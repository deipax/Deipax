
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.8842 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.3362 ns | 0.0035 ns | 0.0031 ns |           - |           - |           - |                   - |
             ToChar |  0.8875 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1150 ns | 0.0039 ns | 0.0037 ns |           - |           - |           - |                   - |
            ToSByte |  1.2087 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.1082 ns | 0.0029 ns | 0.0026 ns |           - |           - |           - |                   - |
             ToByte |  1.2068 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.1049 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
            ToShort |  1.1990 ns | 0.0044 ns | 0.0041 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.1111 ns | 0.0096 ns | 0.0090 ns |           - |           - |           - |                   - |
           ToUShort |  1.1994 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.1076 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
              ToInt |  1.2078 ns | 0.0018 ns | 0.0015 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1064 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
             ToUInt |  1.2087 ns | 0.0013 ns | 0.0011 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.1089 ns | 0.0042 ns | 0.0037 ns |           - |           - |           - |                   - |
             ToLong |  1.1983 ns | 0.0011 ns | 0.0010 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.9434 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
            ToULong |  1.1998 ns | 0.0010 ns | 0.0009 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.6202 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            ToFloat |  1.1497 ns | 0.0037 ns | 0.0035 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.5704 ns | 0.0044 ns | 0.0037 ns |           - |           - |           - |                   - |
           ToDouble |  1.1324 ns | 0.0015 ns | 0.0013 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.8559 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
          ToDecimal |  5.7200 ns | 0.0065 ns | 0.0057 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.0987 ns | 0.0184 ns | 0.0163 ns |           - |           - |           - |                   - |
         ToDateTime |  2.0144 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.0563 ns | 0.0042 ns | 0.0039 ns |           - |           - |           - |                   - |
           ToObject |  3.5430 ns | 0.0103 ns | 0.0097 ns |      0.0038 |           - |           - |                24 B |
          To_String |  2.3692 ns | 0.0065 ns | 0.0058 ns |           - |           - |           - |                   - |
             ToEnum | 10.1035 ns | 0.0064 ns | 0.0060 ns |           - |           - |           - |                   - |
     ToEnumNullable | 14.6979 ns | 0.0064 ns | 0.0056 ns |           - |           - |           - |                   - |
