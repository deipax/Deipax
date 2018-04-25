
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  4.311 ns | 0.0521 ns | 0.0488 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  4.303 ns | 0.0347 ns | 0.0308 ns | 0.0057 |      24 B |
              Get_Field_Class |  4.314 ns | 0.0546 ns | 0.0484 ns | 0.0057 |      24 B |
             Get_Field_Struct |  4.255 ns | 0.0043 ns | 0.0038 ns | 0.0057 |      24 B |
               Set_Prop_Class |  3.548 ns | 0.0572 ns | 0.0447 ns |      - |       0 B |
              Set_Prop_Struct |  2.889 ns | 0.1010 ns | 0.0895 ns |      - |       0 B |
              Set_Field_Class |  2.632 ns | 0.0067 ns | 0.0059 ns |      - |       0 B |
             Set_Field_Struct |  3.775 ns | 0.0740 ns | 0.0692 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 21.879 ns | 0.0264 ns | 0.0247 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 21.997 ns | 0.0353 ns | 0.0295 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 21.720 ns | 0.0143 ns | 0.0133 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 22.301 ns | 0.0221 ns | 0.0207 ns |      - |       0 B |
