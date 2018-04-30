
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Allocated |
------------------- |----------:|----------:|----------:|----------:|
             ToBool |  3.280 ns | 0.0054 ns | 0.0051 ns |       0 B |
     ToBoolNullable |  6.904 ns | 0.0018 ns | 0.0014 ns |       0 B |
             ToChar |  3.924 ns | 0.0081 ns | 0.0075 ns |       0 B |
     ToCharNullable |  6.770 ns | 0.0049 ns | 0.0044 ns |       0 B |
            ToSByte |  3.870 ns | 0.0014 ns | 0.0012 ns |       0 B |
    ToSByteNullable | 10.087 ns | 0.0045 ns | 0.0042 ns |       0 B |
             ToByte |  4.082 ns | 0.0018 ns | 0.0017 ns |       0 B |
     ToByteNullable |  6.772 ns | 0.0052 ns | 0.0049 ns |       0 B |
            ToShort |  3.295 ns | 0.0068 ns | 0.0064 ns |       0 B |
    ToShortNullable |  6.763 ns | 0.0099 ns | 0.0088 ns |       0 B |
           ToUShort |  3.890 ns | 0.0052 ns | 0.0046 ns |       0 B |
   ToUShortNullable |  6.769 ns | 0.0040 ns | 0.0033 ns |       0 B |
              ToInt |  3.872 ns | 0.0046 ns | 0.0043 ns |       0 B |
      ToIntNullable |  6.774 ns | 0.0091 ns | 0.0085 ns |       0 B |
             ToUInt |  1.792 ns | 0.0039 ns | 0.0035 ns |       0 B |
     ToUIntNullable |  1.533 ns | 0.0013 ns | 0.0012 ns |       0 B |
             ToLong |  3.425 ns | 0.0304 ns | 0.0285 ns |       0 B |
     ToLongNullable |  6.506 ns | 0.0541 ns | 0.0506 ns |       0 B |
            ToULong |  3.395 ns | 0.0078 ns | 0.0073 ns |       0 B |
    ToULongNullable |  6.424 ns | 0.0124 ns | 0.0116 ns |       0 B |
            ToFloat |  3.505 ns | 0.0011 ns | 0.0007 ns |       0 B |
    ToFloatNullable |  6.516 ns | 0.0041 ns | 0.0035 ns |       0 B |
           ToDouble |  3.580 ns | 0.0035 ns | 0.0031 ns |       0 B |
   ToDoubleNullable |  6.679 ns | 0.0074 ns | 0.0061 ns |       0 B |
          ToDecimal |  6.393 ns | 0.0112 ns | 0.0105 ns |       0 B |
  ToDecimalNullable |  6.426 ns | 0.0049 ns | 0.0038 ns |       0 B |
         ToDateTime |  4.600 ns | 0.0067 ns | 0.0063 ns |       0 B |
 ToDateTimeNullable |  6.406 ns | 0.0043 ns | 0.0038 ns |       0 B |
           ToObject |  2.048 ns | 0.0033 ns | 0.0031 ns |       0 B |
          To_String |  3.900 ns | 0.0036 ns | 0.0032 ns |       0 B |
             ToEnum |  4.128 ns | 0.0018 ns | 0.0016 ns |       0 B |
