
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.282 ns | 0.0048 ns | 0.0040 ns |       0 B |
     ToBoolNullable | 6.745 ns | 0.0030 ns | 0.0024 ns |       0 B |
             ToChar | 4.046 ns | 0.0024 ns | 0.0021 ns |       0 B |
     ToCharNullable | 6.512 ns | 0.0056 ns | 0.0047 ns |       0 B |
            ToSByte | 4.169 ns | 0.0062 ns | 0.0052 ns |       0 B |
    ToSByteNullable | 6.767 ns | 0.0061 ns | 0.0054 ns |       0 B |
             ToByte | 4.065 ns | 0.0069 ns | 0.0065 ns |       0 B |
     ToByteNullable | 6.783 ns | 0.0040 ns | 0.0037 ns |       0 B |
            ToShort | 4.011 ns | 0.0068 ns | 0.0057 ns |       0 B |
    ToShortNullable | 6.778 ns | 0.0047 ns | 0.0044 ns |       0 B |
           ToUShort | 1.797 ns | 0.0007 ns | 0.0005 ns |       0 B |
   ToUShortNullable | 1.280 ns | 0.0015 ns | 0.0013 ns |       0 B |
              ToInt | 3.352 ns | 0.0074 ns | 0.0061 ns |       0 B |
      ToIntNullable | 6.516 ns | 0.0057 ns | 0.0048 ns |       0 B |
             ToUInt | 3.654 ns | 0.0010 ns | 0.0008 ns |       0 B |
     ToUIntNullable | 6.515 ns | 0.0050 ns | 0.0044 ns |       0 B |
             ToLong | 3.455 ns | 0.0021 ns | 0.0018 ns |       0 B |
     ToLongNullable | 6.436 ns | 0.0157 ns | 0.0147 ns |       0 B |
            ToULong | 3.369 ns | 0.0055 ns | 0.0043 ns |       0 B |
    ToULongNullable | 6.417 ns | 0.0125 ns | 0.0110 ns |       0 B |
            ToFloat | 3.330 ns | 0.0047 ns | 0.0041 ns |       0 B |
    ToFloatNullable | 6.520 ns | 0.0169 ns | 0.0150 ns |       0 B |
           ToDouble | 3.860 ns | 0.0033 ns | 0.0031 ns |       0 B |
   ToDoubleNullable | 6.157 ns | 0.0123 ns | 0.0115 ns |       0 B |
          ToDecimal | 6.397 ns | 0.0048 ns | 0.0045 ns |       0 B |
  ToDecimalNullable | 6.436 ns | 0.0246 ns | 0.0230 ns |       0 B |
         ToDateTime | 4.606 ns | 0.0032 ns | 0.0030 ns |       0 B |
 ToDateTimeNullable | 6.557 ns | 0.1268 ns | 0.1186 ns |       0 B |
           ToObject | 2.046 ns | 0.0068 ns | 0.0060 ns |       0 B |
          To_String | 3.933 ns | 0.0383 ns | 0.0339 ns |       0 B |
             ToEnum | 4.160 ns | 0.0848 ns | 0.0793 ns |       0 B |
