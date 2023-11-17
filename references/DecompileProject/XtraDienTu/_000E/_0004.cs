// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace \u000E
{
  internal class \u0004 : \u0005.\u0006
  {
    private new const string \u0001 = "{bf13b64c-b3d2-4165-b3f5-7f852d4744cf}";
    private const string \u0002 = "{07572d6f-5375-47d5-8a8c-b5f0cbe5bad0}";
    private const string \u0003 = "{6d3806d4-1193-4601-a7df-2249c7f0014b}";
    private const string \u0004 = "{d316c294-ed40-4778-8b7b-29800a2dcbc3}";
    private const string \u0005 = "{a9035fc5-7ed1-4e0c-8962-dfcb1d508afc}";
    private const string \u0006 = "{73fbfb9b-41e7-4744-bf74-74b7c6c117c1}";
    private const string \u0007 = "SmartAssembly.exe";
    private readonly Exception \u0008;
    private readonly Guid \u000E;
    private readonly char[] \u000F = new char[0];
    private readonly Dictionary<string, object> \u0010 = new Dictionary<string, object>();
    private readonly Dictionary<string, \u000E.\u0004.\u0001> \u0011 = new Dictionary<string, \u000E.\u0004.\u0001>();
    private readonly XmlWriter \u0012;
    private readonly List<\u0008.\u000F> \u0013 = new List<\u0008.\u000F>();
    private readonly List<string> \u0014 = new List<string>();
    private readonly Dictionary<string, int> \u0015 = new Dictionary<string, int>();
    private readonly List<\u000E.\u0004.\u0002> \u0016 = new List<\u000E.\u0004.\u0002>();
    private readonly Dictionary<string, int> \u0017 = new Dictionary<string, int>();
    private readonly MemoryStream \u0018;
    private byte[] \u0019;
    private \u000E.\u0005 \u001A;
    private EventHandler \u001B;

    public \u0004(Guid userId, Exception currentException, IWebProxy proxy)
    {
      this.\u000E = userId;
      this.\u0008 = currentException;
      this.\u0018 = new MemoryStream();
      this.\u0012 = (XmlWriter) new XmlTextWriter((Stream) this.\u0018, (Encoding) new UTF8Encoding(false));
      this.\u0001(proxy);
      string upper;
      if ((upper = \u0005.\u0004.\u0001(16009).ToUpper()) == null)
        return;
      if (!(upper == \u0005.\u0004.\u0001(16022)))
      {
        if (!(upper == \u0005.\u0004.\u0001(16009)))
          return;
        this.\u000F = new char[58]
        {
          '\u0001',
          '\u0002',
          '\u0003',
          '\u0004',
          '\u0005',
          '\u0006',
          '\a',
          '\b',
          '\u000E',
          '\u000F',
          '\u0010',
          '\u0011',
          '\u0012',
          '\u0013',
          '\u0014',
          '\u0015',
          '\u0016',
          '\u0017',
          '\u0018',
          '\u0019',
          '\u001A',
          '\u001B',
          '\u001C',
          '\u001D',
          '\u001E',
          '\u001F',
          '\u007F',
          '\u0080',
          '\u0081',
          '\u0082',
          '\u0083',
          '\u0084',
          '\u0086',
          '\u0087',
          '\u0088',
          '\u0089',
          '\u008A',
          '\u008B',
          '\u008C',
          '\u008D',
          '\u008E',
          '\u008F',
          '\u0090',
          '\u0091',
          '\u0092',
          '\u0093',
          '\u0094',
          '\u0095',
          '\u0096',
          '\u0097',
          '\u0098',
          '\u0099',
          '\u009A',
          '\u009B',
          '\u009C',
          '\u009D',
          '\u009E',
          '\u009F'
        };
      }
      else
        this.\u000F = new char[62]
        {
          'a',
          'b',
          'c',
          'd',
          'e',
          'f',
          'g',
          'h',
          'i',
          'j',
          'k',
          'l',
          'm',
          'n',
          'o',
          'p',
          'q',
          'r',
          's',
          't',
          'u',
          'v',
          'w',
          'x',
          'y',
          'z',
          'A',
          'B',
          'C',
          'D',
          'E',
          'F',
          'G',
          'H',
          'I',
          'J',
          'K',
          'L',
          'M',
          'N',
          'O',
          'P',
          'Q',
          'R',
          'S',
          'T',
          'U',
          'V',
          'W',
          'X',
          'Y',
          'Z',
          '0',
          '1',
          '2',
          '3',
          '4',
          '5',
          '6',
          '7',
          '8',
          '9'
        };
    }

    private static unsafe string \u0001(object _param0)
    {
      string empty;
      do
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(46);
        try
        {
          if (_param0 == null)
          {
            empty = string.Empty;
            goto label_23;
          }
          else
          {
            if (!(_param0 is int num7))
            {
              switch (_param0)
              {
                case long num1:
                  *(long*) voidPtr = num1;
                  empty = ((long*) voidPtr)->ToString(\u0005.\u0004.\u0001(16031));
                  goto label_23;
                case short _:
label_5:
                  *(short*) ((IntPtr) voidPtr + 40) = (short) _param0;
                  empty = ((short*) ((IntPtr) voidPtr + 40))->ToString(\u0005.\u0004.\u0001(16031));
                  goto label_23;
                case uint num2:
                  *(int*) ((IntPtr) voidPtr + 36) = (int) num2;
                  empty = ((uint*) ((IntPtr) voidPtr + 36))->ToString(\u0005.\u0004.\u0001(16031));
                  goto label_23;
                case ulong num3:
                  *(long*) ((IntPtr) voidPtr + 8) = (long) num3;
                  do
                  {
                    empty = ((ulong*) ((IntPtr) voidPtr + 8))->ToString(\u0005.\u0004.\u0001(16031));
                  }
                  while (false);
                  goto label_23;
                case ushort _:
label_9:
                  *(short*) ((IntPtr) voidPtr + 42) = (short) (ushort) _param0;
                  empty = ((ushort*) ((IntPtr) voidPtr + 42))->ToString(\u0005.\u0004.\u0001(16031));
                  goto label_23;
                case byte num4:
                  *(sbyte*) ((IntPtr) voidPtr + 44) = (sbyte) num4;
                  empty = ((byte*) ((IntPtr) voidPtr + 44))->ToString(\u0005.\u0004.\u0001(16031));
                  goto label_23;
                case sbyte num5:
                  *(sbyte*) ((IntPtr) voidPtr + 45) = num5;
                  if (true)
                  {
                    empty = ((sbyte*) ((IntPtr) voidPtr + 45))->ToString(\u0005.\u0004.\u0001(16031));
                    goto label_23;
                  }
                  else
                    break;
                case IntPtr num6:
                  *(long*) ((IntPtr) voidPtr + 16) = num6.ToInt64();
                  empty = ((long*) ((IntPtr) voidPtr + 16))->ToString(\u0005.\u0004.\u0001(16031));
                  if (false)
                    goto label_23;
                  else
                    goto label_23;
                case UIntPtr _:
                  if (true)
                  {
                    UIntPtr num = (UIntPtr) _param0;
                    if (true)
                    {
                      *(long*) ((IntPtr) voidPtr + 24) = (long) num.ToUInt64();
                      empty = ((ulong*) ((IntPtr) voidPtr + 24))->ToString(\u0005.\u0004.\u0001(16031));
                      goto label_23;
                    }
                    else
                      goto label_9;
                  }
                  else
                    goto label_5;
                default:
                  goto label_21;
              }
            }
            else
              *(int*) ((IntPtr) voidPtr + 32) = num7;
            empty = ((int*) ((IntPtr) voidPtr + 32))->ToString(\u0005.\u0004.\u0001(16031));
            goto label_23;
          }
        }
        catch
        {
        }
label_21:;
      }
      while (false);
      return string.Empty;
label_23:
      return empty;
    }

    private static string \u0001(string _param0)
    {
      while (_param0.StartsWith(\u0005.\u0004.\u0001(16036)))
      {
label_2:
        if (true)
        {
          int num;
          for (int index = _param0.EndsWith(\u0005.\u0004.\u0001(16057)) ? 1 : 0; index != 0; index = num)
          {
            if (true)
            {
              num = 16078;
              if (num != 0)
                return \u0005.\u0004.\u0001(num);
            }
            else
              goto label_2;
          }
          break;
        }
      }
      return _param0;
    }

    private unsafe void \u0001(\u0008.\u000F _param1, FieldInfo _param2)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(8);
      string name1 = (object) _param2 == null ? (string) null : _param2.Name;
      string name2 = (object) _param2 == null ? \u0005.\u0004.\u0001(16160) : \u0005.\u0004.\u0001(16151);
      object obj = _param1.\u0001();
      if (obj == null)
      {
        using (new \u0003.\u0007(this.\u0012, name2))
        {
          if ((object) _param2 != null)
          {
            if (_param2.IsStatic)
              this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16169), \u0005.\u0004.\u0001(16178));
            Type fieldType = _param2.FieldType;
            if ((object) fieldType != null && fieldType.HasElementType)
            {
              this.\u0001(fieldType.GetElementType());
              if (fieldType.IsByRef)
                this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16183), \u0005.\u0004.\u0001(16178));
              if (fieldType.IsPointer)
                this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16192), \u0005.\u0004.\u0001(16178));
              if (fieldType.IsArray)
              {
                XmlWriter xmlWriter = this.\u0012;
                string localName = \u0005.\u0004.\u0001(16205);
                *(int*) ((IntPtr) voidPtr + 4) = fieldType.GetArrayRank();
                string str = ((int*) ((IntPtr) voidPtr + 4))->ToString();
                xmlWriter.WriteAttributeString(localName, str);
              }
            }
            else
              this.\u0001(fieldType);
          }
          if (name1 != null)
            this.\u0001(name1);
          this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16214), \u0005.\u0004.\u0001(16178));
        }
      }
      else
      {
        Type type = _param1.\u0001().GetType();
        string str1 = (string) null;
        string str2 = (string) null;
        if (obj is string)
          str1 = \u0005.\u0004.\u0001(16223);
        if (str1 == null)
        {
          if (type.IsPrimitive || obj is IntPtr || obj is UIntPtr)
          {
            str1 = type.FullName;
            if (obj is char ch)
            {
              *(int*) voidPtr = (int) ch;
              StringBuilder stringBuilder = new StringBuilder();
              if (*(int*) voidPtr >= 32)
              {
                stringBuilder.Append('\'');
                stringBuilder.Append((char) obj);
                stringBuilder.Append(\u0005.\u0004.\u0001(16244));
              }
              stringBuilder.Append(\u0005.\u0004.\u0001(16249));
              stringBuilder.Append(((int*) voidPtr)->ToString(\u0005.\u0004.\u0001(16031)));
              stringBuilder.Append(')');
              str2 = stringBuilder.ToString();
            }
            if (obj is bool)
              str2 = obj.ToString().ToLower();
            if (str2 == null)
            {
              string str3 = \u000E.\u0004.\u0001(obj);
              if (str3.Length > 0)
              {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(obj.ToString());
                stringBuilder.Append(\u0005.\u0004.\u0001(16254));
                stringBuilder.Append(str3);
                stringBuilder.Append(')');
                str2 = stringBuilder.ToString();
              }
              else
                str2 = obj.ToString();
            }
          }
          else if (type.IsValueType && (object) type.Module != (object) this.GetType().Module)
            str1 = type.FullName;
        }
        using (new \u0003.\u0007(this.\u0012, name2))
        {
          if ((object) _param2 != null && _param2.IsStatic)
            this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16169), \u0005.\u0004.\u0001(16178));
          if (str1 != null)
          {
            this.\u0001(type);
            if (name1 != null)
              this.\u0001(name1);
            if (type.IsEnum)
              str2 = obj.ToString();
            if (obj is Guid)
              str2 = \u0005.\u0004.\u0001(15255) + obj + \u0005.\u0004.\u0001(16263);
            if (str2 == null)
              str2 = \u0005.\u0004.\u0001(16268) + obj + \u0005.\u0004.\u0001(16268);
            this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16273), \u000E.\u0004.\u0001(str2));
          }
          else
          {
            if ((object) _param2 != null)
              this.\u0001(_param2.FieldType);
            this.\u0001(_param1);
            if (name1 == null)
              return;
            this.\u0001(name1);
          }
        }
      }
    }

    private unsafe void \u0001(\u0008.\u000F _param1)
    {
      void* voidPtr;
      do
      {
        // ISSUE: untyped stack allocation
        voidPtr = (void*) __untypedstackalloc(8);
      }
      while (false);
      object objB = _param1.\u0001();
      do
      {
        *(int*) voidPtr = -1;
      }
      while (false);
      *(int*) ((IntPtr) voidPtr + 4) = 0;
      while (*(int*) ((IntPtr) voidPtr + 4) < this.\u0013.Count)
      {
        if (object.ReferenceEquals(this.\u0013[*(int*) ((IntPtr) voidPtr + 4)].\u0001(), objB))
        {
          *(int*) voidPtr = *(int*) ((IntPtr) voidPtr + 4);
          if (false)
            goto label_6;
          else
            break;
        }
        else
          *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
      }
      if (*(int*) voidPtr == -1)
        *(int*) voidPtr = this.\u0013.Count;
      else
        goto label_7;
label_6:
      this.\u0013.Add(_param1);
label_7:
      this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16282), ((int*) voidPtr)->ToString());
    }

    private void \u0001(string _param1)
    {
      int num1 = this.\u0001(_param1);
      if (false)
        goto label_2;
      else
        goto label_5;
label_1:
      int num2;
      if (true)
        num1 = num2;
      else
        goto label_7;
label_2:
      if (num1 == -1)
      {
        if (true)
        {
          this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16296), _param1);
          return;
        }
        goto label_1;
      }
      else
        goto label_7;
