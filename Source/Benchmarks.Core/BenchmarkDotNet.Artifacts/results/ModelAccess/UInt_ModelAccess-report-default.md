
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.295 ns | 0.0062 ns | 0.0055 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  53.407 ns | 0.0793 ns | 0.0703 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.312 ns | 0.0032 ns | 0.0030 ns | 0.0057 |      24 B |
             Get_Field_Struct |  52.607 ns | 0.0506 ns | 0.0449 ns | 0.1296 |     544 B |
               Set_Prop_Class |   5.635 ns | 0.0526 ns | 0.0466 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  53.816 ns | 0.1005 ns | 0.0940 ns | 0.1296 |     544 B |
              Set_Field_Class |   5.061 ns | 0.0251 ns | 0.0210 ns | 0.0057 |      24 B |
             Set_Field_Struct |  53.920 ns | 0.1133 ns | 0.1004 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 150.726 ns | 0.3474 ns | 0.2712 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 196.190 ns | 0.1519 ns | 0.1421 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 146.995 ns | 1.7544 ns | 1.5552 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 195.091 ns | 0.2056 ns | 0.1923 ns | 0.1237 |     520 B |
