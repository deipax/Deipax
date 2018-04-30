
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.896 ns | 0.0017 ns | 0.0016 ns |      - |       0 B |
     ToBoolNullable |  6.775 ns | 0.0113 ns | 0.0101 ns |      - |       0 B |
             ToChar |  4.192 ns | 0.0027 ns | 0.0025 ns |      - |       0 B |
     ToCharNullable |  6.579 ns | 0.0803 ns | 0.0712 ns |      - |       0 B |
            ToSByte |  4.384 ns | 0.0049 ns | 0.0046 ns |      - |       0 B |
    ToSByteNullable |  6.780 ns | 0.0100 ns | 0.0084 ns |      - |       0 B |
             ToByte |  2.229 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
     ToByteNullable |  1.279 ns | 0.0027 ns | 0.0025 ns |      - |       0 B |
            ToShort |  3.852 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
    ToShortNullable |  6.522 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
           ToUShort |  3.907 ns | 0.0098 ns | 0.0081 ns |      - |       0 B |
   ToUShortNullable |  6.520 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
              ToInt |  3.854 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
      ToIntNullable |  6.522 ns | 0.0046 ns | 0.0041 ns |      - |       0 B |
             ToUInt |  3.831 ns | 0.0048 ns | 0.0045 ns |      - |       0 B |
     ToUIntNullable |  6.517 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
             ToLong |  3.837 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
     ToLongNullable |  6.414 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
            ToULong |  3.856 ns | 0.0288 ns | 0.0240 ns |      - |       0 B |
    ToULongNullable |  6.436 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
            ToFloat |  3.836 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
    ToFloatNullable |  6.775 ns | 0.0074 ns | 0.0069 ns |      - |       0 B |
           ToDouble |  4.321 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
   ToDoubleNullable |  6.899 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
          ToDecimal |  7.415 ns | 0.0074 ns | 0.0062 ns |      - |       0 B |
  ToDecimalNullable | 16.215 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
         ToDateTime |  4.605 ns | 0.0074 ns | 0.0066 ns |      - |       0 B |
 ToDateTimeNullable |  6.393 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
           ToObject |  4.854 ns | 0.0020 ns | 0.0017 ns | 0.0057 |      24 B |
          To_String | 46.543 ns | 0.0101 ns | 0.0090 ns | 0.0076 |      32 B |
             ToEnum | 27.677 ns | 0.0107 ns | 0.0083 ns | 0.0057 |      24 B |