label_5:
      num2 = num1;
      goto label_1;
label_7:
      this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16287), num2.ToString());
    }

    private static \u000E.\u0004.\u0003 \u0001(Type _param0)
    {
label_0:
      \u000E.\u0004.\u0003 empty;
      while (true)
      {
        empty = \u000E.\u0004.\u0003.Empty;
        if ((object) _param0 != null)
        {
          while ((object) _param0.Assembly.GetType(\u0005.\u0004.\u0001(16305)) != null)
          {
            if (true)
            {
              if (true)
              {
                empty.\u0001 = ((_param0.MetadataToken & 16777215) - 1).ToString();
                Assembly assembly = _param0.Assembly;
                if (true)
                {
                  empty.\u0002 = new \u000E.\u0004.\u0002(assembly.ManifestModule.ModuleVersionId.ToString(\u0005.\u0004.\u0001(16366)), assembly.FullName);
                  break;
                }
              }
            }
            else
              goto label_0;
          }
          break;
        }
        break;
      }
      return empty;
    }

    private int \u0001(\u000E.\u0004.\u0003 _param1)
    {
      string upper = _param1.\u0002.\u0001.ToUpper();
      if (true)
      {
        int num1 = this.\u0017.ContainsKey(upper) ? 1 : 0;
        if (true)
        {
          if (num1 == 0)
            goto label_9;
          else
            goto label_8;
        }
        else
          goto label_6;
label_3:
        if (true)
        {
          int num2 = num1;
          this.\u0016.Add(_param1.\u0002);
          this.\u0017.Add(upper, num2);
          if (true)
            num1 = num2;
          else
            goto label_9;
        }
label_6:
        if (true)
          return num1;
        goto label_3;
label_9:
        num1 = this.\u0016.Count;
        goto label_3;
      }
label_8:
      return this.\u0017[upper];
    }

    private unsafe void \u0001(Type _param1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(12);
      if ((object) _param1 == null)
        return;
      try
      {
        \u000E.\u0004.\u0003 obj = \u000E.\u0004.\u0001(_param1);
        if (obj.IsEmpty)
        {
          string fullName = _param1.FullName;
          if (this.\u0015.ContainsKey(fullName))
          {
            *(int*) ((IntPtr) voidPtr + 4) = this.\u0015[fullName];
          }
          else
          {
            StringBuilder stringBuilder = new StringBuilder();
            string name = _param1.Assembly.GetName().Name;
            if (name.Length > 0 && name != \u0005.\u0004.\u0001(16397))
            {
              stringBuilder.Append('[');
              stringBuilder.Append(name);
              stringBuilder.Append(']');
            }
            string str1 = _param1.Namespace;
            if (str1.Length > 0)
            {
              stringBuilder.Append(str1);
              stringBuilder.Append('.');
            }
            if (_param1.HasElementType)
              _param1 = _param1.GetElementType();
            *(int*) ((IntPtr) voidPtr + 8) = fullName.LastIndexOf(\u0005.\u0004.\u0001(16410));
            if (*(int*) ((IntPtr) voidPtr + 8) > 0)
            {
              string str2 = fullName.Substring(str1.Length + 1, *(int*) ((IntPtr) voidPtr + 8) - str1.Length).Replace(\u0005.\u0004.\u0001(16410), \u0005.\u0004.\u0001(4107));
              stringBuilder.Append(str2);
            }
            stringBuilder.Append(_param1.Name);
            *(int*) ((IntPtr) voidPtr + 4) = this.\u0014.Count;
            this.\u0014.Add(stringBuilder.ToString());
            this.\u0015.Add(fullName, *(int*) ((IntPtr) voidPtr + 4));
          }
          this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16415), ((int*) ((IntPtr) voidPtr + 4))->ToString());
        }
        else
        {
          this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16371), obj.\u0001);
          *(int*) voidPtr = this.\u0001(obj);
          if (*(int*) voidPtr <= 0)
            return;
          this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16384), ((int*) voidPtr)->ToString());
        }
      }
      catch
      {
      }
    }

    private unsafe int \u0001(string _param1)
    {
      int num1 = 18;
      int num2;
      while (true)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(num1);
        try
        {
          *(sbyte*) ((IntPtr) voidPtr + 16) = (sbyte) (this.\u000F[0] == '\u0001');
          if (_param1 != null)
            goto label_20;
label_5:
          *(int*) ((IntPtr) voidPtr + 12) = -1;
          goto label_22;
label_20:
          int num3;
          for (int index = _param1.Length; index != 0 && (*(sbyte*) ((IntPtr) voidPtr + 16) == (sbyte) 0 || _param1.Length <= 4) && (*(sbyte*) ((IntPtr) voidPtr + 16) != (sbyte) 0 || _param1[0] == '#'); index = num3)
          {
            *(int*) voidPtr = 0;
            *(int*) ((IntPtr) voidPtr + 4) = _param1.Length - 1;
            while (*(int*) ((IntPtr) voidPtr + 4) >= 0 && (*(sbyte*) ((IntPtr) voidPtr + 16) != (sbyte) 0 || *(int*) ((IntPtr) voidPtr + 4) != 0))
            {
              char ch = _param1[*(int*) ((IntPtr) voidPtr + 4)];
              *(sbyte*) ((IntPtr) voidPtr + 17) = (sbyte) 0;
              *(int*) ((IntPtr) voidPtr + 8) = 0;
              while (true)
              {
                num3 = *(int*) ((IntPtr) voidPtr + 8);
                if (true)
                {
                  int length = this.\u000F.Length;
                  if (num3 < length)
                  {
                    if ((int) this.\u000F[*(int*) ((IntPtr) voidPtr + 8)] != (int) ch)
                      *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
                    else
                      break;
                  }
                  else
                    goto label_13;
                }
                else
                  break;
              }
              *(int*) voidPtr = *(int*) voidPtr * this.\u000F.Length + *(int*) ((IntPtr) voidPtr + 8);
              *(sbyte*) ((IntPtr) voidPtr + 17) = (sbyte) 1;
label_13:
              if (true)
              {
                if (*(sbyte*) ((IntPtr) voidPtr + 17) == (sbyte) 0)
                {
                  *(int*) ((IntPtr) voidPtr + 12) = -1;
                  goto label_22;
                }
                else
                  *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) - 1;
              }
              else
                goto label_22;
            }
            *(int*) ((IntPtr) voidPtr + 12) = *(int*) voidPtr;
            goto label_22;
          }
          goto label_5;
        }
        catch
        {
          *(int*) ((IntPtr) voidPtr + 12) = -1;
        }
