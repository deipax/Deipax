
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.640 ns | 0.0023 ns | 0.0022 ns |      - |       0 B |
     ToBoolNullable |  6.776 ns | 0.0090 ns | 0.0070 ns |      - |       0 B |
             ToChar |  3.604 ns | 0.0056 ns | 0.0052 ns |      - |       0 B |
     ToCharNullable |  6.784 ns | 0.0166 ns | 0.0147 ns |      - |       0 B |
            ToSByte |  4.275 ns | 0.0023 ns | 0.0022 ns |      - |       0 B |
    ToSByteNullable |  7.021 ns | 0.0172 ns | 0.0152 ns |      - |       0 B |
             ToByte |  1.810 ns | 0.0033 ns | 0.0031 ns |      - |       0 B |
     ToByteNullable |  4.708 ns | 0.0126 ns | 0.0111 ns |      - |       0 B |
            ToShort |  3.847 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
    ToShortNullable |  6.776 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |
           ToUShort |  3.846 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
   ToUShortNullable |  8.022 ns | 0.0191 ns | 0.0170 ns |      - |       0 B |
              ToInt |  3.844 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
      ToIntNullable |  6.769 ns | 0.0033 ns | 0.0028 ns |      - |       0 B |
             ToUInt |  3.832 ns | 0.0006 ns | 0.0006 ns |      - |       0 B |
     ToUIntNullable |  6.776 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
             ToLong |  3.832 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
     ToLongNullable |  6.142 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
            ToULong |  3.831 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
    ToULongNullable |  6.144 ns | 0.0040 ns | 0.0037 ns |      - |       0 B |
            ToFloat |  3.832 ns | 0.0012 ns | 0.0011 ns |      - |       0 B |
    ToFloatNullable |  6.789 ns | 0.0053 ns | 0.0050 ns |      - |       0 B |
           ToDouble |  3.842 ns | 0.0087 ns | 0.0073 ns |      - |       0 B |
   ToDoubleNullable |  6.148 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
          ToDecimal |  7.169 ns | 0.0172 ns | 0.0161 ns |      - |       0 B |
  ToDecimalNullable | 16.003 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
         ToDateTime |  5.378 ns | 0.0151 ns | 0.0133 ns |      - |       0 B |
 ToDateTimeNullable |  6.658 ns | 0.0044 ns | 0.0037 ns |      - |       0 B |
           ToObject |  4.512 ns | 0.0020 ns | 0.0017 ns | 0.0057 |      24 B |
          To_String | 47.798 ns | 0.0338 ns | 0.0317 ns | 0.0076 |      32 B |
             ToEnum | 23.116 ns | 0.0469 ns | 0.0415 ns | 0.0057 |      24 B |
