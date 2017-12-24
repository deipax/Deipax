
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


         Method |             Mean |             Error |           StdDev |    Gen 0 |    Gen 1 |    Gen 2 |   Allocated |
--------------- |-----------------:|------------------:|-----------------:|---------:|---------:|---------:|------------:|
            Int |         42.15 ns |         0.9607 ns |         2.833 ns |   0.0038 |        - |        - |        24 B |
         String |         39.33 ns |         0.8199 ns |         2.258 ns |        - |        - |        - |         0 B |
  ListOfStrings |      1,113.30 ns |        24.5285 ns |        72.323 ns |   1.3103 |   0.0343 |        - |      8256 B |
    ListOfBytes | 49,182,033.37 ns | 1,115,596.9666 ns | 3,289,362.827 ns | 250.0000 | 250.0000 | 250.0000 | 100000064 B |
     ListOfInts |        560.72 ns |        15.5533 ns |        45.859 ns |   0.6599 |   0.0086 |        - |      4160 B |
 ListOfTimeSpan |        225.81 ns |         6.9857 ns |        20.598 ns |   0.0300 |        - |        - |       192 B |
 ListOfDateTime |        221.76 ns |         4.4631 ns |        11.441 ns |   0.0303 |        - |        - |       192 B |
 ListOfDelegate |        716.95 ns |        16.5201 ns |        48.710 ns |   0.0401 |        - |        - |       256 B |
