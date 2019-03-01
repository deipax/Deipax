
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6735 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromBoolNullable |  0.9209 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromChar |  1.3770 ns | 0.0121 ns | 0.0108 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.7910 ns | 0.0323 ns | 0.0270 ns |           - |           - |           - |                   - |
            FromSByte |  1.3394 ns | 0.0234 ns | 0.0208 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.8199 ns | 0.0692 ns | 0.0613 ns |           - |           - |           - |                   - |
             FromByte |  0.5430 ns | 0.0070 ns | 0.0062 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.5745 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
            FromShort |  1.8610 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.5199 ns | 0.0571 ns | 0.0506 ns |           - |           - |           - |                   - |
           FromUShort |  1.3932 ns | 0.0478 ns | 0.0447 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.7781 ns | 0.0312 ns | 0.0276 ns |           - |           - |           - |                   - |
              FromInt |  1.7806 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.4789 ns | 0.0028 ns | 0.0025 ns |           - |           - |           - |                   - |
             FromUInt |  1.4152 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.9287 ns | 0.0017 ns | 0.0014 ns |           - |           - |           - |                   - |
             FromLong |  1.8044 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.8829 ns | 0.0031 ns | 0.0028 ns |           - |           - |           - |                   - |
            FromULong |  1.7051 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.8874 ns | 0.0037 ns | 0.0035 ns |           - |           - |           - |                   - |
            FromFloat |  4.0018 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
    FromFloatNullable |  4.4584 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
           FromDouble |  3.8769 ns | 0.0031 ns | 0.0027 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.6550 ns | 0.0043 ns | 0.0040 ns |           - |           - |           - |                   - |
          FromDecimal | 13.1873 ns | 0.0103 ns | 0.0097 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 24.4700 ns | 0.0203 ns | 0.0190 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7132 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6529 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
           FromObject | 13.7744 ns | 0.0101 ns | 0.0094 ns |           - |           - |           - |                   - |
           FromString | 42.0678 ns | 0.0361 ns | 0.0338 ns |           - |           - |           - |                   - |
             FromEnum |  1.8770 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.6866 ns | 0.0086 ns | 0.0080 ns |           - |           - |           - |                   - |
