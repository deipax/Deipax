
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  23.56 ns | 0.0378 ns | 0.0354 ns |       0 B |
              Get_Prop_Struct |  23.89 ns | 0.0219 ns | 0.0194 ns |       0 B |
              Get_Field_Class |  23.67 ns | 0.0259 ns | 0.0230 ns |       0 B |
             Get_Field_Struct |  24.32 ns | 0.0431 ns | 0.0360 ns |       0 B |
               Set_Prop_Class |  13.18 ns | 0.0119 ns | 0.0093 ns |       0 B |
              Set_Prop_Struct |  12.99 ns | 0.0217 ns | 0.0203 ns |       0 B |
              Set_Field_Class |  13.04 ns | 0.0067 ns | 0.0063 ns |       0 B |
             Set_Field_Struct |  13.05 ns | 0.0279 ns | 0.0261 ns |       0 B |
   Set_Prop_WithConvert_Class | 143.86 ns | 0.3389 ns | 0.3170 ns |       0 B |
  Set_Prop_WithConvert_Struct | 145.57 ns | 0.4996 ns | 0.4429 ns |       0 B |
  Set_Field_WithConvert_Class | 143.79 ns | 0.3474 ns | 0.2901 ns |       0 B |
 Set_Field_WithConvert_Struct | 145.78 ns | 0.2771 ns | 0.2592 ns |       0 B |
