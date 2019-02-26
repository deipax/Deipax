
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9576 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.0888 ns | 0.0035 ns | 0.0032 ns |           - |           - |           - |                   - |
             ToChar |  0.8878 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1039 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
            ToSByte |  1.4516 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.1035 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
             ToByte |  1.2415 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.3233 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
            ToShort |  0.8869 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.1017 ns | 0.0024 ns | 0.0021 ns |           - |           - |           - |                   - |
           ToUShort |  0.8866 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.0918 ns | 0.0054 ns | 0.0051 ns |           - |           - |           - |                   - |
              ToInt |  0.8854 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1011 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
             ToUInt |  0.8930 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.1055 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
             ToLong |  0.8924 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.4242 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            ToULong |  0.8933 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.4221 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
            ToFloat |  1.0998 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3363 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
           ToDouble |  1.2022 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.6075 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
          ToDecimal |  5.7090 ns | 0.0098 ns | 0.0091 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.8255 ns | 0.0083 ns | 0.0073 ns |           - |           - |           - |                   - |
         ToDateTime |  2.0130 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.0587 ns | 0.0127 ns | 0.0119 ns |           - |           - |           - |                   - |
           ToObject |  3.5532 ns | 0.0078 ns | 0.0061 ns |      0.0038 |           - |           - |                24 B |
          To_String | 16.6779 ns | 0.0268 ns | 0.0238 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 10.1291 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
     ToEnumNullable | 14.8374 ns | 0.0101 ns | 0.0095 ns |           - |           - |           - |                   - |
