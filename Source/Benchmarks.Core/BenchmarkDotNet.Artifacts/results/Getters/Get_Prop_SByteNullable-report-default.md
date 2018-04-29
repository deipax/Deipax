
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  4.361 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
     ToBoolNullable |  6.800 ns | 0.0064 ns | 0.0057 ns |      - |       0 B |
             ToChar |  4.880 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
     ToCharNullable |  7.296 ns | 0.0086 ns | 0.0077 ns |      - |       0 B |
            ToSByte |  2.841 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
    ToSByteNullable |  1.789 ns | 0.0052 ns | 0.0049 ns |      - |       0 B |
             ToByte |  5.379 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
     ToByteNullable |  7.277 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
            ToShort |  4.626 ns | 0.0116 ns | 0.0097 ns |      - |       0 B |
    ToShortNullable |  6.792 ns | 0.0057 ns | 0.0053 ns |      - |       0 B |
           ToUShort |  5.398 ns | 0.0094 ns | 0.0079 ns |      - |       0 B |
   ToUShortNullable |  7.290 ns | 0.0069 ns | 0.0061 ns |      - |       0 B |
              ToInt |  4.643 ns | 0.0038 ns | 0.0028 ns |      - |       0 B |
      ToIntNullable |  6.791 ns | 0.0035 ns | 0.0033 ns |      - |       0 B |
             ToUInt |  5.376 ns | 0.0125 ns | 0.0111 ns |      - |       0 B |
     ToUIntNullable |  7.276 ns | 0.0038 ns | 0.0036 ns |      - |       0 B |
             ToLong |  4.610 ns | 0.0121 ns | 0.0108 ns |      - |       0 B |
     ToLongNullable |  7.176 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
            ToULong |  5.381 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
    ToULongNullable |  7.681 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
            ToFloat |  4.615 ns | 0.0144 ns | 0.0127 ns |      - |       0 B |
    ToFloatNullable |  7.039 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
           ToDouble |  4.884 ns | 0.0126 ns | 0.0105 ns |      - |       0 B |
   ToDoubleNullable |  6.911 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
          ToDecimal |  8.173 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
  ToDecimalNullable | 16.772 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
         ToDateTime |  5.364 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
 ToDateTimeNullable |  6.658 ns | 0.0054 ns | 0.0050 ns |      - |       0 B |
           ToObject |  5.294 ns | 0.0013 ns | 0.0012 ns | 0.0057 |      24 B |
          To_String | 47.556 ns | 0.0688 ns | 0.0610 ns | 0.0076 |      32 B |
             ToEnum | 30.067 ns | 0.0054 ns | 0.0045 ns | 0.0057 |      24 B |
