
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool | 10.745 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
     ToBoolNullable | 16.867 ns | 0.0210 ns | 0.0187 ns |      - |       0 B |
             ToChar |  1.294 ns | 0.0012 ns | 0.0011 ns |      - |       0 B |
     ToCharNullable |  4.482 ns | 0.0034 ns | 0.0032 ns |      - |       0 B |
            ToSByte | 14.786 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
    ToSByteNullable | 22.500 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
             ToByte | 14.716 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
     ToByteNullable | 22.675 ns | 0.0535 ns | 0.0474 ns |      - |       0 B |
            ToShort | 14.858 ns | 0.0082 ns | 0.0064 ns |      - |       0 B |
    ToShortNullable | 22.620 ns | 0.0299 ns | 0.0280 ns |      - |       0 B |
           ToUShort | 14.982 ns | 0.0196 ns | 0.0184 ns |      - |       0 B |
   ToUShortNullable | 22.560 ns | 0.0123 ns | 0.0109 ns |      - |       0 B |
              ToInt | 16.227 ns | 0.0011 ns | 0.0010 ns |      - |       0 B |
      ToIntNullable | 21.856 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
             ToUInt | 13.882 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
     ToUIntNullable | 21.611 ns | 0.0380 ns | 0.0337 ns |      - |       0 B |
             ToLong | 16.298 ns | 0.0237 ns | 0.0221 ns |      - |       0 B |
     ToLongNullable | 15.146 ns | 0.0164 ns | 0.0153 ns |      - |       0 B |
            ToULong | 14.361 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
    ToULongNullable | 14.922 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
            ToFloat | 10.103 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
    ToFloatNullable | 17.524 ns | 0.0270 ns | 0.0239 ns |      - |       0 B |
           ToDouble |  8.088 ns | 0.0075 ns | 0.0050 ns |      - |       0 B |
   ToDoubleNullable |  9.109 ns | 0.0051 ns | 0.0040 ns |      - |       0 B |
          ToDecimal |  2.812 ns | 0.0051 ns | 0.0039 ns |      - |       0 B |
  ToDecimalNullable |  6.522 ns | 0.0131 ns | 0.0116 ns |      - |       0 B |
         ToDateTime |  3.068 ns | 0.0037 ns | 0.0035 ns |      - |       0 B |
 ToDateTimeNullable |  8.322 ns | 0.0154 ns | 0.0136 ns |      - |       0 B |
           ToObject |  4.106 ns | 0.0021 ns | 0.0017 ns | 0.0076 |      32 B |
          To_String | 75.080 ns | 0.1521 ns | 0.1423 ns | 0.0075 |      32 B |
             ToEnum | 28.773 ns | 0.0300 ns | 0.0251 ns |      - |       0 B |
     ToEnumNullable | 34.170 ns | 0.0569 ns | 0.0532 ns |      - |       0 B |
