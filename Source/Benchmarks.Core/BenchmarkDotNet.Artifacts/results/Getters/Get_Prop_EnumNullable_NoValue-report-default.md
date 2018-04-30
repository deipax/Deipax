
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.267 ns | 0.0028 ns | 0.0025 ns |       0 B |
     ToBoolNullable | 6.762 ns | 0.0063 ns | 0.0055 ns |       0 B |
             ToChar | 3.318 ns | 0.0039 ns | 0.0036 ns |       0 B |
     ToCharNullable | 6.533 ns | 0.0064 ns | 0.0056 ns |       0 B |
            ToSByte | 3.300 ns | 0.0055 ns | 0.0052 ns |       0 B |
    ToSByteNullable | 6.538 ns | 0.0116 ns | 0.0103 ns |       0 B |
             ToByte | 3.388 ns | 0.0031 ns | 0.0028 ns |       0 B |
     ToByteNullable | 6.531 ns | 0.0011 ns | 0.0009 ns |       0 B |
            ToShort | 3.275 ns | 0.0025 ns | 0.0022 ns |       0 B |
    ToShortNullable | 6.752 ns | 0.0089 ns | 0.0079 ns |       0 B |
           ToUShort | 3.282 ns | 0.0026 ns | 0.0023 ns |       0 B |
   ToUShortNullable | 6.530 ns | 0.0027 ns | 0.0021 ns |       0 B |
              ToInt | 3.265 ns | 0.0059 ns | 0.0049 ns |       0 B |
      ToIntNullable | 6.533 ns | 0.0066 ns | 0.0062 ns |       0 B |
             ToUInt | 4.074 ns | 0.0042 ns | 0.0033 ns |       0 B |
     ToUIntNullable | 6.789 ns | 0.0068 ns | 0.0064 ns |       0 B |
             ToLong | 3.284 ns | 0.0040 ns | 0.0037 ns |       0 B |
     ToLongNullable | 5.881 ns | 0.0047 ns | 0.0044 ns |       0 B |
            ToULong | 3.893 ns | 0.0038 ns | 0.0032 ns |       0 B |
    ToULongNullable | 6.144 ns | 0.0117 ns | 0.0109 ns |       0 B |
            ToFloat | 3.439 ns | 0.0216 ns | 0.0202 ns |       0 B |
    ToFloatNullable | 6.540 ns | 0.0059 ns | 0.0055 ns |       0 B |
           ToDouble | 3.393 ns | 0.0033 ns | 0.0029 ns |       0 B |
   ToDoubleNullable | 6.140 ns | 0.0104 ns | 0.0098 ns |       0 B |
          ToDecimal | 5.910 ns | 0.0124 ns | 0.0116 ns |       0 B |
  ToDecimalNullable | 6.140 ns | 0.0044 ns | 0.0039 ns |       0 B |
         ToDateTime | 4.088 ns | 0.0076 ns | 0.0068 ns |       0 B |
 ToDateTimeNullable | 6.144 ns | 0.0156 ns | 0.0122 ns |       0 B |
           ToObject | 1.790 ns | 0.0017 ns | 0.0016 ns |       0 B |
          To_String | 4.277 ns | 0.0011 ns | 0.0009 ns |       0 B |
             ToEnum | 2.301 ns | 0.0030 ns | 0.0028 ns |       0 B |
