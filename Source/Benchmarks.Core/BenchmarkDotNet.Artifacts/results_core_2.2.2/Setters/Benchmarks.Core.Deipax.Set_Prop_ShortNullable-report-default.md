
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6709 ns | 0.0026 ns | 0.0023 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.6216 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromChar |  1.3679 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.7598 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
            FromSByte |  0.6744 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
    FromSByteNullable |  0.9139 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
             FromByte |  0.5648 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.9718 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
            FromShort |  0.7387 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    FromShortNullable |  0.6092 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
           FromUShort |  1.3483 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.7602 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
              FromInt |  1.7866 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.5373 ns | 0.0029 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromUInt |  1.7889 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.5384 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
             FromLong |  2.0865 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
     FromLongNullable |  3.1873 ns | 0.0034 ns | 0.0031 ns |           - |           - |           - |                   - |
            FromULong |  1.7022 ns | 0.0036 ns | 0.0032 ns |           - |           - |           - |                   - |
    FromULongNullable |  3.1170 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
            FromFloat |  3.8247 ns | 0.0038 ns | 0.0035 ns |           - |           - |           - |                   - |
    FromFloatNullable |  4.7134 ns | 0.0043 ns | 0.0041 ns |           - |           - |           - |                   - |
           FromDouble |  3.9243 ns | 0.0057 ns | 0.0053 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.7782 ns | 0.0038 ns | 0.0035 ns |           - |           - |           - |                   - |
          FromDecimal | 13.8481 ns | 0.0192 ns | 0.0170 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 24.6528 ns | 0.0208 ns | 0.0195 ns |           - |           - |           - |                   - |
         FromDateTime |  0.9297 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6397 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
           FromObject | 14.0294 ns | 0.0085 ns | 0.0071 ns |           - |           - |           - |                   - |
           FromString | 41.9020 ns | 0.0702 ns | 0.0657 ns |           - |           - |           - |                   - |
             FromEnum |  1.8067 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.6631 ns | 0.0035 ns | 0.0029 ns |           - |           - |           - |                   - |
