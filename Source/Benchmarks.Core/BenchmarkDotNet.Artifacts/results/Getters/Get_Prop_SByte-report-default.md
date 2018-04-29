
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.727 ns | 0.0027 ns | 0.0025 ns |      - |       0 B |
     ToBoolNullable |  6.784 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
             ToChar |  4.429 ns | 0.0056 ns | 0.0053 ns |      - |       0 B |
     ToCharNullable |  7.020 ns | 0.0174 ns | 0.0163 ns |      - |       0 B |
            ToSByte |  2.505 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
    ToSByteNullable |  4.709 ns | 0.0005 ns | 0.0005 ns |      - |       0 B |
             ToByte |  4.368 ns | 0.0074 ns | 0.0070 ns |      - |       0 B |
     ToByteNullable |  7.017 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
            ToShort |  3.850 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
    ToShortNullable |  6.792 ns | 0.0047 ns | 0.0039 ns |      - |       0 B |
           ToUShort |  4.498 ns | 0.0033 ns | 0.0029 ns |      - |       0 B |
   ToUShortNullable |  7.024 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
              ToInt |  3.849 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
      ToIntNullable |  6.778 ns | 0.0169 ns | 0.0159 ns |      - |       0 B |
             ToUInt |  4.346 ns | 0.0052 ns | 0.0049 ns |      - |       0 B |
     ToUIntNullable |  7.017 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
             ToLong |  3.837 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
     ToLongNullable |  6.132 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
            ToULong |  4.408 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
    ToULongNullable |  7.155 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
            ToFloat |  3.832 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
    ToFloatNullable |  6.768 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
           ToDouble |  3.836 ns | 0.0063 ns | 0.0058 ns |      - |       0 B |
   ToDoubleNullable |  6.132 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
          ToDecimal |  7.156 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
  ToDecimalNullable | 16.221 ns | 0.0090 ns | 0.0080 ns |      - |       0 B |
         ToDateTime |  5.367 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
 ToDateTimeNullable |  6.660 ns | 0.0067 ns | 0.0060 ns |      - |       0 B |
           ToObject |  4.538 ns | 0.0021 ns | 0.0015 ns | 0.0057 |      24 B |
          To_String | 46.832 ns | 0.0600 ns | 0.0561 ns | 0.0076 |      32 B |
             ToEnum | 23.530 ns | 0.0351 ns | 0.0311 ns | 0.0057 |      24 B |
