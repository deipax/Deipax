
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                         Method |            Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------------------- |----------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
                    SimpleClass |        31.31 ns |     0.0387 ns |     0.0362 ns |      0.0089 |           - |           - |                56 B |
                   ComplexClass |        45.06 ns |     0.0327 ns |     0.0306 ns |      0.0127 |           - |           - |                80 B |
              InheritList_Class | 1,076,906.16 ns | 9,340.2523 ns | 8,736.8778 ns |    113.2813 |     78.1250 |     25.3906 |            691145 B |
                InheritList_Int |        19.40 ns |     0.0381 ns |     0.0357 ns |           - |           - |           - |                   - |
                           Null |        18.02 ns |     0.0114 ns |     0.0106 ns |           - |           - |           - |                   - |
           GrandChildClass_Test |       105.63 ns |     0.1441 ns |     0.1348 ns |      0.0521 |           - |           - |               328 B |
             List_SimpleClasses | 1,044,625.32 ns | 8,119.5454 ns | 7,595.0278 ns |    113.2813 |     76.1719 |     25.3906 |            691147 B |
 List_SimpleClasses_AsInterface | 1,325,582.23 ns | 8,101.4279 ns | 7,578.0807 ns |    111.3281 |     74.2188 |     27.3438 |            691151 B |
   List_SimpleClasses_AsObjects | 1,279,199.49 ns | 8,374.4985 ns | 7,833.5111 ns |    111.3281 |     74.2188 |     27.3438 |            691161 B |
            List_ComplexClasses | 1,563,524.60 ns | 5,312.1857 ns | 4,435.9157 ns |    156.2500 |     93.7500 |     29.2969 |            931148 B |
                List_Interfaces | 2,368,748.76 ns | 2,507.2184 ns | 2,345.2536 ns |    156.2500 |     93.7500 |     42.9688 |           1062262 B |
             List_SimpleStructs |   201,619.99 ns | 1,670.5377 ns | 1,562.6220 ns |     49.0723 |     49.0723 |     49.0723 |            655746 B |
            List_ComplexStructs |   194,207.12 ns | 1,306.0341 ns | 1,157.7652 ns |     48.3398 |     48.3398 |     48.3398 |            655738 B |
            DictionaryOfStructs |   405,343.41 ns | 2,680.9561 ns | 2,507.7680 ns |    100.0977 |     89.8438 |     88.8672 |           1612569 B |
            DictionaryOfClasses |              NA |            NA |            NA |           - |           - |           - |                   - |
                DictionaryOfInt |    86,451.07 ns |   422.8485 ns |   353.0976 ns |     32.7148 |     21.8506 |     21.6064 |            350677 B |

Benchmarks with issues:
  ComplexRefTypeDeepCopy.DictionaryOfClasses: DefaultJob
