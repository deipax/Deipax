
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  34.00 ns | 0.1631 ns | 0.1526 ns |      - |       0 B |
              Get_Prop_Struct |  84.38 ns | 0.3961 ns | 0.3705 ns | 0.1239 |     520 B |
              Get_Field_Class |  34.09 ns | 0.0327 ns | 0.0306 ns |      - |       0 B |
             Get_Field_Struct |  84.64 ns | 0.0839 ns | 0.0701 ns | 0.1239 |     520 B |
               Set_Prop_Class |  81.40 ns | 0.1177 ns | 0.1044 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 130.77 ns | 0.6550 ns | 0.6126 ns | 0.1295 |     544 B |
              Set_Field_Class |  81.55 ns | 0.0493 ns | 0.0385 ns | 0.0056 |      24 B |
             Set_Field_Struct | 130.85 ns | 0.1556 ns | 0.1300 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 233.01 ns | 0.5553 ns | 0.4923 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 279.70 ns | 1.2733 ns | 1.1287 ns | 0.1235 |     520 B |
  Set_Field_WithConvert_Class | 227.80 ns | 0.0633 ns | 0.0561 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 277.90 ns | 0.1560 ns | 0.1218 ns | 0.1235 |     520 B |
