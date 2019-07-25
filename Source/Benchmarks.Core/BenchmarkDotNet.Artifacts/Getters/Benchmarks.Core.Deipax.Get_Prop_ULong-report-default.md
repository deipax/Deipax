
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  0.8880 ns | 0.0051 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.3967 ns | 0.0044 ns | 0.0039 ns |  1.57 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.1948 ns | 0.0031 ns | 0.0027 ns |  1.35 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  0.9620 ns | 0.0043 ns | 0.0038 ns |  1.08 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  0.9617 ns | 0.0042 ns | 0.0035 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9949 ns | 0.0089 ns | 0.0079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2019 ns | 0.0101 ns | 0.0090 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0387 ns | 0.0058 ns | 0.0054 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1849 ns | 0.0077 ns | 0.0072 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1829 ns | 0.0088 ns | 0.0082 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.9693 ns | 0.0041 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.2763 ns | 0.0175 ns | 0.0163 ns |  1.16 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.0442 ns | 0.0033 ns | 0.0029 ns |  1.04 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  1.6587 ns | 0.0077 ns | 0.0069 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  1.6576 ns | 0.0048 ns | 0.0043 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.7032 ns | 0.0256 ns | 0.0239 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.8905 ns | 0.0061 ns | 0.0054 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.5214 ns | 0.0141 ns | 0.0132 ns |  0.96 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.6391 ns | 0.0066 ns | 0.0059 ns |  0.99 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.6777 ns | 0.0404 ns | 0.0378 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.1853 ns | 0.0045 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.4652 ns | 0.0046 ns | 0.0043 ns |  1.24 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.0193 ns | 0.0046 ns | 0.0040 ns |  0.86 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.6668 ns | 0.0063 ns | 0.0056 ns |  1.41 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.6595 ns | 0.0044 ns | 0.0041 ns |  1.40 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  3.9951 ns | 0.0107 ns | 0.0100 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.2073 ns | 0.0093 ns | 0.0087 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0309 ns | 0.0058 ns | 0.0054 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.6498 ns | 0.0097 ns | 0.0086 ns |  1.16 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.6395 ns | 0.0069 ns | 0.0065 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.1315 ns | 0.0087 ns | 0.0082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.1431 ns | 0.0063 ns | 0.0059 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.0412 ns | 0.0046 ns | 0.0039 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  1.6854 ns | 0.0048 ns | 0.0040 ns |  0.79 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  1.6813 ns | 0.0047 ns | 0.0042 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.6907 ns | 0.0075 ns | 0.0063 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.9132 ns | 0.0338 ns | 0.0316 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.5074 ns | 0.0089 ns | 0.0083 ns |  0.96 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.6466 ns | 0.0099 ns | 0.0092 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.6903 ns | 0.0055 ns | 0.0051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.0830 ns | 0.0052 ns | 0.0048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.1381 ns | 0.0068 ns | 0.0060 ns |  1.03 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.9930 ns | 0.0031 ns | 0.0027 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  1.6616 ns | 0.0061 ns | 0.0057 ns |  0.80 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.6584 ns | 0.0047 ns | 0.0042 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.6956 ns | 0.0104 ns | 0.0097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.9032 ns | 0.0167 ns | 0.0148 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.5093 ns | 0.0151 ns | 0.0141 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.6499 ns | 0.0126 ns | 0.0112 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.6464 ns | 0.0116 ns | 0.0091 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  2.1594 ns | 0.0134 ns | 0.0125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.2116 ns | 0.0084 ns | 0.0079 ns |  1.02 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.9460 ns | 0.0040 ns | 0.0036 ns |  0.90 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.6569 ns | 0.0050 ns | 0.0046 ns |  0.77 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.6591 ns | 0.0036 ns | 0.0032 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.6954 ns | 0.0088 ns | 0.0078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.9049 ns | 0.0094 ns | 0.0083 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.5035 ns | 0.0073 ns | 0.0061 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.6468 ns | 0.0127 ns | 0.0119 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.6467 ns | 0.0112 ns | 0.0105 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  2.1345 ns | 0.0041 ns | 0.0034 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  2.2638 ns | 0.0048 ns | 0.0042 ns |  1.06 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  2.3315 ns | 0.0098 ns | 0.0087 ns |  1.09 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  1.8939 ns | 0.0050 ns | 0.0045 ns |  0.89 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  1.9524 ns | 0.0032 ns | 0.0028 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.4596 ns | 0.0085 ns | 0.0066 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.6774 ns | 0.0111 ns | 0.0104 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.5011 ns | 0.0050 ns | 0.0045 ns |  1.01 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.6759 ns | 0.0284 ns | 0.0265 ns |  1.05 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.6594 ns | 0.0311 ns | 0.0291 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.2600 ns | 0.0070 ns | 0.0066 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4875 ns | 0.0131 ns | 0.0122 ns |  1.18 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.0057 ns | 0.0039 ns | 0.0036 ns |  0.80 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.6830 ns | 0.0074 ns | 0.0065 ns |  1.34 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.6932 ns | 0.0144 ns | 0.0135 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.2292 ns | 0.0065 ns | 0.0060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1944 ns | 0.0096 ns | 0.0090 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0361 ns | 0.0091 ns | 0.0085 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.6677 ns | 0.0308 ns | 0.0288 ns |  1.10 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.6450 ns | 0.0123 ns | 0.0115 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.3112 ns | 0.0043 ns | 0.0040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.8366 ns | 0.0143 ns | 0.0134 ns |  1.40 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.1941 ns | 0.0029 ns | 0.0027 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  1.6570 ns | 0.0039 ns | 0.0030 ns |  1.26 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  1.6595 ns | 0.0036 ns | 0.0034 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.1169 ns | 0.0148 ns | 0.0131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.0601 ns | 0.0036 ns | 0.0030 ns |  0.97 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.6674 ns | 0.0111 ns | 0.0104 ns |  0.79 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.7509 ns | 0.0084 ns | 0.0078 ns |  1.30 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.7561 ns | 0.0086 ns | 0.0080 ns |  1.30 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  0.9310 ns | 0.0043 ns | 0.0036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.1652 ns | 0.0028 ns | 0.0025 ns |  1.25 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  0.9672 ns | 0.0030 ns | 0.0023 ns |  1.04 |    0.01 |      - |     - |     - |         - |
            ToULong |        net461 |  0.7277 ns | 0.0033 ns | 0.0031 ns |  0.78 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  0.7297 ns | 0.0043 ns | 0.0038 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.5025 ns | 0.0054 ns | 0.0050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.6212 ns | 0.0090 ns | 0.0084 ns |  1.08 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.6603 ns | 0.0037 ns | 0.0035 ns |  1.11 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  1.5798 ns | 0.0045 ns | 0.0040 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  1.5774 ns | 0.0065 ns | 0.0057 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.6206 ns | 0.0592 ns | 0.0749 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4264 ns | 0.0049 ns | 0.0044 ns |  0.88 |    0.04 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.3353 ns | 0.0030 ns | 0.0026 ns |  0.82 |    0.04 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.9522 ns | 0.0070 ns | 0.0065 ns |  0.59 |    0.03 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.9620 ns | 0.0055 ns | 0.0052 ns |  0.60 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.6849 ns | 0.0109 ns | 0.0097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.8980 ns | 0.0040 ns | 0.0036 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.5080 ns | 0.0133 ns | 0.0124 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.8925 ns | 0.0292 ns | 0.0273 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.8769 ns | 0.0086 ns | 0.0076 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.3144 ns | 0.0103 ns | 0.0092 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.3819 ns | 0.0032 ns | 0.0028 ns |  1.05 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.4320 ns | 0.0041 ns | 0.0039 ns |  1.09 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.9735 ns | 0.0032 ns | 0.0030 ns |  0.74 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.9799 ns | 0.0067 ns | 0.0063 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.9559 ns | 0.0060 ns | 0.0053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.8493 ns | 0.0054 ns | 0.0048 ns |  0.95 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.8950 ns | 0.0040 ns | 0.0035 ns |  0.97 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.0525 ns | 0.0041 ns | 0.0039 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.0681 ns | 0.0045 ns | 0.0042 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.0716 ns | 0.0095 ns | 0.0079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.8392 ns | 0.0191 ns | 0.0169 ns |  0.96 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.9255 ns | 0.0229 ns | 0.0203 ns |  0.98 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.0503 ns | 0.0127 ns | 0.0106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.8058 ns | 0.0116 ns | 0.0097 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.2380 ns | 0.0246 ns | 0.0218 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.0625 ns | 0.0566 ns | 0.0529 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.1051 ns | 0.2507 ns | 0.2345 ns |  0.72 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 17.9005 ns | 0.0716 ns | 0.0670 ns |  0.98 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.1869 ns | 0.0315 ns | 0.0294 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.1545 ns | 0.0050 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3505 ns | 0.0048 ns | 0.0042 ns |  1.09 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1313 ns | 0.0042 ns | 0.0035 ns |  0.99 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1296 ns | 0.0035 ns | 0.0027 ns |  0.52 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1427 ns | 0.0064 ns | 0.0057 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9547 ns | 0.0234 ns | 0.0219 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3663 ns | 0.0221 ns | 0.0196 ns |  1.05 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9474 ns | 0.0061 ns | 0.0051 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4292 ns | 0.0217 ns | 0.0192 ns |  1.06 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.4213 ns | 0.0205 ns | 0.0191 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.2763 ns | 0.0169 ns | 0.0149 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.7777 ns | 0.0202 ns | 0.0179 ns |  1.15 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.8196 ns | 0.0254 ns | 0.0226 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.8169 ns | 0.0434 ns | 0.0406 ns |  0.86 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.6999 ns | 0.0198 ns | 0.0185 ns |  0.82 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 30.5734 ns | 0.1092 ns | 0.0968 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 19.1163 ns | 0.0497 ns | 0.0441 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.1014 ns | 0.0256 ns | 0.0227 ns |  0.40 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 30.5570 ns | 0.0517 ns | 0.0431 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 30.8353 ns | 0.0774 ns | 0.0646 ns |  1.01 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 10.4648 ns | 0.0261 ns | 0.0218 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.6475 ns | 0.0223 ns | 0.0198 ns |  1.02 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.5964 ns | 0.0205 ns | 0.0192 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.7639 ns | 0.0277 ns | 0.0259 ns |  1.22 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.7888 ns | 0.0227 ns | 0.0201 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 15.0868 ns | 0.0300 ns | 0.0281 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 15.4961 ns | 0.0359 ns | 0.0336 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.0557 ns | 0.0184 ns | 0.0154 ns |  0.87 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 17.4800 ns | 0.0261 ns | 0.0244 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 17.6759 ns | 0.0859 ns | 0.0761 ns |  1.17 |    0.00 |      - |     - |     - |         - |
