
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.299 ns | 0.0044 ns | 0.0039 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  53.143 ns | 0.2187 ns | 0.1939 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.259 ns | 0.0076 ns | 0.0060 ns | 0.0057 |      24 B |
             Get_Field_Struct |  52.762 ns | 0.0193 ns | 0.0150 ns | 0.1296 |     544 B |
               Set_Prop_Class |   4.771 ns | 0.0130 ns | 0.0122 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  53.664 ns | 0.0561 ns | 0.0525 ns | 0.1296 |     544 B |
              Set_Field_Class |   5.539 ns | 0.0094 ns | 0.0078 ns | 0.0057 |      24 B |
             Set_Field_Struct |  53.918 ns | 0.0619 ns | 0.0549 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 207.962 ns | 0.1235 ns | 0.1095 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 260.448 ns | 0.2283 ns | 0.2024 ns | 0.1235 |     520 B |
  Set_Field_WithConvert_Class | 206.377 ns | 0.2330 ns | 0.2066 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 259.252 ns | 0.7859 ns | 0.7351 ns | 0.1235 |     520 B |
