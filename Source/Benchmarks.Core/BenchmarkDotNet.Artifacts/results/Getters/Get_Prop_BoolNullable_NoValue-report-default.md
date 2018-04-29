
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 2.286 ns | 0.0061 ns | 0.0057 ns |       0 B |
     ToBoolNullable | 1.795 ns | 0.0051 ns | 0.0043 ns |       0 B |
             ToChar | 3.827 ns | 0.0110 ns | 0.0103 ns |       0 B |
     ToCharNullable | 6.808 ns | 0.0430 ns | 0.0402 ns |       0 B |
            ToSByte | 4.325 ns | 0.0036 ns | 0.0032 ns |       0 B |
    ToSByteNullable | 6.792 ns | 0.0144 ns | 0.0127 ns |       0 B |
             ToByte | 4.079 ns | 0.0079 ns | 0.0073 ns |       0 B |
     ToByteNullable | 6.797 ns | 0.0125 ns | 0.0111 ns |       0 B |
            ToShort | 4.071 ns | 0.0073 ns | 0.0068 ns |       0 B |
    ToShortNullable | 6.854 ns | 0.0084 ns | 0.0066 ns |       0 B |
           ToUShort | 4.580 ns | 0.0020 ns | 0.0017 ns |       0 B |
   ToUShortNullable | 6.821 ns | 0.0380 ns | 0.0356 ns |       0 B |
              ToInt | 4.636 ns | 0.0029 ns | 0.0024 ns |       0 B |
      ToIntNullable | 6.818 ns | 0.0359 ns | 0.0318 ns |       0 B |
             ToUInt | 4.137 ns | 0.0048 ns | 0.0045 ns |       0 B |
     ToUIntNullable | 6.789 ns | 0.0057 ns | 0.0051 ns |       0 B |
             ToLong | 4.138 ns | 0.0177 ns | 0.0128 ns |       0 B |
     ToLongNullable | 6.145 ns | 0.0171 ns | 0.0160 ns |       0 B |
            ToULong | 4.084 ns | 0.0021 ns | 0.0017 ns |       0 B |
    ToULongNullable | 6.393 ns | 0.0094 ns | 0.0078 ns |       0 B |
            ToFloat | 4.091 ns | 0.0063 ns | 0.0052 ns |       0 B |
    ToFloatNullable | 6.800 ns | 0.0158 ns | 0.0148 ns |       0 B |
           ToDouble | 4.097 ns | 0.0057 ns | 0.0050 ns |       0 B |
   ToDoubleNullable | 6.396 ns | 0.0115 ns | 0.0107 ns |       0 B |
          ToDecimal | 7.154 ns | 0.0023 ns | 0.0018 ns |       0 B |
  ToDecimalNullable | 6.295 ns | 0.0091 ns | 0.0085 ns |       0 B |
         ToDateTime | 5.113 ns | 0.0043 ns | 0.0040 ns |       0 B |
 ToDateTimeNullable | 6.389 ns | 0.0027 ns | 0.0021 ns |       0 B |
           ToObject | 2.811 ns | 0.0011 ns | 0.0009 ns |       0 B |
          To_String | 4.655 ns | 0.0076 ns | 0.0067 ns |       0 B |
             ToEnum | 4.701 ns | 0.0027 ns | 0.0023 ns |       0 B |
