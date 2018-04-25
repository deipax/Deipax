
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.522 ns | 0.0048 ns | 0.0037 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.504 ns | 0.0047 ns | 0.0042 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.506 ns | 0.0060 ns | 0.0056 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.507 ns | 0.0051 ns | 0.0047 ns | 0.0057 |      24 B |
               Set_Prop_Class |   2.594 ns | 0.0137 ns | 0.0115 ns |      - |       0 B |
              Set_Prop_Struct |   2.668 ns | 0.0252 ns | 0.0236 ns |      - |       0 B |
              Set_Field_Class |   3.308 ns | 0.0044 ns | 0.0042 ns |      - |       0 B |
             Set_Field_Struct |   3.305 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 143.454 ns | 0.5016 ns | 0.4692 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 139.551 ns | 0.3311 ns | 0.3098 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 140.961 ns | 0.0803 ns | 0.0751 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 138.854 ns | 0.0461 ns | 0.0360 ns |      - |       0 B |
