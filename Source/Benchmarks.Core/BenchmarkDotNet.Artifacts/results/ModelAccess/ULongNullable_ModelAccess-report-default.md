
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  34.99 ns | 0.1131 ns | 0.1058 ns |      - |       0 B |
              Get_Prop_Struct |  82.83 ns | 0.3498 ns | 0.3101 ns | 0.1239 |     520 B |
              Get_Field_Class |  34.06 ns | 0.0435 ns | 0.0386 ns |      - |       0 B |
             Get_Field_Struct |  82.96 ns | 0.0624 ns | 0.0553 ns | 0.1239 |     520 B |
               Set_Prop_Class |  81.04 ns | 0.0762 ns | 0.0676 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 131.02 ns | 0.3347 ns | 0.3131 ns | 0.1295 |     544 B |
              Set_Field_Class |  80.73 ns | 0.3423 ns | 0.3202 ns | 0.0056 |      24 B |
             Set_Field_Struct | 132.01 ns | 0.3052 ns | 0.2706 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 209.56 ns | 0.1114 ns | 0.0931 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 258.64 ns | 0.2625 ns | 0.2192 ns | 0.1235 |     520 B |
  Set_Field_WithConvert_Class | 209.45 ns | 0.2134 ns | 0.1996 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 260.63 ns | 0.7103 ns | 0.6644 ns | 0.1235 |     520 B |