label_22:
        num2 = *(int*) ((IntPtr) voidPtr + 12);
        if (false)
          num1 = num2;
        else
          break;
      }
      return num2;
    }

    private static string \u0001()
    {
      string str;
      try
      {
        str = Application.ExecutablePath;
      }
      catch
      {
        str = \u0005.\u0004.\u0001(16428);
      }
      return str;
    }

    private Assembly[] \u0001()
    {
      Assembly[] assemblyArray;
      try
      {
        do
        {
          assemblyArray = AppDomain.CurrentDomain.GetAssemblies();
        }
        while (false);
      }
      catch
      {
        assemblyArray = new Assembly[1]{ \u000E.\u0004.\u0001() };
      }
      return assemblyArray;
    }

    private static Assembly \u0001()
    {
      Assembly assembly;
      try
      {
        assembly = Assembly.GetExecutingAssembly();
      }
      catch
      {
        assembly = (Assembly) null;
      }
      return assembly;
    }

    internal byte[] \u0001() => this.\u0002();

    private unsafe byte[] \u0002()
    {
      // ISSUE: untyped stack allocation
      IntPtr num = __untypedstackalloc(52);
      void* voidPtr;
      if (true)
        voidPtr = (void*) num;
      if (this.\u0019 != null)
        return this.\u0019;
      this.\u0012.WriteStartDocument();
      using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16433)))
      {
        this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16466), \u0005.\u0004.\u0001(15951).ToUpper());
        this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16483), DateTime.Now.ToString(\u0005.\u0004.\u0001(16496)));
        this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(15180), \u000E.\u0004.\u0001());
        if (this.\u000E != Guid.Empty)
          this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16501), this.\u000E.ToString(\u0005.\u0004.\u0001(16366)));
        this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16510), Guid.NewGuid().ToString(\u0005.\u0004.\u0001(16366)));
        if (this.\u0016.Count > 0)
          this.\u0016.Clear();
        this.\u0016.Add(new \u000E.\u0004.\u0002(\u0005.\u0004.\u0001(15951), string.Empty));
        if (this.\u0017.Count > 0)
          this.\u0017.Clear();
        this.\u0017.Add(\u0005.\u0004.\u0001(15951), 0);
        using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16523)))
        {
          Assembly assembly1 = \u000E.\u0004.\u0001();
          Assembly[] assemblyArray = this.\u0001();
          *(int*) ((IntPtr) voidPtr + 32) = 0;
          while (*(int*) ((IntPtr) voidPtr + 32) < assemblyArray.Length)
          {
            Assembly assembly2 = assemblyArray[*(int*) ((IntPtr) voidPtr + 32)];
            if ((object) assembly2 != null)
            {
              using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16384)))
              {
                try
                {
                  this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16296), assembly2.FullName);
                  this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16540), assembly2.CodeBase);
                  if ((object) assembly2 == (object) assembly1)
                    this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16553), \u0005.\u0004.\u0001(16178));
                }
                catch
                {
                }
              }
            }
            *(int*) ((IntPtr) voidPtr + 32) = *(int*) ((IntPtr) voidPtr + 32) + 1;
          }
        }
        using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16562)))
        {
          if (this.\u0010 != null)
          {
            if (this.\u0010.Count > 0)
            {
              foreach (string key in this.\u0010.Keys)
              {
                using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16587)))
                {
                  this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16296), key);
                  string str = (string) this.\u0010[key];
                  if (str == null)
                    this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16214), \u0005.\u0004.\u0001(16178));
                  else
                    this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16273), \u0005.\u0004.\u0001(16268) + str + \u0005.\u0004.\u0001(16268));
                }
              }
            }
          }
        }
        if (this.\u0011 != null && this.\u0011.Count > 0)
        {
          using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16608)))
          {
            foreach (string key in this.\u0011.Keys)
            {
              using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16629)))
              {
                this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16646), key);
                \u000E.\u0004.\u0001 obj = this.\u0011[key];
                this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16651), obj.\u0001);
                XmlWriter xmlWriter = this.\u0012;
                string localName = \u0005.\u0004.\u0001(16664);
                *(int*) ((IntPtr) voidPtr + 36) = obj.\u0004;
                string str = ((int*) ((IntPtr) voidPtr + 36))->ToString();
                xmlWriter.WriteAttributeString(localName, str);
                if (obj.\u0003.Length > 0)
                  this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16673), obj.\u0003);
                else
                  this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16682), obj.\u0002);
              }
            }
          }
        }
        using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16691)))
        {
          try
          {
            this.\u0012.WriteElementString(\u0005.\u0004.\u0001(16716), Environment.Version.ToString());
            this.\u0012.WriteElementString(\u0005.\u0004.\u0001(16733), Environment.OSVersion.Version.ToString());
            this.\u0012.WriteElementString(\u0005.\u0004.\u0001(16746), Environment.OSVersion.Platform.ToString());
            this.\u0012.WriteElementString(\u0005.\u0004.\u0001(16763), \u0008.\u0010.ServicePack);
            this.\u0012.WriteElementString(\u0005.\u0004.\u0001(16780), \u0008.\u0010.IsServerR2 ? \u0005.\u0004.\u0001(16178) : \u0005.\u0004.\u0001(6532));
            this.\u0012.WriteElementString(\u0005.\u0004.\u0001(16793), \u0008.\u0010.IsX64 ? \u0005.\u0004.\u0001(16178) : \u0005.\u0004.\u0001(6532));
            this.\u0012.WriteElementString(\u0005.\u0004.\u0001(16798), \u0008.\u0010.IsWorkstation ? \u0005.\u0004.\u0001(16178) : \u0005.\u0004.\u0001(6532));
          }
          catch
          {
          }
        }
        List<Exception> exceptionList = new List<Exception>();
        for (Exception innerException = this.\u0008; innerException != null; innerException = innerException.InnerException)
          exceptionList.Add(innerException);
        exceptionList.Reverse();
        using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16815)))
        {
          foreach (Exception exception in exceptionList)
          {
            try
            {
              this.\u0001(exception);
              if (exception.Data.Contains((object) \u0005.\u0004.\u0001(16832)))
              {
                ICollection collection = (ICollection) exception.Data[(object) \u0005.\u0004.\u0001(16832)];
                *(int*) voidPtr = collection.Count;
                *(int*) ((IntPtr) voidPtr + 4) = 0;
                foreach (object obj1 in (IEnumerable) collection)
                {
                  try
                  {
                    Type type = obj1.GetType();
                    *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
                    if (*(int*) ((IntPtr) voidPtr + 4) > 100 && *(int*) ((IntPtr) voidPtr + 4) == *(int*) voidPtr - 100)
                    {
                      using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16857)))
                        this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16878), ((int*) voidPtr)->ToString());
                    }
                    else
                    {
                      if (*(int*) ((IntPtr) voidPtr + 4) > 100)
                      {
                        if (*(int*) ((IntPtr) voidPtr + 4) <= *(int*) voidPtr - 100)
                          continue;
                      }
                      *(int*) ((IntPtr) voidPtr + 8) = (int) type.GetField(\u0005.\u0004.\u0001(16903)).GetValue(obj1);
                      *(int*) ((IntPtr) voidPtr + 12) = (int) type.GetField(\u0005.\u0004.\u0001(16916)).GetValue(obj1);
                      *(int*) ((IntPtr) voidPtr + 16) = (int) type.GetField(\u0005.\u0004.\u0001(16929)).GetValue(obj1);
                      object[] objArray1 = (object[]) type.GetField(\u0005.\u0004.\u0001(16958)).GetValue(obj1);
                      \u000E.\u0004.\u0003 obj2 = \u000E.\u0004.\u0001(type);
                      if (!obj2.IsEmpty)
                      {
                        using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16971)))
                        {
                          this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16903), ((int*) ((IntPtr) voidPtr + 8))->ToString());
                          this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16929), ((int*) ((IntPtr) voidPtr + 16))->ToString());
                          *(int*) ((IntPtr) voidPtr + 20) = this.\u0001(obj2);
                          if (*(int*) ((IntPtr) voidPtr + 20) > 0)
                            this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16384), ((int*) ((IntPtr) voidPtr + 20))->ToString());
                          if (*(int*) ((IntPtr) voidPtr + 12) != -1)
                            this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16916), ((int*) ((IntPtr) voidPtr + 12))->ToString());
                          object[] objArray2 = objArray1;
                          *(int*) ((IntPtr) voidPtr + 40) = 0;
                          while (*(int*) ((IntPtr) voidPtr + 40) < objArray2.Length)
                          {
                            object o = objArray2[*(int*) ((IntPtr) voidPtr + 40)];
                            try
                            {
                              this.\u0001(new \u0008.\u000F(o, true), (FieldInfo) null);
                            }
                            catch
                            {
                            }
                            *(int*) ((IntPtr) voidPtr + 40) = *(int*) ((IntPtr) voidPtr + 40) + 1;
                          }
                        }
                      }
                    }
                  }
                  catch
                  {
                  }
                }
              }
            }
            catch
            {
            }
          }
        }
        this.\u0001();
        using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16988)))
        {
          XmlWriter xmlWriter = this.\u0012;
          string localName = \u0005.\u0004.\u0001(17001);
          *(int*) ((IntPtr) voidPtr + 44) = this.\u0014.Count;
          string str1 = ((int*) ((IntPtr) voidPtr + 44))->ToString();
          xmlWriter.WriteAttributeString(localName, str1);
          *(int*) ((IntPtr) voidPtr + 24) = 0;
          while (*(int*) ((IntPtr) voidPtr + 24) < this.\u0014.Count)
          {
            string str2;
            try
            {
              str2 = this.\u0014[*(int*) ((IntPtr) voidPtr + 24)].ToString();
            }
            catch (Exception ex)
            {
              str2 = '"'.ToString() + ex.Message + (object) '"';
            }
            this.\u0012.WriteElementString(\u0005.\u0004.\u0001(16415), str2);
            *(int*) ((IntPtr) voidPtr + 24) = *(int*) ((IntPtr) voidPtr + 24) + 1;
          }
        }
        using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(17010)))
        {
          XmlWriter xmlWriter = this.\u0012;
          string localName = \u0005.\u0004.\u0001(17001);
          *(int*) ((IntPtr) voidPtr + 48) = this.\u0016.Count;
          string str = ((int*) ((IntPtr) voidPtr + 48))->ToString();
          xmlWriter.WriteAttributeString(localName, str);
          *(int*) ((IntPtr) voidPtr + 28) = 0;
          while (*(int*) ((IntPtr) voidPtr + 28) < this.\u0016.Count)
          {
            using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16466)))
            {
              \u000E.\u0004.\u0002 obj = this.\u0016[*(int*) ((IntPtr) voidPtr + 28)];
              this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16282), obj.\u0001);
              if (obj.\u0002.Length > 0)
                this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(17027), obj.\u0002);
            }
            *(int*) ((IntPtr) voidPtr + 28) = *(int*) ((IntPtr) voidPtr + 28) + 1;
          }
        }
      }
      this.\u0012.WriteEndDocument();
      this.\u0012.Flush();
      this.\u0018.Flush();
      this.\u0019 = this.\u0018.ToArray();
      return this.\u0019;
    }

    private unsafe void \u0001()
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(33);
      using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16958)))
      {
        *(int*) voidPtr = 0;
        while (*(int*) voidPtr < this.\u0013.Count)
        {
          \u0008.\u000F obj1 = this.\u0013[*(int*) voidPtr];
          object obj2 = obj1.\u0001();
          Type enumType = obj1.\u0001();
          using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(17040)))
          {
            this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16282), ((int*) voidPtr)->ToString());
            string str1 = (string) null;
            *(sbyte*) ((IntPtr) voidPtr + 32) = (sbyte) 1;
            string[] strArray = \u0005.\u0004.\u0001(720).Split(',');
            *(int*) ((IntPtr) voidPtr + 20) = 0;
            while (*(int*) ((IntPtr) voidPtr + 20) < strArray.Length)
            {
              string str2 = strArray[*(int*) ((IntPtr) voidPtr + 20)];
              if (str2 != \u0005.\u0004.\u0001(720) && enumType.FullName.StartsWith(str2))
              {
                *(sbyte*) ((IntPtr) voidPtr + 32) = (sbyte) 0;
                break;
              }
              *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) + 1;
            }
            object[] customAttributes = enumType.GetCustomAttributes(true);
            *(int*) ((IntPtr) voidPtr + 24) = 0;
            while (*(int*) ((IntPtr) voidPtr + 24) < customAttributes.Length)
            {
              string name = ((Attribute) customAttributes[*(int*) ((IntPtr) voidPtr + 24)]).GetType().Name;
              if (!(name != \u0005.\u0004.\u0001(17053)) || !(name != \u0005.\u0004.\u0001(17090)))
              {
                *(sbyte*) ((IntPtr) voidPtr + 32) = (sbyte) 0;
                break;
              }
              *(int*) ((IntPtr) voidPtr + 24) = *(int*) ((IntPtr) voidPtr + 24) + 1;
            }
            if (*(sbyte*) ((IntPtr) voidPtr + 32) != (sbyte) 0)
            {
              try
              {
                str1 = obj2.ToString();
                str1 = !(str1 == enumType.FullName) ? (!enumType.IsEnum ? (!(obj2 is Guid) ? \u0005.\u0004.\u0001(16268) + str1 + \u0005.\u0004.\u0001(16268) : \u0005.\u0004.\u0001(15255) + str1 + \u0005.\u0004.\u0001(16263)) : System.Enum.Format(enumType, obj2, \u0005.\u0004.\u0001(17119))) : (string) null;
              }
              catch
              {
              }
              if (str1 != null)
                this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16273), \u000E.\u0004.\u0001(str1));
            }
            if (enumType.HasElementType)
            {
              this.\u0001(enumType.GetElementType());
              if (enumType.IsByRef)
                this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16183), \u0005.\u0004.\u0001(16178));
              if (enumType.IsPointer)
                this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16192), \u0005.\u0004.\u0001(16178));
              if (enumType.IsArray)
              {
                Array array = (Array) obj2;
                XmlWriter xmlWriter = this.\u0012;
                string localName = \u0005.\u0004.\u0001(16205);
                *(int*) ((IntPtr) voidPtr + 28) = array.Rank;
                string str3 = ((int*) ((IntPtr) voidPtr + 28))->ToString();
                xmlWriter.WriteAttributeString(localName, str3);
                StringBuilder stringBuilder = new StringBuilder();
                *(int*) ((IntPtr) voidPtr + 4) = 0;
                while (*(int*) ((IntPtr) voidPtr + 4) < array.Rank)
                {
                  if (*(int*) ((IntPtr) voidPtr + 4) > 0)
                    stringBuilder.Append(',');
                  stringBuilder.Append(array.GetLength(*(int*) ((IntPtr) voidPtr + 4)));
                  *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
                }
                this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(16664), stringBuilder.ToString());
                if (array.Rank == 1)
                {
                  *(int*) ((IntPtr) voidPtr + 8) = array.Length;
                  *(int*) ((IntPtr) voidPtr + 12) = 0;
                  while (*(int*) ((IntPtr) voidPtr + 12) < *(int*) ((IntPtr) voidPtr + 8))
                  {
                    if (*(int*) ((IntPtr) voidPtr + 12) == 10)
                    {
                      if (*(int*) ((IntPtr) voidPtr + 8) > 16)
                        *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 8) - 5;
                    }
                    try
                    {
                      this.\u0001(new \u0008.\u000F(array.GetValue(*(int*) ((IntPtr) voidPtr + 12)), false), (FieldInfo) null);
                    }
                    catch
                    {
                    }
                    *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
                  }
                }
              }
            }
            else
            {
              this.\u0001(enumType);
              if (obj1.FirstLevel)
              {
                if (*(sbyte*) ((IntPtr) voidPtr + 32) != (sbyte) 0)
                {
                  try
                  {
                    if (obj2 is IEnumerable)
                    {
                      using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(17124)))
                      {
                        *(int*) ((IntPtr) voidPtr + 16) = 0;
                        foreach (object o in (IEnumerable) obj2)
                        {
                          if (*(int*) ((IntPtr) voidPtr + 16) > 20)
                          {
                            this.\u0012.WriteElementString(\u0005.\u0004.\u0001(17141), string.Empty);
                            break;
                          }
                          this.\u0001(new \u0008.\u000F(o, false), (FieldInfo) null);
                          *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) + 1;
                        }
                      }
                    }
                  }
                  catch
                  {
                  }
                  this.\u0002(obj1);
                }
              }
            }
          }
          *(int*) voidPtr = *(int*) voidPtr + 1;
        }
      }
    }

    private unsafe void \u0002(\u0008.\u000F _param1)
    {
      // ISSUE: untyped stack allocation
      IntPtr num = __untypedstackalloc(13);
      void* voidPtr;
      if (true)
        voidPtr = (void*) num;
      FieldInfo[] fields = _param1.\u0001().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
      *(int*) voidPtr = 0;
      while (*(int*) voidPtr < fields.Length)
      {
        FieldInfo fieldInfo = fields[*(int*) voidPtr];
        try
        {
          if (!fieldInfo.IsLiteral)
          {
            if (fieldInfo.IsStatic)
            {
              if (fieldInfo.IsInitOnly)
                goto label_14;
            }
            *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 1;
            object[] customAttributes;
            if (true)
            {
              customAttributes = fieldInfo.GetCustomAttributes(true);
              *(int*) ((IntPtr) voidPtr + 4) = 0;
            }
            while (*(int*) ((IntPtr) voidPtr + 4) < customAttributes.Length)
            {
              if (((Attribute) customAttributes[*(int*) ((IntPtr) voidPtr + 4)]).GetType().Name == \u0005.\u0004.\u0001(17090))
              {
                *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 0;
                break;
              }
              *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
            }
            if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
              this.\u0001(new \u0008.\u000F(fieldInfo.GetValue(_param1.\u0001()), false), fieldInfo);
          }
        }
        catch
        {
        }
label_14:
        *(int*) voidPtr = *(int*) voidPtr + 1;
      }
      _param1 = new \u0008.\u000F(_param1.\u0001(), _param1.\u0001().BaseType, _param1.FirstLevel);
      while ((object) _param1.\u0001() != null)
      {
        if (true)
        {
          using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(16151)))
          {
            this.\u0001(\u0005.\u0004.\u0001(17150));
            XmlWriter xmlWriter = this.\u0012;
            string localName = \u0005.\u0004.\u0001(16282);
            *(int*) ((IntPtr) voidPtr + 8) = this.\u0013.Count;
            string str = ((int*) ((IntPtr) voidPtr + 8))->ToString();
            xmlWriter.WriteAttributeString(localName, str);
          }
          this.\u0013.Add(_param1);
          break;
        }
      }
    }

    private void \u0001(Exception _param1)
    {
      using (new \u0003.\u0007(this.\u0012, \u0005.\u0004.\u0001(17159)))
      {
        try
        {
          this.\u0001(_param1.GetType());
          do
          {
            string str = \u0005.\u0004.\u0001(16428);
            try
            {
              str = _param1.Message;
            }
            catch
            {
            }
            this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(17172), str);
          }
          while (false);
          string str1 = _param1.StackTrace.Trim();
          do
          {
            this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(17185), str1);
            int num = str1.IndexOf(' ');
            str1 = str1.Substring(num + 1);
          }
          while (false);
          int length = str1.IndexOf(\u0005.\u0004.\u0001(17214));
          if (length != -1)
            str1 = str1.Substring(0, length);
          this.\u0012.WriteAttributeString(\u0005.\u0004.\u0001(17219), str1);
          this.\u0001(new \u0008.\u000F((object) _param1, true));
        }
        catch
        {
        }
      }
    }

    internal void \u0001(string _param1, object _param2) => this.\u0010.Add(_param1, _param2);

    internal void \u0001(string _param1, string _param2)
    {
label_0:
      while (System.IO.File.Exists(_param2))
      {
        do
        {
          if (true)
          {
            \u000E.\u0004.\u0001 obj1 = new \u000E.\u0004.\u0001(_param2);
            if (true)
            {
              Dictionary<string, \u000E.\u0004.\u0001> dictionary = this.\u0011;
              string key = _param1;
              \u000E.\u0004.\u0001 obj2 = obj1;
              if (true)
                goto label_7;
label_5:
              continue;
label_7:
              dictionary.Add(key, obj2);
              goto label_5;
            }
            else
              goto label_0;
          }
          else
            goto label_0;
        }
        while (false);
        break;
      }
    }

    internal unsafe bool \u0001()
    {
      void* voidPtr;
      do
      {
        // ISSUE: untyped stack allocation
        voidPtr = (void*) __untypedstackalloc(5);
        try
        {
          byte[] numArray;
          do
          {
            this.\u0001(\u000E.\u0007.\u0001);
            try
            {
              numArray = this.\u0002();
            }
            catch (Exception ex)
            {
              *(int*) voidPtr = -1;
              try
              {
                StackTrace stackTrace = new StackTrace(ex);
                if (stackTrace.FrameCount > 0)
                {
                  StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
                  *(int*) voidPtr = frame.GetILOffset();
                }
              }
              catch
              {
              }
              this.\u0001(\u000E.\u0007.\u0001, string.Format(\u0005.\u0004.\u0001(17228), (object) ex.Message, (object) *(int*) voidPtr));
              do
              {
                *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) 0;
              }
              while (false);
              goto label_17;
            }
          }
          while (false);
          \u0005.\u0006.\u0003 obj = new \u0005.\u0006.\u0003(\u0005.\u0004.\u0001(720), \u0005.\u0004.\u0001(720), \u0005.\u0004.\u0001(17261));
          if (true)
            *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) this.\u0001(numArray, obj);
        }
        catch (ThreadAbortException ex)
        {
          if (true)
            *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) 0;
        }
        catch (Exception ex)
        {
          do
          {
            this.\u0001(new \u0001.\u0007(ex));
          }
          while (false);
          *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) 0;
        }
