
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   1.294 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
     ToBoolNullable |   4.811 ns | 0.0030 ns | 0.0028 ns |      - |       0 B |
             ToChar |   1.294 ns | 0.0020 ns | 0.0015 ns |      - |       0 B |
     ToCharNullable |   4.817 ns | 0.0443 ns | 0.0414 ns |      - |       0 B |
            ToSByte |   6.293 ns | 0.0189 ns | 0.0167 ns |      - |       0 B |
    ToSByteNullable |   7.321 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
             ToByte |   6.086 ns | 0.0046 ns | 0.0041 ns |      - |       0 B |
     ToByteNullable |   7.338 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
            ToShort |   6.153 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
    ToShortNullable |   7.364 ns | 0.0094 ns | 0.0083 ns |      - |       0 B |
           ToUShort |   6.165 ns | 0.0111 ns | 0.0098 ns |      - |       0 B |
   ToUShortNullable |   7.497 ns | 0.0051 ns | 0.0040 ns |      - |       0 B |
              ToInt |   4.099 ns | 0.0119 ns | 0.0099 ns |      - |       0 B |
      ToIntNullable |   6.500 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
             ToUInt |   4.078 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
     ToUIntNullable |   6.484 ns | 0.0067 ns | 0.0060 ns |      - |       0 B |
             ToLong |   4.926 ns | 0.0073 ns | 0.0065 ns |      - |       0 B |
     ToLongNullable |   6.900 ns | 0.0073 ns | 0.0069 ns |      - |       0 B |
            ToULong |   4.510 ns | 0.0118 ns | 0.0104 ns |      - |       0 B |
    ToULongNullable |   6.135 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
            ToFloat |   1.279 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
    ToFloatNullable |   4.471 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
           ToDouble |   1.278 ns | 0.0019 ns | 0.0018 ns |      - |       0 B |
   ToDoubleNullable |   2.561 ns | 0.0038 ns | 0.0033 ns |      - |       0 B |
          ToDecimal |  26.145 ns | 0.1358 ns | 0.1270 ns |      - |       0 B |
  ToDecimalNullable |  37.697 ns | 0.2948 ns | 0.2757 ns |      - |       0 B |
         ToDateTime |   3.069 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
 ToDateTimeNullable |   8.844 ns | 0.0143 ns | 0.0133 ns |      - |       0 B |
           ToObject |   3.816 ns | 0.0061 ns | 0.0057 ns | 0.0057 |      24 B |
          To_String | 218.823 ns | 0.2875 ns | 0.2549 ns | 0.0074 |      32 B |
             ToEnum |  13.250 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
     ToEnumNullable |  18.916 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
