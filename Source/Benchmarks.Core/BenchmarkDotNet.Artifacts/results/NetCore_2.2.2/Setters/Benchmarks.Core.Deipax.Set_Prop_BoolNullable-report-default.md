
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6986 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromBoolNullable |  0.6889 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromChar |  0.6929 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.9932 ns | 0.0019 ns | 0.0016 ns |           - |           - |           - |                   - |
            FromSByte |  0.7154 ns | 0.0013 ns | 0.0013 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.1895 ns | 0.0013 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromByte |  0.7080 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.1631 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
            FromShort |  0.9246 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.1397 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
           FromUShort |  0.9232 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.2035 ns | 0.0037 ns | 0.0035 ns |           - |           - |           - |                   - |
              FromInt |  1.3467 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.2319 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
             FromUInt |  0.7156 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.0946 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromLong |  0.7147 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.7238 ns | 0.0025 ns | 0.0024 ns |           - |           - |           - |                   - |
            FromULong |  0.7366 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.7335 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
            FromFloat |  0.9880 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.2682 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
           FromDouble |  0.9426 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.8599 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
          FromDecimal |  8.3820 ns | 0.0089 ns | 0.0074 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 17.4267 ns | 0.0090 ns | 0.0084 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7354 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.4189 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
           FromObject | 13.7821 ns | 0.0088 ns | 0.0083 ns |           - |           - |           - |                   - |
           FromString | 20.0614 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
             FromEnum |  0.7125 ns | 0.0037 ns | 0.0033 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.1873 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
