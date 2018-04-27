
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  4.309 ns | 0.0017 ns | 0.0014 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  4.295 ns | 0.0036 ns | 0.0033 ns | 0.0057 |      24 B |
              Get_Field_Class |  4.296 ns | 0.0132 ns | 0.0124 ns | 0.0057 |      24 B |
             Get_Field_Struct |  4.526 ns | 0.0028 ns | 0.0025 ns | 0.0057 |      24 B |
               Set_Prop_Class |  3.158 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
              Set_Prop_Struct |  2.975 ns | 0.0053 ns | 0.0050 ns |      - |       0 B |
              Set_Field_Class |  3.139 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
             Set_Field_Struct |  2.985 ns | 0.0058 ns | 0.0054 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 97.916 ns | 0.0326 ns | 0.0289 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 99.906 ns | 0.0774 ns | 0.0646 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 99.221 ns | 0.0430 ns | 0.0381 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 99.086 ns | 0.0735 ns | 0.0687 ns |      - |       0 B |
