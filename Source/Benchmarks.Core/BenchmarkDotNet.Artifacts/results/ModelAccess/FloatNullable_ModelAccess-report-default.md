
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  32.89 ns | 0.0893 ns | 0.0835 ns |      - |       0 B |
              Get_Prop_Struct |  83.89 ns | 0.0629 ns | 0.0491 ns | 0.1239 |     520 B |
              Get_Field_Class |  34.01 ns | 0.0637 ns | 0.0596 ns |      - |       0 B |
             Get_Field_Struct |  82.12 ns | 0.1164 ns | 0.1032 ns | 0.1239 |     520 B |
               Set_Prop_Class |  79.94 ns | 0.1075 ns | 0.1005 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 132.49 ns | 0.0921 ns | 0.0816 ns | 0.1295 |     544 B |
              Set_Field_Class |  81.88 ns | 0.1029 ns | 0.0912 ns | 0.0056 |      24 B |
             Set_Field_Struct | 130.52 ns | 0.1963 ns | 0.1298 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 155.97 ns | 0.0515 ns | 0.0430 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 213.03 ns | 0.9346 ns | 0.8743 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 155.83 ns | 0.0875 ns | 0.0775 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 206.82 ns | 0.6143 ns | 0.5746 ns | 0.1237 |     520 B |
