
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   6.340 ns | 0.0117 ns | 0.0091 ns |      - |       0 B |
     ToBoolNullable |   8.737 ns | 0.2001 ns | 0.1966 ns |      - |       0 B |
             ToChar |   1.547 ns | 0.0257 ns | 0.0228 ns |      - |       0 B |
     ToCharNullable |   8.876 ns | 0.0207 ns | 0.0173 ns |      - |       0 B |
            ToSByte |   1.528 ns | 0.0065 ns | 0.0054 ns |      - |       0 B |
    ToSByteNullable |   8.967 ns | 0.0266 ns | 0.0208 ns |      - |       0 B |
             ToByte |   1.558 ns | 0.0461 ns | 0.0409 ns |      - |       0 B |
     ToByteNullable |   9.183 ns | 0.1118 ns | 0.0991 ns |      - |       0 B |
            ToShort |   1.544 ns | 0.0326 ns | 0.0289 ns |      - |       0 B |
    ToShortNullable |   8.622 ns | 0.0354 ns | 0.0314 ns |      - |       0 B |
           ToUShort |   1.547 ns | 0.0478 ns | 0.0447 ns |      - |       0 B |
   ToUShortNullable |   8.615 ns | 0.0066 ns | 0.0059 ns |      - |       0 B |
              ToInt |   1.538 ns | 0.0125 ns | 0.0105 ns |      - |       0 B |
      ToIntNullable |   8.879 ns | 0.0231 ns | 0.0193 ns |      - |       0 B |
             ToUInt |   1.556 ns | 0.0163 ns | 0.0127 ns |      - |       0 B |
     ToUIntNullable |   8.969 ns | 0.0351 ns | 0.0329 ns |      - |       0 B |
             ToLong |   1.609 ns | 0.0643 ns | 0.0740 ns |      - |       0 B |
     ToLongNullable |   2.820 ns | 0.0131 ns | 0.0109 ns |      - |       0 B |
            ToULong |   1.562 ns | 0.0370 ns | 0.0328 ns |      - |       0 B |
    ToULongNullable |   2.932 ns | 0.0835 ns | 0.1143 ns |      - |       0 B |
            ToFloat |   1.638 ns | 0.0652 ns | 0.1143 ns |      - |       0 B |
    ToFloatNullable |   8.621 ns | 0.0580 ns | 0.0484 ns |      - |       0 B |
           ToDouble |   1.529 ns | 0.0158 ns | 0.0132 ns |      - |       0 B |
   ToDoubleNullable |   2.833 ns | 0.0172 ns | 0.0160 ns |      - |       0 B |
          ToDecimal |   9.898 ns | 0.0431 ns | 0.0382 ns |      - |       0 B |
  ToDecimalNullable |   2.822 ns | 0.0164 ns | 0.0153 ns |      - |       0 B |
         ToDateTime |   2.237 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
 ToDateTimeNullable |   2.313 ns | 0.0135 ns | 0.0127 ns |      - |       0 B |
           ToObject |   5.786 ns | 0.0374 ns | 0.0312 ns | 0.0057 |      24 B |
          To_String | 431.353 ns | 8.5156 ns | 8.3635 ns | 0.0401 |     168 B |
             ToEnum |  14.612 ns | 0.0704 ns | 0.0624 ns |      - |       0 B |
     ToEnumNullable |  19.527 ns | 0.0726 ns | 0.0679 ns |      - |       0 B |
