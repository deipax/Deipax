
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |   3.564 ns | 0.0087 ns | 0.0077 ns |           - |           - |           - |                   - |
     FromBoolNullable |   2.086 ns | 0.0028 ns | 0.0025 ns |           - |           - |           - |                   - |
             FromChar |   4.657 ns | 0.0045 ns | 0.0042 ns |      0.0051 |           - |           - |                32 B |
     FromCharNullable |   5.192 ns | 0.0059 ns | 0.0053 ns |      0.0051 |           - |           - |                32 B |
            FromSByte |  17.712 ns | 0.0128 ns | 0.0120 ns |      0.0051 |           - |           - |                32 B |
    FromSByteNullable |  19.308 ns | 0.0156 ns | 0.0146 ns |      0.0051 |           - |           - |                32 B |
             FromByte |  17.526 ns | 0.0134 ns | 0.0125 ns |      0.0051 |           - |           - |                32 B |
     FromByteNullable |  19.002 ns | 0.0159 ns | 0.0133 ns |      0.0051 |           - |           - |                32 B |
            FromShort |  17.808 ns | 0.0254 ns | 0.0237 ns |      0.0051 |           - |           - |                32 B |
    FromShortNullable |  18.457 ns | 0.0160 ns | 0.0150 ns |      0.0051 |           - |           - |                32 B |
           FromUShort |  17.542 ns | 0.0158 ns | 0.0140 ns |      0.0051 |           - |           - |                32 B |
   FromUShortNullable |  18.229 ns | 0.0231 ns | 0.0216 ns |      0.0051 |           - |           - |                32 B |
              FromInt |  17.682 ns | 0.0104 ns | 0.0092 ns |      0.0051 |           - |           - |                32 B |
      FromIntNullable |  18.265 ns | 0.0175 ns | 0.0164 ns |      0.0051 |           - |           - |                32 B |
             FromUInt |  17.593 ns | 0.0154 ns | 0.0144 ns |      0.0051 |           - |           - |                32 B |
     FromUIntNullable |  17.858 ns | 0.0329 ns | 0.0308 ns |      0.0051 |           - |           - |                32 B |
             FromLong |  18.817 ns | 0.0338 ns | 0.0316 ns |      0.0051 |           - |           - |                32 B |
     FromLongNullable |  20.414 ns | 0.0228 ns | 0.0213 ns |      0.0051 |           - |           - |                32 B |
            FromULong |  19.015 ns | 0.0287 ns | 0.0268 ns |      0.0051 |           - |           - |                32 B |
    FromULongNullable |  20.349 ns | 0.3507 ns | 0.3109 ns |      0.0051 |           - |           - |                32 B |
            FromFloat | 107.274 ns | 0.4398 ns | 0.3899 ns |      0.0050 |           - |           - |                32 B |
    FromFloatNullable | 104.321 ns | 0.5164 ns | 0.4578 ns |      0.0050 |           - |           - |                32 B |
           FromDouble | 108.079 ns | 0.2430 ns | 0.2154 ns |      0.0050 |           - |           - |                32 B |
   FromDoubleNullable | 110.196 ns | 0.0528 ns | 0.0468 ns |      0.0050 |           - |           - |                32 B |
          FromDecimal |  47.888 ns | 0.0382 ns | 0.0339 ns |      0.0051 |           - |           - |                32 B |
  FromDecimalNullable |  50.359 ns | 0.0457 ns | 0.0428 ns |      0.0051 |           - |           - |                32 B |
         FromDateTime | 270.883 ns | 0.2676 ns | 0.2372 ns |      0.0262 |           - |           - |               168 B |
 FromDateTimeNullable |   2.606 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
           FromObject |   2.161 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
           FromString |   1.814 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
             FromEnum |  50.105 ns | 0.0964 ns | 0.0902 ns |      0.0038 |           - |           - |                24 B |
     FromEnumNullable |  52.259 ns | 0.1888 ns | 0.1766 ns |      0.0038 |           - |           - |                24 B |
