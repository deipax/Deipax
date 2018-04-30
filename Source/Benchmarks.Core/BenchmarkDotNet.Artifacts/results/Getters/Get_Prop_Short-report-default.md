
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.120 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
     ToBoolNullable |  6.530 ns | 0.0050 ns | 0.0042 ns |      - |       0 B |
             ToChar |  4.005 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
     ToCharNullable |  6.531 ns | 0.0071 ns | 0.0066 ns |      - |       0 B |
            ToSByte |  4.079 ns | 0.0060 ns | 0.0056 ns |      - |       0 B |
    ToSByteNullable |  7.300 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
             ToByte |  4.081 ns | 0.0028 ns | 0.0022 ns |      - |       0 B |
     ToByteNullable |  7.084 ns | 0.0461 ns | 0.0431 ns |      - |       0 B |
            ToShort |  1.263 ns | 0.0026 ns | 0.0024 ns |      - |       0 B |
    ToShortNullable |  4.489 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
           ToUShort |  3.730 ns | 0.0053 ns | 0.0047 ns |      - |       0 B |
   ToUShortNullable |  6.544 ns | 0.0047 ns | 0.0044 ns |      - |       0 B |
              ToInt |  3.053 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
      ToIntNullable |  6.539 ns | 0.0046 ns | 0.0038 ns |      - |       0 B |
             ToUInt |  3.898 ns | 0.0080 ns | 0.0066 ns |      - |       0 B |
     ToUIntNullable |  6.545 ns | 0.0074 ns | 0.0069 ns |      - |       0 B |
             ToLong |  3.070 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
     ToLongNullable |  5.891 ns | 0.0047 ns | 0.0042 ns |      - |       0 B |
            ToULong |  4.116 ns | 0.0049 ns | 0.0044 ns |      - |       0 B |
    ToULongNullable |  6.402 ns | 0.0058 ns | 0.0054 ns |      - |       0 B |
            ToFloat |  3.072 ns | 0.0057 ns | 0.0050 ns |      - |       0 B |
    ToFloatNullable |  6.534 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
           ToDouble |  3.230 ns | 0.0053 ns | 0.0050 ns |      - |       0 B |
   ToDoubleNullable |  5.908 ns | 0.0060 ns | 0.0056 ns |      - |       0 B |
          ToDecimal |  6.395 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
  ToDecimalNullable | 15.735 ns | 0.0085 ns | 0.0080 ns |      - |       0 B |
         ToDateTime |  4.349 ns | 0.0051 ns | 0.0047 ns |      - |       0 B |
 ToDateTimeNullable |  5.995 ns | 0.0484 ns | 0.0452 ns |      - |       0 B |
           ToObject |  3.778 ns | 0.0030 ns | 0.0027 ns | 0.0057 |      24 B |
          To_String | 44.838 ns | 0.0250 ns | 0.0208 ns | 0.0076 |      32 B |
             ToEnum | 23.902 ns | 0.0376 ns | 0.0352 ns | 0.0057 |      24 B |
