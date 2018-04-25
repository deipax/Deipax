
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  34.23 ns | 0.1518 ns | 0.1346 ns |      - |       0 B |
              Get_Prop_Struct |  83.41 ns | 0.1164 ns | 0.1089 ns | 0.1239 |     520 B |
              Get_Field_Class |  34.73 ns | 0.0667 ns | 0.0591 ns |      - |       0 B |
             Get_Field_Struct |  82.38 ns | 0.1027 ns | 0.0802 ns | 0.1239 |     520 B |
               Set_Prop_Class |  81.06 ns | 0.0221 ns | 0.0185 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 136.20 ns | 4.2176 ns | 5.1796 ns | 0.1295 |     544 B |
              Set_Field_Class |  83.03 ns | 1.1689 ns | 1.0934 ns | 0.0056 |      24 B |
             Set_Field_Struct | 134.29 ns | 1.3119 ns | 1.1630 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 193.05 ns | 0.9788 ns | 0.8676 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 251.45 ns | 2.0697 ns | 1.9360 ns | 0.1235 |     520 B |
  Set_Field_WithConvert_Class | 192.20 ns | 0.6066 ns | 0.5378 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 246.42 ns | 0.1615 ns | 0.1432 ns | 0.1235 |     520 B |
