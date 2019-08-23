
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-UEIOLC : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-AUDEBQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-DSDLWP : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-CMETFP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-MAJXYB : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.7099 ns | 0.0028 ns | 0.0025 ns |  0.7104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6589 ns | 0.0029 ns | 0.0028 ns |  0.6597 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.8938 ns | 0.0029 ns | 0.0024 ns |  0.8940 ns |  1.26 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6562 ns | 0.0020 ns | 0.0018 ns |  0.6561 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6553 ns | 0.0020 ns | 0.0019 ns |  0.6553 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  0.9667 ns | 0.0083 ns | 0.0077 ns |  0.9697 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.9081 ns | 0.0024 ns | 0.0020 ns |  0.9086 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1446 ns | 0.0046 ns | 0.0043 ns |  1.1451 ns |  1.18 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9035 ns | 0.0059 ns | 0.0052 ns |  1.9044 ns |  1.97 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9038 ns | 0.0020 ns | 0.0018 ns |  1.9040 ns |  1.97 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.2885 ns | 0.0039 ns | 0.0037 ns |  1.2896 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.3571 ns | 0.0030 ns | 0.0025 ns |  1.3570 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7030 ns | 0.0076 ns | 0.0072 ns |  0.7056 ns |  0.55 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  1.7614 ns | 0.0292 ns | 0.0273 ns |  1.7478 ns |  1.37 |    0.02 |     - |     - |     - |         - |
             FromChar |        net472 |  1.7361 ns | 0.0063 ns | 0.0058 ns |  1.7369 ns |  1.35 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.8180 ns | 0.0158 ns | 0.0148 ns |  1.8096 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.7136 ns | 0.0030 ns | 0.0028 ns |  1.7138 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1254 ns | 0.0027 ns | 0.0025 ns |  1.1262 ns |  0.62 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.8772 ns | 0.0049 ns | 0.0044 ns |  1.8760 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.0286 ns | 0.0043 ns | 0.0038 ns |  2.0290 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.2895 ns | 0.0032 ns | 0.0030 ns |  1.2892 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.3502 ns | 0.0027 ns | 0.0023 ns |  1.3499 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.8763 ns | 0.0037 ns | 0.0035 ns |  0.8758 ns |  0.68 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7592 ns | 0.0214 ns | 0.0200 ns |  1.7656 ns |  1.36 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.7319 ns | 0.0016 ns | 0.0014 ns |  1.7316 ns |  1.34 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.7744 ns | 0.0045 ns | 0.0038 ns |  1.7733 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.7362 ns | 0.0078 ns | 0.0065 ns |  1.7362 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9705 ns | 0.0113 ns | 0.0094 ns |  0.9723 ns |  0.55 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9092 ns | 0.0047 ns | 0.0042 ns |  1.9086 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.3481 ns | 0.0737 ns | 0.1602 ns |  2.3674 ns |  1.31 |    0.12 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7107 ns | 0.0024 ns | 0.0021 ns |  0.7103 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.5410 ns | 0.0016 ns | 0.0015 ns |  0.5410 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6858 ns | 0.0029 ns | 0.0027 ns |  0.6855 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5536 ns | 0.0101 ns | 0.0095 ns |  0.5506 ns |  0.78 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5420 ns | 0.0030 ns | 0.0025 ns |  0.5424 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.6084 ns | 0.0019 ns | 0.0016 ns |  0.6084 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.5508 ns | 0.0055 ns | 0.0051 ns |  0.5495 ns |  0.91 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9352 ns | 0.0060 ns | 0.0056 ns |  0.9356 ns |  1.54 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  0.5575 ns | 0.0032 ns | 0.0030 ns |  0.5586 ns |  0.92 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  0.5489 ns | 0.0071 ns | 0.0066 ns |  0.5515 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.8221 ns | 0.0019 ns | 0.0016 ns |  1.8220 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.8419 ns | 0.0101 ns | 0.0084 ns |  1.8447 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  1.9439 ns | 0.0041 ns | 0.0038 ns |  1.9428 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.7958 ns | 0.0041 ns | 0.0039 ns |  1.7962 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  1.7950 ns | 0.0018 ns | 0.0016 ns |  1.7953 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.8092 ns | 0.0052 ns | 0.0047 ns |  1.8091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.7245 ns | 0.0169 ns | 0.0158 ns |  1.7141 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.7146 ns | 0.0030 ns | 0.0026 ns |  1.7144 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.8770 ns | 0.0036 ns | 0.0032 ns |  1.8769 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9045 ns | 0.0142 ns | 0.0133 ns |  1.9108 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.2887 ns | 0.0020 ns | 0.0016 ns |  1.2890 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.3583 ns | 0.0033 ns | 0.0031 ns |  1.3587 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.8572 ns | 0.0036 ns | 0.0030 ns |  0.8570 ns |  0.67 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.7483 ns | 0.0136 ns | 0.0127 ns |  1.7455 ns |  1.35 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  2.3675 ns | 0.0045 ns | 0.0042 ns |  2.3683 ns |  1.84 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.8052 ns | 0.0048 ns | 0.0045 ns |  1.8054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.7132 ns | 0.0027 ns | 0.0023 ns |  1.7131 ns |  0.95 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1642 ns | 0.0041 ns | 0.0038 ns |  1.1642 ns |  0.64 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.8764 ns | 0.0057 ns | 0.0053 ns |  1.8776 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.8783 ns | 0.0036 ns | 0.0032 ns |  1.8789 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.7599 ns | 0.0039 ns | 0.0035 ns |  1.7599 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.7803 ns | 0.0062 ns | 0.0049 ns |  1.7801 ns |  1.01 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.6980 ns | 0.0050 ns | 0.0045 ns |  1.6975 ns |  0.96 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7074 ns | 0.0035 ns | 0.0031 ns |  1.7070 ns |  0.97 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.9230 ns | 0.0132 ns | 0.0124 ns |  1.9270 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.8059 ns | 0.0039 ns | 0.0031 ns |  1.8066 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.7101 ns | 0.0042 ns | 0.0039 ns |  1.7104 ns |  0.95 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.7011 ns | 0.0036 ns | 0.0030 ns |  1.7005 ns |  0.94 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.1324 ns | 0.0213 ns | 0.0199 ns |  2.1422 ns |  1.18 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.8780 ns | 0.0042 ns | 0.0037 ns |  1.8781 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4429 ns | 0.0022 ns | 0.0019 ns |  1.4430 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.4107 ns | 0.0026 ns | 0.0024 ns |  1.4107 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9114 ns | 0.0097 ns | 0.0090 ns |  0.9092 ns |  0.63 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7399 ns | 0.0057 ns | 0.0053 ns |  1.7384 ns |  1.21 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.7679 ns | 0.0046 ns | 0.0041 ns |  1.7673 ns |  1.23 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.9620 ns | 0.0053 ns | 0.0049 ns |  1.9619 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.9046 ns | 0.0041 ns | 0.0032 ns |  1.9046 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1189 ns | 0.0048 ns | 0.0043 ns |  1.1175 ns |  0.57 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.8901 ns | 0.0079 ns | 0.0070 ns |  1.8886 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9069 ns | 0.0043 ns | 0.0040 ns |  1.9075 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8886 ns | 0.0031 ns | 0.0024 ns |  1.8889 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8093 ns | 0.0032 ns | 0.0029 ns |  1.8085 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.6741 ns | 0.0031 ns | 0.0027 ns |  1.6736 ns |  0.89 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7129 ns | 0.0100 ns | 0.0089 ns |  1.7092 ns |  0.91 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7329 ns | 0.0034 ns | 0.0032 ns |  1.7330 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.7590 ns | 0.0048 ns | 0.0042 ns |  1.7600 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7580 ns | 0.0066 ns | 0.0059 ns |  1.7588 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.7813 ns | 0.0106 ns | 0.0094 ns |  1.7777 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.0301 ns | 0.0064 ns | 0.0059 ns |  2.0286 ns |  1.15 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.5738 ns | 0.0184 ns | 0.0172 ns |  2.5655 ns |  1.46 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.8825 ns | 0.0071 ns | 0.0063 ns |  1.8803 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.7189 ns | 0.0026 ns | 0.0023 ns |  1.7185 ns |  0.91 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  2.0996 ns | 0.0022 ns | 0.0020 ns |  2.0993 ns |  1.12 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7416 ns | 0.0038 ns | 0.0032 ns |  1.7421 ns |  0.93 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7640 ns | 0.0033 ns | 0.0029 ns |  1.7641 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.7631 ns | 0.0248 ns | 0.0220 ns |  1.7535 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.7177 ns | 0.0029 ns | 0.0027 ns |  1.7169 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.8011 ns | 0.0042 ns | 0.0035 ns |  1.8021 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.9176 ns | 0.0032 ns | 0.0028 ns |  1.9171 ns |  1.09 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.9155 ns | 0.0027 ns | 0.0025 ns |  1.9157 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.7959 ns | 0.0098 ns | 0.0087 ns |  3.7933 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  4.0064 ns | 0.0053 ns | 0.0049 ns |  4.0061 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.4487 ns | 0.0088 ns | 0.0078 ns |  4.4484 ns |  1.17 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.8884 ns | 0.0082 ns | 0.0077 ns |  3.8886 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  4.0274 ns | 0.0081 ns | 0.0063 ns |  4.0270 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.8557 ns | 0.0076 ns | 0.0064 ns |  1.8553 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.8007 ns | 0.0127 ns | 0.0113 ns |  1.8034 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.7219 ns | 0.0030 ns | 0.0026 ns |  1.7212 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.8999 ns | 0.0186 ns | 0.0174 ns |  1.9085 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9135 ns | 0.0030 ns | 0.0028 ns |  1.9136 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.7686 ns | 0.0089 ns | 0.0078 ns |  3.7662 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.9050 ns | 0.0050 ns | 0.0047 ns |  3.9059 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  3.7389 ns | 0.0069 ns | 0.0054 ns |  3.7398 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.3365 ns | 0.0060 ns | 0.0054 ns |  3.3368 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.3669 ns | 0.0046 ns | 0.0041 ns |  3.3679 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9264 ns | 0.0027 ns | 0.0024 ns |  1.9263 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.8995 ns | 0.0048 ns | 0.0043 ns |  1.8977 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.9501 ns | 0.0099 ns | 0.0093 ns |  1.9523 ns |  1.01 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.1689 ns | 0.0201 ns | 0.0188 ns |  2.1593 ns |  1.13 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.1109 ns | 0.0153 ns | 0.0143 ns |  2.1029 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.5833 ns | 0.0124 ns | 0.0116 ns | 13.5837 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.8066 ns | 0.0252 ns | 0.0210 ns | 13.8095 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.8170 ns | 0.1547 ns | 0.1781 ns |  6.7162 ns |  0.50 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.9308 ns | 0.0243 ns | 0.0228 ns | 13.9295 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.9587 ns | 0.0187 ns | 0.0175 ns | 13.9549 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.1820 ns | 0.0139 ns | 0.0123 ns |  8.1822 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.9235 ns | 0.0177 ns | 0.0165 ns |  8.9268 ns |  1.09 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.5263 ns | 0.0078 ns | 0.0061 ns |  2.5292 ns |  0.31 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  9.1419 ns | 0.0165 ns | 0.0138 ns |  9.1375 ns |  1.12 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  9.0018 ns | 0.0140 ns | 0.0124 ns |  9.0049 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6887 ns | 0.0034 ns | 0.0032 ns |  0.6881 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7089 ns | 0.0021 ns | 0.0019 ns |  0.7092 ns |  1.03 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.6831 ns | 0.0015 ns | 0.0014 ns |  0.6835 ns |  0.99 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6779 ns | 0.0022 ns | 0.0019 ns |  0.6777 ns |  0.98 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.9208 ns | 0.0028 ns | 0.0023 ns |  0.9203 ns |  1.34 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.6698 ns | 0.0037 ns | 0.0033 ns |  1.6708 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6847 ns | 0.0109 ns | 0.0102 ns |  1.6875 ns |  1.01 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4810 ns | 0.0135 ns | 0.0120 ns |  1.4766 ns |  0.89 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  2.6380 ns | 0.0037 ns | 0.0033 ns |  2.6382 ns |  1.58 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6616 ns | 0.0054 ns | 0.0050 ns |  1.6626 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.9927 ns | 0.0097 ns | 0.0081 ns |  2.9905 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8696 ns | 0.0157 ns | 0.0139 ns |  2.8711 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.9153 ns | 0.0106 ns | 0.0094 ns |  2.9172 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8330 ns | 0.0147 ns | 0.0130 ns |  2.8311 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8618 ns | 0.0159 ns | 0.0149 ns |  2.8547 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.7906 ns | 0.0024 ns | 0.0022 ns |  1.7904 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.8883 ns | 0.0044 ns | 0.0035 ns |  1.8893 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9109 ns | 0.0059 ns | 0.0052 ns |  1.9099 ns |  1.07 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.7884 ns | 0.0024 ns | 0.0020 ns |  1.7886 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  1.8078 ns | 0.0030 ns | 0.0027 ns |  1.8086 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8119 ns | 0.0037 ns | 0.0035 ns |  1.8121 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.8819 ns | 0.0053 ns | 0.0050 ns |  1.8807 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.8360 ns | 0.0042 ns | 0.0038 ns |  1.8356 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7102 ns | 0.0041 ns | 0.0035 ns |  1.7106 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7344 ns | 0.0033 ns | 0.0027 ns |  1.7347 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.8051 ns | 0.0047 ns | 0.0039 ns |  1.8045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.7774 ns | 0.0100 ns | 0.0089 ns |  1.7782 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.6853 ns | 0.0156 ns | 0.0146 ns |  1.6786 ns |  0.93 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.8911 ns | 0.0169 ns | 0.0158 ns |  1.8986 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9016 ns | 0.0037 ns | 0.0035 ns |  1.9028 ns |  1.05 |    0.00 |     - |     - |     - |         - |
