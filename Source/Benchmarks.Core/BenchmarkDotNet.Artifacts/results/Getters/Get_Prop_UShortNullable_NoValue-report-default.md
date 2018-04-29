
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.819 ns | 0.0008 ns | 0.0006 ns |       0 B |
     ToBoolNullable | 6.759 ns | 0.0064 ns | 0.0060 ns |       0 B |
             ToChar | 4.006 ns | 0.0080 ns | 0.0075 ns |       0 B |
     ToCharNullable | 6.784 ns | 0.0127 ns | 0.0112 ns |       0 B |
            ToSByte | 5.016 ns | 0.0012 ns | 0.0010 ns |       0 B |
    ToSByteNullable | 7.269 ns | 0.0050 ns | 0.0045 ns |       0 B |
             ToByte | 4.406 ns | 0.0068 ns | 0.0064 ns |       0 B |
     ToByteNullable | 7.296 ns | 0.0172 ns | 0.0153 ns |       0 B |
            ToShort | 4.517 ns | 0.0113 ns | 0.0094 ns |       0 B |
    ToShortNullable | 7.265 ns | 0.0023 ns | 0.0018 ns |       0 B |
           ToUShort | 2.324 ns | 0.0077 ns | 0.0068 ns |       0 B |
   ToUShortNullable | 1.791 ns | 0.0046 ns | 0.0043 ns |       0 B |
              ToInt | 4.108 ns | 0.0080 ns | 0.0075 ns |       0 B |
      ToIntNullable | 6.775 ns | 0.0074 ns | 0.0070 ns |       0 B |
             ToUInt | 4.089 ns | 0.0016 ns | 0.0015 ns |       0 B |
     ToUIntNullable | 6.776 ns | 0.0141 ns | 0.0131 ns |       0 B |
             ToLong | 4.088 ns | 0.0014 ns | 0.0011 ns |       0 B |
     ToLongNullable | 6.387 ns | 0.0020 ns | 0.0016 ns |       0 B |
            ToULong | 4.094 ns | 0.0016 ns | 0.0014 ns |       0 B |
    ToULongNullable | 6.657 ns | 0.0208 ns | 0.0174 ns |       0 B |
            ToFloat | 4.088 ns | 0.0022 ns | 0.0017 ns |       0 B |
    ToFloatNullable | 6.774 ns | 0.0062 ns | 0.0058 ns |       0 B |
           ToDouble | 4.091 ns | 0.0037 ns | 0.0035 ns |       0 B |
   ToDoubleNullable | 6.652 ns | 0.0156 ns | 0.0146 ns |       0 B |
          ToDecimal | 7.153 ns | 0.0013 ns | 0.0011 ns |       0 B |
  ToDecimalNullable | 6.402 ns | 0.0063 ns | 0.0059 ns |       0 B |
         ToDateTime | 5.366 ns | 0.0043 ns | 0.0040 ns |       0 B |
 ToDateTimeNullable | 6.670 ns | 0.0095 ns | 0.0089 ns |       0 B |
           ToObject | 2.809 ns | 0.0006 ns | 0.0005 ns |       0 B |
          To_String | 4.687 ns | 0.0049 ns | 0.0046 ns |       0 B |
             ToEnum | 4.606 ns | 0.0006 ns | 0.0005 ns |       0 B |
