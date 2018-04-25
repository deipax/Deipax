
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  5.001 ns | 0.0051 ns | 0.0047 ns | 0.0057 |      24 B |
              Get_Prop_Struct | 52.839 ns | 0.0345 ns | 0.0323 ns | 0.1296 |     544 B |
              Get_Field_Class |  4.986 ns | 0.0059 ns | 0.0046 ns | 0.0057 |      24 B |
             Get_Field_Struct | 52.018 ns | 0.0987 ns | 0.0824 ns | 0.1296 |     544 B |
               Set_Prop_Class |  4.798 ns | 0.0304 ns | 0.0269 ns | 0.0057 |      24 B |
              Set_Prop_Struct | 53.422 ns | 0.0292 ns | 0.0228 ns | 0.1296 |     544 B |
              Set_Field_Class |  4.780 ns | 0.0099 ns | 0.0088 ns | 0.0057 |      24 B |
             Set_Field_Struct | 53.725 ns | 0.0780 ns | 0.0609 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 21.829 ns | 0.0917 ns | 0.0813 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 71.893 ns | 0.0588 ns | 0.0550 ns | 0.1239 |     520 B |
  Set_Field_WithConvert_Class | 21.798 ns | 0.1093 ns | 0.0913 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 71.795 ns | 0.0929 ns | 0.0869 ns | 0.1239 |     520 B |
