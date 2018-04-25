
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev | Allocated |
----------------------------- |----------:|----------:|----------:|----------:|
               Get_Prop_Class |  24.06 ns | 0.0338 ns | 0.0300 ns |       0 B |
              Get_Prop_Struct |  23.89 ns | 0.0218 ns | 0.0204 ns |       0 B |
              Get_Field_Class |  23.90 ns | 0.0229 ns | 0.0214 ns |       0 B |
             Get_Field_Struct |  23.86 ns | 0.0372 ns | 0.0330 ns |       0 B |
               Set_Prop_Class |  12.95 ns | 0.0152 ns | 0.0142 ns |       0 B |
              Set_Prop_Struct |  13.04 ns | 0.0149 ns | 0.0139 ns |       0 B |
              Set_Field_Class |  13.24 ns | 0.0355 ns | 0.0332 ns |       0 B |
             Set_Field_Struct |  13.29 ns | 0.0223 ns | 0.0198 ns |       0 B |
   Set_Prop_WithConvert_Class | 140.74 ns | 0.4374 ns | 0.4092 ns |       0 B |
  Set_Prop_WithConvert_Struct | 141.00 ns | 0.1298 ns | 0.1151 ns |       0 B |
  Set_Field_WithConvert_Class | 140.39 ns | 0.1211 ns | 0.1133 ns |       0 B |
 Set_Field_WithConvert_Struct | 139.18 ns | 0.1345 ns | 0.1258 ns |       0 B |
