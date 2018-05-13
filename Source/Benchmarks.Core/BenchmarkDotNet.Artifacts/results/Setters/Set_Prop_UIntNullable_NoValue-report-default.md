
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |     Median | Allocated |
--------------------- |----------:|----------:|----------:|-----------:|----------:|
             FromBool |  1.266 ns | 0.0033 ns | 0.0029 ns |  1.2648 ns |       0 B |
     FromBoolNullable |  1.780 ns | 0.0052 ns | 0.0048 ns |  1.7785 ns |       0 B |
             FromChar |  1.012 ns | 0.0026 ns | 0.0024 ns |  1.0116 ns |       0 B |
     FromCharNullable |  1.774 ns | 0.0025 ns | 0.0021 ns |  1.7723 ns |       0 B |
            FromSByte |  1.891 ns | 0.0072 ns | 0.0060 ns |  1.8904 ns |       0 B |
    FromSByteNullable |  2.266 ns | 0.0077 ns | 0.0072 ns |  2.2647 ns |       0 B |
             FromByte |  1.008 ns | 0.0031 ns | 0.0027 ns |  1.0064 ns |       0 B |
     FromByteNullable |  1.858 ns | 0.0723 ns | 0.1731 ns |  1.7801 ns |       0 B |
            FromShort |  1.894 ns | 0.0030 ns | 0.0028 ns |  1.8937 ns |       0 B |
    FromShortNullable |  2.493 ns | 0.0124 ns | 0.0116 ns |  2.4915 ns |       0 B |
           FromUShort |  1.009 ns | 0.0022 ns | 0.0020 ns |  1.0086 ns |       0 B |
   FromUShortNullable |  1.779 ns | 0.0051 ns | 0.0048 ns |  1.7777 ns |       0 B |
              FromInt |  1.924 ns | 0.0043 ns | 0.0041 ns |  1.9255 ns |       0 B |
      FromIntNullable |  2.446 ns | 0.0081 ns | 0.0075 ns |  2.4481 ns |       0 B |
             FromUInt |  1.013 ns | 0.0038 ns | 0.0034 ns |  1.0121 ns |       0 B |
     FromUIntNullable |  1.043 ns | 0.0033 ns | 0.0031 ns |  1.0415 ns |       0 B |
             FromLong |  2.570 ns | 0.0098 ns | 0.0092 ns |  2.5655 ns |       0 B |
     FromLongNullable |  2.613 ns | 0.0054 ns | 0.0051 ns |  2.6136 ns |       0 B |
            FromULong |  3.535 ns | 0.0606 ns | 0.0566 ns |  3.5440 ns |       0 B |
    FromULongNullable |  3.112 ns | 0.0166 ns | 0.0155 ns |  3.1086 ns |       0 B |
            FromFloat |  4.664 ns | 0.0122 ns | 0.0095 ns |  4.6606 ns |       0 B |
    FromFloatNullable |  2.489 ns | 0.0110 ns | 0.0103 ns |  2.4897 ns |       0 B |
           FromDouble |  4.187 ns | 0.0115 ns | 0.0107 ns |  4.1883 ns |       0 B |
   FromDoubleNullable |  2.422 ns | 0.1024 ns | 0.1006 ns |  2.3733 ns |       0 B |
          FromDecimal | 14.772 ns | 0.4178 ns | 0.4103 ns | 14.5642 ns |       0 B |
  FromDecimalNullable |  8.754 ns | 0.1986 ns | 0.2287 ns |  8.6360 ns |       0 B |
         FromDateTime |  1.010 ns | 0.0418 ns | 0.0391 ns |  0.9865 ns |       0 B |
 FromDateTimeNullable |  2.189 ns | 0.0766 ns | 0.0716 ns |  2.1605 ns |       0 B |
           FromObject |  3.949 ns | 0.0247 ns | 0.0219 ns |  3.9422 ns |       0 B |
           FromString |  2.472 ns | 0.0066 ns | 0.0055 ns |  2.4709 ns |       0 B |
             FromEnum |  2.056 ns | 0.0352 ns | 0.0312 ns |  2.0409 ns |       0 B |
     FromEnumNullable |  2.457 ns | 0.0149 ns | 0.0124 ns |  2.4538 ns |       0 B |
