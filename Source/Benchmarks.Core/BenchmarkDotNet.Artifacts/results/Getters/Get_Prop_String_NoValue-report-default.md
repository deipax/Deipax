
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.538 ns | 0.0024 ns | 0.0020 ns |       0 B |
     ToBoolNullable | 6.512 ns | 0.0039 ns | 0.0033 ns |       0 B |
             ToChar | 3.606 ns | 0.0039 ns | 0.0032 ns |       0 B |
     ToCharNullable | 6.531 ns | 0.0122 ns | 0.0114 ns |       0 B |
            ToSByte | 3.879 ns | 0.0005 ns | 0.0005 ns |       0 B |
    ToSByteNullable | 7.033 ns | 0.0059 ns | 0.0052 ns |       0 B |
             ToByte | 3.974 ns | 0.0046 ns | 0.0043 ns |       0 B |
     ToByteNullable | 7.029 ns | 0.0098 ns | 0.0091 ns |       0 B |
            ToShort | 3.900 ns | 0.0053 ns | 0.0050 ns |       0 B |
    ToShortNullable | 7.027 ns | 0.0060 ns | 0.0057 ns |       0 B |
           ToUShort | 4.014 ns | 0.0085 ns | 0.0079 ns |       0 B |
   ToUShortNullable | 7.025 ns | 0.0076 ns | 0.0063 ns |       0 B |
              ToInt | 3.884 ns | 0.0069 ns | 0.0065 ns |       0 B |
      ToIntNullable | 7.031 ns | 0.0114 ns | 0.0106 ns |       0 B |
             ToUInt | 3.978 ns | 0.0059 ns | 0.0055 ns |       0 B |
     ToUIntNullable | 7.023 ns | 0.0019 ns | 0.0016 ns |       0 B |
             ToLong | 3.904 ns | 0.0006 ns | 0.0005 ns |       0 B |
     ToLongNullable | 6.644 ns | 0.0079 ns | 0.0070 ns |       0 B |
            ToULong | 3.985 ns | 0.0054 ns | 0.0051 ns |       0 B |
    ToULongNullable | 6.641 ns | 0.0075 ns | 0.0067 ns |       0 B |
            ToFloat | 3.935 ns | 0.0037 ns | 0.0033 ns |       0 B |
    ToFloatNullable | 7.023 ns | 0.0007 ns | 0.0006 ns |       0 B |
           ToDouble | 4.045 ns | 0.0063 ns | 0.0059 ns |       0 B |
   ToDoubleNullable | 6.910 ns | 0.0026 ns | 0.0020 ns |       0 B |
          ToDecimal | 6.398 ns | 0.0090 ns | 0.0084 ns |       0 B |
  ToDecimalNullable | 6.388 ns | 0.0041 ns | 0.0035 ns |       0 B |
         ToDateTime | 5.115 ns | 0.0070 ns | 0.0066 ns |       0 B |
 ToDateTimeNullable | 6.655 ns | 0.0047 ns | 0.0042 ns |       0 B |
           ToObject | 1.788 ns | 0.0004 ns | 0.0003 ns |       0 B |
          To_String | 1.277 ns | 0.0005 ns | 0.0004 ns |       0 B |
             ToEnum | 3.888 ns | 0.0006 ns | 0.0005 ns |       0 B |
