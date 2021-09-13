
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |---------:|----------:|----------:|---------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.610 ns | 0.0643 ns | 0.0035 ns | 1.611 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.507 ns | 0.6151 ns | 0.0337 ns | 1.517 ns |  0.94 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 4.007 ns | 0.4079 ns | 0.0224 ns | 4.019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 3.745 ns | 0.4893 ns | 0.0268 ns | 3.736 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.478 ns | 0.2504 ns | 0.0137 ns | 1.472 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.569 ns | 1.1611 ns | 0.0636 ns | 1.541 ns |  1.06 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 4.004 ns | 0.2471 ns | 0.0135 ns | 4.002 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 3.772 ns | 0.2296 ns | 0.0126 ns | 3.776 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.380 ns | 0.4944 ns | 0.0271 ns | 1.366 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.452 ns | 0.7588 ns | 0.0416 ns | 1.437 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 3.985 ns | 0.6116 ns | 0.0335 ns | 4.004 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 4.171 ns | 0.1139 ns | 0.0062 ns | 4.169 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.381 ns | 1.5606 ns | 0.0855 ns | 1.386 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.307 ns | 0.7439 ns | 0.0408 ns | 1.295 ns |  0.95 |    0.07 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 4.019 ns | 0.2945 ns | 0.0161 ns | 4.022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 3.725 ns | 1.3400 ns | 0.0734 ns | 3.683 ns |  0.93 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.604 ns | 1.1467 ns | 0.0629 ns | 1.594 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.402 ns | 0.8856 ns | 0.0485 ns | 1.383 ns |  0.87 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 4.083 ns | 2.0909 ns | 0.1146 ns | 4.068 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 3.791 ns | 0.3165 ns | 0.0173 ns | 3.785 ns |  0.93 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.304 ns | 0.3035 ns | 0.0166 ns | 1.302 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.500 ns | 0.5252 ns | 0.0288 ns | 1.492 ns |  1.15 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 3.823 ns | 0.7229 ns | 0.0396 ns | 3.814 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 3.758 ns | 0.2323 ns | 0.0127 ns | 3.766 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.774 ns | 0.3483 ns | 0.0191 ns | 1.765 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.363 ns | 0.5946 ns | 0.0326 ns | 1.345 ns |  0.77 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 3.949 ns | 0.1364 ns | 0.0075 ns | 3.945 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 3.786 ns | 0.2561 ns | 0.0140 ns | 3.790 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.267 ns | 0.1559 ns | 0.0085 ns | 1.264 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.440 ns | 0.2563 ns | 0.0140 ns | 1.447 ns |  1.14 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 4.176 ns | 3.1189 ns | 0.1710 ns | 4.220 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 3.785 ns | 0.1233 ns | 0.0068 ns | 3.782 ns |  0.91 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.369 ns | 0.5508 ns | 0.0302 ns | 1.353 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.512 ns | 0.9815 ns | 0.0538 ns | 1.513 ns |  1.10 |    0.06 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 1.913 ns | 0.0597 ns | 0.0033 ns | 1.911 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 2.120 ns | 1.8303 ns | 0.1003 ns | 2.100 ns |  1.11 |    0.05 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.365 ns | 0.3637 ns | 0.0199 ns | 1.354 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.366 ns | 0.8771 ns | 0.0481 ns | 1.341 ns |  1.00 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 2.170 ns | 0.0094 ns | 0.0005 ns | 2.170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 2.142 ns | 1.8252 ns | 0.1000 ns | 2.168 ns |  0.99 |    0.05 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.534 ns | 0.8110 ns | 0.0445 ns | 1.516 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.373 ns | 0.7612 ns | 0.0417 ns | 1.386 ns |  0.90 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.234 ns | 0.4527 ns | 0.0248 ns | 4.243 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 4.170 ns | 2.6486 ns | 0.1452 ns | 4.226 ns |  0.98 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.546 ns | 0.0259 ns | 0.0014 ns | 1.546 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.392 ns | 0.3645 ns | 0.0200 ns | 1.384 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 2.252 ns | 0.7126 ns | 0.0391 ns | 2.266 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 2.071 ns | 0.0653 ns | 0.0036 ns | 2.069 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.424 ns | 2.4773 ns | 0.1358 ns | 2.484 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 2.213 ns | 1.4023 ns | 0.0769 ns | 2.179 ns |  0.91 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 2.426 ns | 0.0579 ns | 0.0032 ns | 2.428 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.306 ns | 0.9275 ns | 0.0508 ns | 2.281 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.347 ns | 0.0273 ns | 0.0015 ns | 2.347 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.140 ns | 0.9365 ns | 0.0513 ns | 2.112 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 2.165 ns | 0.1647 ns | 0.0090 ns | 2.170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 1.537 ns | 0.0337 ns | 0.0018 ns | 1.536 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.343 ns | 0.5091 ns | 0.0279 ns | 1.339 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.372 ns | 0.6541 ns | 0.0359 ns | 1.371 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.331 ns | 0.3548 ns | 0.0194 ns | 1.324 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 1.381 ns | 0.5961 ns | 0.0327 ns | 1.373 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.513 ns | 0.5242 ns | 0.0287 ns | 1.513 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.331 ns | 0.0834 ns | 0.0046 ns | 1.330 ns |  0.88 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 1.158 ns | 0.4432 ns | 0.0243 ns | 1.163 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 1.019 ns | 0.8495 ns | 0.0466 ns | 1.028 ns |  0.88 |    0.05 |     - |     - |     - |         - |
