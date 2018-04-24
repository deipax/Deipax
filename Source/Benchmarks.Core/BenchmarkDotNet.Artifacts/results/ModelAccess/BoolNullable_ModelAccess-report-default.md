
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  34.39 ns | 0.4765 ns | 0.4457 ns |      - |       0 B |
              Get_Prop_Struct |  90.18 ns | 1.8252 ns | 1.9530 ns | 0.1239 |     520 B |
              Get_Field_Class |  35.22 ns | 0.6293 ns | 0.5579 ns |      - |       0 B |
             Get_Field_Struct |  87.22 ns | 1.3382 ns | 1.2518 ns | 0.1239 |     520 B |
               Set_Prop_Class |  80.61 ns | 0.7378 ns | 0.6161 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 135.38 ns | 2.7273 ns | 4.6311 ns | 0.1295 |     544 B |
              Set_Field_Class |  79.73 ns | 0.2268 ns | 0.1771 ns | 0.0056 |      24 B |
             Set_Field_Struct | 130.67 ns | 0.2217 ns | 0.1731 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class |  35.91 ns | 0.0195 ns | 0.0152 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct |  87.42 ns | 0.5010 ns | 0.4441 ns | 0.1239 |     520 B |
  Set_Field_WithConvert_Class |  36.95 ns | 0.0831 ns | 0.0777 ns |      - |       0 B |
 Set_Field_WithConvert_Struct |  87.19 ns | 0.6647 ns | 0.6217 ns | 0.1239 |     520 B |
