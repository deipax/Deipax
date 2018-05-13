
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 1.776 ns | 0.0038 ns | 0.0034 ns |       0 B |
     ToBoolNullable | 4.490 ns | 0.0027 ns | 0.0024 ns |       0 B |
             ToChar | 1.773 ns | 0.0011 ns | 0.0009 ns |       0 B |
     ToCharNullable | 4.997 ns | 0.0030 ns | 0.0028 ns |       0 B |
            ToSByte | 1.774 ns | 0.0024 ns | 0.0021 ns |       0 B |
    ToSByteNullable | 5.002 ns | 0.0051 ns | 0.0048 ns |       0 B |
             ToByte | 1.776 ns | 0.0030 ns | 0.0028 ns |       0 B |
     ToByteNullable | 4.994 ns | 0.0008 ns | 0.0007 ns |       0 B |
            ToShort | 1.768 ns | 0.0024 ns | 0.0022 ns |       0 B |
    ToShortNullable | 4.995 ns | 0.0037 ns | 0.0035 ns |       0 B |
           ToUShort | 1.766 ns | 0.0023 ns | 0.0019 ns |       0 B |
   ToUShortNullable | 4.994 ns | 0.0030 ns | 0.0026 ns |       0 B |
              ToInt | 2.282 ns | 0.0004 ns | 0.0004 ns |       0 B |
      ToIntNullable | 1.278 ns | 0.0015 ns | 0.0014 ns |       0 B |
             ToUInt | 2.300 ns | 0.0005 ns | 0.0004 ns |       0 B |
     ToUIntNullable | 5.277 ns | 0.0053 ns | 0.0041 ns |       0 B |
             ToLong | 2.046 ns | 0.0024 ns | 0.0020 ns |       0 B |
     ToLongNullable | 3.065 ns | 0.0017 ns | 0.0013 ns |       0 B |
            ToULong | 2.298 ns | 0.0007 ns | 0.0006 ns |       0 B |
    ToULongNullable | 3.079 ns | 0.0180 ns | 0.0141 ns |       0 B |
            ToFloat | 2.044 ns | 0.0017 ns | 0.0014 ns |       0 B |
    ToFloatNullable | 4.491 ns | 0.0043 ns | 0.0040 ns |       0 B |
           ToDouble | 2.046 ns | 0.0025 ns | 0.0022 ns |       0 B |
   ToDoubleNullable | 3.322 ns | 0.0061 ns | 0.0057 ns |       0 B |
          ToDecimal | 3.580 ns | 0.0053 ns | 0.0049 ns |       0 B |
  ToDecimalNullable | 9.087 ns | 0.0036 ns | 0.0032 ns |       0 B |
         ToDateTime | 2.811 ns | 0.0028 ns | 0.0026 ns |       0 B |
 ToDateTimeNullable | 8.322 ns | 0.0048 ns | 0.0045 ns |       0 B |
           ToObject | 2.045 ns | 0.0007 ns | 0.0006 ns |       0 B |
          To_String | 2.302 ns | 0.0058 ns | 0.0048 ns |       0 B |
             ToEnum | 2.049 ns | 0.0037 ns | 0.0035 ns |       0 B |
     ToEnumNullable | 5.083 ns | 0.0063 ns | 0.0056 ns |       0 B |
