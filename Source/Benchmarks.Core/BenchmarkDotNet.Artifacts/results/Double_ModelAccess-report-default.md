
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  5.294 ns | 0.0117 ns | 0.0104 ns | 0.0057 |      24 B |
              Get_Prop_Struct | 53.604 ns | 0.0373 ns | 0.0348 ns | 0.1296 |     544 B |
              Get_Field_Class |  5.378 ns | 0.0037 ns | 0.0029 ns | 0.0057 |      24 B |
             Get_Field_Struct | 52.733 ns | 0.0601 ns | 0.0502 ns | 0.1296 |     544 B |
               Set_Prop_Class |  5.568 ns | 0.0389 ns | 0.0364 ns | 0.0057 |      24 B |
              Set_Prop_Struct | 55.096 ns | 0.0259 ns | 0.0216 ns | 0.1296 |     544 B |
              Set_Field_Class |  4.824 ns | 0.0276 ns | 0.0244 ns | 0.0057 |      24 B |
             Set_Field_Struct | 54.254 ns | 0.0185 ns | 0.0164 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class |        NA |        NA |        NA |    N/A |       N/A |
  Set_Prop_WithConvert_Struct |        NA |        NA |        NA |    N/A |       N/A |
  Set_Field_WithConvert_Class |        NA |        NA |        NA |    N/A |       N/A |
 Set_Field_WithConvert_Struct |        NA |        NA |        NA |    N/A |       N/A |

Benchmarks with issues:
  Double_ModelAccess.Set_Prop_WithConvert_Class: DefaultJob
  Double_ModelAccess.Set_Prop_WithConvert_Struct: DefaultJob
  Double_ModelAccess.Set_Field_WithConvert_Class: DefaultJob
  Double_ModelAccess.Set_Field_WithConvert_Struct: DefaultJob
