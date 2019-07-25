
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
             ToBool | .NET Core 2.0 |  1.4492 ns | 0.0077 ns | 0.0064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.6881 ns | 0.0231 ns | 0.0216 ns |  1.17 |    0.02 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.5498 ns | 0.0076 ns | 0.0068 ns |  1.07 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  1.9233 ns | 0.0049 ns | 0.0046 ns |  1.33 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  1.8666 ns | 0.0036 ns | 0.0032 ns |  1.29 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  1.1813 ns | 0.0051 ns | 0.0043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  1.1906 ns | 0.0051 ns | 0.0048 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  1.1430 ns | 0.0069 ns | 0.0057 ns |  0.97 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  0.9869 ns | 0.0057 ns | 0.0050 ns |  0.84 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  0.9913 ns | 0.0037 ns | 0.0035 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.2078 ns | 0.0039 ns | 0.0037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.2165 ns | 0.0034 ns | 0.0027 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.1452 ns | 0.0035 ns | 0.0033 ns |  0.95 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  0.5480 ns | 0.0197 ns | 0.0174 ns |  0.45 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |  0.6251 ns | 0.0036 ns | 0.0034 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0628 ns | 0.0083 ns | 0.0074 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.2204 ns | 0.0077 ns | 0.0072 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0231 ns | 0.0095 ns | 0.0089 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.2148 ns | 0.0076 ns | 0.0071 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.2282 ns | 0.0075 ns | 0.0070 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.9574 ns | 0.0083 ns | 0.0077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.8775 ns | 0.0049 ns | 0.0041 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.6518 ns | 0.0023 ns | 0.0020 ns |  0.84 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.3529 ns | 0.0038 ns | 0.0036 ns |  0.69 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.3634 ns | 0.0032 ns | 0.0028 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.2931 ns | 0.0075 ns | 0.0062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4548 ns | 0.0080 ns | 0.0071 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.4855 ns | 0.0119 ns | 0.0111 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.6969 ns | 0.0092 ns | 0.0082 ns |  1.09 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.6985 ns | 0.0079 ns | 0.0074 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.9138 ns | 0.0114 ns | 0.0106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.7220 ns | 0.0059 ns | 0.0052 ns |  0.90 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.5035 ns | 0.0018 ns | 0.0015 ns |  0.79 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  1.3726 ns | 0.0040 ns | 0.0037 ns |  0.72 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  1.3764 ns | 0.0053 ns | 0.0047 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.2926 ns | 0.0095 ns | 0.0089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.4585 ns | 0.0082 ns | 0.0076 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.4817 ns | 0.0062 ns | 0.0058 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.6862 ns | 0.0083 ns | 0.0077 ns |  1.09 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.6968 ns | 0.0069 ns | 0.0058 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.9620 ns | 0.0064 ns | 0.0057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.9956 ns | 0.0190 ns | 0.0178 ns |  1.02 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.7013 ns | 0.0042 ns | 0.0037 ns |  0.87 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  1.3703 ns | 0.0057 ns | 0.0054 ns |  0.70 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.3826 ns | 0.0134 ns | 0.0126 ns |  0.70 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.2935 ns | 0.0102 ns | 0.0095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.4560 ns | 0.0081 ns | 0.0072 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.4829 ns | 0.0141 ns | 0.0118 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.6919 ns | 0.0118 ns | 0.0111 ns |  1.09 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.6983 ns | 0.0078 ns | 0.0073 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.9077 ns | 0.0253 ns | 0.0236 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.0663 ns | 0.0083 ns | 0.0074 ns |  1.08 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.7693 ns | 0.0131 ns | 0.0122 ns |  0.93 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.6128 ns | 0.0052 ns | 0.0046 ns |  0.85 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.3927 ns | 0.0045 ns | 0.0038 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.2913 ns | 0.0052 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4986 ns | 0.0190 ns | 0.0177 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.2465 ns | 0.0086 ns | 0.0081 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.7341 ns | 0.0088 ns | 0.0078 ns |  1.10 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.6909 ns | 0.0064 ns | 0.0060 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.9578 ns | 0.0081 ns | 0.0076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.8983 ns | 0.0073 ns | 0.0064 ns |  0.97 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.6356 ns | 0.0085 ns | 0.0076 ns |  0.84 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  1.3619 ns | 0.0080 ns | 0.0075 ns |  0.70 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  1.3626 ns | 0.0037 ns | 0.0035 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.3040 ns | 0.0214 ns | 0.0200 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4625 ns | 0.0133 ns | 0.0118 ns |  1.04 |    0.01 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.4824 ns | 0.0083 ns | 0.0078 ns |  1.04 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.6900 ns | 0.0122 ns | 0.0114 ns |  1.09 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.7263 ns | 0.0202 ns | 0.0189 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.8805 ns | 0.0038 ns | 0.0031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.7225 ns | 0.0059 ns | 0.0053 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.5206 ns | 0.0094 ns | 0.0084 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.4036 ns | 0.0221 ns | 0.0196 ns |  0.75 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.3807 ns | 0.0054 ns | 0.0051 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.3413 ns | 0.0110 ns | 0.0097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4591 ns | 0.0088 ns | 0.0082 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.4760 ns | 0.0097 ns | 0.0075 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.6898 ns | 0.0093 ns | 0.0083 ns |  1.08 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.7042 ns | 0.0150 ns | 0.0125 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.9581 ns | 0.0052 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.9823 ns | 0.0053 ns | 0.0044 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.7005 ns | 0.0094 ns | 0.0084 ns |  0.87 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  1.4118 ns | 0.0044 ns | 0.0041 ns |  0.72 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  1.3706 ns | 0.0047 ns | 0.0042 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.4307 ns | 0.0207 ns | 0.0194 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.1914 ns | 0.0071 ns | 0.0063 ns |  0.90 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.0761 ns | 0.0062 ns | 0.0049 ns |  0.85 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  3.1643 ns | 0.0072 ns | 0.0064 ns |  1.30 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  3.1864 ns | 0.0076 ns | 0.0071 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.8761 ns | 0.0071 ns | 0.0063 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.7505 ns | 0.0045 ns | 0.0038 ns |  0.93 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.6839 ns | 0.0018 ns | 0.0016 ns |  0.90 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  1.3879 ns | 0.0057 ns | 0.0048 ns |  0.74 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  1.3858 ns | 0.0052 ns | 0.0048 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.1700 ns | 0.0055 ns | 0.0051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.2015 ns | 0.0175 ns | 0.0163 ns |  1.01 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.0853 ns | 0.0093 ns | 0.0083 ns |  0.96 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.8795 ns | 0.0218 ns | 0.0170 ns |  1.33 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.8393 ns | 0.0099 ns | 0.0087 ns |  1.31 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.7524 ns | 0.0109 ns | 0.0097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.8817 ns | 0.0070 ns | 0.0066 ns |  1.07 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.6482 ns | 0.0127 ns | 0.0113 ns |  0.94 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.6006 ns | 0.0078 ns | 0.0069 ns |  0.91 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.6037 ns | 0.0063 ns | 0.0055 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.7985 ns | 0.0184 ns | 0.0172 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.9363 ns | 0.0203 ns | 0.0180 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.7358 ns | 0.0298 ns | 0.0279 ns |  0.99 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  5.2081 ns | 0.0204 ns | 0.0181 ns |  1.09 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  5.1611 ns | 0.0067 ns | 0.0056 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.8772 ns | 0.0058 ns | 0.0052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.9443 ns | 0.0102 ns | 0.0090 ns |  1.04 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.9243 ns | 0.0115 ns | 0.0096 ns |  1.02 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.1827 ns | 0.0051 ns | 0.0048 ns |  0.63 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.1898 ns | 0.0056 ns | 0.0047 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.2840 ns | 0.0109 ns | 0.0102 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.5276 ns | 0.0304 ns | 0.0285 ns |  1.11 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.3119 ns | 0.0047 ns | 0.0037 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.8241 ns | 0.0072 ns | 0.0060 ns |  1.24 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.8409 ns | 0.0204 ns | 0.0190 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.3814 ns | 0.0170 ns | 0.0159 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.3238 ns | 0.0141 ns | 0.0118 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.2691 ns | 0.1292 ns | 0.1208 ns |  0.98 |    0.02 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.5848 ns | 0.0169 ns | 0.0158 ns |  1.03 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.6001 ns | 0.0324 ns | 0.0303 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.6825 ns | 0.0602 ns | 0.0534 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 19.1501 ns | 0.0272 ns | 0.0241 ns |  1.03 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.4598 ns | 0.1091 ns | 0.1020 ns |  0.72 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.9467 ns | 0.0403 ns | 0.0377 ns |  1.01 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.9883 ns | 0.0459 ns | 0.0407 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3446 ns | 0.0042 ns | 0.0037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3872 ns | 0.0087 ns | 0.0081 ns |  1.02 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1153 ns | 0.0046 ns | 0.0041 ns |  0.90 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.4316 ns | 0.0052 ns | 0.0049 ns |  0.61 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.4453 ns | 0.0200 ns | 0.0187 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.1250 ns | 0.0274 ns | 0.0243 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3361 ns | 0.0366 ns | 0.0343 ns |  1.03 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9169 ns | 0.0040 ns | 0.0033 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.3082 ns | 0.0104 ns | 0.0092 ns |  1.02 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.3540 ns | 0.0291 ns | 0.0258 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.9264 ns | 0.0459 ns | 0.0429 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.6011 ns | 0.0228 ns | 0.0213 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.5381 ns | 0.0504 ns | 0.0471 ns |  1.16 |    0.02 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.8095 ns | 0.0174 ns | 0.0163 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.7843 ns | 0.0280 ns | 0.0262 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 |  3.3421 ns | 0.0156 ns | 0.0138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 2.2 |  3.0645 ns | 0.0145 ns | 0.0129 ns |  0.92 |    0.01 |      - |     - |     - |         - |
          To_String | .NET Core 3.0 |  3.3751 ns | 0.0088 ns | 0.0078 ns |  1.01 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 |  3.0068 ns | 0.0071 ns | 0.0067 ns |  0.90 |    0.00 |      - |     - |     - |         - |
          To_String |        net472 |  3.0248 ns | 0.0065 ns | 0.0061 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.5369 ns | 0.0246 ns | 0.0206 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.4755 ns | 0.0273 ns | 0.0242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.7283 ns | 0.0229 ns | 0.0203 ns |  0.70 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.4542 ns | 0.0446 ns | 0.0395 ns |  1.23 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.3332 ns | 0.0342 ns | 0.0286 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.8445 ns | 0.0298 ns | 0.0264 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.9537 ns | 0.0402 ns | 0.0336 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.3003 ns | 0.0701 ns | 0.0656 ns |  0.79 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 19.9241 ns | 0.0781 ns | 0.0692 ns |  1.18 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 20.0549 ns | 0.1013 ns | 0.0948 ns |  1.19 |    0.01 |      - |     - |     - |         - |
