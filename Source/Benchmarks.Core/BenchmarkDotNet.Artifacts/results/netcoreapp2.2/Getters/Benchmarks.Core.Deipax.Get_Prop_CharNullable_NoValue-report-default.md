
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool | 1.142 ns | 0.0012 ns | 0.0010 ns |           - |           - |           - |                   - |
     ToBoolNullable | 4.140 ns | 0.0039 ns | 0.0035 ns |           - |           - |           - |                   - |
             ToChar | 1.412 ns | 0.0016 ns | 0.0014 ns |           - |           - |           - |                   - |
     ToCharNullable | 1.133 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
            ToSByte | 1.599 ns | 0.0024 ns | 0.0021 ns |           - |           - |           - |                   - |
    ToSByteNullable | 4.367 ns | 0.0040 ns | 0.0038 ns |           - |           - |           - |                   - |
             ToByte | 1.390 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
     ToByteNullable | 4.370 ns | 0.0036 ns | 0.0028 ns |           - |           - |           - |                   - |
            ToShort | 1.529 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
    ToShortNullable | 4.369 ns | 0.0036 ns | 0.0032 ns |           - |           - |           - |                   - |
           ToUShort | 1.665 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
   ToUShortNullable | 4.142 ns | 0.0036 ns | 0.0033 ns |           - |           - |           - |                   - |
              ToInt | 1.520 ns | 0.0023 ns | 0.0020 ns |           - |           - |           - |                   - |
      ToIntNullable | 4.139 ns | 0.0037 ns | 0.0035 ns |           - |           - |           - |                   - |
             ToUInt | 1.595 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
     ToUIntNullable | 4.188 ns | 0.0603 ns | 0.0534 ns |           - |           - |           - |                   - |
             ToLong | 1.395 ns | 0.0084 ns | 0.0078 ns |           - |           - |           - |                   - |
     ToLongNullable | 1.813 ns | 0.0016 ns | 0.0012 ns |           - |           - |           - |                   - |
            ToULong | 1.403 ns | 0.0040 ns | 0.0033 ns |           - |           - |           - |                   - |
    ToULongNullable | 1.830 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
            ToFloat | 1.130 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
    ToFloatNullable | 4.366 ns | 0.0040 ns | 0.0036 ns |           - |           - |           - |                   - |
           ToDouble | 1.139 ns | 0.0018 ns | 0.0015 ns |           - |           - |           - |                   - |
   ToDoubleNullable | 1.587 ns | 0.0099 ns | 0.0088 ns |           - |           - |           - |                   - |
          ToDecimal | 1.909 ns | 0.0010 ns | 0.0008 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 1.827 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
         ToDateTime | 2.070 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
 ToDateTimeNullable | 8.132 ns | 0.0115 ns | 0.0107 ns |           - |           - |           - |                   - |
           ToObject | 1.590 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
          To_String | 1.594 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
             ToEnum | 1.723 ns | 0.0024 ns | 0.0021 ns |           - |           - |           - |                   - |
     ToEnumNullable | 4.366 ns | 0.0033 ns | 0.0030 ns |           - |           - |           - |                   - |
