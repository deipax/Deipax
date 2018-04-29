
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.948 ns | 0.0175 ns | 0.0164 ns |       0 B |
     ToBoolNullable | 6.789 ns | 0.0076 ns | 0.0068 ns |       0 B |
             ToChar | 4.863 ns | 0.1316 ns | 0.1711 ns |       0 B |
     ToCharNullable | 7.081 ns | 0.1300 ns | 0.1216 ns |       0 B |
            ToSByte | 4.450 ns | 0.0384 ns | 0.0359 ns |       0 B |
    ToSByteNullable | 7.671 ns | 0.1213 ns | 0.1135 ns |       0 B |
             ToByte | 2.444 ns | 0.0583 ns | 0.0545 ns |       0 B |
     ToByteNullable | 1.955 ns | 0.0704 ns | 0.0810 ns |       0 B |
            ToShort | 4.088 ns | 0.0049 ns | 0.0038 ns |       0 B |
    ToShortNullable | 6.890 ns | 0.1277 ns | 0.1132 ns |       0 B |
           ToUShort | 4.067 ns | 0.0068 ns | 0.0060 ns |       0 B |
   ToUShortNullable | 6.817 ns | 0.0360 ns | 0.0336 ns |       0 B |
              ToInt | 4.093 ns | 0.0042 ns | 0.0040 ns |       0 B |
      ToIntNullable | 6.793 ns | 0.0341 ns | 0.0302 ns |       0 B |
             ToUInt | 4.110 ns | 0.0029 ns | 0.0023 ns |       0 B |
     ToUIntNullable | 6.796 ns | 0.0470 ns | 0.0367 ns |       0 B |
             ToLong | 4.139 ns | 0.0073 ns | 0.0068 ns |       0 B |
     ToLongNullable | 6.177 ns | 0.0433 ns | 0.0361 ns |       0 B |
            ToULong | 4.094 ns | 0.0059 ns | 0.0055 ns |       0 B |
    ToULongNullable | 6.179 ns | 0.0494 ns | 0.0413 ns |       0 B |
            ToFloat | 4.098 ns | 0.0056 ns | 0.0052 ns |       0 B |
    ToFloatNullable | 6.805 ns | 0.0056 ns | 0.0041 ns |       0 B |
           ToDouble | 4.113 ns | 0.0081 ns | 0.0075 ns |       0 B |
   ToDoubleNullable | 6.415 ns | 0.0379 ns | 0.0354 ns |       0 B |
          ToDecimal | 7.157 ns | 0.0092 ns | 0.0086 ns |       0 B |
  ToDecimalNullable | 6.165 ns | 0.0040 ns | 0.0038 ns |       0 B |
         ToDateTime | 5.112 ns | 0.0066 ns | 0.0055 ns |       0 B |
 ToDateTimeNullable | 6.458 ns | 0.0092 ns | 0.0077 ns |       0 B |
           ToObject | 2.810 ns | 0.0005 ns | 0.0004 ns |       0 B |
          To_String | 4.685 ns | 0.0037 ns | 0.0033 ns |       0 B |
             ToEnum | 4.671 ns | 0.0060 ns | 0.0057 ns |       0 B |
