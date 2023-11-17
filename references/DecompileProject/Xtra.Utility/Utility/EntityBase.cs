// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.EntityBase
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using System.ComponentModel;

namespace Xtra.Utility
{
  public class EntityBase : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    public void NotifyPropertyChanged(string info)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(info));
    }
  }
}
