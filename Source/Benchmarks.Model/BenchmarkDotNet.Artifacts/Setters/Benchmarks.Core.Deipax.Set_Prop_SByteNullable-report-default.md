
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
             FromBool | .NET Core 2.0 |  0.7387 ns | 0.0093 ns | 0.0087 ns |  0.7413 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6842 ns | 0.0047 ns | 0.0042 ns |  0.6831 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9315 ns | 0.0043 ns | 0.0038 ns |  0.9307 ns |  1.26 |    0.02 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6560 ns | 0.0036 ns | 0.0032 ns |  0.6550 ns |  0.89 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6704 ns | 0.0041 ns | 0.0038 ns |  0.6702 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1664 ns | 0.0044 ns | 0.0039 ns |  1.1656 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.9544 ns | 0.0039 ns | 0.0034 ns |  0.9550 ns |  0.82 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9714 ns | 0.0171 ns | 0.0160 ns |  0.9764 ns |  0.83 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0762 ns | 0.0048 ns | 0.0045 ns |  2.0774 ns |  1.78 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.0834 ns | 0.0053 ns | 0.0044 ns |  2.0823 ns |  1.79 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.3134 ns | 0.0047 ns | 0.0041 ns |  1.3122 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.4131 ns | 0.0034 ns | 0.0030 ns |  1.4133 ns |  1.08 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7014 ns | 0.0053 ns | 0.0042 ns |  0.7008 ns |  0.53 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  1.7501 ns | 0.0054 ns | 0.0042 ns |  1.7500 ns |  1.33 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  1.7638 ns | 0.0035 ns | 0.0033 ns |  1.7644 ns |  1.34 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.9802 ns | 0.0241 ns | 0.0226 ns |  1.9917 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.7978 ns | 0.0041 ns | 0.0038 ns |  1.7975 ns |  0.91 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.5619 ns | 0.0151 ns | 0.0141 ns |  1.5554 ns |  0.79 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.7790 ns | 0.0118 ns | 0.0110 ns |  2.7759 ns |  1.40 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.7860 ns | 0.0142 ns | 0.0133 ns |  2.7849 ns |  1.41 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.5289 ns | 0.0037 ns | 0.0032 ns |  0.5275 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.6836 ns | 0.0024 ns | 0.0021 ns |  0.6839 ns |  1.29 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7053 ns | 0.0043 ns | 0.0038 ns |  0.7048 ns |  1.33 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.5485 ns | 0.0040 ns | 0.0038 ns |  0.5473 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.5522 ns | 0.0033 ns | 0.0028 ns |  0.5522 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.6099 ns | 0.0029 ns | 0.0027 ns |  0.6093 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.5636 ns | 0.0182 ns | 0.0170 ns |  0.5708 ns |  0.92 |    0.03 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.7231 ns | 0.0038 ns | 0.0030 ns |  0.7231 ns |  1.19 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  0.5223 ns | 0.0028 ns | 0.0023 ns |  0.5222 ns |  0.86 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  0.5275 ns | 0.0031 ns | 0.0027 ns |  0.5267 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  1.3253 ns | 0.0146 ns | 0.0137 ns |  1.3301 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  1.3786 ns | 0.0040 ns | 0.0035 ns |  1.3782 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7114 ns | 0.0153 ns | 0.0143 ns |  0.7057 ns |  0.54 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  1.6853 ns | 0.0054 ns | 0.0048 ns |  1.6850 ns |  1.27 |    0.02 |     - |     - |     - |         - |
             FromByte |        net472 |  2.1818 ns | 0.0046 ns | 0.0043 ns |  2.1827 ns |  1.65 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.9934 ns | 0.0033 ns | 0.0031 ns |  1.9931 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.9421 ns | 0.0035 ns | 0.0033 ns |  1.9420 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9549 ns | 0.0039 ns | 0.0035 ns |  0.9549 ns |  0.48 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  3.0449 ns | 0.0246 ns | 0.0219 ns |  3.0522 ns |  1.53 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.9049 ns | 0.0190 ns | 0.0158 ns |  2.9007 ns |  1.46 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.8447 ns | 0.0054 ns | 0.0050 ns |  1.8455 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.8951 ns | 0.0078 ns | 0.0073 ns |  1.8955 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  1.6563 ns | 0.0043 ns | 0.0033 ns |  1.6560 ns |  0.90 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.8068 ns | 0.0052 ns | 0.0049 ns |  1.8066 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  1.8250 ns | 0.0175 ns | 0.0163 ns |  1.8205 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  2.7017 ns | 0.0075 ns | 0.0067 ns |  2.7013 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  2.6222 ns | 0.0056 ns | 0.0050 ns |  2.6229 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  2.3461 ns | 0.0050 ns | 0.0044 ns |  2.3450 ns |  0.87 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.8600 ns | 0.0129 ns | 0.0114 ns |  2.8582 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.9808 ns | 0.0307 ns | 0.0272 ns |  2.9941 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.3370 ns | 0.0085 ns | 0.0080 ns |  1.3381 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.8042 ns | 0.0638 ns | 0.0955 ns |  1.8044 ns |  1.34 |    0.07 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6243 ns | 0.0037 ns | 0.0032 ns |  0.6246 ns |  0.47 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.7918 ns | 0.0185 ns | 0.0173 ns |  1.7840 ns |  1.34 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.7593 ns | 0.0121 ns | 0.0101 ns |  1.7576 ns |  1.32 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.9607 ns | 0.0037 ns | 0.0033 ns |  1.9613 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.8293 ns | 0.0191 ns | 0.0169 ns |  1.8371 ns |  0.93 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.2008 ns | 0.0151 ns | 0.0134 ns |  1.1952 ns |  0.61 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.7867 ns | 0.0079 ns | 0.0074 ns |  2.7850 ns |  1.42 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.7810 ns | 0.0077 ns | 0.0072 ns |  2.7802 ns |  1.42 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.7862 ns | 0.0041 ns | 0.0039 ns |  1.7864 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.8383 ns | 0.0206 ns | 0.0193 ns |  1.8480 ns |  1.03 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.6823 ns | 0.0047 ns | 0.0039 ns |  1.6821 ns |  0.94 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7519 ns | 0.0078 ns | 0.0065 ns |  1.7513 ns |  0.98 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7570 ns | 0.0067 ns | 0.0060 ns |  1.7572 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.5965 ns | 0.0101 ns | 0.0095 ns |  2.5946 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.7364 ns | 0.0071 ns | 0.0059 ns |  2.7357 ns |  1.05 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  2.5672 ns | 0.0073 ns | 0.0068 ns |  2.5655 ns |  0.99 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.9014 ns | 0.0061 ns | 0.0054 ns |  2.9015 ns |  1.12 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.8481 ns | 0.0124 ns | 0.0110 ns |  2.8459 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.8175 ns | 0.0050 ns | 0.0047 ns |  1.8165 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  2.2316 ns | 0.0059 ns | 0.0055 ns |  2.2297 ns |  1.23 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7591 ns | 0.0039 ns | 0.0033 ns |  0.7587 ns |  0.42 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7230 ns | 0.0044 ns | 0.0041 ns |  1.7234 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.7944 ns | 0.0039 ns | 0.0037 ns |  1.7948 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.0178 ns | 0.0040 ns | 0.0038 ns |  2.0188 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.9550 ns | 0.0042 ns | 0.0039 ns |  1.9547 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.6685 ns | 0.0054 ns | 0.0042 ns |  1.6693 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.7541 ns | 0.0112 ns | 0.0099 ns |  2.7515 ns |  1.36 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.7828 ns | 0.0058 ns | 0.0054 ns |  2.7827 ns |  1.38 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.9093 ns | 0.0030 ns | 0.0028 ns |  1.9098 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8253 ns | 0.0186 ns | 0.0174 ns |  1.8165 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.7180 ns | 0.0056 ns | 0.0052 ns |  1.7180 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7742 ns | 0.0130 ns | 0.0122 ns |  1.7749 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7835 ns | 0.0129 ns | 0.0121 ns |  1.7779 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  3.1072 ns | 0.0239 ns | 0.0223 ns |  3.0992 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  3.1101 ns | 0.0094 ns | 0.0088 ns |  3.1090 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.7250 ns | 0.0141 ns | 0.0117 ns |  2.7266 ns |  0.88 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.1898 ns | 0.0081 ns | 0.0072 ns |  3.1894 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.2098 ns | 0.0217 ns | 0.0203 ns |  3.2109 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.4810 ns | 0.0063 ns | 0.0056 ns |  1.4812 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.4326 ns | 0.0168 ns | 0.0157 ns |  1.4401 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7584 ns | 0.0061 ns | 0.0051 ns |  0.7574 ns |  0.51 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7838 ns | 0.0055 ns | 0.0043 ns |  1.7832 ns |  1.20 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  1.8093 ns | 0.0083 ns | 0.0078 ns |  1.8069 ns |  1.22 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.2105 ns | 0.0197 ns | 0.0174 ns |  2.2154 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.3947 ns | 0.0035 ns | 0.0031 ns |  2.3940 ns |  1.08 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.5883 ns | 0.0027 ns | 0.0024 ns |  1.5887 ns |  0.72 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.5958 ns | 0.0243 ns | 0.0216 ns |  3.6031 ns |  1.63 |    0.02 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.0639 ns | 0.0098 ns | 0.0087 ns |  3.0620 ns |  1.39 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  4.2218 ns | 0.0227 ns | 0.0190 ns |  4.2170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.8786 ns | 0.0091 ns | 0.0085 ns |  3.8764 ns |  0.92 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.0930 ns | 0.0315 ns | 0.0295 ns |  4.0959 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.9970 ns | 0.0094 ns | 0.0083 ns |  3.9981 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  4.1706 ns | 0.0138 ns | 0.0129 ns |  4.1696 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  5.5596 ns | 0.0945 ns | 0.0884 ns |  5.5592 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.7491 ns | 0.0331 ns | 0.0310 ns |  4.7594 ns |  0.85 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.4423 ns | 0.0185 ns | 0.0164 ns |  4.4400 ns |  0.80 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.7808 ns | 0.0163 ns | 0.0152 ns |  4.7802 ns |  0.86 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.7937 ns | 0.0105 ns | 0.0093 ns |  4.7945 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  4.2964 ns | 0.0100 ns | 0.0093 ns |  4.2955 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.8417 ns | 0.0073 ns | 0.0065 ns |  3.8430 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  3.7961 ns | 0.0094 ns | 0.0088 ns |  3.7916 ns |  0.88 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.4391 ns | 0.0282 ns | 0.0220 ns |  3.4465 ns |  0.80 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.4262 ns | 0.0304 ns | 0.0254 ns |  3.4211 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  5.2824 ns | 0.0157 ns | 0.0123 ns |  5.2797 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.8874 ns | 0.0144 ns | 0.0134 ns |  4.8872 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  4.8115 ns | 0.0493 ns | 0.0461 ns |  4.7803 ns |  0.91 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  5.7519 ns | 0.0066 ns | 0.0059 ns |  5.7528 ns |  1.09 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  5.8906 ns | 0.0179 ns | 0.0168 ns |  5.8912 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.8981 ns | 0.0369 ns | 0.0308 ns | 13.8883 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 14.2354 ns | 0.1256 ns | 0.1175 ns | 14.2833 ns |  1.02 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  7.0119 ns | 0.1041 ns | 0.0974 ns |  7.0699 ns |  0.50 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.3274 ns | 0.0226 ns | 0.0189 ns | 14.3302 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.3029 ns | 0.0825 ns | 0.0689 ns | 14.2721 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 25.0916 ns | 0.0391 ns | 0.0365 ns | 25.0903 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 25.7445 ns | 0.0298 ns | 0.0264 ns | 25.7342 ns |  1.03 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.8700 ns | 0.0394 ns | 0.0350 ns | 13.8669 ns |  0.55 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 25.6144 ns | 0.1163 ns | 0.0971 ns | 25.6369 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 25.3663 ns | 0.0431 ns | 0.0382 ns | 25.3640 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  1.1565 ns | 0.0484 ns | 0.0557 ns |  1.1551 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6954 ns | 0.0031 ns | 0.0029 ns |  0.6945 ns |  0.60 |    0.03 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7526 ns | 0.0045 ns | 0.0042 ns |  0.7513 ns |  0.65 |    0.04 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7221 ns | 0.0032 ns | 0.0030 ns |  0.7217 ns |  0.62 |    0.03 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7112 ns | 0.0037 ns | 0.0033 ns |  0.7120 ns |  0.62 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.5016 ns | 0.0166 ns | 0.0155 ns |  1.4935 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6762 ns | 0.0259 ns | 0.0242 ns |  1.6839 ns |  1.12 |    0.02 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4668 ns | 0.0057 ns | 0.0053 ns |  1.4671 ns |  0.98 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6806 ns | 0.0052 ns | 0.0044 ns |  1.6799 ns |  1.12 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6968 ns | 0.0249 ns | 0.0233 ns |  1.6853 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.8322 ns | 0.0141 ns | 0.0132 ns |  9.8344 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 13.9924 ns | 0.0314 ns | 0.0278 ns | 13.9967 ns |  1.42 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 14.7699 ns | 0.1129 ns | 0.1056 ns | 14.6979 ns |  1.50 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 13.2103 ns | 0.1248 ns | 0.1167 ns | 13.2701 ns |  1.34 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 | 13.0387 ns | 0.0179 ns | 0.0168 ns | 13.0346 ns |  1.33 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 48.3217 ns | 0.1147 ns | 0.0958 ns | 48.3284 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 42.6591 ns | 0.0802 ns | 0.0711 ns | 42.6654 ns |  0.88 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  8.7751 ns | 0.0273 ns | 0.0228 ns |  8.7701 ns |  0.18 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 47.0047 ns | 0.1039 ns | 0.0921 ns | 46.9768 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 47.0623 ns | 0.1918 ns | 0.1700 ns | 47.0464 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8473 ns | 0.0226 ns | 0.0211 ns |  1.8468 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.8743 ns | 0.0243 ns | 0.0228 ns |  1.8901 ns |  1.01 |    0.02 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.8624 ns | 0.0088 ns | 0.0078 ns |  1.8599 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.8522 ns | 0.0084 ns | 0.0074 ns |  1.8503 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.8287 ns | 0.0031 ns | 0.0029 ns |  1.8293 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.6453 ns | 0.0227 ns | 0.0213 ns |  2.6529 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.5627 ns | 0.0058 ns | 0.0052 ns |  2.5629 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.7965 ns | 0.0070 ns | 0.0066 ns |  2.7971 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.9338 ns | 0.0465 ns | 0.0435 ns |  2.9212 ns |  1.11 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  3.1391 ns | 0.0111 ns | 0.0104 ns |  3.1391 ns |  1.19 |    0.01 |     - |     - |     - |         - |
