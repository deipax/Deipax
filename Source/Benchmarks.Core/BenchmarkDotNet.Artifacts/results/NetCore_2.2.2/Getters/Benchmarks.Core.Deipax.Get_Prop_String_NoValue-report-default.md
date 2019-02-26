
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool | 1.7165 ns | 0.0285 ns | 0.0267 ns |           - |           - |           - |                   - |
     ToBoolNullable | 4.1907 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
             ToChar | 1.4763 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
     ToCharNullable | 4.4470 ns | 0.0182 ns | 0.0170 ns |           - |           - |           - |                   - |
            ToSByte | 1.4767 ns | 0.0150 ns | 0.0125 ns |           - |           - |           - |                   - |
    ToSByteNullable | 9.4928 ns | 0.0234 ns | 0.0183 ns |           - |           - |           - |                   - |
             ToByte | 1.8728 ns | 0.0072 ns | 0.0067 ns |           - |           - |           - |                   - |
     ToByteNullable | 9.5426 ns | 0.0863 ns | 0.0808 ns |           - |           - |           - |                   - |
            ToShort | 1.8961 ns | 0.0129 ns | 0.0115 ns |           - |           - |           - |                   - |
    ToShortNullable | 9.5786 ns | 0.0669 ns | 0.0593 ns |           - |           - |           - |                   - |
           ToUShort | 1.8725 ns | 0.0161 ns | 0.0135 ns |           - |           - |           - |                   - |
   ToUShortNullable | 9.6338 ns | 0.0554 ns | 0.0518 ns |           - |           - |           - |                   - |
              ToInt | 1.7941 ns | 0.0622 ns | 0.0582 ns |           - |           - |           - |                   - |
      ToIntNullable | 9.6462 ns | 0.1121 ns | 0.1048 ns |           - |           - |           - |                   - |
             ToUInt | 1.8882 ns | 0.0241 ns | 0.0226 ns |           - |           - |           - |                   - |
     ToUIntNullable | 9.5655 ns | 0.0444 ns | 0.0371 ns |           - |           - |           - |                   - |
             ToLong | 1.6920 ns | 0.0167 ns | 0.0148 ns |           - |           - |           - |                   - |
     ToLongNullable | 2.3447 ns | 0.0118 ns | 0.0104 ns |           - |           - |           - |                   - |
            ToULong | 1.6955 ns | 0.0042 ns | 0.0038 ns |           - |           - |           - |                   - |
    ToULongNullable | 2.3554 ns | 0.0289 ns | 0.0270 ns |           - |           - |           - |                   - |
            ToFloat | 1.8988 ns | 0.0066 ns | 0.0059 ns |           - |           - |           - |                   - |
    ToFloatNullable | 9.9262 ns | 0.1435 ns | 0.1342 ns |           - |           - |           - |                   - |
           ToDouble | 1.9273 ns | 0.0148 ns | 0.0131 ns |           - |           - |           - |                   - |
   ToDoubleNullable | 2.6308 ns | 0.0403 ns | 0.0337 ns |           - |           - |           - |                   - |
          ToDecimal | 2.5427 ns | 0.0024 ns | 0.0020 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 8.6998 ns | 0.0673 ns | 0.0630 ns |           - |           - |           - |                   - |
         ToDateTime | 2.8059 ns | 0.0071 ns | 0.0063 ns |           - |           - |           - |                   - |
 ToDateTimeNullable | 8.4866 ns | 0.0456 ns | 0.0426 ns |           - |           - |           - |                   - |
           ToObject | 0.9663 ns | 0.0071 ns | 0.0067 ns |           - |           - |           - |                   - |
          To_String | 0.9815 ns | 0.0237 ns | 0.0222 ns |           - |           - |           - |                   - |
             ToEnum | 1.4882 ns | 0.0213 ns | 0.0199 ns |           - |           - |           - |                   - |
     ToEnumNullable | 4.4515 ns | 0.0287 ns | 0.0255 ns |           - |           - |           - |                   - |
