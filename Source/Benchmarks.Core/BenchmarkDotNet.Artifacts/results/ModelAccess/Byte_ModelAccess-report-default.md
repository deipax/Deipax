
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.535 ns | 0.0032 ns | 0.0030 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.531 ns | 0.0072 ns | 0.0061 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.528 ns | 0.0042 ns | 0.0035 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.502 ns | 0.0026 ns | 0.0022 ns | 0.0057 |      24 B |
               Set_Prop_Class |   2.619 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
              Set_Prop_Struct |   3.206 ns | 0.0163 ns | 0.0152 ns |      - |       0 B |
              Set_Field_Class |   3.338 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
             Set_Field_Struct |   3.308 ns | 0.0050 ns | 0.0045 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 100.661 ns | 0.0732 ns | 0.0648 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 100.331 ns | 0.3816 ns | 0.3569 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 100.270 ns | 0.0513 ns | 0.0480 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 100.512 ns | 0.3165 ns | 0.2643 ns |      - |       0 B |
