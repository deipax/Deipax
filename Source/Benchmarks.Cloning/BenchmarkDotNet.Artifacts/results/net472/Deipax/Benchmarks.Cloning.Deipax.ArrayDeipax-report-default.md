
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


              Method |       Mean |      Error |     StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
-------------------- |-----------:|-----------:|-----------:|------------:|------------:|------------:|--------------------:|
            IntArray |   144.3 ns |  1.0856 ns |  1.0155 ns |      0.0100 |           - |           - |                64 B |
           ByteArray |   186.1 ns |  0.7588 ns |  0.7098 ns |      0.1626 |           - |           - |              1024 B |
         StringArray |   141.6 ns |  0.7008 ns |  0.6555 ns |      0.0165 |           - |           - |               104 B |
       TimeSpanArray |   179.0 ns |  0.9717 ns |  0.9089 ns |      0.0165 |           - |           - |               104 B |
       DateTimeArray |   177.2 ns |  0.7929 ns |  0.7417 ns |      0.0165 |           - |           - |               104 B |
       DelegateArray |   219.0 ns |  2.4045 ns |  2.2492 ns |      0.0165 |           - |           - |               104 B |
 ArrayOfStringArrays |   390.9 ns |  2.4551 ns |  2.2965 ns |      0.0186 |           - |           - |               120 B |
      ArrayOfClasses | 5,822.5 ns | 33.6901 ns | 31.5137 ns |      1.0147 |      0.0153 |           - |              6424 B |
       ArrayOfStruct |   385.5 ns |  2.0545 ns |  1.9218 ns |      0.6390 |           - |           - |              4025 B |
