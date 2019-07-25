
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  7.704 ns | 0.0226 ns | 0.0201 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  7.944 ns | 0.0483 ns | 0.0452 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  7.559 ns | 0.0140 ns | 0.0117 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 |  7.888 ns | 0.0129 ns | 0.0115 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  7.667 ns | 0.0332 ns | 0.0294 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  7.834 ns | 0.0784 ns | 0.0733 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  8.010 ns | 0.0185 ns | 0.0164 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  7.813 ns | 0.0192 ns | 0.0161 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  7.993 ns | 0.0191 ns | 0.0160 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  7.916 ns | 0.0388 ns | 0.0363 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  7.631 ns | 0.0551 ns | 0.0515 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  7.950 ns | 0.0099 ns | 0.0083 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  7.588 ns | 0.0133 ns | 0.0125 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  7.917 ns | 0.0187 ns | 0.0166 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  7.608 ns | 0.0211 ns | 0.0187 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  7.802 ns | 0.0177 ns | 0.0157 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  7.965 ns | 0.0267 ns | 0.0249 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  7.808 ns | 0.0218 ns | 0.0170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  7.890 ns | 0.0129 ns | 0.0114 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  7.891 ns | 0.0314 ns | 0.0294 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  7.896 ns | 0.0401 ns | 0.0375 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  7.697 ns | 0.0173 ns | 0.0154 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  7.339 ns | 0.0165 ns | 0.0147 ns |  0.93 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  7.832 ns | 0.0479 ns | 0.0400 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  7.789 ns | 0.0316 ns | 0.0295 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  7.593 ns | 0.0253 ns | 0.0237 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  8.007 ns | 0.0133 ns | 0.0118 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  7.940 ns | 0.0359 ns | 0.0335 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  7.998 ns | 0.0158 ns | 0.0140 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  8.108 ns | 0.0184 ns | 0.0163 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  7.548 ns | 0.0122 ns | 0.0108 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  7.694 ns | 0.0182 ns | 0.0170 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  7.574 ns | 0.0131 ns | 0.0122 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  7.692 ns | 0.0110 ns | 0.0086 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  7.848 ns | 0.0397 ns | 0.0372 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  7.664 ns | 0.0184 ns | 0.0163 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  8.129 ns | 0.0182 ns | 0.0170 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  7.839 ns | 0.0193 ns | 0.0171 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  8.181 ns | 0.0091 ns | 0.0081 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  7.911 ns | 0.0175 ns | 0.0146 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  7.555 ns | 0.0155 ns | 0.0138 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  8.051 ns | 0.0355 ns | 0.0332 ns |  1.07 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  7.571 ns | 0.0186 ns | 0.0174 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  7.910 ns | 0.0167 ns | 0.0156 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  7.662 ns | 0.0143 ns | 0.0119 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  7.914 ns | 0.0171 ns | 0.0143 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  7.946 ns | 0.0202 ns | 0.0179 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  7.810 ns | 0.0093 ns | 0.0078 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  7.965 ns | 0.0590 ns | 0.0492 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  7.730 ns | 0.0184 ns | 0.0172 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  7.803 ns | 0.0245 ns | 0.0204 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  7.900 ns | 0.0231 ns | 0.0216 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  7.714 ns | 0.0129 ns | 0.0120 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  7.958 ns | 0.0278 ns | 0.0247 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  7.608 ns | 0.0212 ns | 0.0188 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  7.720 ns | 0.0199 ns | 0.0186 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  8.021 ns | 0.0133 ns | 0.0125 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  7.587 ns | 0.0178 ns | 0.0149 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  7.903 ns | 0.0190 ns | 0.0159 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  7.941 ns | 0.0139 ns | 0.0130 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  7.791 ns | 0.0142 ns | 0.0133 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  7.692 ns | 0.0194 ns | 0.0162 ns |  0.99 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  7.600 ns | 0.0166 ns | 0.0139 ns |  0.98 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  7.806 ns | 0.0246 ns | 0.0206 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  7.619 ns | 0.0449 ns | 0.0420 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  7.596 ns | 0.0403 ns | 0.0336 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  8.198 ns | 0.0258 ns | 0.0242 ns |  1.08 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  7.835 ns | 0.0140 ns | 0.0124 ns |  1.03 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  7.893 ns | 0.0203 ns | 0.0189 ns |  1.04 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  7.834 ns | 0.0185 ns | 0.0173 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  7.604 ns | 0.0296 ns | 0.0277 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  7.716 ns | 0.0105 ns | 0.0087 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  7.386 ns | 0.0142 ns | 0.0118 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  7.676 ns | 0.0190 ns | 0.0149 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  7.755 ns | 0.0191 ns | 0.0179 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  7.557 ns | 0.0116 ns | 0.0103 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  8.080 ns | 0.0193 ns | 0.0171 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  7.829 ns | 0.0197 ns | 0.0174 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  8.171 ns | 0.0217 ns | 0.0203 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  7.951 ns | 0.0339 ns | 0.0300 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  7.579 ns | 0.0137 ns | 0.0122 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  7.903 ns | 0.0125 ns | 0.0117 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  7.427 ns | 0.0217 ns | 0.0203 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  7.855 ns | 0.0170 ns | 0.0151 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  7.732 ns | 0.0488 ns | 0.0432 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  8.311 ns | 0.0160 ns | 0.0149 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  8.462 ns | 0.0228 ns | 0.0202 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  8.438 ns | 0.0114 ns | 0.0095 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  8.414 ns | 0.0398 ns | 0.0353 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  8.811 ns | 0.0311 ns | 0.0291 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  7.899 ns | 0.0103 ns | 0.0086 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  7.927 ns | 0.0285 ns | 0.0252 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  7.566 ns | 0.0163 ns | 0.0152 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  7.950 ns | 0.0134 ns | 0.0119 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  7.723 ns | 0.0643 ns | 0.0601 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  8.361 ns | 0.0304 ns | 0.0284 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  8.241 ns | 0.0121 ns | 0.0107 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  8.512 ns | 0.0529 ns | 0.0495 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  8.422 ns | 0.0229 ns | 0.0203 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 12.287 ns | 0.0415 ns | 0.0368 ns |  1.47 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  7.909 ns | 0.0323 ns | 0.0286 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  7.889 ns | 0.0132 ns | 0.0110 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  7.648 ns | 0.0409 ns | 0.0382 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  7.783 ns | 0.0172 ns | 0.0152 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  8.197 ns | 0.0178 ns | 0.0158 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  7.558 ns | 0.0166 ns | 0.0129 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  7.869 ns | 0.0142 ns | 0.0133 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  7.806 ns | 0.0126 ns | 0.0118 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  7.926 ns | 0.0145 ns | 0.0121 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  8.116 ns | 0.0202 ns | 0.0189 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  7.570 ns | 0.0224 ns | 0.0187 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  7.694 ns | 0.0120 ns | 0.0112 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  7.859 ns | 0.0200 ns | 0.0178 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  7.870 ns | 0.0127 ns | 0.0119 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  8.186 ns | 0.0097 ns | 0.0081 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  9.016 ns | 0.0436 ns | 0.0408 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  8.662 ns | 0.0289 ns | 0.0270 ns |  0.96 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  8.937 ns | 0.0120 ns | 0.0112 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  8.354 ns | 0.0092 ns | 0.0082 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  8.215 ns | 0.0189 ns | 0.0158 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  8.930 ns | 0.0230 ns | 0.0204 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  8.307 ns | 0.0177 ns | 0.0166 ns |  0.93 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  8.923 ns | 0.0166 ns | 0.0156 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  8.581 ns | 0.0275 ns | 0.0243 ns |  0.96 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  8.319 ns | 0.0181 ns | 0.0170 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.532 ns | 0.0247 ns | 0.0219 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.577 ns | 0.0296 ns | 0.0263 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  8.377 ns | 0.0080 ns | 0.0071 ns |  0.98 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  9.216 ns | 0.0156 ns | 0.0146 ns |  1.08 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  8.930 ns | 0.0313 ns | 0.0277 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  4.820 ns | 0.0288 ns | 0.0270 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  4.244 ns | 0.0081 ns | 0.0072 ns |  0.88 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  4.473 ns | 0.1108 ns | 0.1138 ns |  0.93 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net461 |  4.991 ns | 0.0366 ns | 0.0343 ns |  1.04 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  4.951 ns | 0.0099 ns | 0.0092 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.462 ns | 0.0054 ns | 0.0051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.176 ns | 0.0080 ns | 0.0067 ns |  0.80 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.383 ns | 0.0064 ns | 0.0057 ns |  0.95 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.440 ns | 0.0057 ns | 0.0053 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.445 ns | 0.0037 ns | 0.0033 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  8.760 ns | 0.0370 ns | 0.0328 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  8.973 ns | 0.0503 ns | 0.0446 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  8.982 ns | 0.0148 ns | 0.0131 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  8.611 ns | 0.0158 ns | 0.0148 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  8.877 ns | 0.0160 ns | 0.0142 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  7.901 ns | 0.0233 ns | 0.0206 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  8.203 ns | 0.0231 ns | 0.0216 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  7.784 ns | 0.0325 ns | 0.0288 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  7.920 ns | 0.0154 ns | 0.0144 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  8.282 ns | 0.0357 ns | 0.0334 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  7.580 ns | 0.0190 ns | 0.0169 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  7.721 ns | 0.0325 ns | 0.0288 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  7.612 ns | 0.0195 ns | 0.0162 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  7.655 ns | 0.0124 ns | 0.0110 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  7.917 ns | 0.0156 ns | 0.0146 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  7.571 ns | 0.0151 ns | 0.0126 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  8.515 ns | 0.0773 ns | 0.0723 ns |  1.13 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  7.902 ns | 0.0149 ns | 0.0132 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  8.138 ns | 0.0442 ns | 0.0413 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  7.984 ns | 0.0199 ns | 0.0176 ns |  1.05 |    0.00 |     - |     - |     - |         - |
