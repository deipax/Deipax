
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.838 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
              Get_Prop_Struct |  53.744 ns | 0.1209 ns | 0.1131 ns | 0.1239 |     520 B |
              Get_Field_Class |   4.839 ns | 0.0032 ns | 0.0030 ns |      - |       0 B |
             Get_Field_Struct |  52.541 ns | 0.0430 ns | 0.0403 ns | 0.1239 |     520 B |
               Set_Prop_Class |   4.587 ns | 0.0048 ns | 0.0045 ns |      - |       0 B |
              Set_Prop_Struct |  53.319 ns | 0.0683 ns | 0.0638 ns | 0.1239 |     520 B |
              Set_Field_Class |   4.585 ns | 0.0047 ns | 0.0044 ns |      - |       0 B |
             Set_Field_Struct |  52.552 ns | 0.0435 ns | 0.0363 ns | 0.1239 |     520 B |
   Set_Prop_WithConvert_Class |  81.060 ns | 0.1450 ns | 0.1356 ns | 0.0172 |      72 B |
  Set_Prop_WithConvert_Struct | 129.149 ns | 0.0746 ns | 0.0661 ns | 0.1409 |     592 B |
  Set_Field_WithConvert_Class |  81.825 ns | 0.1183 ns | 0.1107 ns | 0.0172 |      72 B |
 Set_Field_WithConvert_Struct | 129.943 ns | 0.0594 ns | 0.0496 ns | 0.1409 |     592 B |
