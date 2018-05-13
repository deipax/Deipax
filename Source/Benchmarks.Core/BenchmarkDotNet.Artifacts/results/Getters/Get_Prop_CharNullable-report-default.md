
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  1.262 ns | 0.0014 ns | 0.0013 ns |      - |       0 B |
     ToBoolNullable |  4.490 ns | 0.0128 ns | 0.0119 ns |      - |       0 B |
             ToChar |  2.041 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
     ToCharNullable |  1.283 ns | 0.0069 ns | 0.0061 ns |      - |       0 B |
            ToSByte |  2.798 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
    ToSByteNullable |  5.289 ns | 0.0047 ns | 0.0034 ns |      - |       0 B |
             ToByte |  2.539 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
     ToByteNullable |  5.281 ns | 0.0133 ns | 0.0117 ns |      - |       0 B |
            ToShort |  2.541 ns | 0.0037 ns | 0.0035 ns |      - |       0 B |
    ToShortNullable |  5.509 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
           ToUShort |  2.028 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
   ToUShortNullable |  4.889 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
              ToInt |  2.028 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
      ToIntNullable |  5.502 ns | 0.0621 ns | 0.0551 ns |      - |       0 B |
             ToUInt |  2.040 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
     ToUIntNullable |  5.034 ns | 0.1449 ns | 0.1356 ns |      - |       0 B |
             ToLong |  2.045 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
     ToLongNullable |  2.810 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
            ToULong |  2.044 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
    ToULongNullable |  2.810 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
            ToFloat |  1.284 ns | 0.0119 ns | 0.0106 ns |      - |       0 B |
    ToFloatNullable |  4.484 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
           ToDouble |  1.279 ns | 0.0023 ns | 0.0021 ns |      - |       0 B |
   ToDoubleNullable |  2.299 ns | 0.0004 ns | 0.0004 ns |      - |       0 B |
          ToDecimal |  2.811 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
  ToDecimalNullable |  2.298 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
         ToDateTime |  2.813 ns | 0.0041 ns | 0.0039 ns |      - |       0 B |
 ToDateTimeNullable |  8.381 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
           ToObject |  4.903 ns | 0.0069 ns | 0.0065 ns | 0.0057 |      24 B |
          To_String |  6.082 ns | 0.0069 ns | 0.0058 ns | 0.0076 |      32 B |
             ToEnum | 14.813 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
     ToEnumNullable | 20.180 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
