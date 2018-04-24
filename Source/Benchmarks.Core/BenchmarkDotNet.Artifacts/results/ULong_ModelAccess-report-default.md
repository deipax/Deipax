
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.290 ns | 0.0076 ns | 0.0071 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  53.639 ns | 0.3181 ns | 0.2656 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.280 ns | 0.0065 ns | 0.0061 ns | 0.0057 |      24 B |
             Get_Field_Struct |  52.608 ns | 0.1495 ns | 0.1399 ns | 0.1296 |     544 B |
               Set_Prop_Class |   5.613 ns | 0.0391 ns | 0.0346 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  54.027 ns | 0.0442 ns | 0.0392 ns | 0.1296 |     544 B |
              Set_Field_Class |   5.076 ns | 0.0388 ns | 0.0344 ns | 0.0057 |      24 B |
             Set_Field_Struct |  54.500 ns | 0.0281 ns | 0.0263 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 215.656 ns | 2.8350 ns | 2.3674 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 268.282 ns | 0.2810 ns | 0.2347 ns | 0.1235 |     520 B |
  Set_Field_WithConvert_Class | 213.418 ns | 0.0743 ns | 0.0621 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 263.235 ns | 0.4431 ns | 0.4145 ns | 0.1235 |     520 B |
