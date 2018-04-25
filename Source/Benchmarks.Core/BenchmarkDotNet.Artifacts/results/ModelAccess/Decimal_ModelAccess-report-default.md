
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.575 ns | 0.0036 ns | 0.0034 ns | 0.0076 |      32 B |
              Get_Prop_Struct |   4.583 ns | 0.0100 ns | 0.0089 ns | 0.0076 |      32 B |
              Get_Field_Class |   4.588 ns | 0.0041 ns | 0.0036 ns | 0.0076 |      32 B |
             Get_Field_Struct |   5.062 ns | 0.0042 ns | 0.0039 ns | 0.0076 |      32 B |
               Set_Prop_Class |   2.897 ns | 0.0071 ns | 0.0067 ns |      - |       0 B |
              Set_Prop_Struct |   3.561 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
              Set_Field_Class |   4.249 ns | 0.0264 ns | 0.0247 ns |      - |       0 B |
             Set_Field_Struct |   3.308 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 655.197 ns | 1.1706 ns | 1.0950 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 658.336 ns | 0.2571 ns | 0.2279 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 654.511 ns | 1.0518 ns | 0.9839 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 660.780 ns | 0.8682 ns | 0.8121 ns |      - |       0 B |
