
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.262 ns | 0.0030 ns | 0.0027 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.259 ns | 0.0098 ns | 0.0091 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.261 ns | 0.0054 ns | 0.0048 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.245 ns | 0.0082 ns | 0.0076 ns | 0.0057 |      24 B |
               Set_Prop_Class |   2.664 ns | 0.0354 ns | 0.0331 ns |      - |       0 B |
              Set_Prop_Struct |   3.308 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
              Set_Field_Class |   2.605 ns | 0.0166 ns | 0.0156 ns |      - |       0 B |
             Set_Field_Struct |   2.821 ns | 0.0285 ns | 0.0267 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 189.263 ns | 0.1500 ns | 0.1403 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 189.759 ns | 0.3086 ns | 0.2577 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 189.626 ns | 0.1480 ns | 0.1156 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 189.382 ns | 0.1768 ns | 0.1654 ns |      - |       0 B |
