
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  7.407 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
     FromBoolNullable |  7.720 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
             FromChar |  7.443 ns | 0.0080 ns | 0.0075 ns |           - |           - |           - |                   - |
     FromCharNullable |  7.737 ns | 0.0131 ns | 0.0123 ns |           - |           - |           - |                   - |
            FromSByte |  7.474 ns | 0.0053 ns | 0.0047 ns |           - |           - |           - |                   - |
    FromSByteNullable |  7.859 ns | 0.0055 ns | 0.0052 ns |           - |           - |           - |                   - |
             FromByte |  7.652 ns | 0.0091 ns | 0.0085 ns |           - |           - |           - |                   - |
     FromByteNullable |  7.749 ns | 0.0080 ns | 0.0075 ns |           - |           - |           - |                   - |
            FromShort |  7.436 ns | 0.0052 ns | 0.0048 ns |           - |           - |           - |                   - |
    FromShortNullable |  7.910 ns | 0.0149 ns | 0.0139 ns |           - |           - |           - |                   - |
           FromUShort |  7.420 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
   FromUShortNullable |  7.679 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
              FromInt |  7.485 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
      FromIntNullable |  7.752 ns | 0.0071 ns | 0.0063 ns |           - |           - |           - |                   - |
             FromUInt | 15.605 ns | 0.0211 ns | 0.0197 ns |           - |           - |           - |                   - |
     FromUIntNullable |  7.796 ns | 0.0117 ns | 0.0098 ns |           - |           - |           - |                   - |
             FromLong |  7.470 ns | 0.0049 ns | 0.0043 ns |           - |           - |           - |                   - |
     FromLongNullable |  7.972 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
            FromULong |  7.542 ns | 0.0072 ns | 0.0067 ns |           - |           - |           - |                   - |
    FromULongNullable |  8.095 ns | 0.0061 ns | 0.0051 ns |           - |           - |           - |                   - |
            FromFloat |  7.925 ns | 0.0115 ns | 0.0096 ns |           - |           - |           - |                   - |
    FromFloatNullable | 11.488 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
           FromDouble |  7.944 ns | 0.0069 ns | 0.0065 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  7.972 ns | 0.0086 ns | 0.0080 ns |           - |           - |           - |                   - |
          FromDecimal |  8.169 ns | 0.0362 ns | 0.0339 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.352 ns | 0.0073 ns | 0.0065 ns |           - |           - |           - |                   - |
         FromDateTime |  4.149 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.178 ns | 0.0025 ns | 0.0024 ns |           - |           - |           - |                   - |
           FromObject |  8.650 ns | 0.0073 ns | 0.0069 ns |           - |           - |           - |                   - |
           FromString |  7.947 ns | 0.0048 ns | 0.0044 ns |           - |           - |           - |                   - |
             FromEnum |  7.735 ns | 0.0055 ns | 0.0048 ns |           - |           - |           - |                   - |
     FromEnumNullable |  7.692 ns | 0.0044 ns | 0.0039 ns |           - |           - |           - |                   - |
