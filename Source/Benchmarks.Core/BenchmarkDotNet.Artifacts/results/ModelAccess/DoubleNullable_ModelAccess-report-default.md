
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  24.07 ns | 0.0490 ns | 0.0458 ns |       0 B |
              Get_Prop_Struct |  25.02 ns | 0.0180 ns | 0.0169 ns |       0 B |
              Get_Field_Class |  25.02 ns | 0.0917 ns | 0.0858 ns |       0 B |
             Get_Field_Struct |  23.82 ns | 0.0239 ns | 0.0212 ns |       0 B |
               Set_Prop_Class |  13.64 ns | 0.0589 ns | 0.0522 ns |       0 B |
              Set_Prop_Struct |  13.62 ns | 0.0151 ns | 0.0126 ns |       0 B |
              Set_Field_Class |  13.56 ns | 0.0108 ns | 0.0090 ns |       0 B |
             Set_Field_Struct |  14.70 ns | 0.0154 ns | 0.0136 ns |       0 B |
   Set_Prop_WithConvert_Class | 161.31 ns | 0.4438 ns | 0.4152 ns |       0 B |
  Set_Prop_WithConvert_Struct | 160.65 ns | 0.3485 ns | 0.3260 ns |       0 B |
  Set_Field_WithConvert_Class | 163.41 ns | 0.4321 ns | 0.4042 ns |       0 B |
 Set_Field_WithConvert_Struct | 164.70 ns | 0.4041 ns | 0.3780 ns |       0 B |
