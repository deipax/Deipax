
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.013 ns | 0.0336 ns | 0.0314 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  52.613 ns | 0.0737 ns | 0.0689 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.014 ns | 0.0313 ns | 0.0293 ns | 0.0057 |      24 B |
             Get_Field_Struct |  52.932 ns | 0.3796 ns | 0.3551 ns | 0.1296 |     544 B |
               Set_Prop_Class |   4.813 ns | 0.0517 ns | 0.0484 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  54.845 ns | 0.1242 ns | 0.0970 ns | 0.1296 |     544 B |
              Set_Field_Class |   4.872 ns | 0.0987 ns | 0.0924 ns | 0.0057 |      24 B |
             Set_Field_Struct |  54.911 ns | 0.9465 ns | 0.8390 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 115.636 ns | 2.5109 ns | 3.4370 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 164.452 ns | 0.6205 ns | 0.5501 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 115.643 ns | 2.3609 ns | 3.0698 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 164.093 ns | 0.5208 ns | 0.4349 ns | 0.1237 |     520 B |
