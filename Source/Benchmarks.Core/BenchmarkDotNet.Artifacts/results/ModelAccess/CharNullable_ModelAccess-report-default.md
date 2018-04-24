
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  35.02 ns | 0.0681 ns | 0.0637 ns |      - |       0 B |
              Get_Prop_Struct |  86.33 ns | 0.0638 ns | 0.0498 ns | 0.1239 |     520 B |
              Get_Field_Class |  35.18 ns | 0.0445 ns | 0.0372 ns |      - |       0 B |
             Get_Field_Struct |  86.35 ns | 0.3381 ns | 0.2824 ns | 0.1239 |     520 B |
               Set_Prop_Class |  79.08 ns | 0.1272 ns | 0.1128 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 130.98 ns | 0.0699 ns | 0.0584 ns | 0.1295 |     544 B |
              Set_Field_Class |  79.32 ns | 0.1645 ns | 0.1538 ns | 0.0056 |      24 B |
             Set_Field_Struct | 130.64 ns | 0.1119 ns | 0.0992 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class |  28.50 ns | 0.0161 ns | 0.0135 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct |  78.83 ns | 0.0486 ns | 0.0431 ns | 0.1239 |     520 B |
  Set_Field_WithConvert_Class |  28.40 ns | 0.0502 ns | 0.0445 ns |      - |       0 B |
 Set_Field_WithConvert_Struct |  78.17 ns | 0.0906 ns | 0.0847 ns | 0.1239 |     520 B |
