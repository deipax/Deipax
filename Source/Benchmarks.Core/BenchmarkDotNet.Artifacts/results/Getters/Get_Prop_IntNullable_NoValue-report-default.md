
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.423 ns | 0.1010 ns | 0.1202 ns |       0 B |
     ToBoolNullable | 6.830 ns | 0.0558 ns | 0.0436 ns |       0 B |
             ToChar | 3.449 ns | 0.1097 ns | 0.1264 ns |       0 B |
     ToCharNullable | 6.787 ns | 0.1620 ns | 0.1515 ns |       0 B |
            ToSByte | 3.735 ns | 0.0811 ns | 0.0719 ns |       0 B |
    ToSByteNullable | 6.810 ns | 0.1657 ns | 0.2035 ns |       0 B |
             ToByte | 3.507 ns | 0.1037 ns | 0.1018 ns |       0 B |
     ToByteNullable | 6.670 ns | 0.1556 ns | 0.1528 ns |       0 B |
            ToShort | 3.375 ns | 0.0964 ns | 0.0902 ns |       0 B |
    ToShortNullable | 6.941 ns | 0.1254 ns | 0.1173 ns |       0 B |
           ToUShort | 3.289 ns | 0.0188 ns | 0.0166 ns |       0 B |
   ToUShortNullable | 6.538 ns | 0.0054 ns | 0.0050 ns |       0 B |
              ToInt | 1.772 ns | 0.0029 ns | 0.0027 ns |       0 B |
      ToIntNullable | 1.279 ns | 0.0019 ns | 0.0018 ns |       0 B |
             ToUInt | 4.131 ns | 0.0043 ns | 0.0040 ns |       0 B |
     ToUIntNullable | 6.784 ns | 0.0014 ns | 0.0012 ns |       0 B |
             ToLong | 3.337 ns | 0.0024 ns | 0.0019 ns |       0 B |
     ToLongNullable | 6.156 ns | 0.0050 ns | 0.0044 ns |       0 B |
            ToULong | 4.067 ns | 0.0031 ns | 0.0027 ns |       0 B |
    ToULongNullable | 5.899 ns | 0.0073 ns | 0.0064 ns |       0 B |
            ToFloat | 3.339 ns | 0.0027 ns | 0.0021 ns |       0 B |
    ToFloatNullable | 6.533 ns | 0.0116 ns | 0.0097 ns |       0 B |
           ToDouble | 3.657 ns | 0.0018 ns | 0.0015 ns |       0 B |
   ToDoubleNullable | 5.962 ns | 0.0087 ns | 0.0073 ns |       0 B |
          ToDecimal | 6.131 ns | 0.0013 ns | 0.0011 ns |       0 B |
  ToDecimalNullable | 5.912 ns | 0.0064 ns | 0.0057 ns |       0 B |
         ToDateTime | 4.776 ns | 0.0029 ns | 0.0026 ns |       0 B |
 ToDateTimeNullable | 6.160 ns | 0.0091 ns | 0.0081 ns |       0 B |
           ToObject | 2.045 ns | 0.0021 ns | 0.0020 ns |       0 B |
          To_String | 3.936 ns | 0.0054 ns | 0.0051 ns |       0 B |
             ToEnum | 4.201 ns | 0.0015 ns | 0.0014 ns |       0 B |
