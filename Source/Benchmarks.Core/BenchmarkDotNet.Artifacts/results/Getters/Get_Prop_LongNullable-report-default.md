
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  5.883 ns | 0.0123 ns | 0.0115 ns |      - |       0 B |
     ToBoolNullable |  7.062 ns | 0.0267 ns | 0.0249 ns |      - |       0 B |
             ToChar |  6.933 ns | 0.0174 ns | 0.0136 ns |      - |       0 B |
     ToCharNullable |  7.919 ns | 0.1109 ns | 0.1038 ns |      - |       0 B |
            ToSByte | 12.679 ns | 0.0258 ns | 0.0228 ns |      - |       0 B |
    ToSByteNullable |  7.833 ns | 0.0244 ns | 0.0229 ns |      - |       0 B |
             ToByte |  6.943 ns | 0.0177 ns | 0.0165 ns |      - |       0 B |
     ToByteNullable |  7.908 ns | 0.0354 ns | 0.0331 ns |      - |       0 B |
            ToShort |  6.966 ns | 0.0282 ns | 0.0264 ns |      - |       0 B |
    ToShortNullable |  7.906 ns | 0.1125 ns | 0.0998 ns |      - |       0 B |
           ToUShort |  6.957 ns | 0.0169 ns | 0.0149 ns |      - |       0 B |
   ToUShortNullable |  7.957 ns | 0.0288 ns | 0.0269 ns |      - |       0 B |
              ToInt |  6.978 ns | 0.0364 ns | 0.0341 ns |      - |       0 B |
      ToIntNullable |  7.825 ns | 0.0230 ns | 0.0204 ns |      - |       0 B |
             ToUInt |  6.926 ns | 0.0164 ns | 0.0154 ns |      - |       0 B |
     ToUIntNullable |  7.838 ns | 0.0316 ns | 0.0296 ns |      - |       0 B |
             ToLong |  2.839 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
     ToLongNullable |  3.591 ns | 0.0079 ns | 0.0070 ns |      - |       0 B |
            ToULong |  5.480 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
    ToULongNullable |  7.694 ns | 0.0198 ns | 0.0176 ns |      - |       0 B |
            ToFloat |  5.554 ns | 0.0241 ns | 0.0226 ns |      - |       0 B |
    ToFloatNullable |  7.299 ns | 0.0195 ns | 0.0182 ns |      - |       0 B |
           ToDouble |  5.401 ns | 0.0185 ns | 0.0155 ns |      - |       0 B |
   ToDoubleNullable |  7.504 ns | 0.0272 ns | 0.0242 ns |      - |       0 B |
          ToDecimal |  8.473 ns | 0.0200 ns | 0.0187 ns |      - |       0 B |
  ToDecimalNullable | 16.519 ns | 0.0199 ns | 0.0186 ns |      - |       0 B |
         ToDateTime |  5.922 ns | 0.0305 ns | 0.0285 ns |      - |       0 B |
 ToDateTimeNullable |  6.951 ns | 0.0246 ns | 0.0230 ns |      - |       0 B |
           ToObject |  5.375 ns | 0.0189 ns | 0.0177 ns | 0.0057 |      24 B |
          To_String | 49.663 ns | 0.1984 ns | 0.1856 ns | 0.0076 |      32 B |
             ToEnum | 30.133 ns | 0.1389 ns | 0.1300 ns | 0.0057 |      24 B |
