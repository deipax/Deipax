
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |     Mean |     Error |    StdDev | Allocated |
----------------------------- |---------:|----------:|----------:|----------:|
               Get_Prop_Class | 2.058 ns | 0.0016 ns | 0.0015 ns |       0 B |
              Get_Prop_Struct | 1.802 ns | 0.0007 ns | 0.0007 ns |       0 B |
              Get_Field_Class | 1.802 ns | 0.0002 ns | 0.0002 ns |       0 B |
             Get_Field_Struct | 1.803 ns | 0.0014 ns | 0.0013 ns |       0 B |
               Set_Prop_Class | 6.299 ns | 0.0033 ns | 0.0031 ns |       0 B |
              Set_Prop_Struct | 6.144 ns | 0.0054 ns | 0.0051 ns |       0 B |
              Set_Field_Class | 6.324 ns | 0.0043 ns | 0.0040 ns |       0 B |
             Set_Field_Struct | 6.155 ns | 0.0040 ns | 0.0037 ns |       0 B |
   Set_Prop_WithConvert_Class | 6.356 ns | 0.0036 ns | 0.0032 ns |       0 B |
  Set_Prop_WithConvert_Struct | 6.142 ns | 0.0033 ns | 0.0031 ns |       0 B |
  Set_Field_WithConvert_Class | 6.299 ns | 0.0028 ns | 0.0025 ns |       0 B |
 Set_Field_WithConvert_Struct | 6.153 ns | 0.0014 ns | 0.0013 ns |       0 B |
