
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


              Method |        Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
-------------------- |------------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
            IntArray |    93.64 ns | 0.7002 ns | 0.6550 ns |      0.0101 |           - |           - |                64 B |
           ByteArray |   147.47 ns | 0.1643 ns | 0.1537 ns |      0.1626 |           - |           - |              1024 B |
         StringArray |   102.12 ns | 0.0948 ns | 0.0887 ns |      0.0165 |           - |           - |               104 B |
       TimeSpanArray |    95.44 ns | 0.0760 ns | 0.0711 ns |      0.0165 |           - |           - |               104 B |
       DateTimeArray |    93.42 ns | 0.4711 ns | 0.4406 ns |      0.0165 |           - |           - |               104 B |
       DelegateArray |   430.96 ns | 0.7644 ns | 0.7150 ns |      0.0262 |           - |           - |               168 B |
 ArrayOfStringArrays |   256.93 ns | 0.3551 ns | 0.3322 ns |      0.0186 |           - |           - |               120 B |
      ArrayOfClasses | 4,287.01 ns | 2.5622 ns | 2.3967 ns |      1.0147 |      0.0153 |           - |              6424 B |
       ArrayOfStruct |   322.23 ns | 0.3064 ns | 0.2866 ns |      0.6390 |           - |           - |              4024 B |
