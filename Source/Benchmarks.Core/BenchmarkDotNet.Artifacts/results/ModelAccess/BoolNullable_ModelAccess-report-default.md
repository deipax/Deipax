
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435890 Hz, Resolution=291.0454 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |     Mean |     Error |    StdDev | Allocated |
----------------------------- |---------:|----------:|----------:|----------:|
               Get_Prop_Class | 23.99 ns | 0.1974 ns | 0.1541 ns |       0 B |
              Get_Prop_Struct | 23.95 ns | 0.0222 ns | 0.0208 ns |       0 B |
              Get_Field_Class | 23.59 ns | 0.0386 ns | 0.0322 ns |       0 B |
             Get_Field_Struct | 23.91 ns | 0.0149 ns | 0.0140 ns |       0 B |
               Set_Prop_Class | 12.88 ns | 0.0224 ns | 0.0198 ns |       0 B |
              Set_Prop_Struct | 12.93 ns | 0.0212 ns | 0.0199 ns |       0 B |
              Set_Field_Class | 13.03 ns | 0.0464 ns | 0.0434 ns |       0 B |
             Set_Field_Struct | 13.82 ns | 0.0165 ns | 0.0146 ns |       0 B |
   Set_Prop_WithConvert_Class | 23.24 ns | 0.0230 ns | 0.0204 ns |       0 B |
  Set_Prop_WithConvert_Struct | 23.98 ns | 0.0262 ns | 0.0232 ns |       0 B |
  Set_Field_WithConvert_Class | 23.28 ns | 0.0285 ns | 0.0267 ns |       0 B |
 Set_Field_WithConvert_Struct | 24.01 ns | 0.0128 ns | 0.0100 ns |       0 B |
