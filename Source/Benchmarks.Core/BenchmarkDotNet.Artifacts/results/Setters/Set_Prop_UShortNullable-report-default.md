
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |    Median | Allocated |
--------------------- |----------:|----------:|----------:|----------:|----------:|
             FromBool |  6.760 ns | 0.0029 ns | 0.0025 ns |  6.760 ns |       0 B |
     FromBoolNullable |  6.784 ns | 0.0179 ns | 0.0149 ns |  6.787 ns |       0 B |
             FromChar |  6.779 ns | 0.0100 ns | 0.0093 ns |  6.777 ns |       0 B |
     FromCharNullable |  6.522 ns | 0.0153 ns | 0.0143 ns |  6.514 ns |       0 B |
            FromSByte |  6.763 ns | 0.0025 ns | 0.0020 ns |  6.763 ns |       0 B |
    FromSByteNullable |  6.771 ns | 0.0024 ns | 0.0020 ns |  6.770 ns |       0 B |
             FromByte |  6.776 ns | 0.0066 ns | 0.0062 ns |  6.774 ns |       0 B |
     FromByteNullable |  6.523 ns | 0.0131 ns | 0.0116 ns |  6.515 ns |       0 B |
            FromShort |  6.758 ns | 0.0067 ns | 0.0063 ns |  6.754 ns |       0 B |
    FromShortNullable |  6.773 ns | 0.0173 ns | 0.0162 ns |  6.761 ns |       0 B |
           FromUShort |  1.051 ns | 0.0005 ns | 0.0004 ns |  1.051 ns |       0 B |
   FromUShortNullable |  1.008 ns | 0.0020 ns | 0.0019 ns |  1.007 ns |       0 B |
              FromInt |  7.508 ns | 0.0058 ns | 0.0054 ns |  7.505 ns |       0 B |
      FromIntNullable |  7.303 ns | 0.0208 ns | 0.0173 ns |  7.301 ns |       0 B |
             FromUInt |  6.767 ns | 0.0049 ns | 0.0046 ns |  6.767 ns |       0 B |
     FromUIntNullable |  6.775 ns | 0.0171 ns | 0.0160 ns |  6.766 ns |       0 B |
             FromLong |  7.529 ns | 0.0076 ns | 0.0072 ns |  7.529 ns |       0 B |
     FromLongNullable |  7.820 ns | 0.0225 ns | 0.0188 ns |  7.827 ns |       0 B |
            FromULong |  7.254 ns | 0.0103 ns | 0.0096 ns |  7.248 ns |       0 B |
    FromULongNullable |  7.779 ns | 0.0056 ns | 0.0050 ns |  7.778 ns |       0 B |
            FromFloat |  8.943 ns | 0.0114 ns | 0.0107 ns |  8.937 ns |       0 B |
    FromFloatNullable |  9.859 ns | 0.0018 ns | 0.0012 ns |  9.858 ns |       0 B |
           FromDouble |  9.134 ns | 0.0012 ns | 0.0010 ns |  9.133 ns |       0 B |
   FromDoubleNullable |  9.824 ns | 0.0043 ns | 0.0038 ns |  9.823 ns |       0 B |
          FromDecimal | 20.548 ns | 0.0020 ns | 0.0017 ns | 20.548 ns |       0 B |
  FromDecimalNullable | 25.666 ns | 0.0017 ns | 0.0014 ns | 25.667 ns |       0 B |
         FromDateTime |  6.831 ns | 0.0433 ns | 0.0405 ns |  6.816 ns |       0 B |
 FromDateTimeNullable |  7.265 ns | 0.0057 ns | 0.0050 ns |  7.263 ns |       0 B |
           FromObject | 13.361 ns | 0.0061 ns | 0.0051 ns | 13.360 ns |       0 B |
           FromString | 75.565 ns | 0.1061 ns | 0.0941 ns | 75.526 ns |       0 B |
             FromEnum |  7.494 ns | 0.0014 ns | 0.0011 ns |  7.494 ns |       0 B |
     FromEnumNullable |  7.183 ns | 0.0062 ns | 0.0055 ns |  7.183 ns |       0 B |
