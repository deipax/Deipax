
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  4.587 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
              Get_Prop_Struct | 52.730 ns | 0.1560 ns | 0.1459 ns | 0.1239 |     520 B |
              Get_Field_Class |  4.328 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
             Get_Field_Struct | 52.095 ns | 0.0522 ns | 0.0408 ns | 0.1239 |     520 B |
               Set_Prop_Class | 11.489 ns | 0.0127 ns | 0.0113 ns |      - |       0 B |
              Set_Prop_Struct | 61.807 ns | 0.1966 ns | 0.1839 ns | 0.1239 |     520 B |
              Set_Field_Class | 13.259 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
             Set_Field_Struct | 61.705 ns | 0.4338 ns | 0.3845 ns | 0.1239 |     520 B |
   Set_Prop_WithConvert_Class | 11.493 ns | 0.0131 ns | 0.0123 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 60.970 ns | 0.0456 ns | 0.0356 ns | 0.1239 |     520 B |
  Set_Field_WithConvert_Class | 11.485 ns | 0.0091 ns | 0.0081 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 61.248 ns | 0.1349 ns | 0.1126 ns | 0.1239 |     520 B |
