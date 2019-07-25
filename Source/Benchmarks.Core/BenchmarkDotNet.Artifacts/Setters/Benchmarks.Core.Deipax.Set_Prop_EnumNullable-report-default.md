
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
             FromBool | .NET Core 2.0 | 17.2165 ns | 0.0861 ns | 0.0805 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 17.3359 ns | 0.0187 ns | 0.0175 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 13.5595 ns | 0.0412 ns | 0.0366 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 | 19.7724 ns | 0.0166 ns | 0.0129 ns |  1.15 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 | 19.9396 ns | 0.0728 ns | 0.0645 ns |  1.16 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 17.5712 ns | 0.0271 ns | 0.0240 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 17.6430 ns | 0.0377 ns | 0.0315 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 13.9808 ns | 0.0795 ns | 0.0743 ns |  0.80 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 20.6401 ns | 0.0462 ns | 0.0432 ns |  1.17 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 20.9065 ns | 0.0638 ns | 0.0597 ns |  1.19 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 | 17.1150 ns | 0.0234 ns | 0.0207 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 | 17.2215 ns | 0.0221 ns | 0.0207 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 | 13.5581 ns | 0.0165 ns | 0.0138 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 | 19.8037 ns | 0.0334 ns | 0.0296 ns |  1.16 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 | 19.7410 ns | 0.0484 ns | 0.0404 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 | 17.6133 ns | 0.0271 ns | 0.0240 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 17.6798 ns | 0.0314 ns | 0.0294 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 | 13.9873 ns | 0.0237 ns | 0.0185 ns |  0.79 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 | 20.6746 ns | 0.0301 ns | 0.0267 ns |  1.17 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 | 20.8795 ns | 0.0673 ns | 0.0629 ns |  1.19 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 17.1690 ns | 0.0147 ns | 0.0130 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 17.1822 ns | 0.0384 ns | 0.0359 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 13.6436 ns | 0.0437 ns | 0.0409 ns |  0.79 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 | 19.7922 ns | 0.0541 ns | 0.0506 ns |  1.15 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 | 19.8067 ns | 0.0235 ns | 0.0220 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 17.7918 ns | 0.0287 ns | 0.0268 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 17.6571 ns | 0.0260 ns | 0.0203 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 13.9242 ns | 0.0295 ns | 0.0262 ns |  0.78 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 20.5981 ns | 0.0271 ns | 0.0240 ns |  1.16 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 20.6323 ns | 0.0452 ns | 0.0423 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 17.1708 ns | 0.0253 ns | 0.0211 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 17.2174 ns | 0.0277 ns | 0.0216 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 13.5492 ns | 0.0902 ns | 0.0843 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 | 19.8253 ns | 0.0502 ns | 0.0445 ns |  1.15 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 | 19.7425 ns | 0.0418 ns | 0.0371 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 17.7053 ns | 0.0577 ns | 0.0482 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 17.6691 ns | 0.0292 ns | 0.0259 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 13.9010 ns | 0.0372 ns | 0.0330 ns |  0.79 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 20.8272 ns | 0.0467 ns | 0.0437 ns |  1.18 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 20.6185 ns | 0.0342 ns | 0.0320 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 17.1455 ns | 0.0192 ns | 0.0171 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 17.3772 ns | 0.0561 ns | 0.0497 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 13.5026 ns | 0.0298 ns | 0.0264 ns |  0.79 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 | 19.7850 ns | 0.0472 ns | 0.0394 ns |  1.15 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 | 19.9149 ns | 0.0681 ns | 0.0637 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 17.6093 ns | 0.0358 ns | 0.0299 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 17.6608 ns | 0.0217 ns | 0.0181 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 13.8797 ns | 0.0289 ns | 0.0256 ns |  0.79 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 20.6537 ns | 0.0275 ns | 0.0244 ns |  1.17 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 20.7159 ns | 0.0458 ns | 0.0406 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 17.3011 ns | 0.0354 ns | 0.0331 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 17.3022 ns | 0.0537 ns | 0.0502 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 13.5347 ns | 0.0351 ns | 0.0293 ns |  0.78 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 | 19.7617 ns | 0.0433 ns | 0.0384 ns |  1.14 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 | 19.8386 ns | 0.0382 ns | 0.0339 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 17.6268 ns | 0.0565 ns | 0.0472 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 17.7277 ns | 0.0303 ns | 0.0283 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 13.8740 ns | 0.0202 ns | 0.0179 ns |  0.79 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 20.6754 ns | 0.0349 ns | 0.0326 ns |  1.17 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 20.7164 ns | 0.0258 ns | 0.0229 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 17.1225 ns | 0.0178 ns | 0.0139 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 17.1046 ns | 0.0378 ns | 0.0354 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 13.2569 ns | 0.0101 ns | 0.0084 ns |  0.77 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 | 19.9833 ns | 0.0575 ns | 0.0538 ns |  1.17 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 | 19.7766 ns | 0.0329 ns | 0.0292 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 17.7502 ns | 0.0704 ns | 0.0624 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 17.6473 ns | 0.0222 ns | 0.0208 ns |  0.99 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 13.9473 ns | 0.0186 ns | 0.0155 ns |  0.79 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 20.6385 ns | 0.0251 ns | 0.0235 ns |  1.16 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 20.8242 ns | 0.0669 ns | 0.0626 ns |  1.17 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 17.2204 ns | 0.0323 ns | 0.0302 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 17.1377 ns | 0.0364 ns | 0.0323 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 13.3156 ns | 0.0212 ns | 0.0199 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 | 20.1036 ns | 0.0228 ns | 0.0213 ns |  1.17 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 | 19.9641 ns | 0.0235 ns | 0.0220 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 17.6625 ns | 0.0293 ns | 0.0229 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 17.5714 ns | 0.0362 ns | 0.0302 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 13.7940 ns | 0.0288 ns | 0.0270 ns |  0.78 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 20.8468 ns | 0.0301 ns | 0.0251 ns |  1.18 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 20.8956 ns | 0.0214 ns | 0.0200 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 17.8094 ns | 0.0435 ns | 0.0363 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 17.6016 ns | 0.0686 ns | 0.0608 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 13.7563 ns | 0.0419 ns | 0.0372 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 | 20.2602 ns | 0.1169 ns | 0.1093 ns |  1.14 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 | 20.2319 ns | 0.0274 ns | 0.0256 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 18.9791 ns | 0.0996 ns | 0.0932 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 18.4881 ns | 0.1376 ns | 0.1220 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 14.9872 ns | 0.0241 ns | 0.0213 ns |  0.79 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 21.8111 ns | 0.0227 ns | 0.0212 ns |  1.15 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 21.8154 ns | 0.0326 ns | 0.0305 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 17.7154 ns | 0.0456 ns | 0.0404 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 17.4647 ns | 0.0489 ns | 0.0408 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 13.7744 ns | 0.0291 ns | 0.0258 ns |  0.78 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 | 20.3032 ns | 0.0382 ns | 0.0358 ns |  1.15 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 | 20.0737 ns | 0.0274 ns | 0.0256 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 18.5902 ns | 0.0313 ns | 0.0293 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 18.4320 ns | 0.0309 ns | 0.0289 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 14.9945 ns | 0.0208 ns | 0.0195 ns |  0.81 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 21.6501 ns | 0.1126 ns | 0.1053 ns |  1.16 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 21.5753 ns | 0.0328 ns | 0.0291 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 19.8767 ns | 0.0166 ns | 0.0139 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 19.4091 ns | 0.0269 ns | 0.0239 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 15.8995 ns | 0.0256 ns | 0.0240 ns |  0.80 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 | 22.3496 ns | 0.0441 ns | 0.0391 ns |  1.12 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 | 22.4940 ns | 0.0981 ns | 0.0917 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 19.6025 ns | 0.0273 ns | 0.0242 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 19.6894 ns | 0.1415 ns | 0.1324 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 16.2165 ns | 0.0745 ns | 0.0660 ns |  0.83 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 22.6962 ns | 0.1197 ns | 0.1061 ns |  1.16 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 22.7222 ns | 0.0411 ns | 0.0364 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 19.5035 ns | 0.0284 ns | 0.0266 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 19.3879 ns | 0.0332 ns | 0.0295 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 15.8716 ns | 0.0279 ns | 0.0233 ns |  0.81 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 | 22.3311 ns | 0.0486 ns | 0.0405 ns |  1.14 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 | 22.5377 ns | 0.1027 ns | 0.0960 ns |  1.16 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 20.2552 ns | 0.0523 ns | 0.0490 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 20.0621 ns | 0.0437 ns | 0.0387 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 16.7908 ns | 0.0232 ns | 0.0205 ns |  0.83 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 23.2952 ns | 0.0386 ns | 0.0361 ns |  1.15 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 23.3400 ns | 0.0399 ns | 0.0333 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 35.1195 ns | 0.2602 ns | 0.2433 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 34.6423 ns | 0.0810 ns | 0.0757 ns |  0.99 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 | 23.5387 ns | 0.0312 ns | 0.0277 ns |  0.67 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 31.0658 ns | 0.1190 ns | 0.1055 ns |  0.88 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 | 30.8800 ns | 0.0468 ns | 0.0415 ns |  0.88 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 39.7615 ns | 0.1261 ns | 0.1179 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 39.0006 ns | 0.0734 ns | 0.0613 ns |  0.98 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 30.0122 ns | 0.0705 ns | 0.0659 ns |  0.75 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 34.7939 ns | 0.1639 ns | 0.1368 ns |  0.88 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 34.8319 ns | 0.0548 ns | 0.0486 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 | 11.9464 ns | 0.0244 ns | 0.0228 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 | 11.5891 ns | 0.0159 ns | 0.0124 ns |  0.97 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  7.4196 ns | 0.0139 ns | 0.0123 ns |  0.62 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 | 14.5437 ns | 0.0313 ns | 0.0293 ns |  1.22 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 | 14.5758 ns | 0.0248 ns | 0.0232 ns |  1.22 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  9.5671 ns | 0.0448 ns | 0.0419 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  8.8107 ns | 0.0219 ns | 0.0205 ns |  0.92 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  2.4292 ns | 0.0075 ns | 0.0063 ns |  0.25 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  9.0362 ns | 0.0351 ns | 0.0329 ns |  0.94 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  8.9747 ns | 0.0674 ns | 0.0631 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.7349 ns | 0.0195 ns | 0.0182 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.2677 ns | 0.0204 ns | 0.0170 ns |  1.47 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 14.9089 ns | 0.0869 ns | 0.0813 ns |  1.53 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 13.6912 ns | 0.0263 ns | 0.0233 ns |  1.41 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.5680 ns | 0.0217 ns | 0.0203 ns |  1.39 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 20.8641 ns | 0.0379 ns | 0.0336 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 24.6144 ns | 0.1616 ns | 0.1512 ns |  1.18 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 19.6941 ns | 0.0338 ns | 0.0283 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 29.8301 ns | 0.2137 ns | 0.1999 ns |  1.43 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 30.2008 ns | 0.1846 ns | 0.1637 ns |  1.45 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.7245 ns | 0.0086 ns | 0.0076 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.7253 ns | 0.0212 ns | 0.0199 ns |  1.00 |    0.03 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7335 ns | 0.0060 ns | 0.0053 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.9517 ns | 0.0038 ns | 0.0030 ns |  1.31 |    0.02 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.9475 ns | 0.0054 ns | 0.0051 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  0.6840 ns | 0.0042 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  0.9459 ns | 0.0039 ns | 0.0032 ns |  1.38 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  0.6976 ns | 0.0043 ns | 0.0040 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.1159 ns | 0.0097 ns | 0.0090 ns |  1.63 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  0.7255 ns | 0.0030 ns | 0.0023 ns |  1.06 |    0.01 |     - |     - |     - |         - |
