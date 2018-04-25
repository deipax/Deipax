
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  4.519 ns | 0.0131 ns | 0.0110 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  4.567 ns | 0.0088 ns | 0.0069 ns | 0.0057 |      24 B |
              Get_Field_Class |  4.506 ns | 0.0026 ns | 0.0023 ns | 0.0057 |      24 B |
             Get_Field_Struct |  4.520 ns | 0.0051 ns | 0.0048 ns | 0.0057 |      24 B |
               Set_Prop_Class |  2.589 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
              Set_Prop_Struct |  3.310 ns | 0.0071 ns | 0.0067 ns |      - |       0 B |
              Set_Field_Class |  3.384 ns | 0.0346 ns | 0.0289 ns |      - |       0 B |
             Set_Field_Struct |  3.310 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 15.889 ns | 0.0180 ns | 0.0168 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 15.668 ns | 0.0039 ns | 0.0032 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 16.366 ns | 0.0157 ns | 0.0147 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 15.595 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
