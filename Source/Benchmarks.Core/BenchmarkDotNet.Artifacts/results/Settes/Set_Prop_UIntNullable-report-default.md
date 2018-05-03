
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  6.7515 ns | 0.0020 ns | 0.0018 ns |       0 B |
     FromBoolNullable |  6.7845 ns | 0.0143 ns | 0.0119 ns |       0 B |
             FromChar |  6.7685 ns | 0.0264 ns | 0.0220 ns |       0 B |
     FromCharNullable |  6.5151 ns | 0.0060 ns | 0.0050 ns |       0 B |
            FromSByte |  6.7734 ns | 0.0033 ns | 0.0028 ns |       0 B |
    FromSByteNullable |  6.7872 ns | 0.0176 ns | 0.0156 ns |       0 B |
             FromByte |  6.7637 ns | 0.0037 ns | 0.0035 ns |       0 B |
     FromByteNullable |  6.5238 ns | 0.0149 ns | 0.0140 ns |       0 B |
            FromShort |  6.7570 ns | 0.0084 ns | 0.0079 ns |       0 B |
    FromShortNullable |  6.7746 ns | 0.0094 ns | 0.0088 ns |       0 B |
           FromUShort |  6.7532 ns | 0.0010 ns | 0.0009 ns |       0 B |
   FromUShortNullable |  6.5205 ns | 0.0115 ns | 0.0102 ns |       0 B |
              FromInt |  6.7531 ns | 0.0014 ns | 0.0011 ns |       0 B |
      FromIntNullable |  6.7238 ns | 0.0075 ns | 0.0070 ns |       0 B |
             FromUInt |  0.9052 ns | 0.0007 ns | 0.0005 ns |       0 B |
     FromUIntNullable |  1.0313 ns | 0.0021 ns | 0.0020 ns |       0 B |
             FromLong |  7.5008 ns | 0.0098 ns | 0.0091 ns |       0 B |
     FromLongNullable |  7.9681 ns | 0.0200 ns | 0.0177 ns |       0 B |
            FromULong |  6.7530 ns | 0.0026 ns | 0.0023 ns |       0 B |
    FromULongNullable |  7.5311 ns | 0.0044 ns | 0.0034 ns |       0 B |
            FromFloat |  8.0685 ns | 0.0077 ns | 0.0069 ns |       0 B |
    FromFloatNullable |  8.3361 ns | 0.0194 ns | 0.0182 ns |       0 B |
           FromDouble |  7.8284 ns | 0.0007 ns | 0.0006 ns |       0 B |
   FromDoubleNullable |  8.8038 ns | 0.0144 ns | 0.0135 ns |       0 B |
          FromDecimal | 19.7080 ns | 0.0029 ns | 0.0024 ns |       0 B |
  FromDecimalNullable | 24.6664 ns | 0.0200 ns | 0.0187 ns |       0 B |
         FromDateTime |  7.0306 ns | 0.0059 ns | 0.0053 ns |       0 B |
 FromDateTimeNullable |  7.2912 ns | 0.0053 ns | 0.0047 ns |       0 B |
           FromObject | 14.3237 ns | 0.0051 ns | 0.0040 ns |       0 B |
           FromString | 74.0055 ns | 0.1082 ns | 0.0845 ns |       0 B |
             FromEnum |  6.7524 ns | 0.0017 ns | 0.0013 ns |       0 B |
     FromEnumNullable |  6.8077 ns | 0.0072 ns | 0.0067 ns |       0 B |
