
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  34.66 ns | 0.1523 ns | 0.1425 ns |      - |       0 B |
              Get_Prop_Struct |  85.67 ns | 1.8413 ns | 3.0254 ns | 0.1239 |     520 B |
              Get_Field_Class |  35.57 ns | 0.3920 ns | 0.3274 ns |      - |       0 B |
             Get_Field_Struct |  84.42 ns | 1.2245 ns | 1.1454 ns | 0.1239 |     520 B |
               Set_Prop_Class |  82.32 ns | 0.4659 ns | 0.4130 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 134.11 ns | 2.2519 ns | 1.9962 ns | 0.1295 |     544 B |
              Set_Field_Class |  81.41 ns | 0.7589 ns | 0.6727 ns | 0.0056 |      24 B |
             Set_Field_Struct | 132.04 ns | 0.5011 ns | 0.3912 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 165.21 ns | 2.3284 ns | 2.1780 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 220.29 ns | 3.1238 ns | 2.9220 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 161.29 ns | 0.3216 ns | 0.2685 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 217.65 ns | 2.1617 ns | 1.9163 ns | 0.1237 |     520 B |
