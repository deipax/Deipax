
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  24.53 ns | 0.0064 ns | 0.0054 ns |       0 B |
              Get_Prop_Struct |  24.85 ns | 0.0208 ns | 0.0162 ns |       0 B |
              Get_Field_Class |  24.68 ns | 0.1611 ns | 0.1507 ns |       0 B |
             Get_Field_Struct |  24.76 ns | 0.0288 ns | 0.0256 ns |       0 B |
               Set_Prop_Class |  12.96 ns | 0.0133 ns | 0.0124 ns |       0 B |
              Set_Prop_Struct |  14.00 ns | 0.0212 ns | 0.0188 ns |       0 B |
              Set_Field_Class |  12.92 ns | 0.0096 ns | 0.0090 ns |       0 B |
             Set_Field_Struct |  13.05 ns | 0.0615 ns | 0.0545 ns |       0 B |
   Set_Prop_WithConvert_Class | 103.08 ns | 0.0769 ns | 0.0642 ns |       0 B |
  Set_Prop_WithConvert_Struct | 102.15 ns | 0.1488 ns | 0.1392 ns |       0 B |
  Set_Field_WithConvert_Class | 103.04 ns | 0.1077 ns | 0.0955 ns |       0 B |
 Set_Field_WithConvert_Struct | 103.49 ns | 0.1395 ns | 0.1237 ns |       0 B |
