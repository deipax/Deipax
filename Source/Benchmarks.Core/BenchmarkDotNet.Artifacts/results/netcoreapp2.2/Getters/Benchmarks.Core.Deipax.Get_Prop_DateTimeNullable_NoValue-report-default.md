
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.140 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
     ToBoolNullable | 10.094 ns | 0.0067 ns | 0.0063 ns |           - |           - |           - |                   - |
             ToChar |  1.370 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
     ToCharNullable | 10.099 ns | 0.0059 ns | 0.0055 ns |           - |           - |           - |                   - |
            ToSByte |  1.136 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
    ToSByteNullable | 10.102 ns | 0.0069 ns | 0.0058 ns |           - |           - |           - |                   - |
             ToByte |  1.364 ns | 0.0019 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToByteNullable | 10.105 ns | 0.0070 ns | 0.0065 ns |           - |           - |           - |                   - |
            ToShort |  1.142 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
    ToShortNullable | 10.097 ns | 0.0079 ns | 0.0066 ns |           - |           - |           - |                   - |
           ToUShort |  1.371 ns | 0.0036 ns | 0.0033 ns |           - |           - |           - |                   - |
   ToUShortNullable | 10.096 ns | 0.0090 ns | 0.0080 ns |           - |           - |           - |                   - |
              ToInt |  1.136 ns | 0.0029 ns | 0.0026 ns |           - |           - |           - |                   - |
      ToIntNullable | 10.105 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
             ToUInt |  1.362 ns | 0.0026 ns | 0.0021 ns |           - |           - |           - |                   - |
     ToUIntNullable | 10.113 ns | 0.0098 ns | 0.0092 ns |           - |           - |           - |                   - |
             ToLong |  1.146 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.639 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
            ToULong |  1.131 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.642 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
            ToFloat |  1.356 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
    ToFloatNullable | 10.094 ns | 0.0056 ns | 0.0053 ns |           - |           - |           - |                   - |
           ToDouble |  1.174 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.808 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
          ToDecimal |  8.708 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  1.823 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
         ToDateTime |  2.520 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  1.819 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
           ToObject |  1.609 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
          To_String |  1.588 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
             ToEnum |  1.593 ns | 0.0009 ns | 0.0008 ns |           - |           - |           - |                   - |
     ToEnumNullable | 10.128 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
