
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |     Mean |     Error |    StdDev | Allocated |
--------------------- |---------:|----------:|----------:|----------:|
             FromBool | 6.145 ns | 0.0008 ns | 0.0006 ns |       0 B |
     FromBoolNullable | 5.923 ns | 0.0530 ns | 0.0442 ns |       0 B |
             FromChar | 6.149 ns | 0.0066 ns | 0.0058 ns |       0 B |
     FromCharNullable | 5.899 ns | 0.0036 ns | 0.0034 ns |       0 B |
            FromSByte | 6.150 ns | 0.0069 ns | 0.0065 ns |       0 B |
    FromSByteNullable | 5.909 ns | 0.0029 ns | 0.0025 ns |       0 B |
             FromByte | 6.149 ns | 0.0048 ns | 0.0045 ns |       0 B |
     FromByteNullable | 5.897 ns | 0.0017 ns | 0.0016 ns |       0 B |
            FromShort | 6.146 ns | 0.0013 ns | 0.0011 ns |       0 B |
    FromShortNullable | 5.909 ns | 0.0038 ns | 0.0036 ns |       0 B |
           FromUShort | 6.146 ns | 0.0011 ns | 0.0009 ns |       0 B |
   FromUShortNullable | 5.893 ns | 0.0062 ns | 0.0058 ns |       0 B |
              FromInt | 6.167 ns | 0.0067 ns | 0.0060 ns |       0 B |
      FromIntNullable | 5.896 ns | 0.0103 ns | 0.0096 ns |       0 B |
             FromUInt | 6.153 ns | 0.0023 ns | 0.0021 ns |       0 B |
     FromUIntNullable | 5.896 ns | 0.0106 ns | 0.0094 ns |       0 B |
             FromLong | 6.172 ns | 0.0045 ns | 0.0042 ns |       0 B |
     FromLongNullable | 5.890 ns | 0.0010 ns | 0.0009 ns |       0 B |
            FromULong | 6.153 ns | 0.0019 ns | 0.0017 ns |       0 B |
    FromULongNullable | 5.893 ns | 0.0043 ns | 0.0040 ns |       0 B |
            FromFloat | 6.171 ns | 0.0033 ns | 0.0029 ns |       0 B |
    FromFloatNullable | 5.892 ns | 0.0013 ns | 0.0012 ns |       0 B |
           FromDouble | 6.154 ns | 0.0020 ns | 0.0018 ns |       0 B |
   FromDoubleNullable | 5.892 ns | 0.0026 ns | 0.0023 ns |       0 B |
          FromDecimal | 6.172 ns | 0.0041 ns | 0.0036 ns |       0 B |
  FromDecimalNullable | 5.898 ns | 0.0086 ns | 0.0080 ns |       0 B |
         FromDateTime | 6.153 ns | 0.0013 ns | 0.0011 ns |       0 B |
 FromDateTimeNullable | 5.897 ns | 0.0039 ns | 0.0037 ns |       0 B |
           FromObject | 5.908 ns | 0.0027 ns | 0.0025 ns |       0 B |
           FromString | 5.894 ns | 0.0067 ns | 0.0062 ns |       0 B |
             FromEnum | 6.352 ns | 0.0042 ns | 0.0037 ns |       0 B |
