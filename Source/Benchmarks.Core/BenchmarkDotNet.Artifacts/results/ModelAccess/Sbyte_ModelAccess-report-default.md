
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   4.303 ns | 0.0068 ns | 0.0060 ns | 0.0057 |      24 B |
              Get_Prop_Struct |   4.264 ns | 0.0099 ns | 0.0093 ns | 0.0057 |      24 B |
              Get_Field_Class |   4.243 ns | 0.0021 ns | 0.0017 ns | 0.0057 |      24 B |
             Get_Field_Struct |   4.271 ns | 0.0173 ns | 0.0162 ns | 0.0057 |      24 B |
               Set_Prop_Class |   2.603 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
              Set_Prop_Struct |   2.868 ns | 0.0167 ns | 0.0148 ns |      - |       0 B |
              Set_Field_Class |   2.606 ns | 0.0219 ns | 0.0205 ns |      - |       0 B |
             Set_Field_Struct |   2.894 ns | 0.0338 ns | 0.0316 ns |      - |       0 B |
   Set_Prop_WithConvert_Class | 102.468 ns | 0.0761 ns | 0.0675 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 102.619 ns | 0.0393 ns | 0.0368 ns |      - |       0 B |
  Set_Field_WithConvert_Class | 102.973 ns | 0.0453 ns | 0.0402 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 102.962 ns | 0.0860 ns | 0.0805 ns |      - |       0 B |
