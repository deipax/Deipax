
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  23.96 ns | 0.0392 ns | 0.0366 ns |       0 B |
              Get_Prop_Struct |  24.09 ns | 0.0226 ns | 0.0211 ns |       0 B |
              Get_Field_Class |  23.62 ns | 0.0274 ns | 0.0256 ns |       0 B |
             Get_Field_Struct |  23.67 ns | 0.0457 ns | 0.0428 ns |       0 B |
               Set_Prop_Class |  13.63 ns | 0.0908 ns | 0.0850 ns |       0 B |
              Set_Prop_Struct |  13.50 ns | 0.0124 ns | 0.0110 ns |       0 B |
              Set_Field_Class |  14.37 ns | 0.0188 ns | 0.0157 ns |       0 B |
             Set_Field_Struct |  13.46 ns | 0.0178 ns | 0.0167 ns |       0 B |
   Set_Prop_WithConvert_Class | 139.33 ns | 0.4312 ns | 0.3601 ns |       0 B |
  Set_Prop_WithConvert_Struct | 138.86 ns | 0.4454 ns | 0.4166 ns |       0 B |
  Set_Field_WithConvert_Class | 141.15 ns | 0.5757 ns | 0.5385 ns |       0 B |
 Set_Field_WithConvert_Struct | 139.66 ns | 0.4109 ns | 0.3843 ns |       0 B |
