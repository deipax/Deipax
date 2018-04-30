
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Allocated |
------------------- |----------:|----------:|----------:|----------:|
             ToBool |  4.226 ns | 0.0019 ns | 0.0015 ns |       0 B |
     ToBoolNullable |  7.025 ns | 0.0051 ns | 0.0045 ns |       0 B |
             ToChar |  3.781 ns | 0.0069 ns | 0.0061 ns |       0 B |
     ToCharNullable |  6.987 ns | 0.0035 ns | 0.0029 ns |       0 B |
            ToSByte |  4.556 ns | 0.0131 ns | 0.0116 ns |       0 B |
    ToSByteNullable |  6.796 ns | 0.0421 ns | 0.0373 ns |       0 B |
             ToByte |  4.398 ns | 0.0160 ns | 0.0134 ns |       0 B |
     ToByteNullable |  6.771 ns | 0.0142 ns | 0.0126 ns |       0 B |
            ToShort |  4.309 ns | 0.0071 ns | 0.0066 ns |       0 B |
    ToShortNullable |  6.776 ns | 0.0094 ns | 0.0084 ns |       0 B |
           ToUShort |  4.244 ns | 0.0170 ns | 0.0159 ns |       0 B |
   ToUShortNullable |  6.866 ns | 0.0007 ns | 0.0005 ns |       0 B |
              ToInt |  4.244 ns | 0.0061 ns | 0.0048 ns |       0 B |
      ToIntNullable |  7.032 ns | 0.0093 ns | 0.0087 ns |       0 B |
             ToUInt |  4.372 ns | 0.0019 ns | 0.0016 ns |       0 B |
     ToUIntNullable |  6.516 ns | 0.0010 ns | 0.0008 ns |       0 B |
             ToLong |  4.571 ns | 0.0189 ns | 0.0177 ns |       0 B |
     ToLongNullable |  6.393 ns | 0.0051 ns | 0.0045 ns |       0 B |
            ToULong |  4.215 ns | 0.0235 ns | 0.0208 ns |       0 B |
    ToULongNullable |  6.392 ns | 0.0036 ns | 0.0030 ns |       0 B |
            ToFloat |  4.308 ns | 0.0160 ns | 0.0133 ns |       0 B |
    ToFloatNullable |  6.775 ns | 0.0079 ns | 0.0074 ns |       0 B |
           ToDouble | 11.132 ns | 0.0329 ns | 0.0308 ns |       0 B |
   ToDoubleNullable |  6.910 ns | 0.0137 ns | 0.0128 ns |       0 B |
          ToDecimal |  3.334 ns | 0.0133 ns | 0.0118 ns |       0 B |
  ToDecimalNullable |  2.558 ns | 0.0045 ns | 0.0040 ns |       0 B |
         ToDateTime |  5.170 ns | 0.0112 ns | 0.0104 ns |       0 B |
 ToDateTimeNullable | 10.330 ns | 0.0012 ns | 0.0009 ns |       0 B |
           ToObject |  2.298 ns | 0.0005 ns | 0.0004 ns |       0 B |
          To_String |  4.683 ns | 0.0048 ns | 0.0045 ns |       0 B |
             ToEnum |  4.669 ns | 0.0013 ns | 0.0009 ns |       0 B |
