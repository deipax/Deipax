
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  2.029 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
     ToBoolNullable |  4.992 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
             ToChar |  2.527 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
     ToCharNullable |  5.252 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
            ToSByte |  3.820 ns | 0.0057 ns | 0.0051 ns |      - |       0 B |
    ToSByteNullable |  6.242 ns | 0.0022 ns | 0.0018 ns |      - |       0 B |
             ToByte |  3.817 ns | 0.0030 ns | 0.0027 ns |      - |       0 B |
     ToByteNullable |  6.240 ns | 0.0018 ns | 0.0014 ns |      - |       0 B |
            ToShort |  2.066 ns | 0.0005 ns | 0.0005 ns |      - |       0 B |
    ToShortNullable |  1.278 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
           ToUShort |  2.796 ns | 0.0078 ns | 0.0065 ns |      - |       0 B |
   ToUShortNullable |  5.511 ns | 0.0086 ns | 0.0072 ns |      - |       0 B |
              ToInt |  2.032 ns | 0.0052 ns | 0.0049 ns |      - |       0 B |
      ToIntNullable |  4.991 ns | 0.0023 ns | 0.0022 ns |      - |       0 B |
             ToUInt |  2.800 ns | 0.0064 ns | 0.0057 ns |      - |       0 B |
     ToUIntNullable |  5.487 ns | 0.0066 ns | 0.0052 ns |      - |       0 B |
             ToLong |  2.059 ns | 0.0166 ns | 0.0155 ns |      - |       0 B |
     ToLongNullable |  3.075 ns | 0.0093 ns | 0.0083 ns |      - |       0 B |
            ToULong |  2.813 ns | 0.0215 ns | 0.0191 ns |      - |       0 B |
    ToULongNullable |  3.584 ns | 0.0075 ns | 0.0059 ns |      - |       0 B |
            ToFloat |  2.310 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
    ToFloatNullable |  4.982 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
           ToDouble |  2.294 ns | 0.0190 ns | 0.0177 ns |      - |       0 B |
   ToDoubleNullable |  3.067 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
          ToDecimal |  6.769 ns | 0.0046 ns | 0.0041 ns |      - |       0 B |
  ToDecimalNullable | 20.828 ns | 0.0140 ns | 0.0125 ns |      - |       0 B |
         ToDateTime |  2.817 ns | 0.0115 ns | 0.0108 ns |      - |       0 B |
 ToDateTimeNullable |  8.828 ns | 0.0152 ns | 0.0142 ns |      - |       0 B |
           ToObject |  4.876 ns | 0.0022 ns | 0.0018 ns | 0.0057 |      24 B |
          To_String | 42.112 ns | 0.1088 ns | 0.1018 ns | 0.0076 |      32 B |
             ToEnum | 14.774 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
     ToEnumNullable | 20.196 ns | 0.0209 ns | 0.0195 ns |      - |       0 B |
