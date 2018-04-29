
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  4.431 ns | 0.0015 ns | 0.0014 ns |      - |       0 B |
     ToBoolNullable |  7.010 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
             ToChar |  6.147 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
     ToCharNullable |  7.550 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
            ToSByte |  5.891 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
    ToSByteNullable |  7.764 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
             ToByte |  6.147 ns | 0.0011 ns | 0.0010 ns |      - |       0 B |
     ToByteNullable |  7.700 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
            ToShort |  6.146 ns | 0.0011 ns | 0.0010 ns |      - |       0 B |
    ToShortNullable |  7.560 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
           ToUShort |  6.150 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
   ToUShortNullable |  7.546 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
              ToInt |  2.826 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
      ToIntNullable |  2.043 ns | 0.0064 ns | 0.0057 ns |      - |       0 B |
             ToUInt |  5.363 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
     ToUIntNullable |  7.274 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
             ToLong |  4.608 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
     ToLongNullable |  6.881 ns | 0.0068 ns | 0.0064 ns |      - |       0 B |
            ToULong |  5.368 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
    ToULongNullable |  7.665 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
            ToFloat |  4.602 ns | 0.0057 ns | 0.0054 ns |      - |       0 B |
    ToFloatNullable |  6.799 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
           ToDouble |  4.827 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
   ToDoubleNullable |  6.918 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
          ToDecimal |  8.194 ns | 0.0161 ns | 0.0143 ns |      - |       0 B |
  ToDecimalNullable | 16.772 ns | 0.0046 ns | 0.0041 ns |      - |       0 B |
         ToDateTime |  5.382 ns | 0.0158 ns | 0.0140 ns |      - |       0 B |
 ToDateTimeNullable |  6.658 ns | 0.0047 ns | 0.0044 ns |      - |       0 B |
           ToObject |  5.303 ns | 0.0013 ns | 0.0012 ns | 0.0057 |      24 B |
          To_String | 47.048 ns | 0.0063 ns | 0.0049 ns | 0.0076 |      32 B |
             ToEnum | 27.600 ns | 0.0194 ns | 0.0172 ns | 0.0057 |      24 B |
