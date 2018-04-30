
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   3.526 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
     ToBoolNullable |   6.773 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
             ToChar |   4.312 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
     ToCharNullable |   6.793 ns | 0.0234 ns | 0.0218 ns |      - |       0 B |
            ToSByte |   3.483 ns | 0.0014 ns | 0.0009 ns |      - |       0 B |
    ToSByteNullable |   6.771 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
             ToByte |   3.680 ns | 0.0015 ns | 0.0014 ns |      - |       0 B |
     ToByteNullable |   6.804 ns | 0.0209 ns | 0.0185 ns |      - |       0 B |
            ToShort |   3.545 ns | 0.0006 ns | 0.0006 ns |      - |       0 B |
    ToShortNullable |   6.798 ns | 0.0238 ns | 0.0211 ns |      - |       0 B |
           ToUShort |   3.478 ns | 0.0060 ns | 0.0053 ns |      - |       0 B |
   ToUShortNullable |   6.788 ns | 0.0243 ns | 0.0227 ns |      - |       0 B |
              ToInt |   3.478 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |
      ToIntNullable |   6.774 ns | 0.0074 ns | 0.0065 ns |      - |       0 B |
             ToUInt |   3.701 ns | 0.0007 ns | 0.0007 ns |      - |       0 B |
     ToUIntNullable |   6.788 ns | 0.0228 ns | 0.0191 ns |      - |       0 B |
             ToLong |   3.544 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
     ToLongNullable |   6.137 ns | 0.0066 ns | 0.0059 ns |      - |       0 B |
            ToULong |   3.464 ns | 0.0040 ns | 0.0036 ns |      - |       0 B |
    ToULongNullable |   6.394 ns | 0.0238 ns | 0.0223 ns |      - |       0 B |
            ToFloat |   3.467 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
    ToFloatNullable |   6.774 ns | 0.0053 ns | 0.0050 ns |      - |       0 B |
           ToDouble |   3.669 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
   ToDoubleNullable |   6.662 ns | 0.0299 ns | 0.0265 ns |      - |       0 B |
          ToDecimal |   6.155 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
  ToDecimalNullable |   6.652 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
         ToDateTime |   2.210 ns | 0.0035 ns | 0.0032 ns |      - |       0 B |
 ToDateTimeNullable |   2.567 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
           ToObject |   4.903 ns | 0.0028 ns | 0.0027 ns | 0.0057 |      24 B |
          To_String | 428.746 ns | 0.3062 ns | 0.2557 ns | 0.0401 |     168 B |
             ToEnum |  25.657 ns | 0.0176 ns | 0.0165 ns | 0.0057 |      24 B |
