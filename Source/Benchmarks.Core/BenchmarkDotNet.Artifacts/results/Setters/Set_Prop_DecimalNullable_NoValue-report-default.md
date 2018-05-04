
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool | 14.946 ns | 0.0108 ns | 0.0101 ns |       0 B |
     FromBoolNullable |  5.097 ns | 0.0107 ns | 0.0100 ns |       0 B |
             FromChar |  5.449 ns | 0.0023 ns | 0.0018 ns |       0 B |
     FromCharNullable |  4.580 ns | 0.0010 ns | 0.0008 ns |       0 B |
            FromSByte | 14.688 ns | 0.0068 ns | 0.0063 ns |       0 B |
    FromSByteNullable |  5.080 ns | 0.0011 ns | 0.0009 ns |       0 B |
             FromByte | 14.689 ns | 0.0110 ns | 0.0097 ns |       0 B |
     FromByteNullable |  5.320 ns | 0.0079 ns | 0.0074 ns |       0 B |
            FromShort | 14.937 ns | 0.0017 ns | 0.0014 ns |       0 B |
    FromShortNullable |  4.912 ns | 0.0046 ns | 0.0031 ns |       0 B |
           FromUShort | 14.687 ns | 0.0069 ns | 0.0065 ns |       0 B |
   FromUShortNullable |  4.901 ns | 0.0110 ns | 0.0092 ns |       0 B |
              FromInt | 14.684 ns | 0.0013 ns | 0.0011 ns |       0 B |
      FromIntNullable |  4.881 ns | 0.0099 ns | 0.0083 ns |       0 B |
             FromUInt | 14.688 ns | 0.0074 ns | 0.0070 ns |       0 B |
     FromUIntNullable |  4.862 ns | 0.0099 ns | 0.0088 ns |       0 B |
             FromLong | 14.937 ns | 0.0018 ns | 0.0015 ns |       0 B |
     FromLongNullable |  5.142 ns | 0.0142 ns | 0.0126 ns |       0 B |
            FromULong | 14.683 ns | 0.0019 ns | 0.0016 ns |       0 B |
    FromULongNullable |  5.257 ns | 0.0062 ns | 0.0058 ns |       0 B |
            FromFloat | 19.556 ns | 0.0021 ns | 0.0016 ns |       0 B |
    FromFloatNullable |  5.244 ns | 0.0016 ns | 0.0015 ns |       0 B |
           FromDouble | 17.520 ns | 0.0152 ns | 0.0142 ns |       0 B |
   FromDoubleNullable |  5.239 ns | 0.0062 ns | 0.0058 ns |       0 B |
          FromDecimal |  6.021 ns | 0.0058 ns | 0.0051 ns |       0 B |
  FromDecimalNullable |  1.789 ns | 0.0011 ns | 0.0010 ns |       0 B |
         FromDateTime |  4.842 ns | 0.0029 ns | 0.0026 ns |       0 B |
 FromDateTimeNullable |  5.096 ns | 0.0061 ns | 0.0051 ns |       0 B |
           FromObject |  7.778 ns | 0.0048 ns | 0.0045 ns |       0 B |
           FromString |  6.826 ns | 0.0318 ns | 0.0297 ns |       0 B |
             FromEnum | 14.675 ns | 0.0017 ns | 0.0014 ns |       0 B |
     FromEnumNullable |  5.066 ns | 0.0072 ns | 0.0064 ns |       0 B |
