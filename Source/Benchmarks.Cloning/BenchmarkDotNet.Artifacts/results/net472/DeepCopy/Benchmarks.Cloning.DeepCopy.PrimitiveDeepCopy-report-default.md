
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


         Method |             Mean |           Error |          StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------- |-----------------:|----------------:|----------------:|------------:|------------:|------------:|--------------------:|
            Int |         28.19 ns |       0.1822 ns |       0.1704 ns |      0.0038 |           - |           - |                24 B |
         String |         30.75 ns |       0.1882 ns |       0.1760 ns |           - |           - |           - |                   - |
  ListOfStrings |        859.46 ns |       6.7889 ns |       6.3503 ns |      1.3123 |      0.0353 |           - |              8262 B |
    ListOfBytes | 34,930,073.33 ns | 275,019.0072 ns | 257,252.9499 ns |    133.3333 |    133.3333 |    133.3333 |         100001127 B |
     ListOfInts |        395.21 ns |       1.7227 ns |       1.6114 ns |      0.6609 |      0.0091 |           - |              4161 B |
 ListOfTimeSpan |        225.37 ns |       3.5827 ns |       3.1759 ns |      0.0303 |           - |           - |               192 B |
 ListOfDateTime |        205.55 ns |       1.1779 ns |       1.1018 ns |      0.0303 |           - |           - |               192 B |
 ListOfDelegate |        598.05 ns |       3.8631 ns |       3.6135 ns |      0.0401 |           - |           - |               256 B |
