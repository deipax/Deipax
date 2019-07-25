
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|------:|------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.4704 ns | 0.0092 ns | 0.0086 ns |  1.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1596 ns | 0.0072 ns | 0.0064 ns |  0.79 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4378 ns | 0.0073 ns | 0.0068 ns |  0.98 |     - |     - |     - |         - |
             ToBool |        net461 |  1.1856 ns | 0.0042 ns | 0.0035 ns |  0.81 |     - |     - |     - |         - |
             ToBool |        net472 |  1.1823 ns | 0.0029 ns | 0.0026 ns |  0.80 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.2752 ns | 0.0128 ns | 0.0120 ns |  1.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.3774 ns | 0.0096 ns | 0.0085 ns |  1.02 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.2541 ns | 0.0073 ns | 0.0068 ns |  1.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.4263 ns | 0.0230 ns | 0.0215 ns |  1.04 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.4064 ns | 0.0112 ns | 0.0105 ns |  1.03 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.1930 ns | 0.0039 ns | 0.0032 ns |  1.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.1165 ns | 0.0033 ns | 0.0030 ns |  0.94 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.3950 ns | 0.0049 ns | 0.0046 ns |  1.17 |     - |     - |     - |         - |
             ToChar |        net461 |  0.7272 ns | 0.0075 ns | 0.0067 ns |  0.61 |     - |     - |     - |         - |
             ToChar |        net472 |  0.7232 ns | 0.0117 ns | 0.0110 ns |  0.61 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0348 ns | 0.0063 ns | 0.0052 ns |  1.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.3833 ns | 0.0089 ns | 0.0083 ns |  1.09 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.2924 ns | 0.0259 ns | 0.0242 ns |  1.06 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.3997 ns | 0.0079 ns | 0.0070 ns |  1.09 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4095 ns | 0.0109 ns | 0.0102 ns |  1.09 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4683 ns | 0.0043 ns | 0.0040 ns |  1.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.2109 ns | 0.0097 ns | 0.0086 ns |  0.82 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.4865 ns | 0.0030 ns | 0.0025 ns |  1.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  1.0433 ns | 0.0032 ns | 0.0028 ns |  0.71 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.9454 ns | 0.0035 ns | 0.0031 ns |  0.64 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.5498 ns | 0.0203 ns | 0.0180 ns |  1.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4253 ns | 0.0363 ns | 0.0340 ns |  0.97 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.2578 ns | 0.0207 ns | 0.0173 ns |  0.94 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.6890 ns | 0.0072 ns | 0.0068 ns |  1.03 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.6903 ns | 0.0490 ns | 0.0458 ns |  1.03 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.6634 ns | 0.0073 ns | 0.0068 ns |  1.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.3465 ns | 0.0052 ns | 0.0044 ns |  0.81 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.5644 ns | 0.0109 ns | 0.0097 ns |  0.94 |     - |     - |     - |         - |
             ToByte |        net461 |  1.2086 ns | 0.0028 ns | 0.0022 ns |  0.73 |     - |     - |     - |         - |
             ToByte |        net472 |  1.2103 ns | 0.0033 ns | 0.0028 ns |  0.73 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.5026 ns | 0.0084 ns | 0.0078 ns |  1.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.3740 ns | 0.0051 ns | 0.0046 ns |  0.97 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.2496 ns | 0.0140 ns | 0.0131 ns |  0.94 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.6916 ns | 0.0205 ns | 0.0191 ns |  1.04 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.6427 ns | 0.0149 ns | 0.0124 ns |  1.03 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.4699 ns | 0.0051 ns | 0.0045 ns |  1.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.3266 ns | 0.0037 ns | 0.0034 ns |  0.90 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.6238 ns | 0.0051 ns | 0.0048 ns |  1.10 |     - |     - |     - |         - |
            ToShort |        net461 |  0.9477 ns | 0.0036 ns | 0.0032 ns |  0.64 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9402 ns | 0.0036 ns | 0.0032 ns |  0.64 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.5117 ns | 0.0191 ns | 0.0179 ns |  1.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.3775 ns | 0.0091 ns | 0.0080 ns |  0.97 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.2584 ns | 0.0106 ns | 0.0099 ns |  0.94 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.6331 ns | 0.0078 ns | 0.0073 ns |  1.03 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.6394 ns | 0.0131 ns | 0.0123 ns |  1.03 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.6761 ns | 0.0088 ns | 0.0083 ns |  1.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.1615 ns | 0.0073 ns | 0.0068 ns |  0.69 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.4411 ns | 0.0083 ns | 0.0065 ns |  0.86 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9465 ns | 0.0046 ns | 0.0041 ns |  0.56 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9521 ns | 0.0109 ns | 0.0102 ns |  0.57 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.5094 ns | 0.0118 ns | 0.0104 ns |  1.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.3826 ns | 0.0059 ns | 0.0053 ns |  0.97 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.2821 ns | 0.0254 ns | 0.0238 ns |  0.95 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.6443 ns | 0.0089 ns | 0.0079 ns |  1.03 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.6368 ns | 0.0108 ns | 0.0096 ns |  1.03 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.5866 ns | 0.0132 ns | 0.0117 ns |  1.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.1609 ns | 0.0064 ns | 0.0060 ns |  0.73 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.4387 ns | 0.0100 ns | 0.0094 ns |  0.91 |     - |     - |     - |         - |
              ToInt |        net461 |  1.2004 ns | 0.0062 ns | 0.0058 ns |  0.76 |     - |     - |     - |         - |
              ToInt |        net472 |  1.1905 ns | 0.0038 ns | 0.0033 ns |  0.75 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.5552 ns | 0.0208 ns | 0.0195 ns |  1.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4349 ns | 0.0212 ns | 0.0198 ns |  0.97 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.2528 ns | 0.0099 ns | 0.0088 ns |  0.93 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.6463 ns | 0.0121 ns | 0.0107 ns |  1.02 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.6429 ns | 0.0157 ns | 0.0139 ns |  1.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.6443 ns | 0.0037 ns | 0.0034 ns |  1.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.3853 ns | 0.0067 ns | 0.0063 ns |  0.84 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.6301 ns | 0.0035 ns | 0.0029 ns |  0.99 |     - |     - |     - |         - |
             ToUInt |        net461 |  1.2220 ns | 0.0045 ns | 0.0042 ns |  0.74 |     - |     - |     - |         - |
             ToUInt |        net472 |  1.2106 ns | 0.0052 ns | 0.0048 ns |  0.74 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4969 ns | 0.0097 ns | 0.0090 ns |  1.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4280 ns | 0.0136 ns | 0.0114 ns |  0.99 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.2718 ns | 0.0376 ns | 0.0333 ns |  0.95 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.6416 ns | 0.0113 ns | 0.0101 ns |  1.03 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.6749 ns | 0.0280 ns | 0.0262 ns |  1.04 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.4536 ns | 0.0077 ns | 0.0068 ns |  1.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.3350 ns | 0.0079 ns | 0.0070 ns |  0.92 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.6266 ns | 0.0031 ns | 0.0026 ns |  1.12 |     - |     - |     - |         - |
             ToLong |        net461 |  1.2165 ns | 0.0134 ns | 0.0119 ns |  0.84 |     - |     - |     - |         - |
             ToLong |        net472 |  1.1846 ns | 0.0042 ns | 0.0039 ns |  0.82 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.4263 ns | 0.0059 ns | 0.0056 ns |  1.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.0641 ns | 0.0073 ns | 0.0064 ns |  0.85 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1033 ns | 0.0073 ns | 0.0068 ns |  0.87 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.0913 ns | 0.0035 ns | 0.0029 ns |  0.86 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.1215 ns | 0.0233 ns | 0.0218 ns |  0.87 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.6429 ns | 0.0063 ns | 0.0059 ns |  1.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.3312 ns | 0.0060 ns | 0.0056 ns |  0.81 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.6233 ns | 0.0035 ns | 0.0027 ns |  0.99 |     - |     - |     - |         - |
            ToULong |        net461 |  1.1828 ns | 0.0044 ns | 0.0039 ns |  0.72 |     - |     - |     - |         - |
            ToULong |        net472 |  1.1840 ns | 0.0030 ns | 0.0027 ns |  0.72 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.9484 ns | 0.0049 ns | 0.0043 ns |  1.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.0808 ns | 0.0168 ns | 0.0149 ns |  1.07 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.0956 ns | 0.0043 ns | 0.0040 ns |  1.08 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.0865 ns | 0.0055 ns | 0.0048 ns |  1.07 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.0903 ns | 0.0123 ns | 0.0103 ns |  1.07 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.4829 ns | 0.0049 ns | 0.0046 ns |  1.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.3429 ns | 0.0038 ns | 0.0032 ns |  0.91 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.6457 ns | 0.0112 ns | 0.0105 ns |  1.11 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.1900 ns | 0.0093 ns | 0.0087 ns |  0.80 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.1852 ns | 0.0028 ns | 0.0025 ns |  0.80 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2812 ns | 0.0306 ns | 0.0271 ns |  1.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.3795 ns | 0.0099 ns | 0.0088 ns |  1.02 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2495 ns | 0.0076 ns | 0.0067 ns |  0.99 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6478 ns | 0.0134 ns | 0.0119 ns |  1.09 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6780 ns | 0.0252 ns | 0.0236 ns |  1.09 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.4841 ns | 0.0117 ns | 0.0109 ns |  1.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.2485 ns | 0.0072 ns | 0.0067 ns |  0.84 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.5262 ns | 0.0036 ns | 0.0034 ns |  1.03 |     - |     - |     - |         - |
           ToDouble |        net461 |  0.9866 ns | 0.0048 ns | 0.0042 ns |  0.66 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.2842 ns | 0.0023 ns | 0.0018 ns |  0.87 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.6874 ns | 0.0047 ns | 0.0042 ns |  1.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.5624 ns | 0.0045 ns | 0.0038 ns |  0.93 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.7833 ns | 0.0054 ns | 0.0045 ns |  1.06 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.5727 ns | 0.0038 ns | 0.0033 ns |  0.93 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.5824 ns | 0.0080 ns | 0.0071 ns |  0.94 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.1809 ns | 0.0037 ns | 0.0035 ns |  1.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.0995 ns | 0.0056 ns | 0.0052 ns |  0.96 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.1957 ns | 0.0048 ns | 0.0043 ns |  1.01 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.1199 ns | 0.0285 ns | 0.0267 ns |  2.81 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.0546 ns | 0.0165 ns | 0.0146 ns |  2.78 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.0905 ns | 0.0236 ns | 0.0197 ns |  1.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 11.6623 ns | 0.0183 ns | 0.0143 ns |  1.16 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.3907 ns | 0.0122 ns | 0.0115 ns |  0.24 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.7239 ns | 0.0189 ns | 0.0176 ns |  1.06 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.8341 ns | 0.0579 ns | 0.0542 ns |  1.07 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3434 ns | 0.0037 ns | 0.0035 ns |  1.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.2183 ns | 0.0053 ns | 0.0047 ns |  0.95 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.2969 ns | 0.0052 ns | 0.0043 ns |  0.98 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.3549 ns | 0.0061 ns | 0.0057 ns |  0.58 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.3550 ns | 0.0051 ns | 0.0048 ns |  0.58 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.0572 ns | 0.0188 ns | 0.0157 ns |  1.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.4121 ns | 0.0225 ns | 0.0200 ns |  1.04 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9550 ns | 0.0187 ns | 0.0166 ns |  0.24 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.7752 ns | 0.0159 ns | 0.0149 ns |  1.09 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.4830 ns | 0.0104 ns | 0.0087 ns |  1.05 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4498 ns | 0.0036 ns | 0.0030 ns |  1.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.5768 ns | 0.0082 ns | 0.0077 ns |  1.09 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.5379 ns | 0.0074 ns | 0.0069 ns |  1.06 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9861 ns | 0.0068 ns | 0.0060 ns |  0.68 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9813 ns | 0.0045 ns | 0.0042 ns |  0.68 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
          To_String | .NET Core 2.0 |  1.6645 ns | 0.0123 ns | 0.0115 ns |  1.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.3228 ns | 0.0032 ns | 0.0030 ns |  0.79 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.6250 ns | 0.0064 ns | 0.0060 ns |  0.98 |     - |     - |     - |         - |
          To_String |        net461 |  1.2138 ns | 0.0030 ns | 0.0025 ns |  0.73 |     - |     - |     - |         - |
          To_String |        net472 |  1.2334 ns | 0.0147 ns | 0.0138 ns |  0.74 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.6463 ns | 0.0055 ns | 0.0052 ns |  1.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.3330 ns | 0.0047 ns | 0.0042 ns |  0.81 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.4390 ns | 0.0059 ns | 0.0053 ns |  0.87 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2123 ns | 0.0054 ns | 0.0048 ns |  0.74 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.5143 ns | 0.0053 ns | 0.0047 ns |  0.92 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.5111 ns | 0.0096 ns | 0.0090 ns |  1.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.6142 ns | 0.0080 ns | 0.0075 ns |  1.02 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.2908 ns | 0.0086 ns | 0.0076 ns |  0.95 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.8810 ns | 0.0097 ns | 0.0091 ns |  1.08 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.8791 ns | 0.0162 ns | 0.0152 ns |  1.08 |     - |     - |     - |         - |
