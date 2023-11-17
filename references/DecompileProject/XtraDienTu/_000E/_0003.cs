// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace \u000E
{
  internal class \u0003
  {
    public static string \u0001;

    private static unsafe bool \u0001(Assembly _param0, Assembly _param1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      byte[] numArray1;
      byte[] publicKey1;
      try
      {
        do
        {
          publicKey1 = _param0.GetName().GetPublicKey();
          byte[] publicKey2 = _param1.GetName().GetPublicKey();
          if (true)
            goto label_18;
label_3:
          int num1 = numArray1 == null ? 1 : 0;
          while (true)
          {
            int num2 = publicKey1 == null ? 1 : 0;
            if (num1 == num2)
            {
              if (numArray1 != null)
              {
                if (true)
                  *(int*) voidPtr = 0;
                int num3;
                while (true)
                {
                  num3 = *(int*) voidPtr;
                  if (true)
                  {
                    int num4 = numArray1.Length;
                    if (true)
                      num4 = num4;
                    if (num3 < num4)
                    {
                      if ((int) numArray1[*(int*) voidPtr] == (int) publicKey1[*(int*) voidPtr])
                        *(int*) voidPtr = *(int*) voidPtr + 1;
                      else
                        goto label_11;
                    }
                    else
                      goto label_17;
                  }
                  else
                    break;
                }
                num1 = num3;
              }
              else
                goto label_17;
            }
            else
              break;
          }
          continue;
label_18:
          numArray1 = publicKey2;
          goto label_3;
        }
        while (false);
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) 0;
        goto label_20;
label_11:
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) 0;
        goto label_20;
label_17:
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) 1;
      }
      catch (Exception ex)
      {
        byte[] numArray2 = publicKey1;
        byte[] numArray3 = numArray1;
        // ISSUE: variable of a boxed type
        __Boxed<int> local = (ValueType) *(int*) voidPtr;
        Assembly assembly1 = _param0;
        Assembly assembly2 = _param1;
        \u0005.\u0008.\u0001(ex, (object) numArray2, (object) numArray3, (object) local, (object) assembly1, (object) assembly2);
        throw;
      }
label_20:
      return (bool) *(sbyte*) ((IntPtr) voidPtr + 4);
    }

    public static unsafe byte[] \u0001(byte[] _param0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(46);
      \u000E.\u0003.\u000F obj1;
      byte[] numArray1;
      byte[] buffer1;
      byte[] buffer2;
      byte[] numArray2;
      \u000E.\u0003.\u0001 obj2;
      byte[] numArray3;
      \u000E.\u0003.\u0001 obj3;
      byte[] numArray4;
      byte[] numArray5;
      \u0007.\u0008 obj4;
      ICryptoTransform cryptoTransform1;
      byte[] numArray6;
      byte[] numArray7;
      byte[] numArray8;
      \u0005.\u0005 obj5;
      ICryptoTransform cryptoTransform2;
      byte[] numArray9;
      Assembly callingAssembly;
      Assembly executingAssembly;
      try
      {
        callingAssembly = Assembly.GetCallingAssembly();
        executingAssembly = Assembly.GetExecutingAssembly();
        if ((object) callingAssembly != (object) executingAssembly && !\u000E.\u0003.\u0001(executingAssembly, callingAssembly))
          return (byte[]) null;
        obj1 = new \u000E.\u0003.\u000F(_param0);
        numArray1 = new byte[0];
        *(int*) voidPtr = obj1.\u0002();
        if (*(int*) voidPtr == 67324752)
        {
          *(short*) ((IntPtr) voidPtr + 44) = (short) obj1.\u0001();
          *(int*) ((IntPtr) voidPtr + 4) = obj1.\u0001();
          *(int*) ((IntPtr) voidPtr + 8) = obj1.\u0001();
          if (*(int*) voidPtr != 67324752 || *(short*) ((IntPtr) voidPtr + 44) != (short) 20 || *(int*) ((IntPtr) voidPtr + 4) != 0 || *(int*) ((IntPtr) voidPtr + 8) != 8)
            throw new FormatException("Wrong Header Signature");
          obj1.\u0002();
          obj1.\u0002();
          obj1.\u0002();
          *(int*) ((IntPtr) voidPtr + 12) = obj1.\u0002();
          *(int*) ((IntPtr) voidPtr + 16) = obj1.\u0001();
          *(int*) ((IntPtr) voidPtr + 20) = obj1.\u0001();
          if (*(int*) ((IntPtr) voidPtr + 16) > 0)
          {
            buffer1 = new byte[*(int*) ((IntPtr) voidPtr + 16)];
            obj1.Read(buffer1, 0, *(int*) ((IntPtr) voidPtr + 16));
          }
          if (*(int*) ((IntPtr) voidPtr + 20) > 0)
          {
            buffer2 = new byte[*(int*) ((IntPtr) voidPtr + 20)];
            obj1.Read(buffer2, 0, *(int*) ((IntPtr) voidPtr + 20));
          }
          numArray2 = new byte[obj1.Length - obj1.Position];
          obj1.Read(numArray2, 0, numArray2.Length);
          obj2 = new \u000E.\u0003.\u0001(numArray2);
          numArray1 = new byte[*(int*) ((IntPtr) voidPtr + 12)];
          obj2.\u0001(numArray1, 0, numArray1.Length);
          numArray2 = (byte[]) null;
        }
        else
        {
          *(int*) ((IntPtr) voidPtr + 24) = *(int*) voidPtr >> 24;
          *(int*) voidPtr = *(int*) voidPtr - (*(int*) ((IntPtr) voidPtr + 24) << 24);
          if (*(int*) voidPtr != 8223355)
            throw new FormatException("Unknown Header");
          if (*(int*) ((IntPtr) voidPtr + 24) == 1)
          {
            *(int*) ((IntPtr) voidPtr + 28) = obj1.\u0002();
            numArray1 = new byte[*(int*) ((IntPtr) voidPtr + 28)];
            *(int*) ((IntPtr) voidPtr + 32) = 0;
            while (*(int*) ((IntPtr) voidPtr + 32) < *(int*) ((IntPtr) voidPtr + 28))
            {
              *(int*) ((IntPtr) voidPtr + 36) = obj1.\u0002();
              *(int*) ((IntPtr) voidPtr + 40) = obj1.\u0002();
              numArray3 = new byte[*(int*) ((IntPtr) voidPtr + 36)];
              obj1.Read(numArray3, 0, numArray3.Length);
              obj3 = new \u000E.\u0003.\u0001(numArray3);
              obj3.\u0001(numArray1, *(int*) ((IntPtr) voidPtr + 32), *(int*) ((IntPtr) voidPtr + 40));
              *(int*) ((IntPtr) voidPtr + 32) = *(int*) ((IntPtr) voidPtr + 32) + *(int*) ((IntPtr) voidPtr + 40);
            }
          }
          if (*(int*) ((IntPtr) voidPtr + 24) == 2)
          {
            numArray4 = new byte[8]
            {
              (byte) 146,
              (byte) 3,
              (byte) 29,
              (byte) 142,
              (byte) 245,
              (byte) 28,
              (byte) 2,
              (byte) 224
            };
            numArray5 = new byte[8]
            {
              (byte) 143,
              (byte) 95,
              (byte) 3,
              (byte) 158,
              (byte) 155,
              (byte) 200,
              (byte) 19,
              (byte) 133
            };
            obj4 = new \u0007.\u0008();
            try
            {
              cryptoTransform1 = obj4.\u0001(numArray4, numArray5, true);
              try
              {
                numArray6 = cryptoTransform1.TransformFinalBlock(_param0, 4, _param0.Length - 4);
                numArray1 = \u000E.\u0003.\u0001(numArray6);
              }
              finally
              {
                cryptoTransform1?.Dispose();
              }
            }
            finally
            {
              ((IDisposable) obj4)?.Dispose();
            }
          }
          if (*(int*) ((IntPtr) voidPtr + 24) == 3)
          {
            numArray7 = new byte[16]
            {
              (byte) 1,
              (byte) 1,
              (byte) 1,
              (byte) 1,
              (byte) 1,
              (byte) 1,
              (byte) 1,
              (byte) 1,
              (byte) 1,
              (byte) 1,
              (byte) 1,
              (byte) 1,
              (byte) 1,
              (byte) 1,
              (byte) 1,
              (byte) 1
            };
            numArray8 = new byte[16]
            {
              (byte) 2,
              (byte) 2,
              (byte) 2,
              (byte) 2,
              (byte) 2,
              (byte) 2,
              (byte) 2,
              (byte) 2,
              (byte) 2,
              (byte) 2,
              (byte) 2,
              (byte) 2,
              (byte) 2,
              (byte) 2,
              (byte) 2,
              (byte) 2
            };
            obj5 = new \u0005.\u0005();
            try
            {
              cryptoTransform2 = obj5.\u0001(numArray7, numArray8, true);
              try
              {
                numArray9 = cryptoTransform2.TransformFinalBlock(_param0, 4, _param0.Length - 4);
                numArray1 = \u000E.\u0003.\u0001(numArray9);
              }
              finally
              {
                cryptoTransform2?.Dispose();
              }
            }
            finally
            {
              ((IDisposable) obj5)?.Dispose();
            }
          }
        }
        obj1.Close();
        return numArray1;
      }
      catch (Exception ex)
      {
        object[] objArray = new object[33]
        {
          (object) callingAssembly,
          (object) executingAssembly,
          (object) obj1,
          (object) numArray1,
          (object) *(int*) voidPtr,
          (object) *(short*) ((IntPtr) voidPtr + 44),
          (object) *(int*) ((IntPtr) voidPtr + 4),
          (object) *(int*) ((IntPtr) voidPtr + 8),
          (object) *(int*) ((IntPtr) voidPtr + 12),
          (object) *(int*) ((IntPtr) voidPtr + 16),
          (object) *(int*) ((IntPtr) voidPtr + 20),
          (object) buffer1,
          (object) buffer2,
          (object) numArray2,
          (object) obj2,
          (object) *(int*) ((IntPtr) voidPtr + 24),
          (object) *(int*) ((IntPtr) voidPtr + 28),
          (object) *(int*) ((IntPtr) voidPtr + 32),
          (object) *(int*) ((IntPtr) voidPtr + 36),
          (object) *(int*) ((IntPtr) voidPtr + 40),
          (object) obj3,
          (object) numArray3,
          (object) numArray4,
          (object) numArray5,
          (object) obj4,
          (object) cryptoTransform1,
          (object) numArray6,
          (object) numArray7,
          (object) numArray8,
          (object) obj5,
          (object) cryptoTransform2,
          (object) numArray9,
          (object) _param0
        };
        \u0005.\u0008.\u0001(ex, objArray);
        throw;
      }
    }

    public static byte[] \u0002(byte[] _param0)
    {
      byte[] numArray1;
      try
      {
        numArray1 = \u000E.\u0003.\u0001(_param0, 1, (byte[]) null, (byte[]) null);
      }
      catch (Exception ex)
      {
        byte[] numArray2 = _param0;
        \u0005.\u0008.\u0001(ex, (object) numArray2);
        throw;
      }
      return numArray1;
    }

    public static byte[] \u0001(byte[] _param0, byte[] _param1, byte[] _param2)
    {
      byte[] numArray1;
      try
      {
        do
        {
          if (true)
            goto label_2;
label_1:
          continue;
label_2:
          numArray1 = \u000E.\u0003.\u0001(_param0, 2, _param1, _param2);
          goto label_1;
        }
        while (false);
      }
      catch (Exception ex)
      {
        byte[] numArray2 = _param0;
        byte[] numArray3 = _param1;
        byte[] numArray4 = _param2;
        \u0005.\u0008.\u0001(ex, (object) numArray2, (object) numArray3, (object) numArray4);
        throw;
      }
      return numArray1;
    }

    public static byte[] \u0002(byte[] _param0, byte[] _param1, byte[] _param2)
    {
      byte[] numArray1;
      try
      {
        do
        {
          if (true)
            goto label_2;
label_1:
          continue;
label_2:
          numArray1 = \u000E.\u0003.\u0001(_param0, 3, _param1, _param2);
          goto label_1;
        }
        while (false);
      }
      catch (Exception ex)
      {
        byte[] numArray2 = _param0;
        byte[] numArray3 = _param1;
        byte[] numArray4 = _param2;
        \u0005.\u0008.\u0001(ex, (object) numArray2, (object) numArray3, (object) numArray4);
        throw;
      }
      return numArray1;
    }

    private static unsafe byte[] \u0001(
      byte[] _param0,
      int _param1,
      byte[] _param2,
      byte[] _param3)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(64);
      DateTime now;
      uint[] numArray1;
      uint num1;
      int num2;
      int length;
      \u000E.\u0003.\u000F obj1;
      byte[] bytes;
      \u000E.\u0003.\u0006 obj2;
      byte[] buffer1;
      byte[] buffer2;
      byte[] dst;
      \u000E.\u0003.\u0006 obj3;
      byte[] buffer3;
      byte[] buffer4;
      byte[] inputBuffer1;
      \u0007.\u0008 obj4;
      ICryptoTransform cryptoTransform1;
      byte[] buffer5;
      byte[] inputBuffer2;
      \u0005.\u0005 obj5;
      ICryptoTransform cryptoTransform2;
      byte[] buffer6;
      try
      {
        byte[] array;
        try
        {
          obj1 = new \u000E.\u0003.\u000F();
          switch (_param1)
          {
            case 0:
              \u000E.\u0003.\u0006 obj6 = new \u000E.\u0003.\u0006();
              if (true)
                obj2 = obj6;
              now = DateTime.Now;
              do
              {
                *(long*) voidPtr = (long) (uint) ((now.Year - 1980 & (int) sbyte.MaxValue) << 25 | now.Month << 21 | now.Day << 16 | now.Hour << 11 | now.Minute << 5 | now.Second >>> 1);
                numArray1 = new uint[256]
                {
                  0U,
                  1996959894U,
                  3993919788U,
                  2567524794U,
                  124634137U,
                  1886057615U,
                  3915621685U,
                  2657392035U,
                  249268274U,
                  2044508324U,
                  3772115230U,
                  2547177864U,
                  162941995U,
                  2125561021U,
                  3887607047U,
                  2428444049U,
                  498536548U,
                  1789927666U,
                  4089016648U,
                  2227061214U,
                  450548861U,
                  1843258603U,
                  4107580753U,
                  2211677639U,
                  325883990U,
                  1684777152U,
                  4251122042U,
                  2321926636U,
                  335633487U,
                  1661365465U,
                  4195302755U,
                  2366115317U,
                  997073096U,
                  1281953886U,
                  3579855332U,
                  2724688242U,
                  1006888145U,
                  1258607687U,
                  3524101629U,
                  2768942443U,
                  901097722U,
                  1119000684U,
                  3686517206U,
                  2898065728U,
                  853044451U,
                  1172266101U,
                  3705015759U,
                  2882616665U,
                  651767980U,
                  1373503546U,
                  3369554304U,
                  3218104598U,
                  565507253U,
                  1454621731U,
                  3485111705U,
                  3099436303U,
                  671266974U,
                  1594198024U,
                  3322730930U,
                  2970347812U,
                  795835527U,
                  1483230225U,
                  3244367275U,
                  3060149565U,
                  1994146192U,
                  31158534U,
                  2563907772U,
                  4023717930U,
                  1907459465U,
                  112637215U,
                  2680153253U,
                  3904427059U,
                  2013776290U,
                  251722036U,
                  2517215374U,
                  3775830040U,
                  2137656763U,
                  141376813U,
                  2439277719U,
                  3865271297U,
                  1802195444U,
                  476864866U,
                  2238001368U,
                  4066508878U,
                  1812370925U,
                  453092731U,
                  2181625025U,
                  4111451223U,
                  1706088902U,
                  314042704U,
                  2344532202U,
                  4240017532U,
                  1658658271U,
                  366619977U,
                  2362670323U,
                  4224994405U,
                  1303535960U,
                  984961486U,
                  2747007092U,
                  3569037538U,
                  1256170817U,
                  1037604311U,
                  2765210733U,
                  3554079995U,
                  1131014506U,
                  879679996U,
                  2909243462U,
                  3663771856U,
                  1141124467U,
                  855842277U,
                  2852801631U,
                  3708648649U,
                  1342533948U,
                  654459306U,
                  3188396048U,
                  3373015174U,
                  1466479909U,
                  544179635U,
                  3110523913U,
                  3462522015U,
                  1591671054U,
                  702138776U,
                  2966460450U,
                  3352799412U,
                  1504918807U,
                  783551873U,
                  3082640443U,
                  3233442989U,
                  3988292384U,
                  2596254646U,
                  62317068U,
                  1957810842U,
                  3939845945U,
                  2647816111U,
                  81470997U,
                  1943803523U,
                  3814918930U,
                  2489596804U,
                  225274430U,
                  2053790376U,
                  3826175755U,
                  2466906013U,
                  167816743U,
                  2097651377U,
                  4027552580U,
                  2265490386U,
                  503444072U,
                  1762050814U,
                  4150417245U,
                  2154129355U,
                  426522225U,
                  1852507879U,
                  4275313526U,
                  2312317920U,
                  282753626U,
                  1742555852U,
                  4189708143U,
                  2394877945U,
                  397917763U,
                  1622183637U,
                  3604390888U,
                  2714866558U,
                  953729732U,
                  1340076626U,
                  3518719985U,
                  2797360999U,
                  1068828381U,
                  1219638859U,
                  3624741850U,
                  2936675148U,
                  906185462U,
                  1090812512U,
                  3747672003U,
                  2825379669U,
                  829329135U,
                  1181335161U,
                  3412177804U,
                  3160834842U,
                  628085408U,
                  1382605366U,
                  3423369109U,
                  3138078467U,
                  570562233U,
                  1426400815U,
                  3317316542U,
                  2998733608U,
                  733239954U,
                  1555261956U,
                  3268935591U,
                  3050360625U,
                  752459403U,
                  1541320221U,
                  2607071920U,
                  3965973030U,
                  1969922972U,
                  40735498U,
                  2617837225U,
                  3943577151U,
                  1913087877U,
                  83908371U,
                  2512341634U,
                  3803740692U,
                  2075208622U,
                  213261112U,
                  2463272603U,
                  3855990285U,
                  2094854071U,
                  198958881U,
                  2262029012U,
                  4057260610U,
                  1759359992U,
                  534414190U,
                  2176718541U,
                  4139329115U,
                  1873836001U,
                  414664567U,
                  2282248934U,
                  4279200368U,
                  1711684554U,
                  285281116U,
                  2405801727U,
                  4167216745U,
                  1634467795U,
                  376229701U,
                  2685067896U,
                  3608007406U,
                  1308918612U,
                  956543938U,
                  2808555105U,
                  3495958263U,
                  1231636301U,
                  1047427035U,
                  2932959818U,
                  3654703836U,
                  1088359270U,
                  936918000U,
                  2847714899U,
                  3736837829U,
                  1202900863U,
                  817233897U,
                  3183342108U,
                  3401237130U,
                  1404277552U,
                  615818150U,
                  3134207493U,
                  3453421203U,
                  1423857449U,
                  601450431U,
                  3009837614U,
                  3294710456U,
                  1567103746U,
                  711928724U,
                  3020668471U,
                  3272380065U,
                  1510334235U,
                  755167117U
                };
                *(int*) ((IntPtr) voidPtr + 40) = -1;
                num1 = *(uint*) ((IntPtr) voidPtr + 40);
                num2 = 0;
                length = _param0.Length;
                while (--length >= 0)
                  num1 = numArray1[(IntPtr) (uint) (((int) num1 ^ (int) _param0[num2++]) & (int) byte.MaxValue)] ^ num1 >> 8;
                num1 ^= *(uint*) ((IntPtr) voidPtr + 40);
                obj1.\u0002(67324752);
                obj1.\u0001(20);
                if (true)
                {
                  obj1.\u0001(0);
                  obj1.\u0001(8);
                  obj1.\u0002((int) *(long*) voidPtr);
                  obj1.\u0002((int) num1);
                  *(long*) ((IntPtr) voidPtr + 8) = obj1.Position;
                  obj1.\u0002(0);
                  obj1.\u0002(_param0.Length);
                  bytes = Encoding.UTF8.GetBytes("{data}");
                  obj1.\u0001(bytes.Length);
                  obj1.\u0001(0);
                  obj1.Write(bytes, 0, bytes.Length);
                  obj2.\u0001(_param0);
                  while (!obj2.IsNeedingInput)
                  {
                    buffer1 = new byte[512];
                    *(int*) ((IntPtr) voidPtr + 44) = obj2.\u0001(buffer1);
                    if (*(int*) ((IntPtr) voidPtr + 44) > 0)
                      obj1.Write(buffer1, 0, *(int*) ((IntPtr) voidPtr + 44));
                    else
                      break;
                  }
                  obj2.\u0001();
                  while (!obj2.IsFinished)
                  {
                    buffer2 = new byte[512];
                    *(int*) ((IntPtr) voidPtr + 48) = obj2.\u0001(buffer2);
                    if (*(int*) ((IntPtr) voidPtr + 48) > 0)
                      obj1.Write(buffer2, 0, *(int*) ((IntPtr) voidPtr + 48));
                    else
                      break;
                  }
                  *(long*) ((IntPtr) voidPtr + 16) = obj2.TotalOut;
                  obj1.\u0002(33639248);
                  obj1.\u0001(20);
                  obj1.\u0001(20);
                  obj1.\u0001(0);
                  obj1.\u0001(8);
                }
                else
                  goto label_28;
              }
              while (false);
              obj1.\u0002((int) *(long*) voidPtr);
              obj1.\u0002((int) num1);
              obj1.\u0002((int) *(long*) ((IntPtr) voidPtr + 16));
              obj1.\u0002(_param0.Length);
              obj1.\u0001(bytes.Length);
              obj1.\u0001(0);
              obj1.\u0001(0);
              obj1.\u0001(0);
              obj1.\u0001(0);
              obj1.\u0002(0);
              obj1.\u0002(0);
              obj1.Write(bytes, 0, bytes.Length);
              obj1.\u0002(101010256);
              obj1.\u0001(0);
              obj1.\u0001(0);
              obj1.\u0001(1);
              obj1.\u0001(1);
              obj1.\u0002(46 + bytes.Length);
              obj1.\u0002((int) ((long) (30 + bytes.Length) + *(long*) ((IntPtr) voidPtr + 16)));
              obj1.\u0001(0);
              do
              {
                obj1.Seek(*(long*) ((IntPtr) voidPtr + 8), SeekOrigin.Begin);
                obj1.\u0002((int) *(long*) ((IntPtr) voidPtr + 16));
              }
              while (false);
              goto default;
            case 1:
              obj1.\u0002(25000571);
              obj1.\u0002(_param0.Length);
              *(int*) ((IntPtr) voidPtr + 52) = 0;
              while (*(int*) ((IntPtr) voidPtr + 52) < _param0.Length)
              {
                dst = new byte[Math.Min(2097151, _param0.Length - *(int*) ((IntPtr) voidPtr + 52))];
                Buffer.BlockCopy((Array) _param0, *(int*) ((IntPtr) voidPtr + 52), (Array) dst, 0, dst.Length);
                *(long*) ((IntPtr) voidPtr + 24) = obj1.Position;
                obj1.\u0002(0);
                obj1.\u0002(dst.Length);
                obj3 = new \u000E.\u0003.\u0006();
                obj3.\u0001(dst);
                while (!obj3.IsNeedingInput)
                {
                  buffer3 = new byte[512];
                  *(int*) ((IntPtr) voidPtr + 56) = obj3.\u0001(buffer3);
                  if (*(int*) ((IntPtr) voidPtr + 56) > 0)
                    obj1.Write(buffer3, 0, *(int*) ((IntPtr) voidPtr + 56));
                  else
                    break;
                }
                obj3.\u0001();
                while (!obj3.IsFinished)
                {
                  buffer4 = new byte[512];
                  *(int*) ((IntPtr) voidPtr + 60) = obj3.\u0001(buffer4);
                  if (*(int*) ((IntPtr) voidPtr + 60) > 0)
                    obj1.Write(buffer4, 0, *(int*) ((IntPtr) voidPtr + 60));
                  else
                    break;
                }
                *(long*) ((IntPtr) voidPtr + 32) = obj1.Position;
                obj1.Position = *(long*) ((IntPtr) voidPtr + 24);
                obj1.\u0002((int) obj3.TotalOut);
                obj1.Position = *(long*) ((IntPtr) voidPtr + 32);
                *(int*) ((IntPtr) voidPtr + 52) = *(int*) ((IntPtr) voidPtr + 52) + dst.Length;
              }
              goto default;
            case 2:
              obj1.\u0002(41777787);
              break;
            case 3:
              obj1.\u0002(58555003);
              inputBuffer2 = \u000E.\u0003.\u0001(_param0, 1, (byte[]) null, (byte[]) null);
              obj5 = new \u0005.\u0005();
              try
              {
                cryptoTransform2 = obj5.\u0001(_param2, _param3, false);
                try
                {
                  buffer6 = cryptoTransform2.TransformFinalBlock(inputBuffer2, 0, inputBuffer2.Length);
                  obj1.Write(buffer6, 0, buffer6.Length);
                  goto default;
                }
                finally
                {
                  cryptoTransform2?.Dispose();
                }
              }
              finally
              {
                ((IDisposable) obj5)?.Dispose();
              }
            default:
label_46:
              obj1.Flush();
              obj1.Close();
              array = obj1.ToArray();
              goto label_52;
          }
label_28:
          inputBuffer1 = \u000E.\u0003.\u0001(_param0, 1, (byte[]) null, (byte[]) null);
          obj4 = new \u0007.\u0008();
          try
          {
            cryptoTransform1 = obj4.\u0001(_param2, _param3, false);
            try
            {
              buffer5 = cryptoTransform1.TransformFinalBlock(inputBuffer1, 0, inputBuffer1.Length);
              obj1.Write(buffer5, 0, buffer5.Length);
              goto label_46;
            }
            finally
            {
              cryptoTransform1?.Dispose();
            }
          }
          finally
          {
            ((IDisposable) obj4)?.Dispose();
          }
        }
        catch (Exception ex)
        {
          \u000E.\u0003.\u0001 = "ERR 2003: " + ex.Message;
          throw;
        }
label_52:
        return array;
      }
      catch (Exception ex)
      {
        byte[] numArray2;
        object[] objArray = new object[39]
        {
          (object) obj1,
          (object) obj2,
          (object) now,
          (object) *(long*) voidPtr,
          (object) numArray1,
          (object) *(uint*) ((IntPtr) voidPtr + 40),
          (object) num1,
          (object) num2,
          (object) length,
          (object) *(long*) ((IntPtr) voidPtr + 8),
          (object) bytes,
          (object) buffer1,
          (object) *(int*) ((IntPtr) voidPtr + 44),
          (object) buffer2,
          (object) *(int*) ((IntPtr) voidPtr + 48),
          (object) *(long*) ((IntPtr) voidPtr + 16),
          (object) *(int*) ((IntPtr) voidPtr + 52),
          (object) dst,
          (object) *(long*) ((IntPtr) voidPtr + 24),
          (object) obj3,
          (object) buffer3,
          (object) *(int*) ((IntPtr) voidPtr + 56),
          (object) buffer4,
          (object) *(int*) ((IntPtr) voidPtr + 60),
          (object) *(long*) ((IntPtr) voidPtr + 32),
          (object) inputBuffer1,
          (object) obj4,
          (object) cryptoTransform1,
          (object) buffer5,
          (object) inputBuffer2,
          (object) obj5,
          (object) cryptoTransform2,
          (object) buffer6,
          (object) ex,
          (object) numArray2,
          (object) _param0,
          (object) _param1,
          (object) _param2,
          (object) _param3
        };
        \u0005.\u0008.\u0001(ex, objArray);
        throw;
      }
    }

    internal sealed class \u0001
    {
      private const int \u0001 = 0;
      private const int \u0002 = 1;
      private const int \u0003 = 2;
      private const int \u0004 = 3;
      private const int \u0005 = 4;
      private const int \u0006 = 5;
      private const int \u0007 = 6;
      private const int \u0008 = 7;
      private const int \u000E = 8;
      private const int \u000F = 9;
      private const int \u0010 = 10;
      private const int \u0011 = 11;
      private const int \u0012 = 12;
      private static readonly int[] \u0013;
      private static readonly int[] \u0014;
      private static readonly int[] \u0015;
      private static readonly int[] \u0016;
      private int \u0017;
      private int \u0018;
      private int \u0019;
      private int \u001A;
      private int \u001B;
      private bool \u001C;
      private \u000E.\u0003.\u0002 \u001D;
      private \u000E.\u0003.\u0003 \u001E;
      private \u000E.\u0003.\u0005 \u001F;
      private \u000E.\u0003.\u0004 \u007F;
      private \u000E.\u0003.\u0004 \u0080;

      public \u0001(byte[] bytes)
      {
        try
        {
          this.\u001D = new \u000E.\u0003.\u0002();
          this.\u001E = new \u000E.\u0003.\u0003();
          this.\u0017 = 2;
          this.\u001D.\u0001(bytes, 0, bytes.Length);
        }
        catch (Exception ex)
        {
          byte[] numArray = bytes;
          \u0005.\u0008.\u0001(ex, (object) this, (object) numArray);
          throw;
        }
      }

      private unsafe bool \u0001()
      {
        int num1 = 13;
        do
        {
          if (num1 != 0)
          {
            // ISSUE: untyped stack allocation
            void* voidPtr = (void*) __untypedstackalloc(num1);
            int num2;
            int index;
            try
            {
              int num3 = this.\u001E.\u0001();
              if (true)
                goto label_38;
label_36:
              while (num2 >= 258)
              {
                *(int*) ((IntPtr) voidPtr + 8) = this.\u0017;
                int num4 = *(int*) ((IntPtr) voidPtr + 8);
                int num5;
                while (true)
                {
                  int num6 = num4 - 7;
                  int num7;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 0:
                        while (((index = this.\u007F.\u0001(this.\u001D)) & -256) == 0)
                        {
                          this.\u001E.\u0001(index);
                          num7 = num2 - 1;
                          if (true)
                          {
                            num2 = num7;
                            if (num7 < 258)
                            {
                              *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 1;
                              goto label_42;
                            }
                          }
                          else
                            goto label_30;
                        }
                        if (index < 257)
                        {
                          num5 = index;
                          if (false)
                          {
                            num6 = num5;
                            continue;
                          }
                          goto label_13;
                        }
                        else
                          goto label_16;
                      case 1:
                        goto label_17;
                      case 2:
                        goto label_24;
                      case 3:
                        goto label_28;
                      default:
                        goto label_36;
                    }
                  }
label_16:
                  this.\u0019 = \u000E.\u0003.\u0001.\u0013[index - 257];
                  this.\u0018 = \u000E.\u0003.\u0001.\u0014[index - 257];
label_17:
                  if (this.\u0018 <= 0)
                    goto label_23;
label_18:
                  this.\u0017 = 8;
                  *(int*) voidPtr = this.\u001D.\u0001(this.\u0018);
label_19:
                  int num8 = *(int*) voidPtr;
                  if (false)
                  {
                    num4 = num8;
                    continue;
                  }
                  if (num8 >= 0)
                  {
                    this.\u001D.\u0001(this.\u0018);
                    this.\u0019 += *(int*) voidPtr;
                  }
                  else
                    goto label_21;
label_23:
                  this.\u0017 = 9;
label_24:
                  index = this.\u0080.\u0001(this.\u001D);
                  if (index < 0)
                  {
                    if (false)
                      goto label_19;
                    else
                      goto label_26;
                  }
                  else
                  {
                    this.\u001A = \u000E.\u0003.\u0001.\u0015[index];
                    this.\u0018 = \u000E.\u0003.\u0001.\u0016[index];
                  }
label_28:
                  if (this.\u0018 > 0)
                  {
                    this.\u0017 = 10;
                    *(int*) ((IntPtr) voidPtr + 4) = this.\u001D.\u0001(this.\u0018);
                    int num9 = *(int*) ((IntPtr) voidPtr + 4);
                    num7 = 0;
                    num7 = num9;
                  }
                  else
                    goto label_34;
label_30:
                  if (num7 >= num7)
                  {
                    if (false)
                      goto label_18;
                    else
                      goto label_33;
                  }
                  else
                    goto label_31;
                }
label_13:
                if (num5 < 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 0;
                  goto label_42;
                }
                else
                {
                  this.\u0080 = (\u000E.\u0003.\u0004) null;
                  this.\u007F = (\u000E.\u0003.\u0004) null;
                  this.\u0017 = 2;
                  *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 1;
                  goto label_42;
                }
label_21:
                *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 0;
                goto label_42;
label_26:
                *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 0;
                goto label_42;
label_31:
                *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 0;
                goto label_42;
label_33:
                this.\u001D.\u0001(this.\u0018);
                this.\u001A += *(int*) ((IntPtr) voidPtr + 4);
label_34:
                if (true)
                {
                  this.\u001E.\u0001(this.\u0019, this.\u001A);
                  num2 -= this.\u0019;
                  this.\u0017 = 7;
                }
              }
              *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 1;
              goto label_42;
label_38:
              num2 = num3;
              goto label_36;
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a boxed type
              __Boxed<int> local1 = (ValueType) num2;
              // ISSUE: variable of a boxed type
              __Boxed<int> local2 = (ValueType) index;
              // ISSUE: variable of a boxed type
              __Boxed<int> local3 = (ValueType) *(int*) voidPtr;
              // ISSUE: variable of a boxed type
              __Boxed<int> local4 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
              // ISSUE: variable of a boxed type
              __Boxed<int> local5 = (ValueType) *(int*) ((IntPtr) voidPtr + 8);
              \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) local4, (object) local5, (object) this);
              throw;
            }
