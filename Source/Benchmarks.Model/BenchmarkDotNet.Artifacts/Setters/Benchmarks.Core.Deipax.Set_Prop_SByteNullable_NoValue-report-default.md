
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FAIBOE : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-HDWVEN : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-QWBUFU : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-UUEYQZ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-TUNFLE : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.9202 ns | 0.0052 ns | 0.0048 ns |  0.9189 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9406 ns | 0.0050 ns | 0.0047 ns |  0.9397 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7074 ns | 0.0137 ns | 0.0129 ns |  0.7135 ns |  0.77 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6662 ns | 0.0042 ns | 0.0039 ns |  0.6661 ns |  0.72 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.5415 ns | 0.0031 ns | 0.0028 ns |  0.5406 ns |  0.59 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1619 ns | 0.0074 ns | 0.0062 ns |  1.1601 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1811 ns | 0.0041 ns | 0.0037 ns |  1.1797 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9259 ns | 0.0033 ns | 0.0028 ns |  0.9259 ns |  0.80 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.4785 ns | 0.0540 ns | 0.0505 ns |  2.4974 ns |  2.14 |    0.05 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.1598 ns | 0.0237 ns | 0.0222 ns |  2.1632 ns |  1.86 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.3367 ns | 0.0061 ns | 0.0057 ns |  1.3353 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.3965 ns | 0.0074 ns | 0.0065 ns |  1.3947 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.8825 ns | 0.0033 ns | 0.0029 ns |  0.8824 ns |  0.66 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  1.7560 ns | 0.0066 ns | 0.0055 ns |  1.7550 ns |  1.31 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  1.7607 ns | 0.0157 ns | 0.0146 ns |  1.7540 ns |  1.32 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.8928 ns | 0.0051 ns | 0.0045 ns |  1.8930 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.7577 ns | 0.0061 ns | 0.0054 ns |  1.7556 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.5231 ns | 0.0215 ns | 0.0201 ns |  1.5311 ns |  0.80 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.8985 ns | 0.0039 ns | 0.0034 ns |  1.8980 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.8954 ns | 0.0026 ns | 0.0023 ns |  1.8950 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6949 ns | 0.0052 ns | 0.0044 ns |  0.6948 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.9454 ns | 0.0036 ns | 0.0034 ns |  0.9458 ns |  1.36 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6590 ns | 0.0053 ns | 0.0045 ns |  0.6600 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.5502 ns | 0.0054 ns | 0.0042 ns |  0.5504 ns |  0.79 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.5689 ns | 0.0126 ns | 0.0118 ns |  0.5735 ns |  0.82 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.6936 ns | 0.0040 ns | 0.0038 ns |  0.6927 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.7191 ns | 0.0027 ns | 0.0025 ns |  0.7185 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.8798 ns | 0.0028 ns | 0.0025 ns |  0.8795 ns |  1.27 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  0.5346 ns | 0.0180 ns | 0.0159 ns |  0.5288 ns |  0.77 |    0.02 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  0.5228 ns | 0.0057 ns | 0.0048 ns |  0.5221 ns |  0.75 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  1.3309 ns | 0.0050 ns | 0.0044 ns |  1.3307 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  1.3768 ns | 0.0048 ns | 0.0043 ns |  1.3773 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.9104 ns | 0.0208 ns | 0.0194 ns |  0.9246 ns |  0.69 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  1.7351 ns | 0.0192 ns | 0.0160 ns |  1.7388 ns |  1.30 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  1.6838 ns | 0.0046 ns | 0.0041 ns |  1.6830 ns |  1.27 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.7759 ns | 0.0049 ns | 0.0041 ns |  1.7755 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.8209 ns | 0.0060 ns | 0.0056 ns |  1.8210 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.8939 ns | 0.0027 ns | 0.0023 ns |  0.8937 ns |  0.50 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9297 ns | 0.0073 ns | 0.0061 ns |  1.9275 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.0527 ns | 0.0314 ns | 0.0293 ns |  2.0712 ns |  1.15 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.9303 ns | 0.0060 ns | 0.0053 ns |  1.9296 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  2.1279 ns | 0.0145 ns | 0.0129 ns |  2.1246 ns |  1.10 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  2.0813 ns | 0.0083 ns | 0.0070 ns |  2.0805 ns |  1.08 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.8197 ns | 0.0161 ns | 0.0142 ns |  1.8165 ns |  0.94 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  2.2600 ns | 0.0176 ns | 0.0165 ns |  2.2529 ns |  1.17 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.8478 ns | 0.0051 ns | 0.0043 ns |  1.8470 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.9182 ns | 0.0084 ns | 0.0070 ns |  1.9174 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.7163 ns | 0.0236 ns | 0.0221 ns |  1.7254 ns |  0.93 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9327 ns | 0.0046 ns | 0.0041 ns |  1.9333 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.8983 ns | 0.0066 ns | 0.0059 ns |  1.8956 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.3301 ns | 0.0052 ns | 0.0043 ns |  1.3289 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.3491 ns | 0.0065 ns | 0.0057 ns |  1.3466 ns |  1.01 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6962 ns | 0.0200 ns | 0.0187 ns |  0.6867 ns |  0.52 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.7552 ns | 0.0071 ns | 0.0063 ns |  1.7547 ns |  1.32 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.7493 ns | 0.0051 ns | 0.0045 ns |  1.7482 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.8502 ns | 0.0060 ns | 0.0050 ns |  1.8505 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.7973 ns | 0.0217 ns | 0.0193 ns |  1.8039 ns |  0.97 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1382 ns | 0.0057 ns | 0.0054 ns |  1.1386 ns |  0.62 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9075 ns | 0.0297 ns | 0.0278 ns |  1.8940 ns |  1.03 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9009 ns | 0.0044 ns | 0.0041 ns |  1.9012 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.8967 ns | 0.0037 ns | 0.0033 ns |  1.8964 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.8867 ns | 0.0072 ns | 0.0067 ns |  1.8870 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.8403 ns | 0.0069 ns | 0.0061 ns |  1.8390 ns |  0.97 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7579 ns | 0.0087 ns | 0.0073 ns |  1.7551 ns |  0.93 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7506 ns | 0.0072 ns | 0.0060 ns |  1.7478 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.8504 ns | 0.0056 ns | 0.0050 ns |  1.8505 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.7647 ns | 0.0140 ns | 0.0131 ns |  1.7605 ns |  0.95 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.6948 ns | 0.0058 ns | 0.0054 ns |  1.6942 ns |  0.92 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9114 ns | 0.0272 ns | 0.0255 ns |  1.9102 ns |  1.03 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.4628 ns | 0.0753 ns | 0.0979 ns |  2.4603 ns |  1.31 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4962 ns | 0.0043 ns | 0.0036 ns |  1.4955 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.4100 ns | 0.0035 ns | 0.0032 ns |  1.4098 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7213 ns | 0.0035 ns | 0.0030 ns |  0.7209 ns |  0.48 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7741 ns | 0.0176 ns | 0.0165 ns |  1.7792 ns |  1.19 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.7508 ns | 0.0053 ns | 0.0044 ns |  1.7502 ns |  1.17 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.9742 ns | 0.0146 ns | 0.0129 ns |  1.9768 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.9183 ns | 0.0102 ns | 0.0090 ns |  1.9175 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0596 ns | 0.0033 ns | 0.0030 ns |  1.0596 ns |  0.54 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9263 ns | 0.0058 ns | 0.0048 ns |  1.9272 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.7807 ns | 0.0082 ns | 0.0077 ns |  2.7804 ns |  1.41 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  2.0864 ns | 0.0079 ns | 0.0074 ns |  2.0859 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8563 ns | 0.0050 ns | 0.0047 ns |  1.8551 ns |  0.89 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.6819 ns | 0.0054 ns | 0.0051 ns |  1.6797 ns |  0.81 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7740 ns | 0.0061 ns | 0.0051 ns |  1.7742 ns |  0.85 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7461 ns | 0.0048 ns | 0.0040 ns |  1.7451 ns |  0.84 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.4647 ns | 0.0754 ns | 0.0869 ns |  2.4803 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7676 ns | 0.0051 ns | 0.0045 ns |  1.7686 ns |  0.72 |    0.03 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.8545 ns | 0.0253 ns | 0.0237 ns |  1.8438 ns |  0.75 |    0.03 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.0205 ns | 0.0254 ns | 0.0237 ns |  2.0311 ns |  0.82 |    0.03 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  1.9793 ns | 0.0044 ns | 0.0041 ns |  1.9783 ns |  0.81 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.5256 ns | 0.0045 ns | 0.0038 ns |  1.5256 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.4161 ns | 0.0087 ns | 0.0081 ns |  1.4142 ns |  0.93 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7214 ns | 0.0038 ns | 0.0036 ns |  0.7208 ns |  0.47 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  2.2506 ns | 0.0082 ns | 0.0073 ns |  2.2501 ns |  1.47 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7793 ns | 0.0061 ns | 0.0054 ns |  1.7776 ns |  1.17 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9868 ns | 0.0051 ns | 0.0048 ns |  1.9851 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.2464 ns | 0.0105 ns | 0.0098 ns |  2.2427 ns |  1.13 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.6270 ns | 0.0039 ns | 0.0036 ns |  1.6260 ns |  0.82 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.9127 ns | 0.0048 ns | 0.0043 ns |  1.9121 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.9100 ns | 0.0051 ns | 0.0042 ns |  1.9106 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  4.2945 ns | 0.1111 ns | 0.1140 ns |  4.2925 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.9545 ns | 0.0073 ns | 0.0068 ns |  3.9549 ns |  0.92 |    0.03 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.0568 ns | 0.0476 ns | 0.0445 ns |  4.0389 ns |  0.95 |    0.03 |     - |     - |     - |         - |
            FromFloat |        net461 |  4.8218 ns | 0.0114 ns | 0.0107 ns |  4.8223 ns |  1.13 |    0.03 |     - |     - |     - |         - |
            FromFloat |        net472 |  4.0158 ns | 0.0079 ns | 0.0070 ns |  4.0144 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.9506 ns | 0.0389 ns | 0.0363 ns |  1.9477 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.8259 ns | 0.0143 ns | 0.0127 ns |  1.8282 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.7222 ns | 0.0055 ns | 0.0049 ns |  1.7208 ns |  0.89 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.9558 ns | 0.0050 ns | 0.0044 ns |  1.9572 ns |  1.01 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9054 ns | 0.0060 ns | 0.0057 ns |  1.9053 ns |  0.98 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  4.4185 ns | 0.0639 ns | 0.0567 ns |  4.4030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  4.0188 ns | 0.0232 ns | 0.0205 ns |  4.0127 ns |  0.91 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.2188 ns | 0.0086 ns | 0.0080 ns |  4.2213 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.4254 ns | 0.0157 ns | 0.0131 ns |  3.4196 ns |  0.77 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.3911 ns | 0.0163 ns | 0.0145 ns |  3.3874 ns |  0.77 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9168 ns | 0.0116 ns | 0.0103 ns |  1.9159 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.8777 ns | 0.0087 ns | 0.0077 ns |  1.8758 ns |  0.98 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.9459 ns | 0.0059 ns | 0.0053 ns |  1.9448 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.1606 ns | 0.0267 ns | 0.0250 ns |  2.1729 ns |  1.13 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.2507 ns | 0.0060 ns | 0.0053 ns |  2.2505 ns |  1.17 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.9146 ns | 0.0270 ns | 0.0252 ns | 13.9060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 14.1831 ns | 0.1360 ns | 0.1272 ns | 14.2676 ns |  1.02 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.9554 ns | 0.1170 ns | 0.1094 ns |  7.0394 ns |  0.50 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.3207 ns | 0.0253 ns | 0.0225 ns | 14.3226 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.2983 ns | 0.0248 ns | 0.0232 ns | 14.2995 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.3968 ns | 0.0228 ns | 0.0191 ns |  8.3948 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.5963 ns | 0.0281 ns | 0.0235 ns |  8.5912 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.5170 ns | 0.0122 ns | 0.0108 ns |  2.5169 ns |  0.30 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  9.3985 ns | 0.0684 ns | 0.0640 ns |  9.3663 ns |  1.12 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  9.4337 ns | 0.0223 ns | 0.0209 ns |  9.4308 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9259 ns | 0.0025 ns | 0.0023 ns |  0.9260 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7000 ns | 0.0038 ns | 0.0036 ns |  0.6995 ns |  0.76 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7676 ns | 0.0250 ns | 0.0222 ns |  0.7574 ns |  0.83 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7148 ns | 0.0047 ns | 0.0044 ns |  0.7126 ns |  0.77 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6904 ns | 0.0031 ns | 0.0028 ns |  0.6903 ns |  0.75 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4867 ns | 0.0336 ns | 0.0314 ns |  1.4702 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6812 ns | 0.0133 ns | 0.0125 ns |  1.6840 ns |  1.13 |    0.03 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4961 ns | 0.0066 ns | 0.0061 ns |  1.4956 ns |  1.01 |    0.02 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6753 ns | 0.0109 ns | 0.0097 ns |  1.6747 ns |  1.13 |    0.02 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6713 ns | 0.0089 ns | 0.0074 ns |  1.6703 ns |  1.12 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.0569 ns | 0.0185 ns | 0.0173 ns |  3.0565 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8607 ns | 0.0106 ns | 0.0083 ns |  2.8596 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.7563 ns | 0.0083 ns | 0.0069 ns |  2.7568 ns |  0.90 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.9309 ns | 0.0285 ns | 0.0267 ns |  2.9409 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8510 ns | 0.0145 ns | 0.0136 ns |  2.8446 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.8475 ns | 0.0149 ns | 0.0139 ns |  1.8423 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.8995 ns | 0.0085 ns | 0.0075 ns |  1.8969 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9255 ns | 0.0052 ns | 0.0041 ns |  1.9255 ns |  1.04 |    0.01 |     - |     - |     - |         - |
           FromString |        net461 |  1.8629 ns | 0.0093 ns | 0.0082 ns |  1.8635 ns |  1.01 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 |  1.8340 ns | 0.0048 ns | 0.0045 ns |  1.8342 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8798 ns | 0.0089 ns | 0.0083 ns |  1.8803 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  2.1019 ns | 0.0133 ns | 0.0118 ns |  2.0993 ns |  1.12 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.6820 ns | 0.0038 ns | 0.0035 ns |  1.6816 ns |  0.89 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7807 ns | 0.0059 ns | 0.0050 ns |  1.7796 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.8059 ns | 0.0160 ns | 0.0150 ns |  1.8082 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.8501 ns | 0.0082 ns | 0.0073 ns |  1.8503 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.7508 ns | 0.0043 ns | 0.0040 ns |  1.7509 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.6887 ns | 0.0039 ns | 0.0037 ns |  1.6886 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9224 ns | 0.0045 ns | 0.0038 ns |  1.9224 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9018 ns | 0.0105 ns | 0.0093 ns |  1.8998 ns |  1.03 |    0.01 |     - |     - |     - |         - |
