
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool | 2.061 ns | 0.0318 ns | 0.0297 ns |           - |           - |           - |                   - |
     ToBoolNullable | 4.926 ns | 0.0350 ns | 0.0327 ns |           - |           - |           - |                   - |
             ToChar | 2.000 ns | 0.0448 ns | 0.0419 ns |           - |           - |           - |                   - |
     ToCharNullable | 5.347 ns | 0.0288 ns | 0.0256 ns |           - |           - |           - |                   - |
            ToSByte | 2.100 ns | 0.0331 ns | 0.0293 ns |           - |           - |           - |                   - |
    ToSByteNullable | 5.414 ns | 0.0477 ns | 0.0423 ns |           - |           - |           - |                   - |
             ToByte | 2.084 ns | 0.0062 ns | 0.0048 ns |           - |           - |           - |                   - |
     ToByteNullable | 5.380 ns | 0.0325 ns | 0.0271 ns |           - |           - |           - |                   - |
            ToShort | 2.092 ns | 0.0553 ns | 0.0518 ns |           - |           - |           - |                   - |
    ToShortNullable | 5.349 ns | 0.0142 ns | 0.0126 ns |           - |           - |           - |                   - |
           ToUShort | 2.044 ns | 0.0061 ns | 0.0054 ns |           - |           - |           - |                   - |
   ToUShortNullable | 5.367 ns | 0.0358 ns | 0.0317 ns |           - |           - |           - |                   - |
              ToInt | 2.091 ns | 0.0231 ns | 0.0216 ns |           - |           - |           - |                   - |
      ToIntNullable | 5.420 ns | 0.0445 ns | 0.0394 ns |           - |           - |           - |                   - |
             ToUInt | 2.086 ns | 0.0076 ns | 0.0067 ns |           - |           - |           - |                   - |
     ToUIntNullable | 5.362 ns | 0.0297 ns | 0.0263 ns |           - |           - |           - |                   - |
             ToLong | 2.283 ns | 0.0492 ns | 0.0460 ns |           - |           - |           - |                   - |
     ToLongNullable | 2.853 ns | 0.0259 ns | 0.0216 ns |           - |           - |           - |                   - |
            ToULong | 2.084 ns | 0.0248 ns | 0.0207 ns |           - |           - |           - |                   - |
    ToULongNullable | 2.871 ns | 0.0102 ns | 0.0090 ns |           - |           - |           - |                   - |
            ToFloat | 2.199 ns | 0.0441 ns | 0.0368 ns |           - |           - |           - |                   - |
    ToFloatNullable | 5.410 ns | 0.0218 ns | 0.0204 ns |           - |           - |           - |                   - |
           ToDouble | 2.162 ns | 0.0070 ns | 0.0058 ns |           - |           - |           - |                   - |
   ToDoubleNullable | 3.300 ns | 0.0192 ns | 0.0170 ns |           - |           - |           - |                   - |
          ToDecimal | 3.117 ns | 0.0167 ns | 0.0139 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 9.845 ns | 0.2194 ns | 0.1832 ns |           - |           - |           - |                   - |
         ToDateTime | 2.911 ns | 0.0180 ns | 0.0160 ns |           - |           - |           - |                   - |
 ToDateTimeNullable | 9.424 ns | 0.0390 ns | 0.0365 ns |           - |           - |           - |                   - |
           ToObject | 1.161 ns | 0.0140 ns | 0.0124 ns |           - |           - |           - |                   - |
          To_String | 1.862 ns | 0.0081 ns | 0.0068 ns |           - |           - |           - |                   - |
             ToEnum | 1.941 ns | 0.0699 ns | 0.0777 ns |           - |           - |           - |                   - |
     ToEnumNullable | 4.911 ns | 0.0082 ns | 0.0073 ns |           - |           - |           - |                   - |
