
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.031 ns | 0.0028 ns | 0.0022 ns |      - |       0 B |
     ToBoolNullable |  6.514 ns | 0.0055 ns | 0.0052 ns |      - |       0 B |
             ToChar |  4.109 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
     ToCharNullable |  7.278 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
            ToSByte |  4.113 ns | 0.0053 ns | 0.0049 ns |      - |       0 B |
    ToSByteNullable |  7.283 ns | 0.0068 ns | 0.0063 ns |      - |       0 B |
             ToByte |  4.110 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
     ToByteNullable |  7.026 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
            ToShort |  4.113 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
    ToShortNullable |  7.299 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
           ToUShort |  4.113 ns | 0.0065 ns | 0.0061 ns |      - |       0 B |
   ToUShortNullable |  7.270 ns | 0.0022 ns | 0.0018 ns |      - |       0 B |
              ToInt |  4.119 ns | 0.0061 ns | 0.0058 ns |      - |       0 B |
      ToIntNullable |  7.231 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
             ToUInt |  4.100 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
     ToUIntNullable |  7.023 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
             ToLong |  1.278 ns | 0.0014 ns | 0.0013 ns |      - |       0 B |
     ToLongNullable |  2.560 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
            ToULong |  3.602 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |
    ToULongNullable |  6.650 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
            ToFloat |  3.528 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
    ToFloatNullable |  6.540 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
           ToDouble |  3.186 ns | 0.0097 ns | 0.0091 ns |      - |       0 B |
   ToDoubleNullable |  6.172 ns | 0.0106 ns | 0.0100 ns |      - |       0 B |
          ToDecimal |  6.650 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
  ToDecimalNullable | 15.986 ns | 0.0138 ns | 0.0129 ns |      - |       0 B |
         ToDateTime |  4.603 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
 ToDateTimeNullable |  6.438 ns | 0.0082 ns | 0.0073 ns |      - |       0 B |
           ToObject |  3.796 ns | 0.0083 ns | 0.0074 ns | 0.0057 |      24 B |
          To_String | 46.514 ns | 0.0278 ns | 0.0246 ns | 0.0076 |      32 B |
             ToEnum | 23.919 ns | 0.0177 ns | 0.0166 ns | 0.0057 |      24 B |
