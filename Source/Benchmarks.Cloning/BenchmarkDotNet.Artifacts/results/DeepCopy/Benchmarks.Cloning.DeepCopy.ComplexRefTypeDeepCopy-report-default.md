
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                         Method |            Mean |           Error |         StdDev |          Median |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
------------------------------- |----------------:|----------------:|---------------:|----------------:|---------:|---------:|---------:|----------:|
                    SimpleClass |        41.40 ns |       0.8523 ns |       1.889 ns |        40.88 ns |   0.0089 |        - |        - |      56 B |
                   ComplexClass |        58.19 ns |       1.4007 ns |       1.242 ns |        57.92 ns |   0.0126 |        - |        - |      80 B |
              InheritList_Class | 1,906,860.36 ns |  45,861.0104 ns | 133,778.720 ns | 1,896,569.73 ns | 105.6250 |  66.5234 |  23.4375 |  691155 B |
                InheritList_Int |        29.40 ns |       0.6160 ns |       1.452 ns |        29.32 ns |        - |        - |        - |       0 B |
                           Null |        29.57 ns |       0.6570 ns |       1.937 ns |        28.82 ns |        - |        - |        - |       0 B |
           GrandChildClass_Test |       129.20 ns |       2.6858 ns |       7.663 ns |       126.16 ns |   0.0520 |        - |        - |     328 B |
             List_SimpleClasses | 1,886,428.83 ns |  42,264.8267 ns | 123,955.420 ns | 1,899,638.55 ns | 110.5273 |  71.4258 |  27.1484 |  691157 B |
 List_SimpleClasses_AsInterface | 2,381,975.93 ns |  64,837.8957 ns | 191,175.998 ns | 2,346,224.81 ns | 105.8203 |  66.4844 |  23.4375 |  691155 B |
   List_SimpleClasses_AsObjects | 2,085,659.69 ns |  50,677.6277 ns | 149,424.129 ns | 2,077,480.13 ns | 105.7422 |  66.4453 |  23.4375 |  691152 B |
            List_ComplexClasses | 2,898,401.03 ns |  77,278.4751 ns | 227,857.327 ns | 2,896,847.65 ns | 148.7891 |  86.3281 |  23.7891 |  931154 B |
                List_Interfaces | 4,034,698.35 ns | 100,106.8746 ns | 295,167.378 ns | 4,050,670.14 ns | 152.5781 |  90.0781 |  31.2500 | 1062256 B |
             List_SimpleStructs |   478,387.42 ns |  12,665.4676 ns |  37,344.417 ns |   481,710.34 ns |  82.5000 |  82.5000 |  82.5000 |  656065 B |
            List_ComplexStructs |   477,108.80 ns |  13,074.2421 ns |  38,344.489 ns |   477,362.38 ns |  82.1973 |  82.1973 |  82.1973 |  656064 B |
            DictionaryOfStructs | 1,154,446.45 ns |  34,848.8258 ns | 101,655.661 ns | 1,165,733.84 ns | 201.4258 | 191.7383 | 191.6602 | 1612857 B |
            DictionaryOfClasses |              NA |              NA |             NA |              NA |      N/A |      N/A |      N/A |       N/A |
                DictionaryOfInt |   165,663.66 ns |   3,296.6098 ns |   6,808.071 ns |   167,090.33 ns |  56.4526 |  46.1353 |  45.4126 |  350884 B |

Benchmarks with issues:
  ComplexRefTypeDeepCopy.DictionaryOfClasses: DefaultJob
