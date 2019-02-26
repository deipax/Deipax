
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |   1.142 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToBoolNullable |  10.095 ns | 0.0051 ns | 0.0045 ns |           - |           - |           - |                   - |
             ToChar |   1.369 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToCharNullable |  10.098 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
            ToSByte |   1.135 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
    ToSByteNullable |  10.101 ns | 0.0079 ns | 0.0070 ns |           - |           - |           - |                   - |
             ToByte |   1.364 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToByteNullable |  10.103 ns | 0.0095 ns | 0.0085 ns |           - |           - |           - |                   - |
            ToShort |   1.141 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
    ToShortNullable |  10.093 ns | 0.0059 ns | 0.0052 ns |           - |           - |           - |                   - |
           ToUShort |   1.367 ns | 0.0029 ns | 0.0026 ns |           - |           - |           - |                   - |
   ToUShortNullable |  10.098 ns | 0.0071 ns | 0.0067 ns |           - |           - |           - |                   - |
              ToInt |   1.139 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
      ToIntNullable |  10.097 ns | 0.0081 ns | 0.0075 ns |           - |           - |           - |                   - |
             ToUInt |   1.533 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
     ToUIntNullable |  10.122 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
             ToLong |   1.142 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
     ToLongNullable |   1.642 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
            ToULong |   1.143 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
    ToULongNullable |   1.640 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
            ToFloat |   1.358 ns | 0.0008 ns | 0.0006 ns |           - |           - |           - |                   - |
    ToFloatNullable |  10.105 ns | 0.0066 ns | 0.0055 ns |           - |           - |           - |                   - |
           ToDouble |   1.172 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
   ToDoubleNullable |   1.810 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
          ToDecimal |   8.680 ns | 0.0149 ns | 0.0132 ns |           - |           - |           - |                   - |
  ToDecimalNullable |   1.827 ns | 0.0027 ns | 0.0022 ns |           - |           - |           - |                   - |
         ToDateTime |   1.747 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |   1.594 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
           ToObject |   4.535 ns | 0.0113 ns | 0.0095 ns |      0.0038 |           - |           - |                24 B |
          To_String | 270.518 ns | 0.2097 ns | 0.1859 ns |      0.0262 |           - |           - |               168 B |
             ToEnum |  11.834 ns | 0.0100 ns | 0.0093 ns |           - |           - |           - |                   - |
     ToEnumNullable |  16.875 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
