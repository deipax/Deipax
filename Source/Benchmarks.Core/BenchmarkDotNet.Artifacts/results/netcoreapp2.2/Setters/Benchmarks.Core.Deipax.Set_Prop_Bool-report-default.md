
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.7042 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.1817 ns | 0.0032 ns | 0.0028 ns |           - |           - |           - |                   - |
             FromChar |  0.7212 ns | 0.0016 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.9340 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
            FromSByte |  0.7004 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.1691 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
             FromByte |  0.7019 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.1691 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            FromShort |  0.7037 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.1620 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
           FromUShort |  0.9427 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
   FromUShortNullable |  0.9350 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
              FromInt |  0.7049 ns | 0.0039 ns | 0.0030 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.1617 ns | 0.0028 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromUInt |  0.9071 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.1430 ns | 0.0065 ns | 0.0061 ns |           - |           - |           - |                   - |
             FromLong |  0.6763 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.4180 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
            FromULong |  0.6772 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.6319 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
            FromFloat |  0.9045 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
    FromFloatNullable |  0.9897 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
           FromDouble |  0.7075 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.6531 ns | 0.0174 ns | 0.0162 ns |           - |           - |           - |                   - |
          FromDecimal |  7.5614 ns | 0.0120 ns | 0.0100 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 17.0055 ns | 0.0125 ns | 0.0111 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6774 ns | 0.0010 ns | 0.0008 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.3917 ns | 0.0029 ns | 0.0026 ns |           - |           - |           - |                   - |
           FromObject |  2.2388 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromString | 19.7105 ns | 0.0663 ns | 0.0620 ns |           - |           - |           - |                   - |
             FromEnum |  0.6759 ns | 0.0031 ns | 0.0028 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.1397 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
