
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                         Method |            Mean |          Error |         StdDev |          Median | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------- |----------------:|---------------:|---------------:|----------------:|------------:|------------:|------------:|--------------------:|
                    SimpleClass |        39.57 ns |      0.2643 ns |      0.2473 ns |        39.55 ns |      0.0089 |           - |           - |                56 B |
                   ComplexClass |        51.17 ns |      0.3293 ns |      0.3080 ns |        51.09 ns |      0.0127 |           - |           - |                80 B |
              InheritList_Class | 1,194,321.03 ns | 21,659.8293 ns | 20,260.6178 ns | 1,199,964.34 ns |    113.2813 |     76.1719 |     25.3906 |            691247 B |
                InheritList_Int |        19.46 ns |      0.1407 ns |      0.1316 ns |        19.44 ns |           - |           - |           - |                   - |
                           Null |        20.65 ns |      0.0972 ns |      0.0861 ns |        20.63 ns |           - |           - |           - |                   - |
           GrandChildClass_Test |        97.07 ns |      0.4259 ns |      0.3984 ns |        97.04 ns |      0.0521 |           - |           - |               328 B |
             List_SimpleClasses | 1,184,811.42 ns | 23,004.2937 ns | 25,569.2115 ns | 1,185,844.51 ns |    113.2813 |     76.1719 |     25.3906 |            691247 B |
 List_SimpleClasses_AsInterface | 1,354,112.42 ns | 26,500.1662 ns | 32,544.5840 ns | 1,355,371.93 ns |    111.3281 |     74.2188 |     23.4375 |            691281 B |
   List_SimpleClasses_AsObjects | 1,310,023.89 ns | 24,595.5875 ns | 26,317.0031 ns | 1,300,895.56 ns |    109.3750 |     72.2656 |     23.4375 |            691235 B |
            List_ComplexClasses | 1,628,545.98 ns | 31,726.1501 ns | 55,565.7926 ns | 1,627,046.04 ns |    158.2031 |     99.6094 |     31.2500 |            931184 B |
                List_Interfaces | 2,538,803.83 ns | 26,503.6289 ns | 24,791.5110 ns | 2,531,799.92 ns |    160.1563 |    101.5625 |     39.0625 |           1062378 B |
             List_SimpleStructs |   168,599.98 ns | 28,833.6651 ns | 85,016.7121 ns |   239,419.03 ns |     32.4707 |     32.4707 |     32.4707 |            655691 B |
            List_ComplexStructs |   174,604.37 ns | 28,153.9628 ns | 83,012.5945 ns |   238,797.48 ns |     34.4238 |     34.4238 |     34.4238 |            655706 B |
            DictionaryOfStructs |   166,500.65 ns |  3,026.4732 ns |  2,682.8897 ns |   166,274.43 ns |     91.5527 |     81.7871 |     80.3223 |           1614184 B |
            DictionaryOfClasses |              NA |             NA |             NA |              NA |           - |           - |           - |                   - |
                DictionaryOfInt |    38,053.68 ns |    450.5620 ns |    399.4115 ns |    38,057.07 ns |     30.2124 |     20.1416 |     19.1040 |            350986 B |

Benchmarks with issues:
  ComplexRefTypeDeepCopy.DictionaryOfClasses: DefaultJob
