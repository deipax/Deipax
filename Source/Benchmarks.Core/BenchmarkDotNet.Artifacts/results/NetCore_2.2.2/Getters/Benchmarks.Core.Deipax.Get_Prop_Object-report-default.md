
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  3.732 ns | 0.0059 ns | 0.0052 ns |           - |           - |           - |                   - |
     ToBoolNullable |  6.782 ns | 0.0068 ns | 0.0064 ns |           - |           - |           - |                   - |
             ToChar |  3.699 ns | 0.0072 ns | 0.0056 ns |           - |           - |           - |                   - |
     ToCharNullable |  6.786 ns | 0.0155 ns | 0.0129 ns |           - |           - |           - |                   - |
            ToSByte |  3.700 ns | 0.0182 ns | 0.0171 ns |           - |           - |           - |                   - |
    ToSByteNullable |  6.779 ns | 0.0046 ns | 0.0043 ns |           - |           - |           - |                   - |
             ToByte |  3.751 ns | 0.0059 ns | 0.0050 ns |           - |           - |           - |                   - |
     ToByteNullable |  6.768 ns | 0.0355 ns | 0.0332 ns |           - |           - |           - |                   - |
            ToShort |  3.787 ns | 0.0319 ns | 0.0283 ns |           - |           - |           - |                   - |
    ToShortNullable |  6.737 ns | 0.0182 ns | 0.0161 ns |           - |           - |           - |                   - |
           ToUShort |  3.723 ns | 0.0177 ns | 0.0165 ns |           - |           - |           - |                   - |
   ToUShortNullable |  6.753 ns | 0.0237 ns | 0.0210 ns |           - |           - |           - |                   - |
              ToInt |  3.794 ns | 0.1075 ns | 0.1005 ns |           - |           - |           - |                   - |
      ToIntNullable |  6.775 ns | 0.0330 ns | 0.0292 ns |           - |           - |           - |                   - |
             ToUInt |  3.726 ns | 0.0290 ns | 0.0271 ns |           - |           - |           - |                   - |
     ToUIntNullable |  6.727 ns | 0.0292 ns | 0.0228 ns |           - |           - |           - |                   - |
             ToLong |  3.709 ns | 0.0284 ns | 0.0252 ns |           - |           - |           - |                   - |
     ToLongNullable |  4.842 ns | 0.0305 ns | 0.0254 ns |           - |           - |           - |                   - |
            ToULong |  3.737 ns | 0.0063 ns | 0.0056 ns |           - |           - |           - |                   - |
    ToULongNullable |  5.095 ns | 0.0192 ns | 0.0170 ns |           - |           - |           - |                   - |
            ToFloat |  3.741 ns | 0.0187 ns | 0.0175 ns |           - |           - |           - |                   - |
    ToFloatNullable |  7.009 ns | 0.0666 ns | 0.0623 ns |           - |           - |           - |                   - |
           ToDouble |  3.721 ns | 0.0204 ns | 0.0171 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  5.473 ns | 0.0223 ns | 0.0198 ns |           - |           - |           - |                   - |
          ToDecimal |  4.501 ns | 0.0359 ns | 0.0300 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 11.859 ns | 0.0557 ns | 0.0521 ns |           - |           - |           - |                   - |
         ToDateTime |  4.232 ns | 0.0134 ns | 0.0112 ns |           - |           - |           - |                   - |
 ToDateTimeNullable | 11.500 ns | 0.0487 ns | 0.0407 ns |           - |           - |           - |                   - |
           ToObject |  1.141 ns | 0.0065 ns | 0.0051 ns |           - |           - |           - |                   - |
          To_String | 16.240 ns | 0.0399 ns | 0.0353 ns |           - |           - |           - |                   - |
             ToEnum | 16.520 ns | 0.0425 ns | 0.0332 ns |           - |           - |           - |                   - |
     ToEnumNullable | 19.148 ns | 0.0738 ns | 0.0616 ns |           - |           - |           - |                   - |
