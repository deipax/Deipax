
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  26.92 ns | 0.0160 ns | 0.0150 ns |       0 B |
              Get_Prop_Struct |  23.70 ns | 0.0362 ns | 0.0321 ns |       0 B |
              Get_Field_Class |  23.60 ns | 0.0508 ns | 0.0475 ns |       0 B |
             Get_Field_Struct |  23.89 ns | 0.0180 ns | 0.0168 ns |       0 B |
               Set_Prop_Class |  13.37 ns | 0.0091 ns | 0.0071 ns |       0 B |
              Set_Prop_Struct |  13.37 ns | 0.0174 ns | 0.0136 ns |       0 B |
              Set_Field_Class |  13.40 ns | 0.0127 ns | 0.0119 ns |       0 B |
             Set_Field_Struct |  13.37 ns | 0.0290 ns | 0.0272 ns |       0 B |
   Set_Prop_WithConvert_Class | 109.61 ns | 0.0527 ns | 0.0467 ns |       0 B |
  Set_Prop_WithConvert_Struct | 110.98 ns | 0.0496 ns | 0.0440 ns |       0 B |
  Set_Field_WithConvert_Class | 109.94 ns | 0.0635 ns | 0.0594 ns |       0 B |
 Set_Field_WithConvert_Struct | 111.77 ns | 0.0681 ns | 0.0637 ns |       0 B |
