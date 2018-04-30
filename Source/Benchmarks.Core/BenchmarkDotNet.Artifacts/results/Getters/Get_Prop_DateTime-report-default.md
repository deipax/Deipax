
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   3.063 ns | 0.0018 ns | 0.0017 ns |      - |       0 B |
     ToBoolNullable |   6.768 ns | 0.0038 ns | 0.0036 ns |      - |       0 B |
             ToChar |   3.087 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
     ToCharNullable |   6.771 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
            ToSByte |   3.155 ns | 0.0038 ns | 0.0032 ns |      - |       0 B |
    ToSByteNullable |   6.768 ns | 0.0028 ns | 0.0024 ns |      - |       0 B |
             ToByte |   3.246 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
     ToByteNullable |   6.767 ns | 0.0052 ns | 0.0046 ns |      - |       0 B |
            ToShort |   3.064 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
    ToShortNullable |   6.770 ns | 0.0042 ns | 0.0039 ns |      - |       0 B |
           ToUShort |   3.106 ns | 0.0063 ns | 0.0056 ns |      - |       0 B |
   ToUShortNullable |   6.770 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
              ToInt |   3.494 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
      ToIntNullable |   6.775 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
             ToUInt |   3.209 ns | 0.0023 ns | 0.0022 ns |      - |       0 B |
     ToUIntNullable |   6.828 ns | 0.0752 ns | 0.0703 ns |      - |       0 B |
             ToLong |   3.045 ns | 0.0040 ns | 0.0036 ns |      - |       0 B |
     ToLongNullable |   6.391 ns | 0.0085 ns | 0.0076 ns |      - |       0 B |
            ToULong |   3.056 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
    ToULongNullable |   6.137 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
            ToFloat |   3.206 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
    ToFloatNullable |   6.770 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
           ToDouble |   3.217 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
   ToDoubleNullable |   6.391 ns | 0.0086 ns | 0.0081 ns |      - |       0 B |
          ToDecimal |   6.192 ns | 0.0090 ns | 0.0085 ns |      - |       0 B |
  ToDecimalNullable |   6.394 ns | 0.0125 ns | 0.0117 ns |      - |       0 B |
         ToDateTime |   1.532 ns | 0.0004 ns | 0.0004 ns |      - |       0 B |
 ToDateTimeNullable |   8.042 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
           ToObject |   3.753 ns | 0.0028 ns | 0.0026 ns | 0.0057 |      24 B |
          To_String | 425.166 ns | 0.8739 ns | 0.7747 ns | 0.0401 |     168 B |
             ToEnum |  20.912 ns | 0.0068 ns | 0.0064 ns | 0.0057 |      24 B |
