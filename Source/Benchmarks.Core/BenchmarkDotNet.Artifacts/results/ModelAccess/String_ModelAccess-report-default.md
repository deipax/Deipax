
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  2.311 ns | 0.0013 ns | 0.0012 ns |      - |       0 B |
              Get_Prop_Struct |  2.317 ns | 0.0034 ns | 0.0030 ns |      - |       0 B |
              Get_Field_Class |  2.312 ns | 0.0002 ns | 0.0001 ns |      - |       0 B |
             Get_Field_Struct |  2.824 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
               Set_Prop_Class |  4.866 ns | 0.0029 ns | 0.0028 ns |      - |       0 B |
              Set_Prop_Struct |  4.864 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
              Set_Field_Class |  4.869 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
             Set_Field_Struct |  4.611 ns | 0.0021 ns | 0.0020 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 75.387 ns | 0.0484 ns | 0.0404 ns | 0.0113 |      48 B |
  Set_Prop_WithConvert_Struct | 73.531 ns | 0.0305 ns | 0.0270 ns | 0.0113 |      48 B |
  Set_Field_WithConvert_Class | 73.634 ns | 0.0405 ns | 0.0359 ns | 0.0113 |      48 B |
 Set_Field_WithConvert_Struct | 74.911 ns | 0.0352 ns | 0.0329 ns | 0.0113 |      48 B |
