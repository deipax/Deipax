
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  1.295 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
     ToBoolNullable |  4.469 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
             ToChar |  2.827 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
     ToCharNullable |  5.236 ns | 0.0031 ns | 0.0027 ns |      - |       0 B |
            ToSByte |  2.061 ns | 0.0018 ns | 0.0017 ns |      - |       0 B |
    ToSByteNullable |  4.710 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
             ToByte |  3.081 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
     ToByteNullable |  5.237 ns | 0.0033 ns | 0.0028 ns |      - |       0 B |
            ToShort |  3.086 ns | 0.0031 ns | 0.0028 ns |      - |       0 B |
    ToShortNullable |  5.238 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
           ToUShort |  3.082 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
   ToUShortNullable |  5.235 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
              ToInt |  3.081 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
      ToIntNullable |  4.991 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
             ToUInt |  2.043 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
     ToUIntNullable |  4.967 ns | 0.0018 ns | 0.0017 ns |      - |       0 B |
             ToLong |  1.791 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
     ToLongNullable |  3.581 ns | 0.0055 ns | 0.0051 ns |      - |       0 B |
            ToULong |  1.281 ns | 0.0060 ns | 0.0054 ns |      - |       0 B |
    ToULongNullable |  2.810 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
            ToFloat |  2.043 ns | 0.0074 ns | 0.0069 ns |      - |       0 B |
    ToFloatNullable |  4.761 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
           ToDouble |  1.792 ns | 0.0041 ns | 0.0038 ns |      - |       0 B |
   ToDoubleNullable |  3.324 ns | 0.0055 ns | 0.0051 ns |      - |       0 B |
          ToDecimal |  6.521 ns | 0.0052 ns | 0.0048 ns |      - |       0 B |
  ToDecimalNullable | 20.795 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
         ToDateTime |  2.817 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
 ToDateTimeNullable |  8.699 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
           ToObject |  3.783 ns | 0.0047 ns | 0.0044 ns | 0.0057 |      24 B |
          To_String | 41.915 ns | 0.0277 ns | 0.0231 ns | 0.0076 |      32 B |
             ToEnum | 12.162 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
     ToEnumNullable | 17.973 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
