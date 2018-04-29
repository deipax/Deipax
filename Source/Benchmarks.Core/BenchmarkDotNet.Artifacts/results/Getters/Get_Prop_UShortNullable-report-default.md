
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  4.441 ns | 0.0119 ns | 0.0112 ns |      - |       0 B |
     ToBoolNullable |  6.778 ns | 0.0041 ns | 0.0038 ns |      - |       0 B |
             ToChar |  4.362 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
     ToCharNullable |  6.776 ns | 0.0074 ns | 0.0062 ns |      - |       0 B |
            ToSByte |  4.927 ns | 0.0034 ns | 0.0032 ns |      - |       0 B |
    ToSByteNullable |  7.263 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
             ToByte |  4.877 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
     ToByteNullable |  7.263 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
            ToShort |  4.875 ns | 0.0068 ns | 0.0064 ns |      - |       0 B |
    ToShortNullable |  7.262 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
           ToUShort |  2.825 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
   ToUShortNullable |  1.789 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
              ToInt |  4.622 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
      ToIntNullable |  6.778 ns | 0.0155 ns | 0.0145 ns |      - |       0 B |
             ToUInt |  4.613 ns | 0.0052 ns | 0.0049 ns |      - |       0 B |
     ToUIntNullable |  6.773 ns | 0.0072 ns | 0.0068 ns |      - |       0 B |
             ToLong |  4.598 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
     ToLongNullable |  6.642 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
            ToULong |  4.590 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
    ToULongNullable |  6.899 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
            ToFloat |  4.611 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
    ToFloatNullable |  7.027 ns | 0.0011 ns | 0.0010 ns |      - |       0 B |
           ToDouble |  4.601 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
   ToDoubleNullable |  7.154 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
          ToDecimal |  8.179 ns | 0.0094 ns | 0.0083 ns |      - |       0 B |
  ToDecimalNullable | 16.469 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
         ToDateTime |  5.380 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
 ToDateTimeNullable |  6.648 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
           ToObject |  5.297 ns | 0.0028 ns | 0.0026 ns | 0.0057 |      24 B |
          To_String | 41.446 ns | 0.0094 ns | 0.0079 ns | 0.0076 |      32 B |
             ToEnum | 28.240 ns | 0.0187 ns | 0.0175 ns | 0.0057 |      24 B |
