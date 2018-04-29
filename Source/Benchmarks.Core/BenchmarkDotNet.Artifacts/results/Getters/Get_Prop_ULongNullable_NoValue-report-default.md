
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 4.837 ns | 0.0163 ns | 0.0153 ns |       0 B |
     ToBoolNullable | 6.798 ns | 0.0096 ns | 0.0090 ns |       0 B |
             ToChar | 4.672 ns | 0.0121 ns | 0.0113 ns |       0 B |
     ToCharNullable | 6.802 ns | 0.0134 ns | 0.0125 ns |       0 B |
            ToSByte | 4.994 ns | 0.0148 ns | 0.0139 ns |       0 B |
    ToSByteNullable | 7.297 ns | 0.0123 ns | 0.0115 ns |       0 B |
             ToByte | 4.609 ns | 0.0130 ns | 0.0122 ns |       0 B |
     ToByteNullable | 6.825 ns | 0.0230 ns | 0.0215 ns |       0 B |
            ToShort | 4.880 ns | 0.0619 ns | 0.0548 ns |       0 B |
    ToShortNullable | 6.807 ns | 0.0215 ns | 0.0201 ns |       0 B |
           ToUShort | 4.632 ns | 0.0175 ns | 0.0155 ns |       0 B |
   ToUShortNullable | 6.786 ns | 0.0119 ns | 0.0106 ns |       0 B |
              ToInt | 4.626 ns | 0.0076 ns | 0.0071 ns |       0 B |
      ToIntNullable | 6.804 ns | 0.0161 ns | 0.0151 ns |       0 B |
             ToUInt | 5.108 ns | 0.0081 ns | 0.0076 ns |       0 B |
     ToUIntNullable | 7.038 ns | 0.0150 ns | 0.0140 ns |       0 B |
             ToLong | 5.048 ns | 0.0116 ns | 0.0108 ns |       0 B |
     ToLongNullable | 6.930 ns | 0.0232 ns | 0.0217 ns |       0 B |
            ToULong | 2.312 ns | 0.0082 ns | 0.0077 ns |       0 B |
    ToULongNullable | 3.070 ns | 0.0081 ns | 0.0076 ns |       0 B |
            ToFloat | 4.783 ns | 0.0184 ns | 0.0172 ns |       0 B |
    ToFloatNullable | 6.799 ns | 0.0127 ns | 0.0113 ns |       0 B |
           ToDouble | 4.777 ns | 0.0127 ns | 0.0113 ns |       0 B |
   ToDoubleNullable | 6.152 ns | 0.0150 ns | 0.0140 ns |       0 B |
          ToDecimal | 7.178 ns | 0.0187 ns | 0.0175 ns |       0 B |
  ToDecimalNullable | 6.169 ns | 0.0244 ns | 0.0228 ns |       0 B |
         ToDateTime | 8.426 ns | 0.0111 ns | 0.0104 ns |       0 B |
 ToDateTimeNullable | 7.121 ns | 0.0113 ns | 0.0106 ns |       0 B |
           ToObject | 2.814 ns | 0.0048 ns | 0.0045 ns |       0 B |
          To_String | 5.288 ns | 0.0217 ns | 0.0170 ns |       0 B |
             ToEnum | 5.265 ns | 0.0131 ns | 0.0122 ns |       0 B |
