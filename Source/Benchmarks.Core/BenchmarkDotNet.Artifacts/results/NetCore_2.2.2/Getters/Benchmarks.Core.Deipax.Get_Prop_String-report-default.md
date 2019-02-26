
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |         NA |        NA |        NA |           - |           - |           - |                   - |
     ToBoolNullable |         NA |        NA |        NA |           - |           - |           - |                   - |
             ToChar |  2.7934 ns | 0.0105 ns | 0.0093 ns |           - |           - |           - |                   - |
     ToCharNullable |  5.5167 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
            ToSByte | 42.4223 ns | 0.0277 ns | 0.0259 ns |           - |           - |           - |                   - |
    ToSByteNullable | 48.7631 ns | 0.0654 ns | 0.0612 ns |           - |           - |           - |                   - |
             ToByte | 41.3123 ns | 0.0537 ns | 0.0476 ns |           - |           - |           - |                   - |
     ToByteNullable | 48.0899 ns | 0.0795 ns | 0.0743 ns |           - |           - |           - |                   - |
            ToShort | 42.3075 ns | 0.0495 ns | 0.0463 ns |           - |           - |           - |                   - |
    ToShortNullable | 48.2809 ns | 0.0350 ns | 0.0328 ns |           - |           - |           - |                   - |
           ToUShort | 40.0884 ns | 0.0379 ns | 0.0336 ns |           - |           - |           - |                   - |
   ToUShortNullable | 46.7834 ns | 0.0689 ns | 0.0644 ns |           - |           - |           - |                   - |
              ToInt | 40.7572 ns | 0.0288 ns | 0.0270 ns |           - |           - |           - |                   - |
      ToIntNullable | 47.0397 ns | 0.0424 ns | 0.0396 ns |           - |           - |           - |                   - |
             ToUInt | 39.3232 ns | 0.0711 ns | 0.0555 ns |           - |           - |           - |                   - |
     ToUIntNullable | 45.7453 ns | 0.0432 ns | 0.0361 ns |           - |           - |           - |                   - |
             ToLong | 39.5612 ns | 0.0639 ns | 0.0598 ns |           - |           - |           - |                   - |
     ToLongNullable | 41.1323 ns | 0.1177 ns | 0.1101 ns |           - |           - |           - |                   - |
            ToULong | 40.1509 ns | 0.0703 ns | 0.0658 ns |           - |           - |           - |                   - |
    ToULongNullable | 41.1719 ns | 0.0456 ns | 0.0404 ns |           - |           - |           - |                   - |
            ToFloat | 59.8146 ns | 0.0956 ns | 0.0798 ns |           - |           - |           - |                   - |
    ToFloatNullable | 66.3634 ns | 0.1182 ns | 0.1106 ns |           - |           - |           - |                   - |
           ToDouble | 61.0048 ns | 0.0965 ns | 0.0903 ns |           - |           - |           - |                   - |
   ToDoubleNullable | 63.2476 ns | 0.8346 ns | 0.7398 ns |           - |           - |           - |                   - |
          ToDecimal | 64.8893 ns | 1.0579 ns | 0.8834 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 75.1482 ns | 1.8691 ns | 2.5585 ns |           - |           - |           - |                   - |
         ToDateTime |         NA |        NA |        NA |           - |           - |           - |                   - |
 ToDateTimeNullable |         NA |        NA |        NA |           - |           - |           - |                   - |
           ToObject |  0.9716 ns | 0.0102 ns | 0.0095 ns |           - |           - |           - |                   - |
          To_String |  0.9571 ns | 0.0164 ns | 0.0154 ns |           - |           - |           - |                   - |
             ToEnum | 21.2252 ns | 0.1079 ns | 0.0956 ns |           - |           - |           - |                   - |
     ToEnumNullable | 21.9116 ns | 0.1027 ns | 0.0960 ns |           - |           - |           - |                   - |

Benchmarks with issues:
  Get_Prop_String.ToBool: DefaultJob
  Get_Prop_String.ToBoolNullable: DefaultJob
  Get_Prop_String.ToDateTime: DefaultJob
  Get_Prop_String.ToDateTimeNullable: DefaultJob
