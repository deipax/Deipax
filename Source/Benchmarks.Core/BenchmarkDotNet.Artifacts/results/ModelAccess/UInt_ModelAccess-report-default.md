
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.525 ns | 0.0016 ns | 0.0015 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.549 ns | 0.0019 ns | 0.0017 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.533 ns | 0.0008 ns | 0.0007 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.297 ns | 0.0011 ns | 0.0010 ns | 0.0057 |      24 B |
               Set_Prop_Class |   3.030 ns | 0.0031 ns | 0.0028 ns |      - |       0 B |
              Set_Prop_Struct |   2.969 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
              Set_Field_Class |   3.411 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
             Set_Field_Struct |   3.033 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 136.027 ns | 0.0484 ns | 0.0429 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 138.195 ns | 0.1047 ns | 0.0979 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 136.363 ns | 0.0996 ns | 0.0883 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 137.954 ns | 0.0849 ns | 0.0752 ns |      - |       0 B |