label_42:
            num1 = (int) *(sbyte*) ((IntPtr) voidPtr + 12);
          }
        }
        while (false);
        return num1 != 0;
      }

      private unsafe bool \u0002()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(13);
        int num;
        try
        {
          num = this.\u0017;
          switch (num)
          {
            case 2:
              if (this.\u001C)
              {
                this.\u0017 = 12;
                *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 0;
                break;
              }
              *(int*) voidPtr = this.\u001D.\u0001(3);
              if (*(int*) voidPtr < 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 0;
                break;
              }
              this.\u001D.\u0001(3);
              if ((*(int*) voidPtr & 1) != 0)
                this.\u001C = true;
              num = *(int*) voidPtr >> 1;
              switch (num)
              {
                case 0:
                  this.\u001D.\u0001();
                  this.\u0017 = 3;
                  break;
                case 1:
                  this.\u007F = \u000E.\u0003.\u0004.\u0003;
                  this.\u0080 = \u000E.\u0003.\u0004.\u0004;
                  this.\u0017 = 7;
                  break;
                case 2:
                  this.\u001F = new \u000E.\u0003.\u0005();
                  this.\u0017 = 6;
                  break;
              }
              *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 1;
              break;
            case 3:
              this.\u001B = num = this.\u001D.\u0001(16);
              if (num < 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 0;
                break;
              }
              this.\u001D.\u0001(16);
              this.\u0017 = 4;
              goto case 4;
            case 4:
              *(int*) ((IntPtr) voidPtr + 4) = this.\u001D.\u0001(16);
              if (*(int*) ((IntPtr) voidPtr + 4) < 0)
              {
                *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 0;
                break;
              }
              this.\u001D.\u0001(16);
              this.\u0017 = 5;
              goto case 5;
            case 5:
              *(int*) ((IntPtr) voidPtr + 8) = this.\u001E.\u0001(this.\u001D, this.\u001B);
              this.\u001B -= *(int*) ((IntPtr) voidPtr + 8);
              if (this.\u001B == 0)
              {
                this.\u0017 = 2;
                *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 1;
                break;
              }
              *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) !this.\u001D.IsNeedingInput;
              break;
            case 6:
              if (!this.\u001F.\u0001(this.\u001D))
              {
                *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 0;
                break;
              }
              this.\u007F = this.\u001F.\u0001();
              this.\u0080 = this.\u001F.\u0002();
              this.\u0017 = 7;
              goto case 7;
            case 7:
            case 8:
            case 9:
            case 10:
              *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) this.\u0001();
              break;
            case 12:
              *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 0;
              break;
            default:
              *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 0;
              break;
          }
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) *(int*) ((IntPtr) voidPtr + 8);
          // ISSUE: variable of a boxed type
          __Boxed<int> local4 = (ValueType) num;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) local4, (object) this);
          throw;
        }
        return (bool) *(sbyte*) ((IntPtr) voidPtr + 12);
      }

      public unsafe int \u0001(byte[] _param1, int _param2, int _param3)
      {
        void* voidPtr;
        do
        {
          // ISSUE: untyped stack allocation
          voidPtr = (void*) __untypedstackalloc(12);
          try
          {
            *(int*) voidPtr = 0;
label_11:
            do
            {
              if (this.\u0017 != 11)
                goto label_12;
label_6:
              do
              {
                if (!this.\u0002())
                {
                  if (this.\u001E.\u0002() <= 0)
                    goto label_10;
                }
                else
                  goto label_11;
              }
              while (false);
              continue;
label_12:
              *(int*) ((IntPtr) voidPtr + 4) = this.\u001E.\u0001(_param1, _param2, _param3);
              do
              {
                _param2 += *(int*) ((IntPtr) voidPtr + 4);
                if (false)
                  goto label_11;
              }
              while (false);
              *(int*) voidPtr = *(int*) voidPtr + *(int*) ((IntPtr) voidPtr + 4);
              _param3 -= *(int*) ((IntPtr) voidPtr + 4);
              if (_param3 != 0)
                goto label_6;
              else
                goto label_5;
            }
            while (this.\u0017 != 11);
            goto label_10;
label_5:
            *(int*) ((IntPtr) voidPtr + 8) = *(int*) voidPtr;
            if (true)
              goto label_14;
label_10:
            *(int*) ((IntPtr) voidPtr + 8) = *(int*) voidPtr;
          }
          catch (Exception ex)
          {
            // ISSUE: variable of a boxed type
            __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
            // ISSUE: variable of a boxed type
            __Boxed<int> local2 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
            byte[] numArray = _param1;
            // ISSUE: variable of a boxed type
            __Boxed<int> local3 = (ValueType) _param2;
            // ISSUE: variable of a boxed type
            __Boxed<int> local4 = (ValueType) _param3;
            \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) this, (object) numArray, (object) local3, (object) local4);
            throw;
          }
