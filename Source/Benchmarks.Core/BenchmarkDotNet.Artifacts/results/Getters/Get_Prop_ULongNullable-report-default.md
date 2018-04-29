
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  6.326 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
     ToBoolNullable |  7.064 ns | 0.0200 ns | 0.0177 ns |      - |       0 B |
             ToChar |  6.655 ns | 0.0206 ns | 0.0183 ns |      - |       0 B |
     ToCharNullable |  9.989 ns | 0.0155 ns | 0.0129 ns |      - |       0 B |
            ToSByte |  5.610 ns | 0.0093 ns | 0.0078 ns |      - |       0 B |
    ToSByteNullable |  7.306 ns | 0.0135 ns | 0.0127 ns |      - |       0 B |
             ToByte |  6.909 ns | 0.0223 ns | 0.0208 ns |      - |       0 B |
     ToByteNullable |  7.839 ns | 0.0170 ns | 0.0159 ns |      - |       0 B |
            ToShort |  6.913 ns | 0.0253 ns | 0.0237 ns |      - |       0 B |
    ToShortNullable |  7.838 ns | 0.0261 ns | 0.0244 ns |      - |       0 B |
           ToUShort |  6.906 ns | 0.0223 ns | 0.0208 ns |      - |       0 B |
   ToUShortNullable |  7.820 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
              ToInt |  6.899 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
      ToIntNullable |  7.765 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
             ToUInt |  5.635 ns | 0.0182 ns | 0.0171 ns |      - |       0 B |
     ToUIntNullable |  7.297 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
             ToLong |  5.641 ns | 0.0224 ns | 0.0199 ns |      - |       0 B |
     ToLongNullable |  8.189 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
            ToULong |  2.832 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
    ToULongNullable |  3.076 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
            ToFloat |  6.561 ns | 0.0170 ns | 0.0151 ns |      - |       0 B |
    ToFloatNullable |  7.318 ns | 0.0132 ns | 0.0124 ns |      - |       0 B |
           ToDouble |  5.590 ns | 0.0156 ns | 0.0139 ns |      - |       0 B |
   ToDoubleNullable |  7.702 ns | 0.0269 ns | 0.0251 ns |      - |       0 B |
          ToDecimal |  7.699 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
  ToDecimalNullable | 16.283 ns | 0.0416 ns | 0.0325 ns |      - |       0 B |
         ToDateTime |  5.657 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
 ToDateTimeNullable |  6.430 ns | 0.0335 ns | 0.0313 ns |      - |       0 B |
           ToObject |  5.291 ns | 0.0119 ns | 0.0111 ns | 0.0057 |      24 B |
          To_String | 46.358 ns | 0.1315 ns | 0.1230 ns | 0.0076 |      32 B |
             ToEnum | 30.763 ns | 0.0636 ns | 0.0595 ns | 0.0057 |      24 B |
