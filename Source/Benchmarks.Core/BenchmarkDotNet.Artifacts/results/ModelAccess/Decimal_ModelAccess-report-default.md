
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.072 ns | 0.0117 ns | 0.0110 ns | 0.0076 |      32 B |
              Get_Prop_Struct |  53.365 ns | 0.0711 ns | 0.0594 ns | 0.1315 |     552 B |
              Get_Field_Class |   5.147 ns | 0.0088 ns | 0.0082 ns | 0.0076 |      32 B |
             Get_Field_Struct |  53.607 ns | 0.0436 ns | 0.0387 ns | 0.1315 |     552 B |
               Set_Prop_Class |   5.342 ns | 0.0320 ns | 0.0299 ns | 0.0076 |      32 B |
              Set_Prop_Struct |  55.321 ns | 0.0314 ns | 0.0262 ns | 0.1315 |     552 B |
              Set_Field_Class |   5.346 ns | 0.0295 ns | 0.0262 ns | 0.0076 |      32 B |
             Set_Field_Struct |  55.171 ns | 0.0490 ns | 0.0409 ns | 0.1315 |     552 B |
   Set_Prop_WithConvert_Class | 655.040 ns | 0.1610 ns | 0.1427 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 708.978 ns | 0.4299 ns | 0.4021 ns | 0.1230 |     520 B |
  Set_Field_WithConvert_Class | 655.661 ns | 2.4622 ns | 2.3031 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 704.836 ns | 0.3686 ns | 0.3078 ns | 0.1230 |     520 B |
