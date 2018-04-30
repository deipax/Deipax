
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.654 ns | 0.0062 ns | 0.0055 ns |  3.654 ns |      - |       0 B |
     ToBoolNullable |  6.805 ns | 0.0316 ns | 0.0296 ns |  6.783 ns |      - |       0 B |
             ToChar |  5.373 ns | 0.0168 ns | 0.0140 ns |  5.365 ns |      - |       0 B |
     ToCharNullable |  8.157 ns | 0.0954 ns | 0.0796 ns |  8.205 ns |      - |       0 B |
            ToSByte |  5.125 ns | 0.0170 ns | 0.0151 ns |  5.118 ns |      - |       0 B |
    ToSByteNullable |  7.575 ns | 0.0075 ns | 0.0063 ns |  7.573 ns |      - |       0 B |
             ToByte |  5.374 ns | 0.0258 ns | 0.0229 ns |  5.368 ns |      - |       0 B |
     ToByteNullable |  7.573 ns | 0.0102 ns | 0.0090 ns |  7.572 ns |      - |       0 B |
            ToShort |  5.357 ns | 0.0201 ns | 0.0188 ns |  5.341 ns |      - |       0 B |
    ToShortNullable |  7.565 ns | 0.0030 ns | 0.0023 ns |  7.564 ns |      - |       0 B |
           ToUShort |  5.357 ns | 0.0158 ns | 0.0147 ns |  5.351 ns |      - |       0 B |
   ToUShortNullable |  7.608 ns | 0.0201 ns | 0.0178 ns |  7.600 ns |      - |       0 B |
              ToInt |  2.188 ns | 0.0063 ns | 0.0052 ns |  2.186 ns |      - |       0 B |
      ToIntNullable |  1.280 ns | 0.0012 ns | 0.0011 ns |  1.280 ns |      - |       0 B |
             ToUInt |  4.609 ns | 0.0021 ns | 0.0017 ns |  4.609 ns |      - |       0 B |
     ToUIntNullable |  6.831 ns | 0.0071 ns | 0.0059 ns |  6.832 ns |      - |       0 B |
             ToLong |  3.840 ns | 0.0046 ns | 0.0043 ns |  3.840 ns |      - |       0 B |
     ToLongNullable |  6.399 ns | 0.0030 ns | 0.0026 ns |  6.399 ns |      - |       0 B |
            ToULong |  4.597 ns | 0.0022 ns | 0.0019 ns |  4.596 ns |      - |       0 B |
    ToULongNullable |  6.952 ns | 0.0063 ns | 0.0056 ns |  6.951 ns |      - |       0 B |
            ToFloat |  3.839 ns | 0.0065 ns | 0.0051 ns |  3.838 ns |      - |       0 B |
    ToFloatNullable |  7.036 ns | 0.0854 ns | 0.0757 ns |  7.035 ns |      - |       0 B |
           ToDouble |  4.314 ns | 0.1567 ns | 0.4595 ns |  4.153 ns |      - |       0 B |
   ToDoubleNullable |  6.698 ns | 0.1634 ns | 0.2007 ns |  6.635 ns |      - |       0 B |
          ToDecimal |  7.421 ns | 0.1777 ns | 0.1975 ns |  7.381 ns |      - |       0 B |
  ToDecimalNullable | 16.422 ns | 0.2328 ns | 0.2064 ns | 16.329 ns |      - |       0 B |
         ToDateTime |  4.486 ns | 0.1031 ns | 0.0914 ns |  4.482 ns |      - |       0 B |
 ToDateTimeNullable |  6.311 ns | 0.1460 ns | 0.1366 ns |  6.314 ns |      - |       0 B |
           ToObject |  4.975 ns | 0.0721 ns | 0.0639 ns |  4.977 ns | 0.0057 |      24 B |
          To_String | 47.531 ns | 0.6296 ns | 0.5581 ns | 47.511 ns | 0.0076 |      32 B |
             ToEnum | 27.080 ns | 0.4801 ns | 0.4490 ns | 27.101 ns | 0.0057 |      24 B |
