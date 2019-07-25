
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.7245 ns | 0.0082 ns | 0.0077 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6894 ns | 0.0057 ns | 0.0050 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7671 ns | 0.0035 ns | 0.0033 ns |  1.06 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6630 ns | 0.0025 ns | 0.0023 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6546 ns | 0.0037 ns | 0.0033 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1902 ns | 0.0164 ns | 0.0146 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.9633 ns | 0.0179 ns | 0.0167 ns |  0.81 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1798 ns | 0.0141 ns | 0.0132 ns |  0.99 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.2117 ns | 0.0180 ns | 0.0169 ns |  1.86 |    0.03 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.0672 ns | 0.0055 ns | 0.0046 ns |  1.74 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6993 ns | 0.0048 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6539 ns | 0.0070 ns | 0.0062 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7431 ns | 0.0058 ns | 0.0054 ns |  1.06 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6738 ns | 0.0039 ns | 0.0036 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6695 ns | 0.0039 ns | 0.0036 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9885 ns | 0.0084 ns | 0.0074 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.0715 ns | 0.0094 ns | 0.0088 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0955 ns | 0.0042 ns | 0.0035 ns |  1.11 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9915 ns | 0.0058 ns | 0.0052 ns |  2.01 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.9671 ns | 0.0053 ns | 0.0047 ns |  1.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.5398 ns | 0.0030 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.5720 ns | 0.0079 ns | 0.0070 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.5925 ns | 0.0027 ns | 0.0021 ns |  1.10 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.6781 ns | 0.0121 ns | 0.0113 ns |  1.25 |    0.02 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.8271 ns | 0.0052 ns | 0.0048 ns |  1.53 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.0392 ns | 0.0442 ns | 0.0413 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9834 ns | 0.0466 ns | 0.0537 ns |  0.95 |    0.06 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1815 ns | 0.0112 ns | 0.0100 ns |  1.13 |    0.04 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9244 ns | 0.0042 ns | 0.0037 ns |  1.85 |    0.07 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9311 ns | 0.0243 ns | 0.0227 ns |  1.86 |    0.08 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7399 ns | 0.0292 ns | 0.0273 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.5999 ns | 0.0284 ns | 0.0252 ns |  0.81 |    0.05 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.5831 ns | 0.0062 ns | 0.0055 ns |  0.79 |    0.03 |     - |     - |     - |         - |
             FromByte |        net461 |  0.6736 ns | 0.0097 ns | 0.0091 ns |  0.91 |    0.04 |     - |     - |     - |         - |
             FromByte |        net472 |  0.6671 ns | 0.0041 ns | 0.0037 ns |  0.90 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.0298 ns | 0.0305 ns | 0.0271 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9376 ns | 0.0098 ns | 0.0091 ns |  0.91 |    0.03 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9623 ns | 0.0032 ns | 0.0030 ns |  0.94 |    0.03 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9272 ns | 0.0080 ns | 0.0071 ns |  1.87 |    0.05 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9545 ns | 0.0095 ns | 0.0088 ns |  1.90 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.5485 ns | 0.0173 ns | 0.0162 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.7218 ns | 0.0128 ns | 0.0119 ns |  1.32 |    0.05 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7259 ns | 0.0038 ns | 0.0031 ns |  1.33 |    0.04 |     - |     - |     - |         - |
            FromShort |        net461 |  0.6867 ns | 0.0074 ns | 0.0069 ns |  1.25 |    0.03 |     - |     - |     - |         - |
            FromShort |        net472 |  0.6726 ns | 0.0027 ns | 0.0025 ns |  1.23 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.0101 ns | 0.0216 ns | 0.0192 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.1113 ns | 0.0070 ns | 0.0062 ns |  1.10 |    0.02 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.0983 ns | 0.0049 ns | 0.0046 ns |  1.09 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9518 ns | 0.0038 ns | 0.0033 ns |  1.93 |    0.04 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.4844 ns | 0.0060 ns | 0.0047 ns |  2.46 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.7044 ns | 0.0147 ns | 0.0131 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6547 ns | 0.0095 ns | 0.0079 ns |  0.93 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7461 ns | 0.0092 ns | 0.0082 ns |  1.06 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6860 ns | 0.0081 ns | 0.0076 ns |  0.97 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6718 ns | 0.0032 ns | 0.0030 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.0149 ns | 0.0140 ns | 0.0131 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.0737 ns | 0.0059 ns | 0.0052 ns |  1.06 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.0808 ns | 0.0052 ns | 0.0046 ns |  1.07 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.1324 ns | 0.0046 ns | 0.0043 ns |  2.10 |    0.03 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9480 ns | 0.0033 ns | 0.0031 ns |  1.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.5907 ns | 0.0061 ns | 0.0051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.6049 ns | 0.0165 ns | 0.0154 ns |  1.02 |    0.02 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7264 ns | 0.0032 ns | 0.0027 ns |  1.23 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.6698 ns | 0.0034 ns | 0.0032 ns |  1.13 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.6882 ns | 0.0033 ns | 0.0029 ns |  1.17 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  0.7013 ns | 0.0258 ns | 0.0241 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  0.6996 ns | 0.0034 ns | 0.0030 ns |  1.00 |    0.04 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  0.7305 ns | 0.0059 ns | 0.0055 ns |  1.04 |    0.04 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  0.5387 ns | 0.0034 ns | 0.0032 ns |  0.77 |    0.03 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  0.5363 ns | 0.0036 ns | 0.0032 ns |  0.76 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4780 ns | 0.0220 ns | 0.0206 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.3668 ns | 0.0123 ns | 0.0103 ns |  0.92 |    0.02 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9392 ns | 0.0032 ns | 0.0030 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7465 ns | 0.0180 ns | 0.0168 ns |  1.18 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.8594 ns | 0.0202 ns | 0.0189 ns |  1.26 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.1345 ns | 0.0101 ns | 0.0094 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.9124 ns | 0.0055 ns | 0.0052 ns |  0.90 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1583 ns | 0.0052 ns | 0.0048 ns |  0.54 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.6215 ns | 0.0060 ns | 0.0056 ns |  1.23 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.6661 ns | 0.0072 ns | 0.0068 ns |  1.25 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.7973 ns | 0.0168 ns | 0.0149 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.6921 ns | 0.0057 ns | 0.0053 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.8757 ns | 0.0071 ns | 0.0067 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7635 ns | 0.0045 ns | 0.0037 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7957 ns | 0.0083 ns | 0.0074 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.7437 ns | 0.0085 ns | 0.0071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.8961 ns | 0.0073 ns | 0.0065 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.5640 ns | 0.0082 ns | 0.0073 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.9611 ns | 0.0108 ns | 0.0101 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.9709 ns | 0.0042 ns | 0.0037 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.8024 ns | 0.0074 ns | 0.0062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.7184 ns | 0.0090 ns | 0.0085 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.8327 ns | 0.0040 ns | 0.0037 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  2.2117 ns | 0.0041 ns | 0.0035 ns |  1.23 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.8462 ns | 0.0039 ns | 0.0035 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.9763 ns | 0.0258 ns | 0.0241 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  3.1515 ns | 0.0110 ns | 0.0097 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  3.2015 ns | 0.0152 ns | 0.0127 ns |  1.07 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.3340 ns | 0.0224 ns | 0.0209 ns |  1.12 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.1963 ns | 0.0067 ns | 0.0063 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.5225 ns | 0.0287 ns | 0.0254 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.4324 ns | 0.0065 ns | 0.0061 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.4982 ns | 0.0074 ns | 0.0069 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.4413 ns | 0.0099 ns | 0.0093 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.4276 ns | 0.0072 ns | 0.0067 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  3.4987 ns | 0.0281 ns | 0.0249 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  3.7042 ns | 0.0272 ns | 0.0255 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  3.5187 ns | 0.0096 ns | 0.0090 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  3.7036 ns | 0.0285 ns | 0.0266 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  3.7548 ns | 0.0084 ns | 0.0079 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.6799 ns | 0.0274 ns | 0.0257 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.5892 ns | 0.0122 ns | 0.0114 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  2.9043 ns | 0.0108 ns | 0.0095 ns |  1.08 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.2202 ns | 0.0091 ns | 0.0085 ns |  1.20 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  2.5837 ns | 0.0074 ns | 0.0069 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  3.7229 ns | 0.0329 ns | 0.0308 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.0581 ns | 0.0153 ns | 0.0143 ns |  1.09 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  3.7893 ns | 0.0053 ns | 0.0050 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.1127 ns | 0.0071 ns | 0.0063 ns |  1.10 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.1887 ns | 0.0108 ns | 0.0101 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.4233 ns | 0.0306 ns | 0.0286 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.3690 ns | 0.0222 ns | 0.0207 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.8670 ns | 0.0253 ns | 0.0225 ns |  0.44 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  7.4530 ns | 0.0404 ns | 0.0378 ns |  0.56 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  7.3946 ns | 0.0105 ns | 0.0099 ns |  0.55 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.6792 ns | 0.1521 ns | 0.1270 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.5454 ns | 0.0255 ns | 0.0213 ns |  0.99 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.3542 ns | 0.0162 ns | 0.0126 ns |  0.54 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 26.1314 ns | 0.0321 ns | 0.0300 ns |  1.06 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 22.9002 ns | 0.0346 ns | 0.0323 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6994 ns | 0.0067 ns | 0.0062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6936 ns | 0.0045 ns | 0.0040 ns |  0.99 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7292 ns | 0.0034 ns | 0.0030 ns |  1.04 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7060 ns | 0.0063 ns | 0.0059 ns |  1.01 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7007 ns | 0.0129 ns | 0.0121 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.5136 ns | 0.0048 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  2.3033 ns | 0.0066 ns | 0.0062 ns |  1.52 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4739 ns | 0.0053 ns | 0.0050 ns |  0.97 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6875 ns | 0.0034 ns | 0.0031 ns |  1.11 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6888 ns | 0.0044 ns | 0.0039 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 10.1999 ns | 0.0515 ns | 0.0481 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.2737 ns | 0.0279 ns | 0.0218 ns |  1.40 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 15.0520 ns | 0.0430 ns | 0.0402 ns |  1.48 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 12.8603 ns | 0.0714 ns | 0.0668 ns |  1.26 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 | 13.2992 ns | 0.0227 ns | 0.0212 ns |  1.30 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 47.2880 ns | 0.3002 ns | 0.2661 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 41.9382 ns | 0.0834 ns | 0.0780 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 10.4311 ns | 0.0151 ns | 0.0142 ns |  0.22 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 45.1365 ns | 0.1131 ns | 0.1058 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 44.9867 ns | 0.1024 ns | 0.0958 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.7345 ns | 0.0216 ns | 0.0202 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.5746 ns | 0.0030 ns | 0.0028 ns |  0.78 |    0.02 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7208 ns | 0.0045 ns | 0.0042 ns |  0.98 |    0.03 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.5810 ns | 0.0023 ns | 0.0018 ns |  0.80 |    0.02 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.5731 ns | 0.0028 ns | 0.0026 ns |  0.78 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  0.9845 ns | 0.0121 ns | 0.0101 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.0936 ns | 0.0048 ns | 0.0040 ns |  1.11 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1785 ns | 0.0077 ns | 0.0060 ns |  1.20 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9012 ns | 0.0037 ns | 0.0031 ns |  1.93 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.8989 ns | 0.0083 ns | 0.0078 ns |  1.93 |    0.02 |     - |     - |     - |         - |
