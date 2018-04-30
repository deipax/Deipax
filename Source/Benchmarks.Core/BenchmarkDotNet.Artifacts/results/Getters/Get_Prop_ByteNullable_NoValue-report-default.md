
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.419 ns | 0.0992 ns | 0.1102 ns |       0 B |
     ToBoolNullable | 6.754 ns | 0.0048 ns | 0.0040 ns |       0 B |
             ToChar | 3.343 ns | 0.0040 ns | 0.0037 ns |       0 B |
     ToCharNullable | 6.518 ns | 0.0058 ns | 0.0055 ns |       0 B |
            ToSByte | 3.872 ns | 0.0030 ns | 0.0028 ns |       0 B |
    ToSByteNullable | 6.786 ns | 0.0240 ns | 0.0224 ns |       0 B |
             ToByte | 1.804 ns | 0.0044 ns | 0.0039 ns |       0 B |
     ToByteNullable | 1.279 ns | 0.0016 ns | 0.0013 ns |       0 B |
            ToShort | 3.350 ns | 0.0069 ns | 0.0064 ns |       0 B |
    ToShortNullable | 6.521 ns | 0.0236 ns | 0.0221 ns |       0 B |
           ToUShort | 3.437 ns | 0.0031 ns | 0.0027 ns |       0 B |
   ToUShortNullable | 6.520 ns | 0.0069 ns | 0.0064 ns |       0 B |
              ToInt | 3.501 ns | 0.0039 ns | 0.0036 ns |       0 B |
      ToIntNullable | 6.521 ns | 0.0237 ns | 0.0222 ns |       0 B |
             ToUInt | 3.604 ns | 0.0027 ns | 0.0024 ns |       0 B |
     ToUIntNullable | 6.520 ns | 0.0083 ns | 0.0077 ns |       0 B |
             ToLong | 3.349 ns | 0.0045 ns | 0.0038 ns |       0 B |
     ToLongNullable | 6.160 ns | 0.0236 ns | 0.0220 ns |       0 B |
            ToULong | 3.491 ns | 0.0053 ns | 0.0049 ns |       0 B |
    ToULongNullable | 6.187 ns | 0.0088 ns | 0.0073 ns |       0 B |
            ToFloat | 3.416 ns | 0.0211 ns | 0.0197 ns |       0 B |
    ToFloatNullable | 6.514 ns | 0.0099 ns | 0.0077 ns |       0 B |
           ToDouble | 3.534 ns | 0.0013 ns | 0.0011 ns |       0 B |
   ToDoubleNullable | 6.442 ns | 0.0250 ns | 0.0222 ns |       0 B |
          ToDecimal | 6.390 ns | 0.0020 ns | 0.0016 ns |       0 B |
  ToDecimalNullable | 6.230 ns | 0.0247 ns | 0.0231 ns |       0 B |
         ToDateTime | 4.607 ns | 0.0095 ns | 0.0084 ns |       0 B |
 ToDateTimeNullable | 6.399 ns | 0.0086 ns | 0.0081 ns |       0 B |
           ToObject | 2.044 ns | 0.0014 ns | 0.0012 ns |       0 B |
          To_String | 3.960 ns | 0.0051 ns | 0.0048 ns |       0 B |
             ToEnum | 4.148 ns | 0.0006 ns | 0.0006 ns |       0 B |
