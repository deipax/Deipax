
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 4.860 ns | 0.0134 ns | 0.0125 ns |       0 B |
     ToBoolNullable | 6.776 ns | 0.0114 ns | 0.0107 ns |       0 B |
             ToChar | 4.386 ns | 0.0157 ns | 0.0147 ns |       0 B |
     ToCharNullable | 7.033 ns | 0.0033 ns | 0.0030 ns |       0 B |
            ToSByte | 4.827 ns | 0.0199 ns | 0.0186 ns |       0 B |
    ToSByteNullable | 6.782 ns | 0.0126 ns | 0.0118 ns |       0 B |
             ToByte | 5.024 ns | 0.0111 ns | 0.0093 ns |       0 B |
     ToByteNullable | 6.803 ns | 0.0212 ns | 0.0199 ns |       0 B |
            ToShort | 4.837 ns | 0.0154 ns | 0.0136 ns |       0 B |
    ToShortNullable | 6.783 ns | 0.0096 ns | 0.0089 ns |       0 B |
           ToUShort | 5.019 ns | 0.0130 ns | 0.0109 ns |       0 B |
   ToUShortNullable | 6.790 ns | 0.0074 ns | 0.0054 ns |       0 B |
              ToInt | 5.448 ns | 0.0095 ns | 0.0084 ns |       0 B |
      ToIntNullable | 6.800 ns | 0.0191 ns | 0.0179 ns |       0 B |
             ToUInt | 4.925 ns | 0.0149 ns | 0.0140 ns |       0 B |
     ToUIntNullable | 6.802 ns | 0.0211 ns | 0.0198 ns |       0 B |
             ToLong | 4.834 ns | 0.0189 ns | 0.0176 ns |       0 B |
     ToLongNullable | 7.445 ns | 0.0201 ns | 0.0188 ns |       0 B |
            ToULong | 4.942 ns | 0.0178 ns | 0.0166 ns |       0 B |
    ToULongNullable | 7.450 ns | 0.0199 ns | 0.0186 ns |       0 B |
            ToFloat | 5.047 ns | 0.0171 ns | 0.0160 ns |       0 B |
    ToFloatNullable | 6.808 ns | 0.0318 ns | 0.0297 ns |       0 B |
           ToDouble | 5.004 ns | 0.0118 ns | 0.0110 ns |       0 B |
   ToDoubleNullable | 7.687 ns | 0.0251 ns | 0.0234 ns |       0 B |
          ToDecimal | 4.099 ns | 0.0132 ns | 0.0117 ns |       0 B |
  ToDecimalNullable | 3.587 ns | 0.0096 ns | 0.0090 ns |       0 B |
         ToDateTime | 6.313 ns | 0.0275 ns | 0.0257 ns |       0 B |
 ToDateTimeNullable | 6.934 ns | 0.0329 ns | 0.0308 ns |       0 B |
           ToObject | 2.815 ns | 0.0058 ns | 0.0054 ns |       0 B |
          To_String | 5.630 ns | 0.0150 ns | 0.0133 ns |       0 B |
             ToEnum | 6.119 ns | 0.0145 ns | 0.0135 ns |       0 B |