label_14:;
        }
        while (false);
        return *(int*) ((IntPtr) voidPtr + 8);
      }

      static \u0001()
      {
        try
        {
          do
          {
            do
            {
              if (true)
              {
                \u000E.\u0003.\u0001.\u0013 = new int[29]
                {
                  3,
                  4,
                  5,
                  6,
                  7,
                  8,
                  9,
                  10,
                  11,
                  13,
                  15,
                  17,
                  19,
                  23,
                  27,
                  31,
                  35,
                  43,
                  51,
                  59,
                  67,
                  83,
                  99,
                  115,
                  131,
                  163,
                  195,
                  227,
                  258
                };
                \u000E.\u0003.\u0001.\u0014 = new int[29]
                {
                  0,
                  0,
                  0,
                  0,
                  0,
                  0,
                  0,
                  0,
                  1,
                  1,
                  1,
                  1,
                  2,
                  2,
                  2,
                  2,
                  3,
                  3,
                  3,
                  3,
                  4,
                  4,
                  4,
                  4,
                  5,
                  5,
                  5,
                  5,
                  0
                };
              }
            }
            while (false);
            if (true)
              \u000E.\u0003.\u0001.\u0015 = new int[30]
              {
                1,
                2,
                3,
                4,
                5,
                7,
                9,
                13,
                17,
                25,
                33,
                49,
                65,
                97,
                129,
                193,
                257,
                385,
                513,
                769,
                1025,
                1537,
                2049,
                3073,
                4097,
                6145,
                8193,
                12289,
                16385,
                24577
              };
            \u000E.\u0003.\u0001.\u0016 = new int[30]
            {
              0,
              0,
              0,
              0,
              1,
              1,
              2,
              2,
              3,
              3,
              4,
              4,
              5,
              5,
              6,
              6,
              7,
              7,
              8,
              8,
              9,
              9,
              10,
              10,
              11,
              11,
              12,
              12,
              13,
              13
            };
          }
          while (false);
        }
        catch (Exception ex)
        {
          \u0005.\u0008.\u0001(ex);
          throw;
        }
      }
    }

    internal sealed class \u0002
    {
      private byte[] \u0001;
      private int \u0002 = 0;
      private int \u0003 = 0;
      private uint \u0004 = 0;
      private int \u0005 = 0;

      public int \u0001(int _param1)
      {
        int num1;
        try
        {
          if (this.\u0005 < _param1)
            goto label_5;
label_4:
          return (int) ((long) this.\u0004 & (long) ((1 << _param1) - 1));
label_5:
          if (this.\u0002 == this.\u0003)
            return -1;
          \u000E.\u0003.\u0002 obj1 = this;
          int num2 = (int) obj1.\u0004;
          byte[] numArray1 = this.\u0001;
          \u000E.\u0003.\u0002 obj2 = this;
          int num3 = obj2.\u0002;
          if (true)
            goto label_6;
label_3:
          obj2.\u0002 = num3 + 1;
          int index1 = num1;
          int num4 = (int) numArray1[index1] & (int) byte.MaxValue;
          byte[] numArray2 = this.\u0001;
          num1 = this.\u0002++;
          int index2 = num1;
          int num5 = ((int) numArray2[index2] & (int) byte.MaxValue) << 8;
          int num6 = (num4 | num5) << this.\u0005;
          obj1.\u0004 = (uint) (num2 | num6);
          this.\u0005 += 16;
          goto label_4;
label_6:
          num1 = num3;
          goto label_3;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) num1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) _param1;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) this, (object) local2);
          throw;
        }
      }

      public void \u0001(int _param1)
      {
        try
        {
          if (true)
            this.\u0004 >>>= _param1 & 31;
          else
            goto label_4;
label_2:
          if (true)
            this.\u0005 -= _param1;
label_4:
          if (false)
            goto label_2;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local = (ValueType) _param1;
          \u0005.\u0008.\u0001(ex, (object) this, (object) local);
          throw;
        }
      }

      public int AvailableBits
      {
        get
        {
          int num;
          try
          {
            num = this.\u0005;
          }
          catch (Exception ex)
          {
            \u0005.\u0008.\u0001(ex, (object) this);
            throw;
          }
          return num;
        }
      }

      public int AvailableBytes
      {
        get
        {
          int num1;
          try
          {
            int num2 = this.\u0003 - this.\u0002;
            do
            {
              if (true)
                goto label_7;
label_6:
              continue;
label_7:
              int num3 = this.\u0005;
              do
              {
                if (true)
                  num3 >>= 3;
              }
              while (false);
              num2 += num3;
              goto label_6;
            }
            while (false);
            num1 = num2;
          }
          catch (Exception ex)
          {
            \u0005.\u0008.\u0001(ex, (object) this);
            throw;
          }
          return num1;
        }
      }

      public void \u0001()
      {
        try
        {
          this.\u0004 >>>= this.\u0005 & 7 & 31;
          this.\u0005 &= -8;
        }
        catch (Exception ex)
        {
          \u0005.\u0008.\u0001(ex, (object) this);
          throw;
        }
      }

      public bool IsNeedingInput
      {
        get
        {
          bool flag;
          try
          {
            flag = this.\u0002 == this.\u0003;
          }
          catch (Exception ex)
          {
            \u0005.\u0008.\u0001(ex, (object) this);
            throw;
          }
          return flag;
        }
      }

      public unsafe int \u0001(byte[] _param1, int _param2, int _param3)
      {
        // ISSUE: untyped stack allocation
        IntPtr num1 = __untypedstackalloc(12);
        if (true)
          goto label_20;
label_1:
        void* voidPtr;
        int num2;
        try
        {
          *(int*) voidPtr = 0;
label_3:
          int num3 = this.\u0005;
          int num4;
          for (int index = 0; num3 > index && _param3 > 0; num3 = num4)
          {
            _param1[_param2++] = (byte) this.\u0004;
            this.\u0004 >>= 8;
            this.\u0005 -= 8;
            num4 = _param3;
            int num5 = 1;
            if (num5 != 0)
            {
              int num6 = num4 - num5;
              if (true)
                _param3 = num6;
              *(int*) voidPtr = *(int*) voidPtr + 1;
              goto label_3;
            }
            else
              index = num5;
          }
          if (_param3 == 0)
          {
            *(int*) ((IntPtr) voidPtr + 8) = *(int*) voidPtr;
          }
          else
          {
            *(int*) ((IntPtr) voidPtr + 4) = this.\u0003 - this.\u0002;
            if (_param3 > *(int*) ((IntPtr) voidPtr + 4))
            {
              if (true)
                _param3 = *(int*) ((IntPtr) voidPtr + 4);
              else
                goto label_12;
            }
            Array.Copy((Array) this.\u0001, this.\u0002, (Array) _param1, _param2, _param3);
            if (true)
              this.\u0002 += _param3;
            else
              goto label_19;
label_12:
            if ((this.\u0002 - this.\u0003 & 1) != 0)
            {
              byte[] numArray = this.\u0001;
              num2 = this.\u0002++;
              int index = num2;
              this.\u0004 = (uint) numArray[index] & (uint) byte.MaxValue;
              this.\u0005 = 8;
            }
            *(int*) ((IntPtr) voidPtr + 8) = *(int*) voidPtr + _param3;
          }
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) num2;
          byte[] numArray = _param1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local4 = (ValueType) _param2;
          // ISSUE: variable of a boxed type
          __Boxed<int> local5 = (ValueType) _param3;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) this, (object) numArray, (object) local4, (object) local5);
          throw;
        }
label_19:
        return *(int*) ((IntPtr) voidPtr + 8);
label_20:
        voidPtr = (void*) num1;
        goto label_1;
      }

      public void \u0002()
      {
        int num;
        try
        {
          this.\u0005 = num = 0;
          this.\u0003 = num = num;
          this.\u0002 = num = num;
          this.\u0004 = (uint) num;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local = (ValueType) num;
          \u0005.\u0008.\u0001(ex, (object) local, (object) this);
          throw;
        }
      }

      public void \u0001(byte[] _param1, int _param2, int _param3)
      {
        int num1;
        try
        {
          if (false)
            goto label_10;
          else
            goto label_16;
label_1:
          int num2;
          int num3;
          if (num2 < num3)
            throw new InvalidOperationException();
          int num4 = _param2;
          int num5 = _param3;
          if (true)
            num1 = num4 + num5;
          else
            goto label_8;
label_4:
          int num6;
          if (0 <= _param2)
          {
            num2 = _param2;
            num3 = num1;
            if (true)
            {
              if (num2 <= num3)
              {
                int num7 = num1;
                if (true)
                {
                  num5 = _param1.Length;
                  num4 = num7;
                }
                else
                {
                  num6 = num7;
                  goto label_11;
                }
              }
              else
                goto label_9;
            }
            else
              goto label_1;
          }
          else
            goto label_9;
label_8:
          int num8 = num5;
          if (num4 <= num8)
            goto label_10;
label_9:
          throw new ArgumentOutOfRangeException();
label_10:
          num6 = _param3 & 1;
label_11:
          if (num6 != 0)
          {
            if (true)
            {
              this.\u0004 |= (uint) (((int) _param1[_param2++] & (int) byte.MaxValue) << this.\u0005);
              this.\u0005 += 8;
            }
            else
              goto label_9;
          }
          this.\u0001 = _param1;
          this.\u0002 = _param2;
          if (true)
          {
            this.\u0003 = num1;
            return;
          }
          goto label_4;
label_16:
          int num9 = this.\u0002;
          num3 = this.\u0003;
          num2 = num9;
          goto label_1;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) num1;
          byte[] numArray = _param1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) _param2;
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) _param3;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) this, (object) numArray, (object) local2, (object) local3);
          throw;
        }
      }
    }

    internal sealed class \u0003
    {
      private const int \u0001 = 32768;
      private const int \u0002 = 32767;
      private byte[] \u0003 = new byte[32768];
      private int \u0004 = 0;
      private int \u0005 = 0;

      public void \u0001(int _param1)
      {
        int num1;
        try
        {
          \u000E.\u0003.\u0003 obj1 = this;
          int num2;
          num1 = num2 = obj1.\u0005;
          obj1.\u0005 = num2 + 1;
          if (num1 == 32768)
            throw new InvalidOperationException();
          byte[] numArray = this.\u0003;
          \u000E.\u0003.\u0003 obj2 = this;
          int num3;
          num1 = num3 = obj2.\u0004;
          obj2.\u0004 = num3 + 1;
          int index = num1;
          int num4 = (int) (byte) _param1;
          numArray[index] = (byte) num4;
          this.\u0004 &= (int) short.MaxValue;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) num1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) _param1;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) this, (object) local2);
          throw;
        }
      }

      private void \u0001(int _param1, int _param2, int _param3)
      {
label_0:
        int num1;
        try
        {
          do
          {
            while (true)
            {
              if (true)
              {
                if (true)
                {
                  int num2 = _param2;
                  int num3 = num2 - 1;
                  if (true)
                    goto label_12;
label_3:
                  _param1 = num2 & num3;
                  continue;
label_12:
                  _param2 = num3;
                  if (num2 > 0)
                  {
                    byte[] numArray = this.\u0003;
                    \u000E.\u0003.\u0003 obj = this;
                    int num4 = obj.\u0004;
                    if (true)
                      goto label_10;
label_1:
                    obj.\u0004 = num4 + 1;
                    int index = num1;
                    int num5 = (int) this.\u0003[_param1++];
                    numArray[index] = (byte) num5;
                    if (true)
                      this.\u0004 &= (int) short.MaxValue;
                    int num6 = _param1;
                    num3 = (int) short.MaxValue;
                    num2 = num6;
                    goto label_3;
label_10:
                    num1 = num4;
                    goto label_1;
                  }
                  else
                    break;
                }
                else
                  break;
              }
              else
                goto label_0;
            }
          }
          while (false);
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) num1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) _param1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) _param2;
          // ISSUE: variable of a boxed type
          __Boxed<int> local4 = (ValueType) _param3;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) this, (object) local2, (object) local3, (object) local4);
          throw;
        }
      }

      public void \u0001(int _param1, int _param2)
      {
        int sourceIndex;
        int num1;
        int num2;
        try
        {
          int num3;
          int num4;
          int num5;
          if (true)
          {
            if (true)
            {
              num2 = (this.\u0005 += _param1);
              int num6 = num2;
              if (true)
              {
                if (num6 > 32768)
                  throw new InvalidOperationException();
                int num7 = this.\u0004 - _param2;
                num4 = (int) short.MaxValue;
                num3 = num7;
              }
              else
              {
                num5 = num6;
                goto label_20;
              }
            }
            else
              goto label_10;
          }
          else
            goto label_12;
label_6:
          sourceIndex = num3 & num4;
          num5 = 32768;
          goto label_20;
label_10:
          int num8 = this.\u0004;
          int num9 = num1;
          int num10 = num8;
label_11:
          if (num10 >= num9)
            goto label_17;
label_12:
          if (_param1 <= _param2)
          {
            Array.Copy((Array) this.\u0003, sourceIndex, (Array) this.\u0003, this.\u0004, _param1);
            this.\u0004 += _param1;
            return;
          }
          while (true)
          {
            num3 = _param1;
            num4 = num3 - 1;
            if (true)
            {
              _param1 = num4;
              if (num3 > 0)
              {
                byte[] numArray = this.\u0003;
                num2 = this.\u0004++;
                int index = num2;
                int num11 = (int) this.\u0003[sourceIndex++];
                numArray[index] = (byte) num11;
              }
              else
                break;
            }
            else
              goto label_6;
          }
          return;
label_17:
          this.\u0001(sourceIndex, _param1, _param2);
          return;
label_20:
          int num12 = _param1;
          int num13 = num5 - num12;
          if (true)
            goto label_21;
label_7:
          num10 = sourceIndex;
          num9 = num1;
          if (true)
          {
            if (false)
            {
              num4 = num9;
              num3 = num10;
              goto label_6;
            }
            else if (num10 > num9)
              goto label_17;
            else
              goto label_10;
          }
          else
            goto label_11;
label_21:
          num1 = num13;
          goto label_7;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) sourceIndex;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) num1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) num2;
          // ISSUE: variable of a boxed type
          __Boxed<int> local4 = (ValueType) _param1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local5 = (ValueType) _param2;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) this, (object) local4, (object) local5);
          throw;
        }
      }

      public unsafe int \u0001(\u000E.\u0003.\u0002 _param1, int _param2)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(12);
        try
        {
          int val1 = _param2;
          int val2_1 = 32768;
          if (val2_1 != 0)
          {
            int val2_2 = val2_1 - this.\u0005;
            int num = Math.Min(val1, val2_2);
            val2_1 = _param1.AvailableBytes;
            val1 = num;
          }
          int num1 = Math.Min(val1, val2_1);
          while (true)
          {
            _param2 = num1;
            int num2;
            do
            {
              *(int*) ((IntPtr) voidPtr + 4) = 32768 - this.\u0004;
              num2 = _param2;
              if (true)
              {
                int num3 = *(int*) ((IntPtr) voidPtr + 4);
                if (num2 > num3)
                  goto label_4;
              }
              else
                goto label_2;
            }
            while (false);
            goto label_7;
label_2:
            num1 = num2;
          }
label_4:
          *(int*) voidPtr = _param1.\u0001(this.\u0003, this.\u0004, *(int*) ((IntPtr) voidPtr + 4));
          if (*(int*) voidPtr == *(int*) ((IntPtr) voidPtr + 4))
          {
            *(int*) voidPtr = *(int*) voidPtr + _param1.\u0001(this.\u0003, 0, _param2 - *(int*) ((IntPtr) voidPtr + 4));
            goto label_8;
          }
          else
            goto label_8;
label_7:
          *(int*) voidPtr = _param1.\u0001(this.\u0003, this.\u0004, _param2);
label_8:
          this.\u0004 = this.\u0004 + *(int*) voidPtr & (int) short.MaxValue;
          this.\u0005 += *(int*) voidPtr;
          *(int*) ((IntPtr) voidPtr + 8) = *(int*) voidPtr;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
          \u000E.\u0003.\u0002 obj = _param1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) _param2;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) this, (object) obj, (object) local3);
          throw;
        }
        return *(int*) ((IntPtr) voidPtr + 8);
      }

      public void \u0001(byte[] _param1, int _param2, int _param3)
      {
        try
        {
          if (false)
            return;
          int num1 = this.\u0005;
          int num2 = 0;
          if (num2 == 0)
          {
            if (num1 > num2)
              throw new InvalidOperationException();
            goto label_10;
          }
          else
            goto label_3;
label_2:
          num2 = 32768;
          int num3;
          num1 = num3;
label_3:
          if (num1 > num2)
          {
            int num4 = _param2;
            if (false)
            {
              num3 = num4;
              goto label_2;
            }
            else
            {
              int num5 = _param3 - 32768;
              int num6 = num4 + num5;
              int num7;
              while (true)
              {
                _param2 = num6;
                num7 = 32768;
                if (num7 == 0)
                  num6 = num7;
                else
                  break;
              }
              _param3 = num7;
            }
          }
          Array.Copy((Array) _param1, _param2, (Array) this.\u0003, 0, _param3);
          if (true)
          {
            this.\u0004 = _param3 & (int) short.MaxValue;
            return;
          }
label_10:
          num3 = _param3;
          goto label_2;
        }
        catch (Exception ex)
        {
          byte[] numArray = _param1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) _param2;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) _param3;
          \u0005.\u0008.\u0001(ex, (object) this, (object) numArray, (object) local1, (object) local2);
          throw;
        }
      }

      public int \u0001()
      {
        int num1;
        try
        {
          do
          {
            int num2 = 32768;
            if (num2 != 0)
              num2 -= this.\u0005;
            num1 = num2;
          }
          while (false);
        }
        catch (Exception ex)
        {
          \u0005.\u0008.\u0001(ex, (object) this);
          throw;
        }
        return num1;
      }

      public int \u0002()
      {
        int num;
        try
        {
          num = this.\u0005;
        }
        catch (Exception ex)
        {
          \u0005.\u0008.\u0001(ex, (object) this);
          throw;
        }
        return num;
      }

      public unsafe int \u0001(byte[] _param1, int _param2, int _param3)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(16);
        try
        {
          *(int*) voidPtr = this.\u0004;
          if (_param3 <= this.\u0005)
            goto label_9;
          else
            goto label_8;
label_2:
          do
          {
            *(int*) ((IntPtr) voidPtr + 4) = _param3;
            *(int*) ((IntPtr) voidPtr + 8) = _param3 - *(int*) voidPtr;
            if (*(int*) ((IntPtr) voidPtr + 8) > 0)
            {
              Array.Copy((Array) this.\u0003, 32768 - *(int*) ((IntPtr) voidPtr + 8), (Array) _param1, _param2, *(int*) ((IntPtr) voidPtr + 8));
              _param2 += *(int*) ((IntPtr) voidPtr + 8);
            }
            else
              goto label_5;
          }
          while (false);
          _param3 = *(int*) voidPtr;
label_5:
          Array.Copy((Array) this.\u0003, *(int*) voidPtr - _param3, (Array) _param1, _param2, _param3);
          this.\u0005 -= *(int*) ((IntPtr) voidPtr + 4);
          if (this.\u0005 < 0)
            throw new InvalidOperationException();
          *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 4);
          goto label_11;
label_8:
          _param3 = this.\u0005;
          goto label_2;
label_9:
          *(int*) voidPtr = this.\u0004 - this.\u0005 + _param3 & (int) short.MaxValue;
          goto label_2;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) *(int*) ((IntPtr) voidPtr + 8);
          byte[] numArray = _param1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local4 = (ValueType) _param2;
          // ISSUE: variable of a boxed type
          __Boxed<int> local5 = (ValueType) _param3;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) this, (object) numArray, (object) local4, (object) local5);
          throw;
        }
