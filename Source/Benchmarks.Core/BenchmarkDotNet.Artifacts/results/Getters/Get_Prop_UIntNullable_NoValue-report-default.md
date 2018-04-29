
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.959 ns | 0.0010 ns | 0.0009 ns |       0 B |
     ToBoolNullable | 6.782 ns | 0.0117 ns | 0.0109 ns |       0 B |
             ToChar | 4.591 ns | 0.0017 ns | 0.0014 ns |       0 B |
     ToCharNullable | 7.271 ns | 0.0107 ns | 0.0100 ns |       0 B |
            ToSByte | 4.412 ns | 0.0035 ns | 0.0033 ns |       0 B |
    ToSByteNullable | 7.258 ns | 0.0017 ns | 0.0014 ns |       0 B |
             ToByte | 5.023 ns | 0.0033 ns | 0.0031 ns |       0 B |
     ToByteNullable | 7.263 ns | 0.0014 ns | 0.0012 ns |       0 B |
            ToShort | 3.829 ns | 0.0063 ns | 0.0052 ns |       0 B |
    ToShortNullable | 6.768 ns | 0.0018 ns | 0.0015 ns |       0 B |
           ToUShort | 4.406 ns | 0.0058 ns | 0.0052 ns |       0 B |
   ToUShortNullable | 7.260 ns | 0.0011 ns | 0.0010 ns |       0 B |
              ToInt | 4.416 ns | 0.0014 ns | 0.0012 ns |       0 B |
      ToIntNullable | 7.262 ns | 0.0016 ns | 0.0012 ns |       0 B |
             ToUInt | 2.307 ns | 0.0067 ns | 0.0063 ns |       0 B |
     ToUIntNullable | 2.044 ns | 0.0014 ns | 0.0011 ns |       0 B |
             ToLong | 4.614 ns | 0.0033 ns | 0.0031 ns |       0 B |
     ToLongNullable | 6.394 ns | 0.0128 ns | 0.0120 ns |       0 B |
            ToULong | 4.096 ns | 0.0042 ns | 0.0037 ns |       0 B |
    ToULongNullable | 6.656 ns | 0.0148 ns | 0.0138 ns |       0 B |
            ToFloat | 4.111 ns | 0.0037 ns | 0.0031 ns |       0 B |
    ToFloatNullable | 6.789 ns | 0.0140 ns | 0.0110 ns |       0 B |
           ToDouble | 4.113 ns | 0.0048 ns | 0.0043 ns |       0 B |
   ToDoubleNullable | 6.397 ns | 0.0149 ns | 0.0132 ns |       0 B |
          ToDecimal | 7.428 ns | 0.0040 ns | 0.0035 ns |       0 B |
  ToDecimalNullable | 6.657 ns | 0.0160 ns | 0.0134 ns |       0 B |
         ToDateTime | 5.374 ns | 0.0030 ns | 0.0028 ns |       0 B |
 ToDateTimeNullable | 6.387 ns | 0.0027 ns | 0.0023 ns |       0 B |
           ToObject | 2.880 ns | 0.0604 ns | 0.0565 ns |       0 B |
          To_String | 4.780 ns | 0.0012 ns | 0.0010 ns |       0 B |
             ToEnum | 4.622 ns | 0.0035 ns | 0.0029 ns |       0 B |
