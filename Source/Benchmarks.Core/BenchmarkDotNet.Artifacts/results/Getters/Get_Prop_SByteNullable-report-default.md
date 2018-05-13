
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  2.068 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
     ToBoolNullable |  4.983 ns | 0.0033 ns | 0.0031 ns |      - |       0 B |
             ToChar |  2.580 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
     ToCharNullable |  5.488 ns | 0.0025 ns | 0.0024 ns |      - |       0 B |
            ToSByte |  2.046 ns | 0.0016 ns | 0.0015 ns |      - |       0 B |
    ToSByteNullable |  1.277 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
             ToByte |  2.834 ns | 0.0027 ns | 0.0022 ns |      - |       0 B |
     ToByteNullable |  5.492 ns | 0.0019 ns | 0.0018 ns |      - |       0 B |
            ToShort |  2.066 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
    ToShortNullable |  4.787 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
           ToUShort |  2.835 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
   ToUShortNullable |  5.491 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
              ToInt |  2.064 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
      ToIntNullable |  5.306 ns | 0.1349 ns | 0.1800 ns |      - |       0 B |
             ToUInt |  2.821 ns | 0.0020 ns | 0.0019 ns |      - |       0 B |
     ToUIntNullable |  5.237 ns | 0.0029 ns | 0.0025 ns |      - |       0 B |
             ToLong |  2.049 ns | 0.0013 ns | 0.0012 ns |      - |       0 B |
     ToLongNullable |  3.323 ns | 0.0040 ns | 0.0036 ns |      - |       0 B |
            ToULong |  2.820 ns | 0.0026 ns | 0.0024 ns |      - |       0 B |
    ToULongNullable |  3.841 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
            ToFloat |  2.299 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
    ToFloatNullable |  5.429 ns | 0.1413 ns | 0.2027 ns |      - |       0 B |
           ToDouble |  2.371 ns | 0.0803 ns | 0.0925 ns |      - |       0 B |
   ToDoubleNullable |  3.331 ns | 0.0042 ns | 0.0039 ns |      - |       0 B |
          ToDecimal |  6.751 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
  ToDecimalNullable | 21.382 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
         ToDateTime |  3.065 ns | 0.0027 ns | 0.0025 ns |      - |       0 B |
 ToDateTimeNullable |  8.533 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
           ToObject |  4.889 ns | 0.0049 ns | 0.0043 ns | 0.0057 |      24 B |
          To_String | 43.173 ns | 0.0239 ns | 0.0212 ns | 0.0076 |      32 B |
             ToEnum | 14.643 ns | 0.0041 ns | 0.0037 ns |      - |       0 B |
     ToEnumNullable | 20.160 ns | 0.0093 ns | 0.0077 ns |      - |       0 B |
