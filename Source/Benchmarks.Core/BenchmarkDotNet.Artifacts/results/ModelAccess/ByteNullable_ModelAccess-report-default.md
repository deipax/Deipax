
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  24.86 ns | 0.0361 ns | 0.0338 ns |       0 B |
              Get_Prop_Struct |  24.01 ns | 0.0531 ns | 0.0497 ns |       0 B |
              Get_Field_Class |  24.09 ns | 0.0201 ns | 0.0157 ns |       0 B |
             Get_Field_Struct |  24.41 ns | 0.0798 ns | 0.0746 ns |       0 B |
               Set_Prop_Class |  13.04 ns | 0.0043 ns | 0.0036 ns |       0 B |
              Set_Prop_Struct |  12.94 ns | 0.0064 ns | 0.0050 ns |       0 B |
              Set_Field_Class |  13.04 ns | 0.0169 ns | 0.0141 ns |       0 B |
             Set_Field_Struct |  12.99 ns | 0.0177 ns | 0.0138 ns |       0 B |
   Set_Prop_WithConvert_Class | 102.56 ns | 0.2775 ns | 0.2460 ns |       0 B |
  Set_Prop_WithConvert_Struct | 102.32 ns | 0.1161 ns | 0.1086 ns |       0 B |
  Set_Field_WithConvert_Class | 102.27 ns | 0.0809 ns | 0.0717 ns |       0 B |
 Set_Field_WithConvert_Struct | 102.00 ns | 0.1676 ns | 0.1568 ns |       0 B |
