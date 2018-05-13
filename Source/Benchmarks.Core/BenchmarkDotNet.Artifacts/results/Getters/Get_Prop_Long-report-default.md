
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  1.293 ns | 0.0006 ns | 0.0004 ns |      - |       0 B |
     ToBoolNullable |  4.472 ns | 0.0027 ns | 0.0025 ns |      - |       0 B |
             ToChar |  3.085 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
     ToCharNullable |  5.250 ns | 0.0080 ns | 0.0075 ns |      - |       0 B |
            ToSByte |  3.080 ns | 0.0039 ns | 0.0037 ns |      - |       0 B |
    ToSByteNullable |  5.240 ns | 0.0043 ns | 0.0041 ns |      - |       0 B |
             ToByte |  3.091 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
     ToByteNullable |  5.263 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
            ToShort |  3.081 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
    ToShortNullable |  5.256 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
           ToUShort |  3.081 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
   ToUShortNullable |  5.248 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
              ToInt |  3.085 ns | 0.0064 ns | 0.0060 ns |      - |       0 B |
      ToIntNullable |  5.245 ns | 0.0111 ns | 0.0099 ns |      - |       0 B |
             ToUInt |  3.067 ns | 0.0041 ns | 0.0038 ns |      - |       0 B |
     ToUIntNullable |  5.243 ns | 0.0122 ns | 0.0115 ns |      - |       0 B |
             ToLong |  1.279 ns | 0.0026 ns | 0.0025 ns |      - |       0 B |
     ToLongNullable |  2.553 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
            ToULong |  2.057 ns | 0.0314 ns | 0.0278 ns |      - |       0 B |
    ToULongNullable |  3.337 ns | 0.0064 ns | 0.0056 ns |      - |       0 B |
            ToFloat |  1.267 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
    ToFloatNullable |  4.660 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
           ToDouble |  1.280 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
   ToDoubleNullable |  2.554 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
          ToDecimal | 11.896 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |
  ToDecimalNullable | 18.762 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
         ToDateTime |  3.070 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
 ToDateTimeNullable |  8.800 ns | 0.0072 ns | 0.0060 ns |      - |       0 B |
           ToObject |  3.851 ns | 0.0067 ns | 0.0059 ns | 0.0057 |      24 B |
          To_String | 44.086 ns | 0.0198 ns | 0.0155 ns | 0.0076 |      32 B |
             ToEnum | 12.194 ns | 0.0186 ns | 0.0174 ns |      - |       0 B |
     ToEnumNullable | 18.067 ns | 0.0214 ns | 0.0200 ns |      - |       0 B |
