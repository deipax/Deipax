
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  34.27 ns | 0.0317 ns | 0.0296 ns |      - |       0 B |
              Get_Prop_Struct |  84.19 ns | 0.0655 ns | 0.0512 ns | 0.1239 |     520 B |
              Get_Field_Class |  34.80 ns | 0.0461 ns | 0.0409 ns |      - |       0 B |
             Get_Field_Struct |  83.90 ns | 0.0363 ns | 0.0240 ns | 0.1239 |     520 B |
               Set_Prop_Class |  80.48 ns | 0.1022 ns | 0.0956 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 132.50 ns | 0.2532 ns | 0.2245 ns | 0.1295 |     544 B |
              Set_Field_Class |  81.90 ns | 0.0304 ns | 0.0254 ns | 0.0056 |      24 B |
             Set_Field_Struct | 131.39 ns | 0.4803 ns | 0.4493 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class |        NA |        NA |        NA |    N/A |       N/A |
  Set_Prop_WithConvert_Struct |        NA |        NA |        NA |    N/A |       N/A |
  Set_Field_WithConvert_Class |        NA |        NA |        NA |    N/A |       N/A |
 Set_Field_WithConvert_Struct |        NA |        NA |        NA |    N/A |       N/A |

Benchmarks with issues:
  DoubleNullable_ModelAccess.Set_Prop_WithConvert_Class: DefaultJob
  DoubleNullable_ModelAccess.Set_Prop_WithConvert_Struct: DefaultJob
  DoubleNullable_ModelAccess.Set_Field_WithConvert_Class: DefaultJob
  DoubleNullable_ModelAccess.Set_Field_WithConvert_Struct: DefaultJob
