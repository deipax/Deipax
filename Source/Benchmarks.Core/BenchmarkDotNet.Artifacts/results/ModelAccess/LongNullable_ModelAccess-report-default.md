
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  24.17 ns | 0.0195 ns | 0.0182 ns |       0 B |
              Get_Prop_Struct |  23.82 ns | 0.0410 ns | 0.0363 ns |       0 B |
              Get_Field_Class |  23.75 ns | 0.0263 ns | 0.0246 ns |       0 B |
             Get_Field_Struct |  23.83 ns | 0.0286 ns | 0.0268 ns |       0 B |
               Set_Prop_Class |  13.62 ns | 0.0495 ns | 0.0439 ns |       0 B |
              Set_Prop_Struct |  13.66 ns | 0.0108 ns | 0.0090 ns |       0 B |
              Set_Field_Class |  13.87 ns | 0.0435 ns | 0.0407 ns |       0 B |
             Set_Field_Struct |  13.57 ns | 0.0123 ns | 0.0103 ns |       0 B |
   Set_Prop_WithConvert_Class | 188.01 ns | 0.2200 ns | 0.1837 ns |       0 B |
  Set_Prop_WithConvert_Struct | 188.51 ns | 0.1824 ns | 0.1617 ns |       0 B |
  Set_Field_WithConvert_Class | 187.10 ns | 0.1007 ns | 0.0942 ns |       0 B |
 Set_Field_WithConvert_Struct | 187.54 ns | 0.0664 ns | 0.0588 ns |       0 B |
