
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  33.08 ns | 0.0977 ns | 0.0914 ns |      - |       0 B |
              Get_Prop_Struct |  83.19 ns | 0.0779 ns | 0.0728 ns | 0.1239 |     520 B |
              Get_Field_Class |  32.48 ns | 0.0241 ns | 0.0202 ns |      - |       0 B |
             Get_Field_Struct |  83.31 ns | 0.0409 ns | 0.0320 ns | 0.1239 |     520 B |
               Set_Prop_Class |  80.41 ns | 0.0521 ns | 0.0487 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 132.31 ns | 0.0692 ns | 0.0648 ns | 0.1295 |     544 B |
              Set_Field_Class |  79.12 ns | 0.1267 ns | 0.1185 ns | 0.0056 |      24 B |
             Set_Field_Struct | 131.31 ns | 0.0962 ns | 0.0751 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 167.85 ns | 0.1871 ns | 0.1658 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 220.31 ns | 1.2793 ns | 1.1967 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 169.63 ns | 0.0888 ns | 0.0693 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 220.74 ns | 0.1057 ns | 0.0989 ns | 0.1237 |     520 B |
