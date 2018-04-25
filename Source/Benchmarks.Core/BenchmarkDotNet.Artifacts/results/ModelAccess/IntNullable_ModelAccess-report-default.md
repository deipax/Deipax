
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  32.95 ns | 0.0478 ns | 0.0424 ns |      - |       0 B |
              Get_Prop_Struct |  83.08 ns | 0.3568 ns | 0.3337 ns | 0.1239 |     520 B |
              Get_Field_Class |  32.48 ns | 0.0488 ns | 0.0432 ns |      - |       0 B |
             Get_Field_Struct |  83.11 ns | 0.0894 ns | 0.0793 ns | 0.1239 |     520 B |
               Set_Prop_Class |  79.83 ns | 0.0295 ns | 0.0261 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 129.61 ns | 0.0817 ns | 0.0638 ns | 0.1295 |     544 B |
              Set_Field_Class |  79.74 ns | 0.0261 ns | 0.0218 ns | 0.0056 |      24 B |
             Set_Field_Struct | 131.23 ns | 0.4741 ns | 0.4435 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 140.10 ns | 0.0813 ns | 0.0635 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 194.47 ns | 0.8369 ns | 0.7419 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 140.17 ns | 0.0505 ns | 0.0447 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 193.13 ns | 1.1310 ns | 1.0026 ns | 0.1237 |     520 B |
