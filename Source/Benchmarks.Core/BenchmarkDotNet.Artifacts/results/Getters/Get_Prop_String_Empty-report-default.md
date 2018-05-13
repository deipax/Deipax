
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev |   Median | Allocated |
------------------- |---------:|----------:|----------:|---------:|----------:|
             ToBool | 2.061 ns | 0.0256 ns | 0.0227 ns | 2.054 ns |       0 B |
     ToBoolNullable | 5.197 ns | 0.1088 ns | 0.0965 ns | 5.184 ns |       0 B |
             ToChar | 2.019 ns | 0.0098 ns | 0.0092 ns | 2.017 ns |       0 B |
     ToCharNullable | 5.268 ns | 0.0115 ns | 0.0102 ns | 5.264 ns |       0 B |
            ToSByte | 2.059 ns | 0.0072 ns | 0.0068 ns | 2.057 ns |       0 B |
    ToSByteNullable | 5.344 ns | 0.0777 ns | 0.0727 ns | 5.387 ns |       0 B |
             ToByte | 2.138 ns | 0.0756 ns | 0.1304 ns | 2.071 ns |       0 B |
     ToByteNullable | 5.276 ns | 0.0201 ns | 0.0168 ns | 5.272 ns |       0 B |
            ToShort | 2.065 ns | 0.0408 ns | 0.0341 ns | 2.058 ns |       0 B |
    ToShortNullable | 5.300 ns | 0.0046 ns | 0.0033 ns | 5.300 ns |       0 B |
           ToUShort | 2.059 ns | 0.0296 ns | 0.0277 ns | 2.049 ns |       0 B |
   ToUShortNullable | 5.254 ns | 0.0108 ns | 0.0096 ns | 5.252 ns |       0 B |
              ToInt | 2.023 ns | 0.0111 ns | 0.0098 ns | 2.021 ns |       0 B |
      ToIntNullable | 5.273 ns | 0.0251 ns | 0.0235 ns | 5.266 ns |       0 B |
             ToUInt | 2.133 ns | 0.0747 ns | 0.0889 ns | 2.093 ns |       0 B |
     ToUIntNullable | 5.294 ns | 0.0507 ns | 0.0450 ns | 5.272 ns |       0 B |
             ToLong | 2.189 ns | 0.0763 ns | 0.1489 ns | 2.146 ns |       0 B |
     ToLongNullable | 3.640 ns | 0.0726 ns | 0.0606 ns | 3.628 ns |       0 B |
            ToULong | 2.069 ns | 0.0331 ns | 0.0294 ns | 2.062 ns |       0 B |
    ToULongNullable | 3.418 ns | 0.0378 ns | 0.0295 ns | 3.409 ns |       0 B |
            ToFloat | 2.104 ns | 0.0246 ns | 0.0205 ns | 2.098 ns |       0 B |
    ToFloatNullable | 5.332 ns | 0.0909 ns | 0.0806 ns | 5.312 ns |       0 B |
           ToDouble | 2.121 ns | 0.0294 ns | 0.0230 ns | 2.118 ns |       0 B |
   ToDoubleNullable | 3.637 ns | 0.0471 ns | 0.0394 ns | 3.619 ns |       0 B |
          ToDecimal | 3.465 ns | 0.0725 ns | 0.0678 ns | 3.443 ns |       0 B |
  ToDecimalNullable | 9.728 ns | 0.1101 ns | 0.0976 ns | 9.725 ns |       0 B |
         ToDateTime | 3.452 ns | 0.0991 ns | 0.0878 ns | 3.418 ns |       0 B |
 ToDateTimeNullable | 9.449 ns | 0.0628 ns | 0.0524 ns | 9.438 ns |       0 B |
           ToObject | 3.092 ns | 0.0169 ns | 0.0141 ns | 3.088 ns |       0 B |
          To_String | 1.302 ns | 0.0237 ns | 0.0198 ns | 1.291 ns |       0 B |
             ToEnum | 2.392 ns | 0.0788 ns | 0.0938 ns | 2.356 ns |       0 B |
     ToEnumNullable | 5.020 ns | 0.0121 ns | 0.0094 ns | 5.022 ns |       0 B |
