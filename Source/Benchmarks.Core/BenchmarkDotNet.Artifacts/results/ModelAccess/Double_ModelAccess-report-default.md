
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.502 ns | 0.0087 ns | 0.0081 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.517 ns | 0.0135 ns | 0.0126 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.509 ns | 0.0084 ns | 0.0074 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.501 ns | 0.0051 ns | 0.0043 ns | 0.0057 |      24 B |
               Set_Prop_Class |   2.671 ns | 0.0169 ns | 0.0141 ns |      - |       0 B |
              Set_Prop_Struct |   2.838 ns | 0.0162 ns | 0.0144 ns |      - |       0 B |
              Set_Field_Class |   3.322 ns | 0.0146 ns | 0.0136 ns |      - |       0 B |
             Set_Field_Struct |   3.312 ns | 0.0127 ns | 0.0106 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 162.388 ns | 0.2405 ns | 0.2250 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 164.135 ns | 0.2963 ns | 0.2474 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 163.570 ns | 0.2453 ns | 0.2175 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 164.708 ns | 0.3701 ns | 0.3281 ns |      - |       0 B |
