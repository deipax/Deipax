
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  5.014 ns | 0.0024 ns | 0.0022 ns |      - |       0 B |
     ToBoolNullable |  7.035 ns | 0.0055 ns | 0.0052 ns |      - |       0 B |
             ToChar |  5.896 ns | 0.0016 ns | 0.0015 ns |      - |       0 B |
     ToCharNullable |  7.542 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
            ToSByte |  5.909 ns | 0.0178 ns | 0.0158 ns |      - |       0 B |
    ToSByteNullable |  7.539 ns | 0.0012 ns | 0.0009 ns |      - |       0 B |
             ToByte |  6.601 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
     ToByteNullable |  7.545 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
            ToShort |  5.901 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
    ToShortNullable |  7.781 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
           ToUShort |  5.893 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
   ToUShortNullable |  7.540 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
              ToInt |  5.900 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
      ToIntNullable |  7.607 ns | 0.0301 ns | 0.0281 ns |      - |       0 B |
             ToUInt |  5.882 ns | 0.0073 ns | 0.0064 ns |      - |       0 B |
     ToUIntNullable |  7.539 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
             ToLong |  2.081 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
     ToLongNullable |  2.812 ns | 0.0040 ns | 0.0037 ns |      - |       0 B |
            ToULong |  4.696 ns | 0.0053 ns | 0.0047 ns |      - |       0 B |
    ToULongNullable |  7.668 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
            ToFloat |  4.896 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
    ToFloatNullable |  7.041 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
           ToDouble |  4.891 ns | 0.0057 ns | 0.0047 ns |      - |       0 B |
   ToDoubleNullable |  6.936 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
          ToDecimal |  7.667 ns | 0.0090 ns | 0.0079 ns |      - |       0 B |
  ToDecimalNullable | 16.479 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
         ToDateTime |  5.124 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
 ToDateTimeNullable |  6.256 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
           ToObject |  4.860 ns | 0.0058 ns | 0.0051 ns | 0.0057 |      24 B |
          To_String | 47.648 ns | 0.0185 ns | 0.0173 ns | 0.0076 |      32 B |
             ToEnum | 28.205 ns | 0.0141 ns | 0.0110 ns | 0.0057 |      24 B |
