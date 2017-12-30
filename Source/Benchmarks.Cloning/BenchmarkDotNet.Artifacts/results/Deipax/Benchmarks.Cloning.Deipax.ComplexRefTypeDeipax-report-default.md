
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                         Method |            Mean |           Error |          StdDev |          Median |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
------------------------------- |----------------:|----------------:|----------------:|----------------:|---------:|---------:|---------:|----------:|
                    SimpleClass |       115.51 ns |       2.3248 ns |       5.3416 ns |       113.96 ns |   0.0088 |        - |        - |      56 B |
                   ComplexClass |       177.89 ns |       5.0328 ns |      14.6808 ns |       176.81 ns |   0.0126 |        - |        - |      80 B |
              InheritList_Class | 1,933,316.47 ns |  50,697.2374 ns | 148,686.2212 ns | 1,935,653.70 ns | 106.1719 |  66.8750 |  23.4375 |  691201 B |
                InheritList_Int |        32.16 ns |       0.6720 ns |       0.8971 ns |        32.08 ns |        - |        - |        - |       0 B |
                           Null |        31.42 ns |       0.6576 ns |       0.5830 ns |        31.08 ns |        - |        - |        - |       0 B |
           GrandChildClass_Test |       153.56 ns |       3.0708 ns |       7.5903 ns |       153.08 ns |   0.0520 |        - |        - |     328 B |
             List_SimpleClasses |   681,770.44 ns |  12,985.1912 ns |  13,894.0078 ns |   679,501.33 ns | 100.5859 |  41.0156 |        - |  640064 B |
 List_SimpleClasses_AsInterface | 1,036,534.99 ns |  23,233.9936 ns |  36,172.5289 ns | 1,023,776.79 ns |  99.6094 |  41.0156 |        - |  640064 B |
   List_SimpleClasses_AsObjects |   967,153.88 ns |  18,996.6877 ns |  26,002.8805 ns |   967,416.30 ns | 100.5859 |  41.0156 |        - |  640064 B |
            List_ComplexClasses | 1,482,822.96 ns |  43,995.9226 ns | 128,338.1713 ns | 1,432,406.69 ns | 138.6719 |  48.8281 |        - |  880064 B |
                List_Interfaces | 4,444,785.50 ns | 123,206.6773 ns | 363,277.6679 ns | 4,389,414.97 ns | 148.4375 |  85.9375 |  23.4375 |  960096 B |
             List_SimpleStructs |   200,412.97 ns |   3,970.8593 ns |   5,163.2388 ns |   200,499.28 ns |  56.4648 |  56.4648 |  56.4648 |  400497 B |
            List_ComplexStructs |   244,265.52 ns |   8,545.3421 ns |  25,196.1340 ns |   246,535.44 ns |  48.5205 |  48.5107 |  48.5107 |  400430 B |
            DictionaryOfStructs | 2,125,887.72 ns |  74,141.0288 ns | 218,606.4962 ns | 2,124,212.57 ns | 246.0547 | 178.3594 | 152.3047 | 1489772 B |
            DictionaryOfClasses | 5,209,795.31 ns | 195,569.0681 ns | 573,570.2224 ns | 5,225,975.04 ns | 226.5625 | 148.4375 |  46.8750 | 1403066 B |
                DictionaryOfInt |   455,393.01 ns |  14,403.0909 ns |  42,241.7722 ns |   455,383.96 ns |  40.0830 |  33.7354 |  33.7354 |  202440 B |
