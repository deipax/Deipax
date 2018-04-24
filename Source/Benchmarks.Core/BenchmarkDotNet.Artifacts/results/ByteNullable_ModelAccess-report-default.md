
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  35.72 ns | 0.0103 ns | 0.0081 ns |      - |       0 B |
              Get_Prop_Struct |  84.71 ns | 0.3331 ns | 0.3116 ns | 0.1239 |     520 B |
              Get_Field_Class |  33.75 ns | 0.0563 ns | 0.0526 ns |      - |       0 B |
             Get_Field_Struct |  85.30 ns | 0.4732 ns | 0.4426 ns | 0.1239 |     520 B |
               Set_Prop_Class |  79.26 ns | 0.0375 ns | 0.0313 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 130.10 ns | 0.0781 ns | 0.0564 ns | 0.1295 |     544 B |
              Set_Field_Class |  78.96 ns | 0.0298 ns | 0.0249 ns | 0.0056 |      24 B |
             Set_Field_Struct | 130.31 ns | 0.7945 ns | 0.7043 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class | 115.85 ns | 0.0813 ns | 0.0721 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 165.50 ns | 0.1113 ns | 0.0930 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 115.72 ns | 0.5738 ns | 0.5087 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 165.25 ns | 0.3848 ns | 0.3411 ns | 0.1237 |     520 B |
