
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.354 ns | 0.0025 ns | 0.0022 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.133 ns | 0.0050 ns | 0.0047 ns |           - |           - |           - |                   - |
             ToChar |  2.376 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.814 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
            ToSByte |  2.073 ns | 0.0026 ns | 0.0022 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.845 ns | 0.0096 ns | 0.0090 ns |           - |           - |           - |                   - |
             ToByte |  2.059 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.810 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
            ToShort |  2.384 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.838 ns | 0.0066 ns | 0.0059 ns |           - |           - |           - |                   - |
           ToUShort |  2.208 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.811 ns | 0.0026 ns | 0.0025 ns |           - |           - |           - |                   - |
              ToInt |  2.314 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.811 ns | 0.0037 ns | 0.0035 ns |           - |           - |           - |                   - |
             ToUInt |  2.415 ns | 0.0036 ns | 0.0034 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.812 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
             ToLong |  1.122 ns | 0.0021 ns | 0.0018 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.576 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            ToULong |  1.421 ns | 0.0030 ns | 0.0026 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.041 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
            ToFloat |  1.169 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.353 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
           ToDouble |  1.166 ns | 0.0013 ns | 0.0013 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.575 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
          ToDecimal |  5.955 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.072 ns | 0.0079 ns | 0.0070 ns |           - |           - |           - |                   - |
         ToDateTime |  2.039 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.772 ns | 0.0072 ns | 0.0064 ns |           - |           - |           - |                   - |
           ToObject |  3.839 ns | 0.0152 ns | 0.0142 ns |      0.0038 |           - |           - |                24 B |
          To_String | 17.810 ns | 0.0236 ns | 0.0221 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 10.465 ns | 0.0089 ns | 0.0079 ns |           - |           - |           - |                   - |
     ToEnumNullable | 15.280 ns | 0.0086 ns | 0.0080 ns |           - |           - |           - |                   - |
