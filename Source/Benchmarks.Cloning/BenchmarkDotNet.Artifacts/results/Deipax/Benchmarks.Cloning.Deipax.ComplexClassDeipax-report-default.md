
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |           Error |         StdDev |          Median |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
--------------------------- |----------------:|----------------:|---------------:|----------------:|---------:|---------:|--------:|----------:|
             SingleInstance |       146.40 ns |       2.9413 ns |       6.074 ns |       142.83 ns |   0.0050 |        - |       - |      32 B |
             ObjectInstance |       165.58 ns |       3.3423 ns |       6.977 ns |       165.64 ns |   0.0050 |        - |       - |      32 B |
            DefaultInstance |        29.73 ns |       0.6276 ns |       1.528 ns |        29.09 ns |        - |        - |       - |       0 B |
     ArrayOfDefaultInstance |     9,032.52 ns |     180.4852 ns |     509.062 ns |     8,824.47 ns |  12.6495 |        - |       - |   80024 B |
        ArrayOfDiffInstance |   920,910.89 ns |  18,328.1369 ns |  46,982.022 ns |   895,600.97 ns |  62.5000 |  23.4375 |       - |  400024 B |
        ArrayOfSameInstance |   298,095.58 ns |   5,760.3866 ns |   6,857.331 ns |   294,036.18 ns |  12.2070 |        - |       - |   80056 B |
 ArrayOfObjectsDiffInstance | 1,254,626.76 ns |  25,332.1405 ns |  74,692.388 ns | 1,259,210.75 ns |  62.5000 |  23.4375 |       - |  400024 B |
 ArrayOfObjectsSameInstance |   580,278.03 ns |  11,307.0548 ns |  19,200.237 ns |   582,031.01 ns |  11.7188 |        - |       - |   80056 B |
      Array2dOfDiffInstance |   949,963.05 ns |  18,957.4228 ns |  50,601.199 ns |   931,494.18 ns |  63.4766 |  24.4141 |       - |  403224 B |
      Array2dOfSameInstance |    13,697.26 ns |     282.5782 ns |     833.188 ns |    13,588.94 ns |   0.7629 |        - |       - |    4848 B |
   ArrayRank2OfDiffInstance |     9,735.59 ns |     205.1061 ns |     598.304 ns |     9,666.67 ns |   0.6256 |        - |       - |    4040 B |
   ArrayRank2OfSameInstance |     3,831.11 ns |      76.4806 ns |     129.870 ns |     3,757.24 ns |   0.1297 |        - |       - |     872 B |
   ArrayRank3OfDiffInstance |   216,490.88 ns |   4,429.0994 ns |  11,432.920 ns |   216,979.83 ns |   6.1035 |   0.4883 |       - |   40168 B |
   ArrayRank3OfSameInstance |   139,724.09 ns |   2,783.2457 ns |   7,283.269 ns |   135,280.06 ns |   1.2207 |        - |       - |    8200 B |
         ListOfDiffInstance |   924,546.95 ns |  19,538.4934 ns |  57,609.689 ns |   911,637.56 ns |  62.5000 |  23.4375 |       - |  400064 B |
         ListOfSameInstance |   322,805.84 ns |   8,378.1673 ns |  24,571.714 ns |   314,009.58 ns |  12.2070 |   1.9531 |       - |   80096 B |
  ListOfObjectsDiffInstance | 1,208,425.35 ns |  30,192.0667 ns |  88,548.105 ns | 1,171,591.58 ns |  62.5000 |  23.4375 |       - |  400064 B |
  ListOfObjectsSameInstance |   537,157.29 ns |  10,939.5427 ns |  26,628.359 ns |   519,748.51 ns |  11.7188 |   1.9531 |       - |   80096 B |
           KeyValuePairSame |       207.58 ns |       4.1544 ns |      10.499 ns |       201.16 ns |   0.0100 |        - |       - |      64 B |
           KeyValuePairDiff |       269.83 ns |       6.4992 ns |      19.163 ns |       263.94 ns |   0.0148 |        - |       - |      96 B |
          TupleSameInstance |       236.63 ns |       4.7480 ns |      13.077 ns |       235.26 ns |   0.0100 |        - |       - |      64 B |
          TupleDiffInstance |       286.39 ns |       6.5685 ns |      19.367 ns |       284.22 ns |   0.0148 |        - |       - |      96 B |
     DictionarySameInstance | 3,136,633.02 ns | 101,214.8373 ns | 296,845.597 ns | 3,098,094.94 ns | 117.3438 | 108.6328 | 63.3594 |  603194 B |
     DictionaryDiffInstance | 4,207,263.95 ns | 132,603.3460 ns | 390,983.958 ns | 4,173,319.24 ns | 157.1875 | 110.3125 | 55.6250 |  923090 B |
