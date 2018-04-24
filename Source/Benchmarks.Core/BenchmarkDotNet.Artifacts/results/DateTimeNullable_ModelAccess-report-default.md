
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  36.46 ns | 1.1252 ns | 1.3818 ns |      - |       0 B |
              Get_Prop_Struct |  84.38 ns | 0.4477 ns | 0.3738 ns | 0.1239 |     520 B |
              Get_Field_Class |  34.16 ns | 0.1143 ns | 0.1014 ns |      - |       0 B |
             Get_Field_Struct |  84.22 ns | 0.4689 ns | 0.4386 ns | 0.1239 |     520 B |
               Set_Prop_Class |  80.29 ns | 0.0365 ns | 0.0324 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 130.62 ns | 0.0753 ns | 0.0588 ns | 0.1295 |     544 B |
              Set_Field_Class |  80.20 ns | 0.0386 ns | 0.0322 ns | 0.0056 |      24 B |
             Set_Field_Struct | 132.06 ns | 0.3540 ns | 0.3311 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 757.99 ns | 0.2164 ns | 0.1807 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 886.13 ns | 4.6221 ns | 4.3235 ns | 0.1230 |     520 B |
  Set_Field_WithConvert_Class | 866.78 ns | 1.0734 ns | 0.9516 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 936.99 ns | 4.8105 ns | 4.2644 ns | 0.1230 |     520 B |
