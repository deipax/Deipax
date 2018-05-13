
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Allocated |
------------------- |-----------:|----------:|----------:|----------:|
             ToBool |         NA |        NA |        NA |       N/A |
     ToBoolNullable |         NA |        NA |        NA |       N/A |
             ToChar |   3.862 ns | 0.0671 ns | 0.0560 ns |       0 B |
     ToCharNullable |   6.576 ns | 0.0346 ns | 0.0307 ns |       0 B |
            ToSByte |  77.887 ns | 1.2739 ns | 1.0638 ns |       0 B |
    ToSByteNullable |  78.029 ns | 0.9246 ns | 0.8197 ns |       0 B |
             ToByte |  75.645 ns | 0.7424 ns | 0.6581 ns |       0 B |
     ToByteNullable |  75.882 ns | 0.4708 ns | 0.4404 ns |       0 B |
            ToShort |  76.541 ns | 1.4875 ns | 1.3186 ns |       0 B |
    ToShortNullable |  76.819 ns | 0.3124 ns | 0.2609 ns |       0 B |
           ToUShort |  72.685 ns | 0.1918 ns | 0.1602 ns |       0 B |
   ToUShortNullable |  74.403 ns | 0.5161 ns | 0.4827 ns |       0 B |
              ToInt |  75.418 ns | 1.4825 ns | 1.4560 ns |       0 B |
      ToIntNullable |  74.754 ns | 0.5485 ns | 0.5131 ns |       0 B |
             ToUInt |  72.061 ns | 0.6483 ns | 0.5747 ns |       0 B |
     ToUIntNullable |  72.649 ns | 0.6924 ns | 0.6138 ns |       0 B |
             ToLong |  75.151 ns | 0.3292 ns | 0.2570 ns |       0 B |
     ToLongNullable |  75.709 ns | 0.3825 ns | 0.3391 ns |       0 B |
            ToULong |  73.414 ns | 0.5301 ns | 0.4427 ns |       0 B |
    ToULongNullable |  77.069 ns | 1.5073 ns | 1.6128 ns |       0 B |
            ToFloat |  93.376 ns | 0.2302 ns | 0.2153 ns |       0 B |
    ToFloatNullable |  95.422 ns | 1.0465 ns | 0.8739 ns |       0 B |
           ToDouble |  90.842 ns | 0.5050 ns | 0.4477 ns |       0 B |
   ToDoubleNullable |  92.845 ns | 1.1853 ns | 1.1087 ns |       0 B |
          ToDecimal | 107.490 ns | 0.8190 ns | 0.6839 ns |       0 B |
  ToDecimalNullable | 116.616 ns | 2.1288 ns | 1.9913 ns |       0 B |
         ToDateTime |         NA |        NA |        NA |       N/A |
 ToDateTimeNullable |         NA |        NA |        NA |       N/A |
           ToObject |   3.094 ns | 0.0315 ns | 0.0263 ns |       0 B |
          To_String |   1.320 ns | 0.0500 ns | 0.0443 ns |       0 B |
             ToEnum |  29.307 ns | 0.1497 ns | 0.1400 ns |       0 B |
     ToEnumNullable |  32.067 ns | 0.1540 ns | 0.1441 ns |       0 B |

Benchmarks with issues:
  Get_Prop_String.ToBool: DefaultJob
  Get_Prop_String.ToBoolNullable: DefaultJob
  Get_Prop_String.ToDateTime: DefaultJob
  Get_Prop_String.ToDateTimeNullable: DefaultJob
