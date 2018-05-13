
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  1.313 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
     ToBoolNullable |  4.471 ns | 0.0032 ns | 0.0030 ns |      - |       0 B |
             ToChar |  1.300 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
     ToCharNullable |  4.472 ns | 0.0030 ns | 0.0027 ns |      - |       0 B |
            ToSByte |  2.052 ns | 0.0271 ns | 0.0226 ns |      - |       0 B |
    ToSByteNullable |  4.711 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
             ToByte |  2.058 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
     ToByteNullable |  4.713 ns | 0.0056 ns | 0.0052 ns |      - |       0 B |
            ToShort |  2.040 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
    ToShortNullable |  4.710 ns | 0.0034 ns | 0.0032 ns |      - |       0 B |
           ToUShort |  1.300 ns | 0.0011 ns | 0.0007 ns |      - |       0 B |
   ToUShortNullable |  4.472 ns | 0.0022 ns | 0.0021 ns |      - |       0 B |
              ToInt |  1.285 ns | 0.0228 ns | 0.0213 ns |      - |       0 B |
      ToIntNullable |  4.472 ns | 0.0033 ns | 0.0029 ns |      - |       0 B |
             ToUInt |  1.279 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
     ToUIntNullable |  4.469 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
             ToLong |  1.279 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
     ToLongNullable |  2.554 ns | 0.0003 ns | 0.0002 ns |      - |       0 B |
            ToULong |  1.293 ns | 0.0257 ns | 0.0201 ns |      - |       0 B |
    ToULongNullable |  2.555 ns | 0.0011 ns | 0.0010 ns |      - |       0 B |
            ToFloat |  1.286 ns | 0.0205 ns | 0.0171 ns |      - |       0 B |
    ToFloatNullable |  4.485 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
           ToDouble |  1.279 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
   ToDoubleNullable |  2.556 ns | 0.0041 ns | 0.0036 ns |      - |       0 B |
          ToDecimal |  4.346 ns | 0.0047 ns | 0.0042 ns |      - |       0 B |
  ToDecimalNullable |  2.554 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
         ToDateTime |  3.065 ns | 0.0003 ns | 0.0002 ns |      - |       0 B |
 ToDateTimeNullable |  8.802 ns | 0.0015 ns | 0.0014 ns |      - |       0 B |
           ToObject |  3.785 ns | 0.0054 ns | 0.0050 ns | 0.0057 |      24 B |
          To_String |  5.583 ns | 0.0029 ns | 0.0025 ns | 0.0076 |      32 B |
             ToEnum | 11.569 ns | 0.0058 ns | 0.0049 ns |      - |       0 B |
     ToEnumNullable | 17.431 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
