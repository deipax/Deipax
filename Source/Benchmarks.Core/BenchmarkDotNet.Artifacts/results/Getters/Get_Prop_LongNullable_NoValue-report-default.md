
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 4.718 ns | 0.0102 ns | 0.0096 ns |       0 B |
     ToBoolNullable | 6.837 ns | 0.0209 ns | 0.0195 ns |       0 B |
             ToChar | 4.680 ns | 0.0177 ns | 0.0166 ns |       0 B |
     ToCharNullable | 6.795 ns | 0.0144 ns | 0.0134 ns |       0 B |
            ToSByte | 4.662 ns | 0.0187 ns | 0.0175 ns |       0 B |
    ToSByteNullable | 6.810 ns | 0.0159 ns | 0.0141 ns |       0 B |
             ToByte | 4.650 ns | 0.0149 ns | 0.0139 ns |       0 B |
     ToByteNullable | 6.794 ns | 0.0126 ns | 0.0112 ns |       0 B |
            ToShort | 4.722 ns | 0.0255 ns | 0.0238 ns |       0 B |
    ToShortNullable | 6.818 ns | 0.0125 ns | 0.0117 ns |       0 B |
           ToUShort | 4.640 ns | 0.0217 ns | 0.0203 ns |       0 B |
   ToUShortNullable | 6.797 ns | 0.0186 ns | 0.0165 ns |       0 B |
              ToInt | 4.639 ns | 0.0163 ns | 0.0152 ns |       0 B |
      ToIntNullable | 6.827 ns | 0.0156 ns | 0.0146 ns |       0 B |
             ToUInt | 4.663 ns | 0.0143 ns | 0.0134 ns |       0 B |
     ToUIntNullable | 6.794 ns | 0.0154 ns | 0.0144 ns |       0 B |
             ToLong | 2.321 ns | 0.0179 ns | 0.0168 ns |       0 B |
     ToLongNullable | 3.618 ns | 0.0099 ns | 0.0088 ns |       0 B |
            ToULong | 5.692 ns | 0.0139 ns | 0.0130 ns |       0 B |
    ToULongNullable | 6.694 ns | 0.0324 ns | 0.0303 ns |       0 B |
            ToFloat | 4.895 ns | 0.0089 ns | 0.0064 ns |       0 B |
    ToFloatNullable | 6.788 ns | 0.0151 ns | 0.0141 ns |       0 B |
           ToDouble | 4.724 ns | 0.0112 ns | 0.0105 ns |       0 B |
   ToDoubleNullable | 6.424 ns | 0.0214 ns | 0.0189 ns |       0 B |
          ToDecimal | 7.180 ns | 0.0239 ns | 0.0223 ns |       0 B |
  ToDecimalNullable | 6.686 ns | 0.0210 ns | 0.0197 ns |       0 B |
         ToDateTime | 5.896 ns | 0.0221 ns | 0.0196 ns |       0 B |
 ToDateTimeNullable | 6.935 ns | 0.0251 ns | 0.0235 ns |       0 B |
           ToObject | 2.818 ns | 0.0086 ns | 0.0080 ns |       0 B |
          To_String | 5.286 ns | 0.0695 ns | 0.0581 ns |       0 B |
             ToEnum | 5.246 ns | 0.0104 ns | 0.0092 ns |       0 B |
