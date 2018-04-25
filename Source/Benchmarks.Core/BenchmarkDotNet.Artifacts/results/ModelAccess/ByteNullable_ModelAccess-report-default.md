
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  33.44 ns | 0.0153 ns | 0.0128 ns |      - |       0 B |
              Get_Prop_Struct |  83.81 ns | 0.4110 ns | 0.3845 ns | 0.1239 |     520 B |
              Get_Field_Class |  34.65 ns | 0.4163 ns | 0.3476 ns |      - |       0 B |
             Get_Field_Struct |  85.05 ns | 0.7937 ns | 0.7036 ns | 0.1239 |     520 B |
               Set_Prop_Class |  81.05 ns | 0.0466 ns | 0.0413 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 130.59 ns | 0.8475 ns | 0.7927 ns | 0.1295 |     544 B |
              Set_Field_Class |  79.29 ns | 0.1194 ns | 0.1117 ns | 0.0056 |      24 B |
             Set_Field_Struct | 129.16 ns | 0.5240 ns | 0.4902 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 102.54 ns | 0.3291 ns | 0.2918 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 153.31 ns | 0.7667 ns | 0.7172 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 102.54 ns | 0.4188 ns | 0.3712 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 152.22 ns | 0.2086 ns | 0.1742 ns | 0.1237 |     520 B |
