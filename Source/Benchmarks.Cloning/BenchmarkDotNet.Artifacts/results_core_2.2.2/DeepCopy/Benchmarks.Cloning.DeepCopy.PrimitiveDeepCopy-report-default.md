
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


         Method |             Mean |          Error |         StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------- |-----------------:|---------------:|---------------:|------------:|------------:|------------:|--------------------:|
            Int |         25.35 ns |      0.0149 ns |      0.0139 ns |           - |           - |           - |                   - |
         String |         23.69 ns |      0.0121 ns |      0.0114 ns |           - |           - |           - |                   - |
  ListOfStrings |        770.84 ns |      0.6913 ns |      0.5773 ns |      1.3123 |      0.0353 |           - |              8256 B |
    ListOfBytes | 40,107,232.97 ns | 62,725.9596 ns | 55,604.9294 ns |    307.6923 |    307.6923 |    307.6923 |         100000064 B |
     ListOfInts |        374.71 ns |      0.2214 ns |      0.1963 ns |      0.6609 |      0.0091 |           - |              4160 B |
 ListOfTimeSpan |        141.51 ns |      0.1079 ns |      0.1010 ns |      0.0303 |           - |           - |               192 B |
 ListOfDateTime |        148.53 ns |      0.3566 ns |      0.3336 ns |      0.0303 |           - |           - |               192 B |
 ListOfDelegate |        440.80 ns |      0.2368 ns |      0.2099 ns |      0.0405 |           - |           - |               256 B |
