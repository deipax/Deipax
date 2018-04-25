
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  35.60 ns | 0.2447 ns | 0.2289 ns |      - |       0 B |
              Get_Prop_Struct |  83.66 ns | 0.1626 ns | 0.1521 ns | 0.1239 |     520 B |
              Get_Field_Class |  33.91 ns | 0.0779 ns | 0.0729 ns |      - |       0 B |
             Get_Field_Struct |  83.02 ns | 0.0868 ns | 0.0770 ns | 0.1239 |     520 B |
               Set_Prop_Class |  82.24 ns | 0.0286 ns | 0.0239 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 132.10 ns | 0.1523 ns | 0.1101 ns | 0.1295 |     544 B |
              Set_Field_Class |  82.64 ns | 0.2291 ns | 0.2143 ns | 0.0056 |      24 B |
             Set_Field_Struct | 131.42 ns | 0.1244 ns | 0.1163 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 678.59 ns | 1.3160 ns | 1.2310 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 794.28 ns | 1.5107 ns | 1.4131 ns | 0.1230 |     520 B |
  Set_Field_WithConvert_Class | 678.82 ns | 0.3504 ns | 0.2926 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 794.48 ns | 1.5962 ns | 1.4931 ns | 0.1221 |     520 B |
