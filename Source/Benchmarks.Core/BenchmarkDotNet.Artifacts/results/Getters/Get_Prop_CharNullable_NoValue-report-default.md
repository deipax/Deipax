
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.620 ns | 0.0225 ns | 0.0188 ns |       0 B |
     ToBoolNullable | 6.826 ns | 0.1269 ns | 0.1125 ns |       0 B |
             ToChar | 2.326 ns | 0.0101 ns | 0.0095 ns |       0 B |
     ToCharNullable | 1.794 ns | 0.0059 ns | 0.0053 ns |       0 B |
            ToSByte | 4.462 ns | 0.0011 ns | 0.0010 ns |       0 B |
    ToSByteNullable | 7.271 ns | 0.0148 ns | 0.0123 ns |       0 B |
             ToByte | 4.401 ns | 0.0057 ns | 0.0053 ns |       0 B |
     ToByteNullable | 7.263 ns | 0.0009 ns | 0.0008 ns |       0 B |
            ToShort | 4.349 ns | 0.0006 ns | 0.0005 ns |       0 B |
    ToShortNullable | 7.264 ns | 0.0017 ns | 0.0014 ns |       0 B |
           ToUShort | 4.103 ns | 0.0008 ns | 0.0006 ns |       0 B |
   ToUShortNullable | 6.768 ns | 0.0009 ns | 0.0008 ns |       0 B |
              ToInt | 4.103 ns | 0.0019 ns | 0.0014 ns |       0 B |
      ToIntNullable | 6.769 ns | 0.0004 ns | 0.0003 ns |       0 B |
             ToUInt | 4.089 ns | 0.0011 ns | 0.0009 ns |       0 B |
     ToUIntNullable | 6.769 ns | 0.0010 ns | 0.0009 ns |       0 B |
             ToLong | 4.093 ns | 0.0080 ns | 0.0075 ns |       0 B |
     ToLongNullable | 6.388 ns | 0.0011 ns | 0.0009 ns |       0 B |
            ToULong | 4.088 ns | 0.0021 ns | 0.0017 ns |       0 B |
    ToULongNullable | 6.642 ns | 0.0015 ns | 0.0013 ns |       0 B |
            ToFloat | 3.837 ns | 0.0061 ns | 0.0057 ns |       0 B |
    ToFloatNullable | 6.772 ns | 0.0058 ns | 0.0054 ns |       0 B |
           ToDouble | 3.848 ns | 0.0045 ns | 0.0032 ns |       0 B |
   ToDoubleNullable | 6.135 ns | 0.0075 ns | 0.0071 ns |       0 B |
          ToDecimal | 7.158 ns | 0.0042 ns | 0.0035 ns |       0 B |
  ToDecimalNullable | 6.387 ns | 0.0033 ns | 0.0030 ns |       0 B |
         ToDateTime | 5.373 ns | 0.0102 ns | 0.0090 ns |       0 B |
 ToDateTimeNullable | 6.647 ns | 0.0088 ns | 0.0078 ns |       0 B |
           ToObject | 2.810 ns | 0.0021 ns | 0.0020 ns |       0 B |
          To_String | 4.642 ns | 0.0058 ns | 0.0054 ns |       0 B |
             ToEnum | 4.617 ns | 0.0068 ns | 0.0064 ns |       0 B |
