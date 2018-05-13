
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 1.262 ns | 0.0014 ns | 0.0013 ns |       0 B |
     ToBoolNullable | 4.486 ns | 0.0024 ns | 0.0022 ns |       0 B |
             ToChar | 2.283 ns | 0.0012 ns | 0.0010 ns |       0 B |
     ToCharNullable | 1.277 ns | 0.0003 ns | 0.0002 ns |       0 B |
            ToSByte | 2.034 ns | 0.0059 ns | 0.0055 ns |       0 B |
    ToSByteNullable | 4.996 ns | 0.0023 ns | 0.0021 ns |       0 B |
             ToByte | 2.020 ns | 0.0069 ns | 0.0065 ns |       0 B |
     ToByteNullable | 5.011 ns | 0.0057 ns | 0.0053 ns |       0 B |
            ToShort | 2.028 ns | 0.0016 ns | 0.0013 ns |       0 B |
    ToShortNullable | 4.998 ns | 0.0031 ns | 0.0029 ns |       0 B |
           ToUShort | 2.029 ns | 0.0030 ns | 0.0026 ns |       0 B |
   ToUShortNullable | 4.743 ns | 0.0034 ns | 0.0028 ns |       0 B |
              ToInt | 2.036 ns | 0.0065 ns | 0.0058 ns |       0 B |
      ToIntNullable | 4.488 ns | 0.0028 ns | 0.0026 ns |       0 B |
             ToUInt | 2.049 ns | 0.0077 ns | 0.0072 ns |       0 B |
     ToUIntNullable | 4.488 ns | 0.0023 ns | 0.0022 ns |       0 B |
             ToLong | 2.045 ns | 0.0032 ns | 0.0030 ns |       0 B |
     ToLongNullable | 2.813 ns | 0.0036 ns | 0.0034 ns |       0 B |
            ToULong | 2.050 ns | 0.0095 ns | 0.0084 ns |       0 B |
    ToULongNullable | 2.809 ns | 0.0005 ns | 0.0005 ns |       0 B |
            ToFloat | 1.277 ns | 0.0003 ns | 0.0002 ns |       0 B |
    ToFloatNullable | 4.486 ns | 0.0027 ns | 0.0023 ns |       0 B |
           ToDouble | 1.280 ns | 0.0011 ns | 0.0010 ns |       0 B |
   ToDoubleNullable | 2.299 ns | 0.0005 ns | 0.0004 ns |       0 B |
          ToDecimal | 2.820 ns | 0.0029 ns | 0.0024 ns |       0 B |
  ToDecimalNullable | 2.299 ns | 0.0010 ns | 0.0008 ns |       0 B |
         ToDateTime | 2.815 ns | 0.0020 ns | 0.0018 ns |       0 B |
 ToDateTimeNullable | 8.385 ns | 0.0070 ns | 0.0058 ns |       0 B |
           ToObject | 1.797 ns | 0.0019 ns | 0.0016 ns |       0 B |
          To_String | 2.044 ns | 0.0017 ns | 0.0016 ns |       0 B |
             ToEnum | 2.052 ns | 0.0024 ns | 0.0021 ns |       0 B |
     ToEnumNullable | 4.990 ns | 0.0077 ns | 0.0072 ns |       0 B |
