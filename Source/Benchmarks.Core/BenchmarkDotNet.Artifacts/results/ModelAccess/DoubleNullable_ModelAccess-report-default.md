
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  23.58 ns | 0.0228 ns | 0.0202 ns |       0 B |
              Get_Prop_Struct |  24.38 ns | 0.0437 ns | 0.0409 ns |       0 B |
              Get_Field_Class |  23.59 ns | 0.0374 ns | 0.0350 ns |       0 B |
             Get_Field_Struct |  23.87 ns | 0.0516 ns | 0.0458 ns |       0 B |
               Set_Prop_Class |  13.55 ns | 0.0079 ns | 0.0066 ns |       0 B |
              Set_Prop_Struct |  13.60 ns | 0.0270 ns | 0.0253 ns |       0 B |
              Set_Field_Class |  14.02 ns | 0.0113 ns | 0.0100 ns |       0 B |
             Set_Field_Struct |  13.81 ns | 0.0176 ns | 0.0165 ns |       0 B |
   Set_Prop_WithConvert_Class | 163.21 ns | 0.1348 ns | 0.1195 ns |       0 B |
  Set_Prop_WithConvert_Struct | 164.00 ns | 0.3384 ns | 0.3165 ns |       0 B |
  Set_Field_WithConvert_Class | 161.30 ns | 0.1470 ns | 0.1303 ns |       0 B |
 Set_Field_WithConvert_Struct | 162.90 ns | 0.2277 ns | 0.2130 ns |       0 B |
