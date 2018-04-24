
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.842 ns | 0.0067 ns | 0.0059 ns |      - |       0 B |
              Get_Prop_Struct |  52.790 ns | 0.0452 ns | 0.0377 ns | 0.1239 |     520 B |
              Get_Field_Class |   4.842 ns | 0.0070 ns | 0.0062 ns |      - |       0 B |
             Get_Field_Struct |  52.983 ns | 0.3212 ns | 0.2847 ns | 0.1239 |     520 B |
               Set_Prop_Class |   4.841 ns | 0.0045 ns | 0.0038 ns |      - |       0 B |
              Set_Prop_Struct |  52.965 ns | 0.0750 ns | 0.0626 ns | 0.1239 |     520 B |
              Set_Field_Class |   5.096 ns | 0.0054 ns | 0.0050 ns |      - |       0 B |
             Set_Field_Struct |  52.540 ns | 0.0816 ns | 0.0724 ns | 0.1239 |     520 B |
   Set_Prop_WithConvert_Class |  85.620 ns | 0.0957 ns | 0.0896 ns | 0.0172 |      72 B |
  Set_Prop_WithConvert_Struct | 134.709 ns | 0.0776 ns | 0.0725 ns | 0.1409 |     592 B |
  Set_Field_WithConvert_Class |  85.513 ns | 0.0675 ns | 0.0599 ns | 0.0172 |      72 B |
 Set_Field_WithConvert_Struct | 136.737 ns | 0.1659 ns | 0.1471 ns | 0.1409 |     592 B |
