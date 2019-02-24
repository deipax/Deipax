
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


              Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
-------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
            IntArray |   100.9 ns | 0.1153 ns | 0.1079 ns |      0.0101 |           - |           - |                64 B |
           ByteArray |   173.9 ns | 0.2419 ns | 0.2262 ns |      0.1626 |           - |           - |              1024 B |
         StringArray |   102.8 ns | 0.1409 ns | 0.1176 ns |      0.0165 |           - |           - |               104 B |
       TimeSpanArray |   102.4 ns | 0.0451 ns | 0.0422 ns |      0.0165 |           - |           - |               104 B |
       DateTimeArray |   100.2 ns | 0.0986 ns | 0.0922 ns |      0.0165 |           - |           - |               104 B |
       DelegateArray |   106.3 ns | 0.1066 ns | 0.0997 ns |      0.0165 |           - |           - |               104 B |
 ArrayOfStringArrays |   218.5 ns | 0.2621 ns | 0.2452 ns |      0.0188 |           - |           - |               120 B |
      ArrayOfClasses | 4,325.5 ns | 3.7445 ns | 3.1268 ns |      1.0147 |      0.0153 |           - |              6424 B |
       ArrayOfStruct |   332.8 ns | 1.4391 ns | 1.3461 ns |      0.6390 |           - |           - |              4024 B |
