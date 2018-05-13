
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   1.339 ns | 0.0543 ns | 0.0508 ns |      - |       0 B |
     ToBoolNullable |   4.484 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
             ToChar |   1.302 ns | 0.0222 ns | 0.0197 ns |      - |       0 B |
     ToCharNullable |   4.485 ns | 0.0036 ns | 0.0033 ns |      - |       0 B |
            ToSByte |   1.312 ns | 0.0425 ns | 0.0398 ns |      - |       0 B |
    ToSByteNullable |   4.483 ns | 0.0060 ns | 0.0056 ns |      - |       0 B |
             ToByte |   1.349 ns | 0.0426 ns | 0.0378 ns |      - |       0 B |
     ToByteNullable |   4.483 ns | 0.0060 ns | 0.0054 ns |      - |       0 B |
            ToShort |   1.311 ns | 0.0326 ns | 0.0305 ns |      - |       0 B |
    ToShortNullable |   4.536 ns | 0.0877 ns | 0.0821 ns |      - |       0 B |
           ToUShort |   1.304 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
   ToUShortNullable |   4.480 ns | 0.0056 ns | 0.0049 ns |      - |       0 B |
              ToInt |   1.322 ns | 0.0440 ns | 0.0412 ns |      - |       0 B |
      ToIntNullable |   4.480 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
             ToUInt |   1.311 ns | 0.0528 ns | 0.0468 ns |      - |       0 B |
     ToUIntNullable |   4.495 ns | 0.0473 ns | 0.0420 ns |      - |       0 B |
             ToLong |   1.283 ns | 0.0101 ns | 0.0089 ns |      - |       0 B |
     ToLongNullable |   2.861 ns | 0.0512 ns | 0.0479 ns |      - |       0 B |
            ToULong |   1.284 ns | 0.0051 ns | 0.0045 ns |      - |       0 B |
    ToULongNullable |   2.912 ns | 0.0119 ns | 0.0093 ns |      - |       0 B |
            ToFloat |   1.319 ns | 0.0595 ns | 0.0585 ns |      - |       0 B |
    ToFloatNullable |   4.497 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
           ToDouble |   1.434 ns | 0.0621 ns | 0.1181 ns |      - |       0 B |
   ToDoubleNullable |   2.818 ns | 0.0071 ns | 0.0066 ns |      - |       0 B |
          ToDecimal |   4.370 ns | 0.0136 ns | 0.0120 ns |      - |       0 B |
  ToDecimalNullable |   2.572 ns | 0.0205 ns | 0.0191 ns |      - |       0 B |
         ToDateTime |   1.542 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
 ToDateTimeNullable |   6.506 ns | 0.0208 ns | 0.0163 ns |      - |       0 B |
           ToObject |   3.833 ns | 0.0696 ns | 0.0617 ns | 0.0057 |      24 B |
          To_String | 419.838 ns | 2.6278 ns | 2.1943 ns | 0.0401 |     168 B |
             ToEnum |  11.380 ns | 0.0222 ns | 0.0186 ns |      - |       0 B |
     ToEnumNullable |  11.781 ns | 0.0582 ns | 0.0544 ns |      - |       0 B |