label_11:
        return *(int*) ((IntPtr) voidPtr + 12);
      }

      public void \u0001()
      {
        int num;
        try
        {
          do
          {
            this.\u0004 = num = 0;
            this.\u0005 = num;
          }
          while (false);
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local = (ValueType) num;
          \u0005.\u0008.\u0001(ex, (object) local, (object) this);
          throw;
        }
      }
    }

    internal sealed class \u0004
    {
      private const int \u0001 = 15;
      private short[] \u0002;
      public static readonly \u000E.\u0003.\u0004 \u0003;
      public static readonly \u000E.\u0003.\u0004 \u0004;

      static \u0004()
      {
        int num1;
        byte[] codeLengths;
        try
        {
          int length1 = 288;
          if (length1 != 0)
          {
            codeLengths = new byte[length1];
            length1 = 0;
          }
          num1 = length1;
          while (true)
          {
            if (num1 < 144)
            {
              if (true)
              {
                if (true)
                {
                  codeLengths[num1++] = (byte) 8;
                  continue;
                }
                break;
              }
            }
            else
              goto label_20;
label_19:
            codeLengths[num1++] = (byte) 9;
label_20:
            if (num1 < 256)
              goto label_19;
            else
              goto label_6;
          }
          goto label_13;
label_6:
          if (num1 >= 280)
          {
            int length2;
            while (true)
            {
              int num2 = num1;
              while (true)
              {
                if (num2 >= 288)
                {
                  \u000E.\u0003.\u0004.\u0003 = new \u000E.\u0003.\u0004(codeLengths);
                  length2 = 32;
                  if (length2 == 0)
                    num2 = length2;
                  else
                    goto label_11;
                }
                else
                  break;
              }
              codeLengths[num1++] = (byte) 8;
            }
label_11:
            codeLengths = new byte[length2];
            num1 = 0;
          }
          else
            goto label_21;
label_13:
          while (num1 < 32)
            codeLengths[num1++] = (byte) 5;
          \u000E.\u0003.\u0004.\u0004 = new \u000E.\u0003.\u0004(codeLengths);
          if (true)
            return;
label_21:
          codeLengths[num1++] = (byte) 7;
          goto label_6;
        }
        catch (Exception ex)
        {
          byte[] numArray = codeLengths;
          // ISSUE: variable of a boxed type
          __Boxed<int> local = (ValueType) num1;
          \u0005.\u0008.\u0001(ex, (object) numArray, (object) local);
          throw;
        }
      }

      public \u0004(byte[] codeLengths)
      {
        try
        {
          this.\u0001(codeLengths);
        }
        catch (Exception ex)
        {
          byte[] numArray = codeLengths;
          \u0005.\u0008.\u0001(ex, (object) this, (object) numArray);
          throw;
        }
      }

      private unsafe void \u0001(byte[] _param1)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(68);
        int[] numArray1;
        int[] numArray2;
        int[] numArray3;
        int index;
        try
        {
          numArray1 = new int[16];
          numArray3 = new int[16];
          *(int*) voidPtr = 0;
          while (*(int*) voidPtr < _param1.Length)
          {
            *(int*) ((IntPtr) voidPtr + 4) = (int) _param1[*(int*) voidPtr];
            if (*(int*) ((IntPtr) voidPtr + 4) > 0)
              (numArray2 = numArray1)[index = *(int*) ((IntPtr) voidPtr + 4)] = numArray2[(IntPtr) index] + 1;
            *(int*) voidPtr = *(int*) voidPtr + 1;
          }
          *(int*) ((IntPtr) voidPtr + 8) = 0;
          *(int*) ((IntPtr) voidPtr + 12) = 512;
          *(int*) ((IntPtr) voidPtr + 16) = 1;
          while (*(int*) ((IntPtr) voidPtr + 16) <= 15)
          {
            numArray3[*(int*) ((IntPtr) voidPtr + 16)] = *(int*) ((IntPtr) voidPtr + 8);
            *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + (numArray1[*(int*) ((IntPtr) voidPtr + 16)] << 16 - *(int*) ((IntPtr) voidPtr + 16));
            if (*(int*) ((IntPtr) voidPtr + 16) >= 10)
            {
              *(int*) ((IntPtr) voidPtr + 20) = numArray3[*(int*) ((IntPtr) voidPtr + 16)] & 130944;
              *(int*) ((IntPtr) voidPtr + 24) = *(int*) ((IntPtr) voidPtr + 8) & 130944;
              *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + (*(int*) ((IntPtr) voidPtr + 24) - *(int*) ((IntPtr) voidPtr + 20) >> 16 - *(int*) ((IntPtr) voidPtr + 16));
            }
            *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) + 1;
          }
          this.\u0002 = new short[*(int*) ((IntPtr) voidPtr + 12)];
          *(int*) ((IntPtr) voidPtr + 28) = 512;
          *(int*) ((IntPtr) voidPtr + 32) = 15;
          while (*(int*) ((IntPtr) voidPtr + 32) >= 10)
          {
            *(int*) ((IntPtr) voidPtr + 36) = *(int*) ((IntPtr) voidPtr + 8) & 130944;
            *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - (numArray1[*(int*) ((IntPtr) voidPtr + 32)] << 16 - *(int*) ((IntPtr) voidPtr + 32));
            *(int*) ((IntPtr) voidPtr + 40) = *(int*) ((IntPtr) voidPtr + 8) & 130944;
            *(int*) ((IntPtr) voidPtr + 44) = *(int*) ((IntPtr) voidPtr + 40);
            while (*(int*) ((IntPtr) voidPtr + 44) < *(int*) ((IntPtr) voidPtr + 36))
            {
              this.\u0002[(int) \u000E.\u0003.\u0007.\u0001(*(int*) ((IntPtr) voidPtr + 44))] = (short) (-*(int*) ((IntPtr) voidPtr + 28) << 4 | *(int*) ((IntPtr) voidPtr + 32));
              *(int*) ((IntPtr) voidPtr + 28) = *(int*) ((IntPtr) voidPtr + 28) + (1 << *(int*) ((IntPtr) voidPtr + 32) - 9);
              *(int*) ((IntPtr) voidPtr + 44) = *(int*) ((IntPtr) voidPtr + 44) + 128;
            }
            *(int*) ((IntPtr) voidPtr + 32) = *(int*) ((IntPtr) voidPtr + 32) - 1;
          }
          *(int*) ((IntPtr) voidPtr + 48) = 0;
          while (*(int*) ((IntPtr) voidPtr + 48) < _param1.Length)
          {
            *(int*) ((IntPtr) voidPtr + 52) = (int) _param1[*(int*) ((IntPtr) voidPtr + 48)];
            if (*(int*) ((IntPtr) voidPtr + 52) != 0)
            {
              *(int*) ((IntPtr) voidPtr + 8) = numArray3[*(int*) ((IntPtr) voidPtr + 52)];
              *(int*) ((IntPtr) voidPtr + 56) = (int) \u000E.\u0003.\u0007.\u0001(*(int*) ((IntPtr) voidPtr + 8));
              if (*(int*) ((IntPtr) voidPtr + 52) <= 9)
              {
                do
                {
                  this.\u0002[*(int*) ((IntPtr) voidPtr + 56)] = (short) (*(int*) ((IntPtr) voidPtr + 48) << 4 | *(int*) ((IntPtr) voidPtr + 52));
                  *(int*) ((IntPtr) voidPtr + 56) = *(int*) ((IntPtr) voidPtr + 56) + (1 << *(int*) ((IntPtr) voidPtr + 52));
                }
                while (*(int*) ((IntPtr) voidPtr + 56) < 512);
              }
              else
              {
                *(int*) ((IntPtr) voidPtr + 60) = (int) this.\u0002[*(int*) ((IntPtr) voidPtr + 56) & 511];
                *(int*) ((IntPtr) voidPtr + 64) = 1 << (*(int*) ((IntPtr) voidPtr + 60) & 15);
                *(int*) ((IntPtr) voidPtr + 60) = -(*(int*) ((IntPtr) voidPtr + 60) >> 4);
                do
                {
                  this.\u0002[*(int*) ((IntPtr) voidPtr + 60) | *(int*) ((IntPtr) voidPtr + 56) >> 9] = (short) (*(int*) ((IntPtr) voidPtr + 48) << 4 | *(int*) ((IntPtr) voidPtr + 52));
                  *(int*) ((IntPtr) voidPtr + 56) = *(int*) ((IntPtr) voidPtr + 56) + (1 << *(int*) ((IntPtr) voidPtr + 52));
                }
                while (*(int*) ((IntPtr) voidPtr + 56) < *(int*) ((IntPtr) voidPtr + 64));
              }
              numArray3[*(int*) ((IntPtr) voidPtr + 52)] = *(int*) ((IntPtr) voidPtr + 8) + (1 << 16 - *(int*) ((IntPtr) voidPtr + 52));
            }
            *(int*) ((IntPtr) voidPtr + 48) = *(int*) ((IntPtr) voidPtr + 48) + 1;
          }
        }
        catch (Exception ex)
        {
          object[] objArray = new object[23]
          {
            (object) numArray1,
            (object) numArray3,
            (object) *(int*) voidPtr,
            (object) *(int*) ((IntPtr) voidPtr + 4),
            (object) *(int*) ((IntPtr) voidPtr + 8),
            (object) *(int*) ((IntPtr) voidPtr + 12),
            (object) *(int*) ((IntPtr) voidPtr + 16),
            (object) *(int*) ((IntPtr) voidPtr + 20),
            (object) *(int*) ((IntPtr) voidPtr + 24),
            (object) *(int*) ((IntPtr) voidPtr + 28),
            (object) *(int*) ((IntPtr) voidPtr + 32),
            (object) *(int*) ((IntPtr) voidPtr + 36),
            (object) *(int*) ((IntPtr) voidPtr + 40),
            (object) *(int*) ((IntPtr) voidPtr + 44),
            (object) *(int*) ((IntPtr) voidPtr + 48),
            (object) *(int*) ((IntPtr) voidPtr + 52),
            (object) *(int*) ((IntPtr) voidPtr + 56),
            (object) *(int*) ((IntPtr) voidPtr + 60),
            (object) *(int*) ((IntPtr) voidPtr + 64),
            (object) numArray2,
            (object) (IntPtr) index,
            (object) this,
            (object) _param1
          };
          \u0005.\u0008.\u0001(ex, objArray);
          throw;
        }
      }

      public unsafe int \u0001(\u000E.\u0003.\u0002 _param1)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(20);
        int num;
        int index;
        try
        {
          if ((index = _param1.\u0001(9)) < 0)
          {
            *(int*) ((IntPtr) voidPtr + 12) = _param1.AvailableBits;
            index = _param1.\u0001(*(int*) ((IntPtr) voidPtr + 12));
            num = (int) this.\u0002[index];
            if (num >= 0 && (num & 15) <= *(int*) ((IntPtr) voidPtr + 12))
            {
              _param1.\u0001(num & 15);
              *(int*) ((IntPtr) voidPtr + 16) = num >> 4;
            }
            else
              *(int*) ((IntPtr) voidPtr + 16) = -1;
          }
          else if ((num = (int) this.\u0002[index]) < 0)
          {
            *(int*) voidPtr = -(num >> 4);
            *(int*) ((IntPtr) voidPtr + 4) = num & 15;
            if ((index = _param1.\u0001(*(int*) ((IntPtr) voidPtr + 4))) >= 0)
            {
              num = (int) this.\u0002[*(int*) voidPtr | index >> 9];
              _param1.\u0001(num & 15);
              *(int*) ((IntPtr) voidPtr + 16) = num >> 4;
            }
            else
            {
              *(int*) ((IntPtr) voidPtr + 8) = _param1.AvailableBits;
              do
              {
                index = _param1.\u0001(*(int*) ((IntPtr) voidPtr + 8));
                num = (int) this.\u0002[*(int*) voidPtr | index >> 9];
                if ((num & 15) <= *(int*) ((IntPtr) voidPtr + 8))
                  _param1.\u0001(num & 15);
                else
                  goto label_8;
              }
              while (false);
              *(int*) ((IntPtr) voidPtr + 16) = num >> 4;
              if (true)
                goto label_15;
label_8:
              *(int*) ((IntPtr) voidPtr + 16) = -1;
            }
          }
          else
          {
            _param1.\u0001(num & 15);
            *(int*) ((IntPtr) voidPtr + 16) = num >> 4;
          }
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) index;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) num;
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) *(int*) voidPtr;
          // ISSUE: variable of a boxed type
          __Boxed<int> local4 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
          // ISSUE: variable of a boxed type
          __Boxed<int> local5 = (ValueType) *(int*) ((IntPtr) voidPtr + 8);
          // ISSUE: variable of a boxed type
          __Boxed<int> local6 = (ValueType) *(int*) ((IntPtr) voidPtr + 12);
          \u000E.\u0003.\u0002 obj = _param1;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) local4, (object) local5, (object) local6, (object) this, (object) obj);
          throw;
        }
label_15:
        return *(int*) ((IntPtr) voidPtr + 16);
      }
    }

    internal sealed class \u0005
    {
      private const int \u0001 = 0;
      private const int \u0002 = 1;
      private const int \u0003 = 2;
      private const int \u0004 = 3;
      private const int \u0005 = 4;
      private const int \u0006 = 5;
      private static readonly int[] \u0007;
      private static readonly int[] \u0008;
      private byte[] \u000E;
      private byte[] \u000F;
      private \u000E.\u0003.\u0004 \u0010;
      private int \u0011;
      private int \u0012;
      private int \u0013;
      private int \u0014;
      private int \u0015;
      private int \u0016;
      private byte \u0017;
      private int \u0018;
      private static readonly int[] \u0019;

      public unsafe bool \u0001(\u000E.\u0003.\u0002 _param1)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(9);
label_1:
        int num1;
        int num2;
        byte num3;
        int num4;
        try
        {
          while (true)
          {
            num1 = this.\u0011;
            int num5 = num1;
            int num6;
            while (true)
            {
              int num7;
              switch (num5)
              {
                case 0:
                  this.\u0012 = _param1.\u0001(5);
                  if (this.\u0012 >= 0)
                  {
                    this.\u0012 += 257;
                    _param1.\u0001(5);
                    this.\u0011 = 1;
                    goto case 1;
                  }
                  else
                    goto label_40;
                case 1:
                  if (true)
                  {
                    this.\u0013 = _param1.\u0001(5);
                    int num8 = this.\u0013;
                    int num9 = 0;
                    if (num9 == 0)
                    {
                      if (num8 >= num9)
                      {
                        ++this.\u0013;
                        _param1.\u0001(5);
                        this.\u0015 = this.\u0012 + this.\u0013;
                        this.\u000F = new byte[this.\u0015];
                        this.\u0011 = 2;
                        goto case 2;
                      }
                      else
                        goto label_8;
                    }
                    else
                    {
                      num7 = num9;
                      num7 = num8;
                      goto label_24;
                    }
                  }
                  else
                    goto label_18;
                case 2:
                  this.\u0014 = _param1.\u0001(4);
                  if (this.\u0014 >= 0)
                  {
                    this.\u0014 += 4;
                    _param1.\u0001(4);
                    if (true)
                    {
                      this.\u000E = new byte[19];
                      this.\u0018 = 0;
                      this.\u0011 = 3;
                      goto case 3;
                    }
                    else
                      break;
                  }
                  else
                    goto label_11;
                case 3:
label_19:
                  if (this.\u0018 < this.\u0014)
                  {
                    *(int*) voidPtr = _param1.\u0001(3);
                    if (*(int*) voidPtr >= 0)
                    {
                      _param1.\u0001(3);
                      break;
                    }
                    goto label_15;
                  }
                  else
                  {
                    this.\u0010 = new \u000E.\u0003.\u0004(this.\u000E);
                    this.\u000E = (byte[]) null;
                    this.\u0018 = 0;
                    this.\u0011 = 4;
                    goto case 4;
                  }
                case 4:
label_23:
                  num7 = this.\u0010.\u0001(_param1);
                  goto label_24;
                case 5:
label_30:
                  *(int*) ((IntPtr) voidPtr + 4) = \u000E.\u0003.\u0005.\u0008[this.\u0016];
                  num6 = _param1.\u0001(*(int*) ((IntPtr) voidPtr + 4));
                  if (false)
                  {
                    num5 = num6;
                    continue;
                  }
                  goto label_31;
                default:
                  goto label_1;
              }
              this.\u000E[\u000E.\u0003.\u0005.\u0019[this.\u0018]] = (byte) *(int*) voidPtr;
label_18:
              ++this.\u0018;
              goto label_19;
label_24:
              num2 = num7;
              if ((num7 & -16) == 0)
              {
                byte[] numArray = this.\u000F;
                num1 = this.\u0018++;
                int index = num1;
                this.\u0017 = num3 = (byte) num2;
                int num10 = (int) num3;
                numArray[index] = (byte) num10;
                if (this.\u0018 != this.\u0015)
                  goto label_23;
                else
                  goto label_22;
              }
              else if (num2 >= 0)
              {
                if (num2 >= 17)
                  this.\u0017 = (byte) 0;
                this.\u0016 = num2 - 16;
                this.\u0011 = 5;
                goto label_30;
              }
              else
                goto label_26;
            }
label_31:
            num4 = num6;
            if (num4 >= 0)
            {
              _param1.\u0001(*(int*) ((IntPtr) voidPtr + 4));
              num4 += \u000E.\u0003.\u0005.\u0007[this.\u0016];
              while (num4-- > 0)
              {
                byte[] numArray = this.\u000F;
                num1 = this.\u0018++;
                int index = num1;
                int num11 = (int) this.\u0017;
                numArray[index] = (byte) num11;
              }
              if (this.\u0018 != this.\u0015)
                this.\u0011 = 4;
              else
                goto label_37;
            }
            else
              goto label_32;
          }
label_8:
          *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) 0;
          goto label_42;
label_11:
          *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) 0;
          goto label_42;
label_15:
          *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) 0;
          goto label_42;
label_22:
          *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) 1;
          goto label_42;
label_26:
          *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) 0;
          goto label_42;
label_32:
          *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) 0;
          goto label_42;
label_37:
          *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) 1;
          goto label_42;
label_40:
          *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) 0;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) num2;
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
          // ISSUE: variable of a boxed type
          __Boxed<int> local4 = (ValueType) num4;
          // ISSUE: variable of a boxed type
          __Boxed<int> local5 = (ValueType) num1;
          // ISSUE: variable of a boxed type
          __Boxed<byte> local6 = (ValueType) num3;
          \u000E.\u0003.\u0002 obj = _param1;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) local4, (object) local5, (object) local6, (object) this, (object) obj);
          throw;
        }
