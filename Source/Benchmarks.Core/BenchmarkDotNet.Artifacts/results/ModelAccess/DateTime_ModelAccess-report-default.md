
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.028 ns | 0.0022 ns | 0.0020 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  52.775 ns | 0.0666 ns | 0.0623 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.021 ns | 0.0052 ns | 0.0049 ns | 0.0057 |      24 B |
             Get_Field_Struct |  52.812 ns | 0.0223 ns | 0.0198 ns | 0.1296 |     544 B |
               Set_Prop_Class |   5.027 ns | 0.0036 ns | 0.0034 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  53.248 ns | 0.0380 ns | 0.0336 ns | 0.1296 |     544 B |
              Set_Field_Class |   5.567 ns | 0.0092 ns | 0.0086 ns | 0.0057 |      24 B |
             Set_Field_Struct |  54.145 ns | 0.0521 ns | 0.0487 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 675.125 ns | 2.0994 ns | 1.9637 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 753.077 ns | 0.3652 ns | 0.3416 ns | 0.1230 |     520 B |
  Set_Field_WithConvert_Class | 674.899 ns | 1.2694 ns | 1.1874 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 774.908 ns | 0.3658 ns | 0.2856 ns | 0.1230 |     520 B |
