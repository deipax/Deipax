
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.242 ns | 0.0071 ns | 0.0067 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.260 ns | 0.0066 ns | 0.0061 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.242 ns | 0.0066 ns | 0.0062 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.256 ns | 0.0118 ns | 0.0105 ns | 0.0057 |      24 B |
               Set_Prop_Class |   3.282 ns | 0.0098 ns | 0.0082 ns |      - |       0 B |
              Set_Prop_Struct |   3.307 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
              Set_Field_Class |   2.603 ns | 0.0091 ns | 0.0080 ns |      - |       0 B |
             Set_Field_Struct |   2.875 ns | 0.0082 ns | 0.0077 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 112.594 ns | 0.1194 ns | 0.1117 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 112.485 ns | 0.1091 ns | 0.0968 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 113.298 ns | 0.0225 ns | 0.0199 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 113.635 ns | 0.0694 ns | 0.0580 ns |      - |       0 B |
