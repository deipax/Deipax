
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


         Method |             Mean |            Error |           StdDev |    Gen 0 |    Gen 1 |    Gen 2 |   Allocated |
--------------- |-----------------:|-----------------:|-----------------:|---------:|---------:|---------:|------------:|
            Int |         44.94 ns |         1.487 ns |         4.362 ns |   0.0038 |        - |        - |        24 B |
         String |         40.71 ns |         1.027 ns |         2.965 ns |        - |        - |        - |         0 B |
  ListOfStrings |      1,032.37 ns |        28.149 ns |        82.113 ns |   1.2798 |   0.0324 |        - |      8064 B |
    ListOfBytes | 48,066,601.15 ns | 1,024,290.861 ns | 3,004,067.784 ns | 250.0000 | 250.0000 | 250.0000 | 100000064 B |
     ListOfInts |        547.72 ns |        15.773 ns |        45.254 ns |   0.6447 |   0.0086 |        - |      4064 B |
 ListOfTimeSpan |        155.87 ns |         3.177 ns |         9.366 ns |   0.0226 |        - |        - |       144 B |
 ListOfDateTime |        159.95 ns |         3.259 ns |         9.608 ns |   0.0226 |        - |        - |       144 B |
 ListOfDelegate |        162.69 ns |         3.270 ns |         8.500 ns |   0.0226 |        - |        - |       144 B |
