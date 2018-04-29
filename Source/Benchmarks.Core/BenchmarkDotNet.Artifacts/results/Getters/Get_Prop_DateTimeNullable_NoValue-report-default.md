
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 4.342 ns | 0.0129 ns | 0.0121 ns |       0 B |
     ToBoolNullable | 6.803 ns | 0.0118 ns | 0.0104 ns |       0 B |
             ToChar | 4.331 ns | 0.0080 ns | 0.0075 ns |       0 B |
     ToCharNullable | 6.894 ns | 0.0127 ns | 0.0112 ns |       0 B |
            ToSByte | 4.342 ns | 0.0066 ns | 0.0059 ns |       0 B |
    ToSByteNullable | 7.049 ns | 0.0146 ns | 0.0136 ns |       0 B |
             ToByte | 4.344 ns | 0.0086 ns | 0.0080 ns |       0 B |
     ToByteNullable | 7.049 ns | 0.0037 ns | 0.0033 ns |       0 B |
            ToShort | 4.344 ns | 0.0125 ns | 0.0111 ns |       0 B |
    ToShortNullable | 6.804 ns | 0.0169 ns | 0.0158 ns |       0 B |
           ToUShort | 4.877 ns | 0.0086 ns | 0.0076 ns |       0 B |
   ToUShortNullable | 6.899 ns | 0.0163 ns | 0.0152 ns |       0 B |
              ToInt | 4.355 ns | 0.0148 ns | 0.0138 ns |       0 B |
      ToIntNullable | 6.882 ns | 0.0346 ns | 0.0323 ns |       0 B |
             ToUInt | 4.532 ns | 0.0100 ns | 0.0088 ns |       0 B |
     ToUIntNullable | 6.805 ns | 0.0260 ns | 0.0243 ns |       0 B |
             ToLong | 4.376 ns | 0.0233 ns | 0.0206 ns |       0 B |
     ToLongNullable | 6.663 ns | 0.0323 ns | 0.0302 ns |       0 B |
            ToULong | 4.363 ns | 0.0063 ns | 0.0059 ns |       0 B |
    ToULongNullable | 6.671 ns | 0.0321 ns | 0.0301 ns |       0 B |
            ToFloat | 4.367 ns | 0.0130 ns | 0.0115 ns |       0 B |
    ToFloatNullable | 8.076 ns | 0.0210 ns | 0.0197 ns |       0 B |
           ToDouble | 4.363 ns | 0.0094 ns | 0.0084 ns |       0 B |
   ToDoubleNullable | 7.165 ns | 0.0130 ns | 0.0115 ns |       0 B |
          ToDecimal | 5.911 ns | 0.0200 ns | 0.0187 ns |       0 B |
  ToDecimalNullable | 7.167 ns | 0.0115 ns | 0.0090 ns |       0 B |
         ToDateTime | 3.596 ns | 0.0097 ns | 0.0091 ns |       0 B |
 ToDateTimeNullable | 3.322 ns | 0.0054 ns | 0.0045 ns |       0 B |
           ToObject | 2.817 ns | 0.0068 ns | 0.0064 ns |       0 B |
          To_String | 5.296 ns | 0.0166 ns | 0.0155 ns |       0 B |
             ToEnum | 5.898 ns | 0.0187 ns | 0.0175 ns |       0 B |
