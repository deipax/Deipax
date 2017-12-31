
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |          Error |         StdDev |        Median |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
--------------------------- |--------------:|---------------:|---------------:|--------------:|---------:|---------:|---------:|----------:|
             SingleInstance |      42.05 ns |      0.8771 ns |      2.4594 ns |      42.30 ns |   0.0051 |        - |        - |      32 B |
             ObjectInstance |      61.26 ns |      0.6100 ns |      0.4762 ns |      61.14 ns |        - |        - |        - |       0 B |
            DefaultInstance |      38.31 ns |      0.2109 ns |      0.1646 ns |      38.27 ns |   0.0051 |        - |        - |      32 B |
     ArrayOfDefaultInstance |  87,202.39 ns |  1,628.8327 ns |  3,742.5141 ns |  86,876.69 ns |  40.6006 |  40.6006 |  40.6006 |  160024 B |
        ArrayOfDiffInstance |  91,094.28 ns |  1,810.7447 ns |  4,674.1104 ns |  91,146.45 ns |  40.6152 |  40.6152 |  40.6152 |  160024 B |
        ArrayOfSameInstance |  87,071.53 ns |  1,781.5445 ns |  3,947.7797 ns |  86,446.52 ns |  35.1060 |  35.0988 |  35.0988 |  160024 B |
 ArrayOfObjectsDiffInstance | 855,161.24 ns | 17,935.1545 ns | 51,170.0050 ns | 845,774.84 ns |  11.7188 |        - |        - |   80024 B |
 ArrayOfObjectsSameInstance | 828,888.10 ns | 16,385.0364 ns | 44,017.3362 ns | 808,228.10 ns |  11.7188 |        - |        - |   80024 B |
      Array2dOfDiffInstance |  25,822.34 ns |    532.1671 ns |  1,569.1068 ns |  25,665.65 ns |  25.9094 |   7.1106 |        - |  163224 B |
      Array2dOfSameInstance |   3,957.17 ns |     82.8151 ns |    210.7909 ns |   3,842.26 ns |   0.3815 |        - |        - |    2448 B |
   ArrayRank2OfDiffInstance |     354.76 ns |      7.3491 ns |     21.4376 ns |     349.45 ns |   0.2604 |        - |        - |    1640 B |
   ArrayRank2OfSameInstance |     353.38 ns |      7.0691 ns |     15.2169 ns |     343.81 ns |   0.2604 |        - |        - |    1640 B |
   ArrayRank3OfDiffInstance | 345,631.13 ns |  7,329.2311 ns | 16,543.2959 ns | 338,247.34 ns |  12.2070 |   1.4600 |        - |   80168 B |
   ArrayRank3OfSameInstance | 339,425.74 ns |  6,685.3475 ns | 10,006.3133 ns | 333,781.02 ns |  12.2070 |   1.4600 |        - |   80168 B |
         ListOfDiffInstance | 129,113.14 ns |  4,845.4482 ns | 14,286.9133 ns | 130,410.05 ns |  34.4859 |  34.4859 |  34.4859 |  160323 B |
         ListOfSameInstance | 132,369.01 ns |  3,809.4936 ns | 10,930.1513 ns | 131,722.52 ns |  39.4739 |  39.4739 |  39.4739 |  160376 B |
  ListOfObjectsDiffInstance | 794,847.78 ns | 18,482.5371 ns | 22,698.2153 ns | 784,557.93 ns |  11.7188 |   1.9531 |        - |   80064 B |
  ListOfObjectsSameInstance | 805,954.59 ns | 15,994.8962 ns | 33,387.3047 ns | 785,834.42 ns |  11.7188 |   1.9531 |        - |   80064 B |
           KeyValuePairSame |      48.31 ns |      1.0477 ns |      3.0728 ns |      48.19 ns |   0.0076 |        - |        - |      48 B |
           KeyValuePairDiff |      45.78 ns |      0.9415 ns |      2.0468 ns |      44.58 ns |   0.0076 |        - |        - |      48 B |
          TupleSameInstance |     120.03 ns |      3.2342 ns |      3.9718 ns |     118.27 ns |   0.0074 |        - |        - |      48 B |
          TupleDiffInstance |     126.70 ns |      2.5678 ns |      7.4903 ns |     126.21 ns |   0.0074 |        - |        - |      48 B |
     DictionarySameInstance | 411,813.43 ns |  8,450.4728 ns | 22,113.4144 ns | 410,943.38 ns | 164.1699 | 153.8672 | 153.4277 |  771612 B |
     DictionaryDiffInstance | 453,203.53 ns |  9,016.9469 ns | 21,254.0048 ns | 451,950.07 ns | 168.3594 | 158.1738 | 157.6172 |  771441 B |
