
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.001 ns | 0.0076 ns | 0.0071 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  52.122 ns | 0.0854 ns | 0.0713 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.006 ns | 0.0031 ns | 0.0029 ns | 0.0057 |      24 B |
             Get_Field_Struct |  52.273 ns | 0.0761 ns | 0.0674 ns | 0.1296 |     544 B |
               Set_Prop_Class |   4.743 ns | 0.0071 ns | 0.0067 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  53.703 ns | 0.0917 ns | 0.0857 ns | 0.1296 |     544 B |
              Set_Field_Class |   4.748 ns | 0.0029 ns | 0.0025 ns | 0.0057 |      24 B |
             Set_Field_Struct |  53.259 ns | 0.0756 ns | 0.0670 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 152.775 ns | 0.2855 ns | 0.2531 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 203.050 ns | 0.3258 ns | 0.3047 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 153.457 ns | 0.1989 ns | 0.1661 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 203.870 ns | 0.3431 ns | 0.3209 ns | 0.1237 |     520 B |
