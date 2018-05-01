
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool |  3.525 ns | 0.0249 ns | 0.0208 ns |      - |       0 B |
     FromBoolNullable |  3.378 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
             FromChar |        NA |        NA |        NA |    N/A |       N/A |
     FromCharNullable |  7.071 ns | 0.1552 ns | 0.1451 ns |      - |       0 B |
            FromSByte | 13.000 ns | 0.1998 ns | 0.1869 ns |      - |       0 B |
    FromSByteNullable | 12.904 ns | 0.1177 ns | 0.1044 ns |      - |       0 B |
             FromByte | 13.134 ns | 0.0169 ns | 0.0141 ns |      - |       0 B |
     FromByteNullable | 13.167 ns | 0.0632 ns | 0.0560 ns |      - |       0 B |
            FromShort | 12.888 ns | 0.0788 ns | 0.0698 ns |      - |       0 B |
    FromShortNullable | 12.912 ns | 0.0962 ns | 0.0803 ns |      - |       0 B |
           FromUShort | 13.166 ns | 0.2705 ns | 0.2530 ns |      - |       0 B |
   FromUShortNullable | 12.927 ns | 0.1777 ns | 0.1484 ns |      - |       0 B |
              FromInt | 12.815 ns | 0.0228 ns | 0.0202 ns |      - |       0 B |
      FromIntNullable | 12.838 ns | 0.0543 ns | 0.0453 ns |      - |       0 B |
             FromUInt | 12.814 ns | 0.0174 ns | 0.0163 ns |      - |       0 B |
     FromUIntNullable | 12.804 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
             FromLong | 12.792 ns | 0.0083 ns | 0.0069 ns |      - |       0 B |
     FromLongNullable | 12.827 ns | 0.0214 ns | 0.0200 ns |      - |       0 B |
            FromULong | 12.797 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
    FromULongNullable | 12.870 ns | 0.0487 ns | 0.0455 ns |      - |       0 B |
            FromFloat | 12.802 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
    FromFloatNullable | 12.906 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
           FromDouble | 13.065 ns | 0.0127 ns | 0.0119 ns |      - |       0 B |
   FromDoubleNullable | 13.183 ns | 0.0653 ns | 0.0611 ns |      - |       0 B |
          FromDecimal | 22.538 ns | 0.0141 ns | 0.0125 ns |      - |       0 B |
  FromDecimalNullable | 22.568 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  6.988 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
           FromObject |  3.367 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
           FromString | 18.294 ns | 0.0374 ns | 0.0312 ns |      - |       0 B |
             FromEnum | 43.726 ns | 0.0254 ns | 0.0199 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_Bool.FromChar: DefaultJob
  Set_Prop_Bool.FromDateTime: DefaultJob
