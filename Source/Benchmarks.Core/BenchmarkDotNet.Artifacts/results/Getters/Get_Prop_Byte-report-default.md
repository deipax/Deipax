
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.151 ns | 0.0048 ns | 0.0044 ns |      - |       0 B |
     ToBoolNullable |  6.512 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
             ToChar |  3.305 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
     ToCharNullable |  6.509 ns | 0.0042 ns | 0.0035 ns |      - |       0 B |
            ToSByte |  3.629 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
    ToSByteNullable |  6.516 ns | 0.0055 ns | 0.0046 ns |      - |       0 B |
             ToByte |  1.296 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
     ToByteNullable |  4.477 ns | 0.0021 ns | 0.0020 ns |      - |       0 B |
            ToShort |  3.164 ns | 0.0087 ns | 0.0073 ns |      - |       0 B |
    ToShortNullable |  6.516 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
           ToUShort |  4.017 ns | 0.0077 ns | 0.0065 ns |      - |       0 B |
   ToUShortNullable |  6.512 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
              ToInt |  3.111 ns | 0.0492 ns | 0.0460 ns |      - |       0 B |
      ToIntNullable |  6.511 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
             ToUInt |  3.125 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
     ToUIntNullable |  6.513 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
             ToLong |  3.067 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
     ToLongNullable |  6.138 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
            ToULong |  3.076 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
    ToULongNullable |  6.142 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
            ToFloat |  3.074 ns | 0.0070 ns | 0.0065 ns |      - |       0 B |
    ToFloatNullable |  6.529 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
           ToDouble |  3.185 ns | 0.0067 ns | 0.0063 ns |      - |       0 B |
   ToDoubleNullable |  5.888 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
          ToDecimal |  6.651 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
  ToDecimalNullable | 15.987 ns | 0.0170 ns | 0.0159 ns |      - |       0 B |
         ToDateTime |  4.607 ns | 0.0115 ns | 0.0096 ns |      - |       0 B |
 ToDateTimeNullable |  6.164 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
           ToObject |  3.786 ns | 0.0056 ns | 0.0052 ns | 0.0057 |      24 B |
          To_String | 44.896 ns | 0.0235 ns | 0.0220 ns | 0.0076 |      32 B |
             ToEnum | 22.507 ns | 0.0259 ns | 0.0243 ns | 0.0057 |      24 B |
