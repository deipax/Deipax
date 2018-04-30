
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 1.807 ns | 0.0023 ns | 0.0015 ns |       0 B |
     ToBoolNullable | 1.278 ns | 0.0014 ns | 0.0012 ns |       0 B |
             ToChar | 3.084 ns | 0.0018 ns | 0.0016 ns |       0 B |
     ToCharNullable | 6.526 ns | 0.0113 ns | 0.0106 ns |       0 B |
            ToSByte | 3.342 ns | 0.0073 ns | 0.0065 ns |       0 B |
    ToSByteNullable | 6.523 ns | 0.0105 ns | 0.0088 ns |       0 B |
             ToByte | 3.531 ns | 0.0070 ns | 0.0062 ns |       0 B |
     ToByteNullable | 6.529 ns | 0.0076 ns | 0.0067 ns |       0 B |
            ToShort | 3.283 ns | 0.0035 ns | 0.0033 ns |       0 B |
    ToShortNullable | 6.531 ns | 0.0039 ns | 0.0032 ns |       0 B |
           ToUShort | 3.281 ns | 0.0018 ns | 0.0015 ns |       0 B |
   ToUShortNullable | 6.751 ns | 0.0098 ns | 0.0087 ns |       0 B |
              ToInt | 3.273 ns | 0.0022 ns | 0.0018 ns |       0 B |
      ToIntNullable | 6.517 ns | 0.0061 ns | 0.0057 ns |       0 B |
             ToUInt | 3.668 ns | 0.0099 ns | 0.0088 ns |       0 B |
     ToUIntNullable | 6.520 ns | 0.0080 ns | 0.0075 ns |       0 B |
             ToLong | 3.359 ns | 0.0047 ns | 0.0044 ns |       0 B |
     ToLongNullable | 6.142 ns | 0.0116 ns | 0.0103 ns |       0 B |
            ToULong | 3.450 ns | 0.0047 ns | 0.0044 ns |       0 B |
    ToULongNullable | 6.410 ns | 0.1834 ns | 0.1801 ns |       0 B |
            ToFloat | 3.373 ns | 0.0370 ns | 0.0328 ns |       0 B |
    ToFloatNullable | 6.948 ns | 0.0611 ns | 0.0542 ns |       0 B |
           ToDouble | 3.818 ns | 0.0740 ns | 0.0692 ns |       0 B |
   ToDoubleNullable | 6.289 ns | 0.0630 ns | 0.0526 ns |       0 B |
          ToDecimal | 6.338 ns | 0.0762 ns | 0.0595 ns |       0 B |
  ToDecimalNullable | 6.433 ns | 0.1589 ns | 0.1561 ns |       0 B |
         ToDateTime | 4.342 ns | 0.0101 ns | 0.0079 ns |       0 B |
 ToDateTimeNullable | 6.156 ns | 0.0279 ns | 0.0218 ns |       0 B |
           ToObject | 1.791 ns | 0.0039 ns | 0.0035 ns |       0 B |
          To_String | 3.969 ns | 0.0016 ns | 0.0012 ns |       0 B |
             ToEnum | 4.059 ns | 0.0047 ns | 0.0044 ns |       0 B |
