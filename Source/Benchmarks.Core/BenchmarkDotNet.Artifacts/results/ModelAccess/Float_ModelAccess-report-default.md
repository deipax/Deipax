
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.105 ns | 0.0033 ns | 0.0029 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  53.024 ns | 0.0661 ns | 0.0478 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.064 ns | 0.0110 ns | 0.0097 ns | 0.0057 |      24 B |
             Get_Field_Struct |  53.237 ns | 0.0180 ns | 0.0168 ns | 0.1296 |     544 B |
               Set_Prop_Class |   4.825 ns | 0.0032 ns | 0.0021 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  56.368 ns | 0.0448 ns | 0.0374 ns | 0.1296 |     544 B |
              Set_Field_Class |   5.558 ns | 0.0096 ns | 0.0075 ns | 0.0057 |      24 B |
             Set_Field_Struct |  53.912 ns | 0.1539 ns | 0.1440 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 158.791 ns | 0.3493 ns | 0.3267 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 210.579 ns | 0.2512 ns | 0.1816 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 157.534 ns | 0.2008 ns | 0.1878 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 210.167 ns | 0.2620 ns | 0.1894 ns | 0.1237 |     520 B |
