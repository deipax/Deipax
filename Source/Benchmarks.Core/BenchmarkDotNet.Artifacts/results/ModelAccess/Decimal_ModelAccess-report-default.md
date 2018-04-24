
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.164 ns | 0.0139 ns | 0.0130 ns | 0.0076 |      32 B |
              Get_Prop_Struct |  53.776 ns | 0.0547 ns | 0.0457 ns | 0.1315 |     552 B |
              Get_Field_Class |   5.143 ns | 0.0094 ns | 0.0088 ns | 0.0076 |      32 B |
             Get_Field_Struct |  53.705 ns | 0.0838 ns | 0.0700 ns | 0.1315 |     552 B |
               Set_Prop_Class |   5.345 ns | 0.0104 ns | 0.0098 ns | 0.0076 |      32 B |
              Set_Prop_Struct |  55.857 ns | 0.1114 ns | 0.1042 ns | 0.1315 |     552 B |
              Set_Field_Class |   6.388 ns | 0.0118 ns | 0.0110 ns | 0.0076 |      32 B |
             Set_Field_Struct |  55.104 ns | 0.0784 ns | 0.0695 ns | 0.1315 |     552 B |
   Set_Prop_WithConvert_Class | 661.264 ns | 0.8078 ns | 0.7556 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 714.054 ns | 1.2426 ns | 1.1623 ns | 0.1230 |     520 B |
  Set_Field_WithConvert_Class | 660.804 ns | 1.3538 ns | 1.2664 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 713.294 ns | 1.2462 ns | 1.1657 ns | 0.1230 |     520 B |
