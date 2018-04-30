
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.646 ns | 0.0154 ns | 0.0129 ns |      - |       0 B |
     ToBoolNullable |  6.797 ns | 0.0165 ns | 0.0154 ns |      - |       0 B |
             ToChar |  5.350 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
     ToCharNullable |  7.564 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
            ToSByte |  5.102 ns | 0.0047 ns | 0.0044 ns |      - |       0 B |
    ToSByteNullable |  7.566 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
             ToByte |  5.355 ns | 0.0042 ns | 0.0037 ns |      - |       0 B |
     ToByteNullable |  7.574 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
            ToShort |  5.359 ns | 0.0064 ns | 0.0060 ns |      - |       0 B |
    ToShortNullable |  7.558 ns | 0.0085 ns | 0.0080 ns |      - |       0 B |
           ToUShort |  5.352 ns | 0.0041 ns | 0.0038 ns |      - |       0 B |
   ToUShortNullable |  7.562 ns | 0.0086 ns | 0.0081 ns |      - |       0 B |
              ToInt |  3.565 ns | 0.0040 ns | 0.0038 ns |      - |       0 B |
      ToIntNullable |  6.532 ns | 0.0007 ns | 0.0007 ns |      - |       0 B |
             ToUInt |  4.206 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |
     ToUIntNullable |  6.802 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
             ToLong |  3.584 ns | 0.0065 ns | 0.0054 ns |      - |       0 B |
     ToLongNullable |  6.658 ns | 0.0108 ns | 0.0096 ns |      - |       0 B |
            ToULong |  4.133 ns | 0.0048 ns | 0.0042 ns |      - |       0 B |
    ToULongNullable |  7.672 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
            ToFloat |  3.612 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
    ToFloatNullable |  6.895 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
           ToDouble |  4.096 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
   ToDoubleNullable |  6.902 ns | 0.0055 ns | 0.0046 ns |      - |       0 B |
          ToDecimal |  6.931 ns | 0.0086 ns | 0.0081 ns |      - |       0 B |
  ToDecimalNullable | 16.242 ns | 0.0127 ns | 0.0118 ns |      - |       0 B |
         ToDateTime |  4.100 ns | 0.0045 ns | 0.0038 ns |      - |       0 B |
 ToDateTimeNullable |  6.135 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
           ToObject |  4.907 ns | 0.0031 ns | 0.0027 ns | 0.0057 |      24 B |
          To_String | 74.532 ns | 0.0638 ns | 0.0566 ns | 0.0057 |      24 B |
             ToEnum |  2.072 ns | 0.0027 ns | 0.0025 ns |      - |       0 B |
