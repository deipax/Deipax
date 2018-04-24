
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  36.37 ns | 0.0312 ns | 0.0277 ns |      - |       0 B |
              Get_Prop_Struct |  85.45 ns | 0.2191 ns | 0.2049 ns | 0.1239 |     520 B |
              Get_Field_Class |  36.48 ns | 0.0234 ns | 0.0196 ns |      - |       0 B |
             Get_Field_Struct |  85.32 ns | 0.0692 ns | 0.0613 ns | 0.1239 |     520 B |
               Set_Prop_Class |  83.26 ns | 0.0235 ns | 0.0208 ns | 0.0075 |      32 B |
              Set_Prop_Struct | 134.82 ns | 0.3457 ns | 0.3234 ns | 0.1314 |     552 B |
              Set_Field_Class |  83.27 ns | 0.1251 ns | 0.1170 ns | 0.0075 |      32 B |
             Set_Field_Struct | 135.54 ns | 0.3203 ns | 0.2996 ns | 0.1314 |     552 B |
   Set_Prop_WithConvert_Class | 674.55 ns | 0.9357 ns | 0.7814 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 726.83 ns | 0.7190 ns | 0.6004 ns | 0.1230 |     520 B |
  Set_Field_WithConvert_Class | 673.70 ns | 0.1228 ns | 0.1025 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 727.49 ns | 0.7872 ns | 0.7364 ns | 0.1230 |     520 B |
