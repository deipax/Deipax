
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.578 ns | 0.0163 ns | 0.0152 ns |      - |       0 B |
     ToBoolNullable |  6.806 ns | 0.0157 ns | 0.0139 ns |      - |       0 B |
             ToChar |  4.603 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
     ToCharNullable |  7.327 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
            ToSByte |  4.558 ns | 0.0114 ns | 0.0107 ns |      - |       0 B |
    ToSByteNullable |  7.053 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
             ToByte |  4.851 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
     ToByteNullable |  7.330 ns | 0.0233 ns | 0.0207 ns |      - |       0 B |
            ToShort |  4.853 ns | 0.0179 ns | 0.0168 ns |      - |       0 B |
    ToShortNullable |  7.314 ns | 0.0137 ns | 0.0121 ns |      - |       0 B |
           ToUShort |  4.853 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
   ToUShortNullable |  7.311 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
              ToInt |  4.855 ns | 0.0133 ns | 0.0124 ns |      - |       0 B |
      ToIntNullable |  7.308 ns | 0.0221 ns | 0.0206 ns |      - |       0 B |
             ToUInt |  4.202 ns | 0.0137 ns | 0.0121 ns |      - |       0 B |
     ToUIntNullable |  7.056 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
             ToLong |  4.362 ns | 0.0128 ns | 0.0119 ns |      - |       0 B |
     ToLongNullable |  7.433 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
            ToULong |  1.796 ns | 0.0065 ns | 0.0061 ns |      - |       0 B |
    ToULongNullable |  3.078 ns | 0.0109 ns | 0.0102 ns |      - |       0 B |
            ToFloat |  4.354 ns | 0.0119 ns | 0.0105 ns |      - |       0 B |
    ToFloatNullable |  6.786 ns | 0.0047 ns | 0.0042 ns |      - |       0 B |
           ToDouble |  4.350 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
   ToDoubleNullable |  6.906 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
          ToDecimal |  6.915 ns | 0.0164 ns | 0.0153 ns |      - |       0 B |
  ToDecimalNullable | 15.996 ns | 0.0264 ns | 0.0247 ns |      - |       0 B |
         ToDateTime |  5.131 ns | 0.0180 ns | 0.0169 ns |      - |       0 B |
 ToDateTimeNullable |  6.417 ns | 0.0200 ns | 0.0177 ns |      - |       0 B |
           ToObject |  4.536 ns | 0.0090 ns | 0.0084 ns | 0.0057 |      24 B |
          To_String | 45.795 ns | 0.1182 ns | 0.1106 ns | 0.0076 |      32 B |
             ToEnum | 24.543 ns | 0.0514 ns | 0.0481 ns | 0.0057 |      24 B |
