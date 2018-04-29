
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
             ToBool |  2.798 ns | 0.0082 ns | 0.0077 ns |  2.793 ns |      - |       0 B |
     ToBoolNullable |  1.785 ns | 0.0155 ns | 0.0137 ns |  1.782 ns |      - |       0 B |
             ToChar |  3.834 ns | 0.0027 ns | 0.0022 ns |  3.834 ns |      - |       0 B |
     ToCharNullable |  6.792 ns | 0.0112 ns | 0.0087 ns |  6.788 ns |      - |       0 B |
            ToSByte |  5.410 ns | 0.0049 ns | 0.0043 ns |  5.410 ns |      - |       0 B |
    ToSByteNullable |  6.821 ns | 0.0069 ns | 0.0064 ns |  6.821 ns |      - |       0 B |
             ToByte |  5.350 ns | 0.0011 ns | 0.0008 ns |  5.350 ns |      - |       0 B |
     ToByteNullable |  6.984 ns | 0.0024 ns | 0.0020 ns |  6.984 ns |      - |       0 B |
            ToShort |  5.355 ns | 0.0088 ns | 0.0082 ns |  5.355 ns |      - |       0 B |
    ToShortNullable |  6.991 ns | 0.0076 ns | 0.0071 ns |  6.988 ns |      - |       0 B |
           ToUShort |  5.351 ns | 0.0039 ns | 0.0032 ns |  5.349 ns |      - |       0 B |
   ToUShortNullable |  6.794 ns | 0.0099 ns | 0.0093 ns |  6.789 ns |      - |       0 B |
              ToInt |  5.353 ns | 0.0053 ns | 0.0049 ns |  5.351 ns |      - |       0 B |
      ToIntNullable |  6.795 ns | 0.0075 ns | 0.0066 ns |  6.792 ns |      - |       0 B |
             ToUInt |  5.374 ns | 0.0327 ns | 0.0306 ns |  5.351 ns |      - |       0 B |
     ToUIntNullable |  6.976 ns | 0.0069 ns | 0.0062 ns |  6.973 ns |      - |       0 B |
             ToLong |  5.383 ns | 0.0050 ns | 0.0036 ns |  5.381 ns |      - |       0 B |
     ToLongNullable |  7.162 ns | 0.0104 ns | 0.0093 ns |  7.158 ns |      - |       0 B |
            ToULong |  5.392 ns | 0.0350 ns | 0.0310 ns |  5.410 ns |      - |       0 B |
    ToULongNullable |  7.426 ns | 0.0255 ns | 0.0238 ns |  7.410 ns |      - |       0 B |
            ToFloat |  5.370 ns | 0.0124 ns | 0.0103 ns |  5.365 ns |      - |       0 B |
    ToFloatNullable |  7.053 ns | 0.0117 ns | 0.0109 ns |  7.047 ns |      - |       0 B |
           ToDouble |  5.383 ns | 0.0533 ns | 0.0416 ns |  5.373 ns |      - |       0 B |
   ToDoubleNullable |  7.418 ns | 0.0139 ns | 0.0130 ns |  7.411 ns |      - |       0 B |
          ToDecimal |  8.804 ns | 0.2090 ns | 0.1955 ns |  8.774 ns |      - |       0 B |
  ToDecimalNullable | 16.489 ns | 0.0143 ns | 0.0112 ns | 16.482 ns |      - |       0 B |
         ToDateTime |  5.120 ns | 0.0101 ns | 0.0089 ns |  5.119 ns |      - |       0 B |
 ToDateTimeNullable |  6.406 ns | 0.0186 ns | 0.0155 ns |  6.399 ns |      - |       0 B |
           ToObject |  5.363 ns | 0.0617 ns | 0.0547 ns |  5.333 ns | 0.0057 |      24 B |
          To_String |  7.257 ns | 0.1717 ns | 0.1606 ns |  7.187 ns |      - |       0 B |
             ToEnum | 30.028 ns | 0.2751 ns | 0.2438 ns | 29.899 ns | 0.0057 |      24 B |
