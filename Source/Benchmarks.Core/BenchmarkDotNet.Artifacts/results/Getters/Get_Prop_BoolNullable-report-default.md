
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  2.022 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
     ToBoolNullable |  1.280 ns | 0.0016 ns | 0.0015 ns |      - |       0 B |
             ToChar |  3.095 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
     ToCharNullable |  6.546 ns | 0.0224 ns | 0.0199 ns |      - |       0 B |
            ToSByte |  4.625 ns | 0.0075 ns | 0.0063 ns |      - |       0 B |
    ToSByteNullable |  6.777 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
             ToByte |  4.623 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
     ToByteNullable |  6.856 ns | 0.1724 ns | 0.1439 ns |      - |       0 B |
            ToShort |  4.118 ns | 0.0203 ns | 0.0170 ns |      - |       0 B |
    ToShortNullable |  6.779 ns | 0.0072 ns | 0.0068 ns |      - |       0 B |
           ToUShort |  4.104 ns | 0.0065 ns | 0.0061 ns |      - |       0 B |
   ToUShortNullable |  6.807 ns | 0.0373 ns | 0.0349 ns |      - |       0 B |
              ToInt |  4.113 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
      ToIntNullable |  6.803 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
             ToUInt |  4.085 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
     ToUIntNullable |  6.794 ns | 0.0199 ns | 0.0186 ns |      - |       0 B |
             ToLong |  4.091 ns | 0.0057 ns | 0.0050 ns |      - |       0 B |
     ToLongNullable |  7.450 ns | 0.0075 ns | 0.0063 ns |      - |       0 B |
            ToULong |  4.096 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
    ToULongNullable |  7.422 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
            ToFloat |  4.094 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
    ToFloatNullable |  6.813 ns | 0.0052 ns | 0.0038 ns |      - |       0 B |
           ToDouble |  4.454 ns | 0.0056 ns | 0.0050 ns |      - |       0 B |
   ToDoubleNullable |  7.684 ns | 0.0068 ns | 0.0063 ns |      - |       0 B |
          ToDecimal |  7.971 ns | 0.0802 ns | 0.0750 ns |      - |       0 B |
  ToDecimalNullable | 16.702 ns | 0.1435 ns | 0.1342 ns |      - |       0 B |
         ToDateTime |  4.374 ns | 0.0301 ns | 0.0282 ns |      - |       0 B |
 ToDateTimeNullable |  6.135 ns | 0.0083 ns | 0.0073 ns |      - |       0 B |
           ToObject |  4.875 ns | 0.0069 ns | 0.0065 ns | 0.0057 |      24 B |
          To_String |  6.402 ns | 0.0079 ns | 0.0070 ns |      - |       0 B |
             ToEnum | 26.770 ns | 0.0564 ns | 0.0500 ns | 0.0057 |      24 B |
