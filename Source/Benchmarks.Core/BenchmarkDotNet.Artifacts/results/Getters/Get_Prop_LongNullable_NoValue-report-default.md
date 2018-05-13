
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 1.807 ns | 0.0032 ns | 0.0028 ns |       0 B |
     ToBoolNullable | 4.474 ns | 0.0006 ns | 0.0005 ns |       0 B |
             ToChar | 1.807 ns | 0.0037 ns | 0.0031 ns |       0 B |
     ToCharNullable | 4.982 ns | 0.0029 ns | 0.0024 ns |       0 B |
            ToSByte | 1.805 ns | 0.0015 ns | 0.0012 ns |       0 B |
    ToSByteNullable | 4.983 ns | 0.0038 ns | 0.0034 ns |       0 B |
             ToByte | 1.807 ns | 0.0024 ns | 0.0021 ns |       0 B |
     ToByteNullable | 5.000 ns | 0.0050 ns | 0.0046 ns |       0 B |
            ToShort | 1.805 ns | 0.0035 ns | 0.0027 ns |       0 B |
    ToShortNullable | 4.982 ns | 0.0026 ns | 0.0022 ns |       0 B |
           ToUShort | 1.807 ns | 0.0036 ns | 0.0032 ns |       0 B |
   ToUShortNullable | 4.984 ns | 0.0056 ns | 0.0050 ns |       0 B |
              ToInt | 1.804 ns | 0.0016 ns | 0.0013 ns |       0 B |
      ToIntNullable | 4.980 ns | 0.0027 ns | 0.0022 ns |       0 B |
             ToUInt | 1.794 ns | 0.0065 ns | 0.0061 ns |       0 B |
     ToUIntNullable | 4.982 ns | 0.0030 ns | 0.0027 ns |       0 B |
             ToLong | 2.299 ns | 0.0003 ns | 0.0002 ns |       0 B |
     ToLongNullable | 2.561 ns | 0.0103 ns | 0.0086 ns |       0 B |
            ToULong | 2.300 ns | 0.0011 ns | 0.0010 ns |       0 B |
    ToULongNullable | 3.592 ns | 0.0132 ns | 0.0124 ns |       0 B |
            ToFloat | 2.047 ns | 0.0045 ns | 0.0042 ns |       0 B |
    ToFloatNullable | 4.470 ns | 0.0013 ns | 0.0011 ns |       0 B |
           ToDouble | 2.044 ns | 0.0005 ns | 0.0004 ns |       0 B |
   ToDoubleNullable | 3.579 ns | 0.0050 ns | 0.0046 ns |       0 B |
          ToDecimal | 3.581 ns | 0.0063 ns | 0.0059 ns |       0 B |
  ToDecimalNullable | 9.200 ns | 0.0066 ns | 0.0058 ns |       0 B |
         ToDateTime | 3.066 ns | 0.0028 ns | 0.0026 ns |       0 B |
 ToDateTimeNullable | 8.304 ns | 0.0013 ns | 0.0010 ns |       0 B |
           ToObject | 1.791 ns | 0.0038 ns | 0.0034 ns |       0 B |
          To_String | 2.045 ns | 0.0019 ns | 0.0018 ns |       0 B |
             ToEnum | 2.047 ns | 0.0030 ns | 0.0027 ns |       0 B |
     ToEnumNullable | 5.007 ns | 0.0045 ns | 0.0040 ns |       0 B |
