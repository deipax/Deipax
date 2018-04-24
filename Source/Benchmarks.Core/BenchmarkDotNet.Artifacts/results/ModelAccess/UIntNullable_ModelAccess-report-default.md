
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  33.93 ns | 0.0467 ns | 0.0365 ns |      - |       0 B |
              Get_Prop_Struct |  84.78 ns | 0.1755 ns | 0.1556 ns | 0.1239 |     520 B |
              Get_Field_Class |  33.02 ns | 0.0424 ns | 0.0397 ns |      - |       0 B |
             Get_Field_Struct |  83.14 ns | 0.1421 ns | 0.1329 ns | 0.1239 |     520 B |
               Set_Prop_Class |  81.16 ns | 0.1388 ns | 0.1298 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 130.76 ns | 0.2149 ns | 0.2010 ns | 0.1295 |     544 B |
              Set_Field_Class |  80.03 ns | 0.0767 ns | 0.0718 ns | 0.0056 |      24 B |
             Set_Field_Struct | 130.30 ns | 0.1329 ns | 0.1178 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 158.78 ns | 0.1595 ns | 0.1492 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 205.16 ns | 0.5718 ns | 0.5348 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 160.91 ns | 0.2788 ns | 0.2472 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 205.23 ns | 0.5280 ns | 0.4681 ns | 0.1237 |     520 B |
