
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  34.35 ns | 0.0564 ns | 0.0500 ns |      - |       0 B |
              Get_Prop_Struct |  84.66 ns | 0.5376 ns | 0.5029 ns | 0.1239 |     520 B |
              Get_Field_Class |  34.55 ns | 0.0360 ns | 0.0320 ns |      - |       0 B |
             Get_Field_Struct |  85.07 ns | 0.5351 ns | 0.5005 ns | 0.1239 |     520 B |
               Set_Prop_Class |  79.53 ns | 0.0684 ns | 0.0607 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 129.98 ns | 0.0988 ns | 0.0771 ns | 0.1295 |     544 B |
              Set_Field_Class |  81.99 ns | 0.0537 ns | 0.0449 ns | 0.0056 |      24 B |
             Set_Field_Struct | 130.20 ns | 0.6903 ns | 0.6119 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 116.46 ns | 0.0366 ns | 0.0342 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 167.80 ns | 0.8865 ns | 0.8292 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 116.74 ns | 0.1430 ns | 0.1268 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 168.75 ns | 0.9494 ns | 0.7412 ns | 0.1237 |     520 B |
