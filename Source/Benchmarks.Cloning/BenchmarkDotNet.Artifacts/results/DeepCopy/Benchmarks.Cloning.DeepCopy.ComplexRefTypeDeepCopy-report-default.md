
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                         Method |            Mean |           Error |          StdDev |          Median |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
------------------------------- |----------------:|----------------:|----------------:|----------------:|---------:|---------:|---------:|----------:|
                    SimpleClass |        45.66 ns |       1.0159 ns |       2.9634 ns |        45.57 ns |   0.0089 |        - |        - |      56 B |
                   ComplexClass |        67.43 ns |       1.5014 ns |       4.3795 ns |        66.05 ns |   0.0126 |        - |        - |      80 B |
              InheritList_Class | 1,769,356.37 ns |  52,172.7322 ns | 153,832.4781 ns | 1,756,933.37 ns | 105.9766 |  66.6016 |  23.4375 |  691159 B |
                InheritList_Int |        28.23 ns |       0.5980 ns |       1.5437 ns |        27.97 ns |        - |        - |        - |       0 B |
                           Null |        26.35 ns |       0.7634 ns |       0.8485 ns |        26.04 ns |        - |        - |        - |       0 B |
           GrandChildClass_Test |       131.18 ns |       3.3629 ns |       9.8097 ns |       129.72 ns |   0.0520 |        - |        - |     328 B |
             List_SimpleClasses | 1,864,836.48 ns |  46,017.8618 ns | 135,684.7039 ns | 1,879,657.65 ns | 110.6445 |  72.8125 |  26.8359 |  691145 B |
 List_SimpleClasses_AsInterface | 2,136,308.70 ns |  54,458.7198 ns | 160,572.7639 ns | 2,131,440.31 ns | 106.2109 |  66.6406 |  23.4375 |  691156 B |
   List_SimpleClasses_AsObjects | 2,131,629.80 ns |  42,525.6929 ns | 122,014.1846 ns | 2,130,470.70 ns | 106.2109 |  66.6797 |  23.4375 |  691149 B |
            List_ComplexClasses | 3,021,381.29 ns |  72,946.0775 ns | 213,938.2177 ns | 3,028,790.05 ns | 148.7500 |  86.2500 |  23.7500 |  931152 B |
                List_Interfaces | 4,140,467.95 ns | 102,843.1189 ns | 303,235.2563 ns | 4,097,687.00 ns | 151.3281 |  88.8281 |  31.2500 | 1062236 B |
             List_SimpleStructs |   285,331.06 ns |   5,890.9631 ns |   5,510.4100 ns |   284,464.81 ns |  93.5742 |  93.5742 |  93.5742 |  656165 B |
            List_ComplexStructs |   388,734.65 ns |   7,728.3555 ns |  20,761.7253 ns |   386,924.97 ns |  92.6025 |  92.6025 |  92.6025 |  656156 B |
            DictionaryOfStructs | 1,058,619.71 ns |  35,746.1113 ns | 105,398.2156 ns | 1,067,776.10 ns | 200.7813 | 191.2695 | 191.0156 | 1612799 B |
            DictionaryOfClasses |              NA |              NA |              NA |              NA |      N/A |      N/A |      N/A |       N/A |
                DictionaryOfInt |   170,651.78 ns |   3,838.9288 ns |  11,137.4286 ns |   169,050.36 ns |  56.6113 |  46.0767 |  45.4688 |  350884 B |

Benchmarks with issues:
  ComplexRefTypeDeepCopy.DictionaryOfClasses: DefaultJob
