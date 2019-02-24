
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 11.2750 ns | 0.0082 ns | 0.0077 ns |           - |           - |           - |                   - |
     FromBoolNullable | 11.8535 ns | 0.0059 ns | 0.0055 ns |           - |           - |           - |                   - |
             FromChar |  0.9746 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.5809 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
            FromSByte | 17.0022 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
    FromSByteNullable | 11.5135 ns | 0.0035 ns | 0.0031 ns |           - |           - |           - |                   - |
             FromByte | 16.0922 ns | 0.0115 ns | 0.0102 ns |           - |           - |           - |                   - |
     FromByteNullable | 11.7559 ns | 0.0106 ns | 0.0094 ns |           - |           - |           - |                   - |
            FromShort | 11.2830 ns | 0.0079 ns | 0.0070 ns |           - |           - |           - |                   - |
    FromShortNullable | 11.5224 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
           FromUShort | 11.0798 ns | 0.0059 ns | 0.0055 ns |           - |           - |           - |                   - |
   FromUShortNullable | 11.5096 ns | 0.0085 ns | 0.0080 ns |           - |           - |           - |                   - |
              FromInt | 16.9928 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
      FromIntNullable | 11.7393 ns | 0.0065 ns | 0.0061 ns |           - |           - |           - |                   - |
             FromUInt | 11.2707 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
     FromUIntNullable | 11.5164 ns | 0.0091 ns | 0.0076 ns |           - |           - |           - |                   - |
             FromLong | 11.2998 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
     FromLongNullable | 12.1785 ns | 0.0084 ns | 0.0078 ns |           - |           - |           - |                   - |
            FromULong | 11.0389 ns | 0.0096 ns | 0.0090 ns |           - |           - |           - |                   - |
    FromULongNullable | 12.1722 ns | 0.0155 ns | 0.0145 ns |           - |           - |           - |                   - |
            FromFloat | 23.1867 ns | 0.0175 ns | 0.0164 ns |           - |           - |           - |                   - |
    FromFloatNullable | 22.8422 ns | 0.0119 ns | 0.0112 ns |           - |           - |           - |                   - |
           FromDouble | 53.2817 ns | 0.0259 ns | 0.0242 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 53.9412 ns | 0.1632 ns | 0.1527 ns |           - |           - |           - |                   - |
          FromDecimal |  1.1175 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  3.9468 ns | 0.0053 ns | 0.0050 ns |           - |           - |           - |                   - |
         FromDateTime |  1.1714 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  7.9595 ns | 0.0174 ns | 0.0163 ns |           - |           - |           - |                   - |
           FromObject |  8.1641 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
           FromString | 69.9536 ns | 0.0557 ns | 0.0521 ns |           - |           - |           - |                   - |
             FromEnum | 11.2619 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
     FromEnumNullable | 11.7519 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
