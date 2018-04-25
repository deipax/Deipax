
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |-----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |   5.385 ns | 0.1071 ns | 0.0949 ns | 0.0057 |      24 B |
              Get_Prop_Struct |  53.417 ns | 0.3334 ns | 0.2784 ns | 0.1296 |     544 B |
              Get_Field_Class |   5.299 ns | 0.0203 ns | 0.0190 ns | 0.0057 |      24 B |
             Get_Field_Struct |  53.023 ns | 0.3207 ns | 0.3000 ns | 0.1296 |     544 B |
               Set_Prop_Class |   4.810 ns | 0.0679 ns | 0.0635 ns | 0.0057 |      24 B |
              Set_Prop_Struct |  53.848 ns | 0.1899 ns | 0.1683 ns | 0.1296 |     544 B |
              Set_Field_Class |   5.612 ns | 0.0935 ns | 0.0874 ns | 0.0057 |      24 B |
             Set_Field_Struct |  54.835 ns | 0.9707 ns | 0.9080 ns | 0.1296 |     544 B |
   Set_Prop_WithConvert_Class | 166.659 ns | 3.2944 ns | 3.3831 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 210.390 ns | 0.2916 ns | 0.2277 ns | 0.1237 |     520 B |
  Set_Field_WithConvert_Class | 164.336 ns | 1.6815 ns | 1.4041 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 211.051 ns | 1.2621 ns | 1.1805 ns | 0.1237 |     520 B |
