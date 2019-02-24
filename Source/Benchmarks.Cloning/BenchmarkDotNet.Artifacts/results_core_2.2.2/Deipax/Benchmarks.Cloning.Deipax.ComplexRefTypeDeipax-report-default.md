
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                         Method |            Mean |          Error |         StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------- |----------------:|---------------:|---------------:|------------:|------------:|------------:|--------------------:|
                    SimpleClass |        75.57 ns |      0.1015 ns |      0.0900 ns |      0.0088 |           - |           - |                56 B |
                   ComplexClass |       116.29 ns |      0.1151 ns |      0.1077 ns |      0.0126 |           - |           - |                80 B |
              InheritList_Class | 1,154,705.60 ns | 13,191.9118 ns | 12,339.7225 ns |    113.2813 |     78.1250 |     25.3906 |            691204 B |
                InheritList_Int |        18.10 ns |      0.0244 ns |      0.0228 ns |           - |           - |           - |                   - |
                           Null |        18.11 ns |      0.0104 ns |      0.0097 ns |           - |           - |           - |                   - |
           GrandChildClass_Test |       114.85 ns |      0.2237 ns |      0.2093 ns |      0.0521 |           - |           - |               328 B |
             List_SimpleClasses |   501,350.09 ns |    804.4977 ns |    713.1662 ns |    101.5625 |     41.9922 |           - |            640064 B |
 List_SimpleClasses_AsInterface |   755,146.24 ns |    747.9871 ns |    663.0711 ns |    101.5625 |     41.9922 |           - |            640064 B |
   List_SimpleClasses_AsObjects |   711,015.39 ns |  1,040.8440 ns |    922.6811 ns |    101.5625 |     41.9922 |           - |            640064 B |
            List_ComplexClasses | 1,034,767.89 ns |  1,179.1103 ns |  1,045.2506 ns |    138.6719 |     54.6875 |           - |            880064 B |
                List_Interfaces | 2,580,177.42 ns |  7,341.6189 ns |  6,867.3549 ns |    152.3438 |     89.8438 |     27.3438 |            960125 B |
             List_SimpleStructs |   126,096.06 ns |    584.3969 ns |    518.0526 ns |     29.0527 |     29.0527 |     29.0527 |            400243 B |
            List_ComplexStructs |   124,453.51 ns |    543.9894 ns |    508.8480 ns |     29.2969 |     29.2969 |     29.2969 |            400253 B |
            DictionaryOfStructs |   941,477.26 ns |  6,460.1462 ns |  5,726.7513 ns |    257.8125 |    192.3828 |    163.0859 |           1489692 B |
            DictionaryOfClasses | 2,855,266.51 ns | 29,192.9920 ns | 27,307.1428 ns |    230.4688 |    148.4375 |     46.8750 |           1403024 B |
                DictionaryOfInt |   209,896.27 ns |    520.5036 ns |    461.4129 ns |     42.7246 |     36.3770 |     36.3770 |            202477 B |
