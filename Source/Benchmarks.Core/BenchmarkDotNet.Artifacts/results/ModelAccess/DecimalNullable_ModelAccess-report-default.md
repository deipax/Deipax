
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  36.15 ns | 0.0786 ns | 0.0736 ns |      - |       0 B |
              Get_Prop_Struct |  85.76 ns | 0.1483 ns | 0.1387 ns | 0.1239 |     520 B |
              Get_Field_Class |  36.13 ns | 0.0598 ns | 0.0560 ns |      - |       0 B |
             Get_Field_Struct |  85.34 ns | 0.1084 ns | 0.0905 ns | 0.1239 |     520 B |
               Set_Prop_Class |  85.83 ns | 0.0405 ns | 0.0379 ns | 0.0075 |      32 B |
              Set_Prop_Struct | 136.54 ns | 0.2058 ns | 0.1719 ns | 0.1314 |     552 B |
              Set_Field_Class |  85.56 ns | 0.0303 ns | 0.0253 ns | 0.0075 |      32 B |
             Set_Field_Struct | 134.53 ns | 0.2987 ns | 0.2494 ns | 0.1314 |     552 B |
   Set_Prop_WithConvert_Class | 660.43 ns | 0.3691 ns | 0.3272 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 714.94 ns | 0.2620 ns | 0.2188 ns | 0.1230 |     520 B |
  Set_Field_WithConvert_Class | 655.74 ns | 0.1679 ns | 0.1402 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 715.71 ns | 0.9109 ns | 0.7606 ns | 0.1230 |     520 B |
