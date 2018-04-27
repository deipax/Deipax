
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  24.80 ns | 0.0198 ns | 0.0186 ns |       0 B |
              Get_Prop_Struct |  23.87 ns | 0.0436 ns | 0.0408 ns |       0 B |
              Get_Field_Class |  23.74 ns | 0.0350 ns | 0.0327 ns |       0 B |
             Get_Field_Struct |  23.94 ns | 0.0841 ns | 0.0786 ns |       0 B |
               Set_Prop_Class |  14.13 ns | 0.0428 ns | 0.0401 ns |       0 B |
              Set_Prop_Struct |  13.56 ns | 0.0020 ns | 0.0017 ns |       0 B |
              Set_Field_Class |  13.65 ns | 0.0023 ns | 0.0018 ns |       0 B |
             Set_Field_Struct |  13.57 ns | 0.0088 ns | 0.0078 ns |       0 B |
   Set_Prop_WithConvert_Class | 795.86 ns | 0.4120 ns | 0.3854 ns |       0 B |
  Set_Prop_WithConvert_Struct | 808.87 ns | 0.5337 ns | 0.4731 ns |       0 B |
  Set_Field_WithConvert_Class | 795.64 ns | 0.3370 ns | 0.2987 ns |       0 B |
 Set_Field_WithConvert_Struct | 799.02 ns | 0.4566 ns | 0.4271 ns |       0 B |
