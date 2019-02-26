
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8860 ns | 0.0013 ns | 0.0011 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.1255 ns | 0.0032 ns | 0.0029 ns |           - |           - |           - |                   - |
             FromChar |  0.4269 ns | 0.0012 ns | 0.0010 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.8882 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
            FromSByte |  0.4279 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
    FromSByteNullable |  0.8895 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromByte |  0.4273 ns | 0.0008 ns | 0.0008 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.8902 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
            FromShort |  0.4274 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
    FromShortNullable |  0.8843 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
           FromUShort |  0.4265 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
   FromUShortNullable |  0.8879 ns | 0.0025 ns | 0.0022 ns |           - |           - |           - |                   - |
              FromInt |  0.4378 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
      FromIntNullable |  0.8697 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromUInt |  1.2969 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.6448 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
             FromLong |  1.8387 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.6034 ns | 0.0040 ns | 0.0037 ns |           - |           - |           - |                   - |
            FromULong |  1.6089 ns | 0.0013 ns | 0.0011 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.6703 ns | 0.0038 ns | 0.0035 ns |           - |           - |           - |                   - |
            FromFloat |  3.4408 ns | 0.0045 ns | 0.0042 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.0150 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
           FromDouble |  2.5550 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  3.5164 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
          FromDecimal | 12.9583 ns | 0.0062 ns | 0.0055 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 23.6453 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6909 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.4118 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
           FromObject |  2.2342 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
           FromString | 40.5356 ns | 0.0536 ns | 0.0502 ns |           - |           - |           - |                   - |
             FromEnum |  0.7143 ns | 0.0022 ns | 0.0019 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.1539 ns | 0.0090 ns | 0.0079 ns |           - |           - |           - |                   - |
