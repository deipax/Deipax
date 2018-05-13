
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
             ToBool |  1.279 ns | 0.0304 ns | 0.0269 ns |  1.269 ns |      - |       0 B |
     ToBoolNullable |  4.489 ns | 0.0285 ns | 0.0238 ns |  4.482 ns |      - |       0 B |
             ToChar |  3.131 ns | 0.1131 ns | 0.1257 ns |  3.086 ns |      - |       0 B |
     ToCharNullable |  5.282 ns | 0.0136 ns | 0.0127 ns |  5.279 ns |      - |       0 B |
            ToSByte |  2.961 ns | 0.0505 ns | 0.0394 ns |  2.952 ns |      - |       0 B |
    ToSByteNullable |  5.301 ns | 0.0434 ns | 0.0362 ns |  5.289 ns |      - |       0 B |
             ToByte |  3.110 ns | 0.0220 ns | 0.0184 ns |  3.111 ns |      - |       0 B |
     ToByteNullable |  5.299 ns | 0.0333 ns | 0.0260 ns |  5.297 ns |      - |       0 B |
            ToShort |  3.100 ns | 0.0276 ns | 0.0258 ns |  3.104 ns |      - |       0 B |
    ToShortNullable |  5.481 ns | 0.1420 ns | 0.2293 ns |  5.358 ns |      - |       0 B |
           ToUShort |  3.110 ns | 0.0313 ns | 0.0293 ns |  3.109 ns |      - |       0 B |
   ToUShortNullable |  5.355 ns | 0.1337 ns | 0.1540 ns |  5.273 ns |      - |       0 B |
              ToInt |  1.310 ns | 0.0538 ns | 0.0504 ns |  1.287 ns |      - |       0 B |
      ToIntNullable |  4.555 ns | 0.0788 ns | 0.0699 ns |  4.526 ns |      - |       0 B |
             ToUInt |  1.823 ns | 0.0484 ns | 0.0404 ns |  1.833 ns |      - |       0 B |
     ToUIntNullable |  4.835 ns | 0.1262 ns | 0.1181 ns |  4.882 ns |      - |       0 B |
             ToLong |  1.294 ns | 0.0112 ns | 0.0105 ns |  1.289 ns |      - |       0 B |
     ToLongNullable |  2.609 ns | 0.0328 ns | 0.0307 ns |  2.607 ns |      - |       0 B |
            ToULong |  1.808 ns | 0.0189 ns | 0.0158 ns |  1.799 ns |      - |       0 B |
    ToULongNullable |  3.227 ns | 0.0988 ns | 0.1213 ns |  3.247 ns |      - |       0 B |
            ToFloat |  1.290 ns | 0.0058 ns | 0.0048 ns |  1.290 ns |      - |       0 B |
    ToFloatNullable |  4.513 ns | 0.0198 ns | 0.0175 ns |  4.507 ns |      - |       0 B |
           ToDouble |  1.298 ns | 0.0166 ns | 0.0156 ns |  1.292 ns |      - |       0 B |
   ToDoubleNullable |  2.578 ns | 0.0159 ns | 0.0141 ns |  2.572 ns |      - |       0 B |
          ToDecimal |  6.539 ns | 0.0113 ns | 0.0106 ns |  6.537 ns |      - |       0 B |
  ToDecimalNullable | 18.747 ns | 0.2250 ns | 0.2105 ns | 18.636 ns |      - |       0 B |
         ToDateTime |  2.582 ns | 0.0105 ns | 0.0093 ns |  2.582 ns |      - |       0 B |
 ToDateTimeNullable |  8.596 ns | 0.0338 ns | 0.0300 ns |  8.590 ns |      - |       0 B |
           ToObject |  3.934 ns | 0.0224 ns | 0.0199 ns |  3.935 ns | 0.0057 |      24 B |
          To_String | 72.102 ns | 1.3836 ns | 1.4208 ns | 72.175 ns | 0.0057 |      24 B |
             ToEnum |  1.295 ns | 0.0097 ns | 0.0086 ns |  1.293 ns |      - |       0 B |
     ToEnumNullable |  4.523 ns | 0.0205 ns | 0.0192 ns |  4.521 ns |      - |       0 B |
