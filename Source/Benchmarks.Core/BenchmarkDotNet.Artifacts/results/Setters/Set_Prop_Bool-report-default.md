
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.1102 ns | 0.0456 ns | 0.0404 ns |       0 B |
     FromBoolNullable |  1.6027 ns | 0.0661 ns | 0.0761 ns |       0 B |
             FromChar |  0.8203 ns | 0.0543 ns | 0.0481 ns |       0 B |
     FromCharNullable |  0.8502 ns | 0.0213 ns | 0.0199 ns |       0 B |
            FromSByte |  1.0056 ns | 0.0032 ns | 0.0029 ns |       0 B |
    FromSByteNullable |  1.7850 ns | 0.0036 ns | 0.0030 ns |       0 B |
             FromByte |  1.0084 ns | 0.0030 ns | 0.0025 ns |       0 B |
     FromByteNullable |  1.5924 ns | 0.0082 ns | 0.0077 ns |       0 B |
            FromShort |  1.0099 ns | 0.0046 ns | 0.0041 ns |       0 B |
    FromShortNullable |  1.7863 ns | 0.0180 ns | 0.0168 ns |       0 B |
           FromUShort |  1.0083 ns | 0.0035 ns | 0.0029 ns |       0 B |
   FromUShortNullable |  1.6066 ns | 0.0025 ns | 0.0021 ns |       0 B |
              FromInt |  1.4130 ns | 0.0025 ns | 0.0022 ns |       0 B |
      FromIntNullable |  1.5344 ns | 0.0031 ns | 0.0026 ns |       0 B |
             FromUInt |  1.0067 ns | 0.0010 ns | 0.0009 ns |       0 B |
     FromUIntNullable |  1.6864 ns | 0.0064 ns | 0.0054 ns |       0 B |
             FromLong |  1.1574 ns | 0.0427 ns | 0.0378 ns |       0 B |
     FromLongNullable |  2.2817 ns | 0.0048 ns | 0.0043 ns |       0 B |
            FromULong |  1.0320 ns | 0.0196 ns | 0.0173 ns |       0 B |
    FromULongNullable |  2.2832 ns | 0.0014 ns | 0.0013 ns |       0 B |
            FromFloat |  1.0241 ns | 0.0027 ns | 0.0023 ns |       0 B |
    FromFloatNullable |  1.7783 ns | 0.0060 ns | 0.0050 ns |       0 B |
           FromDouble |  1.0920 ns | 0.0119 ns | 0.0111 ns |       0 B |
   FromDoubleNullable |  2.5222 ns | 0.0057 ns | 0.0047 ns |       0 B |
          FromDecimal | 11.3208 ns | 0.0082 ns | 0.0076 ns |       0 B |
  FromDecimalNullable | 17.8308 ns | 0.0392 ns | 0.0348 ns |       0 B |
         FromDateTime |  0.8177 ns | 0.0040 ns | 0.0037 ns |       0 B |
 FromDateTimeNullable |  1.8223 ns | 0.0060 ns | 0.0053 ns |       0 B |
           FromObject |  3.0318 ns | 0.0199 ns | 0.0186 ns |       0 B |
           FromString |  9.3370 ns | 0.0118 ns | 0.0104 ns |       0 B |
             FromEnum |  1.0082 ns | 0.0023 ns | 0.0021 ns |       0 B |
     FromEnumNullable |  3.9117 ns | 0.1108 ns | 0.1138 ns |       0 B |
