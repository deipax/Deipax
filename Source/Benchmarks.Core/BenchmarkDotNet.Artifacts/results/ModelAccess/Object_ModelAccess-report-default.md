
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |     Mean |     Error |    StdDev | Allocated |
----------------------------- |---------:|----------:|----------:|----------:|
               Get_Prop_Class | 2.029 ns | 0.0027 ns | 0.0026 ns |       0 B |
              Get_Prop_Struct | 2.283 ns | 0.0005 ns | 0.0004 ns |       0 B |
              Get_Field_Class | 1.774 ns | 0.0026 ns | 0.0024 ns |       0 B |
             Get_Field_Struct | 2.285 ns | 0.0020 ns | 0.0019 ns |       0 B |
               Set_Prop_Class | 5.863 ns | 0.0116 ns | 0.0109 ns |       0 B |
              Set_Prop_Struct | 5.862 ns | 0.0038 ns | 0.0035 ns |       0 B |
              Set_Field_Class | 5.870 ns | 0.0073 ns | 0.0065 ns |       0 B |
             Set_Field_Struct | 5.867 ns | 0.0039 ns | 0.0032 ns |       0 B |
   Set_Prop_WithConvert_Class | 5.898 ns | 0.0161 ns | 0.0150 ns |       0 B |
  Set_Prop_WithConvert_Struct | 5.860 ns | 0.0036 ns | 0.0032 ns |       0 B |
  Set_Field_WithConvert_Class | 5.871 ns | 0.0076 ns | 0.0060 ns |       0 B |
 Set_Field_WithConvert_Struct | 5.869 ns | 0.0106 ns | 0.0099 ns |       0 B |
