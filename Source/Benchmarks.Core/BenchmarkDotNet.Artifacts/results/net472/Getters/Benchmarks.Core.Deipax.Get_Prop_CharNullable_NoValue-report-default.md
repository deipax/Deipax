
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool | 0.5537 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
     ToBoolNullable | 4.1911 ns | 0.0218 ns | 0.0204 ns |           - |           - |           - |                   - |
             ToChar | 0.9695 ns | 0.0097 ns | 0.0081 ns |           - |           - |           - |                   - |
     ToCharNullable | 0.9955 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
            ToSByte | 1.2968 ns | 0.0061 ns | 0.0054 ns |           - |           - |           - |                   - |
    ToSByteNullable | 4.4253 ns | 0.0148 ns | 0.0138 ns |           - |           - |           - |                   - |
             ToByte | 0.9818 ns | 0.0105 ns | 0.0093 ns |           - |           - |           - |                   - |
     ToByteNullable | 4.4582 ns | 0.0363 ns | 0.0303 ns |           - |           - |           - |                   - |
            ToShort | 1.0131 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
    ToShortNullable | 4.4144 ns | 0.0251 ns | 0.0209 ns |           - |           - |           - |                   - |
           ToUShort | 0.9905 ns | 0.0056 ns | 0.0049 ns |           - |           - |           - |                   - |
   ToUShortNullable | 4.5248 ns | 0.0498 ns | 0.0466 ns |           - |           - |           - |                   - |
              ToInt | 0.9749 ns | 0.0121 ns | 0.0101 ns |           - |           - |           - |                   - |
      ToIntNullable | 4.4145 ns | 0.0136 ns | 0.0121 ns |           - |           - |           - |                   - |
             ToUInt | 0.9830 ns | 0.0062 ns | 0.0055 ns |           - |           - |           - |                   - |
     ToUIntNullable | 4.4363 ns | 0.0340 ns | 0.0301 ns |           - |           - |           - |                   - |
             ToLong | 0.9852 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
     ToLongNullable | 1.9084 ns | 0.0178 ns | 0.0158 ns |           - |           - |           - |                   - |
            ToULong | 0.9994 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
    ToULongNullable | 2.3633 ns | 0.0407 ns | 0.0380 ns |           - |           - |           - |                   - |
            ToFloat | 0.6683 ns | 0.0076 ns | 0.0067 ns |           - |           - |           - |                   - |
    ToFloatNullable | 4.4152 ns | 0.0211 ns | 0.0187 ns |           - |           - |           - |                   - |
           ToDouble | 0.6852 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
   ToDoubleNullable | 1.6473 ns | 0.0337 ns | 0.0282 ns |           - |           - |           - |                   - |
          ToDecimal | 5.8342 ns | 0.0367 ns | 0.0326 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 1.8791 ns | 0.0025 ns | 0.0021 ns |           - |           - |           - |                   - |
         ToDateTime | 1.1910 ns | 0.0031 ns | 0.0026 ns |           - |           - |           - |                   - |
 ToDateTimeNullable | 8.5246 ns | 0.0540 ns | 0.0479 ns |           - |           - |           - |                   - |
           ToObject | 0.9708 ns | 0.0074 ns | 0.0069 ns |           - |           - |           - |                   - |
          To_String | 1.3081 ns | 0.0218 ns | 0.0204 ns |           - |           - |           - |                   - |
             ToEnum | 1.6425 ns | 0.0080 ns | 0.0071 ns |           - |           - |           - |                   - |
     ToEnumNullable | 4.6455 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
