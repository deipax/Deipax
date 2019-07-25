
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
             FromBool | .NET Core 2.0 |  0.7111 ns | 0.0024 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6816 ns | 0.0038 ns | 0.0032 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9201 ns | 0.0025 ns | 0.0024 ns |  1.29 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9424 ns | 0.0039 ns | 0.0037 ns |  1.33 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9281 ns | 0.0021 ns | 0.0019 ns |  1.30 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1608 ns | 0.0034 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.9365 ns | 0.0039 ns | 0.0032 ns |  0.81 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.0481 ns | 0.0034 ns | 0.0029 ns |  0.90 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.2036 ns | 0.0051 ns | 0.0048 ns |  1.90 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.1818 ns | 0.0058 ns | 0.0054 ns |  1.88 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.9263 ns | 0.0041 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.4119 ns | 0.0086 ns | 0.0080 ns |  0.73 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.9202 ns | 0.0030 ns | 0.0028 ns |  0.48 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  1.8938 ns | 0.0034 ns | 0.0028 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  1.8584 ns | 0.0043 ns | 0.0038 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.9729 ns | 0.0126 ns | 0.0117 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.7873 ns | 0.0034 ns | 0.0032 ns |  0.91 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1773 ns | 0.0027 ns | 0.0021 ns |  0.60 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.8220 ns | 0.0046 ns | 0.0043 ns |  1.43 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.8295 ns | 0.0067 ns | 0.0063 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6898 ns | 0.0107 ns | 0.0100 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.6757 ns | 0.0021 ns | 0.0018 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7097 ns | 0.0073 ns | 0.0061 ns |  1.03 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.7105 ns | 0.0048 ns | 0.0045 ns |  1.03 |    0.02 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7154 ns | 0.0052 ns | 0.0049 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.8707 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.5812 ns | 0.0022 ns | 0.0019 ns |  0.67 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.7269 ns | 0.0024 ns | 0.0022 ns |  0.83 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  0.7088 ns | 0.0033 ns | 0.0027 ns |  0.81 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  0.7222 ns | 0.0027 ns | 0.0025 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  1.3193 ns | 0.0029 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  1.3675 ns | 0.0033 ns | 0.0029 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.9163 ns | 0.0032 ns | 0.0030 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  1.8809 ns | 0.0035 ns | 0.0029 ns |  1.43 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  2.0595 ns | 0.0028 ns | 0.0024 ns |  1.56 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.8280 ns | 0.0030 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.8704 ns | 0.0061 ns | 0.0057 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9786 ns | 0.0024 ns | 0.0023 ns |  0.54 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  3.2504 ns | 0.0221 ns | 0.0196 ns |  1.78 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.8929 ns | 0.0059 ns | 0.0052 ns |  1.58 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.8683 ns | 0.0128 ns | 0.0100 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.8155 ns | 0.0131 ns | 0.0109 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  1.8713 ns | 0.0152 ns | 0.0143 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  2.1106 ns | 0.0036 ns | 0.0032 ns |  1.13 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  2.1051 ns | 0.0047 ns | 0.0042 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  2.7164 ns | 0.0053 ns | 0.0050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  2.6086 ns | 0.0049 ns | 0.0046 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  2.2219 ns | 0.0039 ns | 0.0034 ns |  0.82 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  3.3501 ns | 0.0069 ns | 0.0064 ns |  1.23 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.8558 ns | 0.0042 ns | 0.0037 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.3257 ns | 0.0055 ns | 0.0048 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.3368 ns | 0.0044 ns | 0.0042 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7143 ns | 0.0071 ns | 0.0063 ns |  0.54 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.8970 ns | 0.0019 ns | 0.0018 ns |  1.43 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.9088 ns | 0.0072 ns | 0.0067 ns |  1.44 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.9624 ns | 0.0037 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.7938 ns | 0.0021 ns | 0.0019 ns |  0.91 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1825 ns | 0.0030 ns | 0.0027 ns |  0.60 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.7992 ns | 0.0080 ns | 0.0071 ns |  1.43 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.7830 ns | 0.0046 ns | 0.0041 ns |  1.42 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.7924 ns | 0.0045 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.8404 ns | 0.0106 ns | 0.0094 ns |  1.03 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.7080 ns | 0.0045 ns | 0.0039 ns |  0.95 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  2.2219 ns | 0.0030 ns | 0.0023 ns |  1.24 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  2.4443 ns | 0.0039 ns | 0.0033 ns |  1.36 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.6035 ns | 0.0051 ns | 0.0048 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  3.0190 ns | 0.0856 ns | 0.1333 ns |  1.16 |    0.05 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  2.3560 ns | 0.0080 ns | 0.0067 ns |  0.91 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.8565 ns | 0.0088 ns | 0.0078 ns |  1.10 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.9066 ns | 0.0065 ns | 0.0058 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.5515 ns | 0.0085 ns | 0.0075 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.3593 ns | 0.0037 ns | 0.0033 ns |  0.88 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9439 ns | 0.0027 ns | 0.0024 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.8239 ns | 0.0052 ns | 0.0046 ns |  1.18 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.8697 ns | 0.0059 ns | 0.0056 ns |  1.21 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.0473 ns | 0.0034 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  2.0916 ns | 0.0034 ns | 0.0032 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1507 ns | 0.0041 ns | 0.0032 ns |  0.56 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.7685 ns | 0.0049 ns | 0.0043 ns |  1.35 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.8722 ns | 0.0074 ns | 0.0069 ns |  1.40 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8616 ns | 0.0038 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.7884 ns | 0.0024 ns | 0.0020 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.8414 ns | 0.0020 ns | 0.0019 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7345 ns | 0.0026 ns | 0.0024 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7668 ns | 0.0042 ns | 0.0033 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  3.0969 ns | 0.0043 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  3.0157 ns | 0.0063 ns | 0.0056 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.9194 ns | 0.0099 ns | 0.0088 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.1051 ns | 0.0038 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.1002 ns | 0.0079 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.4893 ns | 0.0062 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.3948 ns | 0.0046 ns | 0.0038 ns |  0.94 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.8853 ns | 0.0031 ns | 0.0026 ns |  0.59 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.8263 ns | 0.0050 ns | 0.0047 ns |  1.23 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.8988 ns | 0.0028 ns | 0.0023 ns |  1.28 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.3020 ns | 0.0034 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.9782 ns | 0.0073 ns | 0.0061 ns |  0.86 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.5386 ns | 0.0051 ns | 0.0046 ns |  0.67 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.0141 ns | 0.0082 ns | 0.0068 ns |  1.31 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.0502 ns | 0.0186 ns | 0.0165 ns |  1.33 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.7636 ns | 0.0071 ns | 0.0066 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.8194 ns | 0.0070 ns | 0.0058 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.1838 ns | 0.0081 ns | 0.0063 ns |  1.11 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.9814 ns | 0.0068 ns | 0.0057 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.9803 ns | 0.0054 ns | 0.0051 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.9806 ns | 0.0074 ns | 0.0065 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.6559 ns | 0.0085 ns | 0.0075 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.6377 ns | 0.0063 ns | 0.0059 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.6588 ns | 0.0066 ns | 0.0058 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.6894 ns | 0.0071 ns | 0.0056 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.6437 ns | 0.0057 ns | 0.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.7634 ns | 0.0061 ns | 0.0054 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.0318 ns | 0.0081 ns | 0.0075 ns |  1.11 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.3710 ns | 0.0097 ns | 0.0091 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.4012 ns | 0.0057 ns | 0.0051 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.5776 ns | 0.0069 ns | 0.0061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.8063 ns | 0.0092 ns | 0.0082 ns |  1.05 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  4.7135 ns | 0.0142 ns | 0.0126 ns |  1.03 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  5.6530 ns | 0.0123 ns | 0.0109 ns |  1.23 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  5.6493 ns | 0.0092 ns | 0.0081 ns |  1.23 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.9811 ns | 0.0345 ns | 0.0323 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.9927 ns | 0.0314 ns | 0.0279 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  7.0347 ns | 0.0472 ns | 0.0442 ns |  0.50 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.1956 ns | 0.0154 ns | 0.0120 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.3438 ns | 0.0218 ns | 0.0204 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 25.7481 ns | 0.0878 ns | 0.0734 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 25.5042 ns | 0.0173 ns | 0.0154 ns |  0.99 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.8014 ns | 0.0443 ns | 0.0392 ns |  0.54 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 25.7826 ns | 0.0397 ns | 0.0371 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 30.2095 ns | 0.0324 ns | 0.0303 ns |  1.17 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9174 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7020 ns | 0.0090 ns | 0.0084 ns |  0.77 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7389 ns | 0.0039 ns | 0.0035 ns |  0.81 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6755 ns | 0.0036 ns | 0.0033 ns |  0.74 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7331 ns | 0.0061 ns | 0.0054 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  2.5482 ns | 0.0056 ns | 0.0052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6569 ns | 0.0017 ns | 0.0016 ns |  0.65 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4427 ns | 0.0029 ns | 0.0023 ns |  0.57 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6395 ns | 0.0085 ns | 0.0075 ns |  0.64 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6351 ns | 0.0045 ns | 0.0042 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.7772 ns | 0.0181 ns | 0.0169 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 15.1688 ns | 0.0204 ns | 0.0181 ns |  1.55 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 14.6210 ns | 0.1129 ns | 0.1056 ns |  1.50 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 13.1301 ns | 0.0247 ns | 0.0231 ns |  1.34 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.2246 ns | 0.0181 ns | 0.0161 ns |  1.35 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 47.9976 ns | 0.1151 ns | 0.1020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 49.5689 ns | 0.0888 ns | 0.0787 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  8.4937 ns | 0.0181 ns | 0.0169 ns |  0.18 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 46.9062 ns | 0.1542 ns | 0.1442 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 47.4387 ns | 0.2004 ns | 0.1777 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8430 ns | 0.0033 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.7885 ns | 0.0044 ns | 0.0041 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.7106 ns | 0.0199 ns | 0.0186 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7333 ns | 0.0034 ns | 0.0031 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7632 ns | 0.0024 ns | 0.0020 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.6093 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.5741 ns | 0.0190 ns | 0.0177 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.5446 ns | 0.0043 ns | 0.0040 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.8368 ns | 0.0255 ns | 0.0238 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.8422 ns | 0.0056 ns | 0.0050 ns |  1.09 |    0.00 |     - |     - |     - |         - |
