
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.781 ns | 0.0056 ns | 0.0049 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  53.375 ns | 0.1840 ns | 0.1721 ns | 0.1296 |     544 B |
              Get_Field_Class |   4.796 ns | 0.0053 ns | 0.0050 ns | 0.0057 |      24 B |
             Get_Field_Struct |  53.585 ns | 0.3161 ns | 0.2957 ns | 0.1296 |     544 B |
               Set_Prop_Class |   5.095 ns | 0.0096 ns | 0.0090 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  54.480 ns | 0.2116 ns | 0.1980 ns | 0.1296 |     544 B |
              Set_Field_Class |   5.620 ns | 0.0112 ns | 0.0105 ns | 0.0057 |      24 B |
             Set_Field_Struct |  53.901 ns | 0.2899 ns | 0.2570 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 148.477 ns | 0.2632 ns | 0.2462 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 195.326 ns | 0.6432 ns | 0.6016 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 147.541 ns | 0.3975 ns | 0.3524 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 196.246 ns | 1.1770 ns | 1.1009 ns | 0.1237 |     520 B |
