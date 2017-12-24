
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                         Method |            Mean |           Error |         StdDev |          Median |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
------------------------------- |----------------:|----------------:|---------------:|----------------:|---------:|---------:|---------:|----------:|
                    SimpleClass |       120.57 ns |       2.4392 ns |       6.880 ns |       119.61 ns |   0.0088 |        - |        - |      56 B |
                   ComplexClass |       182.33 ns |       4.1824 ns |      12.200 ns |       182.22 ns |   0.0126 |        - |        - |      80 B |
              InheritList_Class | 2,048,966.03 ns |  49,190.9337 ns | 145,040.578 ns | 2,044,046.95 ns | 110.6250 |  72.6172 |  26.9922 |  691192 B |
                InheritList_Int |        31.15 ns |       0.7299 ns |       2.094 ns |        30.58 ns |        - |        - |        - |       0 B |
                           Null |        34.21 ns |       0.7433 ns |       2.168 ns |        34.06 ns |        - |        - |        - |       0 B |
           GrandChildClass_Test |       152.61 ns |       3.3897 ns |       9.780 ns |       149.78 ns |   0.0520 |        - |        - |     328 B |
             List_SimpleClasses |   743,187.12 ns |  17,202.5193 ns |  50,452.011 ns |   732,252.80 ns | 100.5859 |  41.0156 |        - |  640064 B |
 List_SimpleClasses_AsInterface | 1,120,504.19 ns |  31,047.9876 ns |  91,545.692 ns | 1,120,131.12 ns |  99.6094 |  41.0156 |        - |  640064 B |
   List_SimpleClasses_AsObjects |   993,270.09 ns |  26,086.7910 ns |  76,096.394 ns |   981,222.02 ns | 100.5859 |  41.0156 |        - |  640064 B |
            List_ComplexClasses | 1,474,119.75 ns |  35,839.0518 ns | 105,672.253 ns | 1,451,446.23 ns | 138.6719 |  48.8281 |        - |  880064 B |
                List_Interfaces | 4,781,659.37 ns | 108,316.5256 ns | 317,673.619 ns | 4,789,769.38 ns | 148.4375 |  85.9375 |  23.4375 |  960086 B |
             List_SimpleStructs |   283,423.50 ns |   6,935.8709 ns |  20,450.572 ns |   281,848.94 ns |  52.8564 |  52.8564 |  52.8564 |  400461 B |
            List_ComplexStructs |   268,481.01 ns |  10,760.4540 ns |  31,727.441 ns |   268,541.05 ns |  47.7962 |  47.7937 |  47.7937 |  400423 B |
            DictionaryOfStructs | 2,205,255.99 ns |  53,496.0069 ns | 157,734.183 ns | 2,202,692.59 ns | 246.0547 | 178.5547 | 152.3047 | 1489757 B |
            DictionaryOfClasses | 5,406,415.99 ns | 148,409.1638 ns | 437,587.768 ns | 5,458,475.90 ns | 226.5625 | 148.4375 |  46.8750 | 1403061 B |
                DictionaryOfInt |   377,560.04 ns |   8,012.5465 ns |  23,118.029 ns |   378,295.30 ns |  38.6035 |  32.2998 |  32.2559 |  202422 B |
