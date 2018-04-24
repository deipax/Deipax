
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.027 ns | 0.0037 ns | 0.0033 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  53.478 ns | 0.0664 ns | 0.0621 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.025 ns | 0.0049 ns | 0.0044 ns | 0.0057 |      24 B |
             Get_Field_Struct |  53.435 ns | 0.3379 ns | 0.2996 ns | 0.1296 |     544 B |
               Set_Prop_Class |   5.063 ns | 0.0067 ns | 0.0059 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  54.561 ns | 0.2852 ns | 0.2528 ns | 0.1296 |     544 B |
              Set_Field_Class |   5.564 ns | 0.0112 ns | 0.0099 ns | 0.0057 |      24 B |
             Set_Field_Struct |  53.014 ns | 0.0566 ns | 0.0529 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 117.787 ns | 0.3196 ns | 0.2989 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 166.055 ns | 0.2925 ns | 0.2736 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 116.127 ns | 0.1288 ns | 0.1142 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 166.927 ns | 0.3318 ns | 0.3103 ns | 0.1237 |     520 B |
