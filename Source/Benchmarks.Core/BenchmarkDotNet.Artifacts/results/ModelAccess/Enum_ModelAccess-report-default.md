
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.067 ns | 0.0038 ns | 0.0035 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  53.088 ns | 0.1691 ns | 0.1581 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.057 ns | 0.0018 ns | 0.0014 ns | 0.0057 |      24 B |
             Get_Field_Struct |  53.632 ns | 0.0275 ns | 0.0230 ns | 0.1296 |     544 B |
               Set_Prop_Class |   5.833 ns | 0.0367 ns | 0.0325 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  54.558 ns | 0.0516 ns | 0.0431 ns | 0.1296 |     544 B |
              Set_Field_Class |   5.327 ns | 0.0428 ns | 0.0357 ns | 0.0057 |      24 B |
             Set_Field_Struct |  54.613 ns | 0.0225 ns | 0.0188 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class |  40.356 ns | 0.5526 ns | 0.5169 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 101.243 ns | 0.0429 ns | 0.0380 ns | 0.1239 |     520 B |
  Set_Field_WithConvert_Class |  42.267 ns | 0.3388 ns | 0.3004 ns |      - |       0 B |
 Set_Field_WithConvert_Struct |  94.723 ns | 0.0586 ns | 0.0519 ns | 0.1239 |     520 B |
