
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 1.775 ns | 0.0020 ns | 0.0017 ns |       0 B |
     ToBoolNullable | 4.484 ns | 0.0041 ns | 0.0036 ns |       0 B |
             ToChar | 1.792 ns | 0.0165 ns | 0.0138 ns |       0 B |
     ToCharNullable | 5.001 ns | 0.0034 ns | 0.0032 ns |       0 B |
            ToSByte | 1.774 ns | 0.0026 ns | 0.0023 ns |       0 B |
    ToSByteNullable | 4.998 ns | 0.0034 ns | 0.0028 ns |       0 B |
             ToByte | 1.775 ns | 0.0033 ns | 0.0029 ns |       0 B |
     ToByteNullable | 4.997 ns | 0.0027 ns | 0.0025 ns |       0 B |
            ToShort | 2.277 ns | 0.0029 ns | 0.0026 ns |       0 B |
    ToShortNullable | 1.279 ns | 0.0024 ns | 0.0021 ns |       0 B |
           ToUShort | 2.029 ns | 0.0030 ns | 0.0028 ns |       0 B |
   ToUShortNullable | 5.000 ns | 0.0041 ns | 0.0038 ns |       0 B |
              ToInt | 2.029 ns | 0.0047 ns | 0.0037 ns |       0 B |
      ToIntNullable | 4.743 ns | 0.0017 ns | 0.0016 ns |       0 B |
             ToUInt | 2.061 ns | 0.0152 ns | 0.0135 ns |       0 B |
     ToUIntNullable | 4.997 ns | 0.0009 ns | 0.0008 ns |       0 B |
             ToLong | 2.056 ns | 0.0174 ns | 0.0163 ns |       0 B |
     ToLongNullable | 3.323 ns | 0.0058 ns | 0.0054 ns |       0 B |
            ToULong | 2.052 ns | 0.0162 ns | 0.0151 ns |       0 B |
    ToULongNullable | 3.081 ns | 0.0020 ns | 0.0017 ns |       0 B |
            ToFloat | 2.302 ns | 0.0041 ns | 0.0039 ns |       0 B |
    ToFloatNullable | 4.780 ns | 0.0006 ns | 0.0005 ns |       0 B |
           ToDouble | 2.299 ns | 0.0033 ns | 0.0031 ns |       0 B |
   ToDoubleNullable | 3.330 ns | 0.0033 ns | 0.0031 ns |       0 B |
          ToDecimal | 3.325 ns | 0.0056 ns | 0.0052 ns |       0 B |
  ToDecimalNullable | 9.678 ns | 0.0077 ns | 0.0068 ns |       0 B |
         ToDateTime | 2.811 ns | 0.0030 ns | 0.0025 ns |       0 B |
 ToDateTimeNullable | 8.843 ns | 0.0065 ns | 0.0051 ns |       0 B |
           ToObject | 1.791 ns | 0.0021 ns | 0.0019 ns |       0 B |
          To_String | 2.062 ns | 0.0048 ns | 0.0045 ns |       0 B |
             ToEnum | 2.047 ns | 0.0035 ns | 0.0033 ns |       0 B |
     ToEnumNullable | 4.988 ns | 0.0025 ns | 0.0022 ns |       0 B |
