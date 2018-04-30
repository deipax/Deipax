
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.650 ns | 0.0035 ns | 0.0032 ns |      - |       0 B |
     ToBoolNullable |  6.773 ns | 0.0074 ns | 0.0062 ns |      - |       0 B |
             ToChar |  4.113 ns | 0.0050 ns | 0.0046 ns |      - |       0 B |
     ToCharNullable |  6.776 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
            ToSByte |  4.134 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
    ToSByteNullable |  6.776 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
             ToByte |  4.234 ns | 0.0042 ns | 0.0037 ns |      - |       0 B |
     ToByteNullable |  6.772 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
            ToShort |  5.389 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
    ToShortNullable |  7.536 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
           ToUShort |  4.112 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
   ToUShortNullable |  6.769 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
              ToInt |  4.119 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
      ToIntNullable |  6.999 ns | 0.0608 ns | 0.0569 ns |      - |       0 B |
             ToUInt |  2.212 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
     ToUIntNullable |  1.533 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
             ToLong |  3.838 ns | 0.0047 ns | 0.0044 ns |      - |       0 B |
     ToLongNullable |  6.648 ns | 0.0113 ns | 0.0094 ns |      - |       0 B |
            ToULong |  3.844 ns | 0.0111 ns | 0.0103 ns |      - |       0 B |
    ToULongNullable |  6.646 ns | 0.0065 ns | 0.0061 ns |      - |       0 B |
            ToFloat |  4.076 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
    ToFloatNullable |  6.828 ns | 0.0120 ns | 0.0106 ns |      - |       0 B |
           ToDouble |  4.088 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
   ToDoubleNullable |  7.170 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
          ToDecimal |  6.641 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
  ToDecimalNullable | 15.960 ns | 0.0015 ns | 0.0014 ns |      - |       0 B |
         ToDateTime |  4.598 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
 ToDateTimeNullable |  6.395 ns | 0.0024 ns | 0.0022 ns |      - |       0 B |
           ToObject |  4.900 ns | 0.0053 ns | 0.0049 ns | 0.0057 |      24 B |
          To_String | 41.425 ns | 0.0122 ns | 0.0102 ns | 0.0076 |      32 B |
             ToEnum | 26.988 ns | 0.0220 ns | 0.0206 ns | 0.0057 |      24 B |
