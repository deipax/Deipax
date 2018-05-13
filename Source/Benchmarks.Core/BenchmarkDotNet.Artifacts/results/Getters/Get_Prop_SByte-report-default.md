
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  1.264 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
     ToBoolNullable |  4.487 ns | 0.0041 ns | 0.0036 ns |      - |       0 B |
             ToChar |  2.034 ns | 0.0068 ns | 0.0063 ns |      - |       0 B |
     ToCharNullable |  4.730 ns | 0.0012 ns | 0.0011 ns |      - |       0 B |
            ToSByte |  1.263 ns | 0.0024 ns | 0.0023 ns |      - |       0 B |
    ToSByteNullable |  4.505 ns | 0.0023 ns | 0.0019 ns |      - |       0 B |
             ToByte |  2.028 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
     ToByteNullable |  4.730 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
            ToShort |  1.262 ns | 0.0016 ns | 0.0015 ns |      - |       0 B |
    ToShortNullable |  4.500 ns | 0.0033 ns | 0.0027 ns |      - |       0 B |
           ToUShort |  2.027 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
   ToUShortNullable |  4.731 ns | 0.0013 ns | 0.0012 ns |      - |       0 B |
              ToInt |  1.261 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
      ToIntNullable |  4.502 ns | 0.0026 ns | 0.0024 ns |      - |       0 B |
             ToUInt |  2.044 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
     ToUIntNullable |  4.731 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
             ToLong |  1.277 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
     ToLongNullable |  2.309 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
            ToULong |  2.042 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
    ToULongNullable |  3.066 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
            ToFloat |  1.534 ns | 0.0022 ns | 0.0021 ns |      - |       0 B |
    ToFloatNullable |  4.485 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
           ToDouble |  1.533 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
   ToDoubleNullable |  2.554 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
          ToDecimal |  7.792 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
  ToDecimalNullable | 18.525 ns | 0.0126 ns | 0.0118 ns |      - |       0 B |
         ToDateTime |  2.809 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
 ToDateTimeNullable |  8.321 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
           ToObject |  3.787 ns | 0.0016 ns | 0.0014 ns | 0.0057 |      24 B |
          To_String | 42.519 ns | 0.0675 ns | 0.0632 ns | 0.0076 |      32 B |
             ToEnum | 11.612 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
     ToEnumNullable | 17.438 ns | 0.0198 ns | 0.0186 ns |      - |       0 B |
