
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 4.627 ns | 0.0110 ns | 0.0097 ns |       0 B |
     ToBoolNullable | 6.785 ns | 0.0170 ns | 0.0159 ns |       0 B |
             ToChar | 4.435 ns | 0.0173 ns | 0.0145 ns |       0 B |
     ToCharNullable | 7.036 ns | 0.0172 ns | 0.0144 ns |       0 B |
            ToSByte | 5.090 ns | 0.0080 ns | 0.0071 ns |       0 B |
    ToSByteNullable | 6.806 ns | 0.0408 ns | 0.0362 ns |       0 B |
             ToByte | 4.625 ns | 0.0279 ns | 0.0261 ns |       0 B |
     ToByteNullable | 6.818 ns | 0.0207 ns | 0.0194 ns |       0 B |
            ToShort | 4.596 ns | 0.0193 ns | 0.0161 ns |       0 B |
    ToShortNullable | 6.815 ns | 0.0303 ns | 0.0283 ns |       0 B |
           ToUShort | 4.638 ns | 0.0330 ns | 0.0293 ns |       0 B |
   ToUShortNullable | 6.797 ns | 0.0190 ns | 0.0177 ns |       0 B |
              ToInt | 4.616 ns | 0.0322 ns | 0.0301 ns |       0 B |
      ToIntNullable | 6.807 ns | 0.0241 ns | 0.0226 ns |       0 B |
             ToUInt | 4.621 ns | 0.0404 ns | 0.0358 ns |       0 B |
     ToUIntNullable | 6.791 ns | 0.0157 ns | 0.0146 ns |       0 B |
             ToLong | 4.561 ns | 0.0192 ns | 0.0179 ns |       0 B |
     ToLongNullable | 7.448 ns | 0.0285 ns | 0.0267 ns |       0 B |
            ToULong | 4.569 ns | 0.0088 ns | 0.0078 ns |       0 B |
    ToULongNullable | 7.443 ns | 0.0305 ns | 0.0285 ns |       0 B |
            ToFloat | 4.565 ns | 0.0093 ns | 0.0083 ns |       0 B |
    ToFloatNullable | 6.787 ns | 0.0131 ns | 0.0116 ns |       0 B |
           ToDouble | 2.310 ns | 0.0097 ns | 0.0091 ns |       0 B |
   ToDoubleNullable | 3.330 ns | 0.0084 ns | 0.0079 ns |       0 B |
          ToDecimal | 7.447 ns | 0.0172 ns | 0.0161 ns |       0 B |
  ToDecimalNullable | 6.679 ns | 0.0306 ns | 0.0287 ns |       0 B |
         ToDateTime | 5.907 ns | 0.0192 ns | 0.0180 ns |       0 B |
 ToDateTimeNullable | 6.415 ns | 0.0221 ns | 0.0207 ns |       0 B |
           ToObject | 2.822 ns | 0.0138 ns | 0.0129 ns |       0 B |
          To_String | 4.898 ns | 0.0273 ns | 0.0256 ns |       0 B |
             ToEnum | 5.100 ns | 0.0139 ns | 0.0130 ns |       0 B |
