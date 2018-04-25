
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.009 ns | 0.0081 ns | 0.0076 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.253 ns | 0.0123 ns | 0.0115 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.001 ns | 0.0067 ns | 0.0059 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.248 ns | 0.0065 ns | 0.0061 ns | 0.0057 |      24 B |
               Set_Prop_Class |   2.633 ns | 0.0158 ns | 0.0147 ns |      - |       0 B |
              Set_Prop_Struct |   3.304 ns | 0.0059 ns | 0.0053 ns |      - |       0 B |
              Set_Field_Class |   2.618 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
             Set_Field_Struct |   2.641 ns | 0.0343 ns | 0.0304 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 137.672 ns | 0.1577 ns | 0.1398 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 140.482 ns | 1.3556 ns | 1.2681 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 137.481 ns | 0.1824 ns | 0.1706 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 138.733 ns | 0.1279 ns | 0.0999 ns |      - |       0 B |
