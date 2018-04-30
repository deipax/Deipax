
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Allocated |
------------------- |-----------:|----------:|----------:|----------:|
             ToBool |         NA |        NA |        NA |       N/A |
     ToBoolNullable |         NA |        NA |        NA |       N/A |
             ToChar |   5.367 ns | 0.0082 ns | 0.0077 ns |       0 B |
     ToCharNullable |   7.816 ns | 0.0030 ns | 0.0025 ns |       0 B |
            ToSByte |  76.631 ns | 0.1239 ns | 0.1159 ns |       0 B |
    ToSByteNullable |  78.004 ns | 0.0310 ns | 0.0274 ns |       0 B |
             ToByte |  76.383 ns | 0.0744 ns | 0.0659 ns |       0 B |
     ToByteNullable |  77.992 ns | 0.0256 ns | 0.0214 ns |       0 B |
            ToShort |  77.841 ns | 0.1143 ns | 0.1070 ns |       0 B |
    ToShortNullable |  78.015 ns | 0.1238 ns | 0.1158 ns |       0 B |
           ToUShort |  75.128 ns | 0.0995 ns | 0.0931 ns |       0 B |
   ToUShortNullable |  76.092 ns | 0.0952 ns | 0.0891 ns |       0 B |
              ToInt |  75.658 ns | 0.0509 ns | 0.0425 ns |       0 B |
      ToIntNullable |  76.061 ns | 0.0394 ns | 0.0329 ns |       0 B |
             ToUInt |  72.979 ns | 0.0585 ns | 0.0548 ns |       0 B |
     ToUIntNullable |  74.153 ns | 0.0486 ns | 0.0431 ns |       0 B |
             ToLong |  75.884 ns | 0.0399 ns | 0.0354 ns |       0 B |
     ToLongNullable |  77.362 ns | 0.0122 ns | 0.0102 ns |       0 B |
            ToULong |  74.995 ns | 0.0810 ns | 0.0757 ns |       0 B |
    ToULongNullable |  76.867 ns | 0.0655 ns | 0.0612 ns |       0 B |
            ToFloat |  94.747 ns | 0.0612 ns | 0.0543 ns |       0 B |
    ToFloatNullable |  96.313 ns | 0.1072 ns | 0.1003 ns |       0 B |
           ToDouble |  92.956 ns | 0.1715 ns | 0.1432 ns |       0 B |
   ToDoubleNullable |  95.869 ns | 0.0483 ns | 0.0377 ns |       0 B |
          ToDecimal | 111.035 ns | 0.0928 ns | 0.0822 ns |       0 B |
  ToDecimalNullable | 111.892 ns | 0.1728 ns | 0.1616 ns |       0 B |
         ToDateTime |         NA |        NA |        NA |       N/A |
 ToDateTimeNullable |         NA |        NA |        NA |       N/A |
           ToObject |   3.062 ns | 0.0046 ns | 0.0043 ns |       0 B |
          To_String |   1.279 ns | 0.0022 ns | 0.0019 ns |       0 B |
             ToEnum |  33.045 ns | 0.0346 ns | 0.0289 ns |       0 B |

Benchmarks with issues:
  Get_Prop_String.ToBool: DefaultJob
  Get_Prop_String.ToBoolNullable: DefaultJob
  Get_Prop_String.ToDateTime: DefaultJob
  Get_Prop_String.ToDateTimeNullable: DefaultJob
