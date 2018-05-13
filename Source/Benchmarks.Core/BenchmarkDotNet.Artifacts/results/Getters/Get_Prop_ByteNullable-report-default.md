
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  2.049 ns | 0.0075 ns | 0.0063 ns |      - |       0 B |
     ToBoolNullable |  5.011 ns | 0.0131 ns | 0.0116 ns |      - |       0 B |
             ToChar |  2.045 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
     ToCharNullable |  4.928 ns | 0.0233 ns | 0.0218 ns |      - |       0 B |
            ToSByte |  2.555 ns | 0.0027 ns | 0.0023 ns |      - |       0 B |
    ToSByteNullable |  5.483 ns | 0.0153 ns | 0.0136 ns |      - |       0 B |
             ToByte |  2.114 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
     ToByteNullable |  1.284 ns | 0.0077 ns | 0.0064 ns |      - |       0 B |
            ToShort |  2.047 ns | 0.0028 ns | 0.0026 ns |      - |       0 B |
    ToShortNullable |  4.929 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
           ToUShort |  2.045 ns | 0.0022 ns | 0.0021 ns |      - |       0 B |
   ToUShortNullable |  4.928 ns | 0.0354 ns | 0.0331 ns |      - |       0 B |
              ToInt |  2.044 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
      ToIntNullable |  4.930 ns | 0.0029 ns | 0.0023 ns |      - |       0 B |
             ToUInt |  2.046 ns | 0.0023 ns | 0.0021 ns |      - |       0 B |
     ToUIntNullable |  4.969 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
             ToLong |  2.299 ns | 0.0039 ns | 0.0037 ns |      - |       0 B |
     ToLongNullable |  3.068 ns | 0.0052 ns | 0.0049 ns |      - |       0 B |
            ToULong |  2.045 ns | 0.0035 ns | 0.0032 ns |      - |       0 B |
    ToULongNullable |  3.068 ns | 0.0052 ns | 0.0048 ns |      - |       0 B |
            ToFloat |  2.302 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
    ToFloatNullable |  4.971 ns | 0.0013 ns | 0.0012 ns |      - |       0 B |
           ToDouble |  2.304 ns | 0.0020 ns | 0.0017 ns |      - |       0 B |
   ToDoubleNullable |  3.323 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
          ToDecimal |  8.059 ns | 0.0056 ns | 0.0053 ns |      - |       0 B |
  ToDecimalNullable | 20.803 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
         ToDateTime |  3.070 ns | 0.0014 ns | 0.0010 ns |      - |       0 B |
 ToDateTimeNullable |  8.798 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
           ToObject |  4.926 ns | 0.0135 ns | 0.0126 ns | 0.0057 |      24 B |
          To_String | 42.225 ns | 0.0584 ns | 0.0546 ns | 0.0076 |      32 B |
             ToEnum | 14.794 ns | 0.0106 ns | 0.0083 ns |      - |       0 B |
     ToEnumNullable | 20.192 ns | 0.0228 ns | 0.0213 ns |      - |       0 B |
