
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6572 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.1271 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromChar |  0.6720 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.0679 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
            FromSByte |  0.5606 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    FromSByteNullable |  0.9233 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
             FromByte |  0.5584 ns | 0.0008 ns | 0.0007 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.9086 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
            FromShort |  0.6341 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.0873 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
           FromUShort |  0.6673 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.0896 ns | 0.0033 ns | 0.0029 ns |           - |           - |           - |                   - |
              FromInt |  0.5687 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.0391 ns | 0.0013 ns | 0.0013 ns |           - |           - |           - |                   - |
             FromUInt |  0.7176 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.1698 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
             FromLong |  0.7040 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.1740 ns | 0.0036 ns | 0.0034 ns |           - |           - |           - |                   - |
            FromULong |  1.3890 ns | 0.0021 ns | 0.0018 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.9847 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
            FromFloat |  2.1648 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
    FromFloatNullable |  2.8225 ns | 0.0020 ns | 0.0016 ns |           - |           - |           - |                   - |
           FromDouble |  1.9203 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  3.3149 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
          FromDecimal | 13.2743 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 24.6266 ns | 0.0144 ns | 0.0128 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7085 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6590 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
           FromObject | 14.2328 ns | 0.0099 ns | 0.0092 ns |           - |           - |           - |                   - |
           FromString | 39.6256 ns | 0.0675 ns | 0.0599 ns |           - |           - |           - |                   - |
             FromEnum |  0.9427 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.7170 ns | 0.0044 ns | 0.0039 ns |           - |           - |           - |                   - |
