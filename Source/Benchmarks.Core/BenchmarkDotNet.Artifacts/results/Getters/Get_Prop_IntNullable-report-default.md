
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  2.029 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
     ToBoolNullable |  4.752 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
             ToChar |  3.818 ns | 0.0031 ns | 0.0027 ns |      - |       0 B |
     ToCharNullable |  6.047 ns | 0.0059 ns | 0.0042 ns |      - |       0 B |
            ToSByte |  3.566 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
    ToSByteNullable |  6.035 ns | 0.0045 ns | 0.0033 ns |      - |       0 B |
             ToByte |  3.818 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
     ToByteNullable |  6.071 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
            ToShort |  3.817 ns | 0.0029 ns | 0.0027 ns |      - |       0 B |
    ToShortNullable |  6.023 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
           ToUShort |  3.818 ns | 0.0032 ns | 0.0030 ns |      - |       0 B |
   ToUShortNullable |  6.031 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
              ToInt |  2.078 ns | 0.0004 ns | 0.0004 ns |      - |       0 B |
      ToIntNullable |  1.287 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
             ToUInt |  2.814 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
     ToUIntNullable |  5.258 ns | 0.0130 ns | 0.0108 ns |      - |       0 B |
             ToLong |  2.045 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
     ToLongNullable |  3.321 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
            ToULong |  2.813 ns | 0.0013 ns | 0.0012 ns |      - |       0 B |
    ToULongNullable |  3.582 ns | 0.0085 ns | 0.0080 ns |      - |       0 B |
            ToFloat |  2.037 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
    ToFloatNullable |  4.815 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
           ToDouble |  2.048 ns | 0.0074 ns | 0.0069 ns |      - |       0 B |
   ToDoubleNullable |  3.321 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
          ToDecimal |  6.766 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
  ToDecimalNullable | 21.077 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
         ToDateTime |  2.811 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
 ToDateTimeNullable |  8.322 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
           ToObject |  4.874 ns | 0.0072 ns | 0.0067 ns | 0.0057 |      24 B |
          To_String | 43.602 ns | 0.0859 ns | 0.0804 ns | 0.0076 |      32 B |
             ToEnum | 14.837 ns | 0.0227 ns | 0.0212 ns |      - |       0 B |
     ToEnumNullable | 20.163 ns | 0.0047 ns | 0.0036 ns |      - |       0 B |