label_42:
        return (bool) *(sbyte*) ((IntPtr) voidPtr + 8);
      }

      public \u000E.\u0003.\u0004 \u0001()
      {
        byte[] numArray1;
        try
        {
          do
          {
            numArray1 = new byte[this.\u0012];
          }
          while (false);
          Array.Copy((Array) this.\u000F, 0, (Array) numArray1, 0, this.\u0012);
          return new \u000E.\u0003.\u0004(numArray1);
        }
        catch (Exception ex)
        {
          byte[] numArray2 = numArray1;
          \u0005.\u0008.\u0001(ex, (object) numArray2, (object) this);
          throw;
        }
      }

      public \u000E.\u0003.\u0004 \u0002()
      {
        \u000E.\u0003.\u0004 obj;
        byte[] numArray1;
        try
        {
          byte[] numArray2 = new byte[this.\u0013];
          if (true)
            goto label_2;
label_1:
          if (true)
          {
            Array.Copy((Array) this.\u000F, this.\u0012, (Array) numArray1, 0, this.\u0013);
            if (true)
            {
              obj = new \u000E.\u0003.\u0004(numArray1);
              goto label_6;
            }
            else
              goto label_6;
          }
          else
            goto label_6;
label_2:
          numArray1 = numArray2;
          goto label_1;
        }
        catch (Exception ex)
        {
          byte[] numArray3 = numArray1;
          \u0005.\u0008.\u0001(ex, (object) numArray3, (object) this);
          throw;
        }
label_6:
        return obj;
      }

      static \u0005()
      {
        try
        {
          \u000E.\u0003.\u0005.\u0007 = new int[3]
          {
            3,
            3,
            11
          };
          \u000E.\u0003.\u0005.\u0008 = new int[3]
          {
            2,
            3,
            7
          };
          \u000E.\u0003.\u0005.\u0019 = new int[19]
          {
            16,
            17,
            18,
            0,
            8,
            7,
            9,
            6,
            10,
            5,
            11,
            4,
            12,
            3,
            13,
            2,
            14,
            1,
            15
          };
        }
        catch (Exception ex)
        {
          \u0005.\u0008.\u0001(ex);
          throw;
        }
      }
    }

    internal sealed class \u0006
    {
      private const int \u0001 = 4;
      private const int \u0002 = 8;
      private const int \u0003 = 16;
      private const int \u0004 = 20;
      private const int \u0005 = 28;
      private const int \u0006 = 30;
      private int \u0007 = 16;
      private long \u0008 = 0;
      private \u000E.\u0003.\u000E \u000E;
      private \u000E.\u0003.\u0008 \u000F;

      public \u0006()
      {
        try
        {
          this.\u000E = new \u000E.\u0003.\u000E();
          this.\u000F = new \u000E.\u0003.\u0008(this.\u000E);
        }
        catch (Exception ex)
        {
          \u0005.\u0008.\u0001(ex, (object) this);
          throw;
        }
      }

      public long TotalOut
      {
        get
        {
          long num;
          try
          {
            num = this.\u0008;
          }
          catch (Exception ex)
          {
            \u0005.\u0008.\u0001(ex, (object) this);
            throw;
          }
          return num;
        }
      }

      public void \u0001()
      {
        try
        {
          if (false)
            return;
          this.\u0007 |= 12;
        }
        catch (Exception ex)
        {
          \u0005.\u0008.\u0001(ex, (object) this);
          throw;
        }
      }

      public bool IsFinished
      {
        get
        {
          bool flag;
          try
          {
            do
            {
              int num;
              if (this.\u0007 != 30)
              {
                num = 0;
                if (num == 0)
                  flag = num != 0;
                else
                  goto label_4;
              }
              else
                goto label_3;
label_2:
              continue;
label_3:
              num = this.\u000E.IsFlushed ? 1 : 0;
label_4:
              flag = num != 0;
              if (false)
                goto label_2;
              else
                break;
            }
            while (false);
          }
          catch (Exception ex)
          {
            \u0005.\u0008.\u0001(ex, (object) this);
            throw;
          }
          return flag;
        }
      }

      public bool IsNeedingInput
      {
        get
        {
          bool flag;
          try
          {
            flag = this.\u000F.\u0001();
          }
          catch (Exception ex)
          {
            \u0005.\u0008.\u0001(ex, (object) this);
            throw;
          }
          return flag;
        }
      }

      public void \u0001(byte[] _param1)
      {
        try
        {
          this.\u000F.\u0001(_param1);
        }
        catch (Exception ex)
        {
          byte[] numArray = _param1;
          \u0005.\u0008.\u0001(ex, (object) this, (object) numArray);
          throw;
        }
      }

      public unsafe int \u0001(byte[] _param1)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(24);
        try
        {
          *(int*) voidPtr = 0;
          *(int*) ((IntPtr) voidPtr + 4) = _param1.Length;
          *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 4);
          while (true)
          {
            int num1;
            do
            {
              *(int*) ((IntPtr) voidPtr + 12) = this.\u000E.\u0001(_param1, *(int*) voidPtr, *(int*) ((IntPtr) voidPtr + 4));
              *(int*) voidPtr = *(int*) voidPtr + *(int*) ((IntPtr) voidPtr + 12);
              this.\u0008 += (long) *(int*) ((IntPtr) voidPtr + 12);
              *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) - *(int*) ((IntPtr) voidPtr + 12);
              if (*(int*) ((IntPtr) voidPtr + 4) != 0)
              {
                int num2 = this.\u0007;
label_3:
                int num3;
                int num4;
                if (true)
                {
                  num4 = 30;
                  num3 = num2;
                }
                else
                  goto label_7;
label_5:
                if (num3 != num4)
                  num2 = this.\u000F.\u0002((this.\u0007 & 4) != 0, (this.\u0007 & 8) != 0) ? 1 : 0;
                else
                  goto label_21;
label_7:
                if (true)
                {
                  if (num2 == 0)
                  {
                    num3 = this.\u0007;
                    num4 = 16;
                    if (num4 != 0)
                    {
                      if (num3 != num4)
                      {
                        int num5 = this.\u0007;
                        while (true)
                        {
                          if (num5 != 20)
                          {
                            num1 = this.\u0007;
                            if (false)
                              num5 = num1;
                            else
                              break;
                          }
                          else
                            goto label_14;
                        }
                      }
                      else
                        goto label_11;
                    }
                    else
                      goto label_5;
                  }
                }
                else
                  goto label_3;
              }
              else
                goto label_21;
            }
            while (num1 != 28);
            goto label_20;
label_14:
            *(int*) ((IntPtr) voidPtr + 16) = 8 + (-this.\u000E.BitCount & 7);
            while (*(int*) ((IntPtr) voidPtr + 16) > 0)
            {
              this.\u000E.\u0001(2, 10);
              *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) - 10;
            }
            this.\u0007 = 16;
            continue;
label_20:
            this.\u000E.\u0001();
            this.\u0007 = 30;
          }
label_11:
          *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 8) - *(int*) ((IntPtr) voidPtr + 4);
          goto label_24;
label_21:
          *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 8) - *(int*) ((IntPtr) voidPtr + 4);
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) *(int*) ((IntPtr) voidPtr + 8);
          // ISSUE: variable of a boxed type
          __Boxed<int> local4 = (ValueType) *(int*) ((IntPtr) voidPtr + 12);
          // ISSUE: variable of a boxed type
          __Boxed<int> local5 = (ValueType) *(int*) ((IntPtr) voidPtr + 16);
          byte[] numArray = _param1;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) local4, (object) local5, (object) this, (object) numArray);
          throw;
        }
label_24:
        return *(int*) ((IntPtr) voidPtr + 20);
      }
    }

    internal sealed class \u0007
    {
      private const int \u0001 = 16384;
      private const int \u0002 = 286;
      private const int \u0003 = 30;
      private const int \u0004 = 19;
      private const int \u0005 = 16;
      private const int \u0006 = 17;
      private const int \u0007 = 18;
      private const int \u0008 = 256;
      private static readonly int[] \u000E;
      private static readonly byte[] \u000F;
      private \u000E.\u0003.\u000E \u0010;
      private \u000E.\u0003.\u0007.\u0001 \u0011;
      private \u000E.\u0003.\u0007.\u0001 \u0012;
      private \u000E.\u0003.\u0007.\u0001 \u0013;
      private short[] \u0014;
      private byte[] \u0015;
      private int \u0016;
      private int \u0017;
      private static readonly short[] \u0018;
      private static readonly byte[] \u0019;
      private static readonly short[] \u001A;
      private static readonly byte[] \u001B;

      public static short \u0001(int _param0)
      {
        short num1;
        try
        {
          int num2 = (int) \u000E.\u0003.\u0007.\u000F[_param0 & 15];
          if (true)
            num2 <<= 12;
          int num3;
          if (true)
          {
            int num4 = (int) \u000E.\u0003.\u0007.\u000F[_param0 >> 4 & 15];
            int num5;
            while (true)
            {
              num5 = num4 << 8;
              if (false)
                num4 = num5;
              else
                break;
            }
            num3 = num2 | num5;
          }
          else
            goto label_7;
label_6:
          int num6 = (int) \u000E.\u0003.\u0007.\u000F[_param0 >> 8 & 15] << 4;
          num2 = num3 | num6 | (int) \u000E.\u0003.\u0007.\u000F[_param0 >> 12];
label_7:
          num3 = (int) (short) num2;
          if (true)
            num1 = (short) num3;
          else
            goto label_6;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local = (ValueType) _param0;
          \u0005.\u0008.\u0001(ex, (object) local);
          throw;
        }
        return num1;
      }

      static \u0007()
      {
        int index;
        try
        {
          \u000E.\u0003.\u0007.\u000E = new int[19]
          {
            16,
            17,
            18,
            0,
            8,
            7,
            9,
            6,
            10,
            5,
            11,
            4,
            12,
            3,
            13,
            2,
            14,
            1,
            15
          };
          \u000E.\u0003.\u0007.\u000F = new byte[16]
          {
            (byte) 0,
            (byte) 8,
            (byte) 4,
            (byte) 12,
            (byte) 2,
            (byte) 10,
            (byte) 6,
            (byte) 14,
            (byte) 1,
            (byte) 9,
            (byte) 5,
            (byte) 13,
            (byte) 3,
            (byte) 11,
            (byte) 7,
            (byte) 15
          };
          int length = 286;
          while (true)
          {
            \u000E.\u0003.\u0007.\u0018 = new short[length];
            \u000E.\u0003.\u0007.\u0019 = new byte[286];
            int num1;
            do
            {
              index = 0;
              int num2;
              while (true)
              {
                num1 = index;
                if (true)
                {
                  num2 = 144;
                  if (num2 != 0)
                  {
                    if (num1 < num2)
                    {
                      \u000E.\u0003.\u0007.\u0018[index] = \u000E.\u0003.\u0007.\u0001(48 + index << 8);
                      if (true)
                        \u000E.\u0003.\u0007.\u0019[index++] = (byte) 8;
                      else
                        goto label_10;
                    }
                    else
                      break;
                  }
                  else
                    goto label_9;
                }
                else
                  goto label_23;
              }
label_8:
              int num3 = index;
              num2 = 256;
              num1 = num3;
label_9:
              if (num1 < num2)
              {
                \u000E.\u0003.\u0007.\u0018[index] = \u000E.\u0003.\u0007.\u0001(256 + index << 7);
                \u000E.\u0003.\u0007.\u0019[index++] = (byte) 9;
                goto label_8;
              }
label_10:;
            }
            while (false);
            break;
label_23:
            length = num1;
          }
          for (; index < 280; \u000E.\u0003.\u0007.\u0019[index++] = (byte) 7)
          {
            \u000E.\u0003.\u0007.\u0018[index] = \u000E.\u0003.\u0007.\u0001(index - 256 << 9);
            if (false)
              goto label_19;
          }
label_15:
          for (; index < 286; \u000E.\u0003.\u0007.\u0019[index++] = (byte) 8)
            \u000E.\u0003.\u0007.\u0018[index] = \u000E.\u0003.\u0007.\u0001(index - 88 << 8);
          \u000E.\u0003.\u0007.\u001A = new short[30];
          \u000E.\u0003.\u0007.\u001B = new byte[30];
          index = 0;
label_19:
          for (; index < 30; ++index)
          {
            \u000E.\u0003.\u0007.\u001A[index] = \u000E.\u0003.\u0007.\u0001(index << 11);
            if (true)
              \u000E.\u0003.\u0007.\u001B[index] = (byte) 5;
            else
              goto label_15;
          }
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local = (ValueType) index;
          \u0005.\u0008.\u0001(ex, (object) local);
          throw;
        }
      }

      public \u0007(\u000E.\u0003.\u000E pending)
      {
        try
        {
          this.\u0010 = pending;
          this.\u0011 = new \u000E.\u0003.\u0007.\u0001(this, 286, 257, 15);
          this.\u0012 = new \u000E.\u0003.\u0007.\u0001(this, 30, 1, 15);
          this.\u0013 = new \u000E.\u0003.\u0007.\u0001(this, 19, 4, 7);
          this.\u0014 = new short[16384];
          this.\u0015 = new byte[16384];
        }
        catch (Exception ex)
        {
          \u000E.\u0003.\u000E obj = pending;
          \u0005.\u0008.\u0001(ex, (object) this, (object) obj);
          throw;
        }
      }

      public void \u0001()
      {
        try
        {
          do
          {
            if (true)
              goto label_2;
label_1:
            continue;
label_2:
            this.\u0016 = 0;
            goto label_1;
          }
          while (false);
          this.\u0017 = 0;
        }
        catch (Exception ex)
        {
          \u0005.\u0008.\u0001(ex, (object) this);
          throw;
        }
      }

      private unsafe int \u0001(int _param1)
      {
        void* voidPtr;
        if (true)
        {
          // ISSUE: untyped stack allocation
          voidPtr = (void*) __untypedstackalloc(8);
          try
          {
            do
            {
              int num1 = _param1;
              int num2 = (int) byte.MaxValue;
              if (num2 != 0)
              {
                if (num1 == num2)
                {
                  *(int*) ((IntPtr) voidPtr + 4) = 285;
                  continue;
                }
                goto label_8;
              }
              else
                goto label_5;
label_4:
              if (true)
              {
                int num3 = _param1;
                num2 = 8;
                num1 = num3;
              }
              else
                goto label_8;
label_5:
              if (num1 < num2)
              {
                *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr + _param1;
                break;
              }
              do
              {
                *(int*) voidPtr = *(int*) voidPtr + 4;
              }
              while (false);
              _param1 >>= 1;
              goto label_4;
label_8:
              *(int*) voidPtr = 257;
              goto label_4;
            }
            while (false);
          }
          catch (Exception ex)
          {
            // ISSUE: variable of a boxed type
            __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
            // ISSUE: variable of a boxed type
            __Boxed<int> local2 = (ValueType) _param1;
            \u0005.\u0008.\u0001(ex, (object) local1, (object) this, (object) local2);
            throw;
          }
        }
        return *(int*) ((IntPtr) voidPtr + 4);
      }

      private unsafe int \u0002(int _param1)
      {
        void* voidPtr;
        int num1;
        do
        {
          num1 = 8;
          if (num1 != 0)
          {
            // ISSUE: untyped stack allocation
            voidPtr = (void*) __untypedstackalloc(num1);
            try
            {
              do
              {
                *(int*) voidPtr = 0;
              }
              while (false);
              int num2;
              for (; _param1 >= 4; _param1 = num2)
              {
                if (true)
                  *(int*) voidPtr = *(int*) voidPtr + 2;
                int num3 = _param1;
                while (true)
                {
                  num2 = num3 >> 1;
                  if (false)
                    num3 = num2;
                  else
                    break;
                }
              }
              *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr + _param1;
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a boxed type
              __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
              // ISSUE: variable of a boxed type
              __Boxed<int> local2 = (ValueType) _param1;
              \u0005.\u0008.\u0001(ex, (object) local1, (object) this, (object) local2);
              throw;
            }
          }
          else
            goto label_6;
        }
        while (false);
        goto label_14;
label_6:
        return num1;
label_14:
        return *(int*) ((IntPtr) voidPtr + 4);
      }

      public void \u0001(int _param1)
      {
label_0:
        int index;
        try
        {
          this.\u0013.\u0001();
          this.\u0011.\u0001();
          this.\u0012.\u0001();
          if (true)
            goto label_10;
label_2:
          if (false)
            return;
          this.\u0010.\u0001((int) this.\u0013.\u0002[\u000E.\u0003.\u0007.\u000E[index]], 3);
          int num1;
          int num2;
          if (true)
          {
            num1 = index;
            num2 = 1;
            if (num2 != 0)
              index = num1 + num2;
            else
              goto label_7;
          }
          else
            goto label_0;
label_6:
          int num3 = index;
          num2 = _param1;
          num1 = num3;
label_7:
          if (num1 >= num2)
          {
            this.\u0011.\u0002(this.\u0013);
            this.\u0012.\u0002(this.\u0013);
            return;
          }
          goto label_2;
label_10:
          \u000E.\u0003.\u000E obj = this.\u0010;
          int num4 = this.\u0011.\u0004 - 257;
          if (true)
            goto label_11;
label_1:
          do
          {
            this.\u0010.\u0001(this.\u0012.\u0004 - 1, 5);
            this.\u0010.\u0001(_param1 - 4, 4);
            index = 0;
          }
          while (false);
          goto label_6;
label_11:
          obj.\u0001(num4, 5);
          goto label_1;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) index;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) _param1;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) this, (object) local2);
          throw;
        }
      }

      public unsafe void \u0002()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(20);
        int num;
        try
        {
          *(int*) voidPtr = 0;
          while (*(int*) voidPtr < this.\u0016)
          {
            *(int*) ((IntPtr) voidPtr + 4) = (int) this.\u0015[*(int*) voidPtr] & (int) byte.MaxValue;
            num = (int) this.\u0014[*(int*) voidPtr];
            if (num-- != 0)
            {
              *(int*) ((IntPtr) voidPtr + 8) = this.\u0001(*(int*) ((IntPtr) voidPtr + 4));
              this.\u0011.\u0001(*(int*) ((IntPtr) voidPtr + 8));
              *(int*) ((IntPtr) voidPtr + 12) = (*(int*) ((IntPtr) voidPtr + 8) - 261) / 4;
              if (*(int*) ((IntPtr) voidPtr + 12) > 0 && *(int*) ((IntPtr) voidPtr + 12) <= 5)
                this.\u0010.\u0001(*(int*) ((IntPtr) voidPtr + 4) & (1 << *(int*) ((IntPtr) voidPtr + 12)) - 1, *(int*) ((IntPtr) voidPtr + 12));
              *(int*) ((IntPtr) voidPtr + 16) = this.\u0002(num);
              this.\u0012.\u0001(*(int*) ((IntPtr) voidPtr + 16));
              *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 16) / 2 - 1;
              if (*(int*) ((IntPtr) voidPtr + 12) > 0)
                this.\u0010.\u0001(num & (1 << *(int*) ((IntPtr) voidPtr + 12)) - 1, *(int*) ((IntPtr) voidPtr + 12));
            }
            else
              this.\u0011.\u0001(*(int*) ((IntPtr) voidPtr + 4));
            *(int*) voidPtr = *(int*) voidPtr + 1;
          }
          this.\u0011.\u0001(256);
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) num;
          // ISSUE: variable of a boxed type
          __Boxed<int> local4 = (ValueType) *(int*) ((IntPtr) voidPtr + 8);
          // ISSUE: variable of a boxed type
          __Boxed<int> local5 = (ValueType) *(int*) ((IntPtr) voidPtr + 12);
          // ISSUE: variable of a boxed type
          __Boxed<int> local6 = (ValueType) *(int*) ((IntPtr) voidPtr + 16);
          \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) local4, (object) local5, (object) local6, (object) this);
          throw;
        }
      }

      public void \u0001(byte[] _param1, int _param2, int _param3, bool _param4)
      {
        try
        {
          if (true)
            this.\u0010.\u0001(_param4 ? 1 : 0, 3);
          this.\u0010.\u0001();
          if (true)
            goto label_5;
label_1:
          if (true)
          {
            this.\u0001();
            return;
          }
          goto label_6;
label_5:
          this.\u0010.\u0001(_param3);
label_6:
          this.\u0010.\u0001(~_param3);
          this.\u0010.\u0001(_param1, _param2, _param3);
          goto label_1;
        }
        catch (Exception ex)
        {
          byte[] numArray = _param1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) _param2;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) _param3;
          // ISSUE: variable of a boxed type
          __Boxed<bool> local3 = (ValueType) _param4;
          \u0005.\u0008.\u0001(ex, (object) this, (object) numArray, (object) local1, (object) local2, (object) local3);
          throw;
        }
      }

      public unsafe void \u0002(byte[] _param1, int _param2, int _param3, bool _param4)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(24);
        short[] numArray1;
        try
        {
          short[] numArray2 = this.\u0011.\u0001;
          if (true)
            goto label_20;
label_2:
          numArray2[256] = (short) ((int) numArray1[256] + 1);
          this.\u0011.\u0002();
          this.\u0012.\u0002();
          this.\u0011.\u0001(this.\u0013);
          this.\u0012.\u0001(this.\u0013);
          this.\u0013.\u0002();
          *(int*) voidPtr = 4;
          *(int*) ((IntPtr) voidPtr + 4) = 18;
          do
          {
            while (*(int*) ((IntPtr) voidPtr + 4) > *(int*) voidPtr)
            {
              if (this.\u0013.\u0002[\u000E.\u0003.\u0007.\u000E[*(int*) ((IntPtr) voidPtr + 4)]] > (byte) 0)
                *(int*) voidPtr = *(int*) ((IntPtr) voidPtr + 4) + 1;
              *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) - 1;
            }
            *(int*) ((IntPtr) voidPtr + 8) = 14 + *(int*) voidPtr * 3 + this.\u0013.\u0001() + this.\u0011.\u0001() + this.\u0012.\u0001() + this.\u0017;
            *(int*) ((IntPtr) voidPtr + 12) = this.\u0017;
            *(int*) ((IntPtr) voidPtr + 16) = 0;
            while (*(int*) ((IntPtr) voidPtr + 16) < 286)
            {
              *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + (int) this.\u0011.\u0001[*(int*) ((IntPtr) voidPtr + 16)] * (int) \u000E.\u0003.\u0007.\u0019[*(int*) ((IntPtr) voidPtr + 16)];
              *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) + 1;
            }
            *(int*) ((IntPtr) voidPtr + 20) = 0;
          }
          while (false);
          while (*(int*) ((IntPtr) voidPtr + 20) < 30)
          {
            *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + (int) this.\u0012.\u0001[*(int*) ((IntPtr) voidPtr + 20)] * (int) \u000E.\u0003.\u0007.\u001B[*(int*) ((IntPtr) voidPtr + 20)];
            *(int*) ((IntPtr) voidPtr + 20) = *(int*) ((IntPtr) voidPtr + 20) + 1;
          }
          if (*(int*) ((IntPtr) voidPtr + 8) >= *(int*) ((IntPtr) voidPtr + 12))
            *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 12);
          if (_param2 >= 0 && _param3 + 4 < *(int*) ((IntPtr) voidPtr + 8) >> 3)
          {
            this.\u0001(_param1, _param2, _param3, _param4);
            return;
          }
          if (*(int*) ((IntPtr) voidPtr + 8) == *(int*) ((IntPtr) voidPtr + 12))
          {
            this.\u0010.\u0001(2 + (_param4 ? 1 : 0), 3);
            this.\u0011.\u0001(\u000E.\u0003.\u0007.\u0018, \u000E.\u0003.\u0007.\u0019);
            this.\u0012.\u0001(\u000E.\u0003.\u0007.\u001A, \u000E.\u0003.\u0007.\u001B);
            this.\u0002();
            this.\u0001();
            return;
          }
          this.\u0010.\u0001(4 + (_param4 ? 1 : 0), 3);
          this.\u0001(*(int*) voidPtr);
          this.\u0002();
          this.\u0001();
          return;
