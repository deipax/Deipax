
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  35.22 ns | 0.1070 ns | 0.1001 ns |      - |       0 B |
              Get_Prop_Struct |  85.83 ns | 0.0380 ns | 0.0318 ns | 0.1239 |     520 B |
              Get_Field_Class |  36.32 ns | 0.1241 ns | 0.1161 ns |      - |       0 B |
             Get_Field_Struct |  86.38 ns | 0.0972 ns | 0.0909 ns | 0.1239 |     520 B |
               Set_Prop_Class |  79.52 ns | 0.1549 ns | 0.1373 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 131.06 ns | 0.1501 ns | 0.1254 ns | 0.1295 |     544 B |
              Set_Field_Class |  78.95 ns | 0.1276 ns | 0.1131 ns | 0.0056 |      24 B |
             Set_Field_Struct | 130.38 ns | 0.0979 ns | 0.0818 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 128.36 ns | 0.0454 ns | 0.0379 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 181.31 ns | 0.1094 ns | 0.0914 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 127.56 ns | 0.2438 ns | 0.2161 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 182.07 ns | 0.0725 ns | 0.0642 ns | 0.1237 |     520 B |
