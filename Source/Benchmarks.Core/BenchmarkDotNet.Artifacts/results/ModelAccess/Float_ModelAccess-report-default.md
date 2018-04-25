
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.243 ns | 0.0028 ns | 0.0025 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.265 ns | 0.0047 ns | 0.0041 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.296 ns | 0.0064 ns | 0.0060 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.273 ns | 0.0121 ns | 0.0113 ns | 0.0057 |      24 B |
               Set_Prop_Class |   3.028 ns | 0.0575 ns | 0.0538 ns |      - |       0 B |
              Set_Prop_Struct |   3.310 ns | 0.0041 ns | 0.0034 ns |      - |       0 B |
              Set_Field_Class |   3.214 ns | 0.0146 ns | 0.0129 ns |      - |       0 B |
             Set_Field_Struct |   2.821 ns | 0.0171 ns | 0.0160 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 153.192 ns | 0.1347 ns | 0.1260 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 153.244 ns | 0.2934 ns | 0.2601 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 155.554 ns | 0.3563 ns | 0.3159 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 152.910 ns | 0.2439 ns | 0.2281 ns |      - |       0 B |
