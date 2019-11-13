
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
             FromBool | .NET Core 2.0 |  0.5493 ns | 0.0122 ns | 0.0114 ns |  0.5530 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6441 ns | 0.0060 ns | 0.0050 ns |  0.6418 ns |  1.17 |    0.03 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.5885 ns | 0.0110 ns | 0.0098 ns |  0.5914 ns |  1.07 |    0.02 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6308 ns | 0.0057 ns | 0.0051 ns |  0.6286 ns |  1.15 |    0.02 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6231 ns | 0.0040 ns | 0.0035 ns |  0.6240 ns |  1.14 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  0.5809 ns | 0.0030 ns | 0.0028 ns |  0.5806 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.5800 ns | 0.0030 ns | 0.0028 ns |  0.5801 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.5643 ns | 0.0041 ns | 0.0039 ns |  0.5632 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  0.5678 ns | 0.0035 ns | 0.0031 ns |  0.5676 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  0.5601 ns | 0.0069 ns | 0.0061 ns |  0.5590 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9566 ns | 0.0174 ns | 0.0163 ns |  0.9484 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6410 ns | 0.0043 ns | 0.0036 ns |  0.6406 ns |  0.67 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7794 ns | 0.0047 ns | 0.0042 ns |  0.7815 ns |  0.81 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6319 ns | 0.0029 ns | 0.0027 ns |  0.6316 ns |  0.66 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6271 ns | 0.0032 ns | 0.0027 ns |  0.6277 ns |  0.66 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.5695 ns | 0.0137 ns | 0.0128 ns |  0.5631 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9083 ns | 0.0071 ns | 0.0059 ns |  0.9063 ns |  1.60 |    0.04 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.7942 ns | 0.0085 ns | 0.0071 ns |  0.7964 ns |  1.40 |    0.03 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.9152 ns | 0.0123 ns | 0.0115 ns |  0.9182 ns |  1.61 |    0.05 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.8885 ns | 0.0056 ns | 0.0052 ns |  0.8869 ns |  1.56 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.5434 ns | 0.0013 ns | 0.0011 ns |  0.5434 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.5879 ns | 0.0050 ns | 0.0042 ns |  0.5876 ns |  1.08 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.5783 ns | 0.0040 ns | 0.0037 ns |  0.5783 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.5694 ns | 0.0137 ns | 0.0128 ns |  0.5751 ns |  1.05 |    0.02 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.5693 ns | 0.0052 ns | 0.0046 ns |  0.5682 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.9850 ns | 0.0142 ns | 0.0133 ns |  0.9805 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9211 ns | 0.0163 ns | 0.0152 ns |  0.9152 ns |  0.94 |    0.02 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9272 ns | 0.0040 ns | 0.0033 ns |  0.9280 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.1256 ns | 0.0046 ns | 0.0038 ns |  2.1251 ns |  2.16 |    0.03 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9333 ns | 0.0075 ns | 0.0067 ns |  1.9319 ns |  1.97 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7301 ns | 0.0074 ns | 0.0066 ns |  0.7282 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.5872 ns | 0.0042 ns | 0.0040 ns |  0.5885 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6112 ns | 0.0204 ns | 0.0190 ns |  0.6184 ns |  0.84 |    0.03 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5686 ns | 0.0034 ns | 0.0032 ns |  0.5678 ns |  0.78 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5662 ns | 0.0050 ns | 0.0047 ns |  0.5664 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9776 ns | 0.0053 ns | 0.0044 ns |  0.9780 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9322 ns | 0.0168 ns | 0.0157 ns |  0.9406 ns |  0.95 |    0.02 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9011 ns | 0.0045 ns | 0.0042 ns |  0.9008 ns |  0.92 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9698 ns | 0.0152 ns | 0.0142 ns |  1.9726 ns |  2.01 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9239 ns | 0.0058 ns | 0.0045 ns |  1.9227 ns |  1.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.5771 ns | 0.0048 ns | 0.0045 ns |  0.5770 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.6781 ns | 0.0035 ns | 0.0031 ns |  0.6778 ns |  1.18 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7279 ns | 0.0042 ns | 0.0037 ns |  0.7276 ns |  1.26 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  0.6697 ns | 0.0043 ns | 0.0036 ns |  0.6689 ns |  1.16 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.6770 ns | 0.0027 ns | 0.0024 ns |  0.6773 ns |  1.17 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  0.9686 ns | 0.0054 ns | 0.0048 ns |  0.9673 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.0987 ns | 0.0040 ns | 0.0038 ns |  1.0987 ns |  1.13 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.0745 ns | 0.0112 ns | 0.0094 ns |  1.0770 ns |  1.11 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9098 ns | 0.0056 ns | 0.0052 ns |  1.9080 ns |  1.97 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9082 ns | 0.0045 ns | 0.0037 ns |  1.9077 ns |  1.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.7051 ns | 0.0036 ns | 0.0034 ns |  0.7048 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.7022 ns | 0.0117 ns | 0.0110 ns |  0.7069 ns |  1.00 |    0.02 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7038 ns | 0.0041 ns | 0.0036 ns |  0.7040 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6462 ns | 0.0159 ns | 0.0149 ns |  0.6542 ns |  0.92 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6638 ns | 0.0052 ns | 0.0043 ns |  0.6633 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9693 ns | 0.0055 ns | 0.0049 ns |  0.9693 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.0729 ns | 0.0034 ns | 0.0029 ns |  1.0726 ns |  1.11 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.0718 ns | 0.0037 ns | 0.0031 ns |  1.0718 ns |  1.11 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.5975 ns | 0.0781 ns | 0.0730 ns |  2.6033 ns |  2.69 |    0.06 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9083 ns | 0.0059 ns | 0.0056 ns |  1.9082 ns |  1.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.5551 ns | 0.0154 ns | 0.0144 ns |  0.5595 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.6949 ns | 0.0031 ns | 0.0027 ns |  0.6951 ns |  1.25 |    0.03 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7429 ns | 0.0024 ns | 0.0023 ns |  0.7431 ns |  1.34 |    0.03 |     - |     - |     - |         - |
              FromInt |        net461 |  0.5870 ns | 0.0042 ns | 0.0037 ns |  0.5862 ns |  1.06 |    0.02 |     - |     - |     - |         - |
              FromInt |        net472 |  0.5918 ns | 0.0038 ns | 0.0036 ns |  0.5920 ns |  1.07 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  0.9717 ns | 0.0028 ns | 0.0027 ns |  0.9715 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.0726 ns | 0.0035 ns | 0.0032 ns |  1.0723 ns |  1.10 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1208 ns | 0.0020 ns | 0.0018 ns |  1.1212 ns |  1.15 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9379 ns | 0.0192 ns | 0.0179 ns |  1.9458 ns |  1.99 |    0.02 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9225 ns | 0.0221 ns | 0.0207 ns |  1.9119 ns |  1.98 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.7265 ns | 0.0022 ns | 0.0018 ns |  0.7261 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.5888 ns | 0.0138 ns | 0.0129 ns |  0.5826 ns |  0.81 |    0.02 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6921 ns | 0.0042 ns | 0.0038 ns |  0.6916 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.5862 ns | 0.0073 ns | 0.0064 ns |  0.5844 ns |  0.81 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7309 ns | 0.0043 ns | 0.0040 ns |  0.7302 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  0.9816 ns | 0.0162 ns | 0.0151 ns |  0.9899 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.0784 ns | 0.0051 ns | 0.0040 ns |  1.0776 ns |  1.09 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1776 ns | 0.0034 ns | 0.0032 ns |  1.1775 ns |  1.20 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9097 ns | 0.0062 ns | 0.0052 ns |  1.9076 ns |  1.94 |    0.03 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9731 ns | 0.0035 ns | 0.0029 ns |  1.9737 ns |  2.01 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.6267 ns | 0.0034 ns | 0.0030 ns |  0.6262 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.7024 ns | 0.0049 ns | 0.0046 ns |  0.7026 ns |  1.12 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.7246 ns | 0.0040 ns | 0.0033 ns |  0.7239 ns |  1.16 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  0.6855 ns | 0.0025 ns | 0.0024 ns |  0.6860 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  0.7060 ns | 0.0020 ns | 0.0018 ns |  0.7058 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.7494 ns | 0.0031 ns | 0.0026 ns |  1.7501 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.5579 ns | 0.0190 ns | 0.0178 ns |  1.5493 ns |  0.89 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.5148 ns | 0.0063 ns | 0.0056 ns |  1.5127 ns |  0.87 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.0609 ns | 0.0244 ns | 0.0228 ns |  2.0493 ns |  1.18 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.0409 ns | 0.0043 ns | 0.0038 ns |  2.0415 ns |  1.17 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.7097 ns | 0.0084 ns | 0.0074 ns |  0.7110 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.6949 ns | 0.0049 ns | 0.0043 ns |  0.6952 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7249 ns | 0.0033 ns | 0.0029 ns |  0.7248 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  0.6918 ns | 0.0030 ns | 0.0025 ns |  0.6915 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  0.5674 ns | 0.0099 ns | 0.0088 ns |  0.5707 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.5446 ns | 0.0159 ns | 0.0149 ns |  1.5383 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.5702 ns | 0.0030 ns | 0.0028 ns |  1.5706 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.5999 ns | 0.0054 ns | 0.0042 ns |  1.5993 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.9104 ns | 0.0040 ns | 0.0037 ns |  1.9098 ns |  1.24 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.9068 ns | 0.0056 ns | 0.0050 ns |  1.9071 ns |  1.24 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.7833 ns | 0.0031 ns | 0.0029 ns |  0.7843 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.9730 ns | 0.0072 ns | 0.0067 ns |  0.9722 ns |  1.24 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.9931 ns | 0.0038 ns | 0.0035 ns |  0.9926 ns |  1.27 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.9860 ns | 0.0206 ns | 0.0182 ns |  0.9777 ns |  1.26 |    0.03 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.9994 ns | 0.0071 ns | 0.0063 ns |  0.9977 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.0046 ns | 0.0117 ns | 0.0104 ns |  1.0011 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.1171 ns | 0.0022 ns | 0.0019 ns |  1.1168 ns |  1.11 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.1352 ns | 0.0030 ns | 0.0025 ns |  1.1349 ns |  1.13 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.9975 ns | 0.0038 ns | 0.0033 ns |  1.9973 ns |  1.99 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9737 ns | 0.0250 ns | 0.0233 ns |  1.9837 ns |  1.97 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.7833 ns | 0.0027 ns | 0.0024 ns |  0.7833 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.9273 ns | 0.0038 ns | 0.0034 ns |  0.9272 ns |  1.18 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.9341 ns | 0.0147 ns | 0.0130 ns |  0.9287 ns |  1.19 |    0.02 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.9297 ns | 0.0029 ns | 0.0027 ns |  0.9293 ns |  1.19 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.9597 ns | 0.0065 ns | 0.0058 ns |  0.9583 ns |  1.23 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.8636 ns | 0.0041 ns | 0.0036 ns |  1.8634 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.6868 ns | 0.0140 ns | 0.0117 ns |  1.6830 ns |  0.91 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.7116 ns | 0.0053 ns | 0.0047 ns |  1.7110 ns |  0.92 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.1689 ns | 0.0173 ns | 0.0153 ns |  2.1726 ns |  1.16 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.5499 ns | 0.0629 ns | 0.0557 ns |  2.5545 ns |  1.37 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  7.3780 ns | 0.0368 ns | 0.0344 ns |  7.3832 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  7.5501 ns | 0.0146 ns | 0.0136 ns |  7.5499 ns |  1.02 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  4.7442 ns | 0.0126 ns | 0.0118 ns |  4.7443 ns |  0.64 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  9.2579 ns | 0.0130 ns | 0.0109 ns |  9.2599 ns |  1.25 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 |  8.0821 ns | 0.0126 ns | 0.0118 ns |  8.0821 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.4993 ns | 0.0177 ns | 0.0166 ns |  8.5033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.4685 ns | 0.0207 ns | 0.0193 ns |  8.4691 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.5233 ns | 0.0073 ns | 0.0064 ns |  2.5219 ns |  0.30 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 12.6279 ns | 0.0187 ns | 0.0175 ns | 12.6237 ns |  1.49 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  9.0055 ns | 0.0236 ns | 0.0220 ns |  9.0062 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.5702 ns | 0.0056 ns | 0.0050 ns |  0.5698 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7440 ns | 0.0025 ns | 0.0021 ns |  0.7437 ns |  1.30 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7478 ns | 0.0170 ns | 0.0159 ns |  0.7570 ns |  1.31 |    0.03 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6948 ns | 0.0041 ns | 0.0038 ns |  0.6951 ns |  1.22 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7140 ns | 0.0038 ns | 0.0034 ns |  0.7139 ns |  1.25 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.5043 ns | 0.0215 ns | 0.0201 ns |  1.5137 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4580 ns | 0.0042 ns | 0.0039 ns |  1.4572 ns |  0.97 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4644 ns | 0.0053 ns | 0.0047 ns |  1.4634 ns |  0.97 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  2.3773 ns | 0.0289 ns | 0.0271 ns |  2.3957 ns |  1.58 |    0.02 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  6.8517 ns | 0.0262 ns | 0.0245 ns |  6.8575 ns |  4.56 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.7908 ns | 0.0052 ns | 0.0049 ns |  2.7900 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8309 ns | 0.0125 ns | 0.0111 ns |  2.8332 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.7937 ns | 0.0319 ns | 0.0298 ns |  2.7839 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8297 ns | 0.0065 ns | 0.0061 ns |  2.8305 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8495 ns | 0.0078 ns | 0.0069 ns |  2.8496 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.6697 ns | 0.0052 ns | 0.0046 ns |  1.6689 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.6548 ns | 0.0167 ns | 0.0156 ns |  1.6506 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.7208 ns | 0.0049 ns | 0.0038 ns |  1.7221 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.6721 ns | 0.0043 ns | 0.0040 ns |  1.6721 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  1.6959 ns | 0.0052 ns | 0.0049 ns |  1.6966 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.6258 ns | 0.0031 ns | 0.0027 ns |  0.6251 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.5827 ns | 0.0039 ns | 0.0035 ns |  0.5829 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.9487 ns | 0.0029 ns | 0.0027 ns |  0.9488 ns |  1.52 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.5919 ns | 0.0111 ns | 0.0104 ns |  0.5954 ns |  0.95 |    0.02 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.7303 ns | 0.0058 ns | 0.0054 ns |  0.7302 ns |  1.17 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.1928 ns | 0.0054 ns | 0.0042 ns |  1.1932 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.4113 ns | 0.0044 ns | 0.0041 ns |  1.4110 ns |  1.18 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1761 ns | 0.0096 ns | 0.0080 ns |  1.1758 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9768 ns | 0.0064 ns | 0.0057 ns |  1.9764 ns |  1.66 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9590 ns | 0.0135 ns | 0.0119 ns |  1.9542 ns |  1.64 |    0.01 |     - |     - |     - |         - |
