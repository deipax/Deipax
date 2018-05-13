
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  1.297 ns | 0.0034 ns | 0.0032 ns |      - |       0 B |
     ToBoolNullable |  4.469 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
             ToChar |  2.046 ns | 0.0033 ns | 0.0026 ns |      - |       0 B |
     ToCharNullable |  4.709 ns | 0.0031 ns | 0.0027 ns |      - |       0 B |
            ToSByte |  2.060 ns | 0.0020 ns | 0.0018 ns |      - |       0 B |
    ToSByteNullable |  4.941 ns | 0.0024 ns | 0.0023 ns |      - |       0 B |
             ToByte |  2.059 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
     ToByteNullable |  4.710 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
            ToShort |  3.081 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
    ToShortNullable |  5.237 ns | 0.0033 ns | 0.0031 ns |      - |       0 B |
           ToUShort |  2.057 ns | 0.0090 ns | 0.0080 ns |      - |       0 B |
   ToUShortNullable |  4.710 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
              ToInt |  1.809 ns | 0.0049 ns | 0.0046 ns |      - |       0 B |
      ToIntNullable |  4.708 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
             ToUInt |  1.277 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
     ToUIntNullable |  4.466 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
             ToLong |  1.272 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
     ToLongNullable |  2.812 ns | 0.0040 ns | 0.0037 ns |      - |       0 B |
            ToULong |  1.278 ns | 0.0017 ns | 0.0016 ns |      - |       0 B |
    ToULongNullable |  2.558 ns | 0.0053 ns | 0.0050 ns |      - |       0 B |
            ToFloat |  1.535 ns | 0.0052 ns | 0.0048 ns |      - |       0 B |
    ToFloatNullable |  4.751 ns | 0.0003 ns | 0.0003 ns |      - |       0 B |
           ToDouble |  1.533 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
   ToDoubleNullable |  2.555 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
          ToDecimal |  7.775 ns | 0.0040 ns | 0.0037 ns |      - |       0 B |
  ToDecimalNullable | 18.500 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
         ToDateTime |  3.076 ns | 0.0039 ns | 0.0036 ns |      - |       0 B |
 ToDateTimeNullable |  8.906 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
           ToObject |  3.813 ns | 0.0062 ns | 0.0058 ns | 0.0057 |      24 B |
          To_String | 37.571 ns | 0.0412 ns | 0.0344 ns | 0.0076 |      32 B |
             ToEnum | 11.874 ns | 0.0143 ns | 0.0127 ns |      - |       0 B |
     ToEnumNullable | 17.476 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
