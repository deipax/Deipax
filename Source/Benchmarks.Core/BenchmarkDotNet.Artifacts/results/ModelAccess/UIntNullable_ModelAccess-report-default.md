
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  24.26 ns | 0.0239 ns | 0.0212 ns |       0 B |
              Get_Prop_Struct |  24.41 ns | 0.0427 ns | 0.0357 ns |       0 B |
              Get_Field_Class |  23.82 ns | 0.0472 ns | 0.0442 ns |       0 B |
             Get_Field_Struct |  23.93 ns | 0.0827 ns | 0.0774 ns |       0 B |
               Set_Prop_Class |  14.44 ns | 0.0163 ns | 0.0136 ns |       0 B |
              Set_Prop_Struct |  13.40 ns | 0.0213 ns | 0.0189 ns |       0 B |
              Set_Field_Class |  13.44 ns | 0.0543 ns | 0.0508 ns |       0 B |
             Set_Field_Struct |  13.42 ns | 0.0264 ns | 0.0247 ns |       0 B |
   Set_Prop_WithConvert_Class | 137.72 ns | 0.1001 ns | 0.0936 ns |       0 B |
  Set_Prop_WithConvert_Struct | 137.63 ns | 0.0317 ns | 0.0265 ns |       0 B |
  Set_Field_WithConvert_Class | 139.76 ns | 0.0821 ns | 0.0686 ns |       0 B |
 Set_Field_WithConvert_Struct | 138.78 ns | 0.1663 ns | 0.1556 ns |       0 B |
