
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  5.246 ns | 0.0041 ns | 0.0038 ns | 0.0057 |      24 B |
              Get_Prop_Struct | 52.827 ns | 0.0624 ns | 0.0553 ns | 0.1296 |     544 B |
              Get_Field_Class |  5.242 ns | 0.0050 ns | 0.0047 ns | 0.0057 |      24 B |
             Get_Field_Struct | 51.913 ns | 0.0547 ns | 0.0457 ns | 0.1296 |     544 B |
               Set_Prop_Class |  4.761 ns | 0.0087 ns | 0.0077 ns | 0.0057 |      24 B |
              Set_Prop_Struct | 53.125 ns | 0.0696 ns | 0.0651 ns | 0.1296 |     544 B |
              Set_Field_Class |  5.534 ns | 0.0032 ns | 0.0030 ns | 0.0057 |      24 B |
             Set_Field_Struct | 53.874 ns | 0.0822 ns | 0.0769 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 39.499 ns | 0.0562 ns | 0.0498 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 91.075 ns | 0.1168 ns | 0.0975 ns | 0.1239 |     520 B |
  Set_Field_WithConvert_Class | 41.121 ns | 0.0518 ns | 0.0484 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 91.749 ns | 0.1498 ns | 0.1402 ns | 0.1239 |     520 B |
