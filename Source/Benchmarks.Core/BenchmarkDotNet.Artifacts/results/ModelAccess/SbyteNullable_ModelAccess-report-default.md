
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  34.01 ns | 0.0247 ns | 0.0206 ns |      - |       0 B |
              Get_Prop_Struct |  83.63 ns | 0.2998 ns | 0.2804 ns | 0.1239 |     520 B |
              Get_Field_Class |  34.18 ns | 0.0048 ns | 0.0042 ns |      - |       0 B |
             Get_Field_Struct |  83.13 ns | 0.4505 ns | 0.4214 ns | 0.1239 |     520 B |
               Set_Prop_Class |  79.56 ns | 0.0569 ns | 0.0444 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 129.76 ns | 0.1971 ns | 0.1844 ns | 0.1295 |     544 B |
              Set_Field_Class |  79.54 ns | 0.0501 ns | 0.0444 ns | 0.0056 |      24 B |
             Set_Field_Struct | 130.26 ns | 0.1007 ns | 0.0841 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 104.07 ns | 0.1016 ns | 0.0950 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 153.18 ns | 0.1085 ns | 0.1015 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 101.80 ns | 0.0461 ns | 0.0408 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 153.23 ns | 0.2203 ns | 0.1953 ns | 0.1237 |     520 B |
