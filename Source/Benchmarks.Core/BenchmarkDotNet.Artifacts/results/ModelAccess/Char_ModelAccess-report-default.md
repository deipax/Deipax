
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  5.257 ns | 0.0065 ns | 0.0057 ns | 0.0057 |      24 B |
              Get_Prop_Struct | 53.443 ns | 0.0339 ns | 0.0300 ns | 0.1296 |     544 B |
              Get_Field_Class |  5.256 ns | 0.0062 ns | 0.0055 ns | 0.0057 |      24 B |
             Get_Field_Struct | 52.827 ns | 0.1457 ns | 0.1363 ns | 0.1296 |     544 B |
               Set_Prop_Class |  4.797 ns | 0.0272 ns | 0.0255 ns | 0.0057 |      24 B |
              Set_Prop_Struct | 54.235 ns | 0.0231 ns | 0.0193 ns | 0.1296 |     544 B |
              Set_Field_Class |  5.549 ns | 0.0050 ns | 0.0045 ns | 0.0057 |      24 B |
             Set_Field_Struct | 54.558 ns | 0.0735 ns | 0.0614 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 15.873 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 65.552 ns | 0.0708 ns | 0.0591 ns | 0.1239 |     520 B |
  Set_Field_WithConvert_Class | 16.356 ns | 0.0314 ns | 0.0293 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 65.881 ns | 0.0767 ns | 0.0599 ns | 0.1239 |     520 B |
