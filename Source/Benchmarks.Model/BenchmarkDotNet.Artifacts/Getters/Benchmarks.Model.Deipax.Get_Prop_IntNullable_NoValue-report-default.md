
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |---------:|----------:|----------:|---------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.222 ns | 0.1665 ns | 0.0091 ns | 1.220 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.684 ns | 0.4240 ns | 0.0232 ns | 1.691 ns |  1.38 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 4.007 ns | 0.5086 ns | 0.0279 ns | 4.019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 3.773 ns | 0.0588 ns | 0.0032 ns | 3.774 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.578 ns | 2.1239 ns | 0.1164 ns | 1.625 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.771 ns | 0.5079 ns | 0.0278 ns | 1.755 ns |  1.13 |    0.08 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 3.979 ns | 0.7056 ns | 0.0387 ns | 3.990 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 3.794 ns | 0.3685 ns | 0.0202 ns | 3.784 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.537 ns | 0.3417 ns | 0.0187 ns | 1.530 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.693 ns | 0.7023 ns | 0.0385 ns | 1.675 ns |  1.10 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 3.993 ns | 0.3181 ns | 0.0174 ns | 3.998 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 4.246 ns | 0.2474 ns | 0.0136 ns | 4.244 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.480 ns | 0.2745 ns | 0.0150 ns | 1.482 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.518 ns | 0.1250 ns | 0.0069 ns | 1.518 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 4.081 ns | 1.6999 ns | 0.0932 ns | 4.032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 3.772 ns | 0.2568 ns | 0.0141 ns | 3.777 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.552 ns | 0.1329 ns | 0.0073 ns | 1.550 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.601 ns | 0.2831 ns | 0.0155 ns | 1.602 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 4.050 ns | 0.8712 ns | 0.0478 ns | 4.035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 3.795 ns | 0.1645 ns | 0.0090 ns | 3.798 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.467 ns | 0.6036 ns | 0.0331 ns | 1.449 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.699 ns | 0.5590 ns | 0.0306 ns | 1.687 ns |  1.16 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 3.981 ns | 0.5118 ns | 0.0281 ns | 3.974 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 3.809 ns | 0.3600 ns | 0.0197 ns | 3.799 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.668 ns | 0.5828 ns | 0.0319 ns | 1.683 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.500 ns | 0.3744 ns | 0.0205 ns | 1.493 ns |  0.90 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 1.160 ns | 0.5176 ns | 0.0284 ns | 1.156 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 1.212 ns | 0.6087 ns | 0.0334 ns | 1.215 ns |  1.04 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.452 ns | 0.2055 ns | 0.0113 ns | 1.454 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.820 ns | 5.9846 ns | 0.3280 ns | 1.753 ns |  1.25 |    0.22 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 4.001 ns | 0.2384 ns | 0.0131 ns | 4.005 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 4.007 ns | 6.0653 ns | 0.3325 ns | 3.863 ns |  1.00 |    0.09 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.529 ns | 0.0348 ns | 0.0019 ns | 1.528 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.719 ns | 0.7648 ns | 0.0419 ns | 1.724 ns |  1.12 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 1.972 ns | 1.1128 ns | 0.0610 ns | 1.946 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 2.155 ns | 0.0208 ns | 0.0011 ns | 2.156 ns |  1.09 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.530 ns | 0.1976 ns | 0.0108 ns | 1.528 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.722 ns | 1.5984 ns | 0.0876 ns | 1.677 ns |  1.13 |    0.06 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 2.141 ns | 0.3909 ns | 0.0214 ns | 2.133 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 2.190 ns | 0.0973 ns | 0.0053 ns | 2.191 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.491 ns | 0.8938 ns | 0.0490 ns | 1.469 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.807 ns | 0.8035 ns | 0.0440 ns | 1.786 ns |  1.21 |    0.06 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.207 ns | 1.0683 ns | 0.0586 ns | 4.229 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 4.007 ns | 0.3852 ns | 0.0211 ns | 4.014 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.588 ns | 0.1452 ns | 0.0080 ns | 1.588 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.894 ns | 1.8532 ns | 0.1016 ns | 1.873 ns |  1.19 |    0.06 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 2.203 ns | 1.0597 ns | 0.0581 ns | 2.177 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 2.211 ns | 0.6097 ns | 0.0334 ns | 2.209 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.346 ns | 2.6521 ns | 0.1454 ns | 2.355 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 2.420 ns | 0.6989 ns | 0.0383 ns | 2.400 ns |  1.03 |    0.08 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 2.280 ns | 1.3539 ns | 0.0742 ns | 2.265 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.469 ns | 0.6106 ns | 0.0335 ns | 2.472 ns |  1.08 |    0.05 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.209 ns | 0.1017 ns | 0.0056 ns | 2.207 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.268 ns | 0.6394 ns | 0.0350 ns | 2.251 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 2.027 ns | 0.0268 ns | 0.0015 ns | 2.027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 1.773 ns | 0.3327 ns | 0.0182 ns | 1.776 ns |  0.88 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.443 ns | 0.1085 ns | 0.0059 ns | 1.441 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.599 ns | 0.8002 ns | 0.0439 ns | 1.581 ns |  1.11 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.643 ns | 0.4612 ns | 0.0253 ns | 1.635 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 1.563 ns | 0.2648 ns | 0.0145 ns | 1.560 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.841 ns | 1.3074 ns | 0.0717 ns | 1.873 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.589 ns | 0.0781 ns | 0.0043 ns | 1.590 ns |  0.86 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 3.993 ns | 0.4725 ns | 0.0259 ns | 3.994 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 4.010 ns | 0.1623 ns | 0.0089 ns | 4.010 ns |  1.00 |    0.01 |     - |     - |     - |         - |
