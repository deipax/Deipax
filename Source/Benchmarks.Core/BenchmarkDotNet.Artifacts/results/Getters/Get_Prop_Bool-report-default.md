
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  1.260 ns | 0.0001 ns | 0.0001 ns |      - |       0 B |
     ToBoolNullable |  4.481 ns | 0.0015 ns | 0.0014 ns |      - |       0 B |
             ToChar |  1.261 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
     ToCharNullable |  4.484 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
            ToSByte |  1.772 ns | 0.0051 ns | 0.0042 ns |      - |       0 B |
    ToSByteNullable |  4.481 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
             ToByte |  1.763 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
     ToByteNullable |  4.481 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
            ToShort |  1.771 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
    ToShortNullable |  4.481 ns | 0.0006 ns | 0.0004 ns |      - |       0 B |
           ToUShort |  1.772 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
   ToUShortNullable |  4.481 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
              ToInt |  1.771 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
      ToIntNullable |  4.482 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
             ToUInt |  1.787 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
     ToUIntNullable |  4.481 ns | 0.0004 ns | 0.0004 ns |      - |       0 B |
             ToLong |  1.785 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
     ToLongNullable |  3.065 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
            ToULong |  1.789 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
    ToULongNullable |  3.061 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
            ToFloat |  1.787 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
    ToFloatNullable |  4.741 ns | 0.0017 ns | 0.0016 ns |      - |       0 B |
           ToDouble |  1.782 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
   ToDoubleNullable |  3.063 ns | 0.0019 ns | 0.0018 ns |      - |       0 B |
          ToDecimal |  6.514 ns | 0.0056 ns | 0.0053 ns |      - |       0 B |
  ToDecimalNullable | 20.546 ns | 0.0070 ns | 0.0066 ns |      - |       0 B |
         ToDateTime |  2.552 ns | 0.0042 ns | 0.0040 ns |      - |       0 B |
 ToDateTimeNullable |  8.260 ns | 0.0051 ns | 0.0046 ns |      - |       0 B |
           ToObject |  3.789 ns | 0.0076 ns | 0.0072 ns | 0.0057 |      24 B |
          To_String |  4.083 ns | 0.0026 ns | 0.0025 ns |      - |       0 B |
             ToEnum | 11.623 ns | 0.0271 ns | 0.0240 ns |      - |       0 B |
     ToEnumNullable | 17.437 ns | 0.0065 ns | 0.0061 ns |      - |       0 B |
