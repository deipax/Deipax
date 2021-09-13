
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.4343 ns | 0.7047 ns | 0.0386 ns | 1.4150 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.4038 ns | 0.4996 ns | 0.0274 ns | 1.3926 ns |  0.98 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 4.0191 ns | 0.1911 ns | 0.0105 ns | 4.0162 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 4.0008 ns | 0.3619 ns | 0.0198 ns | 4.0069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.5311 ns | 1.4391 ns | 0.0789 ns | 1.5042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.4056 ns | 0.4242 ns | 0.0233 ns | 1.3931 ns |  0.92 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 4.2885 ns | 8.1992 ns | 0.4494 ns | 4.0299 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 3.9803 ns | 0.5923 ns | 0.0325 ns | 3.9736 ns |  0.93 |    0.09 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.7846 ns | 0.0693 ns | 0.0038 ns | 1.7859 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.5475 ns | 0.9474 ns | 0.0519 ns | 1.5317 ns |  0.87 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 5.1958 ns | 0.0969 ns | 0.0053 ns | 5.1950 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 4.6984 ns | 0.3256 ns | 0.0178 ns | 4.7019 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.7796 ns | 0.1981 ns | 0.0109 ns | 1.7756 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.5154 ns | 0.6650 ns | 0.0365 ns | 1.5033 ns |  0.85 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 5.1966 ns | 0.5557 ns | 0.0305 ns | 5.2000 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 4.7349 ns | 0.6632 ns | 0.0364 ns | 4.7283 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.7768 ns | 0.3439 ns | 0.0189 ns | 1.7745 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.5377 ns | 1.0473 ns | 0.0574 ns | 1.5203 ns |  0.87 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 5.1923 ns | 0.7904 ns | 0.0433 ns | 5.1715 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 4.7570 ns | 0.5652 ns | 0.0310 ns | 4.7671 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.8282 ns | 1.5981 ns | 0.0876 ns | 1.7912 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.6867 ns | 0.6767 ns | 0.0371 ns | 1.6919 ns |  0.92 |    0.06 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 5.2091 ns | 0.3351 ns | 0.0184 ns | 5.2189 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 4.8255 ns | 2.8096 ns | 0.1540 ns | 4.7744 ns |  0.93 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.8186 ns | 0.3815 ns | 0.0209 ns | 1.8273 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.5272 ns | 0.5945 ns | 0.0326 ns | 1.5218 ns |  0.84 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 4.9855 ns | 0.3249 ns | 0.0178 ns | 4.9862 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 4.5220 ns | 0.2496 ns | 0.0137 ns | 4.5280 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.7675 ns | 0.5972 ns | 0.0327 ns | 1.7493 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.5485 ns | 0.3517 ns | 0.0193 ns | 1.5455 ns |  0.88 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 4.9892 ns | 0.2163 ns | 0.0119 ns | 4.9895 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 4.4955 ns | 0.2224 ns | 0.0122 ns | 4.4987 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 2.2194 ns | 4.3457 ns | 0.2382 ns | 2.0963 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.5309 ns | 0.4120 ns | 0.0226 ns | 1.5233 ns |  0.69 |    0.06 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 2.2842 ns | 0.1342 ns | 0.0074 ns | 2.2810 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 2.6176 ns | 0.0753 ns | 0.0041 ns | 2.6196 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.8652 ns | 3.9263 ns | 0.2152 ns | 1.7430 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.5213 ns | 0.5887 ns | 0.0323 ns | 1.5115 ns |  0.82 |    0.10 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 2.3075 ns | 0.3223 ns | 0.0177 ns | 2.3120 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 2.2853 ns | 0.5178 ns | 0.0284 ns | 2.2747 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.7179 ns | 2.8225 ns | 0.1547 ns | 1.6698 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.5880 ns | 0.3548 ns | 0.0194 ns | 1.5786 ns |  0.93 |    0.07 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.9659 ns | 0.1676 ns | 0.0092 ns | 4.9701 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 4.6951 ns | 0.1773 ns | 0.0097 ns | 4.6982 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.6162 ns | 0.0942 ns | 0.0052 ns | 1.6156 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.6290 ns | 0.2076 ns | 0.0114 ns | 1.6323 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 2.5439 ns | 0.4621 ns | 0.0253 ns | 2.5380 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 2.5145 ns | 0.8116 ns | 0.0445 ns | 2.5006 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.5967 ns | 0.4459 ns | 0.0244 ns | 2.6054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 2.2873 ns | 0.4309 ns | 0.0236 ns | 2.2964 ns |  0.88 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 2.5449 ns | 0.2283 ns | 0.0125 ns | 2.5474 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.5423 ns | 0.9524 ns | 0.0522 ns | 2.5147 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.5897 ns | 0.2094 ns | 0.0115 ns | 2.5934 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.6479 ns | 0.7382 ns | 0.0405 ns | 2.6281 ns |  1.02 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 3.1963 ns | 0.0804 ns | 0.0044 ns | 3.1976 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 2.2582 ns | 0.0372 ns | 0.0020 ns | 2.2576 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 0.9771 ns | 0.4643 ns | 0.0254 ns | 0.9655 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.0042 ns | 1.1729 ns | 0.0643 ns | 0.9880 ns |  1.03 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 0.9651 ns | 0.1033 ns | 0.0057 ns | 0.9648 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 0.9529 ns | 0.2875 ns | 0.0158 ns | 0.9504 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.4870 ns | 2.2986 ns | 0.1260 ns | 1.4444 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.3887 ns | 0.2110 ns | 0.0116 ns | 1.3866 ns |  0.94 |    0.08 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 4.0287 ns | 0.4006 ns | 0.0220 ns | 4.0257 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 4.0033 ns | 0.2109 ns | 0.0116 ns | 4.0034 ns |  0.99 |    0.01 |     - |     - |     - |         - |
