// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.IO;
using System.Security.Cryptography;

namespace \u0007
{
  internal class \u000F
  {
    public static string \u0001;

    public static byte[] \u0001(byte[] _param0, string _param1)
    {
      if (_param1.StartsWith(\u0005.\u0004.\u0001(15255)))
      {
        \u000F.\u0001 = \u0005.\u0004.\u0001(15260);
        return (byte[]) null;
      }
      RijndaelManaged rijndaelManaged = (RijndaelManaged) null;
      RSACryptoServiceProvider cryptoServiceProvider = (RSACryptoServiceProvider) null;
      MemoryStream memoryStream = (MemoryStream) null;
      if (true)
        goto label_21;
label_3:
      CryptoStream cryptoStream;
      try
      {
        rijndaelManaged = new RijndaelManaged();
        cryptoServiceProvider = new RSACryptoServiceProvider();
        cryptoServiceProvider.FromXmlString(_param1);
        rijndaelManaged.GenerateKey();
        rijndaelManaged.GenerateIV();
        byte[] numArray1 = new byte[48];
        if (true)
        {
          Buffer.BlockCopy((Array) rijndaelManaged.Key, 0, (Array) numArray1, 0, 32);
          Buffer.BlockCopy((Array) rijndaelManaged.IV, 0, (Array) numArray1, 32, 16);
          memoryStream = new MemoryStream();
          try
          {
            byte[] buffer = cryptoServiceProvider.Encrypt(numArray1, false);
            memoryStream.WriteByte((byte) 1);
            memoryStream.WriteByte(Convert.ToByte(buffer.Length / 8));
            memoryStream.Write(buffer, 0, buffer.Length);
          }
          catch (CryptographicException ex1)
          {
            try
            {
              byte[] numArray2 = new byte[16];
              byte[] numArray3 = new byte[16];
              Buffer.BlockCopy((Array) rijndaelManaged.Key, 0, (Array) numArray2, 0, 16);
              Buffer.BlockCopy((Array) rijndaelManaged.Key, 16, (Array) numArray3, 0, 16);
              byte[] buffer1 = cryptoServiceProvider.Encrypt(numArray2, false);
              byte[] buffer2 = cryptoServiceProvider.Encrypt(numArray3, false);
              byte[] buffer3 = cryptoServiceProvider.Encrypt(rijndaelManaged.IV, false);
              memoryStream.WriteByte((byte) 2);
              memoryStream.WriteByte(Convert.ToByte(buffer1.Length / 8));
              memoryStream.Write(buffer1, 0, buffer1.Length);
              memoryStream.Write(buffer2, 0, buffer2.Length);
              memoryStream.Write(buffer3, 0, buffer3.Length);
            }
            catch (CryptographicException ex2)
            {
              \u000F.\u0001 = \u0005.\u0004.\u0001(15353);
              return (byte[]) null;
            }
          }
          cryptoStream = new CryptoStream((Stream) memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
          cryptoStream.Write(_param0, 0, _param0.Length);
          cryptoStream.FlushFinalBlock();
        }
        return memoryStream.ToArray();
      }
      catch (Exception ex)
      {
        \u000F.\u0001 = \u0005.\u0004.\u0001(15559) + ex.Message;
        return (byte[]) null;
      }
      finally
      {
        rijndaelManaged?.Clear();
        cryptoServiceProvider?.Clear();
        memoryStream?.Close();
        cryptoStream?.Close();
      }
label_21:
      cryptoStream = (CryptoStream) null;
      goto label_3;
    }
  }
}
