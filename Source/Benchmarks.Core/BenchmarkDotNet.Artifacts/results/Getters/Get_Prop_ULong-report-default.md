
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.679 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
     ToBoolNullable |  6.501 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
             ToChar |  3.851 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
     ToCharNullable |  7.050 ns | 0.0057 ns | 0.0048 ns |      - |       0 B |
            ToSByte |  3.616 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
    ToSByteNullable |  6.523 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
             ToByte |  4.110 ns | 0.0046 ns | 0.0041 ns |      - |       0 B |
     ToByteNullable |  7.030 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
            ToShort |  4.108 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
    ToShortNullable |  7.296 ns | 0.0145 ns | 0.0135 ns |      - |       0 B |
           ToUShort |  4.110 ns | 0.0040 ns | 0.0036 ns |      - |       0 B |
   ToUShortNullable |  7.306 ns | 0.0101 ns | 0.0089 ns |      - |       0 B |
              ToInt |  4.106 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
      ToIntNullable |  7.420 ns | 0.0132 ns | 0.0110 ns |      - |       0 B |
             ToUInt |  3.831 ns | 0.0046 ns | 0.0041 ns |      - |       0 B |
     ToUIntNullable |  6.519 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
             ToLong |  3.607 ns | 0.0070 ns | 0.0059 ns |      - |       0 B |
     ToLongNullable |  7.156 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
            ToULong |  1.277 ns | 0.0003 ns | 0.0002 ns |      - |       0 B |
    ToULongNullable |  2.554 ns | 0.0003 ns | 0.0003 ns |      - |       0 B |
            ToFloat |  3.581 ns | 0.0048 ns | 0.0045 ns |      - |       0 B |
    ToFloatNullable |  6.518 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
           ToDouble |  3.582 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
   ToDoubleNullable |  6.648 ns | 0.0085 ns | 0.0079 ns |      - |       0 B |
          ToDecimal |  6.130 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
  ToDecimalNullable | 15.964 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
         ToDateTime |  4.599 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
 ToDateTimeNullable |  6.147 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
           ToObject |  3.774 ns | 0.0041 ns | 0.0039 ns | 0.0057 |      24 B |
          To_String | 44.660 ns | 0.0335 ns | 0.0297 ns | 0.0076 |      32 B |
             ToEnum | 23.885 ns | 0.0233 ns | 0.0218 ns | 0.0057 |      24 B |
