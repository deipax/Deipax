
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435886 Hz, Resolution=291.0457 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  5.078 ns | 0.0118 ns | 0.0099 ns | 0.0057 |      24 B |
              Get_Prop_Struct | 53.422 ns | 1.0665 ns | 0.9976 ns | 0.1296 |     544 B |
              Get_Field_Class |  5.052 ns | 0.0406 ns | 0.0380 ns | 0.0057 |      24 B |
             Get_Field_Struct | 53.206 ns | 0.0494 ns | 0.0412 ns | 0.1296 |     544 B |
               Set_Prop_Class |  4.797 ns | 0.0102 ns | 0.0091 ns | 0.0057 |      24 B |
              Set_Prop_Struct | 54.101 ns | 0.0546 ns | 0.0456 ns | 0.1296 |     544 B |
              Set_Field_Class |  5.560 ns | 0.0101 ns | 0.0090 ns | 0.0057 |      24 B |
             Set_Field_Struct | 54.052 ns | 0.0625 ns | 0.0488 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 26.847 ns | 0.0384 ns | 0.0340 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 76.183 ns | 0.1547 ns | 0.1371 ns | 0.1239 |     520 B |
  Set_Field_WithConvert_Class | 26.356 ns | 0.1380 ns | 0.0913 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 79.730 ns | 1.5885 ns | 2.0655 ns | 0.1239 |     520 B |
