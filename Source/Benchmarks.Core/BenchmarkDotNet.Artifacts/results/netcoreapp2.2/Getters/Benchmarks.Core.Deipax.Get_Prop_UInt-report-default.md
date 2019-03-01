
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.176 ns | 0.0077 ns | 0.0069 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.167 ns | 0.0301 ns | 0.0251 ns |           - |           - |           - |                   - |
             ToChar |  1.674 ns | 0.0212 ns | 0.0198 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.184 ns | 0.0420 ns | 0.0372 ns |           - |           - |           - |                   - |
            ToSByte |  1.608 ns | 0.0050 ns | 0.0045 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.179 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
             ToByte |  1.622 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.149 ns | 0.0042 ns | 0.0039 ns |           - |           - |           - |                   - |
            ToShort |  2.496 ns | 0.0195 ns | 0.0183 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.838 ns | 0.0125 ns | 0.0110 ns |           - |           - |           - |                   - |
           ToUShort |  1.476 ns | 0.0026 ns | 0.0025 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.154 ns | 0.0060 ns | 0.0053 ns |           - |           - |           - |                   - |
              ToInt |  1.447 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.149 ns | 0.0058 ns | 0.0055 ns |           - |           - |           - |                   - |
             ToUInt |  1.160 ns | 0.0050 ns | 0.0044 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.376 ns | 0.0042 ns | 0.0039 ns |           - |           - |           - |                   - |
             ToLong |  1.168 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.851 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
            ToULong |  1.198 ns | 0.0020 ns | 0.0018 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.675 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
            ToFloat |  1.359 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.834 ns | 0.0035 ns | 0.0031 ns |           - |           - |           - |                   - |
           ToDouble |  1.213 ns | 0.0026 ns | 0.0024 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.779 ns | 0.0013 ns | 0.0011 ns |           - |           - |           - |                   - |
          ToDecimal |  6.019 ns | 0.0134 ns | 0.0119 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.325 ns | 0.0102 ns | 0.0085 ns |           - |           - |           - |                   - |
         ToDateTime |  2.207 ns | 0.0021 ns | 0.0019 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.787 ns | 0.0190 ns | 0.0178 ns |           - |           - |           - |                   - |
           ToObject |  3.603 ns | 0.0052 ns | 0.0049 ns |      0.0038 |           - |           - |                24 B |
          To_String | 16.573 ns | 0.0181 ns | 0.0169 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 10.192 ns | 0.0059 ns | 0.0052 ns |           - |           - |           - |                   - |
     ToEnumNullable | 14.764 ns | 0.0175 ns | 0.0164 ns |           - |           - |           - |                   - |
