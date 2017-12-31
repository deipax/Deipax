
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


         Method |             Mean |           Error |            StdDev |           Median |    Gen 0 |    Gen 1 |    Gen 2 |   Allocated |
--------------- |-----------------:|----------------:|------------------:|-----------------:|---------:|---------:|---------:|------------:|
            Int |         38.25 ns |       0.9652 ns |         2.0147 ns |         38.57 ns |   0.0038 |        - |        - |        24 B |
         String |         35.50 ns |       0.7479 ns |         1.9037 ns |         35.36 ns |        - |        - |        - |         0 B |
  ListOfStrings |        996.02 ns |      25.5617 ns |        74.5647 ns |        975.94 ns |   1.3103 |   0.0343 |        - |      8256 B |
    ListOfBytes | 48,398,991.34 ns | 963,711.6966 ns | 2,399,976.5482 ns | 48,169,125.31 ns | 250.0000 | 250.0000 | 250.0000 | 100000064 B |
     ListOfInts |        503.21 ns |      12.3835 ns |        36.5130 ns |        497.16 ns |   0.6599 |   0.0086 |        - |      4160 B |
 ListOfTimeSpan |        208.81 ns |       4.5419 ns |         9.0708 ns |        203.32 ns |   0.0303 |        - |        - |       192 B |
 ListOfDateTime |        197.91 ns |       0.8249 ns |         0.6888 ns |        197.87 ns |   0.0303 |        - |        - |       192 B |
 ListOfDelegate |        642.17 ns |      12.8526 ns |        35.8279 ns |        628.14 ns |   0.0401 |        - |        - |       256 B |
