
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool | 1.9501 ns | 0.0218 ns | 0.0203 ns |           - |           - |           - |                   - |
     ToBoolNullable | 4.5554 ns | 0.0258 ns | 0.0241 ns |           - |           - |           - |                   - |
             ToChar | 1.6968 ns | 0.0157 ns | 0.0146 ns |           - |           - |           - |                   - |
     ToCharNullable | 4.9981 ns | 0.0223 ns | 0.0209 ns |           - |           - |           - |                   - |
            ToSByte | 1.6985 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
    ToSByteNullable | 5.0117 ns | 0.0219 ns | 0.0205 ns |           - |           - |           - |                   - |
             ToByte | 2.1334 ns | 0.0680 ns | 0.1276 ns |           - |           - |           - |                   - |
     ToByteNullable | 5.0019 ns | 0.0243 ns | 0.0227 ns |           - |           - |           - |                   - |
            ToShort | 1.7000 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
    ToShortNullable | 5.0058 ns | 0.0237 ns | 0.0222 ns |           - |           - |           - |                   - |
           ToUShort | 1.7148 ns | 0.0170 ns | 0.0159 ns |           - |           - |           - |                   - |
   ToUShortNullable | 5.0022 ns | 0.0384 ns | 0.0359 ns |           - |           - |           - |                   - |
              ToInt | 1.7397 ns | 0.0160 ns | 0.0149 ns |           - |           - |           - |                   - |
      ToIntNullable | 4.9390 ns | 0.0227 ns | 0.0212 ns |           - |           - |           - |                   - |
             ToUInt | 1.7481 ns | 0.0100 ns | 0.0089 ns |           - |           - |           - |                   - |
     ToUIntNullable | 5.0061 ns | 0.0349 ns | 0.0327 ns |           - |           - |           - |                   - |
             ToLong | 1.9765 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
     ToLongNullable | 2.6511 ns | 0.0292 ns | 0.0273 ns |           - |           - |           - |                   - |
            ToULong | 1.7428 ns | 0.0147 ns | 0.0137 ns |           - |           - |           - |                   - |
    ToULongNullable | 2.6419 ns | 0.0204 ns | 0.0181 ns |           - |           - |           - |                   - |
            ToFloat | 1.7362 ns | 0.0141 ns | 0.0125 ns |           - |           - |           - |                   - |
    ToFloatNullable | 5.0377 ns | 0.0277 ns | 0.0259 ns |           - |           - |           - |                   - |
           ToDouble | 1.7295 ns | 0.0172 ns | 0.0152 ns |           - |           - |           - |                   - |
   ToDoubleNullable | 2.8762 ns | 0.0453 ns | 0.0423 ns |           - |           - |           - |                   - |
          ToDecimal | 6.5334 ns | 0.0420 ns | 0.0393 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 8.7361 ns | 0.0404 ns | 0.0378 ns |           - |           - |           - |                   - |
         ToDateTime | 2.1253 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
 ToDateTimeNullable | 9.3232 ns | 0.0506 ns | 0.0474 ns |           - |           - |           - |                   - |
           ToObject | 0.4064 ns | 0.0101 ns | 0.0095 ns |           - |           - |           - |                   - |
          To_String | 1.6193 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
             ToEnum | 1.6184 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
     ToEnumNullable | 4.5669 ns | 0.0258 ns | 0.0229 ns |           - |           - |           - |                   - |
