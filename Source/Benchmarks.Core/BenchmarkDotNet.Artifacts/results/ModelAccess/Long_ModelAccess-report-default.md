
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.000 ns | 0.0239 ns | 0.0212 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  53.020 ns | 0.2177 ns | 0.1818 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.013 ns | 0.0318 ns | 0.0297 ns | 0.0057 |      24 B |
             Get_Field_Struct |  53.261 ns | 0.5857 ns | 0.5478 ns | 0.1296 |     544 B |
               Set_Prop_Class |   4.774 ns | 0.0077 ns | 0.0072 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  54.407 ns | 0.1092 ns | 0.0968 ns | 0.1296 |     544 B |
              Set_Field_Class |   4.756 ns | 0.0064 ns | 0.0056 ns | 0.0057 |      24 B |
             Set_Field_Struct |  53.803 ns | 0.0689 ns | 0.0645 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 189.347 ns | 0.2332 ns | 0.2181 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 239.990 ns | 0.1650 ns | 0.1462 ns | 0.1235 |     520 B |
  Set_Field_WithConvert_Class | 189.836 ns | 0.1754 ns | 0.1641 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 239.777 ns | 0.1521 ns | 0.1270 ns | 0.1235 |     520 B |
