
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 4.141 ns | 0.0104 ns | 0.0097 ns |       0 B |
     ToBoolNullable | 7.035 ns | 0.0116 ns | 0.0109 ns |       0 B |
             ToChar | 4.160 ns | 0.0102 ns | 0.0095 ns |       0 B |
     ToCharNullable | 7.050 ns | 0.0260 ns | 0.0243 ns |       0 B |
            ToSByte | 4.424 ns | 0.0080 ns | 0.0074 ns |       0 B |
    ToSByteNullable | 7.317 ns | 0.0144 ns | 0.0135 ns |       0 B |
             ToByte | 4.361 ns | 0.0158 ns | 0.0148 ns |       0 B |
     ToByteNullable | 7.318 ns | 0.0169 ns | 0.0158 ns |       0 B |
            ToShort | 4.723 ns | 0.0099 ns | 0.0088 ns |       0 B |
    ToShortNullable | 7.333 ns | 0.0253 ns | 0.0237 ns |       0 B |
           ToUShort | 4.409 ns | 0.0188 ns | 0.0176 ns |       0 B |
   ToUShortNullable | 7.313 ns | 0.0171 ns | 0.0160 ns |       0 B |
              ToInt | 5.203 ns | 0.0121 ns | 0.0095 ns |       0 B |
      ToIntNullable | 7.318 ns | 0.0162 ns | 0.0152 ns |       0 B |
             ToUInt | 4.384 ns | 0.0106 ns | 0.0089 ns |       0 B |
     ToUIntNullable | 7.320 ns | 0.0206 ns | 0.0193 ns |       0 B |
             ToLong | 4.773 ns | 0.0135 ns | 0.0126 ns |       0 B |
     ToLongNullable | 7.454 ns | 0.0330 ns | 0.0308 ns |       0 B |
            ToULong | 5.036 ns | 0.0094 ns | 0.0083 ns |       0 B |
    ToULongNullable | 7.442 ns | 0.0291 ns | 0.0272 ns |       0 B |
            ToFloat | 4.380 ns | 0.0140 ns | 0.0131 ns |       0 B |
    ToFloatNullable | 7.310 ns | 0.0128 ns | 0.0113 ns |       0 B |
           ToDouble | 4.372 ns | 0.0145 ns | 0.0136 ns |       0 B |
   ToDoubleNullable | 7.703 ns | 0.0271 ns | 0.0253 ns |       0 B |
          ToDecimal | 6.688 ns | 0.0297 ns | 0.0278 ns |       0 B |
  ToDecimalNullable | 7.176 ns | 0.0124 ns | 0.0104 ns |       0 B |
         ToDateTime | 5.622 ns | 0.0018 ns | 0.0014 ns |       0 B |
 ToDateTimeNullable | 7.436 ns | 0.0123 ns | 0.0115 ns |       0 B |
           ToObject | 2.303 ns | 0.0027 ns | 0.0022 ns |       0 B |
          To_String | 1.795 ns | 0.0028 ns | 0.0027 ns |       0 B |
             ToEnum | 4.350 ns | 0.0071 ns | 0.0063 ns |       0 B |
