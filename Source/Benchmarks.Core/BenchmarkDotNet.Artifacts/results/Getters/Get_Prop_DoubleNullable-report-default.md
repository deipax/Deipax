
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   5.481 ns | 0.0404 ns | 0.0358 ns |      - |       0 B |
     ToBoolNullable |   7.334 ns | 0.0277 ns | 0.0259 ns |      - |       0 B |
             ToChar |   4.384 ns | 0.0280 ns | 0.0262 ns |      - |       0 B |
     ToCharNullable |   6.893 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
            ToSByte |  10.320 ns | 0.0290 ns | 0.0271 ns |      - |       0 B |
    ToSByteNullable |  11.510 ns | 0.0486 ns | 0.0406 ns |      - |       0 B |
             ToByte |  10.240 ns | 0.0252 ns | 0.0236 ns |      - |       0 B |
     ToByteNullable |  11.611 ns | 0.0229 ns | 0.0215 ns |      - |       0 B |
            ToShort |  10.376 ns | 0.0185 ns | 0.0144 ns |      - |       0 B |
    ToShortNullable |  11.685 ns | 0.0292 ns | 0.0259 ns |      - |       0 B |
           ToUShort |  10.479 ns | 0.0398 ns | 0.0353 ns |      - |       0 B |
   ToUShortNullable |  11.704 ns | 0.0166 ns | 0.0155 ns |      - |       0 B |
              ToInt |   8.590 ns | 0.0622 ns | 0.0582 ns |      - |       0 B |
      ToIntNullable |   9.297 ns | 0.0194 ns | 0.0172 ns |      - |       0 B |
             ToUInt |   8.607 ns | 0.0518 ns | 0.0484 ns |      - |       0 B |
     ToUIntNullable |   9.059 ns | 0.0216 ns | 0.0192 ns |      - |       0 B |
             ToLong |   8.768 ns | 0.0576 ns | 0.0539 ns |      - |       0 B |
     ToLongNullable |  11.805 ns | 0.0325 ns | 0.0288 ns |      - |       0 B |
            ToULong |   9.234 ns | 0.0308 ns | 0.0273 ns |      - |       0 B |
    ToULongNullable |  11.493 ns | 0.0367 ns | 0.0343 ns |      - |       0 B |
            ToFloat |   5.165 ns | 0.0669 ns | 0.0593 ns |      - |       0 B |
    ToFloatNullable |   7.080 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
           ToDouble |   2.823 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
   ToDoubleNullable |   3.366 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
          ToDecimal |  65.468 ns | 0.0974 ns | 0.0864 ns |      - |       0 B |
  ToDecimalNullable |  72.855 ns | 0.1026 ns | 0.0960 ns |      - |       0 B |
         ToDateTime |   5.907 ns | 0.0192 ns | 0.0179 ns |      - |       0 B |
 ToDateTimeNullable |   6.510 ns | 0.0260 ns | 0.0243 ns |      - |       0 B |
           ToObject |   5.382 ns | 0.0129 ns | 0.0121 ns | 0.0057 |      24 B |
          To_String | 262.088 ns | 0.4160 ns | 0.3248 ns | 0.0072 |      32 B |
             ToEnum |  31.269 ns | 0.0709 ns | 0.0592 ns | 0.0057 |      24 B |
