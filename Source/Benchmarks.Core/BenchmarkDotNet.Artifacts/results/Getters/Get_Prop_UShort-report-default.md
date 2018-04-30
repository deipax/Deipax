
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.119 ns | 0.0353 ns | 0.0313 ns |      - |       0 B |
     ToBoolNullable |  6.652 ns | 0.1551 ns | 0.1593 ns |      - |       0 B |
             ToChar |  2.937 ns | 0.0238 ns | 0.0199 ns |      - |       0 B |
     ToCharNullable |  6.525 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
            ToSByte |  3.807 ns | 0.0231 ns | 0.0216 ns |      - |       0 B |
    ToSByteNullable |  6.523 ns | 0.0202 ns | 0.0179 ns |      - |       0 B |
             ToByte |  3.948 ns | 0.1314 ns | 0.1290 ns |      - |       0 B |
     ToByteNullable |  6.523 ns | 0.0135 ns | 0.0119 ns |      - |       0 B |
            ToShort |  3.815 ns | 0.0461 ns | 0.0385 ns |      - |       0 B |
    ToShortNullable |  6.523 ns | 0.0109 ns | 0.0097 ns |      - |       0 B |
           ToUShort |  1.304 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
   ToUShortNullable |  4.480 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
              ToInt |  3.096 ns | 0.0325 ns | 0.0271 ns |      - |       0 B |
      ToIntNullable |  6.625 ns | 0.0874 ns | 0.0775 ns |      - |       0 B |
             ToUInt |  3.230 ns | 0.0409 ns | 0.0382 ns |      - |       0 B |
     ToUIntNullable |  6.664 ns | 0.1114 ns | 0.1042 ns |      - |       0 B |
             ToLong |  3.096 ns | 0.0397 ns | 0.0372 ns |      - |       0 B |
     ToLongNullable |  6.038 ns | 0.1033 ns | 0.0966 ns |      - |       0 B |
            ToULong |  3.086 ns | 0.0334 ns | 0.0296 ns |      - |       0 B |
    ToULongNullable |  6.170 ns | 0.0242 ns | 0.0215 ns |      - |       0 B |
            ToFloat |  3.103 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
    ToFloatNullable |  6.530 ns | 0.0069 ns | 0.0064 ns |      - |       0 B |
           ToDouble |  3.324 ns | 0.0366 ns | 0.0285 ns |      - |       0 B |
   ToDoubleNullable |  6.180 ns | 0.0295 ns | 0.0246 ns |      - |       0 B |
          ToDecimal |  6.425 ns | 0.0463 ns | 0.0387 ns |      - |       0 B |
  ToDecimalNullable | 15.835 ns | 0.0409 ns | 0.0341 ns |      - |       0 B |
         ToDateTime |  4.715 ns | 0.0939 ns | 0.0878 ns |      - |       0 B |
 ToDateTimeNullable |  6.325 ns | 0.1301 ns | 0.1153 ns |      - |       0 B |
           ToObject |  3.959 ns | 0.1087 ns | 0.1335 ns | 0.0057 |      24 B |
          To_String | 39.995 ns | 0.4223 ns | 0.3526 ns | 0.0076 |      32 B |
             ToEnum | 23.288 ns | 0.4778 ns | 0.4693 ns | 0.0057 |      24 B |
