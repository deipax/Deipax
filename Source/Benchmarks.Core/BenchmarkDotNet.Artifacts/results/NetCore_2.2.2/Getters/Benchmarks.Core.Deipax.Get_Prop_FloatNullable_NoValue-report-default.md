
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.274 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.388 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
             ToChar |  1.034 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.388 ns | 0.0035 ns | 0.0032 ns |           - |           - |           - |                   - |
            ToSByte |  1.258 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.388 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
             ToByte |  1.310 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.386 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
            ToShort |  1.242 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.390 ns | 0.0040 ns | 0.0037 ns |           - |           - |           - |                   - |
           ToUShort |  1.402 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.387 ns | 0.0023 ns | 0.0020 ns |           - |           - |           - |                   - |
              ToInt |  1.550 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.388 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
             ToUInt |  1.425 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.377 ns | 0.0057 ns | 0.0054 ns |           - |           - |           - |                   - |
             ToLong |  1.402 ns | 0.0035 ns | 0.0033 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.102 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
            ToULong |  1.236 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.341 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
            ToFloat |  1.656 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
    ToFloatNullable |  1.198 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
           ToDouble |  1.657 ns | 0.0013 ns | 0.0011 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.858 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
          ToDecimal |  2.312 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 10.586 ns | 0.0033 ns | 0.0030 ns |           - |           - |           - |                   - |
         ToDateTime |  2.135 ns | 0.0023 ns | 0.0019 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.575 ns | 0.0148 ns | 0.0138 ns |           - |           - |           - |                   - |
           ToObject |  1.283 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
          To_String |  1.653 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
             ToEnum |  1.424 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.617 ns | 0.0026 ns | 0.0025 ns |           - |           - |           - |                   - |
