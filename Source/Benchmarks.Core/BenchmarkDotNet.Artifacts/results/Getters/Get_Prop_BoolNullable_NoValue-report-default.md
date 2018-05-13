
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev |   Median | Allocated |
------------------- |---------:|----------:|----------:|---------:|----------:|
             ToBool | 2.297 ns | 0.0025 ns | 0.0021 ns | 2.296 ns |       0 B |
     ToBoolNullable | 1.262 ns | 0.0040 ns | 0.0034 ns | 1.262 ns |       0 B |
             ToChar | 1.278 ns | 0.0015 ns | 0.0014 ns | 1.279 ns |       0 B |
     ToCharNullable | 4.471 ns | 0.0031 ns | 0.0028 ns | 4.470 ns |       0 B |
            ToSByte | 2.047 ns | 0.0040 ns | 0.0038 ns | 2.045 ns |       0 B |
    ToSByteNullable | 4.733 ns | 0.0034 ns | 0.0032 ns | 4.731 ns |       0 B |
             ToByte | 2.087 ns | 0.0249 ns | 0.0233 ns | 2.073 ns |       0 B |
     ToByteNullable | 4.726 ns | 0.0008 ns | 0.0006 ns | 4.726 ns |       0 B |
            ToShort | 2.050 ns | 0.0055 ns | 0.0051 ns | 2.050 ns |       0 B |
    ToShortNullable | 4.522 ns | 0.0037 ns | 0.0035 ns | 4.522 ns |       0 B |
           ToUShort | 2.094 ns | 0.0024 ns | 0.0017 ns | 2.094 ns |       0 B |
   ToUShortNullable | 4.500 ns | 0.0155 ns | 0.0129 ns | 4.496 ns |       0 B |
              ToInt | 2.046 ns | 0.0025 ns | 0.0024 ns | 2.046 ns |       0 B |
      ToIntNullable | 4.727 ns | 0.0020 ns | 0.0018 ns | 4.726 ns |       0 B |
             ToUInt | 2.045 ns | 0.0018 ns | 0.0015 ns | 2.044 ns |       0 B |
     ToUIntNullable | 4.729 ns | 0.0021 ns | 0.0018 ns | 4.728 ns |       0 B |
             ToLong | 2.053 ns | 0.0250 ns | 0.0234 ns | 2.041 ns |       0 B |
     ToLongNullable | 3.068 ns | 0.0075 ns | 0.0063 ns | 3.064 ns |       0 B |
            ToULong | 2.060 ns | 0.0214 ns | 0.0200 ns | 2.052 ns |       0 B |
    ToULongNullable | 3.322 ns | 0.0027 ns | 0.0023 ns | 3.321 ns |       0 B |
            ToFloat | 2.068 ns | 0.0288 ns | 0.0270 ns | 2.090 ns |       0 B |
    ToFloatNullable | 4.732 ns | 0.0020 ns | 0.0019 ns | 4.732 ns |       0 B |
           ToDouble | 2.047 ns | 0.0262 ns | 0.0233 ns | 2.039 ns |       0 B |
   ToDoubleNullable | 3.324 ns | 0.0063 ns | 0.0059 ns | 3.321 ns |       0 B |
          ToDecimal | 3.593 ns | 0.0024 ns | 0.0020 ns | 3.594 ns |       0 B |
  ToDecimalNullable | 9.695 ns | 0.0047 ns | 0.0039 ns | 9.693 ns |       0 B |
         ToDateTime | 3.107 ns | 0.0015 ns | 0.0012 ns | 3.107 ns |       0 B |
 ToDateTimeNullable | 8.807 ns | 0.0134 ns | 0.0125 ns | 8.799 ns |       0 B |
           ToObject | 1.791 ns | 0.0023 ns | 0.0022 ns | 1.790 ns |       0 B |
          To_String | 2.072 ns | 0.0026 ns | 0.0017 ns | 2.072 ns |       0 B |
             ToEnum | 2.047 ns | 0.0043 ns | 0.0038 ns | 2.045 ns |       0 B |
     ToEnumNullable | 4.975 ns | 0.0022 ns | 0.0019 ns | 4.974 ns |       0 B |
