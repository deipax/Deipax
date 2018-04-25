
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  25.67 ns | 0.0366 ns | 0.0343 ns |       0 B |
              Get_Prop_Struct |  23.85 ns | 0.0366 ns | 0.0342 ns |       0 B |
              Get_Field_Class |  23.78 ns | 0.0705 ns | 0.0659 ns |       0 B |
             Get_Field_Struct |  23.81 ns | 0.0416 ns | 0.0369 ns |       0 B |
               Set_Prop_Class |  13.55 ns | 0.0292 ns | 0.0273 ns |       0 B |
              Set_Prop_Struct |  13.81 ns | 0.0169 ns | 0.0141 ns |       0 B |
              Set_Field_Class |  15.07 ns | 0.0141 ns | 0.0125 ns |       0 B |
             Set_Field_Struct |  13.59 ns | 0.0200 ns | 0.0187 ns |       0 B |
   Set_Prop_WithConvert_Class | 209.52 ns | 0.1333 ns | 0.1247 ns |       0 B |
  Set_Prop_WithConvert_Struct | 209.19 ns | 0.2664 ns | 0.2225 ns |       0 B |
  Set_Field_WithConvert_Class | 208.83 ns | 0.1877 ns | 0.1664 ns |       0 B |
 Set_Field_WithConvert_Struct | 208.94 ns | 0.3044 ns | 0.2848 ns |       0 B |
