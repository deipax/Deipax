
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |     Mean |     Error |    StdDev | Allocated |
----------------------------- |---------:|----------:|----------:|----------:|
               Get_Prop_Class | 24.26 ns | 0.1321 ns | 0.1103 ns |       0 B |
              Get_Prop_Struct | 24.68 ns | 0.0999 ns | 0.0934 ns |       0 B |
              Get_Field_Class | 24.35 ns | 0.0269 ns | 0.0239 ns |       0 B |
             Get_Field_Struct | 24.46 ns | 0.0730 ns | 0.0683 ns |       0 B |
               Set_Prop_Class | 13.72 ns | 0.0176 ns | 0.0147 ns |       0 B |
              Set_Prop_Struct | 13.56 ns | 0.0084 ns | 0.0066 ns |       0 B |
              Set_Field_Class | 14.47 ns | 0.0154 ns | 0.0137 ns |       0 B |
             Set_Field_Struct | 14.39 ns | 0.0135 ns | 0.0113 ns |       0 B |
   Set_Prop_WithConvert_Class | 24.14 ns | 0.0110 ns | 0.0103 ns |       0 B |
  Set_Prop_WithConvert_Struct | 20.08 ns | 0.0165 ns | 0.0137 ns |       0 B |
  Set_Field_WithConvert_Class | 20.77 ns | 0.4252 ns | 0.3977 ns |       0 B |
 Set_Field_WithConvert_Struct | 20.06 ns | 0.0278 ns | 0.0260 ns |       0 B |
