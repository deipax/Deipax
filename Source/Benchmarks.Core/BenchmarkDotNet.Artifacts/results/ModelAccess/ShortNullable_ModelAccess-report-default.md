
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  23.72 ns | 0.0310 ns | 0.0242 ns |       0 B |
              Get_Prop_Struct |  23.91 ns | 0.0367 ns | 0.0343 ns |       0 B |
              Get_Field_Class |  23.63 ns | 0.0293 ns | 0.0274 ns |       0 B |
             Get_Field_Struct |  24.04 ns | 0.0225 ns | 0.0199 ns |       0 B |
               Set_Prop_Class |  12.88 ns | 0.0312 ns | 0.0291 ns |       0 B |
              Set_Prop_Struct |  13.29 ns | 0.0295 ns | 0.0247 ns |       0 B |
              Set_Field_Class |  13.55 ns | 0.0277 ns | 0.0259 ns |       0 B |
             Set_Field_Struct |  13.22 ns | 0.0172 ns | 0.0153 ns |       0 B |
   Set_Prop_WithConvert_Class | 112.85 ns | 0.2629 ns | 0.2459 ns |       0 B |
  Set_Prop_WithConvert_Struct | 113.40 ns | 0.0755 ns | 0.0630 ns |       0 B |
  Set_Field_WithConvert_Class | 112.07 ns | 0.1194 ns | 0.1058 ns |       0 B |
 Set_Field_WithConvert_Struct | 114.85 ns | 0.2845 ns | 0.2661 ns |       0 B |
