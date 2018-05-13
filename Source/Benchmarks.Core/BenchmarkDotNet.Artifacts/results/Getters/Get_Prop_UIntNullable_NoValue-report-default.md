
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 1.774 ns | 0.0025 ns | 0.0021 ns |       0 B |
     ToBoolNullable | 4.496 ns | 0.0087 ns | 0.0082 ns |       0 B |
             ToChar | 1.772 ns | 0.0003 ns | 0.0002 ns |       0 B |
     ToCharNullable | 5.252 ns | 0.0029 ns | 0.0027 ns |       0 B |
            ToSByte | 1.777 ns | 0.0042 ns | 0.0039 ns |       0 B |
    ToSByteNullable | 5.250 ns | 0.0021 ns | 0.0017 ns |       0 B |
             ToByte | 1.776 ns | 0.0042 ns | 0.0035 ns |       0 B |
     ToByteNullable | 5.253 ns | 0.0030 ns | 0.0028 ns |       0 B |
            ToShort | 1.775 ns | 0.0044 ns | 0.0036 ns |       0 B |
    ToShortNullable | 4.997 ns | 0.0030 ns | 0.0028 ns |       0 B |
           ToUShort | 1.777 ns | 0.0057 ns | 0.0054 ns |       0 B |
   ToUShortNullable | 5.253 ns | 0.0029 ns | 0.0027 ns |       0 B |
              ToInt | 1.780 ns | 0.0039 ns | 0.0037 ns |       0 B |
      ToIntNullable | 5.251 ns | 0.0010 ns | 0.0009 ns |       0 B |
             ToUInt | 2.306 ns | 0.0035 ns | 0.0032 ns |       0 B |
     ToUIntNullable | 1.278 ns | 0.0025 ns | 0.0022 ns |       0 B |
             ToLong | 2.046 ns | 0.0026 ns | 0.0023 ns |       0 B |
     ToLongNullable | 3.065 ns | 0.0020 ns | 0.0018 ns |       0 B |
            ToULong | 2.045 ns | 0.0037 ns | 0.0030 ns |       0 B |
    ToULongNullable | 3.070 ns | 0.0059 ns | 0.0052 ns |       0 B |
            ToFloat | 2.299 ns | 0.0020 ns | 0.0017 ns |       0 B |
    ToFloatNullable | 4.574 ns | 0.0133 ns | 0.0124 ns |       0 B |
           ToDouble | 2.307 ns | 0.0039 ns | 0.0036 ns |       0 B |
   ToDoubleNullable | 3.068 ns | 0.0046 ns | 0.0043 ns |       0 B |
          ToDecimal | 3.324 ns | 0.0039 ns | 0.0035 ns |       0 B |
  ToDecimalNullable | 9.090 ns | 0.0045 ns | 0.0038 ns |       0 B |
         ToDateTime | 2.813 ns | 0.0057 ns | 0.0053 ns |       0 B |
 ToDateTimeNullable | 8.323 ns | 0.0028 ns | 0.0022 ns |       0 B |
           ToObject | 1.793 ns | 0.0057 ns | 0.0051 ns |       0 B |
          To_String | 2.043 ns | 0.0016 ns | 0.0014 ns |       0 B |
             ToEnum | 2.051 ns | 0.0027 ns | 0.0024 ns |       0 B |
     ToEnumNullable | 5.007 ns | 0.0074 ns | 0.0066 ns |       0 B |
