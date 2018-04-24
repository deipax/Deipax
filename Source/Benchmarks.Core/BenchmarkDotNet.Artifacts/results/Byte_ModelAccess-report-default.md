
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.276 ns | 0.0066 ns | 0.0055 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  52.327 ns | 0.0849 ns | 0.0794 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.298 ns | 0.0077 ns | 0.0068 ns | 0.0057 |      24 B |
             Get_Field_Struct |  52.297 ns | 0.0730 ns | 0.0647 ns | 0.1296 |     544 B |
               Set_Prop_Class |   5.590 ns | 0.0101 ns | 0.0084 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  54.103 ns | 0.0620 ns | 0.0549 ns | 0.1296 |     544 B |
              Set_Field_Class |   4.802 ns | 0.0090 ns | 0.0075 ns | 0.0057 |      24 B |
             Set_Field_Struct |  54.812 ns | 0.1075 ns | 0.1006 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 106.629 ns | 0.6226 ns | 0.5519 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 156.006 ns | 0.0707 ns | 0.0627 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 106.383 ns | 0.0835 ns | 0.0652 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 155.521 ns | 0.2316 ns | 0.2167 ns | 0.1237 |     520 B |
