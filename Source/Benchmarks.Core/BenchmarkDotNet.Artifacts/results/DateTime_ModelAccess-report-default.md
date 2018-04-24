
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.134 ns | 0.0054 ns | 0.0050 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  53.896 ns | 0.1670 ns | 0.1481 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.045 ns | 0.0053 ns | 0.0049 ns | 0.0057 |      24 B |
             Get_Field_Struct |  53.462 ns | 0.0950 ns | 0.0794 ns | 0.1296 |     544 B |
               Set_Prop_Class |   5.548 ns | 0.0040 ns | 0.0035 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  53.575 ns | 0.1455 ns | 0.1290 ns | 0.1296 |     544 B |
              Set_Field_Class |   4.784 ns | 0.0051 ns | 0.0047 ns | 0.0057 |      24 B |
             Set_Field_Struct |  54.858 ns | 0.1293 ns | 0.1080 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 739.848 ns | 0.5263 ns | 0.4394 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 798.925 ns | 6.0942 ns | 5.4024 ns | 0.1230 |     520 B |
  Set_Field_WithConvert_Class | 738.618 ns | 1.3226 ns | 1.1725 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 822.886 ns | 1.1920 ns | 0.9954 ns | 0.1230 |     520 B |
