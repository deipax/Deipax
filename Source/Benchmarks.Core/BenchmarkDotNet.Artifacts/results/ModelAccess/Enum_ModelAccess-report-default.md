
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  4.503 ns | 0.0019 ns | 0.0018 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  4.615 ns | 0.0035 ns | 0.0025 ns | 0.0057 |      24 B |
              Get_Field_Class |  4.518 ns | 0.0017 ns | 0.0016 ns | 0.0057 |      24 B |
             Get_Field_Struct |  4.263 ns | 0.0040 ns | 0.0031 ns | 0.0057 |      24 B |
               Set_Prop_Class |  3.053 ns | 0.0047 ns | 0.0044 ns |      - |       0 B |
              Set_Prop_Struct |  3.021 ns | 0.0183 ns | 0.0153 ns |      - |       0 B |
              Set_Field_Class |  3.411 ns | 0.0051 ns | 0.0045 ns |      - |       0 B |
             Set_Field_Struct |  3.000 ns | 0.0064 ns | 0.0060 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 36.277 ns | 0.0206 ns | 0.0193 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 36.366 ns | 0.0366 ns | 0.0342 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 36.468 ns | 0.0396 ns | 0.0351 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 36.240 ns | 0.0426 ns | 0.0377 ns |      - |       0 B |
