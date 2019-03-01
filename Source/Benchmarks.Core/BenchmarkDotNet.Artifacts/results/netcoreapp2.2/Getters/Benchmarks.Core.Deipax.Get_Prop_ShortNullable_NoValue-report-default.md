
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.437 ns | 0.0036 ns | 0.0032 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.133 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
             ToChar |  1.452 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.382 ns | 0.0057 ns | 0.0050 ns |           - |           - |           - |                   - |
            ToSByte |  1.434 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.145 ns | 0.0059 ns | 0.0056 ns |           - |           - |           - |                   - |
             ToByte |  1.436 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.133 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
            ToShort |  1.517 ns | 0.0048 ns | 0.0044 ns |           - |           - |           - |                   - |
    ToShortNullable |  1.149 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
           ToUShort |  1.494 ns | 0.0019 ns | 0.0016 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.365 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
              ToInt |  1.479 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.134 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
             ToUInt |  1.612 ns | 0.0093 ns | 0.0082 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.365 ns | 0.0029 ns | 0.0028 ns |           - |           - |           - |                   - |
             ToLong |  1.606 ns | 0.0082 ns | 0.0077 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.121 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
            ToULong |  1.471 ns | 0.0038 ns | 0.0035 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.237 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
            ToFloat |  1.446 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.364 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
           ToDouble |  1.604 ns | 0.0023 ns | 0.0020 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.991 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
          ToDecimal |  2.117 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 10.610 ns | 0.0110 ns | 0.0097 ns |           - |           - |           - |                   - |
         ToDateTime |  2.158 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.119 ns | 0.0053 ns | 0.0050 ns |           - |           - |           - |                   - |
           ToObject |  1.607 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
          To_String |  1.763 ns | 0.0034 ns | 0.0031 ns |           - |           - |           - |                   - |
             ToEnum |  1.444 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.365 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
