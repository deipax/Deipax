
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6661 ns | 0.0041 ns | 0.0038 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.4972 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
             FromChar |  0.4046 ns | 0.0023 ns | 0.0020 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.6837 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
            FromSByte |  0.6609 ns | 0.0010 ns | 0.0008 ns |           - |           - |           - |                   - |
    FromSByteNullable |  0.9025 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromByte |  0.6743 ns | 0.0008 ns | 0.0008 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.9016 ns | 0.0031 ns | 0.0028 ns |           - |           - |           - |                   - |
            FromShort |  0.6658 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
    FromShortNullable |  0.8917 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromUShort |  0.6653 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
   FromUShortNullable |  0.8996 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
              FromInt |  0.6651 ns | 0.0009 ns | 0.0007 ns |           - |           - |           - |                   - |
      FromIntNullable |  0.8474 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
             FromUInt |  0.7144 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.1522 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
             FromLong |  0.7059 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.7456 ns | 0.0037 ns | 0.0034 ns |           - |           - |           - |                   - |
            FromULong |  0.9332 ns | 0.0122 ns | 0.0114 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.7030 ns | 0.0018 ns | 0.0015 ns |           - |           - |           - |                   - |
            FromFloat |  0.7279 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
    FromFloatNullable |  0.9660 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromDouble |  0.7308 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.6044 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
          FromDecimal | 10.3999 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 25.4728 ns | 0.0106 ns | 0.0099 ns |           - |           - |           - |                   - |
         FromDateTime |  0.9301 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.4173 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
           FromObject |  2.2042 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
           FromString | 60.4783 ns | 0.0650 ns | 0.0608 ns |           - |           - |           - |                   - |
             FromEnum |  0.9523 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
     FromEnumNullable |  0.9250 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