label_20:
          numArray1 = numArray2;
          goto label_2;
        }
        catch (Exception ex)
        {
          object[] objArray = new object[12]
          {
            (object) *(int*) voidPtr,
            (object) *(int*) ((IntPtr) voidPtr + 4),
            (object) *(int*) ((IntPtr) voidPtr + 8),
            (object) *(int*) ((IntPtr) voidPtr + 12),
            (object) *(int*) ((IntPtr) voidPtr + 16),
            (object) *(int*) ((IntPtr) voidPtr + 20),
            (object) numArray1,
            (object) this,
            (object) _param1,
            (object) _param2,
            (object) _param3,
            (object) _param4
          };
          \u0005.\u0008.\u0001(ex, objArray);
          throw;
        }
      }

      public bool \u0001()
      {
        bool flag;
        try
        {
          do
          {
            do
            {
              if (true)
                goto label_5;
label_3:
              continue;
label_5:
              int num1 = this.\u0016 < 16384 ? 1 : 0;
              int num2;
              while (true)
              {
                num2 = num1 == 0 ? 1 : 0;
                if (false)
                  num1 = num2;
                else
                  break;
              }
              flag = num2 != 0;
              goto label_3;
            }
            while (false);
          }
          while (false);
        }
        catch (Exception ex)
        {
          \u0005.\u0008.\u0001(ex, (object) this);
          throw;
        }
        return flag;
      }

      public bool \u0001(int _param1)
      {
        short[] numArray1;
        int num1;
        int index1;
        try
        {
          this.\u0014[this.\u0016] = (short) 0;
          byte[] numArray2 = this.\u0015;
          \u000E.\u0003.\u0007 obj = this;
          int num2;
          num1 = num2 = obj.\u0016;
          obj.\u0016 = num2 + 1;
          int index2 = num1;
          int num3 = (int) (byte) _param1;
          numArray2[index2] = (byte) num3;
          (numArray1 = this.\u0011.\u0001)[index1 = _param1] = (short) ((int) numArray1[(IntPtr) index1] + 1);
          return this.\u0001();
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) num1;
          short[] numArray3 = numArray1;
          // ISSUE: variable of a boxed type
          __Boxed<IntPtr> local2 = (ValueType) (IntPtr) index1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) _param1;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) numArray3, (object) local2, (object) this, (object) local3);
          throw;
        }
      }

      public unsafe bool \u0001(int _param1, int _param2)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(9);
        short[] numArray1;
        IntPtr index1;
        int num1;
        try
        {
          this.\u0014[this.\u0016] = (short) _param1;
          byte[] numArray2 = this.\u0015;
          \u000E.\u0003.\u0007 obj = this;
          int num2 = obj.\u0016;
          if (true)
            goto label_7;
label_2:
          obj.\u0016 = num2 + 1;
          int index2 = num1;
          int num3 = (int) (byte) (_param2 - 3);
          numArray2[index2] = (byte) num3;
          *(int*) voidPtr = this.\u0001(_param2 - 3);
          (numArray1 = this.\u0011.\u0001)[(int) (index1 = (IntPtr) *(int*) voidPtr)] = (short) ((int) numArray1[index1] + 1);
          if (*(int*) voidPtr >= 265 && *(int*) voidPtr < 285)
            this.\u0017 += (*(int*) voidPtr - 261) / 4;
          *(int*) ((IntPtr) voidPtr + 4) = this.\u0002(_param1 - 1);
          (numArray1 = this.\u0012.\u0001)[(int) (index1 = (IntPtr) *(int*) ((IntPtr) voidPtr + 4))] = (short) ((int) numArray1[index1] + 1);
          if (*(int*) ((IntPtr) voidPtr + 4) >= 4)
            this.\u0017 += *(int*) ((IntPtr) voidPtr + 4) / 2 - 1;
          *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) this.\u0001();
          goto label_9;
label_7:
          num1 = num2;
          goto label_2;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) num1;
          short[] numArray3 = numArray1;
          // ISSUE: variable of a boxed type
          __Boxed<IntPtr> local4 = (ValueType) index1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local5 = (ValueType) _param1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local6 = (ValueType) _param2;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) numArray3, (object) local4, (object) this, (object) local5, (object) local6);
          throw;
        }
label_9:
        return (bool) *(sbyte*) ((IntPtr) voidPtr + 8);
      }

      public sealed class \u0001
      {
        public short[] \u0001;
        public byte[] \u0002;
        public int \u0003;
        public int \u0004;
        private short[] \u0005;
        private int[] \u0006;
        private int \u0007;
        private \u000E.\u0003.\u0007 \u0008;

        public \u0001(\u000E.\u0003.\u0007 dh, int elems, int minCodes, int maxLength)
        {
          try
          {
            this.\u0008 = dh;
            this.\u0003 = minCodes;
            this.\u0007 = maxLength;
            this.\u0001 = new short[elems];
            this.\u0006 = new int[maxLength];
          }
          catch (Exception ex)
          {
            \u000E.\u0003.\u0007 obj = dh;
            // ISSUE: variable of a boxed type
            __Boxed<int> local1 = (ValueType) elems;
            // ISSUE: variable of a boxed type
            __Boxed<int> local2 = (ValueType) minCodes;
            // ISSUE: variable of a boxed type
            __Boxed<int> local3 = (ValueType) maxLength;
            \u0005.\u0008.\u0001(ex, (object) this, (object) obj, (object) local1, (object) local2, (object) local3);
            throw;
          }
        }

        public void \u0001(int _param1)
        {
          try
          {
            do
            {
              if (true)
                goto label_3;
label_1:
              continue;
label_3:
              this.\u0008.\u0010.\u0001((int) this.\u0005[_param1] & (int) ushort.MaxValue, (int) this.\u0002[_param1]);
              goto label_1;
            }
            while (false);
          }
          catch (Exception ex)
          {
            // ISSUE: variable of a boxed type
            __Boxed<int> local = (ValueType) _param1;
            \u0005.\u0008.\u0001(ex, (object) this, (object) local);
            throw;
          }
        }

        public void \u0001(short[] _param1, byte[] _param2)
        {
label_0:
          try
          {
            if (false)
              goto label_2;
            else
              goto label_4;
label_1:
            if (true)
              this.\u0002 = _param2;
            else
              goto label_0;
label_2:
            if (true)
              return;
            goto label_1;
label_4:
            this.\u0005 = _param1;
            goto label_1;
          }
          catch (Exception ex)
          {
            short[] numArray1 = _param1;
            byte[] numArray2 = _param2;
            \u0005.\u0008.\u0001(ex, (object) this, (object) numArray1, (object) numArray2);
            throw;
          }
        }

        public unsafe void \u0001()
        {
          // ISSUE: untyped stack allocation
          void* voidPtr = (void*) __untypedstackalloc(16);
          int[] numArray1;
          int[] numArray2;
          IntPtr index;
          try
          {
            int length = this.\u0001.Length;
            numArray1 = new int[this.\u0007];
            *(int*) voidPtr = 0;
            this.\u0005 = new short[this.\u0001.Length];
            *(int*) ((IntPtr) voidPtr + 4) = 0;
            while (*(int*) ((IntPtr) voidPtr + 4) < this.\u0007)
            {
              numArray1[*(int*) ((IntPtr) voidPtr + 4)] = *(int*) voidPtr;
              *(int*) voidPtr = *(int*) voidPtr + (this.\u0006[*(int*) ((IntPtr) voidPtr + 4)] << 15 - *(int*) ((IntPtr) voidPtr + 4));
              *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
            }
            *(int*) ((IntPtr) voidPtr + 8) = 0;
            while (true)
            {
              int num1 = *(int*) ((IntPtr) voidPtr + 8);
              int num2 = this.\u0004;
              if (true)
                goto label_9;
label_5:
              if (num1 > num2)
              {
                this.\u0005[*(int*) ((IntPtr) voidPtr + 8)] = \u000E.\u0003.\u0007.\u0001(numArray1[*(int*) ((IntPtr) voidPtr + 12) - 1]);
                (numArray2 = numArray1)[(int) (index = (IntPtr) (*(int*) ((IntPtr) voidPtr + 12) - 1))] = numArray2[index] + (1 << 16 - *(int*) ((IntPtr) voidPtr + 12));
              }
              *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
              continue;
label_9:
              if (num1 < num2)
              {
                *(int*) ((IntPtr) voidPtr + 12) = (int) this.\u0002[*(int*) ((IntPtr) voidPtr + 8)];
                int num3 = *(int*) ((IntPtr) voidPtr + 12);
                num2 = 0;
                num1 = num3;
                goto label_5;
              }
              else
                break;
            }
          }
          catch (Exception ex)
          {
            int[] numArray3 = numArray1;
            // ISSUE: variable of a boxed type
            __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
            // ISSUE: variable of a boxed type
            __Boxed<int> local2 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
            // ISSUE: variable of a boxed type
            __Boxed<int> local3 = (ValueType) *(int*) ((IntPtr) voidPtr + 8);
            // ISSUE: variable of a boxed type
            __Boxed<int> local4 = (ValueType) *(int*) ((IntPtr) voidPtr + 12);
            int[] numArray4 = numArray2;
            // ISSUE: variable of a boxed type
            __Boxed<IntPtr> local5 = (ValueType) index;
            \u0005.\u0008.\u0001(ex, (object) numArray3, (object) local1, (object) local2, (object) local3, (object) local4, (object) numArray4, (object) local5, (object) this);
            throw;
          }
        }

        private unsafe void \u0001(int[] _param1)
        {
          // ISSUE: untyped stack allocation
          void* voidPtr = (void*) __untypedstackalloc(36);
          int[] numArray1;
          int num1;
          int[] numArray2;
          IntPtr index1;
          int num2;
          int num3;
          int index2;
          try
          {
            this.\u0002 = new byte[this.\u0001.Length];
            *(int*) voidPtr = _param1.Length / 2;
            *(int*) ((IntPtr) voidPtr + 4) = (*(int*) voidPtr + 1) / 2;
            *(int*) ((IntPtr) voidPtr + 8) = 0;
            *(int*) ((IntPtr) voidPtr + 12) = 0;
            while (true)
            {
              if (*(int*) ((IntPtr) voidPtr + 12) >= this.\u0007)
                goto label_4;
label_2:
              this.\u0006[*(int*) ((IntPtr) voidPtr + 12)] = 0;
              *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
              continue;
label_4:
              numArray1 = new int[*(int*) voidPtr];
              numArray1[*(int*) voidPtr - 1] = 0;
              *(int*) ((IntPtr) voidPtr + 16) = *(int*) voidPtr - 1;
              if (true)
                goto label_11;
label_10:
              *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) - 1;
label_11:
              if (*(int*) ((IntPtr) voidPtr + 16) >= 0)
              {
                if (_param1[2 * *(int*) ((IntPtr) voidPtr + 16) + 1] != -1)
                {
                  *(int*) ((IntPtr) voidPtr + 20) = numArray1[*(int*) ((IntPtr) voidPtr + 16)] + 1;
                  if (*(int*) ((IntPtr) voidPtr + 20) > this.\u0007)
                  {
                    *(int*) ((IntPtr) voidPtr + 20) = this.\u0007;
                    *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
                  }
                  int[] numArray3 = numArray1;
                  int index3 = _param1[2 * *(int*) ((IntPtr) voidPtr + 16)];
                  numArray1[_param1[2 * *(int*) ((IntPtr) voidPtr + 16) + 1]] = num1 = *(int*) ((IntPtr) voidPtr + 20);
                  int num4 = num1;
                  numArray3[index3] = num4;
                  goto label_10;
                }
                else
                {
                  *(int*) ((IntPtr) voidPtr + 24) = numArray1[*(int*) ((IntPtr) voidPtr + 16)];
                  (numArray2 = this.\u0006)[(int) (index1 = (IntPtr) (*(int*) ((IntPtr) voidPtr + 24) - 1))] = numArray2[index1] + 1;
                  this.\u0002[_param1[2 * *(int*) ((IntPtr) voidPtr + 16)]] = (byte) numArray1[*(int*) ((IntPtr) voidPtr + 16)];
                  goto label_10;
                }
              }
              else if (*(int*) ((IntPtr) voidPtr + 8) != 0)
              {
                num2 = this.\u0007 - 1;
                do
                {
                  do
                    ;
                  while (this.\u0006[--num2] == 0);
                  do
                  {
                    (numArray2 = this.\u0006)[(int) (index1 = (IntPtr) num2)] = numArray2[index1] - 1;
                    int[] numArray4;
                    numArray2 = numArray4 = this.\u0006;
                    int index4;
                    num2 = index4 = num2 + 1;
                    index1 = (IntPtr) index4;
                    int num5 = numArray2[index1] + 1;
                    numArray4[index4] = num5;
                    *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - (1 << this.\u0007 - 1 - num2);
                  }
                  while (*(int*) ((IntPtr) voidPtr + 8) > 0 && num2 < this.\u0007 - 1);
                }
                while (*(int*) ((IntPtr) voidPtr + 8) > 0);
                (numArray2 = this.\u0006)[(int) (index1 = (IntPtr) (this.\u0007 - 1))] = numArray2[index1] + *(int*) ((IntPtr) voidPtr + 8);
                (numArray2 = this.\u0006)[(int) (index1 = (IntPtr) (this.\u0007 - 2))] = numArray2[index1] - *(int*) ((IntPtr) voidPtr + 8);
                num3 = 2 * *(int*) ((IntPtr) voidPtr + 4);
                *(int*) ((IntPtr) voidPtr + 28) = this.\u0007;
                while (*(int*) ((IntPtr) voidPtr + 28) != 0)
                {
                  *(int*) ((IntPtr) voidPtr + 32) = this.\u0006[*(int*) ((IntPtr) voidPtr + 28) - 1];
                  while (*(int*) ((IntPtr) voidPtr + 32) > 0)
                  {
                    index2 = 2 * _param1[num3++];
                    if (true)
                    {
                      if (_param1[index2 + 1] == -1)
                      {
                        this.\u0002[_param1[index2]] = (byte) *(int*) ((IntPtr) voidPtr + 28);
                        *(int*) ((IntPtr) voidPtr + 32) = *(int*) ((IntPtr) voidPtr + 32) - 1;
                      }
                    }
                    else
                      goto label_2;
                  }
                  *(int*) ((IntPtr) voidPtr + 28) = *(int*) ((IntPtr) voidPtr + 28) - 1;
                }
                goto label_13;
              }
              else
                break;
            }
            return;
label_13:;
          }
          catch (Exception ex)
          {
            object[] objArray = new object[18]
            {
              (object) *(int*) voidPtr,
              (object) *(int*) ((IntPtr) voidPtr + 4),
              (object) *(int*) ((IntPtr) voidPtr + 8),
              (object) *(int*) ((IntPtr) voidPtr + 12),
              (object) numArray1,
              (object) *(int*) ((IntPtr) voidPtr + 16),
              (object) *(int*) ((IntPtr) voidPtr + 20),
              (object) *(int*) ((IntPtr) voidPtr + 24),
              (object) num2,
              (object) num3,
              (object) *(int*) ((IntPtr) voidPtr + 28),
              (object) *(int*) ((IntPtr) voidPtr + 32),
              (object) index2,
              (object) num1,
              (object) numArray2,
              (object) index1,
              (object) this,
              (object) _param1
            };
            \u0005.\u0008.\u0001(ex, objArray);
            throw;
          }
        }

        public unsafe void \u0002()
        {
          // ISSUE: untyped stack allocation
          void* voidPtr = (void*) __untypedstackalloc(36);
          int num1;
          int index1;
          int[] numArray1;
          int index2;
          int num2;
          int num3;
          int[] numArray2;
          int[] numArray3;
          int num4;
          int index3;
          int index4;
          int index5;
          int num5;
          try
          {
            *(int*) voidPtr = this.\u0001.Length;
            numArray1 = new int[*(int*) voidPtr];
            num1 = 0;
            num2 = 0;
            *(int*) ((IntPtr) voidPtr + 4) = 0;
            while (*(int*) ((IntPtr) voidPtr + 4) < *(int*) voidPtr)
            {
              *(int*) ((IntPtr) voidPtr + 8) = (int) this.\u0001[*(int*) ((IntPtr) voidPtr + 4)];
              if (*(int*) ((IntPtr) voidPtr + 8) != 0)
              {
                for (index1 = num1++; index1 > 0 && (int) this.\u0001[numArray1[index2 = (index1 - 1) / 2]] > *(int*) ((IntPtr) voidPtr + 8); index1 = index2)
                  numArray1[index1] = numArray1[index2];
                numArray1[index1] = *(int*) ((IntPtr) voidPtr + 4);
                num2 = *(int*) ((IntPtr) voidPtr + 4);
              }
              *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
            }
            for (; num1 < 2; numArray1[num1++] = num3)
            {
              int num6;
              if (num2 >= 2)
                num6 = 0;
              else
                num2 = num6 = num2 + 1;
              num3 = num6;
            }
            this.\u0004 = Math.Max(num2 + 1, this.\u0003);
            *(int*) ((IntPtr) voidPtr + 12) = num1;
            int num7 = 4 * num1;
            if (true)
            {
              numArray2 = new int[num7 - 2];
              numArray3 = new int[2 * num1 - 1];
              num4 = *(int*) ((IntPtr) voidPtr + 12);
              *(int*) ((IntPtr) voidPtr + 16) = 0;
              while (*(int*) ((IntPtr) voidPtr + 16) < num1)
              {
                *(int*) ((IntPtr) voidPtr + 20) = numArray1[*(int*) ((IntPtr) voidPtr + 16)];
                numArray2[2 * *(int*) ((IntPtr) voidPtr + 16)] = *(int*) ((IntPtr) voidPtr + 20);
                numArray2[2 * *(int*) ((IntPtr) voidPtr + 16) + 1] = -1;
                numArray3[*(int*) ((IntPtr) voidPtr + 16)] = (int) this.\u0001[*(int*) ((IntPtr) voidPtr + 20)] << 8;
                numArray1[*(int*) ((IntPtr) voidPtr + 16)] = *(int*) ((IntPtr) voidPtr + 16);
                *(int*) ((IntPtr) voidPtr + 16) = *(int*) ((IntPtr) voidPtr + 16) + 1;
              }
            }
            else
              goto label_25;
label_17:
            *(int*) ((IntPtr) voidPtr + 24) = numArray1[0];
            index3 = numArray1[--num1];
            index4 = 0;
            for (index5 = 1; index5 < num1; index5 = index5 * 2 + 1)
            {
              if (index5 + 1 < num1 && numArray3[numArray1[index5]] > numArray3[numArray1[index5 + 1]])
                ++index5;
              numArray1[index4] = numArray1[index5];
              index4 = index5;
            }
            num5 = numArray3[index3];
label_24:
            num7 = index5 = index4;
label_25:
            if (num7 > 0 && numArray3[numArray1[index4 = (index5 - 1) / 2]] > num5)
            {
              numArray1[index5] = numArray1[index4];
              goto label_24;
            }
            else
            {
              numArray1[index5] = index3;
              *(int*) ((IntPtr) voidPtr + 28) = numArray1[0];
              index3 = num4++;
              numArray2[2 * index3] = *(int*) ((IntPtr) voidPtr + 24);
              numArray2[2 * index3 + 1] = *(int*) ((IntPtr) voidPtr + 28);
              *(int*) ((IntPtr) voidPtr + 32) = Math.Min(numArray3[*(int*) ((IntPtr) voidPtr + 24)] & (int) byte.MaxValue, numArray3[*(int*) ((IntPtr) voidPtr + 28)] & (int) byte.MaxValue);
              numArray3[index3] = num5 = numArray3[*(int*) ((IntPtr) voidPtr + 24)] + numArray3[*(int*) ((IntPtr) voidPtr + 28)] - *(int*) ((IntPtr) voidPtr + 32) + 1;
              index4 = 0;
              for (index5 = 1; index5 < num1; index5 = index4 * 2 + 1)
              {
                if (index5 + 1 < num1 && numArray3[numArray1[index5]] > numArray3[numArray1[index5 + 1]])
                  ++index5;
                numArray1[index4] = numArray1[index5];
                index4 = index5;
              }
              while ((index5 = index4) > 0 && numArray3[numArray1[index4 = (index5 - 1) / 2]] > num5)
                numArray1[index5] = numArray1[index4];
              numArray1[index5] = index3;
              if (num1 <= 1)
                this.\u0001(numArray2);
              else
                goto label_17;
            }
          }
          catch (Exception ex)
          {
            object[] objArray = new object[23]
            {
              (object) *(int*) voidPtr,
              (object) numArray1,
              (object) num1,
              (object) num2,
              (object) *(int*) ((IntPtr) voidPtr + 4),
              (object) *(int*) ((IntPtr) voidPtr + 8),
              (object) index1,
              (object) index2,
              (object) num3,
              (object) *(int*) ((IntPtr) voidPtr + 12),
              (object) numArray2,
              (object) numArray3,
              (object) num4,
              (object) *(int*) ((IntPtr) voidPtr + 16),
              (object) *(int*) ((IntPtr) voidPtr + 20),
              (object) *(int*) ((IntPtr) voidPtr + 24),
              (object) index3,
              (object) index4,
              (object) index5,
              (object) num5,
              (object) *(int*) ((IntPtr) voidPtr + 28),
              (object) *(int*) ((IntPtr) voidPtr + 32),
              (object) this
            };
            \u0005.\u0008.\u0001(ex, objArray);
            throw;
          }
        }

        public unsafe int \u0001()
        {
          // ISSUE: untyped stack allocation
          IntPtr num = __untypedstackalloc(12);
          if (true)
            goto label_7;
label_1:
          void* voidPtr;
          try
          {
            *(int*) voidPtr = 0;
            *(int*) ((IntPtr) voidPtr + 4) = 0;
            while (*(int*) ((IntPtr) voidPtr + 4) < this.\u0001.Length)
            {
              *(int*) voidPtr = *(int*) voidPtr + (int) this.\u0001[*(int*) ((IntPtr) voidPtr + 4)] * (int) this.\u0002[*(int*) ((IntPtr) voidPtr + 4)];
              *(int*) ((IntPtr) voidPtr + 4) = *(int*) ((IntPtr) voidPtr + 4) + 1;
            }
            *(int*) ((IntPtr) voidPtr + 8) = *(int*) voidPtr;
          }
          catch (Exception ex)
          {
            // ISSUE: variable of a boxed type
            __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
            // ISSUE: variable of a boxed type
            __Boxed<int> local2 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
            \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) this);
            throw;
          }
          return *(int*) ((IntPtr) voidPtr + 8);
