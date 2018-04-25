
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.276 ns | 0.0031 ns | 0.0028 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  53.181 ns | 0.0403 ns | 0.0337 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.235 ns | 0.0047 ns | 0.0037 ns | 0.0057 |      24 B |
             Get_Field_Struct |  53.552 ns | 0.0646 ns | 0.0573 ns | 0.1296 |     544 B |
               Set_Prop_Class |   4.768 ns | 0.0074 ns | 0.0069 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  53.289 ns | 0.0917 ns | 0.0857 ns | 0.1296 |     544 B |
              Set_Field_Class |   5.538 ns | 0.0063 ns | 0.0055 ns | 0.0057 |      24 B |
             Set_Field_Struct |  54.306 ns | 0.2546 ns | 0.2382 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class |  99.755 ns | 0.1127 ns | 0.0999 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 150.493 ns | 0.1873 ns | 0.1752 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 100.030 ns | 0.1590 ns | 0.1328 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 150.898 ns | 0.1764 ns | 0.1650 ns | 0.1237 |     520 B |
