
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.674 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
     ToBoolNullable |  6.800 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
             ToChar |  4.172 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
     ToCharNullable |  6.805 ns | 0.0270 ns | 0.0239 ns |      - |       0 B |
            ToSByte |  5.359 ns | 0.0066 ns | 0.0062 ns |      - |       0 B |
    ToSByteNullable |  7.551 ns | 0.0101 ns | 0.0095 ns |      - |       0 B |
             ToByte |  5.352 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
     ToByteNullable |  7.559 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
            ToShort |  2.046 ns | 0.0045 ns | 0.0037 ns |      - |       0 B |
    ToShortNullable |  1.278 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
           ToUShort |  4.588 ns | 0.0068 ns | 0.0063 ns |      - |       0 B |
   ToUShortNullable |  6.853 ns | 0.0694 ns | 0.0579 ns |      - |       0 B |
              ToInt |  3.831 ns | 0.0077 ns | 0.0068 ns |      - |       0 B |
      ToIntNullable |  6.555 ns | 0.0354 ns | 0.0295 ns |      - |       0 B |
             ToUInt |  4.595 ns | 0.0060 ns | 0.0050 ns |      - |       0 B |
     ToUIntNullable |  6.808 ns | 0.0132 ns | 0.0117 ns |      - |       0 B |
             ToLong |  3.854 ns | 0.0175 ns | 0.0164 ns |      - |       0 B |
     ToLongNullable |  6.689 ns | 0.0177 ns | 0.0148 ns |      - |       0 B |
            ToULong |  4.648 ns | 0.0517 ns | 0.0483 ns |      - |       0 B |
    ToULongNullable |  7.161 ns | 0.0103 ns | 0.0081 ns |      - |       0 B |
            ToFloat |  3.839 ns | 0.0069 ns | 0.0054 ns |      - |       0 B |
    ToFloatNullable |  6.842 ns | 0.0726 ns | 0.0679 ns |      - |       0 B |
           ToDouble |  4.108 ns | 0.0233 ns | 0.0206 ns |      - |       0 B |
   ToDoubleNullable |  6.706 ns | 0.0472 ns | 0.0442 ns |      - |       0 B |
          ToDecimal |  7.178 ns | 0.0148 ns | 0.0131 ns |      - |       0 B |
  ToDecimalNullable | 16.497 ns | 0.0148 ns | 0.0131 ns |      - |       0 B |
         ToDateTime |  4.354 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
 ToDateTimeNullable |  6.169 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
           ToObject |  4.895 ns | 0.0139 ns | 0.0130 ns | 0.0057 |      24 B |
          To_String | 45.675 ns | 0.1115 ns | 0.0931 ns | 0.0076 |      32 B |
             ToEnum | 27.466 ns | 0.1171 ns | 0.1038 ns | 0.0057 |      24 B |
