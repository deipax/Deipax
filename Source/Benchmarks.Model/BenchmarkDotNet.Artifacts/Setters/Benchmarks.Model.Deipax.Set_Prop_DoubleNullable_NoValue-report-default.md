
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 1.0436 ns | 0.3874 ns | 0.0212 ns | 1.0333 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 0.9852 ns | 0.7209 ns | 0.0395 ns | 0.9629 ns |  0.94 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 1.2889 ns | 0.9407 ns | 0.0516 ns | 1.2719 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 1.4984 ns | 0.8780 ns | 0.0481 ns | 1.4726 ns |  1.16 |    0.08 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 0.7844 ns | 0.4446 ns | 0.0244 ns | 0.7799 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 0.7570 ns | 0.2996 ns | 0.0164 ns | 0.7525 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 0.8256 ns | 0.1502 ns | 0.0082 ns | 0.8285 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 0.7304 ns | 0.8065 ns | 0.0442 ns | 0.7231 ns |  0.89 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 0.7611 ns | 0.0458 ns | 0.0025 ns | 0.7606 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 0.6182 ns | 0.1874 ns | 0.0103 ns | 0.6175 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 1.0420 ns | 0.0019 ns | 0.0001 ns | 1.0420 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 1.2626 ns | 0.4345 ns | 0.0238 ns | 1.2532 ns |  1.21 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 0.7116 ns | 1.8088 ns | 0.0991 ns | 0.6792 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 0.7663 ns | 0.3826 ns | 0.0210 ns | 0.7626 ns |  1.09 |    0.14 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 1.0500 ns | 0.3073 ns | 0.0168 ns | 1.0428 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 1.2935 ns | 1.3317 ns | 0.0730 ns | 1.2653 ns |  1.23 |    0.09 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 0.7543 ns | 0.3635 ns | 0.0199 ns | 0.7491 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 0.9925 ns | 0.1220 ns | 0.0067 ns | 0.9891 ns |  1.32 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 1.1840 ns | 0.4361 ns | 0.0239 ns | 1.1729 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 1.2144 ns | 0.0760 ns | 0.0042 ns | 1.2128 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 0.7852 ns | 0.3882 ns | 0.0213 ns | 0.7752 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 0.6020 ns | 0.2381 ns | 0.0130 ns | 0.6079 ns |  0.77 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 1.2948 ns | 0.9292 ns | 0.0509 ns | 1.3021 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 1.2866 ns | 1.0687 ns | 0.0586 ns | 1.2780 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 0.8044 ns | 0.3548 ns | 0.0194 ns | 0.8015 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 0.7404 ns | 0.3899 ns | 0.0214 ns | 0.7282 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 1.2015 ns | 0.6069 ns | 0.0333 ns | 1.2184 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 1.2081 ns | 0.1520 ns | 0.0083 ns | 1.2105 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 0.8254 ns | 0.6833 ns | 0.0375 ns | 0.8424 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 0.8091 ns | 1.0734 ns | 0.0588 ns | 0.8285 ns |  0.98 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 1.1967 ns | 0.3252 ns | 0.0178 ns | 1.1957 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 1.2270 ns | 0.7320 ns | 0.0401 ns | 1.2039 ns |  1.03 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 0.7688 ns | 0.4163 ns | 0.0228 ns | 0.7631 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 0.7921 ns | 0.0913 ns | 0.0050 ns | 0.7919 ns |  1.03 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 1.7701 ns | 0.5188 ns | 0.0284 ns | 1.7579 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 1.8195 ns | 1.4948 ns | 0.0819 ns | 1.8649 ns |  1.03 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 0.8001 ns | 0.3858 ns | 0.0211 ns | 0.8044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 1.0071 ns | 0.1352 ns | 0.0074 ns | 1.0080 ns |  1.26 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 1.7835 ns | 0.0655 ns | 0.0036 ns | 1.7843 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.6119 ns | 0.9700 ns | 0.0532 ns | 1.5954 ns |  0.90 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 0.8051 ns | 0.2230 ns | 0.0122 ns | 0.8054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 0.7942 ns | 0.1831 ns | 0.0100 ns | 0.7996 ns |  0.99 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 1.2242 ns | 1.0806 ns | 0.0592 ns | 1.2184 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 1.2191 ns | 0.4972 ns | 0.0273 ns | 1.2239 ns |  1.00 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 0.7533 ns | 0.5585 ns | 0.0306 ns | 0.7359 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 0.9412 ns | 0.0549 ns | 0.0030 ns | 0.9395 ns |  1.25 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 1.4651 ns | 1.2577 ns | 0.0689 ns | 1.4340 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 1.2157 ns | 0.9036 ns | 0.0495 ns | 1.1992 ns |  0.83 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 5.3210 ns | 0.1474 ns | 0.0081 ns | 5.3188 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 4.2657 ns | 1.6243 ns | 0.0890 ns | 4.2787 ns |  0.80 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 2.6887 ns | 0.0320 ns | 0.0018 ns | 2.6879 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 2.4352 ns | 0.5529 ns | 0.0303 ns | 2.4461 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 | 0.7507 ns | 0.3366 ns | 0.0185 ns | 0.7528 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 | 0.7548 ns | 0.1066 ns | 0.0058 ns | 0.7532 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.6002 ns | 0.4819 ns | 0.0264 ns | 1.5984 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.2147 ns | 0.4329 ns | 0.0237 ns | 1.2178 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 2.9067 ns | 0.3353 ns | 0.0184 ns | 2.9169 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 2.8777 ns | 1.5160 ns | 0.0831 ns | 2.8335 ns |  0.99 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 1.9389 ns | 0.4317 ns | 0.0237 ns | 1.9335 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 1.8834 ns | 0.2976 ns | 0.0163 ns | 1.8752 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 0.7351 ns | 0.0724 ns | 0.0040 ns | 0.7363 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 | 0.7953 ns | 0.6172 ns | 0.0338 ns | 0.8102 ns |  1.08 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 1.1923 ns | 0.9153 ns | 0.0502 ns | 1.1696 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.2013 ns | 0.4702 ns | 0.0258 ns | 1.1931 ns |  1.01 |    0.06 |     - |     - |     - |         - |
