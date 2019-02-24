
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


         Method |             Mean |           Error |          StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------- |-----------------:|----------------:|----------------:|------------:|------------:|------------:|--------------------:|
            Int |         24.56 ns |       0.0203 ns |       0.0190 ns |           - |           - |           - |                   - |
         String |         25.73 ns |       0.0176 ns |       0.0156 ns |           - |           - |           - |                   - |
  ListOfStrings |        714.72 ns |       0.6528 ns |       0.6106 ns |      1.2798 |      0.0334 |           - |              8064 B |
    ListOfBytes | 40,284,128.21 ns | 158,022.9561 ns | 147,814.7712 ns |    307.6923 |    307.6923 |    307.6923 |         100000064 B |
     ListOfInts |        328.83 ns |       0.4013 ns |       0.3754 ns |      0.6452 |      0.0086 |           - |              4064 B |
 ListOfTimeSpan |        102.47 ns |       0.0656 ns |       0.0581 ns |      0.0228 |           - |           - |               144 B |
 ListOfDateTime |        102.46 ns |       0.0892 ns |       0.0791 ns |      0.0228 |           - |           - |               144 B |
 ListOfDelegate |        106.99 ns |       0.0955 ns |       0.0893 ns |      0.0228 |           - |           - |               144 B |
