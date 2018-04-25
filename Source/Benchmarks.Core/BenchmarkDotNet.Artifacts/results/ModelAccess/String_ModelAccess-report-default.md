
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  2.283 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
              Get_Prop_Struct |  2.287 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
              Get_Field_Class |  2.287 ns | 0.0049 ns | 0.0046 ns |      - |       0 B |
             Get_Field_Struct |  2.793 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
               Set_Prop_Class |  4.585 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
              Set_Prop_Struct |  5.095 ns | 0.0052 ns | 0.0049 ns |      - |       0 B |
              Set_Field_Class |  4.589 ns | 0.0075 ns | 0.0067 ns |      - |       0 B |
             Set_Field_Struct |  4.585 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 78.966 ns | 0.2220 ns | 0.1854 ns | 0.0113 |      48 B |
  Set_Prop_WithConvert_Struct | 77.849 ns | 0.0560 ns | 0.0523 ns | 0.0113 |      48 B |
  Set_Field_WithConvert_Class | 81.136 ns | 0.1281 ns | 0.1136 ns | 0.0113 |      48 B |
 Set_Field_WithConvert_Struct | 78.388 ns | 0.0463 ns | 0.0387 ns | 0.0113 |      48 B |
