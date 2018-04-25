
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  4.485 ns | 0.0047 ns | 0.0044 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  4.525 ns | 0.0084 ns | 0.0079 ns | 0.0057 |      24 B |
              Get_Field_Class |  4.487 ns | 0.0033 ns | 0.0030 ns | 0.0057 |      24 B |
             Get_Field_Struct |  4.243 ns | 0.0060 ns | 0.0056 ns | 0.0057 |      24 B |
               Set_Prop_Class |  3.176 ns | 0.1034 ns | 0.0917 ns |      - |       0 B |
              Set_Prop_Struct |  2.624 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
              Set_Field_Class |  3.314 ns | 0.0094 ns | 0.0084 ns |      - |       0 B |
             Set_Field_Struct |  3.332 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 39.199 ns | 0.0360 ns | 0.0319 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 39.022 ns | 0.0453 ns | 0.0424 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 41.120 ns | 0.0383 ns | 0.0359 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 39.055 ns | 0.0158 ns | 0.0132 ns |      - |       0 B |
