
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.563 ns | 0.0036 ns | 0.0032 ns | 0.0076 |      32 B |
              Get_Prop_Struct |   4.588 ns | 0.0090 ns | 0.0080 ns | 0.0076 |      32 B |
              Get_Field_Class |   4.600 ns | 0.0015 ns | 0.0012 ns | 0.0076 |      32 B |
             Get_Field_Struct |   5.059 ns | 0.0057 ns | 0.0053 ns | 0.0076 |      32 B |
               Set_Prop_Class |   3.144 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
              Set_Prop_Struct |   3.108 ns | 0.0120 ns | 0.0106 ns |      - |       0 B |
              Set_Field_Class |   3.137 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
             Set_Field_Struct |   3.373 ns | 0.0969 ns | 0.0859 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 648.738 ns | 0.2879 ns | 0.2693 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 650.138 ns | 0.0770 ns | 0.0643 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 650.191 ns | 0.3404 ns | 0.3184 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 648.833 ns | 0.1504 ns | 0.1333 ns |      - |       0 B |
