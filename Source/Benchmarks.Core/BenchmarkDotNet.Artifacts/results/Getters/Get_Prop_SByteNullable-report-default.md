
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.852 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
     ToBoolNullable |  6.794 ns | 0.0120 ns | 0.0100 ns |      - |       0 B |
             ToChar |  4.173 ns | 0.0032 ns | 0.0029 ns |      - |       0 B |
     ToCharNullable |  6.793 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |
            ToSByte |  2.102 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
    ToSByteNullable |  1.293 ns | 0.0396 ns | 0.0330 ns |      - |       0 B |
             ToByte |  4.592 ns | 0.0033 ns | 0.0027 ns |      - |       0 B |
     ToByteNullable |  6.788 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
            ToShort |  3.823 ns | 0.0056 ns | 0.0053 ns |      - |       0 B |
    ToShortNullable |  6.528 ns | 0.0087 ns | 0.0082 ns |      - |       0 B |
           ToUShort |  4.585 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
   ToUShortNullable |  6.781 ns | 0.0055 ns | 0.0052 ns |      - |       0 B |
              ToInt |  3.823 ns | 0.0033 ns | 0.0029 ns |      - |       0 B |
      ToIntNullable |  6.528 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
             ToUInt |  5.763 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
     ToUIntNullable |  6.793 ns | 0.0040 ns | 0.0037 ns |      - |       0 B |
             ToLong |  3.837 ns | 0.0053 ns | 0.0047 ns |      - |       0 B |
     ToLongNullable |  6.436 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |
            ToULong |  4.606 ns | 0.0094 ns | 0.0079 ns |      - |       0 B |
    ToULongNullable |  7.156 ns | 0.0021 ns | 0.0017 ns |      - |       0 B |
            ToFloat |  3.835 ns | 0.0044 ns | 0.0041 ns |      - |       0 B |
    ToFloatNullable |  6.792 ns | 0.0092 ns | 0.0082 ns |      - |       0 B |
           ToDouble |  4.089 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
   ToDoubleNullable |  6.644 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
          ToDecimal |  7.409 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
  ToDecimalNullable | 20.836 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
         ToDateTime |  4.345 ns | 0.0047 ns | 0.0044 ns |      - |       0 B |
 ToDateTimeNullable |  5.916 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
           ToObject |  4.856 ns | 0.0015 ns | 0.0014 ns | 0.0057 |      24 B |
          To_String | 45.396 ns | 0.0700 ns | 0.0654 ns | 0.0076 |      32 B |
             ToEnum | 27.337 ns | 0.0294 ns | 0.0275 ns | 0.0057 |      24 B |
