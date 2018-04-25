
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  35.33 ns | 0.0728 ns | 0.0681 ns |      - |       0 B |
              Get_Prop_Struct |  85.01 ns | 0.2285 ns | 0.2026 ns | 0.1239 |     520 B |
              Get_Field_Class |  34.98 ns | 0.0756 ns | 0.0631 ns |      - |       0 B |
             Get_Field_Struct |  85.32 ns | 0.2997 ns | 0.2502 ns | 0.1239 |     520 B |
               Set_Prop_Class |  79.45 ns | 0.3726 ns | 0.3303 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 132.54 ns | 1.0058 ns | 0.8916 ns | 0.1295 |     544 B |
              Set_Field_Class |  81.63 ns | 0.0280 ns | 0.0262 ns | 0.0056 |      24 B |
             Set_Field_Struct | 130.77 ns | 0.3301 ns | 0.2387 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 112.54 ns | 0.0291 ns | 0.0243 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 164.29 ns | 0.4326 ns | 0.4046 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 111.87 ns | 0.0571 ns | 0.0477 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 164.84 ns | 0.7163 ns | 0.6700 ns | 0.1237 |     520 B |