label_17:;
      }
      while (false);
      return (bool) *(sbyte*) ((IntPtr) voidPtr + 4);
    }

    public event \u000E.\u0005 FatalException
    {
      add
      {
        \u000E.\u0005 obj1;
        if (true)
        {
          if (true)
            obj1 = this.\u001A;
        }
        else
          goto label_5;
label_2:
        \u000E.\u0005 comparand;
        if (true)
        {
          \u000E.\u0005 obj2 = obj1;
          if (true)
          {
            comparand = obj2;
            goto label_9;
          }
          else
            goto label_9;
        }
label_4:
        if (obj1 != comparand)
          goto label_2;
label_5:
        if (true)
          return;
label_9:
        obj1 = Interlocked.CompareExchange<\u000E.\u0005>(ref this.\u001A, comparand + value, comparand);
        goto label_4;
      }
      remove
      {
        \u000E.\u0005 obj1;
        if (true)
        {
          if (true)
            obj1 = this.\u001A;
        }
        else
          goto label_5;
label_2:
        \u000E.\u0005 comparand;
        if (true)
        {
          \u000E.\u0005 obj2 = obj1;
          if (true)
          {
            comparand = obj2;
            goto label_9;
          }
          else
            goto label_9;
        }
label_4:
        if (obj1 != comparand)
          goto label_2;
label_5:
        if (true)
          return;
label_9:
        obj1 = Interlocked.CompareExchange<\u000E.\u0005>(ref this.\u001A, comparand - value, comparand);
        goto label_4;
      }
    }

    public void \u0001(\u0001.\u0007 _param1)
    {
      \u000E.\u0005 obj = this.\u001A;
      if (obj == null)
        return;
      obj((object) this, _param1);
    }

    public event EventHandler DebuggerLaunched
    {
      add
      {
        EventHandler eventHandler1;
        if (true)
        {
          if (true)
            eventHandler1 = this.\u001B;
        }
        else
          goto label_5;
label_2:
        EventHandler comparand;
        if (true)
        {
          EventHandler eventHandler2 = eventHandler1;
          if (true)
          {
            comparand = eventHandler2;
            goto label_9;
          }
          else
            goto label_9;
        }
label_4:
        if (eventHandler1 != comparand)
          goto label_2;
label_5:
        if (true)
          return;
label_9:
        eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.\u001B, comparand + value, comparand);
        goto label_4;
      }
      remove
      {
        EventHandler eventHandler1;
        if (true)
        {
          if (true)
            eventHandler1 = this.\u001B;
        }
        else
          goto label_5;
label_2:
        EventHandler comparand;
        if (true)
        {
          EventHandler eventHandler2 = eventHandler1;
          if (true)
          {
            comparand = eventHandler2;
            goto label_9;
          }
          else
            goto label_9;
        }
label_4:
        if (eventHandler1 != comparand)
          goto label_2;
label_5:
        if (true)
          return;
label_9:
        eventHandler1 = Interlocked.CompareExchange<EventHandler>(ref this.\u001B, comparand - value, comparand);
        goto label_4;
      }
    }

    private void \u0002()
    {
      EventHandler eventHandler = this.\u001B;
      if (eventHandler == null)
        return;
      eventHandler((object) this, EventArgs.Empty);
    }

    internal void \u0003()
    {
      try
      {
        string tempFileName = Path.GetTempFileName();
        this.\u0001(tempFileName);
        Process.Start(Path.Combine(\u000E.\u0001.\u0001(), \u0005.\u0004.\u0001(17306)), \u0005.\u0004.\u0001(17331) + tempFileName + \u0005.\u0004.\u0001(16268));
        if (this.\u001B == null)
          return;
        this.\u001B((object) this, EventArgs.Empty);
      }
      catch (ThreadAbortException ex)
      {
      }
      catch (Exception ex)
      {
        do
        {
          this.\u0001(new \u0001.\u0007(ex));
        }
        while (false);
      }
    }

    internal bool \u0001(string _param1)
    {
      bool flag;
      try
      {
        byte[] numArray1 = this.\u0002();
        byte[] numArray2;
        try
        {
          do
          {
            numArray2 = \u000E.\u0003.\u0002(numArray1);
          }
          while (false);
        }
        catch
        {
          numArray2 = (byte[]) null;
        }
        byte[] buffer = \u0007.\u000F.\u0001(numArray2, \u0005.\u0004.\u0001(15576));
        FileStream fileStream = System.IO.File.OpenWrite(_param1);
        if (true)
        {
          byte[] bytes = Encoding.ASCII.GetBytes(\u0005.\u0004.\u0001(15951));
          fileStream.Write(bytes, 0, bytes.Length);
          fileStream.Write(buffer, 0, buffer.Length);
          fileStream.Close();
        }
        flag = true;
      }
      catch (ThreadAbortException ex)
      {
        do
        {
          if (true)
            flag = false;
        }
        while (false);
      }
      catch (Exception ex)
      {
        flag = false;
      }
      return flag;
    }

    private new struct \u0001
    {
      public readonly string \u0001;
      public readonly string \u0002;
      public readonly string \u0003;
      public readonly int \u0004;

      public \u0001(string fileName)
      {
        this.\u0001 = string.Empty;
        this.\u0002 = string.Empty;
        this.\u0003 = string.Empty;
        this.\u0004 = 0;
        try
        {
          FileInfo fileInfo = new FileInfo(fileName);
          this.\u0001 = Path.GetFileName(fileName);
          this.\u0004 = (int) fileInfo.Length;
          byte[] buffer = new byte[this.\u0004];
          using (FileStream fileStream = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
          {
            fileStream.Read(buffer, 0, this.\u0004);
            fileStream.Close();
          }
          byte[] inArray;
          try
          {
            inArray = \u000E.\u0003.\u0002(buffer);
          }
          catch
          {
            inArray = (byte[]) null;
          }
          this.\u0002 = Convert.ToBase64String(inArray);
        }
        catch (Exception ex)
        {
          this.\u0003 = ex.Message;
        }
      }
    }

    private new struct \u0002
    {
      public readonly string \u0001;
      public readonly string \u0002;

      public \u0002(string assemblyID, string assemblyFullName)
      {
        this.\u0001 = assemblyID;
        this.\u0002 = assemblyFullName;
      }
    }

    private new struct \u0003
    {
      public string \u0001;
      public \u000E.\u0004.\u0002 \u0002;

      public bool IsEmpty => this.\u0001.Length == 0;

      public static \u000E.\u0004.\u0003 Empty => new \u000E.\u0004.\u0003(string.Empty, string.Empty, string.Empty);

      private \u0003(string id, string assemblyID, string assemblyFullName)
      {
        this.\u0001 = id;
        this.\u0002 = new \u000E.\u0004.\u0002(assemblyID, assemblyFullName);
      }
    }
  }
}
