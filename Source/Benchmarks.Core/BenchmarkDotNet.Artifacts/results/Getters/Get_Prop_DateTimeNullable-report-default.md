
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   4.335 ns | 0.0064 ns | 0.0060 ns |      - |       0 B |
     ToBoolNullable |   7.064 ns | 0.0105 ns | 0.0098 ns |      - |       0 B |
             ToChar |   4.346 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
     ToCharNullable |   6.879 ns | 0.0015 ns | 0.0014 ns |      - |       0 B |
            ToSByte |   4.944 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
    ToSByteNullable |   6.898 ns | 0.0034 ns | 0.0029 ns |      - |       0 B |
             ToByte |   4.421 ns | 0.0226 ns | 0.0212 ns |      - |       0 B |
     ToByteNullable |   6.816 ns | 0.0028 ns | 0.0023 ns |      - |       0 B |
            ToShort |   4.351 ns | 0.0130 ns | 0.0122 ns |      - |       0 B |
    ToShortNullable |   6.809 ns | 0.0118 ns | 0.0111 ns |      - |       0 B |
           ToUShort |   4.356 ns | 0.0184 ns | 0.0173 ns |      - |       0 B |
   ToUShortNullable |   6.891 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
              ToInt |   4.355 ns | 0.0161 ns | 0.0151 ns |      - |       0 B |
      ToIntNullable |   6.850 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
             ToUInt |   4.594 ns | 0.0139 ns | 0.0130 ns |      - |       0 B |
     ToUIntNullable |   7.045 ns | 0.0102 ns | 0.0080 ns |      - |       0 B |
             ToLong |   4.373 ns | 0.0180 ns | 0.0159 ns |      - |       0 B |
     ToLongNullable |   6.660 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
            ToULong |   4.366 ns | 0.0174 ns | 0.0163 ns |      - |       0 B |
    ToULongNullable |   6.656 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
            ToFloat |   4.365 ns | 0.0118 ns | 0.0110 ns |      - |       0 B |
    ToFloatNullable |   6.874 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
           ToDouble |   4.365 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
   ToDoubleNullable |   7.185 ns | 0.0198 ns | 0.0186 ns |      - |       0 B |
          ToDecimal |   5.910 ns | 0.0238 ns | 0.0222 ns |      - |       0 B |
  ToDecimalNullable |   7.177 ns | 0.0179 ns | 0.0167 ns |      - |       0 B |
         ToDateTime |   2.899 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
 ToDateTimeNullable |   3.321 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
           ToObject |   5.311 ns | 0.0070 ns | 0.0062 ns | 0.0057 |      24 B |
          To_String | 428.744 ns | 1.6238 ns | 1.5189 ns | 0.0401 |     168 B |
             ToEnum |  26.807 ns | 0.0640 ns | 0.0567 ns | 0.0057 |      24 B |
