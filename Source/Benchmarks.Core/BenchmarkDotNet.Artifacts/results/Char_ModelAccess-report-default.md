
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  5.278 ns | 0.0030 ns | 0.0025 ns | 0.0057 |      24 B |
              Get_Prop_Struct | 52.796 ns | 0.1197 ns | 0.1000 ns | 0.1296 |     544 B |
              Get_Field_Class |  5.319 ns | 0.0354 ns | 0.0331 ns | 0.0057 |      24 B |
             Get_Field_Struct | 52.666 ns | 0.0312 ns | 0.0261 ns | 0.1296 |     544 B |
               Set_Prop_Class |  5.606 ns | 0.0290 ns | 0.0272 ns | 0.0057 |      24 B |
              Set_Prop_Struct | 54.185 ns | 0.0574 ns | 0.0480 ns | 0.1296 |     544 B |
              Set_Field_Class |  5.060 ns | 0.0036 ns | 0.0028 ns | 0.0057 |      24 B |
             Set_Field_Struct | 54.297 ns | 0.1256 ns | 0.1049 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 19.624 ns | 0.0196 ns | 0.0174 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 69.841 ns | 0.0284 ns | 0.0222 ns | 0.1239 |     520 B |
  Set_Field_WithConvert_Class | 20.455 ns | 0.0110 ns | 0.0103 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 69.415 ns | 0.1138 ns | 0.1008 ns | 0.1239 |     520 B |
