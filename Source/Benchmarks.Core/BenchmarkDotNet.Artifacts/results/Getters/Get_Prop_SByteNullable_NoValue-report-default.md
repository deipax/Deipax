
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.849 ns | 0.0060 ns | 0.0056 ns |       0 B |
     ToBoolNullable | 6.515 ns | 0.0107 ns | 0.0100 ns |       0 B |
             ToChar | 3.890 ns | 0.0043 ns | 0.0040 ns |       0 B |
     ToCharNullable | 6.784 ns | 0.0087 ns | 0.0081 ns |       0 B |
            ToSByte | 1.773 ns | 0.0023 ns | 0.0022 ns |       0 B |
    ToSByteNullable | 1.279 ns | 0.0022 ns | 0.0021 ns |       0 B |
             ToByte | 4.176 ns | 0.0044 ns | 0.0041 ns |       0 B |
     ToByteNullable | 6.785 ns | 0.0038 ns | 0.0036 ns |       0 B |
            ToShort | 3.306 ns | 0.0010 ns | 0.0009 ns |       0 B |
    ToShortNullable | 6.527 ns | 0.0015 ns | 0.0013 ns |       0 B |
           ToUShort | 3.929 ns | 0.0024 ns | 0.0020 ns |       0 B |
   ToUShortNullable | 6.785 ns | 0.0021 ns | 0.0017 ns |       0 B |
              ToInt | 3.304 ns | 0.0005 ns | 0.0004 ns |       0 B |
      ToIntNullable | 6.530 ns | 0.0014 ns | 0.0009 ns |       0 B |
             ToUInt | 4.654 ns | 0.0108 ns | 0.0101 ns |       0 B |
     ToUIntNullable | 6.793 ns | 0.0092 ns | 0.0086 ns |       0 B |
             ToLong | 3.329 ns | 0.0081 ns | 0.0072 ns |       0 B |
     ToLongNullable | 5.901 ns | 0.0058 ns | 0.0048 ns |       0 B |
            ToULong | 3.949 ns | 0.0026 ns | 0.0022 ns |       0 B |
    ToULongNullable | 6.141 ns | 0.0024 ns | 0.0023 ns |       0 B |
            ToFloat | 3.701 ns | 0.0054 ns | 0.0051 ns |       0 B |
    ToFloatNullable | 6.795 ns | 0.0021 ns | 0.0018 ns |       0 B |
           ToDouble | 3.522 ns | 0.0009 ns | 0.0006 ns |       0 B |
   ToDoubleNullable | 6.173 ns | 0.0119 ns | 0.0111 ns |       0 B |
          ToDecimal | 6.418 ns | 0.0110 ns | 0.0098 ns |       0 B |
  ToDecimalNullable | 6.173 ns | 0.0039 ns | 0.0035 ns |       0 B |
         ToDateTime | 4.349 ns | 0.0065 ns | 0.0060 ns |       0 B |
 ToDateTimeNullable | 5.907 ns | 0.0048 ns | 0.0037 ns |       0 B |
           ToObject | 2.044 ns | 0.0002 ns | 0.0002 ns |       0 B |
          To_String | 3.994 ns | 0.0052 ns | 0.0044 ns |       0 B |
             ToEnum | 4.082 ns | 0.0078 ns | 0.0073 ns |       0 B |
