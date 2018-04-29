
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 4.017 ns | 0.0017 ns | 0.0014 ns |       0 B |
     ToBoolNullable | 6.771 ns | 0.0124 ns | 0.0110 ns |       0 B |
             ToChar | 4.457 ns | 0.0008 ns | 0.0007 ns |       0 B |
     ToCharNullable | 7.273 ns | 0.0065 ns | 0.0058 ns |       0 B |
            ToSByte | 4.099 ns | 0.0057 ns | 0.0053 ns |       0 B |
    ToSByteNullable | 6.792 ns | 0.0053 ns | 0.0050 ns |       0 B |
             ToByte | 4.094 ns | 0.0097 ns | 0.0086 ns |       0 B |
     ToByteNullable | 6.779 ns | 0.0039 ns | 0.0034 ns |       0 B |
            ToShort | 2.325 ns | 0.0057 ns | 0.0050 ns |       0 B |
    ToShortNullable | 1.793 ns | 0.0023 ns | 0.0022 ns |       0 B |
           ToUShort | 4.513 ns | 0.0048 ns | 0.0045 ns |       0 B |
   ToUShortNullable | 7.277 ns | 0.0069 ns | 0.0065 ns |       0 B |
              ToInt | 4.112 ns | 0.0142 ns | 0.0126 ns |       0 B |
      ToIntNullable | 6.790 ns | 0.0057 ns | 0.0054 ns |       0 B |
             ToUInt | 4.388 ns | 0.0112 ns | 0.0100 ns |       0 B |
     ToUIntNullable | 7.279 ns | 0.0055 ns | 0.0049 ns |       0 B |
             ToLong | 4.105 ns | 0.0134 ns | 0.0119 ns |       0 B |
     ToLongNullable | 6.482 ns | 0.0098 ns | 0.0087 ns |       0 B |
            ToULong | 4.444 ns | 0.0096 ns | 0.0089 ns |       0 B |
    ToULongNullable | 6.402 ns | 0.0058 ns | 0.0049 ns |       0 B |
            ToFloat | 4.104 ns | 0.0119 ns | 0.0106 ns |       0 B |
    ToFloatNullable | 6.790 ns | 0.0051 ns | 0.0042 ns |       0 B |
           ToDouble | 4.108 ns | 0.0130 ns | 0.0115 ns |       0 B |
   ToDoubleNullable | 6.659 ns | 0.0070 ns | 0.0065 ns |       0 B |
          ToDecimal | 7.179 ns | 0.0163 ns | 0.0153 ns |       0 B |
  ToDecimalNullable | 6.412 ns | 0.0067 ns | 0.0063 ns |       0 B |
         ToDateTime | 5.364 ns | 0.0009 ns | 0.0007 ns |       0 B |
 ToDateTimeNullable | 6.405 ns | 0.0069 ns | 0.0061 ns |       0 B |
           ToObject | 2.814 ns | 0.0017 ns | 0.0015 ns |       0 B |
          To_String | 4.680 ns | 0.0018 ns | 0.0017 ns |       0 B |
             ToEnum | 4.705 ns | 0.0089 ns | 0.0075 ns |       0 B |
