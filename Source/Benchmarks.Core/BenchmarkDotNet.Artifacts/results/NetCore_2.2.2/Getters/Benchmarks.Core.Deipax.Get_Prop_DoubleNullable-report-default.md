
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |   1.438 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
     ToBoolNullable |   5.059 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
             ToChar |   1.411 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
     ToCharNullable |   4.366 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
            ToSByte |   4.556 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
    ToSByteNullable |   6.899 ns | 0.0057 ns | 0.0053 ns |           - |           - |           - |                   - |
             ToByte |   4.513 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
     ToByteNullable |   6.876 ns | 0.0047 ns | 0.0042 ns |           - |           - |           - |                   - |
            ToShort |   4.619 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
    ToShortNullable |   6.880 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
           ToUShort |   4.573 ns | 0.0057 ns | 0.0053 ns |           - |           - |           - |                   - |
   ToUShortNullable |   6.893 ns | 0.0079 ns | 0.0070 ns |           - |           - |           - |                   - |
              ToInt |   3.242 ns | 0.0085 ns | 0.0076 ns |           - |           - |           - |                   - |
      ToIntNullable |   6.195 ns | 0.0060 ns | 0.0056 ns |           - |           - |           - |                   - |
             ToUInt |   3.391 ns | 0.0126 ns | 0.0118 ns |           - |           - |           - |                   - |
     ToUIntNullable |   6.211 ns | 0.0073 ns | 0.0069 ns |           - |           - |           - |                   - |
             ToLong |   2.803 ns | 0.0041 ns | 0.0039 ns |           - |           - |           - |                   - |
     ToLongNullable |   3.390 ns | 0.0348 ns | 0.0325 ns |           - |           - |           - |                   - |
            ToULong |   2.629 ns | 0.0034 ns | 0.0031 ns |           - |           - |           - |                   - |
    ToULongNullable |   3.485 ns | 0.0202 ns | 0.0189 ns |           - |           - |           - |                   - |
            ToFloat |   1.611 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
    ToFloatNullable |   4.826 ns | 0.0035 ns | 0.0031 ns |           - |           - |           - |                   - |
           ToDouble |   1.677 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
   ToDoubleNullable |   1.866 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
          ToDecimal |  53.947 ns | 0.0439 ns | 0.0410 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  64.511 ns | 0.0441 ns | 0.0412 ns |           - |           - |           - |                   - |
         ToDateTime |   2.324 ns | 0.0035 ns | 0.0033 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |   8.094 ns | 0.0110 ns | 0.0103 ns |           - |           - |           - |                   - |
           ToObject |   4.411 ns | 0.0031 ns | 0.0029 ns |      0.0038 |           - |           - |                24 B |
          To_String | 107.740 ns | 0.1427 ns | 0.1335 ns |      0.0050 |           - |           - |                32 B |
             ToEnum |  14.140 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
     ToEnumNullable |  18.378 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
