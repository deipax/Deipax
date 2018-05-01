
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |     Mean |     Error |    StdDev |   Median | Allocated |
--------------------- |---------:|----------:|----------:|---------:|----------:|
             FromBool | 6.116 ns | 0.0017 ns | 0.0014 ns | 6.115 ns |       0 B |
     FromBoolNullable | 5.867 ns | 0.0035 ns | 0.0029 ns | 5.866 ns |       0 B |
             FromChar | 6.116 ns | 0.0011 ns | 0.0009 ns | 6.116 ns |       0 B |
     FromCharNullable | 5.871 ns | 0.0023 ns | 0.0022 ns | 5.871 ns |       0 B |
            FromSByte | 6.120 ns | 0.0076 ns | 0.0071 ns | 6.116 ns |       0 B |
    FromSByteNullable | 5.870 ns | 0.0047 ns | 0.0039 ns | 5.870 ns |       0 B |
             FromByte | 6.117 ns | 0.0028 ns | 0.0024 ns | 6.116 ns |       0 B |
     FromByteNullable | 5.868 ns | 0.0026 ns | 0.0023 ns | 5.868 ns |       0 B |
            FromShort | 6.122 ns | 0.0018 ns | 0.0016 ns | 6.123 ns |       0 B |
    FromShortNullable | 6.141 ns | 0.3501 ns | 0.4167 ns | 5.875 ns |       0 B |
           FromUShort | 6.125 ns | 0.0020 ns | 0.0018 ns | 6.125 ns |       0 B |
   FromUShortNullable | 5.897 ns | 0.0928 ns | 0.0775 ns | 5.868 ns |       0 B |
              FromInt | 6.119 ns | 0.0071 ns | 0.0063 ns | 6.115 ns |       0 B |
      FromIntNullable | 5.861 ns | 0.0069 ns | 0.0058 ns | 5.858 ns |       0 B |
             FromUInt | 6.126 ns | 0.0025 ns | 0.0021 ns | 6.126 ns |       0 B |
     FromUIntNullable | 5.875 ns | 0.0300 ns | 0.0235 ns | 5.864 ns |       0 B |
             FromLong | 6.309 ns | 0.0246 ns | 0.0230 ns | 6.315 ns |       0 B |
     FromLongNullable | 5.868 ns | 0.0086 ns | 0.0077 ns | 5.867 ns |       0 B |
            FromULong | 6.127 ns | 0.0088 ns | 0.0083 ns | 6.123 ns |       0 B |
    FromULongNullable | 5.863 ns | 0.0054 ns | 0.0051 ns | 5.861 ns |       0 B |
            FromFloat | 6.126 ns | 0.0032 ns | 0.0028 ns | 6.125 ns |       0 B |
    FromFloatNullable | 5.866 ns | 0.0073 ns | 0.0069 ns | 5.865 ns |       0 B |
           FromDouble | 6.121 ns | 0.0022 ns | 0.0019 ns | 6.122 ns |       0 B |
   FromDoubleNullable | 5.866 ns | 0.0072 ns | 0.0068 ns | 5.866 ns |       0 B |
          FromDecimal | 6.125 ns | 0.0024 ns | 0.0020 ns | 6.124 ns |       0 B |
  FromDecimalNullable | 5.874 ns | 0.0151 ns | 0.0133 ns | 5.866 ns |       0 B |
         FromDateTime | 6.116 ns | 0.0039 ns | 0.0035 ns | 6.115 ns |       0 B |
 FromDateTimeNullable | 5.866 ns | 0.0067 ns | 0.0062 ns | 5.861 ns |       0 B |
           FromObject | 4.075 ns | 0.0026 ns | 0.0023 ns | 4.074 ns |       0 B |
           FromString | 6.130 ns | 0.0020 ns | 0.0017 ns | 6.129 ns |       0 B |
             FromEnum | 6.121 ns | 0.0033 ns | 0.0028 ns | 6.121 ns |       0 B |
