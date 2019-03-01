
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                         Method |            Mean |          Error |         StdDev |          Median | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------- |----------------:|---------------:|---------------:|----------------:|------------:|------------:|------------:|--------------------:|
                    SimpleClass |        95.81 ns |      0.9516 ns |      0.8901 ns |        96.09 ns |      0.0088 |           - |           - |                56 B |
                   ComplexClass |       153.29 ns |      0.8425 ns |      0.7881 ns |       153.09 ns |      0.0126 |           - |           - |                80 B |
              InheritList_Class | 1,467,713.29 ns | 27,727.9247 ns | 25,936.7180 ns | 1,467,466.60 ns |    111.3281 |     74.2188 |     23.4375 |            691266 B |
                InheritList_Int |        20.55 ns |      0.1331 ns |      0.1180 ns |        20.52 ns |           - |           - |           - |                   - |
                           Null |        19.46 ns |      0.1456 ns |      0.1362 ns |        19.48 ns |           - |           - |           - |                   - |
           GrandChildClass_Test |       133.20 ns |      0.9488 ns |      0.8411 ns |       133.30 ns |      0.0520 |           - |           - |               328 B |
             List_SimpleClasses |   673,946.69 ns |  4,350.4074 ns |  4,069.3738 ns |   673,036.41 ns |    101.5625 |     41.9922 |           - |            640071 B |
 List_SimpleClasses_AsInterface |   980,121.85 ns |  6,471.2010 ns |  6,053.1654 ns |   979,567.77 ns |    101.5625 |     41.0156 |           - |            640072 B |
   List_SimpleClasses_AsObjects |   914,957.73 ns |  3,722.6196 ns |  3,482.1407 ns |   914,135.94 ns |    101.5625 |     41.9922 |           - |            640071 B |
            List_ComplexClasses | 1,421,128.64 ns |  3,786.3379 ns |  3,161.7636 ns | 1,421,547.66 ns |    138.6719 |     54.6875 |           - |            880079 B |
                List_Interfaces | 3,351,884.38 ns | 39,652.2087 ns | 37,090.7007 ns | 3,343,408.98 ns |    152.3438 |     93.7500 |     27.3438 |            960159 B |
             List_SimpleStructs |    96,852.55 ns | 17,685.7546 ns | 52,146.8465 ns |   130,926.37 ns |     20.8740 |     20.8740 |     20.8740 |            400244 B |
            List_ComplexStructs |   111,561.28 ns | 16,775.4020 ns | 49,462.6514 ns |   146,291.82 ns |     22.4609 |     22.4609 |     22.4609 |            400247 B |
            DictionaryOfStructs |   907,208.44 ns |  6,199.9430 ns |  5,799.4305 ns |   905,010.01 ns |    226.5625 |    159.1797 |    131.8359 |           1490189 B |
            DictionaryOfClasses | 3,473,507.78 ns | 29,566.3725 ns | 26,209.8191 ns | 3,468,596.29 ns |    230.4688 |    144.5313 |     46.8750 |           1403117 B |
                DictionaryOfInt |   186,228.21 ns |  1,849.3813 ns |  1,729.9124 ns |   185,586.32 ns |     37.5977 |     31.2500 |     31.2500 |            202869 B |
