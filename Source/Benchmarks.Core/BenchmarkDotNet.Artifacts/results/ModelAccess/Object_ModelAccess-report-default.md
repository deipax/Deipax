
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
----------------------------- |----------:|----------:|----------:|-------:|----------:|
               Get_Prop_Class |  4.583 ns | 0.0034 ns | 0.0032 ns |      - |       0 B |
              Get_Prop_Struct | 52.286 ns | 0.1334 ns | 0.1183 ns | 0.1239 |     520 B |
              Get_Field_Class |  4.328 ns | 0.0042 ns | 0.0039 ns |      - |       0 B |
             Get_Field_Struct | 52.521 ns | 0.0607 ns | 0.0507 ns | 0.1239 |     520 B |
               Set_Prop_Class |  5.861 ns | 0.0016 ns | 0.0015 ns |      - |       0 B |
              Set_Prop_Struct | 53.925 ns | 0.1445 ns | 0.1281 ns | 0.1239 |     520 B |
              Set_Field_Class |  5.860 ns | 0.0053 ns | 0.0050 ns |      - |       0 B |
             Set_Field_Struct | 55.017 ns | 0.1370 ns | 0.1282 ns | 0.1239 |     520 B |
   Set_Prop_WithConvert_Class |  5.876 ns | 0.0073 ns | 0.0068 ns |      - |       0 B |
  Set_Prop_WithConvert_Struct | 54.195 ns | 0.0449 ns | 0.0398 ns | 0.1239 |     520 B |
  Set_Field_WithConvert_Class |  5.883 ns | 0.0084 ns | 0.0075 ns |      - |       0 B |
 Set_Field_WithConvert_Struct | 55.201 ns | 0.0923 ns | 0.0863 ns | 0.1239 |     520 B |
