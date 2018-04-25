
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.511 ns | 0.0086 ns | 0.0072 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.505 ns | 0.0133 ns | 0.0124 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.513 ns | 0.0054 ns | 0.0045 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.283 ns | 0.0232 ns | 0.0181 ns | 0.0057 |      24 B |
               Set_Prop_Class |   2.874 ns | 0.0222 ns | 0.0208 ns |      - |       0 B |
              Set_Prop_Struct |   2.689 ns | 0.0353 ns | 0.0330 ns |      - |       0 B |
              Set_Field_Class |   3.459 ns | 0.1000 ns | 0.0935 ns |      - |       0 B |
             Set_Field_Struct |   3.325 ns | 0.0192 ns | 0.0179 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 673.790 ns | 1.7460 ns | 1.6332 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 719.871 ns | 1.3755 ns | 1.2867 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 674.152 ns | 0.9522 ns | 0.8907 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 673.547 ns | 0.2724 ns | 0.2127 ns |      - |       0 B |
