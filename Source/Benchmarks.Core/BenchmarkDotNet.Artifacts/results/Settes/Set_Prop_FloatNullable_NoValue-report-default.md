
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 14.801 ns | 0.0046 ns | 0.0038 ns |      - |       0 B |
     FromBoolNullable |  7.709 ns | 0.0050 ns | 0.0039 ns |      - |       0 B |
             FromChar |        NA |        NA |        NA |    N/A |       N/A |
     FromCharNullable |  7.705 ns | 0.0039 ns | 0.0033 ns |      - |       0 B |
            FromSByte | 14.819 ns | 0.0165 ns | 0.0147 ns |      - |       0 B |
    FromSByteNullable |  7.689 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
             FromByte | 14.815 ns | 0.0161 ns | 0.0134 ns |      - |       0 B |
     FromByteNullable |  7.705 ns | 0.0073 ns | 0.0069 ns |      - |       0 B |
            FromShort | 15.080 ns | 0.0258 ns | 0.0241 ns |      - |       0 B |
    FromShortNullable |  7.706 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
           FromUShort | 14.805 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
   FromUShortNullable |  7.701 ns | 0.0022 ns | 0.0018 ns |      - |       0 B |
              FromInt | 14.818 ns | 0.0239 ns | 0.0212 ns |      - |       0 B |
      FromIntNullable |  7.709 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
             FromUInt | 15.068 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
     FromUIntNullable |  7.706 ns | 0.0123 ns | 0.0096 ns |      - |       0 B |
             FromLong | 15.166 ns | 0.1577 ns | 0.1317 ns |      - |       0 B |
     FromLongNullable |  7.698 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
            FromULong | 15.620 ns | 0.0275 ns | 0.0257 ns |      - |       0 B |
    FromULongNullable |  7.695 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
            FromFloat | 13.932 ns | 0.0085 ns | 0.0075 ns |      - |       0 B |
    FromFloatNullable |  7.696 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
           FromDouble | 14.830 ns | 0.0102 ns | 0.0085 ns |      - |       0 B |
   FromDoubleNullable |  7.717 ns | 0.0060 ns | 0.0056 ns |      - |       0 B |
          FromDecimal | 28.206 ns | 0.0179 ns | 0.0167 ns |      - |       0 B |
  FromDecimalNullable |  7.694 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.703 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
           FromObject |  7.713 ns | 0.0221 ns | 0.0185 ns |      - |       0 B |
           FromString |  7.705 ns | 0.0056 ns | 0.0047 ns |      - |       0 B |
             FromEnum | 44.664 ns | 0.1918 ns | 0.1794 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_FloatNullable_NoValue.FromChar: DefaultJob
  Set_Prop_FloatNullable_NoValue.FromDateTime: DefaultJob
