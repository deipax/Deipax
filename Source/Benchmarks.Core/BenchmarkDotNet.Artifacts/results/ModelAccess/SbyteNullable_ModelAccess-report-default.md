
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  24.46 ns | 0.0061 ns | 0.0051 ns |       0 B |
              Get_Prop_Struct |  24.66 ns | 0.0238 ns | 0.0198 ns |       0 B |
              Get_Field_Class |  24.49 ns | 0.0231 ns | 0.0216 ns |       0 B |
             Get_Field_Struct |  24.78 ns | 0.0286 ns | 0.0223 ns |       0 B |
               Set_Prop_Class |  13.43 ns | 0.0200 ns | 0.0167 ns |       0 B |
              Set_Prop_Struct |  13.49 ns | 0.0292 ns | 0.0259 ns |       0 B |
              Set_Field_Class |  13.54 ns | 0.0157 ns | 0.0131 ns |       0 B |
             Set_Field_Struct |  13.45 ns | 0.0113 ns | 0.0100 ns |       0 B |
   Set_Prop_WithConvert_Class | 101.25 ns | 0.0700 ns | 0.0655 ns |       0 B |
  Set_Prop_WithConvert_Struct | 102.78 ns | 0.0876 ns | 0.0819 ns |       0 B |
  Set_Field_WithConvert_Class | 101.22 ns | 0.0454 ns | 0.0424 ns |       0 B |
 Set_Field_WithConvert_Struct | 100.76 ns | 0.0686 ns | 0.0641 ns |       0 B |
