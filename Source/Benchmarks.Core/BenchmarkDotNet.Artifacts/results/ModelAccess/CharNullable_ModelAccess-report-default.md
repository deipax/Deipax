
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  34.96 ns | 0.0209 ns | 0.0163 ns |      - |       0 B |
              Get_Prop_Struct |  84.48 ns | 0.0701 ns | 0.0548 ns | 0.1239 |     520 B |
              Get_Field_Class |  35.12 ns | 0.0330 ns | 0.0293 ns |      - |       0 B |
             Get_Field_Struct |  84.96 ns | 0.0954 ns | 0.0892 ns | 0.1239 |     520 B |
               Set_Prop_Class |  80.87 ns | 0.0315 ns | 0.0294 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 130.71 ns | 0.6099 ns | 0.5093 ns | 0.1295 |     544 B |
              Set_Field_Class |  80.66 ns | 0.2298 ns | 0.2150 ns | 0.0056 |      24 B |
             Set_Field_Struct | 129.84 ns | 0.6496 ns | 0.6076 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class |  17.33 ns | 0.0205 ns | 0.0171 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct |  66.81 ns | 0.0246 ns | 0.0192 ns | 0.1239 |     520 B |
  Set_Field_WithConvert_Class |  17.16 ns | 0.0225 ns | 0.0210 ns |      - |       0 B |
 Set_Field_WithConvert_Struct |  67.15 ns | 0.2028 ns | 0.1897 ns | 0.1239 |     520 B |
