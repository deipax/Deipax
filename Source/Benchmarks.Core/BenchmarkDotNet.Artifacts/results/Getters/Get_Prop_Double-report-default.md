
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   4.012 ns | 0.0080 ns | 0.0075 ns |      - |       0 B |
     ToBoolNullable |   6.790 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
             ToChar |   3.701 ns | 0.0069 ns | 0.0065 ns |      - |       0 B |
     ToCharNullable |   6.779 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
            ToSByte |   7.964 ns | 0.0185 ns | 0.0173 ns |      - |       0 B |
    ToSByteNullable |  10.315 ns | 0.0220 ns | 0.0206 ns |      - |       0 B |
             ToByte |   8.999 ns | 0.0221 ns | 0.0207 ns |      - |       0 B |
     ToByteNullable |  10.313 ns | 0.0140 ns | 0.0124 ns |      - |       0 B |
            ToShort |   7.652 ns | 0.0142 ns | 0.0126 ns |      - |       0 B |
    ToShortNullable |  12.516 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
           ToUShort |   7.729 ns | 0.0203 ns | 0.0190 ns |      - |       0 B |
   ToUShortNullable |  10.294 ns | 0.0181 ns | 0.0151 ns |      - |       0 B |
              ToInt |   5.903 ns | 0.0178 ns | 0.0158 ns |      - |       0 B |
      ToIntNullable |   8.349 ns | 0.0269 ns | 0.0251 ns |      - |       0 B |
             ToUInt |   5.754 ns | 0.0301 ns | 0.0235 ns |      - |       0 B |
     ToUIntNullable |   8.335 ns | 0.0244 ns | 0.0228 ns |      - |       0 B |
             ToLong |   7.192 ns | 0.0209 ns | 0.0195 ns |      - |       0 B |
     ToLongNullable |  10.269 ns | 0.0261 ns | 0.0204 ns |      - |       0 B |
            ToULong |   7.075 ns | 0.0093 ns | 0.0073 ns |      - |       0 B |
    ToULongNullable |  10.355 ns | 0.0296 ns | 0.0276 ns |      - |       0 B |
            ToFloat |   3.596 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
    ToFloatNullable |   6.788 ns | 0.0145 ns | 0.0135 ns |      - |       0 B |
           ToDouble |   1.801 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
   ToDoubleNullable |   3.334 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
          ToDecimal |  65.197 ns | 0.1154 ns | 0.1079 ns |      - |       0 B |
  ToDecimalNullable |  72.265 ns | 0.0716 ns | 0.0635 ns |      - |       0 B |
         ToDateTime |   5.382 ns | 0.0077 ns | 0.0072 ns |      - |       0 B |
 ToDateTimeNullable |   6.434 ns | 0.0344 ns | 0.0321 ns |      - |       0 B |
           ToObject |   4.548 ns | 0.0104 ns | 0.0098 ns | 0.0057 |      24 B |
          To_String | 258.936 ns | 0.7254 ns | 0.6785 ns | 0.0072 |      32 B |
             ToEnum |  25.343 ns | 0.0548 ns | 0.0513 ns | 0.0057 |      24 B |
