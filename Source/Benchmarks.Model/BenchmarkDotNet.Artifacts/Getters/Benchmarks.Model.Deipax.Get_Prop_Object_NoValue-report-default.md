
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |---------:|----------:|----------:|---------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 2.103 ns | 0.0841 ns | 0.0046 ns | 2.104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 2.177 ns | 0.4112 ns | 0.0225 ns | 2.165 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 4.667 ns | 0.3443 ns | 0.0189 ns | 4.675 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 5.099 ns | 0.2280 ns | 0.0125 ns | 5.099 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 2.063 ns | 0.0218 ns | 0.0012 ns | 2.063 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 2.357 ns | 1.4225 ns | 0.0780 ns | 2.389 ns |  1.14 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 4.619 ns | 0.1938 ns | 0.0106 ns | 4.624 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 5.188 ns | 0.3182 ns | 0.0174 ns | 5.184 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 2.334 ns | 3.9995 ns | 0.2192 ns | 2.296 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 2.197 ns | 0.3754 ns | 0.0206 ns | 2.203 ns |  0.95 |    0.10 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 4.660 ns | 0.3816 ns | 0.0209 ns | 4.655 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 5.144 ns | 0.3070 ns | 0.0168 ns | 5.137 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 2.010 ns | 0.0840 ns | 0.0046 ns | 2.009 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 2.263 ns | 0.8989 ns | 0.0493 ns | 2.258 ns |  1.13 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 4.845 ns | 0.5062 ns | 0.0277 ns | 4.835 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 4.949 ns | 0.5813 ns | 0.0319 ns | 4.957 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 2.091 ns | 1.1638 ns | 0.0638 ns | 2.067 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 2.212 ns | 1.0882 ns | 0.0596 ns | 2.187 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 4.852 ns | 0.1717 ns | 0.0094 ns | 4.856 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 4.943 ns | 0.1634 ns | 0.0090 ns | 4.941 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 2.049 ns | 0.0245 ns | 0.0013 ns | 2.049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 2.180 ns | 0.1409 ns | 0.0077 ns | 2.176 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 4.671 ns | 0.1651 ns | 0.0090 ns | 4.670 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 5.115 ns | 0.5504 ns | 0.0302 ns | 5.119 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 2.129 ns | 1.9643 ns | 0.1077 ns | 2.116 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 2.306 ns | 0.8570 ns | 0.0470 ns | 2.317 ns |  1.08 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 4.677 ns | 0.7569 ns | 0.0415 ns | 4.686 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 4.685 ns | 0.2224 ns | 0.0122 ns | 4.689 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 2.782 ns | 0.6721 ns | 0.0368 ns | 2.794 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 2.246 ns | 0.2220 ns | 0.0122 ns | 2.245 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 4.696 ns | 0.1202 ns | 0.0066 ns | 4.695 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 4.910 ns | 0.2000 ns | 0.0110 ns | 4.908 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 2.079 ns | 0.9849 ns | 0.0540 ns | 2.052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 2.221 ns | 0.7842 ns | 0.0430 ns | 2.222 ns |  1.07 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 2.996 ns | 0.7949 ns | 0.0436 ns | 3.018 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 6.476 ns | 0.2446 ns | 0.0134 ns | 6.484 ns |  2.16 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 2.057 ns | 0.4956 ns | 0.0272 ns | 2.045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 2.217 ns | 0.8989 ns | 0.0493 ns | 2.228 ns |  1.08 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 3.095 ns | 0.4233 ns | 0.0232 ns | 3.104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 6.531 ns | 0.1737 ns | 0.0095 ns | 6.532 ns |  2.11 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 2.171 ns | 2.6108 ns | 0.1431 ns | 2.098 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 2.156 ns | 1.4904 ns | 0.0817 ns | 2.187 ns |  1.00 |    0.10 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.893 ns | 0.4171 ns | 0.0229 ns | 4.905 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 4.894 ns | 0.1588 ns | 0.0087 ns | 4.891 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 2.111 ns | 0.3066 ns | 0.0168 ns | 2.102 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 2.168 ns | 0.7917 ns | 0.0434 ns | 2.157 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 3.675 ns | 3.0300 ns | 0.1661 ns | 3.678 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 6.589 ns | 0.1421 ns | 0.0078 ns | 6.586 ns |  1.80 |    0.08 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 3.495 ns | 1.6518 ns | 0.0905 ns | 3.542 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 3.440 ns | 1.4061 ns | 0.0771 ns | 3.483 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 3.489 ns | 1.2681 ns | 0.0695 ns | 3.494 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 3.455 ns | 0.6364 ns | 0.0349 ns | 3.448 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.827 ns | 0.1429 ns | 0.0078 ns | 2.824 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.831 ns | 1.1002 ns | 0.0603 ns | 2.859 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 3.494 ns | 1.3040 ns | 0.0715 ns | 3.516 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 3.289 ns | 1.9897 ns | 0.1091 ns | 3.230 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.107 ns | 0.0266 ns | 0.0015 ns | 1.107 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.203 ns | 0.2882 ns | 0.0158 ns | 1.198 ns |  1.09 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.707 ns | 0.7173 ns | 0.0393 ns | 1.692 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 2.072 ns | 0.3498 ns | 0.0192 ns | 2.068 ns |  1.21 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.871 ns | 2.8818 ns | 0.1580 ns | 1.808 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 2.142 ns | 1.1438 ns | 0.0627 ns | 2.110 ns |  1.15 |    0.12 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 4.446 ns | 0.4325 ns | 0.0237 ns | 4.451 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 4.676 ns | 0.3813 ns | 0.0209 ns | 4.682 ns |  1.05 |    0.01 |     - |     - |     - |         - |
