
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Allocated |
------------------- |-----------:|----------:|----------:|----------:|
             ToBool |         NA |        NA |        NA |       N/A |
     ToBoolNullable |         NA |        NA |        NA |       N/A |
             ToChar |   6.126 ns | 0.0137 ns | 0.0121 ns |       0 B |
     ToCharNullable |   8.343 ns | 0.0289 ns | 0.0270 ns |       0 B |
            ToSByte |  79.625 ns | 0.2175 ns | 0.2035 ns |       0 B |
    ToSByteNullable |  81.306 ns | 0.3111 ns | 0.2429 ns |       0 B |
             ToByte |  77.854 ns | 0.1226 ns | 0.1087 ns |       0 B |
     ToByteNullable |  78.657 ns | 0.0570 ns | 0.0476 ns |       0 B |
            ToShort |  77.475 ns | 0.1893 ns | 0.1771 ns |       0 B |
    ToShortNullable |  79.237 ns | 0.0647 ns | 0.0574 ns |       0 B |
           ToUShort |  74.841 ns | 0.1308 ns | 0.1224 ns |       0 B |
   ToUShortNullable |  76.612 ns | 0.1891 ns | 0.1769 ns |       0 B |
              ToInt |  75.783 ns | 0.1291 ns | 0.1207 ns |       0 B |
      ToIntNullable |  77.008 ns | 0.1147 ns | 0.0958 ns |       0 B |
             ToUInt |  73.313 ns | 0.0803 ns | 0.0670 ns |       0 B |
     ToUIntNullable |  75.493 ns | 0.2037 ns | 0.1905 ns |       0 B |
             ToLong |  75.039 ns | 0.2136 ns | 0.1998 ns |       0 B |
     ToLongNullable |  79.223 ns | 0.1574 ns | 0.1395 ns |       0 B |
            ToULong |  75.194 ns | 0.2446 ns | 0.2288 ns |       0 B |
    ToULongNullable |  78.791 ns | 0.2187 ns | 0.2046 ns |       0 B |
            ToFloat |  96.344 ns | 0.2971 ns | 0.2779 ns |       0 B |
    ToFloatNullable |  98.932 ns | 0.2973 ns | 0.2781 ns |       0 B |
           ToDouble |  93.782 ns | 0.3289 ns | 0.3077 ns |       0 B |
   ToDoubleNullable |  99.223 ns | 0.1638 ns | 0.1532 ns |       0 B |
          ToDecimal | 111.486 ns | 0.2315 ns | 0.2166 ns |       0 B |
  ToDecimalNullable | 113.620 ns | 0.2293 ns | 0.2145 ns |       0 B |
         ToDateTime |         NA |        NA |        NA |       N/A |
 ToDateTimeNullable |         NA |        NA |        NA |       N/A |
           ToObject |   3.591 ns | 0.0112 ns | 0.0104 ns |       0 B |
          To_String |   1.796 ns | 0.0040 ns | 0.0035 ns |       0 B |
             ToEnum |  31.945 ns | 0.0993 ns | 0.0881 ns |       0 B |

Benchmarks with issues:
  Get_Prop_String.ToBool: DefaultJob
  Get_Prop_String.ToBoolNullable: DefaultJob
  Get_Prop_String.ToDateTime: DefaultJob
  Get_Prop_String.ToDateTimeNullable: DefaultJob
