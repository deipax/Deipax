
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  24.25 ns | 0.0261 ns | 0.0244 ns |       0 B |
              Get_Prop_Struct |  24.01 ns | 0.0362 ns | 0.0321 ns |       0 B |
              Get_Field_Class |  23.76 ns | 0.0463 ns | 0.0411 ns |       0 B |
             Get_Field_Struct |  23.97 ns | 0.0461 ns | 0.0431 ns |       0 B |
               Set_Prop_Class |  13.60 ns | 0.0341 ns | 0.0319 ns |       0 B |
              Set_Prop_Struct |  13.81 ns | 0.0248 ns | 0.0232 ns |       0 B |
              Set_Field_Class |  14.17 ns | 0.0052 ns | 0.0041 ns |       0 B |
             Set_Field_Struct |  13.63 ns | 0.0164 ns | 0.0146 ns |       0 B |
   Set_Prop_WithConvert_Class | 677.20 ns | 0.5995 ns | 0.5607 ns |       0 B |
  Set_Prop_WithConvert_Struct | 720.02 ns | 1.3075 ns | 1.2230 ns |       0 B |
  Set_Field_WithConvert_Class | 678.96 ns | 0.7966 ns | 0.7451 ns |       0 B |
 Set_Field_WithConvert_Struct | 680.14 ns | 1.1215 ns | 0.9941 ns |       0 B |
