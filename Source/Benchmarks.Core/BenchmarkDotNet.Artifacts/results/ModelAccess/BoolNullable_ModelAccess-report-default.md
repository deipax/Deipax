
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  33.87 ns | 0.0583 ns | 0.0545 ns |      - |       0 B |
              Get_Prop_Struct |  83.52 ns | 0.0653 ns | 0.0579 ns | 0.1239 |     520 B |
              Get_Field_Class |  33.74 ns | 0.0177 ns | 0.0157 ns |      - |       0 B |
             Get_Field_Struct |  83.42 ns | 0.0816 ns | 0.0723 ns | 0.1239 |     520 B |
               Set_Prop_Class |  80.70 ns | 0.0885 ns | 0.0785 ns | 0.0056 |      24 B |
              Set_Prop_Struct | 130.22 ns | 0.5599 ns | 0.5237 ns | 0.1295 |     544 B |
              Set_Field_Class |  79.97 ns | 0.0316 ns | 0.0247 ns | 0.0056 |      24 B |
             Set_Field_Struct | 130.55 ns | 0.4709 ns | 0.4404 ns | 0.1295 |     544 B |
   Set_Prop_WithConvert_Class |  23.23 ns | 0.0052 ns | 0.0043 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct |  73.71 ns | 0.3020 ns | 0.2677 ns | 0.1239 |     520 B |
  Set_Field_WithConvert_Class |  23.30 ns | 0.0447 ns | 0.0418 ns |      - |       0 B |
 Set_Field_WithConvert_Struct |  73.53 ns | 0.3193 ns | 0.2987 ns | 0.1239 |     520 B |
