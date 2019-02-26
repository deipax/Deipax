
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.599 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.141 ns | 0.0035 ns | 0.0033 ns |           - |           - |           - |                   - |
             ToChar |  1.471 ns | 0.0019 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.368 ns | 0.0035 ns | 0.0033 ns |           - |           - |           - |                   - |
            ToSByte |  1.520 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.375 ns | 0.0041 ns | 0.0038 ns |           - |           - |           - |                   - |
             ToByte |  1.590 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.367 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
            ToShort |  1.600 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.139 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
           ToUShort |  1.528 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.372 ns | 0.0023 ns | 0.0020 ns |           - |           - |           - |                   - |
              ToInt |  1.593 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.368 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
             ToUInt |  1.493 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
     ToUIntNullable |  1.146 ns | 0.0042 ns | 0.0035 ns |           - |           - |           - |                   - |
             ToLong |  1.414 ns | 0.0349 ns | 0.0309 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.834 ns | 0.0071 ns | 0.0067 ns |           - |           - |           - |                   - |
            ToULong |  1.625 ns | 0.0113 ns | 0.0105 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.098 ns | 0.0495 ns | 0.0463 ns |           - |           - |           - |                   - |
            ToFloat |  1.622 ns | 0.0077 ns | 0.0068 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.454 ns | 0.0257 ns | 0.0214 ns |           - |           - |           - |                   - |
           ToDouble |  1.587 ns | 0.0053 ns | 0.0041 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.045 ns | 0.0090 ns | 0.0080 ns |           - |           - |           - |                   - |
          ToDecimal |  2.132 ns | 0.0701 ns | 0.1209 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 10.695 ns | 0.0755 ns | 0.0669 ns |           - |           - |           - |                   - |
         ToDateTime |  2.296 ns | 0.0147 ns | 0.0123 ns |           - |           - |           - |                   - |
 ToDateTimeNullable | 16.842 ns | 0.1780 ns | 0.1578 ns |           - |           - |           - |                   - |
           ToObject |  1.456 ns | 0.0183 ns | 0.0172 ns |           - |           - |           - |                   - |
          To_String |  1.649 ns | 0.0060 ns | 0.0053 ns |           - |           - |           - |                   - |
             ToEnum |  1.588 ns | 0.0009 ns | 0.0008 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.366 ns | 0.0025 ns | 0.0024 ns |           - |           - |           - |                   - |
