
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


         Method |             Mean |          Error |           StdDev |    Gen 0 |    Gen 1 |    Gen 2 |   Allocated |
--------------- |-----------------:|---------------:|-----------------:|---------:|---------:|---------:|------------:|
            Int |         46.99 ns |       1.869 ns |         5.511 ns |   0.0038 |        - |        - |        24 B |
         String |         48.16 ns |       2.217 ns |         6.431 ns |        - |        - |        - |         0 B |
  ListOfStrings |        921.81 ns |      24.531 ns |        72.330 ns |   1.2798 |   0.0324 |        - |      8064 B |
    ListOfBytes | 46,312,418.25 ns | 920,969.296 ns | 2,489,894.045 ns | 250.0000 | 250.0000 | 250.0000 | 100000064 B |
     ListOfInts |        440.23 ns |       8.824 ns |        24.155 ns |   0.6447 |   0.0086 |        - |      4064 B |
 ListOfTimeSpan |        158.33 ns |       4.315 ns |        12.654 ns |   0.0226 |        - |        - |       144 B |
 ListOfDateTime |        157.87 ns |       3.772 ns |        11.122 ns |   0.0226 |        - |        - |       144 B |
 ListOfDelegate |        162.73 ns |       4.213 ns |        12.422 ns |   0.0226 |        - |        - |       144 B |
