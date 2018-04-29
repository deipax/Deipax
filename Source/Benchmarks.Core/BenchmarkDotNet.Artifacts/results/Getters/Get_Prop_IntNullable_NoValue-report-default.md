
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.949 ns | 0.0010 ns | 0.0009 ns |       0 B |
     ToBoolNullable | 6.769 ns | 0.0099 ns | 0.0093 ns |       0 B |
             ToChar | 3.953 ns | 0.0043 ns | 0.0036 ns |       0 B |
     ToCharNullable | 6.765 ns | 0.0072 ns | 0.0060 ns |       0 B |
            ToSByte | 4.069 ns | 0.0027 ns | 0.0023 ns |       0 B |
    ToSByteNullable | 6.769 ns | 0.0010 ns | 0.0009 ns |       0 B |
             ToByte | 3.784 ns | 0.0024 ns | 0.0020 ns |       0 B |
     ToByteNullable | 6.770 ns | 0.0008 ns | 0.0007 ns |       0 B |
            ToShort | 3.869 ns | 0.0038 ns | 0.0035 ns |       0 B |
    ToShortNullable | 6.769 ns | 0.0012 ns | 0.0011 ns |       0 B |
           ToUShort | 3.826 ns | 0.0066 ns | 0.0059 ns |       0 B |
   ToUShortNullable | 6.789 ns | 0.0058 ns | 0.0051 ns |       0 B |
              ToInt | 2.322 ns | 0.0078 ns | 0.0073 ns |       0 B |
      ToIntNullable | 2.045 ns | 0.0028 ns | 0.0025 ns |       0 B |
             ToUInt | 4.413 ns | 0.0009 ns | 0.0008 ns |       0 B |
     ToUIntNullable | 7.265 ns | 0.0042 ns | 0.0037 ns |       0 B |
             ToLong | 4.090 ns | 0.0044 ns | 0.0036 ns |       0 B |
     ToLongNullable | 6.645 ns | 0.0161 ns | 0.0143 ns |       0 B |
            ToULong | 4.331 ns | 0.0007 ns | 0.0006 ns |       0 B |
    ToULongNullable | 6.658 ns | 0.0110 ns | 0.0102 ns |       0 B |
            ToFloat | 4.087 ns | 0.0008 ns | 0.0007 ns |       0 B |
    ToFloatNullable | 6.789 ns | 0.0051 ns | 0.0042 ns |       0 B |
           ToDouble | 4.090 ns | 0.0056 ns | 0.0052 ns |       0 B |
   ToDoubleNullable | 6.388 ns | 0.0016 ns | 0.0013 ns |       0 B |
          ToDecimal | 7.156 ns | 0.0048 ns | 0.0043 ns |       0 B |
  ToDecimalNullable | 6.389 ns | 0.0025 ns | 0.0021 ns |       0 B |
         ToDateTime | 5.364 ns | 0.0019 ns | 0.0018 ns |       0 B |
 ToDateTimeNullable | 6.651 ns | 0.0114 ns | 0.0107 ns |       0 B |
           ToObject | 2.809 ns | 0.0003 ns | 0.0003 ns |       0 B |
          To_String | 4.742 ns | 0.0035 ns | 0.0032 ns |       0 B |
             ToEnum | 4.812 ns | 0.0101 ns | 0.0094 ns |       0 B |
