
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 4.137 ns | 0.1102 ns | 0.1225 ns |       0 B |
     ToBoolNullable | 6.544 ns | 0.0626 ns | 0.0585 ns |       0 B |
             ToChar | 3.975 ns | 0.0103 ns | 0.0096 ns |       0 B |
     ToCharNullable | 6.685 ns | 0.1429 ns | 0.1266 ns |       0 B |
            ToSByte | 4.287 ns | 0.0192 ns | 0.0179 ns |       0 B |
    ToSByteNullable | 6.787 ns | 0.0484 ns | 0.0404 ns |       0 B |
             ToByte | 4.204 ns | 0.0619 ns | 0.0579 ns |       0 B |
     ToByteNullable | 6.520 ns | 0.0098 ns | 0.0076 ns |       0 B |
            ToShort | 3.964 ns | 0.0161 ns | 0.0143 ns |       0 B |
    ToShortNullable | 6.519 ns | 0.0116 ns | 0.0097 ns |       0 B |
           ToUShort | 3.995 ns | 0.0305 ns | 0.0271 ns |       0 B |
   ToUShortNullable | 6.554 ns | 0.0344 ns | 0.0287 ns |       0 B |
              ToInt | 3.978 ns | 0.0092 ns | 0.0077 ns |       0 B |
      ToIntNullable | 6.550 ns | 0.0195 ns | 0.0173 ns |       0 B |
             ToUInt | 4.412 ns | 0.0294 ns | 0.0275 ns |       0 B |
     ToUIntNullable | 6.811 ns | 0.0426 ns | 0.0398 ns |       0 B |
             ToLong | 4.237 ns | 0.0340 ns | 0.0318 ns |       0 B |
     ToLongNullable | 6.473 ns | 0.0653 ns | 0.0611 ns |       0 B |
            ToULong | 1.799 ns | 0.0132 ns | 0.0123 ns |       0 B |
    ToULongNullable | 2.602 ns | 0.0544 ns | 0.0509 ns |       0 B |
            ToFloat | 4.114 ns | 0.0209 ns | 0.0185 ns |       0 B |
    ToFloatNullable | 6.525 ns | 0.0042 ns | 0.0033 ns |       0 B |
           ToDouble | 4.414 ns | 0.0073 ns | 0.0068 ns |       0 B |
   ToDoubleNullable | 5.941 ns | 0.0301 ns | 0.0282 ns |       0 B |
          ToDecimal | 6.513 ns | 0.1477 ns | 0.1310 ns |       0 B |
  ToDecimalNullable | 6.159 ns | 0.0187 ns | 0.0156 ns |       0 B |
         ToDateTime | 5.259 ns | 0.1348 ns | 0.1443 ns |       0 B |
 ToDateTimeNullable | 6.667 ns | 0.0123 ns | 0.0115 ns |       0 B |
           ToObject | 2.044 ns | 0.0050 ns | 0.0046 ns |       0 B |
          To_String | 4.303 ns | 0.0157 ns | 0.0147 ns |       0 B |
             ToEnum | 4.493 ns | 0.0071 ns | 0.0060 ns |       0 B |
