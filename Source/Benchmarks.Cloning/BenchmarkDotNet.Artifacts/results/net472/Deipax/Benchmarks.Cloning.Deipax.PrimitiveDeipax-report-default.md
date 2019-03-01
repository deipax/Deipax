
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


         Method |             Mean |           Error |          StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------- |-----------------:|----------------:|----------------:|------------:|------------:|------------:|--------------------:|
            Int |         28.41 ns |       0.1895 ns |       0.1773 ns |      0.0038 |           - |           - |                24 B |
         String |         27.92 ns |       0.1215 ns |       0.1136 ns |           - |           - |           - |                   - |
  ListOfStrings |        801.47 ns |       5.1948 ns |       4.8592 ns |      1.2798 |      0.0334 |           - |              8066 B |
    ListOfBytes | 34,887,381.33 ns | 223,488.1279 ns | 209,050.9335 ns |    133.3333 |    133.3333 |    133.3333 |         100001127 B |
     ListOfInts |        348.17 ns |       1.5824 ns |       1.4802 ns |      0.6452 |      0.0086 |           - |              4064 B |
 ListOfTimeSpan |        124.46 ns |       0.8206 ns |       0.7676 ns |      0.0226 |           - |           - |               144 B |
 ListOfDateTime |        121.81 ns |       1.1604 ns |       1.0854 ns |      0.0226 |           - |           - |               144 B |
 ListOfDelegate |        125.09 ns |       0.8712 ns |       0.8150 ns |      0.0226 |           - |           - |               144 B |
