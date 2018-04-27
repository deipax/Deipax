
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.030 ns | 0.0028 ns | 0.0026 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.280 ns | 0.0087 ns | 0.0081 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.030 ns | 0.0036 ns | 0.0032 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.515 ns | 0.0015 ns | 0.0013 ns | 0.0057 |      24 B |
               Set_Prop_Class |   3.017 ns | 0.0021 ns | 0.0020 ns |      - |       0 B |
              Set_Prop_Struct |   2.991 ns | 0.0071 ns | 0.0066 ns |      - |       0 B |
              Set_Field_Class |   3.050 ns | 0.0031 ns | 0.0027 ns |      - |       0 B |
             Set_Field_Struct |   2.930 ns | 0.0046 ns | 0.0041 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 135.383 ns | 0.1002 ns | 0.0888 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 134.080 ns | 0.0726 ns | 0.0643 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 134.122 ns | 0.0858 ns | 0.0803 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 134.459 ns | 0.0802 ns | 0.0670 ns |      - |       0 B |
