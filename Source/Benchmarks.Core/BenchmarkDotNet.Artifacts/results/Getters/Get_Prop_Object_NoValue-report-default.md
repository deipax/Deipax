
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Allocated |
------------------- |----------:|----------:|----------:|----------:|
             ToBool |  2.999 ns | 0.0185 ns | 0.0144 ns |       0 B |
     ToBoolNullable |  5.742 ns | 0.1318 ns | 0.1100 ns |       0 B |
             ToChar |  3.177 ns | 0.1379 ns | 0.1641 ns |       0 B |
     ToCharNullable |  5.791 ns | 0.1038 ns | 0.0920 ns |       0 B |
            ToSByte |  3.043 ns | 0.0583 ns | 0.0517 ns |       0 B |
    ToSByteNullable |  5.985 ns | 0.1442 ns | 0.1417 ns |       0 B |
             ToByte |  3.001 ns | 0.0307 ns | 0.0256 ns |       0 B |
     ToByteNullable |  5.782 ns | 0.0171 ns | 0.0151 ns |       0 B |
            ToShort |  3.017 ns | 0.0498 ns | 0.0442 ns |       0 B |
    ToShortNullable |  5.773 ns | 0.0207 ns | 0.0194 ns |       0 B |
           ToUShort |  3.019 ns | 0.0098 ns | 0.0087 ns |       0 B |
   ToUShortNullable |  5.985 ns | 0.1255 ns | 0.1174 ns |       0 B |
              ToInt |  3.123 ns | 0.0616 ns | 0.0546 ns |       0 B |
      ToIntNullable |  5.805 ns | 0.0247 ns | 0.0193 ns |       0 B |
             ToUInt |  3.080 ns | 0.0195 ns | 0.0163 ns |       0 B |
     ToUIntNullable |  5.822 ns | 0.0613 ns | 0.0543 ns |       0 B |
             ToLong |  3.076 ns | 0.0853 ns | 0.0798 ns |       0 B |
     ToLongNullable |  4.403 ns | 0.0440 ns | 0.0367 ns |       0 B |
            ToULong |  3.740 ns | 0.0926 ns | 0.0867 ns |       0 B |
    ToULongNullable |  4.451 ns | 0.1093 ns | 0.0912 ns |       0 B |
            ToFloat |  3.008 ns | 0.0229 ns | 0.0179 ns |       0 B |
    ToFloatNullable |  5.835 ns | 0.1204 ns | 0.1126 ns |       0 B |
           ToDouble |  2.996 ns | 0.0247 ns | 0.0231 ns |       0 B |
   ToDoubleNullable |  4.432 ns | 0.0918 ns | 0.0814 ns |       0 B |
          ToDecimal |  4.400 ns | 0.0138 ns | 0.0123 ns |       0 B |
  ToDecimalNullable | 10.545 ns | 0.1903 ns | 0.1780 ns |       0 B |
         ToDateTime |  3.987 ns | 0.1132 ns | 0.1586 ns |       0 B |
 ToDateTimeNullable | 10.379 ns | 0.1493 ns | 0.1166 ns |       0 B |
           ToObject |  1.336 ns | 0.0687 ns | 0.0675 ns |       0 B |
          To_String |  2.921 ns | 0.0487 ns | 0.0456 ns |       0 B |
             ToEnum |  2.895 ns | 0.0372 ns | 0.0311 ns |       0 B |
     ToEnumNullable |  5.928 ns | 0.1070 ns | 0.1001 ns |       0 B |
