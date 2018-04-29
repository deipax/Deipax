
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   3.604 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
     ToBoolNullable |   7.035 ns | 0.0244 ns | 0.0228 ns |      - |       0 B |
             ToChar |   3.599 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
     ToCharNullable |   7.056 ns | 0.0197 ns | 0.0174 ns |      - |       0 B |
            ToSByte |   3.693 ns | 0.0095 ns | 0.0088 ns |      - |       0 B |
    ToSByteNullable |   7.041 ns | 0.0117 ns | 0.0103 ns |      - |       0 B |
             ToByte |   3.700 ns | 0.0096 ns | 0.0089 ns |      - |       0 B |
     ToByteNullable |   7.053 ns | 0.0138 ns | 0.0115 ns |      - |       0 B |
            ToShort |   3.607 ns | 0.0095 ns | 0.0080 ns |      - |       0 B |
    ToShortNullable |   7.040 ns | 0.0179 ns | 0.0167 ns |      - |       0 B |
           ToUShort |   3.600 ns | 0.0087 ns | 0.0082 ns |      - |       0 B |
   ToUShortNullable |   7.045 ns | 0.0189 ns | 0.0177 ns |      - |       0 B |
              ToInt |   3.730 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
      ToIntNullable |   7.039 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
             ToUInt |   3.586 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
     ToUIntNullable |   7.033 ns | 0.0117 ns | 0.0109 ns |      - |       0 B |
             ToLong |   3.599 ns | 0.0148 ns | 0.0139 ns |      - |       0 B |
     ToLongNullable |   7.175 ns | 0.0172 ns | 0.0160 ns |      - |       0 B |
            ToULong |   3.626 ns | 0.0175 ns | 0.0155 ns |      - |       0 B |
    ToULongNullable |   7.174 ns | 0.0068 ns | 0.0060 ns |      - |       0 B |
            ToFloat |   3.587 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
    ToFloatNullable |   7.037 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
           ToDouble |   4.028 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
   ToDoubleNullable |   7.168 ns | 0.0179 ns | 0.0159 ns |      - |       0 B |
          ToDecimal |   6.665 ns | 0.0209 ns | 0.0185 ns |      - |       0 B |
  ToDecimalNullable |   7.176 ns | 0.0233 ns | 0.0207 ns |      - |       0 B |
         ToDateTime |   2.054 ns | 0.0069 ns | 0.0064 ns |      - |       0 B |
 ToDateTimeNullable |   6.772 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
           ToObject |   4.530 ns | 0.0134 ns | 0.0126 ns | 0.0057 |      24 B |
          To_String | 419.532 ns | 1.1167 ns | 0.9899 ns | 0.0401 |     168 B |
             ToEnum |  21.810 ns | 0.0736 ns | 0.0688 ns | 0.0057 |      24 B |
