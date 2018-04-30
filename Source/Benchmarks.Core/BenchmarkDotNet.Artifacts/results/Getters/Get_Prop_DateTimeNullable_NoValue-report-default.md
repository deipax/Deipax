
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.471 ns | 0.0023 ns | 0.0022 ns |       0 B |
     ToBoolNullable | 6.758 ns | 0.0076 ns | 0.0071 ns |       0 B |
             ToChar | 3.531 ns | 0.0021 ns | 0.0017 ns |       0 B |
     ToCharNullable | 6.783 ns | 0.0265 ns | 0.0235 ns |       0 B |
            ToSByte | 3.511 ns | 0.0037 ns | 0.0033 ns |       0 B |
    ToSByteNullable | 6.776 ns | 0.0070 ns | 0.0058 ns |       0 B |
             ToByte | 4.548 ns | 0.1459 ns | 0.1621 ns |       0 B |
     ToByteNullable | 6.803 ns | 0.0171 ns | 0.0160 ns |       0 B |
            ToShort | 3.501 ns | 0.0287 ns | 0.0254 ns |       0 B |
    ToShortNullable | 6.805 ns | 0.0053 ns | 0.0047 ns |       0 B |
           ToUShort | 4.175 ns | 0.0016 ns | 0.0012 ns |       0 B |
   ToUShortNullable | 6.775 ns | 0.0025 ns | 0.0019 ns |       0 B |
              ToInt | 3.474 ns | 0.0068 ns | 0.0063 ns |       0 B |
      ToIntNullable | 6.783 ns | 0.0046 ns | 0.0043 ns |       0 B |
             ToUInt | 3.710 ns | 0.0070 ns | 0.0062 ns |       0 B |
     ToUIntNullable | 6.806 ns | 0.0100 ns | 0.0088 ns |       0 B |
             ToLong | 3.454 ns | 0.0035 ns | 0.0033 ns |       0 B |
     ToLongNullable | 6.134 ns | 0.0008 ns | 0.0007 ns |       0 B |
            ToULong | 3.456 ns | 0.0030 ns | 0.0027 ns |       0 B |
    ToULongNullable | 6.388 ns | 0.0007 ns | 0.0005 ns |       0 B |
            ToFloat | 3.527 ns | 0.0088 ns | 0.0078 ns |       0 B |
    ToFloatNullable | 6.771 ns | 0.0023 ns | 0.0018 ns |       0 B |
           ToDouble | 3.941 ns | 0.0105 ns | 0.0093 ns |       0 B |
   ToDoubleNullable | 6.656 ns | 0.0139 ns | 0.0130 ns |       0 B |
          ToDecimal | 6.137 ns | 0.0062 ns | 0.0051 ns |       0 B |
  ToDecimalNullable | 6.646 ns | 0.0030 ns | 0.0027 ns |       0 B |
         ToDateTime | 3.325 ns | 0.0029 ns | 0.0026 ns |       0 B |
 ToDateTimeNullable | 2.556 ns | 0.0037 ns | 0.0035 ns |       0 B |
           ToObject | 2.046 ns | 0.0082 ns | 0.0064 ns |       0 B |
          To_String | 4.243 ns | 0.0018 ns | 0.0014 ns |       0 B |
             ToEnum | 4.443 ns | 0.0050 ns | 0.0047 ns |       0 B |
