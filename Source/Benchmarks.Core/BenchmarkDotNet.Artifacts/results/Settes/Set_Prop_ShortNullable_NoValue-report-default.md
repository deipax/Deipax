
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 15.147 ns | 0.0483 ns | 0.0404 ns |      - |       0 B |
     FromBoolNullable |  7.816 ns | 0.1025 ns | 0.0909 ns |      - |       0 B |
             FromChar | 16.523 ns | 0.1210 ns | 0.1131 ns |      - |       0 B |
     FromCharNullable |  7.798 ns | 0.0602 ns | 0.0534 ns |      - |       0 B |
            FromSByte | 15.198 ns | 0.0992 ns | 0.0928 ns |      - |       0 B |
    FromSByteNullable |  7.791 ns | 0.0490 ns | 0.0409 ns |      - |       0 B |
             FromByte | 15.117 ns | 0.0299 ns | 0.0265 ns |      - |       0 B |
     FromByteNullable |  7.794 ns | 0.0256 ns | 0.0227 ns |      - |       0 B |
            FromShort | 14.691 ns | 0.0381 ns | 0.0357 ns |      - |       0 B |
    FromShortNullable |  7.759 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
           FromUShort | 15.656 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
   FromUShortNullable |  7.746 ns | 0.0109 ns | 0.0097 ns |      - |       0 B |
              FromInt | 16.498 ns | 0.0338 ns | 0.0316 ns |      - |       0 B |
      FromIntNullable |  7.745 ns | 0.0110 ns | 0.0086 ns |      - |       0 B |
             FromUInt | 16.414 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
     FromUIntNullable |  7.748 ns | 0.0104 ns | 0.0092 ns |      - |       0 B |
             FromLong | 16.489 ns | 0.0134 ns | 0.0112 ns |      - |       0 B |
     FromLongNullable |  7.746 ns | 0.0100 ns | 0.0094 ns |      - |       0 B |
            FromULong | 16.423 ns | 0.0213 ns | 0.0200 ns |      - |       0 B |
    FromULongNullable |  7.750 ns | 0.0119 ns | 0.0105 ns |      - |       0 B |
            FromFloat | 19.054 ns | 0.0092 ns | 0.0071 ns |      - |       0 B |
    FromFloatNullable |  7.742 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
           FromDouble | 18.703 ns | 0.0149 ns | 0.0132 ns |      - |       0 B |
   FromDoubleNullable |  7.746 ns | 0.0141 ns | 0.0125 ns |      - |       0 B |
          FromDecimal | 27.991 ns | 0.0792 ns | 0.0741 ns |      - |       0 B |
  FromDecimalNullable |  7.736 ns | 0.0076 ns | 0.0060 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.745 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
           FromObject |  7.747 ns | 0.0206 ns | 0.0192 ns |      - |       0 B |
           FromString |  7.785 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
             FromEnum | 46.273 ns | 0.0956 ns | 0.0895 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_ShortNullable_NoValue.FromDateTime: DefaultJob
