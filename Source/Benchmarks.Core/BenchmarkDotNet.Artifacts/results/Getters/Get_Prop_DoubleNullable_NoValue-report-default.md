
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev |   Median | Allocated |
------------------- |---------:|----------:|----------:|---------:|----------:|
             ToBool | 1.774 ns | 0.0024 ns | 0.0020 ns | 1.773 ns |       0 B |
     ToBoolNullable | 4.457 ns | 0.0174 ns | 0.0163 ns | 4.456 ns |       0 B |
             ToChar | 1.261 ns | 0.0006 ns | 0.0006 ns | 1.261 ns |       0 B |
     ToCharNullable | 4.492 ns | 0.0037 ns | 0.0035 ns | 4.492 ns |       0 B |
            ToSByte | 1.771 ns | 0.0063 ns | 0.0056 ns | 1.773 ns |       0 B |
    ToSByteNullable | 4.996 ns | 0.0007 ns | 0.0005 ns | 4.996 ns |       0 B |
             ToByte | 1.775 ns | 0.0044 ns | 0.0041 ns | 1.774 ns |       0 B |
     ToByteNullable | 4.996 ns | 0.0008 ns | 0.0006 ns | 4.996 ns |       0 B |
            ToShort | 1.771 ns | 0.0016 ns | 0.0013 ns | 1.771 ns |       0 B |
    ToShortNullable | 4.996 ns | 0.0005 ns | 0.0005 ns | 4.996 ns |       0 B |
           ToUShort | 1.812 ns | 0.0514 ns | 0.0481 ns | 1.782 ns |       0 B |
   ToUShortNullable | 4.998 ns | 0.0035 ns | 0.0033 ns | 4.997 ns |       0 B |
              ToInt | 1.771 ns | 0.0039 ns | 0.0034 ns | 1.769 ns |       0 B |
      ToIntNullable | 5.000 ns | 0.0047 ns | 0.0043 ns | 4.997 ns |       0 B |
             ToUInt | 1.790 ns | 0.0024 ns | 0.0020 ns | 1.789 ns |       0 B |
     ToUIntNullable | 5.003 ns | 0.0021 ns | 0.0020 ns | 5.002 ns |       0 B |
             ToLong | 1.791 ns | 0.0032 ns | 0.0030 ns | 1.789 ns |       0 B |
     ToLongNullable | 3.593 ns | 0.0069 ns | 0.0065 ns | 3.590 ns |       0 B |
            ToULong | 1.870 ns | 0.0694 ns | 0.1251 ns | 1.793 ns |       0 B |
    ToULongNullable | 3.321 ns | 0.0009 ns | 0.0007 ns | 3.321 ns |       0 B |
            ToFloat | 1.796 ns | 0.0028 ns | 0.0027 ns | 1.796 ns |       0 B |
    ToFloatNullable | 4.740 ns | 0.0003 ns | 0.0002 ns | 4.740 ns |       0 B |
           ToDouble | 2.046 ns | 0.0015 ns | 0.0013 ns | 2.046 ns |       0 B |
   ToDoubleNullable | 2.301 ns | 0.0033 ns | 0.0030 ns | 2.301 ns |       0 B |
          ToDecimal | 3.597 ns | 0.0038 ns | 0.0034 ns | 3.596 ns |       0 B |
  ToDecimalNullable | 9.554 ns | 0.0024 ns | 0.0022 ns | 9.553 ns |       0 B |
         ToDateTime | 2.816 ns | 0.0028 ns | 0.0026 ns | 2.815 ns |       0 B |
 ToDateTimeNullable | 8.814 ns | 0.0014 ns | 0.0011 ns | 8.814 ns |       0 B |
           ToObject | 1.793 ns | 0.0020 ns | 0.0019 ns | 1.793 ns |       0 B |
          To_String | 2.043 ns | 0.0018 ns | 0.0016 ns | 2.043 ns |       0 B |
             ToEnum | 2.049 ns | 0.0031 ns | 0.0029 ns | 2.049 ns |       0 B |
     ToEnumNullable | 4.782 ns | 0.0031 ns | 0.0029 ns | 4.781 ns |       0 B |
