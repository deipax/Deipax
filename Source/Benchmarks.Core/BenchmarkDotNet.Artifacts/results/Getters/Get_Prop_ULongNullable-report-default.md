
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  4.955 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
     ToBoolNullable |  7.026 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
             ToChar |  5.643 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
     ToCharNullable |  7.553 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
            ToSByte |  4.669 ns | 0.0045 ns | 0.0037 ns |      - |       0 B |
    ToSByteNullable |  7.027 ns | 0.0035 ns | 0.0030 ns |      - |       0 B |
             ToByte |  5.894 ns | 0.0038 ns | 0.0032 ns |      - |       0 B |
     ToByteNullable |  7.535 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
            ToShort |  5.893 ns | 0.0034 ns | 0.0030 ns |      - |       0 B |
    ToShortNullable |  7.541 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
           ToUShort |  5.895 ns | 0.0025 ns | 0.0019 ns |      - |       0 B |
   ToUShortNullable |  7.536 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
              ToInt |  5.900 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
      ToIntNullable |  7.536 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
             ToUInt |  4.857 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
     ToUIntNullable |  6.769 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
             ToLong |  4.618 ns | 0.0038 ns | 0.0031 ns |      - |       0 B |
     ToLongNullable |  7.664 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
            ToULong |  2.020 ns | 0.0025 ns | 0.0024 ns |      - |       0 B |
    ToULongNullable |  2.555 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
            ToFloat |  5.203 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
    ToFloatNullable |  7.040 ns | 0.0072 ns | 0.0068 ns |      - |       0 B |
           ToDouble |  4.955 ns | 0.0039 ns | 0.0034 ns |      - |       0 B |
   ToDoubleNullable |  7.411 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
          ToDecimal |  6.909 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
  ToDecimalNullable | 16.029 ns | 0.0564 ns | 0.0528 ns |      - |       0 B |
         ToDateTime |  5.110 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
 ToDateTimeNullable |  6.656 ns | 0.0020 ns | 0.0018 ns |      - |       0 B |
           ToObject |  4.922 ns | 0.0060 ns | 0.0056 ns | 0.0057 |      24 B |
          To_String | 44.595 ns | 0.0351 ns | 0.0293 ns | 0.0076 |      32 B |
             ToEnum | 29.557 ns | 0.0072 ns | 0.0067 ns | 0.0057 |      24 B |