label_7:
          voidPtr = (void*) num;
          goto label_1;
        }

        public unsafe void \u0001(\u000E.\u0003.\u0007.\u0001 _param1)
        {
          // ISSUE: untyped stack allocation
          void* voidPtr = (void*) __untypedstackalloc(20);
          short[] numArray1;
          IntPtr index;
          int num;
          try
          {
            *(int*) ((IntPtr) voidPtr + 8) = -1;
            *(int*) ((IntPtr) voidPtr + 12) = 0;
            while (*(int*) ((IntPtr) voidPtr + 12) < this.\u0004)
            {
              num = 1;
              *(int*) ((IntPtr) voidPtr + 16) = (int) this.\u0002[*(int*) ((IntPtr) voidPtr + 12)];
              if (*(int*) ((IntPtr) voidPtr + 16) != 0)
              {
                *(int*) voidPtr = 6;
                *(int*) ((IntPtr) voidPtr + 4) = 3;
                if (*(int*) ((IntPtr) voidPtr + 8) != *(int*) ((IntPtr) voidPtr + 16))
                {
                  if (false)
                    break;
                  (numArray1 = _param1.\u0001)[(int) (index = (IntPtr) *(int*) ((IntPtr) voidPtr + 16))] = (short) ((int) numArray1[index] + 1);
                  num = 0;
                }
              }
              else
                goto label_19;
label_7:
              *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 16);
              *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
              while (*(int*) ((IntPtr) voidPtr + 12) < this.\u0004 && *(int*) ((IntPtr) voidPtr + 8) == (int) this.\u0002[*(int*) ((IntPtr) voidPtr + 12)])
              {
                *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
                if (++num >= *(int*) voidPtr)
                  break;
              }
              if (num < *(int*) ((IntPtr) voidPtr + 4))
              {
                (numArray1 = _param1.\u0001)[(int) (index = (IntPtr) *(int*) ((IntPtr) voidPtr + 8))] = (short) ((int) numArray1[index] + (int) (short) num);
                continue;
              }
              if (*(int*) ((IntPtr) voidPtr + 8) != 0)
              {
                (numArray1 = _param1.\u0001)[16] = (short) ((int) numArray1[16] + 1);
                continue;
              }
              if (num <= 10)
              {
                (numArray1 = _param1.\u0001)[17] = (short) ((int) numArray1[17] + 1);
                continue;
              }
              (numArray1 = _param1.\u0001)[18] = (short) ((int) numArray1[18] + 1);
              continue;
label_19:
              *(int*) voidPtr = 138;
              *(int*) ((IntPtr) voidPtr + 4) = 3;
              goto label_7;
            }
          }
          catch (Exception ex)
          {
            // ISSUE: variable of a boxed type
            __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
            // ISSUE: variable of a boxed type
            __Boxed<int> local2 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
            // ISSUE: variable of a boxed type
            __Boxed<int> local3 = (ValueType) num;
            // ISSUE: variable of a boxed type
            __Boxed<int> local4 = (ValueType) *(int*) ((IntPtr) voidPtr + 8);
            // ISSUE: variable of a boxed type
            __Boxed<int> local5 = (ValueType) *(int*) ((IntPtr) voidPtr + 12);
            // ISSUE: variable of a boxed type
            __Boxed<int> local6 = (ValueType) *(int*) ((IntPtr) voidPtr + 16);
            short[] numArray2 = numArray1;
            // ISSUE: variable of a boxed type
            __Boxed<IntPtr> local7 = (ValueType) index;
            \u000E.\u0003.\u0007.\u0001 obj = _param1;
            \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) local4, (object) local5, (object) local6, (object) numArray2, (object) local7, (object) this, (object) obj);
            throw;
          }
        }

        public unsafe void \u0002(\u000E.\u0003.\u0007.\u0001 _param1)
        {
          // ISSUE: untyped stack allocation
          void* voidPtr = (void*) __untypedstackalloc(20);
          int num1;
          try
          {
            if (true)
              goto label_26;
label_14:
            int num2 = num1;
            int num3 = num2 - 1;
label_15:
            num1 = num3;
            if (num2 > 0)
            {
              _param1.\u0001(*(int*) ((IntPtr) voidPtr + 8));
              goto label_14;
            }
label_24:
            while (*(int*) ((IntPtr) voidPtr + 12) < this.\u0004)
            {
label_2:
              num1 = 1;
              *(int*) ((IntPtr) voidPtr + 16) = (int) this.\u0002[*(int*) ((IntPtr) voidPtr + 12)];
              if (false)
                goto label_5;
              else
                goto label_28;
label_4:
              if (*(int*) ((IntPtr) voidPtr + 8) == *(int*) ((IntPtr) voidPtr + 16))
                goto label_6;
label_5:
              _param1.\u0001(*(int*) ((IntPtr) voidPtr + 16));
              num1 = 0;
label_6:
              *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 16);
              *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
              int num4;
              int num5;
              do
              {
                if (true)
                {
                  do
                  {
                    if (*(int*) ((IntPtr) voidPtr + 12) < this.\u0004 && *(int*) ((IntPtr) voidPtr + 8) == (int) this.\u0002[*(int*) ((IntPtr) voidPtr + 12)])
                    {
                      *(int*) ((IntPtr) voidPtr + 12) = *(int*) ((IntPtr) voidPtr + 12) + 1;
                      num4 = num1;
                      num5 = 1;
                      if (num5 == 0)
                        goto label_31;
                    }
                    else
                      break;
                  }
                  while ((num1 = num4 + num5) < *(int*) voidPtr);
                }
                else
                  goto label_2;
              }
              while (false);
              if (num1 >= *(int*) ((IntPtr) voidPtr + 4))
              {
                if (*(int*) ((IntPtr) voidPtr + 8) != 0)
                  _param1.\u0001(16);
                else
                  goto label_19;
label_18:
                this.\u0008.\u0010.\u0001(num1 - 3, 2);
                continue;
label_19:
                if (true)
                {
                  if (true)
                  {
                    if (num1 <= 10)
                    {
                      _param1.\u0001(17);
                      this.\u0008.\u0010.\u0001(num1 - 3, 3);
                      continue;
                    }
                    _param1.\u0001(18);
                    this.\u0008.\u0010.\u0001(num1 - 11, 7);
                    continue;
                  }
                  goto label_18;
                }
                else
                  goto label_4;
              }
              else
                goto label_14;
label_31:
              num3 = num5;
              num2 = num4;
              goto label_15;
label_28:
              if (*(int*) ((IntPtr) voidPtr + 16) != 0)
              {
                *(int*) voidPtr = 6;
                *(int*) ((IntPtr) voidPtr + 4) = 3;
                goto label_4;
              }
              else
              {
                *(int*) voidPtr = 138;
                *(int*) ((IntPtr) voidPtr + 4) = 3;
                goto label_6;
              }
            }
            return;
label_26:
            *(int*) ((IntPtr) voidPtr + 8) = -1;
            if (true)
            {
              *(int*) ((IntPtr) voidPtr + 12) = 0;
              goto label_24;
            }
            else
              goto label_14;
          }
          catch (Exception ex)
          {
            // ISSUE: variable of a boxed type
            __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
            // ISSUE: variable of a boxed type
            __Boxed<int> local2 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
            // ISSUE: variable of a boxed type
            __Boxed<int> local3 = (ValueType) num1;
            // ISSUE: variable of a boxed type
            __Boxed<int> local4 = (ValueType) *(int*) ((IntPtr) voidPtr + 8);
            // ISSUE: variable of a boxed type
            __Boxed<int> local5 = (ValueType) *(int*) ((IntPtr) voidPtr + 12);
            // ISSUE: variable of a boxed type
            __Boxed<int> local6 = (ValueType) *(int*) ((IntPtr) voidPtr + 16);
            \u000E.\u0003.\u0007.\u0001 obj = _param1;
            \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) local4, (object) local5, (object) local6, (object) this, (object) obj);
            throw;
          }
        }
      }
    }

    internal sealed class \u0008
    {
      private const int \u0001 = 258;
      private const int \u0002 = 3;
      private const int \u0003 = 32768;
      private const int \u0004 = 32767;
      private const int \u0005 = 32768;
      private const int \u0006 = 32767;
      private const int \u0007 = 5;
      private const int \u0008 = 262;
      private const int \u000E = 32506;
      private const int \u000F = 4096;
      private int \u0010;
      private short[] \u0011;
      private short[] \u0012;
      private int \u0013;
      private int \u0014;
      private bool \u0015;
      private int \u0016;
      private int \u0017;
      private int \u0018;
      private byte[] \u0019;
      private byte[] \u001A;
      private int \u001B;
      private int \u001C;
      private int \u001D;
      private \u000E.\u0003.\u000E \u001E;
      private \u000E.\u0003.\u0007 \u001F;

      public \u0008(\u000E.\u0003.\u000E pending)
      {
        int num;
        try
        {
          this.\u001E = pending;
          this.\u001F = new \u000E.\u0003.\u0007(pending);
          this.\u0019 = new byte[65536];
          this.\u0011 = new short[32768];
          this.\u0012 = new short[32768];
          this.\u0017 = num = 1;
          this.\u0016 = num;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local = (ValueType) num;
          \u000E.\u0003.\u000E obj = pending;
          \u0005.\u0008.\u0001(ex, (object) local, (object) this, (object) obj);
          throw;
        }
      }

      private void \u0001()
      {
        try
        {
          this.\u0010 = (int) this.\u0019[this.\u0017] << 5 ^ (int) this.\u0019[this.\u0017 + 1];
        }
        catch (Exception ex)
        {
          \u0005.\u0008.\u0001(ex, (object) this);
          throw;
        }
      }

      private unsafe int \u0001()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(8);
        short num1;
        try
        {
          *(int*) voidPtr = (this.\u0010 << 5 ^ (int) this.\u0019[this.\u0017 + 2]) & (int) short.MaxValue;
          short[] numArray1 = this.\u0012;
          int index1 = this.\u0017 & (int) short.MaxValue;
          short[] numArray2 = this.\u0011;
          int index2 = *(int*) voidPtr;
          int num2;
          num1 = (short) (num2 = (int) numArray2[index2]);
          numArray1[index1] = (short) num2;
          this.\u0011[*(int*) voidPtr] = (short) this.\u0017;
          this.\u0010 = *(int*) voidPtr;
          *(int*) ((IntPtr) voidPtr + 4) = (int) num1 & (int) ushort.MaxValue;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<short> local1 = (ValueType) num1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) *(int*) voidPtr;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) this);
          throw;
        }
        return *(int*) ((IntPtr) voidPtr + 4);
      }

      private unsafe void \u0002()
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(16);
        try
        {
          byte[] sourceArray = this.\u0019;
          byte[] destinationArray = this.\u0019;
          if (true)
            goto label_8;
label_2:
          this.\u0013 -= 32768;
          this.\u0017 -= 32768;
          this.\u0016 -= 32768;
          *(int*) voidPtr = 0;
          while (*(int*) voidPtr < 32768)
          {
            *(int*) ((IntPtr) voidPtr + 4) = (int) this.\u0011[*(int*) voidPtr] & (int) ushort.MaxValue;
            this.\u0011[*(int*) voidPtr] = *(int*) ((IntPtr) voidPtr + 4) >= 32768 ? (short) (*(int*) ((IntPtr) voidPtr + 4) - 32768) : (short) 0;
            *(int*) voidPtr = *(int*) voidPtr + 1;
          }
          *(int*) ((IntPtr) voidPtr + 8) = 0;
          while (*(int*) ((IntPtr) voidPtr + 8) < 32768)
          {
            *(int*) ((IntPtr) voidPtr + 12) = (int) this.\u0012[*(int*) ((IntPtr) voidPtr + 8)] & (int) ushort.MaxValue;
            this.\u0012[*(int*) ((IntPtr) voidPtr + 8)] = *(int*) ((IntPtr) voidPtr + 12) >= 32768 ? (short) (*(int*) ((IntPtr) voidPtr + 12) - 32768) : (short) 0;
            *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) + 1;
          }
          return;
