
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.386 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.143 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
             ToChar |  1.261 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.143 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
            ToSByte |  1.405 ns | 0.0019 ns | 0.0016 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.142 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
             ToByte |  1.284 ns | 0.0037 ns | 0.0031 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.144 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
            ToShort |  1.386 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.143 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
           ToUShort |  1.267 ns | 0.0029 ns | 0.0025 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.148 ns | 0.0021 ns | 0.0017 ns |           - |           - |           - |                   - |
              ToInt |  1.405 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.145 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
             ToUInt |  1.234 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.141 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
             ToLong |  1.219 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.611 ns | 0.0031 ns | 0.0027 ns |           - |           - |           - |                   - |
            ToULong |  1.233 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.095 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
            ToFloat |  1.374 ns | 0.0041 ns | 0.0036 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.371 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
           ToDouble |  1.398 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.068 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
          ToDecimal |  2.071 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 10.568 ns | 0.0111 ns | 0.0103 ns |           - |           - |           - |                   - |
         ToDateTime |  2.303 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.548 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
           ToObject |  1.267 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
          To_String |  1.373 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
             ToEnum |  1.424 ns | 0.0176 ns | 0.0137 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.361 ns | 0.0074 ns | 0.0065 ns |           - |           - |           - |                   - |
