
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  23.74 ns | 0.0400 ns | 0.0374 ns |       0 B |
              Get_Prop_Struct |  24.03 ns | 0.0496 ns | 0.0464 ns |       0 B |
              Get_Field_Class |  23.94 ns | 0.0607 ns | 0.0568 ns |       0 B |
             Get_Field_Struct |  25.16 ns | 0.0355 ns | 0.0332 ns |       0 B |
               Set_Prop_Class |  13.55 ns | 0.0230 ns | 0.0204 ns |       0 B |
              Set_Prop_Struct |  14.46 ns | 0.0106 ns | 0.0088 ns |       0 B |
              Set_Field_Class |  13.54 ns | 0.0107 ns | 0.0090 ns |       0 B |
             Set_Field_Struct |  13.77 ns | 0.0264 ns | 0.0234 ns |       0 B |
   Set_Prop_WithConvert_Class | 191.52 ns | 0.2127 ns | 0.1990 ns |       0 B |
  Set_Prop_WithConvert_Struct | 191.66 ns | 0.3553 ns | 0.3323 ns |       0 B |
  Set_Field_WithConvert_Class | 191.62 ns | 0.2506 ns | 0.2344 ns |       0 B |
 Set_Field_WithConvert_Struct | 192.36 ns | 0.1898 ns | 0.1683 ns |       0 B |
