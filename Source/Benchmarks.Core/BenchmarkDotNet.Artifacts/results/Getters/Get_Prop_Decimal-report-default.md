
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool | 12.802 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
     ToBoolNullable | 13.296 ns | 0.0066 ns | 0.0058 ns |      - |       0 B |
             ToChar |  4.455 ns | 0.0024 ns | 0.0022 ns |      - |       0 B |
     ToCharNullable |  6.774 ns | 0.0079 ns | 0.0073 ns |      - |       0 B |
            ToSByte | 16.207 ns | 0.0144 ns | 0.0127 ns |      - |       0 B |
    ToSByteNullable | 20.590 ns | 0.0196 ns | 0.0163 ns |      - |       0 B |
             ToByte | 17.971 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
     ToByteNullable | 20.324 ns | 0.0223 ns | 0.0174 ns |      - |       0 B |
            ToShort | 16.197 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
    ToShortNullable | 20.559 ns | 0.0026 ns | 0.0020 ns |      - |       0 B |
           ToUShort | 16.140 ns | 0.0083 ns | 0.0073 ns |      - |       0 B |
   ToUShortNullable | 20.316 ns | 0.0220 ns | 0.0206 ns |      - |       0 B |
              ToInt | 15.335 ns | 0.0253 ns | 0.0237 ns |      - |       0 B |
      ToIntNullable | 19.550 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
             ToUInt | 15.713 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
     ToUIntNullable | 19.307 ns | 0.0352 ns | 0.0329 ns |      - |       0 B |
             ToLong | 16.019 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
     ToLongNullable | 17.254 ns | 0.0291 ns | 0.0258 ns |      - |       0 B |
            ToULong | 15.711 ns | 0.0222 ns | 0.0208 ns |      - |       0 B |
    ToULongNullable | 16.934 ns | 0.0119 ns | 0.0099 ns |      - |       0 B |
            ToFloat | 12.731 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
    ToFloatNullable | 13.417 ns | 0.0088 ns | 0.0069 ns |      - |       0 B |
           ToDouble | 10.619 ns | 0.0030 ns | 0.0027 ns |      - |       0 B |
   ToDoubleNullable | 11.664 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
          ToDecimal |  2.555 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
  ToDecimalNullable |  6.257 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
         ToDateTime |  5.131 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
 ToDateTimeNullable |  6.810 ns | 0.0565 ns | 0.0471 ns |      - |       0 B |
           ToObject |  4.553 ns | 0.0552 ns | 0.0516 ns | 0.0076 |      32 B |
          To_String | 70.141 ns | 0.2016 ns | 0.1574 ns | 0.0075 |      32 B |
             ToEnum | 40.156 ns | 0.0997 ns | 0.0778 ns | 0.0075 |      32 B |
