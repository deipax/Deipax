
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.510 ns | 0.0026 ns | 0.0022 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.502 ns | 0.0044 ns | 0.0041 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.523 ns | 0.0099 ns | 0.0092 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.510 ns | 0.0074 ns | 0.0070 ns | 0.0057 |      24 B |
               Set_Prop_Class |   2.612 ns | 0.0195 ns | 0.0182 ns |      - |       0 B |
              Set_Prop_Struct |   2.836 ns | 0.0212 ns | 0.0188 ns |      - |       0 B |
              Set_Field_Class |   3.318 ns | 0.0051 ns | 0.0048 ns |      - |       0 B |
             Set_Field_Struct |   3.309 ns | 0.0055 ns | 0.0051 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 208.470 ns | 0.2725 ns | 0.2549 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 208.547 ns | 0.2738 ns | 0.2428 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 213.892 ns | 1.1396 ns | 1.0660 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 206.504 ns | 0.4509 ns | 0.3765 ns |      - |       0 B |
