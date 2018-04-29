
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  4.475 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
     ToBoolNullable |  7.042 ns | 0.0242 ns | 0.0226 ns |      - |       0 B |
             ToChar |  6.174 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
     ToCharNullable |  7.724 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
            ToSByte |  5.921 ns | 0.0227 ns | 0.0212 ns |      - |       0 B |
    ToSByteNullable |  7.572 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
             ToByte |  6.164 ns | 0.0163 ns | 0.0153 ns |      - |       0 B |
     ToByteNullable |  7.559 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
            ToShort |  6.154 ns | 0.0111 ns | 0.0104 ns |      - |       0 B |
    ToShortNullable |  7.560 ns | 0.0098 ns | 0.0086 ns |      - |       0 B |
           ToUShort |  6.167 ns | 0.0217 ns | 0.0203 ns |      - |       0 B |
   ToUShortNullable |  7.716 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
              ToInt |  4.388 ns | 0.0163 ns | 0.0136 ns |      - |       0 B |
      ToIntNullable |  6.814 ns | 0.0205 ns | 0.0192 ns |      - |       0 B |
             ToUInt |  4.882 ns | 0.0101 ns | 0.0095 ns |      - |       0 B |
     ToUIntNullable |  7.269 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
             ToLong |  4.355 ns | 0.0177 ns | 0.0148 ns |      - |       0 B |
     ToLongNullable |  7.935 ns | 0.0090 ns | 0.0080 ns |      - |       0 B |
            ToULong |  4.868 ns | 0.0179 ns | 0.0168 ns |      - |       0 B |
    ToULongNullable |  8.450 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
            ToFloat |  4.409 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
    ToFloatNullable |  6.787 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
           ToDouble |  4.396 ns | 0.0166 ns | 0.0156 ns |      - |       0 B |
   ToDoubleNullable |  7.695 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
          ToDecimal |  7.433 ns | 0.0224 ns | 0.0209 ns |      - |       0 B |
  ToDecimalNullable | 16.492 ns | 0.0198 ns | 0.0185 ns |      - |       0 B |
         ToDateTime |  5.134 ns | 0.0196 ns | 0.0183 ns |      - |       0 B |
 ToDateTimeNullable |  6.932 ns | 0.0228 ns | 0.0203 ns |      - |       0 B |
           ToObject |  5.064 ns | 0.0212 ns | 0.0198 ns | 0.0057 |      24 B |
          To_String | 73.078 ns | 0.1596 ns | 0.1493 ns | 0.0057 |      24 B |
             ToEnum |  2.834 ns | 0.0108 ns | 0.0090 ns |      - |       0 B |
