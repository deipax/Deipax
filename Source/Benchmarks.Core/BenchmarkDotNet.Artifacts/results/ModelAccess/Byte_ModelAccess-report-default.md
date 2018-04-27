
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  4.526 ns | 0.0007 ns | 0.0006 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  4.542 ns | 0.0024 ns | 0.0022 ns | 0.0057 |      24 B |
              Get_Field_Class |  4.531 ns | 0.0029 ns | 0.0027 ns | 0.0057 |      24 B |
             Get_Field_Struct |  4.301 ns | 0.0024 ns | 0.0023 ns | 0.0057 |      24 B |
               Set_Prop_Class |  3.159 ns | 0.0030 ns | 0.0026 ns |      - |       0 B |
              Set_Prop_Struct |  3.103 ns | 0.0093 ns | 0.0072 ns |      - |       0 B |
              Set_Field_Class |  3.337 ns | 0.0012 ns | 0.0008 ns |      - |       0 B |
             Set_Field_Struct |  2.942 ns | 0.0131 ns | 0.0109 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 97.111 ns | 0.0318 ns | 0.0265 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 96.879 ns | 0.0765 ns | 0.0678 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 96.340 ns | 0.0553 ns | 0.0490 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 96.602 ns | 0.4695 ns | 0.4162 ns |      - |       0 B |
