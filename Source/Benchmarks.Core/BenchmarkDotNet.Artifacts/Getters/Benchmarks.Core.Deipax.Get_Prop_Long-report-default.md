
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  0.9514 ns | 0.0060 ns | 0.0056 ns |  1.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1143 ns | 0.0035 ns | 0.0029 ns |  1.17 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.3923 ns | 0.0053 ns | 0.0047 ns |  1.46 |      - |     - |     - |         - |
             ToBool |        net461 |  0.6662 ns | 0.0045 ns | 0.0040 ns |  0.70 |      - |     - |     - |         - |
             ToBool |        net472 |  0.6817 ns | 0.0052 ns | 0.0049 ns |  0.72 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0333 ns | 0.0080 ns | 0.0071 ns |  1.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1530 ns | 0.0044 ns | 0.0037 ns |  1.03 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0223 ns | 0.0100 ns | 0.0083 ns |  1.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1716 ns | 0.0096 ns | 0.0090 ns |  1.03 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2048 ns | 0.0097 ns | 0.0086 ns |  1.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.9634 ns | 0.0061 ns | 0.0054 ns |  1.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.0027 ns | 0.0040 ns | 0.0033 ns |  1.02 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.0041 ns | 0.0062 ns | 0.0055 ns |  1.02 |      - |     - |     - |         - |
             ToChar |        net461 |  1.3802 ns | 0.0125 ns | 0.0117 ns |  0.70 |      - |     - |     - |         - |
             ToChar |        net472 |  1.3792 ns | 0.0068 ns | 0.0064 ns |  0.70 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.7273 ns | 0.0089 ns | 0.0079 ns |  1.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.8475 ns | 0.0116 ns | 0.0109 ns |  1.03 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.7205 ns | 0.0122 ns | 0.0102 ns |  1.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.8675 ns | 0.0089 ns | 0.0079 ns |  1.03 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.8967 ns | 0.0056 ns | 0.0052 ns |  1.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
            ToSByte | .NET Core 2.0 |  2.1457 ns | 0.0030 ns | 0.0025 ns |  1.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  2.0356 ns | 0.0121 ns | 0.0101 ns |  0.95 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.9248 ns | 0.0059 ns | 0.0052 ns |  0.90 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.4303 ns | 0.0059 ns | 0.0052 ns |  0.67 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.3730 ns | 0.0038 ns | 0.0035 ns |  0.64 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.7339 ns | 0.0097 ns | 0.0086 ns |  1.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.8474 ns | 0.0084 ns | 0.0075 ns |  1.02 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.4948 ns | 0.0079 ns | 0.0070 ns |  0.95 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.8624 ns | 0.0097 ns | 0.0091 ns |  1.03 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.9367 ns | 0.0196 ns | 0.0183 ns |  1.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.0252 ns | 0.0145 ns | 0.0121 ns |  1.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.9993 ns | 0.0045 ns | 0.0040 ns |  0.99 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.9384 ns | 0.0040 ns | 0.0038 ns |  0.96 |      - |     - |     - |         - |
             ToByte |        net461 |  1.3632 ns | 0.0054 ns | 0.0050 ns |  0.67 |      - |     - |     - |         - |
             ToByte |        net472 |  1.3670 ns | 0.0044 ns | 0.0039 ns |  0.68 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.7253 ns | 0.0129 ns | 0.0108 ns |  1.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.8435 ns | 0.0060 ns | 0.0056 ns |  1.02 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.7200 ns | 0.0123 ns | 0.0109 ns |  1.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.9175 ns | 0.0355 ns | 0.0332 ns |  1.04 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.9031 ns | 0.0076 ns | 0.0063 ns |  1.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.3799 ns | 0.0110 ns | 0.0092 ns |  1.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.1871 ns | 0.0067 ns | 0.0063 ns |  0.92 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.9481 ns | 0.0035 ns | 0.0031 ns |  0.82 |      - |     - |     - |         - |
            ToShort |        net461 |  1.6140 ns | 0.0092 ns | 0.0086 ns |  0.68 |      - |     - |     - |         - |
            ToShort |        net472 |  1.6111 ns | 0.0030 ns | 0.0028 ns |  0.68 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.7311 ns | 0.0129 ns | 0.0114 ns |  1.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.8472 ns | 0.0105 ns | 0.0098 ns |  1.02 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.4887 ns | 0.0074 ns | 0.0070 ns |  0.95 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.8667 ns | 0.0096 ns | 0.0085 ns |  1.03 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.8992 ns | 0.0079 ns | 0.0074 ns |  1.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.9419 ns | 0.0046 ns | 0.0041 ns |  1.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.0056 ns | 0.0036 ns | 0.0032 ns |  1.03 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  2.2756 ns | 0.0058 ns | 0.0051 ns |  1.17 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.3633 ns | 0.0034 ns | 0.0032 ns |  0.70 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.3912 ns | 0.0088 ns | 0.0082 ns |  0.72 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.7232 ns | 0.0079 ns | 0.0074 ns |  1.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.8588 ns | 0.0086 ns | 0.0077 ns |  1.03 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.4578 ns | 0.0073 ns | 0.0061 ns |  0.94 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.8688 ns | 0.0092 ns | 0.0077 ns |  1.03 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.9330 ns | 0.0259 ns | 0.0243 ns |  1.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.9707 ns | 0.0032 ns | 0.0030 ns |  1.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  2.1397 ns | 0.0044 ns | 0.0037 ns |  1.09 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  2.4439 ns | 0.0081 ns | 0.0068 ns |  1.24 |      - |     - |     - |         - |
              ToInt |        net461 |  1.3552 ns | 0.0102 ns | 0.0095 ns |  0.69 |      - |     - |     - |         - |
              ToInt |        net472 |  1.3773 ns | 0.0057 ns | 0.0053 ns |  0.70 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.7272 ns | 0.0094 ns | 0.0083 ns |  1.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.8604 ns | 0.0098 ns | 0.0092 ns |  1.03 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.4871 ns | 0.0116 ns | 0.0097 ns |  0.95 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.6643 ns | 0.0328 ns | 0.0307 ns |  0.99 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.6746 ns | 0.0089 ns | 0.0079 ns |  0.99 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
             ToUInt | .NET Core 2.0 |  2.1863 ns | 0.0045 ns | 0.0042 ns |  1.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  2.1679 ns | 0.0035 ns | 0.0033 ns |  0.99 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  2.3373 ns | 0.0121 ns | 0.0113 ns |  1.07 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.3938 ns | 0.0033 ns | 0.0029 ns |  0.64 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.3663 ns | 0.0012 ns | 0.0010 ns |  0.62 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.7247 ns | 0.0068 ns | 0.0064 ns |  1.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.8535 ns | 0.0056 ns | 0.0052 ns |  1.03 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.4892 ns | 0.0083 ns | 0.0078 ns |  0.95 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.8733 ns | 0.0102 ns | 0.0096 ns |  1.03 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.8979 ns | 0.0105 ns | 0.0098 ns |  1.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
             ToLong | .NET Core 2.0 |  0.9610 ns | 0.0027 ns | 0.0024 ns |  1.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  0.8833 ns | 0.0033 ns | 0.0030 ns |  0.92 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.1573 ns | 0.0039 ns | 0.0034 ns |  1.20 |      - |     - |     - |         - |
             ToLong |        net461 |  0.4339 ns | 0.0021 ns | 0.0018 ns |  0.45 |      - |     - |     - |         - |
             ToLong |        net472 |  0.4470 ns | 0.0031 ns | 0.0027 ns |  0.47 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.6569 ns | 0.0053 ns | 0.0044 ns |  1.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.4949 ns | 0.0040 ns | 0.0035 ns |  0.90 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.4747 ns | 0.0045 ns | 0.0038 ns |  0.89 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.4887 ns | 0.0041 ns | 0.0039 ns |  0.90 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.6463 ns | 0.0066 ns | 0.0062 ns |  0.99 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.2399 ns | 0.0038 ns | 0.0036 ns |  1.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.1587 ns | 0.0058 ns | 0.0048 ns |  0.93 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  0.9689 ns | 0.0036 ns | 0.0032 ns |  0.78 |      - |     - |     - |         - |
            ToULong |        net461 |  1.3633 ns | 0.0057 ns | 0.0051 ns |  1.10 |      - |     - |     - |         - |
            ToULong |        net472 |  1.3869 ns | 0.0138 ns | 0.0129 ns |  1.12 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.8827 ns | 0.0032 ns | 0.0028 ns |  1.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.8605 ns | 0.0026 ns | 0.0022 ns |  0.99 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.7839 ns | 0.0047 ns | 0.0039 ns |  0.95 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.5079 ns | 0.0202 ns | 0.0179 ns |  1.33 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.5575 ns | 0.0075 ns | 0.0062 ns |  1.36 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.4278 ns | 0.0064 ns | 0.0053 ns |  1.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.1040 ns | 0.0069 ns | 0.0061 ns |  0.77 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.1743 ns | 0.0038 ns | 0.0035 ns |  0.82 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.4336 ns | 0.0029 ns | 0.0027 ns |  0.30 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.4400 ns | 0.0029 ns | 0.0024 ns |  0.31 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2595 ns | 0.0077 ns | 0.0072 ns |  1.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.3801 ns | 0.0087 ns | 0.0077 ns |  1.03 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2537 ns | 0.0118 ns | 0.0110 ns |  1.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.4068 ns | 0.0087 ns | 0.0073 ns |  1.03 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.4303 ns | 0.0079 ns | 0.0074 ns |  1.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.2145 ns | 0.0093 ns | 0.0078 ns |  1.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.1334 ns | 0.0126 ns | 0.0117 ns |  0.93 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.1585 ns | 0.0033 ns | 0.0029 ns |  0.95 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.4353 ns | 0.0032 ns | 0.0030 ns |  0.36 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.4403 ns | 0.0027 ns | 0.0024 ns |  0.36 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.6590 ns | 0.0031 ns | 0.0027 ns |  1.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.5020 ns | 0.0048 ns | 0.0045 ns |  0.91 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.7749 ns | 0.0043 ns | 0.0041 ns |  1.07 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.6374 ns | 0.0051 ns | 0.0045 ns |  0.99 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.9089 ns | 0.0132 ns | 0.0103 ns |  1.15 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.2134 ns | 0.0245 ns | 0.0218 ns |  1.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.7743 ns | 0.0090 ns | 0.0080 ns |  0.93 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.8666 ns | 0.0099 ns | 0.0093 ns |  0.94 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.7996 ns | 0.0143 ns | 0.0127 ns |  0.93 |      - |     - |     - |         - |
          ToDecimal |        net472 | 10.3078 ns | 0.0219 ns | 0.0194 ns |  1.66 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 19.3661 ns | 0.0303 ns | 0.0268 ns |  1.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.3235 ns | 0.0275 ns | 0.0258 ns |  0.95 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.5986 ns | 0.0249 ns | 0.0195 ns |  0.65 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.1225 ns | 0.0379 ns | 0.0355 ns |  0.94 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.2292 ns | 0.1004 ns | 0.0939 ns |  0.94 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.1241 ns | 0.0056 ns | 0.0050 ns |  1.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3005 ns | 0.0074 ns | 0.0066 ns |  1.08 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1089 ns | 0.0142 ns | 0.0132 ns |  0.99 |      - |     - |     - |         - |
         ToDateTime |        net461 |  0.9090 ns | 0.0036 ns | 0.0028 ns |  0.43 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1944 ns | 0.0047 ns | 0.0039 ns |  0.56 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.2229 ns | 0.0109 ns | 0.0097 ns |  1.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  7.9606 ns | 0.0150 ns | 0.0133 ns |  0.97 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9353 ns | 0.0059 ns | 0.0055 ns |  0.24 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  7.8860 ns | 0.0243 ns | 0.0228 ns |  0.96 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.3492 ns | 0.0442 ns | 0.0392 ns |  1.02 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.2607 ns | 0.0080 ns | 0.0071 ns |  1.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.7232 ns | 0.0096 ns | 0.0090 ns |  1.14 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.8326 ns | 0.0440 ns | 0.0412 ns |  1.18 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.8986 ns | 0.0108 ns | 0.0090 ns |  0.89 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.6801 ns | 0.0181 ns | 0.0170 ns |  0.82 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |        |       |       |           |
          To_String | .NET Core 2.0 | 32.0490 ns | 0.1062 ns | 0.0942 ns |  1.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 18.3197 ns | 0.0678 ns | 0.0601 ns |  0.57 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.9289 ns | 0.0219 ns | 0.0205 ns |  0.40 |      - |     - |     - |         - |
          To_String |        net461 | 31.3365 ns | 0.0743 ns | 0.0695 ns |  0.98 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 30.9618 ns | 0.0736 ns | 0.0653 ns |  0.97 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |        |       |       |           |
             ToEnum | .NET Core 2.0 | 10.8543 ns | 0.0196 ns | 0.0183 ns |  1.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.5775 ns | 0.0260 ns | 0.0230 ns |  0.97 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.5006 ns | 0.0146 ns | 0.0122 ns |  0.78 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.7013 ns | 0.0233 ns | 0.0206 ns |  1.17 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.6800 ns | 0.0124 ns | 0.0110 ns |  1.17 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 15.3549 ns | 0.0444 ns | 0.0371 ns |  1.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 15.6667 ns | 0.0976 ns | 0.0913 ns |  1.02 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.2385 ns | 0.0380 ns | 0.0355 ns |  0.86 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 17.5128 ns | 0.1014 ns | 0.0949 ns |  1.14 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 17.5089 ns | 0.0478 ns | 0.0447 ns |  1.14 |      - |     - |     - |         - |
