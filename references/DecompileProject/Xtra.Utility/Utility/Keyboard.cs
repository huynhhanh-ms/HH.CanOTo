// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.Keyboard
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Xtra.Utility
{
  public abstract class Keyboard
  {
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern short GetKeyState(int keyCode);

    private static Keyboard.KeyStates GetKeyState(Keys key)
    {
      Keyboard.KeyStates keyState1 = Keyboard.KeyStates.None;
      short keyState2 = Keyboard.GetKeyState((int) key);
      if (((int) keyState2 & 32768) == 32768)
        keyState1 |= Keyboard.KeyStates.Down;
      if (((int) keyState2 & 1) == 1)
        keyState1 |= Keyboard.KeyStates.Toggled;
      return keyState1;
    }

    public static bool IsKeyDown(Keys key) => Keyboard.KeyStates.Down == (Keyboard.GetKeyState(key) & Keyboard.KeyStates.Down);

    public static bool IsKeyToggled(Keys key) => Keyboard.KeyStates.Toggled == (Keyboard.GetKeyState(key) & Keyboard.KeyStates.Toggled);

    [Flags]
    private enum KeyStates
    {
      None = 0,
      Down = 1,
      Toggled = 2,
    }
  }
}
