
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.142 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
     ToBoolNullable |  6.514 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
             ToChar |  4.114 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
     ToCharNullable |  7.032 ns | 0.0074 ns | 0.0065 ns |      - |       0 B |
            ToSByte |  3.859 ns | 0.0066 ns | 0.0062 ns |      - |       0 B |
    ToSByteNullable |  7.379 ns | 0.1536 ns | 0.1361 ns |      - |       0 B |
             ToByte |  4.111 ns | 0.0056 ns | 0.0050 ns |      - |       0 B |
     ToByteNullable |  7.274 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
            ToShort |  4.108 ns | 0.0021 ns | 0.0016 ns |      - |       0 B |
    ToShortNullable |  7.279 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
           ToUShort |  4.111 ns | 0.0032 ns | 0.0026 ns |      - |       0 B |
   ToUShortNullable |  7.024 ns | 0.0074 ns | 0.0070 ns |      - |       0 B |
              ToInt |  3.004 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
      ToIntNullable |  6.515 ns | 0.0056 ns | 0.0050 ns |      - |       0 B |
             ToUInt |  3.780 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
     ToUIntNullable |  6.513 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
             ToLong |  2.921 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
     ToLongNullable |  6.137 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
            ToULong |  3.631 ns | 0.0082 ns | 0.0073 ns |      - |       0 B |
    ToULongNullable |  6.656 ns | 0.0153 ns | 0.0143 ns |      - |       0 B |
            ToFloat |  2.984 ns | 0.0064 ns | 0.0056 ns |      - |       0 B |
    ToFloatNullable |  6.521 ns | 0.0073 ns | 0.0068 ns |      - |       0 B |
           ToDouble |  3.256 ns | 0.0642 ns | 0.0569 ns |      - |       0 B |
   ToDoubleNullable |  6.140 ns | 0.0109 ns | 0.0091 ns |      - |       0 B |
          ToDecimal |  6.946 ns | 0.0066 ns | 0.0062 ns |      - |       0 B |
  ToDecimalNullable | 15.710 ns | 0.0063 ns | 0.0052 ns |      - |       0 B |
         ToDateTime |  4.349 ns | 0.0030 ns | 0.0028 ns |      - |       0 B |
 ToDateTimeNullable |  6.146 ns | 0.0064 ns | 0.0060 ns |      - |       0 B |
           ToObject |  3.843 ns | 0.0029 ns | 0.0028 ns | 0.0057 |      24 B |
          To_String | 70.819 ns | 0.0517 ns | 0.0432 ns | 0.0057 |      24 B |
             ToEnum |  1.279 ns | 0.0020 ns | 0.0019 ns |      - |       0 B |
