
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.440 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.360 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
             ToChar |  1.408 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.368 ns | 0.0042 ns | 0.0039 ns |           - |           - |           - |                   - |
            ToSByte |  1.496 ns | 0.0032 ns | 0.0029 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.368 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
             ToByte |  1.615 ns | 0.0026 ns | 0.0022 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.369 ns | 0.0028 ns | 0.0025 ns |           - |           - |           - |                   - |
            ToShort |  1.612 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.371 ns | 0.0056 ns | 0.0052 ns |           - |           - |           - |                   - |
           ToUShort |  1.467 ns | 0.0035 ns | 0.0033 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.374 ns | 0.0039 ns | 0.0034 ns |           - |           - |           - |                   - |
              ToInt |  1.444 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.372 ns | 0.0051 ns | 0.0047 ns |           - |           - |           - |                   - |
             ToUInt |  1.619 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.365 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
             ToLong |  1.610 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.088 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
            ToULong |  1.637 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.081 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            ToFloat |  1.611 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.368 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
           ToDouble |  1.522 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.864 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
          ToDecimal |  2.149 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 10.561 ns | 0.0057 ns | 0.0053 ns |           - |           - |           - |                   - |
         ToDateTime |  2.322 ns | 0.0039 ns | 0.0036 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.083 ns | 0.0084 ns | 0.0079 ns |           - |           - |           - |                   - |
           ToObject |  1.846 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
          To_String |  1.476 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
             ToEnum |  1.614 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.597 ns | 0.0034 ns | 0.0030 ns |           - |           - |           - |                   - |
