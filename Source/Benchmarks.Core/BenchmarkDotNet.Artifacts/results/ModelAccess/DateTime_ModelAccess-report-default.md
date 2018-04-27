
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.525 ns | 0.0044 ns | 0.0042 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.524 ns | 0.0031 ns | 0.0029 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.543 ns | 0.0020 ns | 0.0018 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.287 ns | 0.0036 ns | 0.0032 ns | 0.0057 |      24 B |
               Set_Prop_Class |   3.210 ns | 0.0053 ns | 0.0047 ns |      - |       0 B |
              Set_Prop_Struct |   2.967 ns | 0.0063 ns | 0.0056 ns |      - |       0 B |
              Set_Field_Class |   3.337 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
             Set_Field_Struct |   3.147 ns | 0.0174 ns | 0.0163 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 798.561 ns | 0.4555 ns | 0.4038 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 787.868 ns | 0.6290 ns | 0.5883 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 794.075 ns | 0.4896 ns | 0.4340 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 812.960 ns | 0.4279 ns | 0.4002 ns |      - |       0 B |
