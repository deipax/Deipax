
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.265 ns | 0.0041 ns | 0.0037 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.271 ns | 0.0015 ns | 0.0013 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.279 ns | 0.0017 ns | 0.0016 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.514 ns | 0.0019 ns | 0.0016 ns | 0.0057 |      24 B |
               Set_Prop_Class |   3.296 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
              Set_Prop_Struct |   3.013 ns | 0.0042 ns | 0.0040 ns |      - |       0 B |
              Set_Field_Class |   3.122 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
             Set_Field_Struct |   3.167 ns | 0.0351 ns | 0.0311 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 107.953 ns | 0.0985 ns | 0.0921 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 108.441 ns | 0.0801 ns | 0.0749 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 108.965 ns | 0.0416 ns | 0.0369 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 108.009 ns | 0.0940 ns | 0.0833 ns |      - |       0 B |
