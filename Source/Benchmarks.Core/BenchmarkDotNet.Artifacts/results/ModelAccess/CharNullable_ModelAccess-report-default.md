
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |     Mean |     Error |    StdDev | Allocated |
----------------------------- |---------:|----------:|----------:|----------:|
               Get_Prop_Class | 24.70 ns | 0.0206 ns | 0.0192 ns |       0 B |
              Get_Prop_Struct | 28.18 ns | 0.2269 ns | 0.2122 ns |       0 B |
              Get_Field_Class | 25.69 ns | 0.0083 ns | 0.0073 ns |       0 B |
             Get_Field_Struct | 25.50 ns | 0.0379 ns | 0.0317 ns |       0 B |
               Set_Prop_Class | 14.16 ns | 0.0300 ns | 0.0250 ns |       0 B |
              Set_Prop_Struct | 16.37 ns | 0.2516 ns | 0.2101 ns |       0 B |
              Set_Field_Class | 14.05 ns | 0.0132 ns | 0.0123 ns |       0 B |
             Set_Field_Struct | 14.02 ns | 0.0246 ns | 0.0230 ns |       0 B |
   Set_Prop_WithConvert_Class | 14.58 ns | 0.0200 ns | 0.0187 ns |       0 B |
  Set_Prop_WithConvert_Struct | 16.96 ns | 0.0384 ns | 0.0359 ns |       0 B |
  Set_Field_WithConvert_Class | 14.57 ns | 0.0101 ns | 0.0090 ns |       0 B |
 Set_Field_WithConvert_Struct | 14.77 ns | 0.0095 ns | 0.0089 ns |       0 B |
