
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.588 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
     ToBoolNullable |  6.802 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
             ToChar |  4.860 ns | 0.0137 ns | 0.0122 ns |      - |       0 B |
     ToCharNullable |  7.322 ns | 0.0178 ns | 0.0167 ns |      - |       0 B |
            ToSByte |  4.605 ns | 0.0104 ns | 0.0097 ns |      - |       0 B |
    ToSByteNullable |  7.355 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
             ToByte |  4.863 ns | 0.0143 ns | 0.0126 ns |      - |       0 B |
     ToByteNullable |  7.315 ns | 0.0160 ns | 0.0149 ns |      - |       0 B |
            ToShort |  4.865 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
    ToShortNullable |  7.334 ns | 0.0261 ns | 0.0244 ns |      - |       0 B |
           ToUShort |  4.864 ns | 0.0174 ns | 0.0154 ns |      - |       0 B |
   ToUShortNullable |  7.336 ns | 0.0305 ns | 0.0286 ns |      - |       0 B |
              ToInt |  3.583 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
      ToIntNullable |  6.800 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
             ToUInt |  4.228 ns | 0.0132 ns | 0.0124 ns |      - |       0 B |
     ToUIntNullable |  7.052 ns | 0.0213 ns | 0.0199 ns |      - |       0 B |
             ToLong |  3.602 ns | 0.0101 ns | 0.0089 ns |      - |       0 B |
     ToLongNullable |  6.658 ns | 0.0213 ns | 0.0199 ns |      - |       0 B |
            ToULong |  4.309 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
    ToULongNullable |  6.936 ns | 0.0232 ns | 0.0217 ns |      - |       0 B |
            ToFloat |  3.602 ns | 0.0148 ns | 0.0138 ns |      - |       0 B |
    ToFloatNullable |  6.799 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
           ToDouble |  3.597 ns | 0.0132 ns | 0.0124 ns |      - |       0 B |
   ToDoubleNullable |  6.923 ns | 0.0134 ns | 0.0112 ns |      - |       0 B |
          ToDecimal |  6.927 ns | 0.0242 ns | 0.0215 ns |      - |       0 B |
  ToDecimalNullable | 15.988 ns | 0.0191 ns | 0.0179 ns |      - |       0 B |
         ToDateTime |  4.869 ns | 0.0157 ns | 0.0147 ns |      - |       0 B |
 ToDateTimeNullable |  6.684 ns | 0.0389 ns | 0.0364 ns |      - |       0 B |
           ToObject |  4.062 ns | 0.0093 ns | 0.0087 ns | 0.0057 |      24 B |
          To_String | 71.921 ns | 0.2268 ns | 0.2122 ns | 0.0057 |      24 B |
             ToEnum |  2.048 ns | 0.0042 ns | 0.0039 ns |      - |       0 B |
