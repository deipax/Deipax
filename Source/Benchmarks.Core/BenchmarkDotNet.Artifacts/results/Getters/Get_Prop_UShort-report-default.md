
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.728 ns | 0.0053 ns | 0.0045 ns |      - |       0 B |
     ToBoolNullable |  6.772 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
             ToChar |  3.593 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
     ToCharNullable |  6.786 ns | 0.0151 ns | 0.0126 ns |      - |       0 B |
            ToSByte |  4.387 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
    ToSByteNullable |  7.019 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
             ToByte |  4.387 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
     ToByteNullable |  7.009 ns | 0.0012 ns | 0.0011 ns |      - |       0 B |
            ToShort |  4.475 ns | 0.0037 ns | 0.0034 ns |      - |       0 B |
    ToShortNullable |  7.010 ns | 0.0016 ns | 0.0012 ns |      - |       0 B |
           ToUShort |  1.805 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
   ToUShortNullable |  4.710 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
              ToInt |  3.849 ns | 0.0041 ns | 0.0037 ns |      - |       0 B |
      ToIntNullable |  6.772 ns | 0.0057 ns | 0.0053 ns |      - |       0 B |
             ToUInt |  3.832 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
     ToUIntNullable |  6.769 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
             ToLong |  3.833 ns | 0.0024 ns | 0.0020 ns |      - |       0 B |
     ToLongNullable |  6.141 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
            ToULong |  3.833 ns | 0.0041 ns | 0.0036 ns |      - |       0 B |
    ToULongNullable |  6.388 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
            ToFloat |  3.832 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
    ToFloatNullable |  6.775 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
           ToDouble |  3.834 ns | 0.0025 ns | 0.0019 ns |      - |       0 B |
   ToDoubleNullable |  6.387 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
          ToDecimal |  7.153 ns | 0.0035 ns | 0.0029 ns |      - |       0 B |
  ToDecimalNullable | 15.975 ns | 0.0180 ns | 0.0168 ns |      - |       0 B |
         ToDateTime |  5.364 ns | 0.0036 ns | 0.0033 ns |      - |       0 B |
 ToDateTimeNullable |  6.645 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
           ToObject |  4.560 ns | 0.0035 ns | 0.0033 ns | 0.0057 |      24 B |
          To_String | 42.021 ns | 0.0241 ns | 0.0213 ns | 0.0076 |      32 B |
             ToEnum | 23.277 ns | 0.0282 ns | 0.0235 ns | 0.0057 |      24 B |
