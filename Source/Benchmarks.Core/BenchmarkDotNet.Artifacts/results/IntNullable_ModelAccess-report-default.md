
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  32.71 ns | 0.0273 ns | 0.0242 ns |      - |       0 B |
              Get_Prop_Struct |  83.62 ns | 0.1263 ns | 0.1120 ns | 0.1239 |     520 B |
              Get_Field_Class |  32.62 ns | 0.1001 ns | 0.0936 ns |      - |       0 B |
             Get_Field_Struct |  83.97 ns | 0.2414 ns | 0.2016 ns | 0.1239 |     520 B |
               Set_Prop_Class |  80.97 ns | 0.1576 ns | 0.1474 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 131.02 ns | 0.4518 ns | 0.4005 ns | 0.1295 |     544 B |
              Set_Field_Class |  79.18 ns | 0.1995 ns | 0.1769 ns | 0.0056 |      24 B |
             Set_Field_Struct | 131.18 ns | 0.4705 ns | 0.4401 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 151.91 ns | 0.0508 ns | 0.0397 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 208.78 ns | 1.1836 ns | 1.0492 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 152.09 ns | 0.0690 ns | 0.0576 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 207.42 ns | 0.9573 ns | 0.8955 ns | 0.1237 |     520 B |
