
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.255 ns | 0.0034 ns | 0.0030 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  52.984 ns | 0.0868 ns | 0.0812 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.255 ns | 0.0039 ns | 0.0035 ns | 0.0057 |      24 B |
             Get_Field_Struct |  53.244 ns | 0.0704 ns | 0.0624 ns | 0.1296 |     544 B |
               Set_Prop_Class |   4.796 ns | 0.0050 ns | 0.0039 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  53.305 ns | 0.0519 ns | 0.0486 ns | 0.1296 |     544 B |
              Set_Field_Class |   5.539 ns | 0.0039 ns | 0.0034 ns | 0.0057 |      24 B |
             Set_Field_Struct |  53.940 ns | 0.0485 ns | 0.0405 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 143.010 ns | 0.2649 ns | 0.2348 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 192.608 ns | 0.3484 ns | 0.3088 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 141.516 ns | 0.0351 ns | 0.0311 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 191.879 ns | 0.2375 ns | 0.2106 ns | 0.1237 |     520 B |
