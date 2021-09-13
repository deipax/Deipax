
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  3.999 ns | 4.6004 ns | 0.2522 ns |  4.106 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  3.672 ns | 1.2858 ns | 0.0705 ns |  3.652 ns |  0.92 |    0.05 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  6.518 ns | 0.6268 ns | 0.0344 ns |  6.512 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  6.790 ns | 0.1062 ns | 0.0058 ns |  6.788 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 |  4.311 ns | 1.6196 ns | 0.0888 ns |  4.286 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  3.631 ns | 0.2473 ns | 0.0136 ns |  3.639 ns |  0.84 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 |  6.443 ns | 0.0199 ns | 0.0011 ns |  6.443 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  6.812 ns | 0.5990 ns | 0.0328 ns |  6.821 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 |  4.299 ns | 0.1908 ns | 0.0105 ns |  4.297 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  3.928 ns | 0.0625 ns | 0.0034 ns |  3.928 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  6.337 ns | 0.6099 ns | 0.0334 ns |  6.318 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  6.862 ns | 2.0724 ns | 0.1136 ns |  6.801 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 |  4.219 ns | 0.2327 ns | 0.0128 ns |  4.224 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  3.790 ns | 1.1371 ns | 0.0623 ns |  3.760 ns |  0.90 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 |  6.527 ns | 0.9865 ns | 0.0541 ns |  6.496 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  6.776 ns | 0.1062 ns | 0.0058 ns |  6.775 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 |  4.457 ns | 5.1494 ns | 0.2823 ns |  4.407 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  4.007 ns | 0.1937 ns | 0.0106 ns |  4.007 ns |  0.90 |    0.06 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 |  6.537 ns | 0.6153 ns | 0.0337 ns |  6.547 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  6.991 ns | 3.7951 ns | 0.2080 ns |  7.073 ns |  1.07 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 |  4.210 ns | 0.3013 ns | 0.0165 ns |  4.212 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  3.639 ns | 0.7943 ns | 0.0435 ns |  3.622 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  6.537 ns | 0.5476 ns | 0.0300 ns |  6.531 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  6.779 ns | 0.2220 ns | 0.0122 ns |  6.785 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 |  4.374 ns | 1.2008 ns | 0.0658 ns |  4.390 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  3.761 ns | 0.5941 ns | 0.0326 ns |  3.776 ns |  0.86 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 |  6.497 ns | 0.4160 ns | 0.0228 ns |  6.509 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  6.761 ns | 0.7316 ns | 0.0401 ns |  6.775 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 |  3.734 ns | 0.2365 ns | 0.0130 ns |  3.741 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  3.831 ns | 1.6497 ns | 0.0904 ns |  3.865 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  6.543 ns | 0.3453 ns | 0.0189 ns |  6.533 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  6.753 ns | 0.0228 ns | 0.0012 ns |  6.754 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 |  3.897 ns | 0.1037 ns | 0.0057 ns |  3.894 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  4.131 ns | 0.6732 ns | 0.0369 ns |  4.116 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 |  5.960 ns | 0.9050 ns | 0.0496 ns |  5.946 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  8.389 ns | 0.5597 ns | 0.0307 ns |  8.401 ns |  1.41 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 |  3.864 ns | 0.1757 ns | 0.0096 ns |  3.861 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  4.325 ns | 0.1507 ns | 0.0083 ns |  4.323 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 |  5.684 ns | 0.0426 ns | 0.0023 ns |  5.685 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  8.611 ns | 0.1840 ns | 0.0101 ns |  8.611 ns |  1.51 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 |  4.018 ns | 0.1295 ns | 0.0071 ns |  4.019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  4.011 ns | 1.6279 ns | 0.0892 ns |  3.989 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  6.736 ns | 0.3376 ns | 0.0185 ns |  6.735 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  6.980 ns | 0.6450 ns | 0.0354 ns |  6.998 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 |  4.043 ns | 1.3901 ns | 0.0762 ns |  4.024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  3.993 ns | 1.4744 ns | 0.0808 ns |  4.037 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  5.165 ns | 0.3160 ns | 0.0173 ns |  5.157 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  8.365 ns | 0.7446 ns | 0.0408 ns |  8.351 ns |  1.62 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 |  4.593 ns | 0.5324 ns | 0.0292 ns |  4.598 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  4.790 ns | 0.9589 ns | 0.0526 ns |  4.788 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 |  5.205 ns | 1.1903 ns | 0.0652 ns |  5.176 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  5.608 ns | 2.0697 ns | 0.1134 ns |  5.591 ns |  1.08 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 |  4.608 ns | 1.7928 ns | 0.0983 ns |  4.564 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  4.369 ns | 0.3404 ns | 0.0187 ns |  4.379 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  5.237 ns | 0.2510 ns | 0.0138 ns |  5.231 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  5.769 ns | 1.5985 ns | 0.0876 ns |  5.745 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 |  1.137 ns | 0.5443 ns | 0.0298 ns |  1.126 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 |  1.187 ns | 0.1322 ns | 0.0072 ns |  1.184 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 12.597 ns | 3.3719 ns | 0.1848 ns | 12.529 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 12.951 ns | 1.4222 ns | 0.0780 ns | 12.947 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 12.854 ns | 0.9653 ns | 0.0529 ns | 12.870 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 10.706 ns | 3.3307 ns | 0.1826 ns | 10.603 ns |  0.83 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 13.956 ns | 0.1651 ns | 0.0090 ns | 13.958 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 11.564 ns | 4.2774 ns | 0.2345 ns | 11.429 ns |  0.83 |    0.02 |     - |     - |     - |         - |
