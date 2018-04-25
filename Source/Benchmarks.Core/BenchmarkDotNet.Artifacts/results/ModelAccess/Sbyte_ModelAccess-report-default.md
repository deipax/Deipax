
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.054 ns | 0.0056 ns | 0.0047 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  52.207 ns | 0.0515 ns | 0.0456 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.011 ns | 0.0126 ns | 0.0118 ns | 0.0057 |      24 B |
             Get_Field_Struct |  53.241 ns | 0.0527 ns | 0.0467 ns | 0.1296 |     544 B |
               Set_Prop_Class |   4.780 ns | 0.0380 ns | 0.0336 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  53.510 ns | 0.0333 ns | 0.0278 ns | 0.1296 |     544 B |
              Set_Field_Class |   4.796 ns | 0.0034 ns | 0.0027 ns | 0.0057 |      24 B |
             Set_Field_Struct |  53.574 ns | 0.0749 ns | 0.0701 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 103.095 ns | 0.4188 ns | 0.3713 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 153.217 ns | 0.1473 ns | 0.1230 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 103.490 ns | 0.4708 ns | 0.4404 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 153.005 ns | 0.1808 ns | 0.1510 ns | 0.1237 |     520 B |
