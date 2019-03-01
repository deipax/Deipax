
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


              Method |       Mean |      Error |     StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
-------------------- |-----------:|-----------:|-----------:|------------:|------------:|------------:|--------------------:|
            IntArray |   132.7 ns |  0.7142 ns |  0.6680 ns |      0.0100 |           - |           - |                64 B |
           ByteArray |   173.1 ns |  0.8988 ns |  0.8407 ns |      0.1626 |           - |           - |              1024 B |
         StringArray |   128.2 ns |  0.6726 ns |  0.6291 ns |      0.0165 |           - |           - |               104 B |
       TimeSpanArray |   191.6 ns |  0.9424 ns |  0.8815 ns |      0.0165 |           - |           - |               104 B |
       DateTimeArray |   163.5 ns |  0.9474 ns |  0.8862 ns |      0.0165 |           - |           - |               104 B |
       DelegateArray |   542.6 ns |  3.8088 ns |  3.5627 ns |      0.0257 |           - |           - |               168 B |
 ArrayOfStringArrays |   426.7 ns |  1.6073 ns |  1.5034 ns |      0.0186 |           - |           - |               120 B |
      ArrayOfClasses | 4,347.4 ns | 22.4506 ns | 21.0003 ns |      1.0147 |      0.0153 |           - |              6424 B |
       ArrayOfStruct |   369.7 ns |  1.9914 ns |  1.8628 ns |      0.6390 |           - |           - |              4025 B |
