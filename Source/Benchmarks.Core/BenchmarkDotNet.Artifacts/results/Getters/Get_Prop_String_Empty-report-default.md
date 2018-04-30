
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 4.078 ns | 0.0022 ns | 0.0018 ns |       0 B |
     ToBoolNullable | 6.530 ns | 0.0064 ns | 0.0054 ns |       0 B |
             ToChar | 4.143 ns | 0.0033 ns | 0.0030 ns |       0 B |
     ToCharNullable | 6.533 ns | 0.0085 ns | 0.0076 ns |       0 B |
            ToSByte | 4.185 ns | 0.0029 ns | 0.0027 ns |       0 B |
    ToSByteNullable | 7.028 ns | 0.0082 ns | 0.0077 ns |       0 B |
             ToByte | 4.281 ns | 0.0089 ns | 0.0079 ns |       0 B |
     ToByteNullable | 7.020 ns | 0.0014 ns | 0.0011 ns |       0 B |
            ToShort | 4.125 ns | 0.0019 ns | 0.0016 ns |       0 B |
    ToShortNullable | 7.290 ns | 0.0288 ns | 0.0256 ns |       0 B |
           ToUShort | 4.341 ns | 0.0074 ns | 0.0069 ns |       0 B |
   ToUShortNullable | 7.023 ns | 0.0018 ns | 0.0015 ns |       0 B |
              ToInt | 4.208 ns | 0.0047 ns | 0.0044 ns |       0 B |
      ToIntNullable | 7.023 ns | 0.0014 ns | 0.0011 ns |       0 B |
             ToUInt | 4.372 ns | 0.0014 ns | 0.0013 ns |       0 B |
     ToUIntNullable | 7.023 ns | 0.0013 ns | 0.0010 ns |       0 B |
             ToLong | 4.142 ns | 0.0045 ns | 0.0040 ns |       0 B |
     ToLongNullable | 6.430 ns | 0.0046 ns | 0.0041 ns |       0 B |
            ToULong | 4.712 ns | 0.0058 ns | 0.0054 ns |       0 B |
    ToULongNullable | 6.408 ns | 0.0048 ns | 0.0040 ns |       0 B |
            ToFloat | 4.225 ns | 0.0070 ns | 0.0062 ns |       0 B |
    ToFloatNullable | 7.024 ns | 0.0014 ns | 0.0011 ns |       0 B |
           ToDouble | 4.590 ns | 0.0024 ns | 0.0021 ns |       0 B |
   ToDoubleNullable | 6.471 ns | 0.0108 ns | 0.0101 ns |       0 B |
          ToDecimal | 5.887 ns | 0.0118 ns | 0.0105 ns |       0 B |
  ToDecimalNullable | 6.197 ns | 0.0088 ns | 0.0083 ns |       0 B |
         ToDateTime | 5.168 ns | 0.0069 ns | 0.0064 ns |       0 B |
 ToDateTimeNullable | 6.189 ns | 0.0075 ns | 0.0070 ns |       0 B |
           ToObject | 3.066 ns | 0.0003 ns | 0.0003 ns |       0 B |
          To_String | 1.277 ns | 0.0003 ns | 0.0002 ns |       0 B |
             ToEnum | 4.250 ns | 0.0007 ns | 0.0005 ns |       0 B |
