
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   2.029 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
     ToBoolNullable |   5.006 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
             ToChar |   1.269 ns | 0.0066 ns | 0.0059 ns |      - |       0 B |
     ToCharNullable |   4.487 ns | 0.0023 ns | 0.0021 ns |      - |       0 B |
            ToSByte |   5.991 ns | 0.1152 ns | 0.1077 ns |      - |       0 B |
    ToSByteNullable |   8.066 ns | 0.0041 ns | 0.0037 ns |      - |       0 B |
             ToByte |   6.143 ns | 0.0170 ns | 0.0159 ns |      - |       0 B |
     ToByteNullable |   8.071 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
            ToShort |   6.133 ns | 0.0182 ns | 0.0171 ns |      - |       0 B |
    ToShortNullable |   8.094 ns | 0.0047 ns | 0.0037 ns |      - |       0 B |
           ToUShort |   6.136 ns | 0.0173 ns | 0.0145 ns |      - |       0 B |
   ToUShortNullable |   8.069 ns | 0.0084 ns | 0.0075 ns |      - |       0 B |
              ToInt |   4.373 ns | 0.0116 ns | 0.0097 ns |      - |       0 B |
      ToIntNullable |   7.049 ns | 0.0124 ns | 0.0116 ns |      - |       0 B |
             ToUInt |   4.279 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
     ToUIntNullable |   7.044 ns | 0.0069 ns | 0.0064 ns |      - |       0 B |
             ToLong |   5.626 ns | 0.0126 ns | 0.0112 ns |      - |       0 B |
     ToLongNullable |   7.409 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
            ToULong |   5.119 ns | 0.0074 ns | 0.0066 ns |      - |       0 B |
    ToULongNullable |   6.646 ns | 0.0052 ns | 0.0043 ns |      - |       0 B |
            ToFloat |   2.046 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
    ToFloatNullable |   4.784 ns | 0.0021 ns | 0.0019 ns |      - |       0 B |
           ToDouble |   2.087 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
   ToDoubleNullable |   2.302 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
          ToDecimal |  63.366 ns | 0.0158 ns | 0.0132 ns |      - |       0 B |
  ToDecimalNullable |  76.650 ns | 0.0713 ns | 0.0667 ns |      - |       0 B |
         ToDateTime |   2.817 ns | 0.0176 ns | 0.0138 ns |      - |       0 B |
 ToDateTimeNullable |   8.825 ns | 0.0148 ns | 0.0139 ns |      - |       0 B |
           ToObject |   4.885 ns | 0.0074 ns | 0.0069 ns | 0.0057 |      24 B |
          To_String | 257.186 ns | 0.0889 ns | 0.0694 ns | 0.0072 |      32 B |
             ToEnum |  16.123 ns | 0.0129 ns | 0.0101 ns |      - |       0 B |
     ToEnumNullable |  21.331 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
