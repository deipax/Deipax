
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.605 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.132 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
             ToChar |  1.461 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.132 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
            ToSByte |  1.520 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.137 ns | 0.0049 ns | 0.0041 ns |           - |           - |           - |                   - |
             ToByte |  1.437 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.134 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
            ToShort |  1.535 ns | 0.0047 ns | 0.0042 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.143 ns | 0.0085 ns | 0.0079 ns |           - |           - |           - |                   - |
           ToUShort |  1.461 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.143 ns | 0.0176 ns | 0.0147 ns |           - |           - |           - |                   - |
              ToInt |  1.685 ns | 0.0054 ns | 0.0048 ns |           - |           - |           - |                   - |
      ToIntNullable |  1.133 ns | 0.0064 ns | 0.0050 ns |           - |           - |           - |                   - |
             ToUInt |  1.491 ns | 0.0180 ns | 0.0151 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.464 ns | 0.0283 ns | 0.0251 ns |           - |           - |           - |                   - |
             ToLong |  1.468 ns | 0.0430 ns | 0.0381 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.890 ns | 0.0077 ns | 0.0068 ns |           - |           - |           - |                   - |
            ToULong |  1.490 ns | 0.0184 ns | 0.0172 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.193 ns | 0.0110 ns | 0.0092 ns |           - |           - |           - |                   - |
            ToFloat |  1.451 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.454 ns | 0.0182 ns | 0.0152 ns |           - |           - |           - |                   - |
           ToDouble |  1.662 ns | 0.0090 ns | 0.0084 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.258 ns | 0.0231 ns | 0.0216 ns |           - |           - |           - |                   - |
          ToDecimal |  2.467 ns | 0.0138 ns | 0.0129 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 10.762 ns | 0.0317 ns | 0.0281 ns |           - |           - |           - |                   - |
         ToDateTime |  2.357 ns | 0.0110 ns | 0.0092 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.317 ns | 0.0559 ns | 0.0496 ns |           - |           - |           - |                   - |
           ToObject |  1.454 ns | 0.0179 ns | 0.0167 ns |           - |           - |           - |                   - |
          To_String |  1.726 ns | 0.0079 ns | 0.0066 ns |           - |           - |           - |                   - |
             ToEnum |  1.641 ns | 0.0203 ns | 0.0180 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.416 ns | 0.0384 ns | 0.0341 ns |           - |           - |           - |                   - |
