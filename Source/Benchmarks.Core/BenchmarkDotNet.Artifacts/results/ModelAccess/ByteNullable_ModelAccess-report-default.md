
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435894 Hz, Resolution=291.0451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                       Method |     Mean |     Error |    StdDev | Allocated |
----------------------------- |---------:|----------:|----------:|----------:|
               Get_Prop_Class | 24.27 ns | 0.0250 ns | 0.0233 ns |       0 B |
              Get_Prop_Struct | 24.40 ns | 0.0242 ns | 0.0202 ns |       0 B |
              Get_Field_Class | 23.75 ns | 0.0039 ns | 0.0031 ns |       0 B |
             Get_Field_Struct | 25.18 ns | 0.0112 ns | 0.0099 ns |       0 B |
               Set_Prop_Class | 13.47 ns | 0.0146 ns | 0.0122 ns |       0 B |
              Set_Prop_Struct | 14.64 ns | 0.0183 ns | 0.0172 ns |       0 B |
              Set_Field_Class | 13.59 ns | 0.0132 ns | 0.0110 ns |       0 B |
             Set_Field_Struct | 13.82 ns | 0.0116 ns | 0.0103 ns |       0 B |
   Set_Prop_WithConvert_Class | 98.55 ns | 0.0866 ns | 0.0767 ns |       0 B |
  Set_Prop_WithConvert_Struct | 98.37 ns | 0.1496 ns | 0.1250 ns |       0 B |
  Set_Field_WithConvert_Class | 99.30 ns | 0.0591 ns | 0.0553 ns |       0 B |
 Set_Field_WithConvert_Struct | 98.43 ns | 0.0669 ns | 0.0593 ns |       0 B |
