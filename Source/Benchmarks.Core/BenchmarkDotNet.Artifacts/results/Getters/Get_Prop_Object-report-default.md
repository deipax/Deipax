
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Allocated |
------------------- |----------:|----------:|----------:|----------:|
             ToBool |  7.017 ns | 0.0722 ns | 0.0676 ns |       0 B |
     ToBoolNullable | 10.080 ns | 0.0262 ns | 0.0245 ns |       0 B |
             ToChar |  6.936 ns | 0.0047 ns | 0.0044 ns |       0 B |
     ToCharNullable | 10.815 ns | 0.0134 ns | 0.0125 ns |       0 B |
            ToSByte |  7.661 ns | 0.0055 ns | 0.0051 ns |       0 B |
    ToSByteNullable |  9.845 ns | 0.0076 ns | 0.0067 ns |       0 B |
             ToByte |  7.074 ns | 0.0101 ns | 0.0079 ns |       0 B |
     ToByteNullable |  9.665 ns | 0.0490 ns | 0.0409 ns |       0 B |
            ToShort |  6.874 ns | 0.0175 ns | 0.0155 ns |       0 B |
    ToShortNullable |  9.369 ns | 0.0150 ns | 0.0140 ns |       0 B |
           ToUShort |  7.026 ns | 0.0022 ns | 0.0018 ns |       0 B |
   ToUShortNullable |  9.542 ns | 0.0092 ns | 0.0077 ns |       0 B |
              ToInt |  7.733 ns | 0.0019 ns | 0.0015 ns |       0 B |
      ToIntNullable |  9.906 ns | 0.0126 ns | 0.0112 ns |       0 B |
             ToUInt |  7.025 ns | 0.0021 ns | 0.0019 ns |       0 B |
     ToUIntNullable |  9.313 ns | 0.0080 ns | 0.0071 ns |       0 B |
             ToLong |  7.492 ns | 0.0035 ns | 0.0030 ns |       0 B |
     ToLongNullable | 11.269 ns | 0.0097 ns | 0.0090 ns |       0 B |
            ToULong |  7.003 ns | 0.0044 ns | 0.0039 ns |       0 B |
    ToULongNullable | 11.251 ns | 0.0156 ns | 0.0146 ns |       0 B |
            ToFloat |  6.920 ns | 0.0016 ns | 0.0014 ns |       0 B |
    ToFloatNullable |  9.812 ns | 0.0024 ns | 0.0020 ns |       0 B |
           ToDouble |  6.995 ns | 0.0031 ns | 0.0028 ns |       0 B |
   ToDoubleNullable | 11.136 ns | 0.0157 ns | 0.0147 ns |       0 B |
          ToDecimal |  9.897 ns | 0.0147 ns | 0.0138 ns |       0 B |
  ToDecimalNullable | 11.277 ns | 0.0137 ns | 0.0122 ns |       0 B |
         ToDateTime |  7.921 ns | 0.0017 ns | 0.0013 ns |       0 B |
 ToDateTimeNullable | 11.247 ns | 0.0087 ns | 0.0081 ns |       0 B |
           ToObject |  1.278 ns | 0.0019 ns | 0.0016 ns |       0 B |
          To_String | 23.766 ns | 0.0015 ns | 0.0011 ns |       0 B |
             ToEnum | 28.707 ns | 0.0183 ns | 0.0153 ns |       0 B |
