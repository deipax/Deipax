
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  2.036 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
     ToBoolNullable |  4.751 ns | 0.0109 ns | 0.0097 ns |      - |       0 B |
             ToChar |  2.543 ns | 0.0055 ns | 0.0052 ns |      - |       0 B |
     ToCharNullable |  5.510 ns | 0.0037 ns | 0.0035 ns |      - |       0 B |
            ToSByte |  2.548 ns | 0.0041 ns | 0.0037 ns |      - |       0 B |
    ToSByteNullable |  5.511 ns | 0.0041 ns | 0.0037 ns |      - |       0 B |
             ToByte |  2.548 ns | 0.0047 ns | 0.0041 ns |      - |       0 B |
     ToByteNullable |  5.263 ns | 0.0142 ns | 0.0126 ns |      - |       0 B |
            ToShort |  3.815 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
    ToShortNullable |  6.030 ns | 0.0116 ns | 0.0084 ns |      - |       0 B |
           ToUShort |  2.538 ns | 0.0002 ns | 0.0002 ns |      - |       0 B |
   ToUShortNullable |  5.503 ns | 0.0040 ns | 0.0035 ns |      - |       0 B |
              ToInt |  2.540 ns | 0.0052 ns | 0.0044 ns |      - |       0 B |
      ToIntNullable |  5.259 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
             ToUInt |  2.057 ns | 0.0041 ns | 0.0038 ns |      - |       0 B |
     ToUIntNullable |  1.281 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
             ToLong |  2.045 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
     ToLongNullable |  3.332 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
            ToULong |  2.045 ns | 0.0028 ns | 0.0026 ns |      - |       0 B |
    ToULongNullable |  3.333 ns | 0.0039 ns | 0.0036 ns |      - |       0 B |
            ToFloat |  2.301 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
    ToFloatNullable |  5.023 ns | 0.0033 ns | 0.0031 ns |      - |       0 B |
           ToDouble |  2.303 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
   ToDoubleNullable |  3.070 ns | 0.0070 ns | 0.0065 ns |      - |       0 B |
          ToDecimal |  6.512 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
  ToDecimalNullable | 18.781 ns | 0.0132 ns | 0.0124 ns |      - |       0 B |
         ToDateTime |  2.810 ns | 0.0008 ns | 0.0008 ns |      - |       0 B |
 ToDateTimeNullable |  8.330 ns | 0.0129 ns | 0.0120 ns |      - |       0 B |
           ToObject |  4.928 ns | 0.0062 ns | 0.0058 ns | 0.0057 |      24 B |
          To_String | 38.051 ns | 0.0372 ns | 0.0330 ns | 0.0076 |      32 B |
             ToEnum | 14.553 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
     ToEnumNullable | 20.121 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
