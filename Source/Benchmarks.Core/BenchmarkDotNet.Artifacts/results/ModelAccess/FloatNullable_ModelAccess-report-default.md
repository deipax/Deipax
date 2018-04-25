
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  23.80 ns | 0.0271 ns | 0.0254 ns |       0 B |
              Get_Prop_Struct |  23.96 ns | 0.0331 ns | 0.0310 ns |       0 B |
              Get_Field_Class |  24.67 ns | 0.0526 ns | 0.0439 ns |       0 B |
             Get_Field_Struct |  23.96 ns | 0.0586 ns | 0.0519 ns |       0 B |
               Set_Prop_Class |  13.03 ns | 0.0145 ns | 0.0128 ns |       0 B |
              Set_Prop_Struct |  13.04 ns | 0.0185 ns | 0.0173 ns |       0 B |
              Set_Field_Class |  12.91 ns | 0.0267 ns | 0.0237 ns |       0 B |
             Set_Field_Struct |  13.30 ns | 0.0234 ns | 0.0219 ns |       0 B |
   Set_Prop_WithConvert_Class | 156.41 ns | 0.2666 ns | 0.2494 ns |       0 B |
  Set_Prop_WithConvert_Struct | 156.70 ns | 0.1726 ns | 0.1614 ns |       0 B |
  Set_Field_WithConvert_Class | 155.93 ns | 0.1567 ns | 0.1309 ns |       0 B |
 Set_Field_WithConvert_Struct | 156.31 ns | 0.2478 ns | 0.2197 ns |       0 B |
