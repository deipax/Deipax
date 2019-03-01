
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool | 10.3460 ns | 0.0975 ns | 0.0912 ns |           - |           - |           - |                   - |
     ToBoolNullable |  9.3342 ns | 0.0406 ns | 0.0379 ns |           - |           - |           - |                   - |
             ToChar |  0.4052 ns | 0.0116 ns | 0.0108 ns |           - |           - |           - |                   - |
     ToCharNullable |  3.9215 ns | 0.0319 ns | 0.0298 ns |           - |           - |           - |                   - |
            ToSByte | 10.2806 ns | 0.0717 ns | 0.0636 ns |           - |           - |           - |                   - |
    ToSByteNullable |  9.5679 ns | 0.0539 ns | 0.0504 ns |           - |           - |           - |                   - |
             ToByte | 10.2811 ns | 0.0452 ns | 0.0423 ns |           - |           - |           - |                   - |
     ToByteNullable |  9.5195 ns | 0.0456 ns | 0.0426 ns |           - |           - |           - |                   - |
            ToShort | 10.3046 ns | 0.0572 ns | 0.0535 ns |           - |           - |           - |                   - |
    ToShortNullable |  9.3295 ns | 0.0602 ns | 0.0563 ns |           - |           - |           - |                   - |
           ToUShort | 10.2665 ns | 0.0605 ns | 0.0566 ns |           - |           - |           - |                   - |
   ToUShortNullable |  9.3628 ns | 0.0660 ns | 0.0617 ns |           - |           - |           - |                   - |
              ToInt | 10.5973 ns | 0.0329 ns | 0.0292 ns |           - |           - |           - |                   - |
      ToIntNullable |  9.5279 ns | 0.0564 ns | 0.0500 ns |           - |           - |           - |                   - |
             ToUInt | 11.9477 ns | 0.0633 ns | 0.0592 ns |           - |           - |           - |                   - |
     ToUIntNullable |  9.5020 ns | 0.0500 ns | 0.0468 ns |           - |           - |           - |                   - |
             ToLong | 11.9021 ns | 0.0561 ns | 0.0524 ns |           - |           - |           - |                   - |
     ToLongNullable |  8.7888 ns | 0.0614 ns | 0.0544 ns |           - |           - |           - |                   - |
            ToULong | 11.9028 ns | 0.0751 ns | 0.0703 ns |           - |           - |           - |                   - |
    ToULongNullable |  7.9644 ns | 0.0484 ns | 0.0452 ns |           - |           - |           - |                   - |
            ToFloat | 11.9166 ns | 0.0473 ns | 0.0442 ns |           - |           - |           - |                   - |
    ToFloatNullable |  9.5307 ns | 0.0503 ns | 0.0471 ns |           - |           - |           - |                   - |
           ToDouble | 11.9342 ns | 0.0724 ns | 0.0677 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  7.9508 ns | 0.0428 ns | 0.0334 ns |           - |           - |           - |                   - |
          ToDecimal |  1.9652 ns | 0.0199 ns | 0.0186 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  1.4271 ns | 0.0164 ns | 0.0153 ns |           - |           - |           - |                   - |
         ToDateTime |  0.9191 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.4821 ns | 0.0543 ns | 0.0508 ns |           - |           - |           - |                   - |
           ToObject |  0.9095 ns | 0.0177 ns | 0.0166 ns |           - |           - |           - |                   - |
          To_String | 12.0616 ns | 0.0568 ns | 0.0532 ns |           - |           - |           - |                   - |
             ToEnum | 12.0882 ns | 0.0596 ns | 0.0557 ns |           - |           - |           - |                   - |
     ToEnumNullable |  9.5033 ns | 0.0465 ns | 0.0412 ns |           - |           - |           - |                   - |
