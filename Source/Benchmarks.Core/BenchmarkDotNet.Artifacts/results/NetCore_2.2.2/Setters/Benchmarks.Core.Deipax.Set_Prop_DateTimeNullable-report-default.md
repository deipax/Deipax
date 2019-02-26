
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |   7.421 ns | 0.0092 ns | 0.0077 ns |           - |           - |           - |                   - |
     FromBoolNullable |   7.690 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
             FromChar |   7.459 ns | 0.0049 ns | 0.0043 ns |           - |           - |           - |                   - |
     FromCharNullable |   7.753 ns | 0.0145 ns | 0.0136 ns |           - |           - |           - |                   - |
            FromSByte |   7.494 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
    FromSByteNullable |   7.944 ns | 0.0060 ns | 0.0053 ns |           - |           - |           - |                   - |
             FromByte |   7.650 ns | 0.0067 ns | 0.0059 ns |           - |           - |           - |                   - |
     FromByteNullable |   7.720 ns | 0.0097 ns | 0.0091 ns |           - |           - |           - |                   - |
            FromShort |   7.491 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
    FromShortNullable |   7.905 ns | 0.0070 ns | 0.0062 ns |           - |           - |           - |                   - |
           FromUShort |   7.447 ns | 0.0101 ns | 0.0094 ns |           - |           - |           - |                   - |
   FromUShortNullable |   7.725 ns | 0.0067 ns | 0.0062 ns |           - |           - |           - |                   - |
              FromInt |   7.438 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
      FromIntNullable |   7.758 ns | 0.0100 ns | 0.0094 ns |           - |           - |           - |                   - |
             FromUInt |   7.564 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
     FromUIntNullable |   7.689 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
             FromLong |   7.545 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
     FromLongNullable |   7.978 ns | 0.0048 ns | 0.0045 ns |           - |           - |           - |                   - |
            FromULong |   7.470 ns | 0.0063 ns | 0.0053 ns |           - |           - |           - |                   - |
    FromULongNullable |   8.302 ns | 0.0100 ns | 0.0089 ns |           - |           - |           - |                   - |
            FromFloat |   7.918 ns | 0.0088 ns | 0.0078 ns |           - |           - |           - |                   - |
    FromFloatNullable |   7.909 ns | 0.0051 ns | 0.0048 ns |           - |           - |           - |                   - |
           FromDouble |   7.978 ns | 0.0067 ns | 0.0063 ns |           - |           - |           - |                   - |
   FromDoubleNullable |   7.997 ns | 0.0075 ns | 0.0066 ns |           - |           - |           - |                   - |
          FromDecimal |   7.989 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
  FromDecimalNullable |   8.384 ns | 0.0127 ns | 0.0119 ns |           - |           - |           - |                   - |
         FromDateTime |   4.154 ns | 0.0037 ns | 0.0034 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |   1.173 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
           FromObject |  19.518 ns | 0.0282 ns | 0.0264 ns |           - |           - |           - |                   - |
           FromString | 320.068 ns | 0.2431 ns | 0.2274 ns |           - |           - |           - |                   - |
             FromEnum |   7.682 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
     FromEnumNullable |   7.744 ns | 0.0100 ns | 0.0094 ns |           - |           - |           - |                   - |
