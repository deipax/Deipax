
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev |   Median | Allocated |
------------------- |---------:|----------:|----------:|---------:|----------:|
             ToBool | 3.341 ns | 0.0473 ns | 0.0443 ns | 3.326 ns |       0 B |
     ToBoolNullable | 6.576 ns | 0.0823 ns | 0.0729 ns | 6.533 ns |       0 B |
             ToChar | 3.922 ns | 0.0091 ns | 0.0081 ns | 3.924 ns |       0 B |
     ToCharNullable | 6.846 ns | 0.0264 ns | 0.0220 ns | 6.851 ns |       0 B |
            ToSByte | 3.735 ns | 0.0156 ns | 0.0139 ns | 3.731 ns |       0 B |
    ToSByteNullable | 6.884 ns | 0.1266 ns | 0.1184 ns | 6.793 ns |       0 B |
             ToByte | 3.431 ns | 0.0132 ns | 0.0123 ns | 3.430 ns |       0 B |
     ToByteNullable | 6.578 ns | 0.0467 ns | 0.0390 ns | 6.577 ns |       0 B |
            ToShort | 1.773 ns | 0.0018 ns | 0.0016 ns | 1.772 ns |       0 B |
    ToShortNullable | 1.277 ns | 0.0016 ns | 0.0015 ns | 1.276 ns |       0 B |
           ToUShort | 3.954 ns | 0.0011 ns | 0.0010 ns | 3.954 ns |       0 B |
   ToUShortNullable | 6.815 ns | 0.0290 ns | 0.0257 ns | 6.830 ns |       0 B |
              ToInt | 3.319 ns | 0.0071 ns | 0.0063 ns | 3.321 ns |       0 B |
      ToIntNullable | 6.605 ns | 0.1176 ns | 0.1043 ns | 6.548 ns |       0 B |
             ToUInt | 4.203 ns | 0.0037 ns | 0.0035 ns | 4.204 ns |       0 B |
     ToUIntNullable | 6.804 ns | 0.0235 ns | 0.0220 ns | 6.795 ns |       0 B |
             ToLong | 3.344 ns | 0.0245 ns | 0.0191 ns | 3.336 ns |       0 B |
     ToLongNullable | 6.253 ns | 0.1618 ns | 0.1351 ns | 6.194 ns |       0 B |
            ToULong | 4.162 ns | 0.0553 ns | 0.0461 ns | 4.148 ns |       0 B |
    ToULongNullable | 6.247 ns | 0.0750 ns | 0.0701 ns | 6.247 ns |       0 B |
            ToFloat | 3.338 ns | 0.0104 ns | 0.0087 ns | 3.335 ns |       0 B |
    ToFloatNullable | 6.549 ns | 0.0114 ns | 0.0101 ns | 6.548 ns |       0 B |
           ToDouble | 3.922 ns | 0.0810 ns | 0.0718 ns | 3.889 ns |       0 B |
   ToDoubleNullable | 6.169 ns | 0.0207 ns | 0.0194 ns | 6.158 ns |       0 B |
          ToDecimal | 6.197 ns | 0.0663 ns | 0.0588 ns | 6.207 ns |       0 B |
  ToDecimalNullable | 5.933 ns | 0.0165 ns | 0.0146 ns | 5.936 ns |       0 B |
         ToDateTime | 4.368 ns | 0.0150 ns | 0.0126 ns | 4.363 ns |       0 B |
 ToDateTimeNullable | 6.159 ns | 0.0134 ns | 0.0126 ns | 6.159 ns |       0 B |
           ToObject | 2.070 ns | 0.0228 ns | 0.0214 ns | 2.062 ns |       0 B |
          To_String | 3.985 ns | 0.0039 ns | 0.0036 ns | 3.985 ns |       0 B |
             ToEnum | 4.150 ns | 0.0249 ns | 0.0233 ns | 4.150 ns |       0 B |
