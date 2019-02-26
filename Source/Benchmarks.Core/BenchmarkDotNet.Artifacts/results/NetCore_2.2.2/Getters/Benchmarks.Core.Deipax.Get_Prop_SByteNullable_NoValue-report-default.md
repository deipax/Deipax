
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.451 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.146 ns | 0.0022 ns | 0.0019 ns |           - |           - |           - |                   - |
             ToChar |  1.489 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.372 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
            ToSByte |  1.639 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
    ToSByteNullable |  1.168 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
             ToByte |  1.550 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.380 ns | 0.0040 ns | 0.0038 ns |           - |           - |           - |                   - |
            ToShort |  1.564 ns | 0.0043 ns | 0.0038 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.147 ns | 0.0040 ns | 0.0038 ns |           - |           - |           - |                   - |
           ToUShort |  1.514 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.373 ns | 0.0037 ns | 0.0035 ns |           - |           - |           - |                   - |
              ToInt |  1.493 ns | 0.0024 ns | 0.0021 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.147 ns | 0.0028 ns | 0.0025 ns |           - |           - |           - |                   - |
             ToUInt |  1.618 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.374 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
             ToLong |  1.617 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.189 ns | 0.0023 ns | 0.0020 ns |           - |           - |           - |                   - |
            ToULong |  1.471 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.149 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
            ToFloat |  1.463 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.374 ns | 0.0036 ns | 0.0033 ns |           - |           - |           - |                   - |
           ToDouble |  1.619 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.026 ns | 0.0042 ns | 0.0039 ns |           - |           - |           - |                   - |
          ToDecimal |  2.139 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 10.623 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
         ToDateTime |  2.175 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.129 ns | 0.0071 ns | 0.0067 ns |           - |           - |           - |                   - |
           ToObject |  1.619 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
          To_String |  1.637 ns | 0.0057 ns | 0.0053 ns |           - |           - |           - |                   - |
             ToEnum |  1.457 ns | 0.0012 ns | 0.0010 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.372 ns | 0.0028 ns | 0.0025 ns |           - |           - |           - |                   - |
