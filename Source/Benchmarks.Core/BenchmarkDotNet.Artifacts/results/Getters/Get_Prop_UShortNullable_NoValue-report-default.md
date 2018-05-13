
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 1.773 ns | 0.0043 ns | 0.0036 ns |       0 B |
     ToBoolNullable | 4.490 ns | 0.0012 ns | 0.0010 ns |       0 B |
             ToChar | 1.777 ns | 0.0042 ns | 0.0039 ns |       0 B |
     ToCharNullable | 4.742 ns | 0.0026 ns | 0.0025 ns |       0 B |
            ToSByte | 1.779 ns | 0.0048 ns | 0.0045 ns |       0 B |
    ToSByteNullable | 5.000 ns | 0.0032 ns | 0.0027 ns |       0 B |
             ToByte | 1.776 ns | 0.0036 ns | 0.0034 ns |       0 B |
     ToByteNullable | 5.012 ns | 0.0066 ns | 0.0058 ns |       0 B |
            ToShort | 1.776 ns | 0.0046 ns | 0.0041 ns |       0 B |
    ToShortNullable | 4.997 ns | 0.0048 ns | 0.0045 ns |       0 B |
           ToUShort | 2.286 ns | 0.0058 ns | 0.0054 ns |       0 B |
   ToUShortNullable | 1.319 ns | 0.0026 ns | 0.0024 ns |       0 B |
              ToInt | 2.032 ns | 0.0034 ns | 0.0032 ns |       0 B |
      ToIntNullable | 4.557 ns | 0.0072 ns | 0.0063 ns |       0 B |
             ToUInt | 2.044 ns | 0.0073 ns | 0.0065 ns |       0 B |
     ToUIntNullable | 4.491 ns | 0.0035 ns | 0.0033 ns |       0 B |
             ToLong | 2.046 ns | 0.0033 ns | 0.0030 ns |       0 B |
     ToLongNullable | 2.813 ns | 0.0062 ns | 0.0058 ns |       0 B |
            ToULong | 2.045 ns | 0.0018 ns | 0.0016 ns |       0 B |
    ToULongNullable | 2.810 ns | 0.0009 ns | 0.0007 ns |       0 B |
            ToFloat | 2.304 ns | 0.0021 ns | 0.0019 ns |       0 B |
    ToFloatNullable | 4.488 ns | 0.0005 ns | 0.0004 ns |       0 B |
           ToDouble | 2.304 ns | 0.0037 ns | 0.0035 ns |       0 B |
   ToDoubleNullable | 3.321 ns | 0.0024 ns | 0.0020 ns |       0 B |
          ToDecimal | 3.592 ns | 0.0061 ns | 0.0057 ns |       0 B |
  ToDecimalNullable | 8.975 ns | 0.0027 ns | 0.0023 ns |       0 B |
         ToDateTime | 2.816 ns | 0.0032 ns | 0.0030 ns |       0 B |
 ToDateTimeNullable | 8.319 ns | 0.0018 ns | 0.0015 ns |       0 B |
           ToObject | 1.798 ns | 0.0046 ns | 0.0043 ns |       0 B |
          To_String | 2.045 ns | 0.0024 ns | 0.0021 ns |       0 B |
             ToEnum | 2.052 ns | 0.0045 ns | 0.0042 ns |       0 B |
     ToEnumNullable | 4.988 ns | 0.0080 ns | 0.0062 ns |       0 B |
