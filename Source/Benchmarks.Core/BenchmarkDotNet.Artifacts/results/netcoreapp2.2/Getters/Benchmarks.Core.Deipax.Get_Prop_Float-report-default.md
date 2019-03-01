
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |   1.385 ns | 0.0025 ns | 0.0024 ns |           - |           - |           - |                   - |
     ToBoolNullable |   4.824 ns | 0.0017 ns | 0.0015 ns |           - |           - |           - |                   - |
             ToChar |   1.179 ns | 0.0054 ns | 0.0042 ns |           - |           - |           - |                   - |
     ToCharNullable |   4.369 ns | 0.0031 ns | 0.0027 ns |           - |           - |           - |                   - |
            ToSByte |   4.774 ns | 0.0054 ns | 0.0051 ns |           - |           - |           - |                   - |
    ToSByteNullable |   6.672 ns | 0.0040 ns | 0.0036 ns |           - |           - |           - |                   - |
             ToByte |   4.779 ns | 0.0048 ns | 0.0045 ns |           - |           - |           - |                   - |
     ToByteNullable |   6.653 ns | 0.0045 ns | 0.0042 ns |           - |           - |           - |                   - |
            ToShort |   4.762 ns | 0.0055 ns | 0.0052 ns |           - |           - |           - |                   - |
    ToShortNullable |   6.665 ns | 0.0058 ns | 0.0054 ns |           - |           - |           - |                   - |
           ToUShort |   4.786 ns | 0.0042 ns | 0.0039 ns |           - |           - |           - |                   - |
   ToUShortNullable |   6.654 ns | 0.0055 ns | 0.0051 ns |           - |           - |           - |                   - |
              ToInt |   3.407 ns | 0.0057 ns | 0.0053 ns |           - |           - |           - |                   - |
      ToIntNullable |   5.969 ns | 0.0041 ns | 0.0036 ns |           - |           - |           - |                   - |
             ToUInt |   3.355 ns | 0.0041 ns | 0.0039 ns |           - |           - |           - |                   - |
     ToUIntNullable |   5.968 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
             ToLong |   2.659 ns | 0.0106 ns | 0.0099 ns |           - |           - |           - |                   - |
     ToLongNullable |   3.138 ns | 0.0069 ns | 0.0061 ns |           - |           - |           - |                   - |
            ToULong |   2.707 ns | 0.0014 ns | 0.0012 ns |           - |           - |           - |                   - |
    ToULongNullable |   3.193 ns | 0.0039 ns | 0.0036 ns |           - |           - |           - |                   - |
            ToFloat |   1.153 ns | 0.0020 ns | 0.0017 ns |           - |           - |           - |                   - |
    ToFloatNullable |   4.368 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
           ToDouble |   1.171 ns | 0.0015 ns | 0.0012 ns |           - |           - |           - |                   - |
   ToDoubleNullable |   1.727 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
          ToDecimal |  23.815 ns | 0.0464 ns | 0.0434 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  33.867 ns | 0.0349 ns | 0.0327 ns |           - |           - |           - |                   - |
         ToDateTime |   2.325 ns | 0.0039 ns | 0.0036 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |   8.019 ns | 0.0055 ns | 0.0046 ns |           - |           - |           - |                   - |
           ToObject |   3.837 ns | 0.0080 ns | 0.0075 ns |      0.0038 |           - |           - |                24 B |
          To_String | 103.082 ns | 1.3150 ns | 1.2301 ns |      0.0050 |           - |           - |                32 B |
             ToEnum |  12.004 ns | 0.0082 ns | 0.0076 ns |           - |           - |           - |                   - |
     ToEnumNullable |  16.927 ns | 0.0186 ns | 0.0174 ns |           - |           - |           - |                   - |
