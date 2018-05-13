
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  19.843 ns | 0.0232 ns | 0.0217 ns |       0 B |
     FromBoolNullable |  18.069 ns | 0.0414 ns | 0.0367 ns |       0 B |
             FromChar |   1.041 ns | 0.0042 ns | 0.0037 ns |       0 B |
     FromCharNullable |   1.341 ns | 0.0033 ns | 0.0029 ns |       0 B |
            FromSByte |  19.835 ns | 0.0219 ns | 0.0194 ns |       0 B |
    FromSByteNullable |  20.147 ns | 0.0316 ns | 0.0296 ns |       0 B |
             FromByte |  19.829 ns | 0.0137 ns | 0.0128 ns |       0 B |
     FromByteNullable |  20.145 ns | 0.0153 ns | 0.0119 ns |       0 B |
            FromShort |  17.536 ns | 0.0210 ns | 0.0196 ns |       0 B |
    FromShortNullable |  17.788 ns | 0.0202 ns | 0.0189 ns |       0 B |
           FromUShort |  17.531 ns | 0.0167 ns | 0.0156 ns |       0 B |
   FromUShortNullable |  17.789 ns | 0.0149 ns | 0.0132 ns |       0 B |
              FromInt |  19.313 ns | 0.0109 ns | 0.0102 ns |       0 B |
      FromIntNullable |  20.141 ns | 0.0391 ns | 0.0347 ns |       0 B |
             FromUInt |  17.283 ns | 0.0233 ns | 0.0217 ns |       0 B |
     FromUIntNullable |  17.806 ns | 0.0388 ns | 0.0344 ns |       0 B |
             FromLong |  17.534 ns | 0.0024 ns | 0.0014 ns |       0 B |
     FromLongNullable |  20.890 ns | 0.6038 ns | 0.5648 ns |       0 B |
            FromULong |  19.842 ns | 0.0230 ns | 0.0215 ns |       0 B |
    FromULongNullable |  18.067 ns | 0.0409 ns | 0.0362 ns |       0 B |
            FromFloat |  35.024 ns | 0.0454 ns | 0.0425 ns |       0 B |
    FromFloatNullable |  37.437 ns | 0.0685 ns | 0.0607 ns |       0 B |
           FromDouble |  72.971 ns | 0.0766 ns | 0.0716 ns |       0 B |
   FromDoubleNullable |  76.490 ns | 0.1280 ns | 0.1135 ns |       0 B |
          FromDecimal |   6.284 ns | 0.0630 ns | 0.0589 ns |       0 B |
  FromDecimalNullable |   1.755 ns | 0.0034 ns | 0.0028 ns |       0 B |
         FromDateTime |   1.212 ns | 0.0034 ns | 0.0032 ns |       0 B |
 FromDateTimeNullable |   1.921 ns | 0.0053 ns | 0.0047 ns |       0 B |
           FromObject |  23.152 ns | 0.0532 ns | 0.0498 ns |       0 B |
           FromString | 115.667 ns | 0.2065 ns | 0.1932 ns |       0 B |
             FromEnum |  19.328 ns | 0.0130 ns | 0.0122 ns |       0 B |
     FromEnumNullable |  17.785 ns | 0.0210 ns | 0.0196 ns |       0 B |
