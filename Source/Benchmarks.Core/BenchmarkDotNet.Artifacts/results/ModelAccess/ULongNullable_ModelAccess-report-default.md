
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  24.51 ns | 0.0271 ns | 0.0253 ns |       0 B |
              Get_Prop_Struct |  23.91 ns | 0.0393 ns | 0.0368 ns |       0 B |
              Get_Field_Class |  23.63 ns | 0.0352 ns | 0.0312 ns |       0 B |
             Get_Field_Struct |  24.81 ns | 0.0296 ns | 0.0247 ns |       0 B |
               Set_Prop_Class |  13.60 ns | 0.0132 ns | 0.0117 ns |       0 B |
              Set_Prop_Struct |  13.66 ns | 0.0447 ns | 0.0418 ns |       0 B |
              Set_Field_Class |  13.67 ns | 0.0109 ns | 0.0085 ns |       0 B |
             Set_Field_Struct |  13.84 ns | 0.0268 ns | 0.0224 ns |       0 B |
   Set_Prop_WithConvert_Class | 206.87 ns | 0.0781 ns | 0.0652 ns |       0 B |
  Set_Prop_WithConvert_Struct | 208.34 ns | 0.1206 ns | 0.1069 ns |       0 B |
  Set_Field_WithConvert_Class | 206.75 ns | 0.0545 ns | 0.0483 ns |       0 B |
 Set_Field_WithConvert_Struct | 207.50 ns | 0.2775 ns | 0.2460 ns |       0 B |
