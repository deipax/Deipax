
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.527 ns | 0.0017 ns | 0.0015 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.535 ns | 0.0046 ns | 0.0041 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.532 ns | 0.0060 ns | 0.0056 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.294 ns | 0.0030 ns | 0.0028 ns | 0.0057 |      24 B |
               Set_Prop_Class |   3.148 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
              Set_Prop_Struct |   3.018 ns | 0.0345 ns | 0.0323 ns |      - |       0 B |
              Set_Field_Class |   3.402 ns | 0.0035 ns | 0.0033 ns |      - |       0 B |
             Set_Field_Struct |   3.067 ns | 0.0076 ns | 0.0068 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 203.508 ns | 0.0269 ns | 0.0210 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 203.852 ns | 0.3059 ns | 0.2711 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 203.981 ns | 0.0615 ns | 0.0545 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 204.226 ns | 0.3931 ns | 0.3677 ns |      - |       0 B |
