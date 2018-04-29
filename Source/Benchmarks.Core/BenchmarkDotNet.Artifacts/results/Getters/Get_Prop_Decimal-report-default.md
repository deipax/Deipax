
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool | 13.857 ns | 0.0304 ns | 0.0285 ns |      - |       0 B |
     ToBoolNullable | 14.105 ns | 0.0623 ns | 0.0552 ns |      - |       0 B |
             ToChar |  4.372 ns | 0.0067 ns | 0.0063 ns |      - |       0 B |
     ToCharNullable |  6.771 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
            ToSByte | 16.890 ns | 0.0279 ns | 0.0261 ns |      - |       0 B |
    ToSByteNullable | 20.842 ns | 0.0151 ns | 0.0126 ns |      - |       0 B |
             ToByte | 16.611 ns | 0.0214 ns | 0.0201 ns |      - |       0 B |
     ToByteNullable | 20.578 ns | 0.0405 ns | 0.0379 ns |      - |       0 B |
            ToShort | 16.827 ns | 0.0168 ns | 0.0140 ns |      - |       0 B |
    ToShortNullable | 20.853 ns | 0.0389 ns | 0.0364 ns |      - |       0 B |
           ToUShort | 16.711 ns | 0.0393 ns | 0.0367 ns |      - |       0 B |
   ToUShortNullable | 20.595 ns | 0.0327 ns | 0.0306 ns |      - |       0 B |
              ToInt | 16.053 ns | 0.0228 ns | 0.0213 ns |      - |       0 B |
      ToIntNullable | 19.822 ns | 0.0358 ns | 0.0299 ns |      - |       0 B |
             ToUInt | 15.488 ns | 0.0346 ns | 0.0306 ns |      - |       0 B |
     ToUIntNullable | 19.580 ns | 0.0186 ns | 0.0174 ns |      - |       0 B |
             ToLong | 16.484 ns | 0.0345 ns | 0.0306 ns |      - |       0 B |
     ToLongNullable | 17.536 ns | 0.0415 ns | 0.0388 ns |      - |       0 B |
            ToULong | 16.006 ns | 0.0215 ns | 0.0191 ns |      - |       0 B |
    ToULongNullable | 17.327 ns | 0.0280 ns | 0.0248 ns |      - |       0 B |
            ToFloat | 13.708 ns | 0.0300 ns | 0.0280 ns |      - |       0 B |
    ToFloatNullable | 14.431 ns | 0.0347 ns | 0.0325 ns |      - |       0 B |
           ToDouble | 11.383 ns | 0.0249 ns | 0.0221 ns |      - |       0 B |
   ToDoubleNullable | 12.467 ns | 0.0328 ns | 0.0274 ns |      - |       0 B |
          ToDecimal |  3.335 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
  ToDecimalNullable |  7.022 ns | 0.0147 ns | 0.0131 ns |      - |       0 B |
         ToDateTime |  5.897 ns | 0.0253 ns | 0.0237 ns |      - |       0 B |
 ToDateTimeNullable |  6.420 ns | 0.0237 ns | 0.0222 ns |      - |       0 B |
           ToObject |  4.882 ns | 0.0176 ns | 0.0165 ns | 0.0076 |      32 B |
          To_String | 72.042 ns | 0.3312 ns | 0.3098 ns | 0.0075 |      32 B |
             ToEnum | 36.633 ns | 0.1053 ns | 0.0933 ns | 0.0076 |      32 B |
