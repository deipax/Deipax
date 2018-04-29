
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.950 ns | 0.0099 ns | 0.0092 ns |       0 B |
     ToBoolNullable | 6.805 ns | 0.0197 ns | 0.0184 ns |       0 B |
             ToChar | 3.607 ns | 0.0380 ns | 0.0355 ns |       0 B |
     ToCharNullable | 6.808 ns | 0.0176 ns | 0.0164 ns |       0 B |
            ToSByte | 4.031 ns | 0.0178 ns | 0.0167 ns |       0 B |
    ToSByteNullable | 6.797 ns | 0.0140 ns | 0.0124 ns |       0 B |
             ToByte | 3.977 ns | 0.0183 ns | 0.0171 ns |       0 B |
     ToByteNullable | 6.813 ns | 0.0205 ns | 0.0192 ns |       0 B |
            ToShort | 3.822 ns | 0.0335 ns | 0.0297 ns |       0 B |
    ToShortNullable | 6.800 ns | 0.0211 ns | 0.0187 ns |       0 B |
           ToUShort | 4.270 ns | 0.0162 ns | 0.0143 ns |       0 B |
   ToUShortNullable | 6.814 ns | 0.0157 ns | 0.0147 ns |       0 B |
              ToInt | 4.679 ns | 0.0291 ns | 0.0272 ns |       0 B |
      ToIntNullable | 6.804 ns | 0.0159 ns | 0.0149 ns |       0 B |
             ToUInt | 3.985 ns | 0.0151 ns | 0.0142 ns |       0 B |
     ToUIntNullable | 6.801 ns | 0.0088 ns | 0.0078 ns |       0 B |
             ToLong | 3.986 ns | 0.0143 ns | 0.0134 ns |       0 B |
     ToLongNullable | 6.929 ns | 0.0383 ns | 0.0358 ns |       0 B |
            ToULong | 4.001 ns | 0.0162 ns | 0.0152 ns |       0 B |
    ToULongNullable | 6.928 ns | 0.0282 ns | 0.0264 ns |       0 B |
            ToFloat | 2.318 ns | 0.0093 ns | 0.0087 ns |       0 B |
    ToFloatNullable | 1.800 ns | 0.0069 ns | 0.0064 ns |       0 B |
           ToDouble | 4.133 ns | 0.0160 ns | 0.0150 ns |       0 B |
   ToDoubleNullable | 6.154 ns | 0.0306 ns | 0.0286 ns |       0 B |
          ToDecimal | 6.920 ns | 0.0157 ns | 0.0147 ns |       0 B |
  ToDecimalNullable | 6.211 ns | 0.1106 ns | 0.0980 ns |       0 B |
         ToDateTime | 5.127 ns | 0.0100 ns | 0.0094 ns |       0 B |
 ToDateTimeNullable | 6.440 ns | 0.0291 ns | 0.0272 ns |       0 B |
           ToObject | 2.813 ns | 0.0057 ns | 0.0053 ns |       0 B |
          To_String | 4.027 ns | 0.0125 ns | 0.0117 ns |       0 B |
             ToEnum | 4.002 ns | 0.0125 ns | 0.0117 ns |       0 B |
