
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  4.568 ns | 0.0153 ns | 0.0111 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  4.584 ns | 0.0430 ns | 0.0382 ns | 0.0057 |      24 B |
              Get_Field_Class |  4.554 ns | 0.0021 ns | 0.0019 ns | 0.0057 |      24 B |
             Get_Field_Struct |  4.287 ns | 0.0011 ns | 0.0010 ns | 0.0057 |      24 B |
               Set_Prop_Class |  3.264 ns | 0.0135 ns | 0.0120 ns |      - |       0 B |
              Set_Prop_Struct |  3.135 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
              Set_Field_Class |  3.394 ns | 0.0128 ns | 0.0120 ns |      - |       0 B |
             Set_Field_Struct |  3.142 ns | 0.0072 ns | 0.0064 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 13.034 ns | 0.0038 ns | 0.0035 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 14.054 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 12.887 ns | 0.0116 ns | 0.0108 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 12.907 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
