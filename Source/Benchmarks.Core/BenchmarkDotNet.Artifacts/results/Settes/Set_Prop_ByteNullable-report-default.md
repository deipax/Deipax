
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  7.101 ns | 0.5200 ns | 0.5340 ns |       0 B |
     FromBoolNullable |  6.916 ns | 0.1563 ns | 0.1462 ns |       0 B |
             FromChar |  6.859 ns | 0.0792 ns | 0.0702 ns |       0 B |
     FromCharNullable |  6.802 ns | 0.0188 ns | 0.0166 ns |       0 B |
            FromSByte |  6.818 ns | 0.0382 ns | 0.0357 ns |       0 B |
    FromSByteNullable |  6.804 ns | 0.0151 ns | 0.0118 ns |       0 B |
             FromByte |  1.043 ns | 0.0305 ns | 0.0271 ns |       0 B |
     FromByteNullable |  1.049 ns | 0.0121 ns | 0.0107 ns |       0 B |
            FromShort |  7.704 ns | 0.1400 ns | 0.1241 ns |       0 B |
    FromShortNullable |  7.328 ns | 0.1374 ns | 0.1218 ns |       0 B |
           FromUShort |  6.854 ns | 0.0459 ns | 0.0407 ns |       0 B |
   FromUShortNullable |  6.863 ns | 0.0466 ns | 0.0389 ns |       0 B |
              FromInt |  7.566 ns | 0.0252 ns | 0.0235 ns |       0 B |
      FromIntNullable |  7.285 ns | 0.0718 ns | 0.0600 ns |       0 B |
             FromUInt |  6.820 ns | 0.0331 ns | 0.0310 ns |       0 B |
     FromUIntNullable |  6.821 ns | 0.0204 ns | 0.0191 ns |       0 B |
             FromLong |  7.577 ns | 0.0371 ns | 0.0310 ns |       0 B |
     FromLongNullable |  8.102 ns | 0.0559 ns | 0.0523 ns |       0 B |
            FromULong |  7.339 ns | 0.0900 ns | 0.0798 ns |       0 B |
    FromULongNullable |  7.945 ns | 0.1480 ns | 0.1312 ns |       0 B |
            FromFloat |  9.210 ns | 0.3040 ns | 0.3619 ns |       0 B |
    FromFloatNullable |  9.727 ns | 0.1492 ns | 0.1396 ns |       0 B |
           FromDouble |  9.557 ns | 0.2129 ns | 0.2187 ns |       0 B |
   FromDoubleNullable |  9.936 ns | 0.0621 ns | 0.0551 ns |       0 B |
          FromDecimal | 21.004 ns | 0.4446 ns | 0.3941 ns |       0 B |
  FromDecimalNullable | 26.181 ns | 0.4788 ns | 0.4478 ns |       0 B |
         FromDateTime |  6.849 ns | 0.0696 ns | 0.0581 ns |       0 B |
 FromDateTimeNullable |  7.305 ns | 0.0870 ns | 0.0727 ns |       0 B |
           FromObject | 13.657 ns | 0.1776 ns | 0.1574 ns |       0 B |
           FromString | 78.917 ns | 1.0151 ns | 0.9495 ns |       0 B |
             FromEnum |  7.534 ns | 0.0174 ns | 0.0163 ns |       0 B |
     FromEnumNullable |  7.262 ns | 0.0778 ns | 0.0728 ns |       0 B |
