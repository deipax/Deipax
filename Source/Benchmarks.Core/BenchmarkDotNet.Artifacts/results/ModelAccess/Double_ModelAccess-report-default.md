
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.519 ns | 0.0027 ns | 0.0025 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.553 ns | 0.0023 ns | 0.0021 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.529 ns | 0.0027 ns | 0.0026 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.285 ns | 0.0033 ns | 0.0029 ns | 0.0057 |      24 B |
               Set_Prop_Class |   3.164 ns | 0.0100 ns | 0.0089 ns |      - |       0 B |
              Set_Prop_Struct |   2.986 ns | 0.0033 ns | 0.0029 ns |      - |       0 B |
              Set_Field_Class |   3.400 ns | 0.0096 ns | 0.0090 ns |      - |       0 B |
             Set_Field_Struct |   2.987 ns | 0.0027 ns | 0.0025 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 163.025 ns | 0.5076 ns | 0.4748 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 158.793 ns | 0.3456 ns | 0.3233 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 162.418 ns | 0.1270 ns | 0.1188 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 156.786 ns | 0.1117 ns | 0.0990 ns |      - |       0 B |
