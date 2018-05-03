
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |     Mean |     Error |    StdDev | Allocated |
--------------------- |---------:|----------:|----------:|----------:|
             FromBool | 5.341 ns | 0.0063 ns | 0.0055 ns |       0 B |
     FromBoolNullable | 4.928 ns | 0.0073 ns | 0.0057 ns |       0 B |
             FromChar | 5.215 ns | 0.0021 ns | 0.0018 ns |       0 B |
     FromCharNullable | 5.066 ns | 0.0094 ns | 0.0078 ns |       0 B |
            FromSByte | 5.133 ns | 0.0025 ns | 0.0023 ns |       0 B |
    FromSByteNullable | 5.741 ns | 0.0009 ns | 0.0008 ns |       0 B |
             FromByte | 5.093 ns | 0.0038 ns | 0.0035 ns |       0 B |
     FromByteNullable | 5.086 ns | 0.0170 ns | 0.0159 ns |       0 B |
            FromShort | 5.141 ns | 0.0068 ns | 0.0064 ns |       0 B |
    FromShortNullable | 5.087 ns | 0.0014 ns | 0.0012 ns |       0 B |
           FromUShort | 5.149 ns | 0.0038 ns | 0.0033 ns |       0 B |
   FromUShortNullable | 5.066 ns | 0.0065 ns | 0.0061 ns |       0 B |
              FromInt | 5.010 ns | 0.0405 ns | 0.0359 ns |       0 B |
      FromIntNullable | 5.503 ns | 0.0025 ns | 0.0021 ns |       0 B |
             FromUInt | 5.513 ns | 0.0061 ns | 0.0057 ns |       0 B |
     FromUIntNullable | 5.082 ns | 0.0019 ns | 0.0017 ns |       0 B |
             FromLong | 5.074 ns | 0.0219 ns | 0.0194 ns |       0 B |
     FromLongNullable | 9.097 ns | 0.0165 ns | 0.0154 ns |       0 B |
            FromULong | 5.013 ns | 0.0256 ns | 0.0214 ns |       0 B |
    FromULongNullable | 5.435 ns | 0.0060 ns | 0.0056 ns |       0 B |
            FromFloat | 5.081 ns | 0.0276 ns | 0.0245 ns |       0 B |
    FromFloatNullable | 5.088 ns | 0.0046 ns | 0.0041 ns |       0 B |
           FromDouble | 5.090 ns | 0.0051 ns | 0.0045 ns |       0 B |
   FromDoubleNullable | 5.755 ns | 0.0009 ns | 0.0008 ns |       0 B |
          FromDecimal | 5.154 ns | 0.0056 ns | 0.0052 ns |       0 B |
  FromDecimalNullable | 5.366 ns | 0.0021 ns | 0.0016 ns |       0 B |
         FromDateTime | 5.251 ns | 0.0019 ns | 0.0017 ns |       0 B |
 FromDateTimeNullable | 1.639 ns | 0.0038 ns | 0.0035 ns |       0 B |
           FromObject | 8.167 ns | 0.0043 ns | 0.0040 ns |       0 B |
           FromString | 5.462 ns | 0.0044 ns | 0.0041 ns |       0 B |
             FromEnum | 5.505 ns | 0.0025 ns | 0.0022 ns |       0 B |
     FromEnumNullable | 5.414 ns | 0.0009 ns | 0.0008 ns |       0 B |
