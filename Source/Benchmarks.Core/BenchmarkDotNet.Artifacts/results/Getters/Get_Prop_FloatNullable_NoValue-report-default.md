
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 1.779 ns | 0.0023 ns | 0.0020 ns |       0 B |
     ToBoolNullable | 4.492 ns | 0.0022 ns | 0.0020 ns |       0 B |
             ToChar | 1.263 ns | 0.0015 ns | 0.0014 ns |       0 B |
     ToCharNullable | 4.485 ns | 0.0019 ns | 0.0018 ns |       0 B |
            ToSByte | 1.777 ns | 0.0071 ns | 0.0066 ns |       0 B |
    ToSByteNullable | 4.995 ns | 0.0006 ns | 0.0005 ns |       0 B |
             ToByte | 1.774 ns | 0.0035 ns | 0.0031 ns |       0 B |
     ToByteNullable | 5.013 ns | 0.0038 ns | 0.0036 ns |       0 B |
            ToShort | 1.773 ns | 0.0021 ns | 0.0018 ns |       0 B |
    ToShortNullable | 5.004 ns | 0.0037 ns | 0.0035 ns |       0 B |
           ToUShort | 1.773 ns | 0.0015 ns | 0.0013 ns |       0 B |
   ToUShortNullable | 5.009 ns | 0.0033 ns | 0.0031 ns |       0 B |
              ToInt | 1.775 ns | 0.0032 ns | 0.0030 ns |       0 B |
      ToIntNullable | 5.003 ns | 0.0032 ns | 0.0028 ns |       0 B |
             ToUInt | 1.788 ns | 0.0010 ns | 0.0008 ns |       0 B |
     ToUIntNullable | 5.005 ns | 0.0094 ns | 0.0088 ns |       0 B |
             ToLong | 1.900 ns | 0.0680 ns | 0.0784 ns |       0 B |
     ToLongNullable | 3.078 ns | 0.0106 ns | 0.0094 ns |       0 B |
            ToULong | 2.298 ns | 0.0005 ns | 0.0004 ns |       0 B |
    ToULongNullable | 3.072 ns | 0.0041 ns | 0.0038 ns |       0 B |
            ToFloat | 2.043 ns | 0.0016 ns | 0.0015 ns |       0 B |
    ToFloatNullable | 1.281 ns | 0.0015 ns | 0.0014 ns |       0 B |
           ToDouble | 1.791 ns | 0.0036 ns | 0.0033 ns |       0 B |
   ToDoubleNullable | 3.581 ns | 0.0041 ns | 0.0039 ns |       0 B |
          ToDecimal | 3.577 ns | 0.0010 ns | 0.0008 ns |       0 B |
  ToDecimalNullable | 9.104 ns | 0.0034 ns | 0.0026 ns |       0 B |
         ToDateTime | 2.560 ns | 0.0028 ns | 0.0026 ns |       0 B |
 ToDateTimeNullable | 8.559 ns | 0.0007 ns | 0.0006 ns |       0 B |
           ToObject | 1.793 ns | 0.0014 ns | 0.0013 ns |       0 B |
          To_String | 2.043 ns | 0.0009 ns | 0.0008 ns |       0 B |
             ToEnum | 2.050 ns | 0.0025 ns | 0.0024 ns |       0 B |
     ToEnumNullable | 4.819 ns | 0.0227 ns | 0.0212 ns |       0 B |
