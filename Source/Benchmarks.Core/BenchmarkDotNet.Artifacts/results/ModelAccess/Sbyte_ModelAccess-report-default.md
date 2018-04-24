
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.044 ns | 0.0038 ns | 0.0035 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  53.633 ns | 0.0431 ns | 0.0382 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.068 ns | 0.0392 ns | 0.0347 ns | 0.0057 |      24 B |
             Get_Field_Struct |  53.973 ns | 0.0797 ns | 0.0576 ns | 0.1296 |     544 B |
               Set_Prop_Class |   4.851 ns | 0.0374 ns | 0.0349 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  54.809 ns | 0.0379 ns | 0.0336 ns | 0.1296 |     544 B |
              Set_Field_Class |   5.612 ns | 0.0368 ns | 0.0327 ns | 0.0057 |      24 B |
             Set_Field_Struct |  54.216 ns | 0.0403 ns | 0.0315 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 106.439 ns | 0.1193 ns | 0.1116 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 156.513 ns | 0.1647 ns | 0.1460 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 106.203 ns | 0.2350 ns | 0.2198 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 157.603 ns | 0.2818 ns | 0.2636 ns | 0.1237 |     520 B |
