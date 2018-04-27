
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  23.57 ns | 0.0167 ns | 0.0157 ns |       0 B |
              Get_Prop_Struct |  23.80 ns | 0.0165 ns | 0.0146 ns |       0 B |
              Get_Field_Class |  24.15 ns | 0.0162 ns | 0.0152 ns |       0 B |
             Get_Field_Struct |  24.12 ns | 0.4427 ns | 0.4141 ns |       0 B |
               Set_Prop_Class |  15.83 ns | 0.0132 ns | 0.0110 ns |       0 B |
              Set_Prop_Struct |  16.33 ns | 0.0177 ns | 0.0165 ns |       0 B |
              Set_Field_Class |  15.45 ns | 0.0153 ns | 0.0136 ns |       0 B |
             Set_Field_Struct |  15.33 ns | 0.0330 ns | 0.0308 ns |       0 B |
   Set_Prop_WithConvert_Class | 659.06 ns | 0.3419 ns | 0.3198 ns |       0 B |
  Set_Prop_WithConvert_Struct | 659.89 ns | 0.1675 ns | 0.1485 ns |       0 B |
  Set_Field_WithConvert_Class | 660.34 ns | 0.2794 ns | 0.2614 ns |       0 B |
 Set_Field_WithConvert_Struct | 657.22 ns | 0.3906 ns | 0.3654 ns |       0 B |
