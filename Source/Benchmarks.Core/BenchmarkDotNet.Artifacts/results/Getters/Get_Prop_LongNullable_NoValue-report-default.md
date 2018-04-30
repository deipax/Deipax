
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 4.122 ns | 0.0035 ns | 0.0031 ns |       0 B |
     ToBoolNullable | 6.504 ns | 0.0063 ns | 0.0059 ns |       0 B |
             ToChar | 4.124 ns | 0.0056 ns | 0.0053 ns |       0 B |
     ToCharNullable | 6.518 ns | 0.0087 ns | 0.0077 ns |       0 B |
            ToSByte | 3.954 ns | 0.0048 ns | 0.0045 ns |       0 B |
    ToSByteNullable | 6.524 ns | 0.0069 ns | 0.0061 ns |       0 B |
             ToByte | 4.159 ns | 0.0009 ns | 0.0007 ns |       0 B |
     ToByteNullable | 6.516 ns | 0.0026 ns | 0.0022 ns |       0 B |
            ToShort | 3.996 ns | 0.0062 ns | 0.0058 ns |       0 B |
    ToShortNullable | 6.526 ns | 0.0075 ns | 0.0070 ns |       0 B |
           ToUShort | 4.076 ns | 0.0063 ns | 0.0059 ns |       0 B |
   ToUShortNullable | 6.521 ns | 0.0072 ns | 0.0068 ns |       0 B |
              ToInt | 3.948 ns | 0.0061 ns | 0.0057 ns |       0 B |
      ToIntNullable | 6.521 ns | 0.0037 ns | 0.0032 ns |       0 B |
             ToUInt | 4.197 ns | 0.0071 ns | 0.0066 ns |       0 B |
     ToUIntNullable | 6.518 ns | 0.0024 ns | 0.0021 ns |       0 B |
             ToLong | 1.787 ns | 0.0005 ns | 0.0004 ns |       0 B |
     ToLongNullable | 2.813 ns | 0.0027 ns | 0.0024 ns |       0 B |
            ToULong | 4.290 ns | 0.0051 ns | 0.0045 ns |       0 B |
    ToULongNullable | 6.696 ns | 0.0058 ns | 0.0049 ns |       0 B |
            ToFloat | 4.062 ns | 0.0048 ns | 0.0045 ns |       0 B |
    ToFloatNullable | 6.521 ns | 0.0026 ns | 0.0020 ns |       0 B |
           ToDouble | 4.384 ns | 0.0103 ns | 0.0080 ns |       0 B |
   ToDoubleNullable | 5.904 ns | 0.0054 ns | 0.0045 ns |       0 B |
          ToDecimal | 6.396 ns | 0.0098 ns | 0.0092 ns |       0 B |
  ToDecimalNullable | 6.159 ns | 0.0066 ns | 0.0062 ns |       0 B |
         ToDateTime | 5.124 ns | 0.0066 ns | 0.0059 ns |       0 B |
 ToDateTimeNullable | 6.244 ns | 0.0100 ns | 0.0088 ns |       0 B |
           ToObject | 2.048 ns | 0.0024 ns | 0.0022 ns |       0 B |
          To_String | 4.278 ns | 0.0058 ns | 0.0054 ns |       0 B |
             ToEnum | 4.540 ns | 0.0020 ns | 0.0015 ns |       0 B |
