
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.4711 ns | 0.0136 ns | 0.0127 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.2065 ns | 0.0114 ns | 0.0101 ns |  0.82 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.2580 ns | 0.0037 ns | 0.0029 ns |  0.86 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  0.9870 ns | 0.0045 ns | 0.0042 ns |  0.67 |    0.01 |     - |     - |     - |         - |
             ToBool |        net472 |  0.9834 ns | 0.0054 ns | 0.0048 ns |  0.67 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0334 ns | 0.0244 ns | 0.0228 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2290 ns | 0.0284 ns | 0.0265 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0322 ns | 0.0053 ns | 0.0050 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2148 ns | 0.0066 ns | 0.0055 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2139 ns | 0.0068 ns | 0.0060 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.5939 ns | 0.0203 ns | 0.0190 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.5865 ns | 0.0599 ns | 0.0641 ns |  1.00 |    0.04 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.3959 ns | 0.0050 ns | 0.0039 ns |  0.88 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9908 ns | 0.0105 ns | 0.0098 ns |  0.62 |    0.01 |     - |     - |     - |         - |
             ToChar |        net472 |  1.0002 ns | 0.0168 ns | 0.0157 ns |  0.63 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0321 ns | 0.0318 ns | 0.0297 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.2476 ns | 0.0440 ns | 0.0412 ns |  1.05 |    0.02 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0095 ns | 0.0060 ns | 0.0053 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.4493 ns | 0.0085 ns | 0.0080 ns |  1.10 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4435 ns | 0.0080 ns | 0.0071 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4839 ns | 0.0205 ns | 0.0192 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.2981 ns | 0.0175 ns | 0.0164 ns |  0.87 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.2970 ns | 0.0030 ns | 0.0028 ns |  0.87 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9838 ns | 0.0042 ns | 0.0039 ns |  0.66 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.9992 ns | 0.0127 ns | 0.0119 ns |  0.67 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.2722 ns | 0.0287 ns | 0.0268 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.3282 ns | 0.0313 ns | 0.0261 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0083 ns | 0.0095 ns | 0.0085 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.4912 ns | 0.0064 ns | 0.0057 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4502 ns | 0.0064 ns | 0.0053 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.7462 ns | 0.0176 ns | 0.0164 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4349 ns | 0.0109 ns | 0.0097 ns |  0.82 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.4740 ns | 0.0144 ns | 0.0127 ns |  0.84 |    0.01 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9742 ns | 0.0047 ns | 0.0044 ns |  0.56 |    0.01 |     - |     - |     - |         - |
             ToByte |        net472 |  0.9736 ns | 0.0042 ns | 0.0039 ns |  0.56 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  1.1143 ns | 0.0121 ns | 0.0107 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  0.9407 ns | 0.0102 ns | 0.0090 ns |  0.84 |    0.01 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  0.9673 ns | 0.0033 ns | 0.0030 ns |  0.87 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  0.9821 ns | 0.0036 ns | 0.0032 ns |  0.88 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  0.9844 ns | 0.0060 ns | 0.0056 ns |  0.88 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.5342 ns | 0.0158 ns | 0.0148 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.3454 ns | 0.0043 ns | 0.0040 ns |  0.88 |    0.01 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.4059 ns | 0.0200 ns | 0.0187 ns |  0.92 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 |  0.9854 ns | 0.0061 ns | 0.0054 ns |  0.64 |    0.01 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9854 ns | 0.0060 ns | 0.0056 ns |  0.64 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.0336 ns | 0.0225 ns | 0.0188 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1971 ns | 0.0242 ns | 0.0226 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0033 ns | 0.0070 ns | 0.0058 ns |  0.99 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.4697 ns | 0.0276 ns | 0.0258 ns |  1.11 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.4501 ns | 0.0054 ns | 0.0048 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.6623 ns | 0.0107 ns | 0.0100 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.2231 ns | 0.0048 ns | 0.0045 ns |  0.74 |    0.01 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.2794 ns | 0.0049 ns | 0.0046 ns |  0.77 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9849 ns | 0.0051 ns | 0.0048 ns |  0.59 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9838 ns | 0.0117 ns | 0.0103 ns |  0.59 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.0117 ns | 0.0141 ns | 0.0132 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1777 ns | 0.0113 ns | 0.0105 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0031 ns | 0.0111 ns | 0.0099 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4563 ns | 0.0106 ns | 0.0099 ns |  1.11 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.4521 ns | 0.0107 ns | 0.0101 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.5505 ns | 0.0230 ns | 0.0215 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.3599 ns | 0.0041 ns | 0.0039 ns |  0.88 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.3947 ns | 0.0057 ns | 0.0047 ns |  0.90 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  0.9869 ns | 0.0066 ns | 0.0061 ns |  0.64 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9848 ns | 0.0023 ns | 0.0022 ns |  0.64 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0206 ns | 0.0167 ns | 0.0148 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.0525 ns | 0.0102 ns | 0.0091 ns |  1.01 |    0.01 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0329 ns | 0.0125 ns | 0.0104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4617 ns | 0.0160 ns | 0.0150 ns |  1.11 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4596 ns | 0.0199 ns | 0.0186 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.5898 ns | 0.0199 ns | 0.0186 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.1990 ns | 0.0069 ns | 0.0065 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.2664 ns | 0.0186 ns | 0.0174 ns |  0.80 |    0.02 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9865 ns | 0.0057 ns | 0.0050 ns |  0.62 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net472 |  1.3243 ns | 0.0036 ns | 0.0034 ns |  0.83 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.0200 ns | 0.0147 ns | 0.0138 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1759 ns | 0.0089 ns | 0.0083 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0044 ns | 0.0078 ns | 0.0073 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4541 ns | 0.0107 ns | 0.0100 ns |  1.11 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4940 ns | 0.0425 ns | 0.0397 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.4420 ns | 0.0225 ns | 0.0210 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.2529 ns | 0.0176 ns | 0.0165 ns |  0.87 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.2837 ns | 0.0059 ns | 0.0053 ns |  0.89 |    0.01 |     - |     - |     - |         - |
             ToLong |        net461 |  1.0064 ns | 0.0085 ns | 0.0080 ns |  0.70 |    0.01 |     - |     - |     - |         - |
             ToLong |        net472 |  1.0248 ns | 0.0032 ns | 0.0029 ns |  0.71 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.8370 ns | 0.0117 ns | 0.0104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.7120 ns | 0.0190 ns | 0.0177 ns |  0.93 |    0.01 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.9260 ns | 0.0125 ns | 0.0117 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.3625 ns | 0.0122 ns | 0.0114 ns |  1.29 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.3540 ns | 0.0070 ns | 0.0059 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.6061 ns | 0.0244 ns | 0.0229 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.2308 ns | 0.0039 ns | 0.0034 ns |  0.77 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.2691 ns | 0.0065 ns | 0.0058 ns |  0.79 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9851 ns | 0.0074 ns | 0.0066 ns |  0.61 |    0.01 |     - |     - |     - |         - |
            ToULong |        net472 |  0.9877 ns | 0.0043 ns | 0.0038 ns |  0.62 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.8369 ns | 0.0178 ns | 0.0149 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.7429 ns | 0.0028 ns | 0.0024 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.9124 ns | 0.0193 ns | 0.0181 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  1.9137 ns | 0.0079 ns | 0.0070 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  1.9075 ns | 0.0053 ns | 0.0047 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.3778 ns | 0.0227 ns | 0.0201 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.3555 ns | 0.0038 ns | 0.0035 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.2304 ns | 0.0043 ns | 0.0040 ns |  0.89 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.0300 ns | 0.0114 ns | 0.0106 ns |  0.75 |    0.02 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.0058 ns | 0.0127 ns | 0.0118 ns |  0.73 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2522 ns | 0.0191 ns | 0.0169 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.8721 ns | 0.0072 ns | 0.0068 ns |  1.15 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2408 ns | 0.0089 ns | 0.0079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6877 ns | 0.0060 ns | 0.0056 ns |  1.10 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6749 ns | 0.0075 ns | 0.0066 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.5788 ns | 0.0126 ns | 0.0118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.2362 ns | 0.0158 ns | 0.0148 ns |  0.78 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.4293 ns | 0.0057 ns | 0.0053 ns |  0.91 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.0071 ns | 0.0053 ns | 0.0041 ns |  0.64 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.0091 ns | 0.0058 ns | 0.0054 ns |  0.64 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.0974 ns | 0.0296 ns | 0.0277 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.9292 ns | 0.0037 ns | 0.0034 ns |  0.92 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.7939 ns | 0.0064 ns | 0.0057 ns |  0.86 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.3727 ns | 0.0125 ns | 0.0110 ns |  1.13 |    0.02 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.3778 ns | 0.0090 ns | 0.0079 ns |  1.13 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.0619 ns | 0.0402 ns | 0.0376 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  1.9701 ns | 0.0206 ns | 0.0193 ns |  0.96 |    0.02 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.1788 ns | 0.0107 ns | 0.0100 ns |  1.06 |    0.02 |     - |     - |     - |         - |
          ToDecimal |        net461 | 12.3711 ns | 0.0132 ns | 0.0123 ns |  6.00 |    0.11 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.0922 ns | 0.0119 ns | 0.0105 ns |  2.96 |    0.06 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.1638 ns | 0.0596 ns | 0.0528 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.7502 ns | 0.0216 ns | 0.0202 ns |  1.06 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.1716 ns | 0.0068 ns | 0.0060 ns |  0.21 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.8674 ns | 0.0468 ns | 0.0438 ns |  1.07 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.7566 ns | 0.0186 ns | 0.0174 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2999 ns | 0.0116 ns | 0.0108 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.0608 ns | 0.0048 ns | 0.0045 ns |  0.90 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1095 ns | 0.0077 ns | 0.0068 ns |  0.92 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.4282 ns | 0.0029 ns | 0.0025 ns |  0.62 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.4296 ns | 0.0161 ns | 0.0150 ns |  0.62 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.4048 ns | 0.0490 ns | 0.0459 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.5251 ns | 0.0217 ns | 0.0182 ns |  1.02 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9358 ns | 0.0176 ns | 0.0147 ns |  0.23 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4218 ns | 0.0179 ns | 0.0158 ns |  1.00 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.4968 ns | 0.0491 ns | 0.0459 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4411 ns | 0.0179 ns | 0.0159 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.2284 ns | 0.0040 ns | 0.0032 ns |  0.85 |    0.01 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.2854 ns | 0.0032 ns | 0.0028 ns |  0.89 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  1.1534 ns | 0.0051 ns | 0.0045 ns |  0.80 |    0.01 |     - |     - |     - |         - |
           ToObject |        net472 |  1.1393 ns | 0.0045 ns | 0.0042 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.5827 ns | 0.0199 ns | 0.0186 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.3672 ns | 0.0065 ns | 0.0057 ns |  0.86 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.3173 ns | 0.0163 ns | 0.0152 ns |  0.83 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.2706 ns | 0.0116 ns | 0.0109 ns |  0.80 |    0.01 |     - |     - |     - |         - |
          To_String |        net472 |  1.2625 ns | 0.0058 ns | 0.0049 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.5803 ns | 0.0221 ns | 0.0206 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.4746 ns | 0.0033 ns | 0.0031 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.3280 ns | 0.0036 ns | 0.0034 ns |  0.84 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2621 ns | 0.0050 ns | 0.0044 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.9126 ns | 0.0065 ns | 0.0058 ns |  1.21 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.2590 ns | 0.0236 ns | 0.0221 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4478 ns | 0.0119 ns | 0.0111 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.0113 ns | 0.0081 ns | 0.0068 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6924 ns | 0.0096 ns | 0.0090 ns |  1.10 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.7035 ns | 0.0384 ns | 0.0359 ns |  1.10 |    0.01 |     - |     - |     - |         - |
