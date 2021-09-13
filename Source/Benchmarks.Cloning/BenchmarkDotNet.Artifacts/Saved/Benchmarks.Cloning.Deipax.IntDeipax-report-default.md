
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                     Method |     Toolchain |          Mean |          Error |        StdDev |        Median | Ratio | RatioSD |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |-------------- |--------------:|---------------:|--------------:|--------------:|------:|--------:|--------:|--------:|--------:|----------:|
             SingleInstance | .NET Core 3.1 |      19.20 ns |       8.858 ns |      0.486 ns |      18.92 ns |  1.00 |    0.00 |       - |       - |       - |         - |
             SingleInstance | .NET Core 5.0 |      21.31 ns |       1.490 ns |      0.082 ns |      21.34 ns |  1.11 |    0.03 |       - |       - |       - |         - |
                            |               |               |                |               |               |       |         |         |         |         |           |
             ObjectInstance | .NET Core 3.1 |      44.41 ns |       2.909 ns |      0.159 ns |      44.32 ns |  1.00 |    0.00 |       - |       - |       - |         - |
             ObjectInstance | .NET Core 5.0 |      44.38 ns |       1.908 ns |      0.105 ns |      44.33 ns |  1.00 |    0.01 |       - |       - |       - |         - |
                            |               |               |                |               |               |       |         |         |         |         |           |
            DefaultInstance | .NET Core 3.1 |      19.04 ns |       2.547 ns |      0.140 ns |      18.99 ns |  1.00 |    0.00 |       - |       - |       - |         - |
            DefaultInstance | .NET Core 5.0 |      18.40 ns |       5.332 ns |      0.292 ns |      18.25 ns |  0.97 |    0.02 |       - |       - |       - |         - |
                            |               |               |                |               |               |       |         |         |         |         |           |
     ArrayOfDefaultInstance | .NET Core 3.1 |   2,220.38 ns |     527.791 ns |     28.930 ns |   2,204.68 ns |  1.00 |    0.00 |  6.3286 |       - |       - |   40024 B |
     ArrayOfDefaultInstance | .NET Core 5.0 |   2,212.06 ns |     371.615 ns |     20.369 ns |   2,207.29 ns |  1.00 |    0.01 |  6.3286 |       - |       - |   40024 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
        ArrayOfDiffInstance | .NET Core 3.1 |   2,264.33 ns |     275.486 ns |     15.100 ns |   2,258.18 ns |  1.00 |    0.00 |  6.3286 |       - |       - |   40024 B |
        ArrayOfDiffInstance | .NET Core 5.0 |   2,124.46 ns |     466.469 ns |     25.569 ns |   2,117.07 ns |  0.94 |    0.01 |  6.3286 |       - |       - |   40024 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
        ArrayOfSameInstance | .NET Core 3.1 |   2,268.42 ns |     337.210 ns |     18.484 ns |   2,261.52 ns |  1.00 |    0.00 |  6.3286 |       - |       - |   40024 B |
        ArrayOfSameInstance | .NET Core 5.0 |   2,234.24 ns |     373.417 ns |     20.468 ns |   2,222.68 ns |  0.98 |    0.01 |  6.3286 |       - |       - |   40024 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
 ArrayOfObjectsDiffInstance | .NET Core 3.1 | 283,557.26 ns | 167,170.679 ns |  9,163.189 ns | 278,491.50 ns |  1.00 |    0.00 | 12.2070 |       - |       - |   80024 B |
 ArrayOfObjectsDiffInstance | .NET Core 5.0 | 233,851.11 ns |  25,796.488 ns |  1,413.993 ns | 234,502.69 ns |  0.83 |    0.02 | 12.4512 |       - |       - |   80024 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
 ArrayOfObjectsSameInstance | .NET Core 3.1 | 281,170.90 ns | 244,248.707 ns | 13,388.096 ns | 275,870.90 ns |  1.00 |    0.00 | 12.2070 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | .NET Core 5.0 | 233,592.42 ns |  22,719.444 ns |  1,245.329 ns | 233,945.02 ns |  0.83 |    0.04 | 12.4512 |       - |       - |   80024 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
      Array2dOfDiffInstance | .NET Core 3.1 |   9,813.75 ns |   3,977.379 ns |    218.014 ns |   9,718.61 ns |  1.00 |    0.00 |  6.8817 |  0.8392 |       - |   43224 B |
      Array2dOfDiffInstance | .NET Core 5.0 |   6,706.46 ns |   4,674.220 ns |    256.210 ns |   6,629.97 ns |  0.68 |    0.01 |  6.8893 |  0.8392 |       - |   43224 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
      Array2dOfSameInstance | .NET Core 3.1 |   3,300.03 ns |     447.801 ns |     24.545 ns |   3,297.45 ns |  1.00 |    0.00 |  0.1984 |       - |       - |    1248 B |
      Array2dOfSameInstance | .NET Core 5.0 |   2,471.53 ns |     274.891 ns |     15.068 ns |   2,465.71 ns |  0.75 |    0.01 |  0.1984 |       - |       - |    1248 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
   ArrayRank2OfDiffInstance | .NET Core 3.1 |     203.35 ns |      37.622 ns |      2.062 ns |     203.18 ns |  1.00 |    0.00 |  0.0701 |       - |       - |     440 B |
   ArrayRank2OfDiffInstance | .NET Core 5.0 |     157.28 ns |      92.544 ns |      5.073 ns |     154.62 ns |  0.77 |    0.03 |  0.0701 |       - |       - |     440 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
   ArrayRank2OfSameInstance | .NET Core 3.1 |     201.56 ns |      22.350 ns |      1.225 ns |     202.03 ns |  1.00 |    0.00 |  0.0701 |       - |       - |     440 B |
   ArrayRank2OfSameInstance | .NET Core 5.0 |     156.33 ns |      28.128 ns |      1.542 ns |     155.73 ns |  0.78 |    0.01 |  0.0701 |       - |       - |     440 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
   ArrayRank3OfDiffInstance | .NET Core 3.1 |     482.78 ns |     378.764 ns |     20.761 ns |     485.83 ns |  1.00 |    0.00 |  0.6514 |       - |       - |    4088 B |
   ArrayRank3OfDiffInstance | .NET Core 5.0 |     424.01 ns |     118.165 ns |      6.477 ns |     427.60 ns |  0.88 |    0.03 |  0.6514 |       - |       - |    4088 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
   ArrayRank3OfSameInstance | .NET Core 3.1 |     470.33 ns |      22.290 ns |      1.222 ns |     470.68 ns |  1.00 |    0.00 |  0.6514 |       - |       - |    4088 B |
   ArrayRank3OfSameInstance | .NET Core 5.0 |     427.31 ns |      66.400 ns |      3.640 ns |     427.05 ns |  0.91 |    0.01 |  0.6514 |       - |       - |    4088 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
         ListOfDiffInstance | .NET Core 3.1 |   2,432.92 ns |     481.868 ns |     26.413 ns |   2,438.67 ns |  1.00 |    0.00 |  6.3667 |  0.7057 |       - |   40056 B |
         ListOfDiffInstance | .NET Core 5.0 |   2,284.13 ns |   1,064.584 ns |     58.353 ns |   2,262.55 ns |  0.94 |    0.02 |  6.3667 |  0.7057 |       - |   40056 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
         ListOfSameInstance | .NET Core 3.1 |   2,407.86 ns |     356.724 ns |     19.553 ns |   2,416.83 ns |  1.00 |    0.00 |  6.3667 |  0.7057 |       - |   40056 B |
         ListOfSameInstance | .NET Core 5.0 |   2,372.36 ns |   3,332.030 ns |    182.640 ns |   2,281.00 ns |  0.99 |    0.07 |  6.3667 |  0.7057 |       - |   40056 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
  ListOfObjectsDiffInstance | .NET Core 3.1 | 300,492.07 ns |  91,091.775 ns |  4,993.048 ns | 298,675.63 ns |  1.00 |    0.00 | 12.2070 |  1.9531 |       - |   80056 B |
  ListOfObjectsDiffInstance | .NET Core 5.0 | 241,820.13 ns |  38,627.577 ns |  2,117.308 ns | 242,165.45 ns |  0.80 |    0.01 | 12.4512 |  1.9531 |       - |   80056 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
  ListOfObjectsSameInstance | .NET Core 3.1 | 293,120.26 ns |  41,767.910 ns |  2,289.440 ns | 293,031.01 ns |  1.00 |    0.00 | 12.2070 |  1.9531 |       - |   80056 B |
  ListOfObjectsSameInstance | .NET Core 5.0 | 247,812.13 ns | 220,874.702 ns | 12,106.888 ns | 241,270.12 ns |  0.85 |    0.04 | 12.4512 |  1.9531 |       - |   80056 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
           KeyValuePairSame | .NET Core 3.1 |      22.60 ns |       1.677 ns |      0.092 ns |      22.63 ns |  1.00 |    0.00 |       - |       - |       - |         - |
           KeyValuePairSame | .NET Core 5.0 |      19.92 ns |      14.187 ns |      0.778 ns |      19.51 ns |  0.88 |    0.03 |       - |       - |       - |         - |
                            |               |               |                |               |               |       |         |         |         |         |           |
           KeyValuePairDiff | .NET Core 3.1 |      25.08 ns |       1.249 ns |      0.068 ns |      25.10 ns |  1.00 |    0.00 |       - |       - |       - |         - |
           KeyValuePairDiff | .NET Core 5.0 |      19.48 ns |       0.354 ns |      0.019 ns |      19.49 ns |  0.78 |    0.00 |       - |       - |       - |         - |
                            |               |               |                |               |               |       |         |         |         |         |           |
          TupleSameInstance | .NET Core 3.1 |      74.99 ns |      20.160 ns |      1.105 ns |      75.12 ns |  1.00 |    0.00 |  0.0038 |       - |       - |      24 B |
          TupleSameInstance | .NET Core 5.0 |      60.14 ns |       9.970 ns |      0.547 ns |      59.99 ns |  0.80 |    0.01 |  0.0038 |       - |       - |      24 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
          TupleDiffInstance | .NET Core 3.1 |      73.68 ns |      26.640 ns |      1.460 ns |      72.93 ns |  1.00 |    0.00 |  0.0038 |       - |       - |      24 B |
          TupleDiffInstance | .NET Core 5.0 |      61.64 ns |       6.969 ns |      0.382 ns |      61.61 ns |  0.84 |    0.02 |  0.0038 |       - |       - |      24 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
     DictionarySameInstance | .NET Core 3.1 | 311,079.52 ns |   9,419.182 ns |    516.297 ns | 310,991.92 ns |  1.00 |    0.00 | 49.8047 | 49.8047 | 49.8047 |  202208 B |
     DictionarySameInstance | .NET Core 5.0 | 226,146.79 ns |  25,882.170 ns |  1,418.689 ns | 226,752.34 ns |  0.73 |    0.00 | 49.8047 | 49.8047 | 49.8047 |  202216 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
     DictionaryDiffInstance | .NET Core 3.1 | 310,682.32 ns |   4,657.498 ns |    255.293 ns | 310,738.67 ns |  1.00 |    0.00 | 49.8047 | 49.8047 | 49.8047 |  202208 B |
     DictionaryDiffInstance | .NET Core 5.0 | 228,528.86 ns |  24,221.596 ns |  1,327.667 ns | 228,761.77 ns |  0.74 |    0.00 | 49.8047 | 49.8047 | 49.8047 |  202216 B |
