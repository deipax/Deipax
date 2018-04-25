
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.786 ns | 0.0042 ns | 0.0039 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  53.335 ns | 0.0218 ns | 0.0170 ns | 0.1296 |     544 B |
              Get_Field_Class |   4.748 ns | 0.0179 ns | 0.0168 ns | 0.0057 |      24 B |
             Get_Field_Struct |  52.470 ns | 0.0859 ns | 0.0804 ns | 0.1296 |     544 B |
               Set_Prop_Class |   4.778 ns | 0.0250 ns | 0.0234 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  54.556 ns | 0.0332 ns | 0.0295 ns | 0.1296 |     544 B |
              Set_Field_Class |   4.745 ns | 0.0034 ns | 0.0028 ns | 0.0057 |      24 B |
             Set_Field_Struct |  54.240 ns | 0.0635 ns | 0.0531 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 137.566 ns | 0.2046 ns | 0.1708 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 190.542 ns | 0.0847 ns | 0.0708 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 137.533 ns | 0.2276 ns | 0.2018 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 190.428 ns | 0.2150 ns | 0.1906 ns | 0.1237 |     520 B |
