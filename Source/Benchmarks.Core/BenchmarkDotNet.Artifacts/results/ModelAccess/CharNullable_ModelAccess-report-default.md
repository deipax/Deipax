
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |     Mean |     Error |    StdDev | Allocated |
----------------------------- |---------:|----------:|----------:|----------:|
               Get_Prop_Class | 23.63 ns | 0.0117 ns | 0.0104 ns |       0 B |
              Get_Prop_Struct | 23.92 ns | 0.1418 ns | 0.1184 ns |       0 B |
              Get_Field_Class | 24.25 ns | 0.0469 ns | 0.0439 ns |       0 B |
             Get_Field_Struct | 24.41 ns | 0.0372 ns | 0.0330 ns |       0 B |
               Set_Prop_Class | 13.32 ns | 0.0341 ns | 0.0319 ns |       0 B |
              Set_Prop_Struct | 13.86 ns | 0.0251 ns | 0.0222 ns |       0 B |
              Set_Field_Class | 13.29 ns | 0.0274 ns | 0.0243 ns |       0 B |
             Set_Field_Struct | 12.97 ns | 0.0473 ns | 0.0443 ns |       0 B |
   Set_Prop_WithConvert_Class | 17.23 ns | 0.0297 ns | 0.0263 ns |       0 B |
  Set_Prop_WithConvert_Struct | 17.79 ns | 0.0130 ns | 0.0122 ns |       0 B |
  Set_Field_WithConvert_Class | 17.09 ns | 0.0115 ns | 0.0090 ns |       0 B |
 Set_Field_WithConvert_Struct | 17.10 ns | 0.0084 ns | 0.0078 ns |       0 B |
