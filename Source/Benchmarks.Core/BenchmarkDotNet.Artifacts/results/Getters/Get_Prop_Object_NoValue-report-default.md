
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 5.152 ns | 0.0198 ns | 0.0185 ns |       0 B |
     ToBoolNullable | 7.470 ns | 0.0539 ns | 0.0478 ns |       0 B |
             ToChar | 5.160 ns | 0.0021 ns | 0.0020 ns |       0 B |
     ToCharNullable | 7.546 ns | 0.0106 ns | 0.0099 ns |       0 B |
            ToSByte | 5.161 ns | 0.0049 ns | 0.0041 ns |       0 B |
    ToSByteNullable | 7.502 ns | 0.0064 ns | 0.0060 ns |       0 B |
             ToByte | 5.247 ns | 0.0061 ns | 0.0054 ns |       0 B |
     ToByteNullable | 7.540 ns | 0.0038 ns | 0.0035 ns |       0 B |
            ToShort | 5.156 ns | 0.0063 ns | 0.0053 ns |       0 B |
    ToShortNullable | 7.453 ns | 0.0321 ns | 0.0300 ns |       0 B |
           ToUShort | 5.656 ns | 0.0118 ns | 0.0110 ns |       0 B |
   ToUShortNullable | 7.537 ns | 0.0072 ns | 0.0064 ns |       0 B |
              ToInt | 5.158 ns | 0.0019 ns | 0.0016 ns |       0 B |
      ToIntNullable | 7.503 ns | 0.0043 ns | 0.0038 ns |       0 B |
             ToUInt | 6.226 ns | 0.0058 ns | 0.0051 ns |       0 B |
     ToUIntNullable | 7.354 ns | 0.0207 ns | 0.0183 ns |       0 B |
             ToLong | 5.224 ns | 0.0051 ns | 0.0042 ns |       0 B |
     ToLongNullable | 7.429 ns | 0.0040 ns | 0.0036 ns |       0 B |
            ToULong | 5.170 ns | 0.0076 ns | 0.0071 ns |       0 B |
    ToULongNullable | 7.363 ns | 0.0357 ns | 0.0317 ns |       0 B |
            ToFloat | 5.171 ns | 0.0071 ns | 0.0067 ns |       0 B |
    ToFloatNullable | 8.161 ns | 0.0038 ns | 0.0027 ns |       0 B |
           ToDouble | 5.263 ns | 0.0221 ns | 0.0196 ns |       0 B |
   ToDoubleNullable | 7.182 ns | 0.0082 ns | 0.0077 ns |       0 B |
          ToDecimal | 7.062 ns | 0.0163 ns | 0.0152 ns |       0 B |
  ToDecimalNullable | 6.848 ns | 0.0052 ns | 0.0046 ns |       0 B |
         ToDateTime | 6.563 ns | 0.0032 ns | 0.0027 ns |       0 B |
 ToDateTimeNullable | 7.044 ns | 0.0049 ns | 0.0046 ns |       0 B |
           ToObject | 1.279 ns | 0.0016 ns | 0.0015 ns |       0 B |
          To_String | 5.271 ns | 0.0052 ns | 0.0048 ns |       0 B |
             ToEnum | 5.426 ns | 0.0050 ns | 0.0047 ns |       0 B |
