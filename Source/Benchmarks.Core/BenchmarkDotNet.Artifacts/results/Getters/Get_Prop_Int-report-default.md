
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.029 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
     ToBoolNullable |  6.593 ns | 0.0579 ns | 0.0513 ns |      - |       0 B |
             ToChar |  4.132 ns | 0.0791 ns | 0.0702 ns |      - |       0 B |
     ToCharNullable |  7.309 ns | 0.0114 ns | 0.0095 ns |      - |       0 B |
            ToSByte |  3.936 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
    ToSByteNullable |  7.297 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
             ToByte |  4.074 ns | 0.0041 ns | 0.0036 ns |      - |       0 B |
     ToByteNullable |  7.040 ns | 0.0082 ns | 0.0064 ns |      - |       0 B |
            ToShort |  4.083 ns | 0.0063 ns | 0.0056 ns |      - |       0 B |
    ToShortNullable |  7.886 ns | 0.0106 ns | 0.0089 ns |      - |       0 B |
           ToUShort |  4.082 ns | 0.0045 ns | 0.0037 ns |      - |       0 B |
   ToUShortNullable |  7.310 ns | 0.0229 ns | 0.0214 ns |      - |       0 B |
              ToInt |  1.264 ns | 0.0026 ns | 0.0024 ns |      - |       0 B |
      ToIntNullable |  4.487 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
             ToUInt |  4.028 ns | 0.0061 ns | 0.0051 ns |      - |       0 B |
     ToUIntNullable |  6.534 ns | 0.0067 ns | 0.0062 ns |      - |       0 B |
             ToLong |  3.068 ns | 0.0056 ns | 0.0052 ns |      - |       0 B |
     ToLongNullable |  5.640 ns | 0.0128 ns | 0.0114 ns |      - |       0 B |
            ToULong |  3.668 ns | 0.0019 ns | 0.0018 ns |      - |       0 B |
    ToULongNullable |  6.658 ns | 0.0185 ns | 0.0154 ns |      - |       0 B |
            ToFloat |  3.461 ns | 0.0044 ns | 0.0041 ns |      - |       0 B |
    ToFloatNullable |  6.556 ns | 0.0330 ns | 0.0293 ns |      - |       0 B |
           ToDouble |  3.210 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
   ToDoubleNullable |  5.904 ns | 0.0113 ns | 0.0094 ns |      - |       0 B |
          ToDecimal |  6.413 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
  ToDecimalNullable | 15.738 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
         ToDateTime |  4.372 ns | 0.0121 ns | 0.0108 ns |      - |       0 B |
 ToDateTimeNullable |  5.942 ns | 0.0191 ns | 0.0169 ns |      - |       0 B |
           ToObject |  3.852 ns | 0.0260 ns | 0.0230 ns | 0.0057 |      24 B |
          To_String | 44.824 ns | 0.0281 ns | 0.0249 ns | 0.0076 |      32 B |
             ToEnum | 26.465 ns | 0.0732 ns | 0.0685 ns | 0.0057 |      24 B |
