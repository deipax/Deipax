
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 4.572 ns | 0.0085 ns | 0.0075 ns |       0 B |
     ToBoolNullable | 7.038 ns | 0.0140 ns | 0.0131 ns |       0 B |
             ToChar | 4.615 ns | 0.0084 ns | 0.0079 ns |       0 B |
     ToCharNullable | 7.050 ns | 0.0184 ns | 0.0173 ns |       0 B |
            ToSByte | 4.866 ns | 0.0163 ns | 0.0153 ns |       0 B |
    ToSByteNullable | 7.311 ns | 0.0105 ns | 0.0093 ns |       0 B |
             ToByte | 4.801 ns | 0.0124 ns | 0.0116 ns |       0 B |
     ToByteNullable | 7.321 ns | 0.0151 ns | 0.0126 ns |       0 B |
            ToShort | 4.871 ns | 0.0886 ns | 0.0828 ns |       0 B |
    ToShortNullable | 7.326 ns | 0.0159 ns | 0.0148 ns |       0 B |
           ToUShort | 4.847 ns | 0.0084 ns | 0.0078 ns |       0 B |
   ToUShortNullable | 7.325 ns | 0.0169 ns | 0.0158 ns |       0 B |
              ToInt | 4.862 ns | 0.0104 ns | 0.0098 ns |       0 B |
      ToIntNullable | 7.321 ns | 0.0174 ns | 0.0163 ns |       0 B |
             ToUInt | 5.202 ns | 0.0139 ns | 0.0130 ns |       0 B |
     ToUIntNullable | 7.321 ns | 0.0197 ns | 0.0184 ns |       0 B |
             ToLong | 4.821 ns | 0.0164 ns | 0.0153 ns |       0 B |
     ToLongNullable | 7.187 ns | 0.0260 ns | 0.0243 ns |       0 B |
            ToULong | 4.899 ns | 0.0235 ns | 0.0219 ns |       0 B |
    ToULongNullable | 7.181 ns | 0.0216 ns | 0.0202 ns |       0 B |
            ToFloat | 4.858 ns | 0.0162 ns | 0.0152 ns |       0 B |
    ToFloatNullable | 7.325 ns | 0.0234 ns | 0.0219 ns |       0 B |
           ToDouble | 4.871 ns | 0.0136 ns | 0.0127 ns |       0 B |
   ToDoubleNullable | 7.198 ns | 0.0292 ns | 0.0273 ns |       0 B |
          ToDecimal | 6.327 ns | 0.0340 ns | 0.0318 ns |       0 B |
  ToDecimalNullable | 6.976 ns | 0.0603 ns | 0.0564 ns |       0 B |
         ToDateTime | 5.485 ns | 0.0136 ns | 0.0120 ns |       0 B |
 ToDateTimeNullable | 6.961 ns | 0.0344 ns | 0.0322 ns |       0 B |
           ToObject | 3.595 ns | 0.0071 ns | 0.0055 ns |       0 B |
          To_String | 1.802 ns | 0.0118 ns | 0.0105 ns |       0 B |
             ToEnum | 5.239 ns | 0.0129 ns | 0.0114 ns |       0 B |
