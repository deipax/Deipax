
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  4.344 ns | 0.1196 ns | 0.1228 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  4.319 ns | 0.0168 ns | 0.0140 ns | 0.0057 |      24 B |
              Get_Field_Class |  4.289 ns | 0.0042 ns | 0.0033 ns | 0.0057 |      24 B |
             Get_Field_Struct |  4.671 ns | 0.0940 ns | 0.0880 ns | 0.0057 |      24 B |
               Set_Prop_Class |  3.250 ns | 0.0088 ns | 0.0082 ns |      - |       0 B |
              Set_Prop_Struct |  3.011 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
              Set_Field_Class |  3.148 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
             Set_Field_Struct |  3.016 ns | 0.0183 ns | 0.0172 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 18.455 ns | 0.0701 ns | 0.0585 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 18.207 ns | 0.0830 ns | 0.0693 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 18.406 ns | 0.0159 ns | 0.0141 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 18.687 ns | 0.0234 ns | 0.0219 ns |      - |       0 B |
