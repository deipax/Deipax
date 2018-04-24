
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  33.92 ns | 0.0361 ns | 0.0320 ns |      - |       0 B |
              Get_Prop_Struct |  84.15 ns | 0.1968 ns | 0.1841 ns | 0.1239 |     520 B |
              Get_Field_Class |  33.75 ns | 0.0833 ns | 0.0779 ns |      - |       0 B |
             Get_Field_Struct |  84.35 ns | 0.0384 ns | 0.0321 ns | 0.1239 |     520 B |
               Set_Prop_Class |  81.78 ns | 0.0308 ns | 0.0273 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 133.42 ns | 0.1789 ns | 0.1673 ns | 0.1295 |     544 B |
              Set_Field_Class |  81.52 ns | 0.0213 ns | 0.0166 ns | 0.0056 |      24 B |
             Set_Field_Struct | 130.99 ns | 0.1872 ns | 0.1751 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 207.61 ns | 0.7166 ns | 0.6353 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 260.98 ns | 0.6709 ns | 0.3993 ns | 0.1235 |     520 B |
  Set_Field_WithConvert_Class | 207.69 ns | 0.5487 ns | 0.5133 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 259.94 ns | 1.4461 ns | 1.3527 ns | 0.1235 |     520 B |
