
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.281 ns | 0.0026 ns | 0.0024 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.300 ns | 0.0020 ns | 0.0018 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.301 ns | 0.0022 ns | 0.0021 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.537 ns | 0.0028 ns | 0.0025 ns | 0.0057 |      24 B |
               Set_Prop_Class |   3.260 ns | 0.0179 ns | 0.0167 ns |      - |       0 B |
              Set_Prop_Struct |   2.933 ns | 0.0041 ns | 0.0038 ns |      - |       0 B |
              Set_Field_Class |   3.183 ns | 0.0032 ns | 0.0030 ns |      - |       0 B |
             Set_Field_Struct |   2.993 ns | 0.0272 ns | 0.0227 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 150.113 ns | 0.1449 ns | 0.1355 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 150.768 ns | 0.0982 ns | 0.0870 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 150.685 ns | 0.0934 ns | 0.0780 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 150.768 ns | 0.0873 ns | 0.0817 ns |      - |       0 B |
