
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
             ToBool | .NET Core 2.0 |  1.4529 ns | 0.0089 ns | 0.0079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.6860 ns | 0.0056 ns | 0.0052 ns |  1.16 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.6224 ns | 0.0038 ns | 0.0035 ns |  1.12 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  1.0045 ns | 0.0040 ns | 0.0035 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  1.0024 ns | 0.0038 ns | 0.0035 ns |  0.69 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0475 ns | 0.0082 ns | 0.0073 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1882 ns | 0.0102 ns | 0.0095 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0488 ns | 0.0281 ns | 0.0249 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2104 ns | 0.0109 ns | 0.0091 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1755 ns | 0.0093 ns | 0.0078 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.5554 ns | 0.0040 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.4863 ns | 0.0075 ns | 0.0063 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.4718 ns | 0.0039 ns | 0.0034 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 |  1.0060 ns | 0.0055 ns | 0.0052 ns |  0.65 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  1.0049 ns | 0.0108 ns | 0.0090 ns |  0.65 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.3154 ns | 0.0190 ns | 0.0168 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1917 ns | 0.0099 ns | 0.0092 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0483 ns | 0.0369 ns | 0.0345 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.3400 ns | 0.0194 ns | 0.0181 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4054 ns | 0.0106 ns | 0.0099 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4588 ns | 0.0054 ns | 0.0050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6201 ns | 0.0045 ns | 0.0037 ns |  1.11 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.6191 ns | 0.0063 ns | 0.0056 ns |  1.11 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 |  1.0071 ns | 0.0045 ns | 0.0040 ns |  0.69 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  1.0242 ns | 0.0073 ns | 0.0068 ns |  0.70 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.2955 ns | 0.0336 ns | 0.0314 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.1835 ns | 0.0077 ns | 0.0072 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0250 ns | 0.0205 ns | 0.0192 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.4408 ns | 0.0098 ns | 0.0082 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4128 ns | 0.0119 ns | 0.0111 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.5585 ns | 0.0052 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4792 ns | 0.0045 ns | 0.0042 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.4588 ns | 0.0045 ns | 0.0042 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 |  1.0034 ns | 0.0060 ns | 0.0056 ns |  0.64 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  1.0044 ns | 0.0111 ns | 0.0104 ns |  0.65 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.2708 ns | 0.0081 ns | 0.0067 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.2217 ns | 0.0343 ns | 0.0321 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  3.9965 ns | 0.0111 ns | 0.0104 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4609 ns | 0.0392 ns | 0.0367 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.4107 ns | 0.0062 ns | 0.0055 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.4772 ns | 0.0092 ns | 0.0081 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.6148 ns | 0.0052 ns | 0.0046 ns |  1.09 |    0.01 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.6078 ns | 0.0041 ns | 0.0039 ns |  1.09 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 |  1.0054 ns | 0.0052 ns | 0.0048 ns |  0.68 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  1.0040 ns | 0.0055 ns | 0.0049 ns |  0.68 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.2784 ns | 0.0090 ns | 0.0080 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1812 ns | 0.0104 ns | 0.0087 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0009 ns | 0.0112 ns | 0.0099 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.4471 ns | 0.0088 ns | 0.0078 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.4120 ns | 0.0092 ns | 0.0081 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.5592 ns | 0.0053 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.4842 ns | 0.0041 ns | 0.0037 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.4910 ns | 0.0043 ns | 0.0038 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  1.0066 ns | 0.0035 ns | 0.0031 ns |  0.65 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  1.1208 ns | 0.0028 ns | 0.0023 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.2701 ns | 0.0132 ns | 0.0117 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1927 ns | 0.0134 ns | 0.0126 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  3.9951 ns | 0.0070 ns | 0.0065 ns |  0.94 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4438 ns | 0.0063 ns | 0.0059 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.4380 ns | 0.0240 ns | 0.0213 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.4782 ns | 0.0031 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.6146 ns | 0.0078 ns | 0.0073 ns |  1.09 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.6191 ns | 0.0069 ns | 0.0061 ns |  1.10 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  0.9772 ns | 0.0144 ns | 0.0135 ns |  0.66 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9702 ns | 0.0041 ns | 0.0038 ns |  0.66 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.2749 ns | 0.0099 ns | 0.0088 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1892 ns | 0.0066 ns | 0.0058 ns |  0.98 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0003 ns | 0.0097 ns | 0.0091 ns |  0.94 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4475 ns | 0.0121 ns | 0.0113 ns |  1.04 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4078 ns | 0.0090 ns | 0.0084 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.5538 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4111 ns | 0.0044 ns | 0.0041 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4188 ns | 0.0037 ns | 0.0035 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9781 ns | 0.0122 ns | 0.0108 ns |  0.63 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.9779 ns | 0.0047 ns | 0.0044 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.2837 ns | 0.0150 ns | 0.0133 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1888 ns | 0.0095 ns | 0.0079 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0290 ns | 0.0270 ns | 0.0252 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4483 ns | 0.0125 ns | 0.0117 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4156 ns | 0.0149 ns | 0.0140 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.6366 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.6302 ns | 0.0068 ns | 0.0064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.4435 ns | 0.0048 ns | 0.0043 ns |  0.88 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 |  1.2071 ns | 0.0184 ns | 0.0172 ns |  0.74 |    0.01 |     - |     - |     - |         - |
             ToLong |        net472 |  1.1927 ns | 0.0082 ns | 0.0076 ns |  0.73 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.7758 ns | 0.0059 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.5878 ns | 0.0041 ns | 0.0036 ns |  0.89 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.6019 ns | 0.0030 ns | 0.0027 ns |  0.90 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  1.8067 ns | 0.0049 ns | 0.0046 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  1.5671 ns | 0.0034 ns | 0.0030 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.6449 ns | 0.0039 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4195 ns | 0.0257 ns | 0.0240 ns |  0.86 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.6235 ns | 0.0049 ns | 0.0046 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 |  1.2014 ns | 0.0051 ns | 0.0043 ns |  0.73 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  1.1889 ns | 0.0023 ns | 0.0019 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.3123 ns | 0.0530 ns | 0.0470 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.0951 ns | 0.0075 ns | 0.0070 ns |  0.91 |    0.02 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.1302 ns | 0.0158 ns | 0.0140 ns |  0.92 |    0.02 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  1.9780 ns | 0.0069 ns | 0.0065 ns |  0.86 |    0.02 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  1.8706 ns | 0.0046 ns | 0.0041 ns |  0.81 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.5568 ns | 0.0103 ns | 0.0086 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.3614 ns | 0.0058 ns | 0.0052 ns |  0.87 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.7386 ns | 0.0034 ns | 0.0032 ns |  1.12 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.1689 ns | 0.0054 ns | 0.0048 ns |  0.75 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.1951 ns | 0.0044 ns | 0.0041 ns |  0.77 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2785 ns | 0.0121 ns | 0.0107 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4223 ns | 0.0088 ns | 0.0078 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2480 ns | 0.0078 ns | 0.0069 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.7034 ns | 0.0376 ns | 0.0351 ns |  1.10 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6426 ns | 0.0158 ns | 0.0148 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6453 ns | 0.0093 ns | 0.0083 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.3556 ns | 0.0057 ns | 0.0054 ns |  0.82 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.5804 ns | 0.0043 ns | 0.0038 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.0316 ns | 0.0056 ns | 0.0053 ns |  0.63 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.0429 ns | 0.0135 ns | 0.0127 ns |  0.63 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.2833 ns | 0.0128 ns | 0.0107 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.0622 ns | 0.0059 ns | 0.0053 ns |  0.90 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1955 ns | 0.0214 ns | 0.0200 ns |  0.96 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.1890 ns | 0.0036 ns | 0.0032 ns |  0.96 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.1071 ns | 0.0047 ns | 0.0044 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.2832 ns | 0.0154 ns | 0.0129 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.8034 ns | 0.0052 ns | 0.0049 ns |  1.23 |    0.01 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.0595 ns | 0.0063 ns | 0.0056 ns |  0.90 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.1520 ns | 0.0145 ns | 0.0136 ns |  2.69 |    0.02 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.2857 ns | 0.0094 ns | 0.0084 ns |  2.75 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.0677 ns | 0.0174 ns | 0.0154 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.7619 ns | 0.0192 ns | 0.0180 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.4383 ns | 0.0205 ns | 0.0191 ns |  0.24 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 11.7242 ns | 0.0168 ns | 0.0157 ns |  1.16 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.7259 ns | 0.0215 ns | 0.0191 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3415 ns | 0.0037 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3238 ns | 0.0173 ns | 0.0162 ns |  0.99 |    0.01 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3201 ns | 0.0049 ns | 0.0046 ns |  0.99 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.2128 ns | 0.0179 ns | 0.0159 ns |  0.52 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.2725 ns | 0.0044 ns | 0.0041 ns |  0.54 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.2052 ns | 0.0287 ns | 0.0240 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.2470 ns | 0.0143 ns | 0.0133 ns |  1.01 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9070 ns | 0.0105 ns | 0.0098 ns |  0.23 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4655 ns | 0.0232 ns | 0.0217 ns |  1.03 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.6326 ns | 0.0158 ns | 0.0148 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4686 ns | 0.0055 ns | 0.0051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.4700 ns | 0.0047 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.4631 ns | 0.0055 ns | 0.0052 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9963 ns | 0.0061 ns | 0.0054 ns |  0.68 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9925 ns | 0.0045 ns | 0.0042 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.6532 ns | 0.0131 ns | 0.0109 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.4688 ns | 0.0036 ns | 0.0034 ns |  0.89 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.6181 ns | 0.0052 ns | 0.0043 ns |  0.98 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.3460 ns | 0.0110 ns | 0.0103 ns |  0.81 |    0.01 |     - |     - |     - |         - |
          To_String |        net472 |  1.3400 ns | 0.0079 ns | 0.0070 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.6363 ns | 0.0045 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.6127 ns | 0.0088 ns | 0.0082 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.6225 ns | 0.0168 ns | 0.0158 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2818 ns | 0.0059 ns | 0.0055 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.2784 ns | 0.0092 ns | 0.0077 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.2789 ns | 0.0112 ns | 0.0094 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4223 ns | 0.0138 ns | 0.0129 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  3.9902 ns | 0.0046 ns | 0.0041 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.7005 ns | 0.0399 ns | 0.0373 ns |  1.10 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.6820 ns | 0.0201 ns | 0.0188 ns |  1.10 |    0.00 |     - |     - |     - |         - |
