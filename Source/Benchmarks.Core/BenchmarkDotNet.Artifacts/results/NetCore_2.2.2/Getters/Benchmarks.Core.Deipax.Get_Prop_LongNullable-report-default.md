
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.386 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.370 ns | 0.0026 ns | 0.0025 ns |           - |           - |           - |                   - |
             ToChar |  2.525 ns | 0.0133 ns | 0.0111 ns |           - |           - |           - |                   - |
     ToCharNullable |  5.057 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
            ToSByte |  2.548 ns | 0.0037 ns | 0.0031 ns |           - |           - |           - |                   - |
    ToSByteNullable |  5.058 ns | 0.0036 ns | 0.0034 ns |           - |           - |           - |                   - |
             ToByte |  2.532 ns | 0.0149 ns | 0.0139 ns |           - |           - |           - |                   - |
     ToByteNullable |  5.059 ns | 0.0037 ns | 0.0035 ns |           - |           - |           - |                   - |
            ToShort |  2.536 ns | 0.0023 ns | 0.0020 ns |           - |           - |           - |                   - |
    ToShortNullable |  5.057 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
           ToUShort |  2.520 ns | 0.0145 ns | 0.0135 ns |           - |           - |           - |                   - |
   ToUShortNullable |  5.066 ns | 0.0042 ns | 0.0039 ns |           - |           - |           - |                   - |
              ToInt |  2.548 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
      ToIntNullable |  5.059 ns | 0.0051 ns | 0.0048 ns |           - |           - |           - |                   - |
             ToUInt |  2.400 ns | 0.0040 ns | 0.0037 ns |           - |           - |           - |                   - |
     ToUIntNullable |  5.056 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
             ToLong |  1.641 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.612 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
            ToULong |  1.441 ns | 0.0022 ns | 0.0018 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.092 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
            ToFloat |  1.422 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.600 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
           ToDouble |  1.632 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.839 ns | 0.0021 ns | 0.0018 ns |           - |           - |           - |                   - |
          ToDecimal |  5.970 ns | 0.0037 ns | 0.0034 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 28.373 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
         ToDateTime |  2.302 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
 ToDateTimeNullable | 16.487 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
           ToObject |  4.319 ns | 0.0034 ns | 0.0032 ns |      0.0038 |           - |           - |                24 B |
          To_String | 18.477 ns | 0.0155 ns | 0.0137 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 12.791 ns | 0.0053 ns | 0.0050 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.783 ns | 0.0104 ns | 0.0097 ns |           - |           - |           - |                   - |