label_8:
          Array.Copy((Array) sourceArray, 32768, (Array) destinationArray, 0, 32768);
          goto label_2;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) *(int*) ((IntPtr) voidPtr + 8);
          // ISSUE: variable of a boxed type
          __Boxed<int> local4 = (ValueType) *(int*) ((IntPtr) voidPtr + 12);
          \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) local4, (object) this);
          throw;
        }
      }

      public void \u0003()
      {
        int length;
        try
        {
          int num1 = this.\u0017;
          int num2 = 65274;
          if (num2 != 0)
          {
            if (num1 >= num2)
            {
              this.\u0002();
              if (false)
                return;
              goto label_7;
            }
            else
              goto label_7;
          }
label_5:
          length = num1 - num2;
label_6:
          Array.Copy((Array) this.\u001A, this.\u001C, (Array) this.\u0019, this.\u0017 + this.\u0018, length);
          this.\u001C += length;
          this.\u001B += length;
          this.\u0018 += length;
label_7:
          while (this.\u0018 >= 262 || this.\u001C >= this.\u001D)
          {
            if (true)
            {
              if (this.\u0018 < 3)
                return;
              this.\u0001();
              return;
            }
          }
          length = 65536 - this.\u0018 - this.\u0017;
          if (length > this.\u001D - this.\u001C)
          {
            int num3 = this.\u001D;
            num2 = this.\u001C;
            num1 = num3;
            goto label_5;
          }
          else
            goto label_6;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local = (ValueType) length;
          \u0005.\u0008.\u0001(ex, (object) local, (object) this);
          throw;
        }
      }

      private unsafe bool \u0001(int _param1)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(23);
        int num1;
        int index;
        int num2;
        short[] numArray;
        try
        {
          num1 = 128;
          *(int*) voidPtr = 128;
          numArray = this.\u0012;
          index = this.\u0017;
          *(int*) ((IntPtr) voidPtr + 4) = this.\u0017 + this.\u0014;
          *(int*) ((IntPtr) voidPtr + 8) = Math.Max(this.\u0014, 2);
          *(int*) ((IntPtr) voidPtr + 12) = Math.Max(this.\u0017 - 32506, 0);
          *(int*) ((IntPtr) voidPtr + 16) = this.\u0017 + 258 - 1;
          *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) this.\u0019[*(int*) ((IntPtr) voidPtr + 4) - 1];
          *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) this.\u0019[*(int*) ((IntPtr) voidPtr + 4)];
          if (*(int*) ((IntPtr) voidPtr + 8) >= 8)
            num1 >>= 2;
          if (*(int*) voidPtr > this.\u0018)
            *(int*) voidPtr = this.\u0018;
          do
          {
            if ((int) this.\u0019[_param1 + *(int*) ((IntPtr) voidPtr + 8)] == (int) *(byte*) ((IntPtr) voidPtr + 21) && (int) this.\u0019[_param1 + *(int*) ((IntPtr) voidPtr + 8) - 1] == (int) *(byte*) ((IntPtr) voidPtr + 20) && (int) this.\u0019[_param1] == (int) this.\u0019[index])
            {
              while ((int) this.\u0019[_param1 + 1] == (int) this.\u0019[index + 1])
              {
                num2 = _param1 + 2;
                index += 2;
                do
                  ;
                while ((int) this.\u0019[++index] == (int) this.\u0019[++num2] && (int) this.\u0019[++index] == (int) this.\u0019[++num2] && (int) this.\u0019[++index] == (int) this.\u0019[++num2] && (int) this.\u0019[++index] == (int) this.\u0019[++num2] && (int) this.\u0019[++index] == (int) this.\u0019[++num2] && (int) this.\u0019[++index] == (int) this.\u0019[++num2] && (int) this.\u0019[++index] == (int) this.\u0019[++num2] && (int) this.\u0019[++index] == (int) this.\u0019[++num2] && index < *(int*) ((IntPtr) voidPtr + 16));
                if (index > *(int*) ((IntPtr) voidPtr + 4))
                {
                  if (true)
                  {
                    this.\u0013 = _param1;
                    *(int*) ((IntPtr) voidPtr + 4) = index;
                    *(int*) ((IntPtr) voidPtr + 8) = index - this.\u0017;
                    if (*(int*) ((IntPtr) voidPtr + 8) < *(int*) voidPtr)
                    {
                      *(sbyte*) ((IntPtr) voidPtr + 20) = (sbyte) this.\u0019[*(int*) ((IntPtr) voidPtr + 4) - 1];
                      *(sbyte*) ((IntPtr) voidPtr + 21) = (sbyte) this.\u0019[*(int*) ((IntPtr) voidPtr + 4)];
                    }
                    else
                      goto label_15;
                  }
                  else
                    continue;
                }
                index = this.\u0017;
                break;
              }
            }
          }
          while ((_param1 = (int) numArray[_param1 & (int) short.MaxValue] & (int) ushort.MaxValue) > *(int*) ((IntPtr) voidPtr + 12) && --num1 != 0);
label_15:
          this.\u0014 = Math.Min(*(int*) ((IntPtr) voidPtr + 8), this.\u0018);
          *(sbyte*) ((IntPtr) voidPtr + 22) = (sbyte) (this.\u0014 >= 3);
        }
        catch (Exception ex)
        {
          object[] objArray = new object[13]
          {
            (object) num1,
            (object) *(int*) voidPtr,
            (object) numArray,
            (object) index,
            (object) num2,
            (object) *(int*) ((IntPtr) voidPtr + 4),
            (object) *(int*) ((IntPtr) voidPtr + 8),
            (object) *(int*) ((IntPtr) voidPtr + 12),
            (object) *(int*) ((IntPtr) voidPtr + 16),
            (object) *(byte*) ((IntPtr) voidPtr + 20),
            (object) *(byte*) ((IntPtr) voidPtr + 21),
            (object) this,
            (object) _param1
          };
          \u0005.\u0008.\u0001(ex, objArray);
          throw;
        }
        return (bool) *(sbyte*) ((IntPtr) voidPtr + 22);
      }

      private unsafe bool \u0001(bool _param1, bool _param2)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(13);
        int num1;
        bool flag;
        try
        {
          if (this.\u0018 >= 262)
            goto label_33;
          else
            goto label_37;
label_2:
          int num2;
          if (num2 == 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 0;
            goto label_43;
          }
label_33:
          int num3;
          if (this.\u0018 < 262)
            num3 = _param1 ? 1 : 0;
          else
            goto label_39;
label_35:
          if (num3 == 0)
          {
            *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 1;
            goto label_43;
          }
label_39:
          int num4;
          if (this.\u0018 != 0)
          {
            if (this.\u0017 >= 65274)
              this.\u0002();
            *(int*) voidPtr = this.\u0013;
            num1 = this.\u0014;
            if (this.\u0018 >= 3)
            {
              *(int*) ((IntPtr) voidPtr + 4) = this.\u0001();
              if (*(int*) ((IntPtr) voidPtr + 4) != 0 && this.\u0017 - *(int*) ((IntPtr) voidPtr + 4) <= 32506)
              {
                num2 = this.\u0001(*(int*) ((IntPtr) voidPtr + 4)) ? 1 : 0;
                if (true)
                {
                  if (num2 != 0 && this.\u0014 <= 5 && this.\u0014 == 3 && this.\u0017 - this.\u0013 > 4096)
                    this.\u0014 = 2;
                }
                else
                  goto label_2;
              }
            }
            if (num1 >= 3 && this.\u0014 <= num1)
              num4 = this.\u001F.\u0001(this.\u0017 - 1 - *(int*) voidPtr, num1) ? 1 : 0;
            else if (true)
            {
              if (this.\u0015)
                this.\u001F.\u0001((int) this.\u0019[this.\u0017 - 1] & (int) byte.MaxValue);
              this.\u0015 = true;
              ++this.\u0017;
              --this.\u0018;
              goto label_24;
            }
            else
              goto label_19;
          }
          else
            goto label_40;
label_13:
          int num5 = num1;
          if (true)
          {
            num1 = num5 - 2;
            do
            {
              ++this.\u0017;
              --this.\u0018;
              if (this.\u0018 >= 3)
                this.\u0001();
            }
            while (--num1 > 0);
            ++this.\u0017;
          }
          else
          {
            num3 = num5;
            goto label_35;
          }
label_19:
          --this.\u0018;
          this.\u0015 = false;
          this.\u0014 = 2;
label_24:
          if (this.\u001F.\u0001())
          {
            *(int*) ((IntPtr) voidPtr + 8) = this.\u0017 - this.\u0016;
            if (this.\u0015)
              *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 8) - 1;
            int num6;
            if (_param2)
            {
              num3 = this.\u0018;
              if (true)
              {
                if (num3 == 0)
                {
                  num6 = !this.\u0015 ? 1 : 0;
                  goto label_32;
                }
              }
              else
                goto label_35;
            }
            num6 = 0;
label_32:
            flag = num6 != 0;
            this.\u001F.\u0002(this.\u0019, this.\u0016, *(int*) ((IntPtr) voidPtr + 8), flag);
            this.\u0016 += *(int*) ((IntPtr) voidPtr + 8);
            *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) !flag;
            goto label_43;
          }
          else
            goto label_33;
label_40:
          if (this.\u0015)
            goto label_41;
label_3:
          this.\u0015 = false;
          this.\u001F.\u0002(this.\u0019, this.\u0016, this.\u0017 - this.\u0016, _param2);
          this.\u0016 = this.\u0017;
          *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) 0;
          goto label_43;
label_41:
          int num7 = this.\u001F.\u0001((int) this.\u0019[this.\u0017 - 1] & (int) byte.MaxValue) ? 1 : 0;
          if (false)
          {
            num4 = num7;
            goto label_13;
          }
          else
            goto label_3;
label_37:
          num2 = _param1 ? 1 : 0;
          goto label_2;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) num1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
          // ISSUE: variable of a boxed type
          __Boxed<int> local4 = (ValueType) *(int*) ((IntPtr) voidPtr + 8);
          // ISSUE: variable of a boxed type
          __Boxed<bool> local5 = (ValueType) flag;
          // ISSUE: variable of a boxed type
          __Boxed<bool> local6 = (ValueType) _param1;
          // ISSUE: variable of a boxed type
          __Boxed<bool> local7 = (ValueType) _param2;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) local4, (object) local5, (object) this, (object) local6, (object) local7);
          throw;
        }
label_43:
        return (bool) *(sbyte*) ((IntPtr) voidPtr + 12);
      }

      public unsafe bool \u0002(bool _param1, bool _param2)
      {
        // ISSUE: untyped stack allocation
        void* voidPtr = (void*) __untypedstackalloc(2);
        bool flag;
        try
        {
          do
          {
            this.\u0003();
            flag = _param1 && this.\u001C == this.\u001D;
            *(sbyte*) voidPtr = (sbyte) this.\u0001(flag, _param2);
          }
          while (this.\u001E.IsFlushed && *(sbyte*) voidPtr != (sbyte) 0);
          *(sbyte*) ((IntPtr) voidPtr + 1) = *(sbyte*) voidPtr;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<bool> local1 = (ValueType) (bool) *(sbyte*) voidPtr;
          // ISSUE: variable of a boxed type
          __Boxed<bool> local2 = (ValueType) flag;
          // ISSUE: variable of a boxed type
          __Boxed<bool> local3 = (ValueType) _param1;
          // ISSUE: variable of a boxed type
          __Boxed<bool> local4 = (ValueType) _param2;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) this, (object) local3, (object) local4);
          throw;
        }
        return (bool) *(sbyte*) ((IntPtr) voidPtr + 1);
      }

      public void \u0001(byte[] _param1)
      {
        try
        {
          do
          {
            this.\u001A = _param1;
            this.\u001C = 0;
            this.\u001D = _param1.Length;
          }
          while (false);
        }
        catch (Exception ex)
        {
          byte[] numArray = _param1;
          \u0005.\u0008.\u0001(ex, (object) this, (object) numArray);
          throw;
        }
      }

      public bool \u0001()
      {
        bool flag;
        try
        {
          flag = this.\u001D == this.\u001C;
        }
        catch (Exception ex)
        {
          \u0005.\u0008.\u0001(ex, (object) this);
          throw;
        }
        return flag;
      }
    }

    internal sealed class \u000E
    {
      protected byte[] \u0001 = new byte[65536];
      private int \u0002 = 0;
      private int \u0003 = 0;
      private uint \u0004 = 0;
      private int \u0005 = 0;

      public void \u0001(int _param1)
      {
        int num1;
        try
        {
          byte[] numArray1 = this.\u0001;
          \u000E.\u0003.\u000E obj1 = this;
          int num2;
          num1 = num2 = obj1.\u0003;
          obj1.\u0003 = num2 + 1;
          int index1 = num1;
          int num3 = (int) (byte) _param1;
          numArray1[index1] = (byte) num3;
          byte[] numArray2 = this.\u0001;
          \u000E.\u0003.\u000E obj2 = this;
          int num4;
          num1 = num4 = obj2.\u0003;
          obj2.\u0003 = num4 + 1;
          int index2 = num1;
          int num5 = (int) (byte) (_param1 >> 8);
          numArray2[index2] = (byte) num5;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) num1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) _param1;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) this, (object) local2);
          throw;
        }
      }

      public void \u0001(byte[] _param1, int _param2, int _param3)
      {
        try
        {
          byte[] sourceArray = _param1;
          int sourceIndex = _param2;
          byte[] destinationArray = this.\u0001;
          int destinationIndex = this.\u0003;
          int length = _param3;
          if (true)
            goto label_2;
label_1:
          this.\u0003 += _param3;
          return;
label_2:
          Array.Copy((Array) sourceArray, sourceIndex, (Array) destinationArray, destinationIndex, length);
          goto label_1;
        }
        catch (Exception ex)
        {
          byte[] numArray = _param1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) _param2;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) _param3;
          \u0005.\u0008.\u0001(ex, (object) this, (object) numArray, (object) local1, (object) local2);
          throw;
        }
      }

      public int BitCount
      {
        get
        {
          int num;
          try
          {
            num = this.\u0005;
          }
          catch (Exception ex)
          {
            \u0005.\u0008.\u0001(ex, (object) this);
            throw;
          }
          return num;
        }
      }

      public void \u0001()
      {
        int num1;
        try
        {
          int num2 = this.\u0005;
label_1:
          if (true)
          {
            if (num2 > 0)
            {
              byte[] numArray = this.\u0001;
              \u000E.\u0003.\u000E obj = this;
              int num3;
              num1 = num3 = obj.\u0003;
              obj.\u0003 = num3 + 1;
              int index = num1;
              int num4 = (int) (byte) this.\u0004;
              numArray[index] = (byte) num4;
              goto label_9;
            }
            else
              goto label_5;
          }
label_3:
          if (true)
          {
            if (num2 > 8)
              goto label_10;
          }
          else
            goto label_1;
label_5:
          this.\u0004 = 0U;
          if (true)
          {
            this.\u0005 = 0;
            if (true)
              return;
            goto label_10;
          }
label_9:
          num2 = this.\u0005;
          goto label_3;
label_10:
          byte[] numArray1 = this.\u0001;
          \u000E.\u0003.\u000E obj1 = this;
          int num5;
          num1 = num5 = obj1.\u0003;
          obj1.\u0003 = num5 + 1;
          int index1 = num1;
          int num6 = (int) (byte) (this.\u0004 >> 8);
          numArray1[index1] = (byte) num6;
          goto label_5;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local = (ValueType) num1;
          \u0005.\u0008.\u0001(ex, (object) local, (object) this);
          throw;
        }
      }

      public void \u0001(int _param1, int _param2)
      {
        int num1;
        try
        {
          this.\u0004 |= (uint) (_param1 << this.\u0005);
          this.\u0005 += _param2;
          if (this.\u0005 < 16)
            return;
          do
          {
            if (true)
              goto label_5;
label_2:
            continue;
label_5:
            byte[] numArray1 = this.\u0001;
            \u000E.\u0003.\u000E obj = this;
            int num2;
            num1 = num2 = obj.\u0003;
            obj.\u0003 = num2 + 1;
            int index1 = num1;
            int num3 = (int) (byte) this.\u0004;
            numArray1[index1] = (byte) num3;
            byte[] numArray2 = this.\u0001;
            num1 = this.\u0003++;
            int index2 = num1;
            int num4 = (int) (byte) (this.\u0004 >> 8);
            numArray2[index2] = (byte) num4;
            this.\u0004 >>= 16;
            goto label_2;
          }
          while (false);
          this.\u0005 -= 16;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) num1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) _param1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) _param2;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) this, (object) local2, (object) local3);
          throw;
        }
      }

      public bool IsFlushed
      {
        get
        {
          bool flag;
          try
          {
            do
            {
              flag = this.\u0003 == 0;
            }
            while (false);
          }
          catch (Exception ex)
          {
            \u0005.\u0008.\u0001(ex, (object) this);
            throw;
          }
          return flag;
        }
      }

      public int \u0001(byte[] _param1, int _param2, int _param3)
      {
        int num1;
        try
        {
          if (this.\u0005 >= 8)
          {
            byte[] numArray = this.\u0001;
            \u000E.\u0003.\u000E obj = this;
            int num2;
            num1 = num2 = obj.\u0003;
            obj.\u0003 = num2 + 1;
            int index = num1;
            int num3 = (int) (byte) this.\u0004;
            numArray[index] = (byte) num3;
            this.\u0004 >>= 8;
            this.\u0005 -= 8;
          }
          if (_param3 <= this.\u0003 - this.\u0002)
          {
            Array.Copy((Array) this.\u0001, this.\u0002, (Array) _param1, _param2, _param3);
            this.\u0002 += _param3;
          }
          else
            goto label_5;
label_2:
          return _param3;
label_5:
          _param3 = this.\u0003 - this.\u0002;
          Array.Copy((Array) this.\u0001, this.\u0002, (Array) _param1, _param2, _param3);
          this.\u0002 = 0;
          this.\u0003 = 0;
          goto label_2;
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local1 = (ValueType) num1;
          byte[] numArray = _param1;
          // ISSUE: variable of a boxed type
          __Boxed<int> local2 = (ValueType) _param2;
          // ISSUE: variable of a boxed type
          __Boxed<int> local3 = (ValueType) _param3;
          \u0005.\u0008.\u0001(ex, (object) local1, (object) this, (object) numArray, (object) local2, (object) local3);
          throw;
        }
      }
    }

    internal sealed class \u000F : MemoryStream
    {
      public void \u0001(int _param1)
      {
        try
        {
          do
          {
            if (true)
              goto label_4;
label_1:
            if (true)
              continue;
            goto label_5;
label_4:
            this.WriteByte((byte) (_param1 & (int) byte.MaxValue));
label_5:
            this.WriteByte((byte) (_param1 >> 8 & (int) byte.MaxValue));
            goto label_1;
          }
          while (false);
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local = (ValueType) _param1;
          \u0005.\u0008.\u0001(ex, (object) this, (object) local);
          throw;
        }
      }

      public void \u0002(int _param1)
      {
        try
        {
          do
          {
            this.\u0001(_param1);
            this.\u0001(_param1 >> 16);
          }
          while (false);
        }
        catch (Exception ex)
        {
          // ISSUE: variable of a boxed type
          __Boxed<int> local = (ValueType) _param1;
          \u0005.\u0008.\u0001(ex, (object) this, (object) local);
          throw;
        }
      }

      public int \u0001()
      {
        int num1;
        try
        {
          if (true)
          {
            int num2 = this.ReadByte();
            int num3;
            while (true)
            {
              int num4 = this.ReadByte();
              int num5;
              while (true)
              {
                num5 = num4 << 8;
                if (false)
                  num4 = num5;
                else
                  break;
              }
              num3 = num2 | num5;
              if (false)
                num2 = num3;
              else
                break;
            }
            num1 = num3;
          }
        }
        catch (Exception ex)
        {
          \u0005.\u0008.\u0001(ex, (object) this);
          throw;
        }
        return num1;
      }

      public int \u0002()
      {
        int num1;
        try
        {
          if (true)
          {
            int num2 = this.\u0001();
            int num3;
            while (true)
            {
              int num4 = this.\u0001();
              int num5;
              while (true)
              {
                num5 = num4 << 16;
                if (false)
                  num4 = num5;
                else
                  break;
              }
              num3 = num2 | num5;
              if (false)
                num2 = num3;
              else
                break;
            }
            num1 = num3;
          }
        }
        catch (Exception ex)
        {
          \u0005.\u0008.\u0001(ex, (object) this);
          throw;
        }
        return num1;
      }

      public \u000F()
      {
      }

      public \u000F(byte[] buffer)
        : base(buffer, false)
      {
      }
    }
  }
}
