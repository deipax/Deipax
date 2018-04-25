
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  23.82 ns | 0.0470 ns | 0.0440 ns |       0 B |
              Get_Prop_Struct |  24.43 ns | 0.0363 ns | 0.0339 ns |       0 B |
              Get_Field_Class |  23.95 ns | 0.0183 ns | 0.0153 ns |       0 B |
             Get_Field_Struct |  24.75 ns | 0.0770 ns | 0.0720 ns |       0 B |
               Set_Prop_Class |  14.89 ns | 0.0247 ns | 0.0231 ns |       0 B |
              Set_Prop_Struct |  15.34 ns | 0.0221 ns | 0.0160 ns |       0 B |
              Set_Field_Class |  14.91 ns | 0.0282 ns | 0.0264 ns |       0 B |
             Set_Field_Struct |  15.24 ns | 0.0353 ns | 0.0331 ns |       0 B |
   Set_Prop_WithConvert_Class | 655.87 ns | 0.8733 ns | 0.8169 ns |       0 B |
  Set_Prop_WithConvert_Struct | 656.94 ns | 0.8185 ns | 0.7656 ns |       0 B |
  Set_Field_WithConvert_Class | 656.14 ns | 0.4842 ns | 0.4292 ns |       0 B |
 Set_Field_WithConvert_Struct | 656.28 ns | 0.6623 ns | 0.5872 ns |       0 B |
