
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.670 ns | 0.3847 ns | 0.0211 ns |  1.679 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.458 ns | 0.0735 ns | 0.0040 ns |  1.459 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  4.392 ns | 0.7220 ns | 0.0396 ns |  4.384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  4.151 ns | 2.1288 ns | 0.1167 ns |  4.098 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  2.747 ns | 0.1536 ns | 0.0084 ns |  2.745 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  2.913 ns | 0.2895 ns | 0.0159 ns |  2.917 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.637 ns | 0.3269 ns | 0.0179 ns |  4.634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  4.693 ns | 0.4579 ns | 0.0251 ns |  4.698 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  1.531 ns | 1.5270 ns | 0.0837 ns |  1.524 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  1.841 ns | 5.7617 ns | 0.3158 ns |  1.683 ns |  1.21 |    0.27 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.257 ns | 0.0821 ns | 0.0045 ns |  4.259 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  4.249 ns | 0.4073 ns | 0.0223 ns |  4.236 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  2.812 ns | 0.6616 ns | 0.0363 ns |  2.804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  2.844 ns | 0.3383 ns | 0.0185 ns |  2.847 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.783 ns | 0.9307 ns | 0.0510 ns |  4.804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  4.849 ns | 5.8334 ns | 0.3198 ns |  4.678 ns |  1.01 |    0.08 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  2.810 ns | 0.1930 ns | 0.0106 ns |  2.804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  2.637 ns | 0.3078 ns | 0.0169 ns |  2.645 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.730 ns | 0.9565 ns | 0.0524 ns |  4.716 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  4.714 ns | 0.2425 ns | 0.0133 ns |  4.711 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  2.910 ns | 0.4907 ns | 0.0269 ns |  2.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  2.402 ns | 1.0011 ns | 0.0549 ns |  2.404 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.613 ns | 0.1971 ns | 0.0108 ns |  4.612 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  4.874 ns | 2.4922 ns | 0.1366 ns |  4.859 ns |  1.06 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  3.070 ns | 6.2563 ns | 0.3429 ns |  3.178 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  2.379 ns | 0.4496 ns | 0.0246 ns |  2.368 ns |  0.78 |    0.09 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  4.657 ns | 0.4246 ns | 0.0233 ns |  4.645 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  4.633 ns | 0.2187 ns | 0.0120 ns |  4.628 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.631 ns | 0.6788 ns | 0.0372 ns |  1.626 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.628 ns | 0.3334 ns | 0.0183 ns |  1.626 ns |  1.00 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  4.271 ns | 0.1675 ns | 0.0092 ns |  4.269 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  4.043 ns | 0.1477 ns | 0.0081 ns |  4.045 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.674 ns | 0.2188 ns | 0.0120 ns |  1.675 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.291 ns | 0.3243 ns | 0.0178 ns |  1.293 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  2.273 ns | 0.3101 ns | 0.0170 ns |  2.275 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  2.158 ns | 0.1558 ns | 0.0085 ns |  2.159 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.623 ns | 0.5488 ns | 0.0301 ns |  1.629 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.148 ns | 0.5916 ns | 0.0324 ns |  1.153 ns |  0.71 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  1.725 ns | 0.0453 ns | 0.0025 ns |  1.724 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.669 ns | 0.0925 ns | 0.0051 ns |  1.670 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.964 ns | 0.1756 ns | 0.0096 ns |  1.959 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.799 ns | 0.4164 ns | 0.0228 ns |  1.807 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.686 ns | 0.6106 ns | 0.0335 ns |  4.671 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.724 ns | 0.4366 ns | 0.0239 ns |  4.723 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.961 ns | 0.3328 ns | 0.0182 ns |  1.953 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.780 ns | 0.1195 ns | 0.0066 ns |  1.778 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  2.388 ns | 0.4883 ns | 0.0268 ns |  2.375 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  2.663 ns | 1.4254 ns | 0.0781 ns |  2.634 ns |  1.12 |    0.04 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  6.452 ns | 5.0809 ns | 0.2785 ns |  6.302 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  2.122 ns | 0.2221 ns | 0.0122 ns |  2.123 ns |  0.33 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 12.682 ns | 0.8841 ns | 0.0485 ns | 12.700 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  8.361 ns | 2.9137 ns | 0.1597 ns |  8.286 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.400 ns | 0.4149 ns | 0.0227 ns |  2.404 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.253 ns | 1.7385 ns | 0.0953 ns |  2.203 ns |  0.94 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.053 ns | 0.4079 ns | 0.0224 ns |  2.051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.591 ns | 0.2871 ns | 0.0157 ns |  1.587 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  4.653 ns | 0.8589 ns | 0.0471 ns |  4.657 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  4.318 ns | 5.1536 ns | 0.2825 ns |  4.225 ns |  0.93 |    0.05 | 0.0038 |     - |     - |      24 B |
                    |               |           |           |           |           |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 13.233 ns | 1.6459 ns | 0.0902 ns | 13.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  4.157 ns | 0.1383 ns | 0.0076 ns |  4.153 ns |  0.31 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.791 ns | 1.1660 ns | 0.0639 ns |  8.812 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  8.545 ns | 0.5377 ns | 0.0295 ns |  8.558 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 13.331 ns | 2.3706 ns | 0.1299 ns | 13.340 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 12.822 ns | 7.9507 ns | 0.4358 ns | 12.618 ns |  0.96 |    0.03 |      - |     - |     - |         - |
