
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  24.48 ns | 0.0222 ns | 0.0207 ns |       0 B |
              Get_Prop_Struct |  23.76 ns | 0.0858 ns | 0.0716 ns |       0 B |
              Get_Field_Class |  23.95 ns | 0.1107 ns | 0.1035 ns |       0 B |
             Get_Field_Struct |  23.76 ns | 0.0158 ns | 0.0123 ns |       0 B |
               Set_Prop_Class |  13.82 ns | 0.0500 ns | 0.0467 ns |       0 B |
              Set_Prop_Struct |  13.73 ns | 0.0118 ns | 0.0111 ns |       0 B |
              Set_Field_Class |  13.45 ns | 0.0289 ns | 0.0271 ns |       0 B |
             Set_Field_Struct |  13.92 ns | 0.0087 ns | 0.0068 ns |       0 B |
   Set_Prop_WithConvert_Class | 151.50 ns | 0.0573 ns | 0.0508 ns |       0 B |
  Set_Prop_WithConvert_Struct | 151.71 ns | 0.1625 ns | 0.1520 ns |       0 B |
  Set_Field_WithConvert_Class | 151.07 ns | 0.1512 ns | 0.1340 ns |       0 B |
 Set_Field_WithConvert_Struct | 151.39 ns | 0.1308 ns | 0.1224 ns |       0 B |
