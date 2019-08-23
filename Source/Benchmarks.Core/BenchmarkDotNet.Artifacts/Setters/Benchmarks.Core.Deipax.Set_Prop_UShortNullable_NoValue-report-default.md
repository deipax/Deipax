
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EESCLK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QSSVGP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOYUJY : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-ETYLEW : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-VJGCOH : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.7047 ns | 0.0034 ns | 0.0030 ns |  0.7041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6860 ns | 0.0023 ns | 0.0021 ns |  0.6861 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9282 ns | 0.0029 ns | 0.0025 ns |  0.9284 ns |  1.32 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9466 ns | 0.0024 ns | 0.0023 ns |  0.9468 ns |  1.34 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6615 ns | 0.0028 ns | 0.0025 ns |  0.6615 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  0.9562 ns | 0.0035 ns | 0.0033 ns |  0.9555 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.9010 ns | 0.0024 ns | 0.0022 ns |  0.9017 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9538 ns | 0.0030 ns | 0.0027 ns |  0.9537 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9309 ns | 0.0045 ns | 0.0040 ns |  1.9317 ns |  2.02 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9312 ns | 0.0168 ns | 0.0157 ns |  1.9389 ns |  2.02 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6885 ns | 0.0026 ns | 0.0025 ns |  0.6880 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6227 ns | 0.0036 ns | 0.0034 ns |  0.6225 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5738 ns | 0.0025 ns | 0.0023 ns |  0.5747 ns |  0.83 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7133 ns | 0.0024 ns | 0.0022 ns |  0.7128 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6144 ns | 0.0019 ns | 0.0017 ns |  0.6146 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9806 ns | 0.0025 ns | 0.0022 ns |  0.9807 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.0463 ns | 0.0022 ns | 0.0021 ns |  1.0468 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.5463 ns | 0.0115 ns | 0.0107 ns |  1.5414 ns |  1.58 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9019 ns | 0.0032 ns | 0.0029 ns |  1.9014 ns |  1.94 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.4289 ns | 0.0034 ns | 0.0030 ns |  2.4285 ns |  2.48 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.2887 ns | 0.0027 ns | 0.0026 ns |  1.2887 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.3529 ns | 0.0025 ns | 0.0023 ns |  1.3525 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.9288 ns | 0.0031 ns | 0.0027 ns |  0.9282 ns |  0.72 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7635 ns | 0.0023 ns | 0.0022 ns |  1.7640 ns |  1.37 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.7382 ns | 0.0165 ns | 0.0154 ns |  1.7474 ns |  1.35 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.7360 ns | 0.0047 ns | 0.0044 ns |  1.7356 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.7355 ns | 0.0032 ns | 0.0025 ns |  1.7355 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9593 ns | 0.0111 ns | 0.0104 ns |  0.9555 ns |  0.55 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9283 ns | 0.0045 ns | 0.0040 ns |  1.9275 ns |  1.11 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9006 ns | 0.0028 ns | 0.0026 ns |  1.9005 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7229 ns | 0.0014 ns | 0.0013 ns |  0.7228 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  2.7609 ns | 0.0039 ns | 0.0037 ns |  2.7607 ns |  3.82 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.5854 ns | 0.0106 ns | 0.0099 ns |  0.5902 ns |  0.81 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7132 ns | 0.0030 ns | 0.0025 ns |  0.7135 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5543 ns | 0.0028 ns | 0.0022 ns |  0.5550 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9698 ns | 0.0017 ns | 0.0016 ns |  0.9697 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9027 ns | 0.0033 ns | 0.0027 ns |  0.9020 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9505 ns | 0.0028 ns | 0.0025 ns |  0.9497 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9664 ns | 0.0028 ns | 0.0026 ns |  1.9656 ns |  2.03 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9007 ns | 0.0029 ns | 0.0027 ns |  1.9005 ns |  1.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.3127 ns | 0.0029 ns | 0.0025 ns |  1.3130 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.4490 ns | 0.0024 ns | 0.0019 ns |  1.4483 ns |  1.10 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6407 ns | 0.0022 ns | 0.0020 ns |  0.6409 ns |  0.49 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.7640 ns | 0.0031 ns | 0.0029 ns |  1.7639 ns |  1.34 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  1.7309 ns | 0.0029 ns | 0.0027 ns |  1.7312 ns |  1.32 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.8282 ns | 0.0106 ns | 0.0094 ns |  1.8298 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.7085 ns | 0.0034 ns | 0.0032 ns |  1.7090 ns |  0.93 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.0794 ns | 0.0102 ns | 0.0096 ns |  1.0841 ns |  0.59 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9014 ns | 0.0020 ns | 0.0019 ns |  1.9013 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.8809 ns | 0.0106 ns | 0.0099 ns |  1.8768 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6895 ns | 0.0017 ns | 0.0015 ns |  0.6896 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6245 ns | 0.0026 ns | 0.0023 ns |  0.6247 ns |  0.91 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.5738 ns | 0.0023 ns | 0.0018 ns |  0.5740 ns |  0.83 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.8596 ns | 0.0023 ns | 0.0021 ns |  0.8596 ns |  1.25 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7279 ns | 0.0028 ns | 0.0026 ns |  0.7283 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.6400 ns | 0.0039 ns | 0.0036 ns |  0.6404 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  0.5627 ns | 0.0075 ns | 0.0070 ns |  0.5605 ns |  0.88 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.6204 ns | 0.0121 ns | 0.0113 ns |  0.6272 ns |  0.97 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  0.7231 ns | 0.0026 ns | 0.0022 ns |  0.7233 ns |  1.13 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  0.5304 ns | 0.0017 ns | 0.0016 ns |  0.5304 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.7917 ns | 0.0023 ns | 0.0021 ns |  1.7916 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.8205 ns | 0.0037 ns | 0.0034 ns |  1.8209 ns |  1.02 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.6970 ns | 0.0040 ns | 0.0031 ns |  1.6966 ns |  0.95 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7597 ns | 0.0027 ns | 0.0024 ns |  1.7592 ns |  0.98 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7403 ns | 0.0134 ns | 0.0125 ns |  1.7355 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.8056 ns | 0.0027 ns | 0.0025 ns |  1.8049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.7101 ns | 0.0034 ns | 0.0032 ns |  1.7095 ns |  0.95 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.7221 ns | 0.0035 ns | 0.0033 ns |  1.7217 ns |  0.95 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9365 ns | 0.0028 ns | 0.0025 ns |  1.9365 ns |  1.07 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.8714 ns | 0.0037 ns | 0.0034 ns |  1.8709 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4479 ns | 0.0040 ns | 0.0038 ns |  1.4479 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.4158 ns | 0.0127 ns | 0.0119 ns |  1.4091 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9552 ns | 0.0025 ns | 0.0022 ns |  0.9554 ns |  0.66 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7814 ns | 0.0037 ns | 0.0035 ns |  1.7804 ns |  1.23 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.7833 ns | 0.0022 ns | 0.0017 ns |  1.7834 ns |  1.23 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.9167 ns | 0.0020 ns | 0.0018 ns |  1.9170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.9264 ns | 0.0032 ns | 0.0030 ns |  1.9268 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.4613 ns | 0.0031 ns | 0.0029 ns |  1.4626 ns |  0.76 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9029 ns | 0.0048 ns | 0.0045 ns |  1.9015 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.8983 ns | 0.0035 ns | 0.0031 ns |  1.8975 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8155 ns | 0.0029 ns | 0.0026 ns |  1.8158 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8052 ns | 0.0022 ns | 0.0020 ns |  1.8054 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.9951 ns | 0.0032 ns | 0.0030 ns |  1.9949 ns |  1.10 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.9098 ns | 0.0019 ns | 0.0015 ns |  1.9098 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7610 ns | 0.0028 ns | 0.0025 ns |  1.7617 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.7518 ns | 0.0060 ns | 0.0053 ns |  1.7520 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.8031 ns | 0.0145 ns | 0.0136 ns |  1.7970 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.7627 ns | 0.0022 ns | 0.0020 ns |  1.7627 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.8716 ns | 0.0076 ns | 0.0071 ns |  1.8697 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  1.9336 ns | 0.0029 ns | 0.0027 ns |  1.9327 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.8017 ns | 0.0087 ns | 0.0081 ns |  1.8034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.6998 ns | 0.0020 ns | 0.0019 ns |  1.6993 ns |  0.94 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.6588 ns | 0.0028 ns | 0.0023 ns |  1.6588 ns |  0.92 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7871 ns | 0.0044 ns | 0.0041 ns |  1.7872 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  1.8154 ns | 0.0138 ns | 0.0129 ns |  1.8192 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.7558 ns | 0.0035 ns | 0.0033 ns |  1.7558 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.7200 ns | 0.0029 ns | 0.0026 ns |  1.7205 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7711 ns | 0.0043 ns | 0.0040 ns |  1.7717 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.0244 ns | 0.0155 ns | 0.0145 ns |  2.0303 ns |  1.15 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.8895 ns | 0.0020 ns | 0.0019 ns |  1.8897 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  4.0026 ns | 0.0051 ns | 0.0045 ns |  4.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  4.0547 ns | 0.0063 ns | 0.0059 ns |  4.0547 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.3658 ns | 0.0110 ns | 0.0103 ns |  4.3678 ns |  1.09 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.7890 ns | 0.0044 ns | 0.0039 ns |  3.7888 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.7939 ns | 0.0037 ns | 0.0034 ns |  3.7927 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.8509 ns | 0.0020 ns | 0.0019 ns |  1.8511 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.7613 ns | 0.0037 ns | 0.0033 ns |  1.7604 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.7129 ns | 0.0046 ns | 0.0041 ns |  1.7133 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.9127 ns | 0.0020 ns | 0.0018 ns |  1.9123 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9290 ns | 0.0090 ns | 0.0084 ns |  1.9312 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.9880 ns | 0.0068 ns | 0.0064 ns |  3.9874 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.5586 ns | 0.0153 ns | 0.0128 ns |  3.5568 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.2410 ns | 0.0067 ns | 0.0060 ns |  4.2432 ns |  1.06 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.6413 ns | 0.0070 ns | 0.0062 ns |  3.6415 ns |  0.91 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.8887 ns | 0.0048 ns | 0.0045 ns |  3.8889 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9337 ns | 0.0025 ns | 0.0023 ns |  1.9338 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.8867 ns | 0.0029 ns | 0.0027 ns |  1.8876 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.9109 ns | 0.0023 ns | 0.0022 ns |  1.9117 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.0840 ns | 0.0132 ns | 0.0123 ns |  2.0883 ns |  1.08 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.0943 ns | 0.0034 ns | 0.0031 ns |  2.0935 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.5342 ns | 0.0110 ns | 0.0103 ns | 13.5328 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.6870 ns | 0.0126 ns | 0.0118 ns | 13.6890 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  7.4549 ns | 0.1258 ns | 0.1177 ns |  7.5311 ns |  0.55 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.8730 ns | 0.0273 ns | 0.0255 ns | 13.8851 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.0773 ns | 0.0501 ns | 0.0444 ns | 14.0879 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.9527 ns | 0.0186 ns | 0.0165 ns |  8.9481 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.6529 ns | 0.0113 ns | 0.0105 ns |  8.6555 ns |  0.97 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.5579 ns | 0.0057 ns | 0.0050 ns |  2.5588 ns |  0.29 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  8.4125 ns | 0.0099 ns | 0.0087 ns |  8.4122 ns |  0.94 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  9.0318 ns | 0.0100 ns | 0.0094 ns |  9.0304 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  1.0836 ns | 0.0025 ns | 0.0024 ns |  1.0832 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.9268 ns | 0.0024 ns | 0.0022 ns |  0.9274 ns |  0.86 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7377 ns | 0.0058 ns | 0.0055 ns |  0.7394 ns |  0.68 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7476 ns | 0.0078 ns | 0.0073 ns |  0.7507 ns |  0.69 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7024 ns | 0.0017 ns | 0.0016 ns |  0.7021 ns |  0.65 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4750 ns | 0.0028 ns | 0.0026 ns |  1.4758 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.7716 ns | 0.0121 ns | 0.0113 ns |  1.7678 ns |  1.20 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4376 ns | 0.0028 ns | 0.0023 ns |  1.4380 ns |  0.97 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6190 ns | 0.0034 ns | 0.0032 ns |  1.6192 ns |  1.10 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.7067 ns | 0.0050 ns | 0.0044 ns |  1.7075 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.9914 ns | 0.0085 ns | 0.0079 ns |  2.9931 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8410 ns | 0.0044 ns | 0.0042 ns |  2.8414 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.7301 ns | 0.0074 ns | 0.0065 ns |  2.7302 ns |  0.91 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8517 ns | 0.0189 ns | 0.0176 ns |  2.8458 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8409 ns | 0.0041 ns | 0.0037 ns |  2.8399 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.8046 ns | 0.0033 ns | 0.0030 ns |  1.8051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.8959 ns | 0.0034 ns | 0.0032 ns |  1.8966 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9736 ns | 0.0107 ns | 0.0100 ns |  1.9748 ns |  1.09 |    0.01 |     - |     - |     - |         - |
           FromString |        net461 |  1.8061 ns | 0.0031 ns | 0.0027 ns |  1.8057 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  1.8055 ns | 0.0033 ns | 0.0031 ns |  1.8059 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8154 ns | 0.0015 ns | 0.0014 ns |  1.8156 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.8824 ns | 0.0111 ns | 0.0104 ns |  1.8780 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.7846 ns | 0.0042 ns | 0.0035 ns |  1.7861 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7621 ns | 0.0041 ns | 0.0039 ns |  1.7623 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7839 ns | 0.0181 ns | 0.0169 ns |  1.7911 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.8110 ns | 0.0044 ns | 0.0041 ns |  1.8104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.7378 ns | 0.0025 ns | 0.0023 ns |  1.7379 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.1836 ns | 0.0044 ns | 0.0037 ns |  2.1821 ns |  1.21 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9050 ns | 0.0034 ns | 0.0027 ns |  1.9048 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9032 ns | 0.0022 ns | 0.0019 ns |  1.9030 ns |  1.05 |    0.00 |     - |     - |     - |         - |
