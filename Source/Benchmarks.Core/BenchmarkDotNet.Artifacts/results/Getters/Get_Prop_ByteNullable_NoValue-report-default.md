
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 1.791 ns | 0.0032 ns | 0.0028 ns |       0 B |
     ToBoolNullable | 4.431 ns | 0.0060 ns | 0.0050 ns |       0 B |
             ToChar | 1.789 ns | 0.0005 ns | 0.0004 ns |       0 B |
     ToCharNullable | 4.473 ns | 0.0007 ns | 0.0005 ns |       0 B |
            ToSByte | 1.782 ns | 0.0067 ns | 0.0063 ns |       0 B |
    ToSByteNullable | 4.979 ns | 0.0007 ns | 0.0006 ns |       0 B |
             ToByte | 2.301 ns | 0.0028 ns | 0.0026 ns |       0 B |
     ToByteNullable | 1.282 ns | 0.0057 ns | 0.0054 ns |       0 B |
            ToShort | 2.045 ns | 0.0019 ns | 0.0017 ns |       0 B |
    ToShortNullable | 4.472 ns | 0.0036 ns | 0.0032 ns |       0 B |
           ToUShort | 2.049 ns | 0.0078 ns | 0.0073 ns |       0 B |
   ToUShortNullable | 4.472 ns | 0.0016 ns | 0.0014 ns |       0 B |
              ToInt | 2.044 ns | 0.0015 ns | 0.0014 ns |       0 B |
      ToIntNullable | 4.733 ns | 0.0126 ns | 0.0112 ns |       0 B |
             ToUInt | 2.044 ns | 0.0011 ns | 0.0009 ns |       0 B |
     ToUIntNullable | 4.726 ns | 0.0022 ns | 0.0019 ns |       0 B |
             ToLong | 2.045 ns | 0.0022 ns | 0.0019 ns |       0 B |
     ToLongNullable | 3.066 ns | 0.0012 ns | 0.0010 ns |       0 B |
            ToULong | 2.048 ns | 0.0063 ns | 0.0059 ns |       0 B |
    ToULongNullable | 3.065 ns | 0.0005 ns | 0.0004 ns |       0 B |
            ToFloat | 2.304 ns | 0.0077 ns | 0.0068 ns |       0 B |
    ToFloatNullable | 4.727 ns | 0.0020 ns | 0.0019 ns |       0 B |
           ToDouble | 2.299 ns | 0.0027 ns | 0.0024 ns |       0 B |
   ToDoubleNullable | 3.576 ns | 0.0003 ns | 0.0002 ns |       0 B |
          ToDecimal | 3.831 ns | 0.0011 ns | 0.0009 ns |       0 B |
  ToDecimalNullable | 9.698 ns | 0.0115 ns | 0.0090 ns |       0 B |
         ToDateTime | 3.069 ns | 0.0059 ns | 0.0055 ns |       0 B |
 ToDateTimeNullable | 8.801 ns | 0.0012 ns | 0.0010 ns |       0 B |
           ToObject | 1.815 ns | 0.0029 ns | 0.0027 ns |       0 B |
          To_String | 2.045 ns | 0.0006 ns | 0.0005 ns |       0 B |
             ToEnum | 2.044 ns | 0.0005 ns | 0.0004 ns |       0 B |
     ToEnumNullable | 4.965 ns | 0.0020 ns | 0.0018 ns |       0 B |
