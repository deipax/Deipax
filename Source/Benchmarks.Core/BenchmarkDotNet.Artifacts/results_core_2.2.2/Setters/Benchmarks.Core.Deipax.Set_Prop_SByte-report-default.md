
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8928 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.1284 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromChar |  1.0644 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.5966 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            FromSByte |  0.4375 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.5290 ns | 0.0016 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromByte |  1.0492 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.4278 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
            FromShort |  1.6319 ns | 0.0024 ns | 0.0021 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.0635 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
           FromUShort |  1.0526 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.5936 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
              FromInt |  1.5696 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.1222 ns | 0.0085 ns | 0.0080 ns |           - |           - |           - |                   - |
             FromUInt |  1.4797 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.6274 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
             FromLong |  1.6273 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.6745 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
            FromULong |  1.1547 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.8726 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
            FromFloat |  3.9170 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
    FromFloatNullable |  4.0412 ns | 0.0056 ns | 0.0049 ns |           - |           - |           - |                   - |
           FromDouble |  3.8259 ns | 0.0011 ns | 0.0009 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.9196 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
          FromDecimal | 13.6098 ns | 0.0119 ns | 0.0106 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 25.6907 ns | 0.0195 ns | 0.0173 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6822 ns | 0.0013 ns | 0.0011 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.4494 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromObject |  2.2283 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
           FromString | 41.7770 ns | 0.0861 ns | 0.0805 ns |           - |           - |           - |                   - |
             FromEnum |  1.6829 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.4346 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
