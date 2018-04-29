
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.791 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
     ToBoolNullable |  6.783 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
             ToChar |  4.870 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
     ToCharNullable |  7.305 ns | 0.0162 ns | 0.0136 ns |      - |       0 B |
            ToSByte |  4.632 ns | 0.0026 ns | 0.0017 ns |      - |       0 B |
    ToSByteNullable |  7.283 ns | 0.0064 ns | 0.0057 ns |      - |       0 B |
             ToByte |  4.895 ns | 0.0062 ns | 0.0052 ns |      - |       0 B |
     ToByteNullable |  7.279 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
            ToShort |  4.891 ns | 0.0059 ns | 0.0039 ns |      - |       0 B |
    ToShortNullable |  7.281 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
           ToUShort |  4.890 ns | 0.0066 ns | 0.0052 ns |      - |       0 B |
   ToUShortNullable |  7.291 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
              ToInt |  1.812 ns | 0.0067 ns | 0.0059 ns |      - |       0 B |
      ToIntNullable |  4.708 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
             ToUInt |  4.343 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
     ToUIntNullable |  7.017 ns | 0.0191 ns | 0.0179 ns |      - |       0 B |
             ToLong |  3.839 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
     ToLongNullable |  6.407 ns | 0.0058 ns | 0.0042 ns |      - |       0 B |
            ToULong |  4.356 ns | 0.0039 ns | 0.0036 ns |      - |       0 B |
    ToULongNullable |  6.907 ns | 0.0178 ns | 0.0139 ns |      - |       0 B |
            ToFloat |  3.839 ns | 0.0025 ns | 0.0024 ns |      - |       0 B |
    ToFloatNullable |  6.787 ns | 0.0130 ns | 0.0115 ns |      - |       0 B |
           ToDouble |  3.844 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
   ToDoubleNullable |  6.372 ns | 0.0100 ns | 0.0093 ns |      - |       0 B |
          ToDecimal |  7.423 ns | 0.0058 ns | 0.0051 ns |      - |       0 B |
  ToDecimalNullable | 15.960 ns | 0.0034 ns | 0.0030 ns |      - |       0 B |
         ToDateTime |  5.381 ns | 0.0033 ns | 0.0031 ns |      - |       0 B |
 ToDateTimeNullable |  6.386 ns | 0.0014 ns | 0.0013 ns |      - |       0 B |
           ToObject |  4.530 ns | 0.0010 ns | 0.0009 ns | 0.0057 |      24 B |
          To_String | 46.416 ns | 0.0341 ns | 0.0319 ns | 0.0076 |      32 B |
             ToEnum | 26.809 ns | 0.0284 ns | 0.0266 ns | 0.0057 |      24 B |
