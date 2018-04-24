
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.007 ns | 0.0054 ns | 0.0050 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  52.207 ns | 0.0372 ns | 0.0310 ns | 0.1296 |     544 B |
              Get_Field_Class |   4.999 ns | 0.0011 ns | 0.0009 ns | 0.0057 |      24 B |
             Get_Field_Struct |  52.764 ns | 0.1348 ns | 0.1195 ns | 0.1296 |     544 B |
               Set_Prop_Class |   5.026 ns | 0.0069 ns | 0.0064 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  54.282 ns | 0.0885 ns | 0.0828 ns | 0.1296 |     544 B |
              Set_Field_Class |   5.530 ns | 0.0056 ns | 0.0052 ns | 0.0057 |      24 B |
             Set_Field_Struct |  53.307 ns | 0.0484 ns | 0.0429 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 199.184 ns | 2.8706 ns | 2.5447 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 247.080 ns | 0.5772 ns | 0.5399 ns | 0.1235 |     520 B |
  Set_Field_WithConvert_Class | 205.055 ns | 0.8401 ns | 0.7447 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 246.231 ns | 0.4917 ns | 0.4599 ns | 0.1235 |     520 B |
