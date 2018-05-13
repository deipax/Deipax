
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 1.792 ns | 0.0106 ns | 0.0089 ns |       0 B |
     ToBoolNullable | 4.515 ns | 0.0170 ns | 0.0151 ns |       0 B |
             ToChar | 1.815 ns | 0.0435 ns | 0.0407 ns |       0 B |
     ToCharNullable | 5.077 ns | 0.0785 ns | 0.0696 ns |       0 B |
            ToSByte | 1.785 ns | 0.0059 ns | 0.0046 ns |       0 B |
    ToSByteNullable | 5.091 ns | 0.1375 ns | 0.1287 ns |       0 B |
             ToByte | 1.790 ns | 0.0123 ns | 0.0109 ns |       0 B |
     ToByteNullable | 5.157 ns | 0.0513 ns | 0.0371 ns |       0 B |
            ToShort | 1.760 ns | 0.0109 ns | 0.0097 ns |       0 B |
    ToShortNullable | 5.014 ns | 0.0186 ns | 0.0165 ns |       0 B |
           ToUShort | 1.786 ns | 0.0093 ns | 0.0082 ns |       0 B |
   ToUShortNullable | 5.024 ns | 0.0233 ns | 0.0194 ns |       0 B |
              ToInt | 2.071 ns | 0.0397 ns | 0.0352 ns |       0 B |
      ToIntNullable | 4.799 ns | 0.0867 ns | 0.0811 ns |       0 B |
             ToUInt | 1.858 ns | 0.0700 ns | 0.0806 ns |       0 B |
     ToUIntNullable | 5.350 ns | 0.0735 ns | 0.0652 ns |       0 B |
             ToLong | 1.892 ns | 0.0826 ns | 0.0732 ns |       0 B |
     ToLongNullable | 3.190 ns | 0.0754 ns | 0.0706 ns |       0 B |
            ToULong | 2.049 ns | 0.0196 ns | 0.0153 ns |       0 B |
    ToULongNullable | 3.391 ns | 0.0906 ns | 0.0848 ns |       0 B |
            ToFloat | 1.843 ns | 0.0574 ns | 0.0509 ns |       0 B |
    ToFloatNullable | 4.915 ns | 0.1297 ns | 0.1150 ns |       0 B |
           ToDouble | 1.876 ns | 0.0708 ns | 0.0695 ns |       0 B |
   ToDoubleNullable | 3.177 ns | 0.0955 ns | 0.1062 ns |       0 B |
          ToDecimal | 3.152 ns | 0.0637 ns | 0.0596 ns |       0 B |
  ToDecimalNullable | 9.876 ns | 0.1693 ns | 0.1584 ns |       0 B |
         ToDateTime | 2.587 ns | 0.0259 ns | 0.0243 ns |       0 B |
 ToDateTimeNullable | 8.429 ns | 0.0410 ns | 0.0364 ns |       0 B |
           ToObject | 2.080 ns | 0.0218 ns | 0.0194 ns |       0 B |
          To_String | 2.320 ns | 0.0117 ns | 0.0091 ns |       0 B |
             ToEnum | 2.353 ns | 0.0765 ns | 0.0819 ns |       0 B |
     ToEnumNullable | 1.290 ns | 0.0085 ns | 0.0071 ns |       0 B |
