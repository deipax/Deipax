
BenchmarkDotNet=v0.10.13, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1650 v3 3.50GHz, 1 CPU, 12 logical cores and 6 physical cores
Frequency=3410117 Hz, Resolution=293.2451 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


                                Method |     Mean |     Error |   StdDev | Allocated |
-------------------------------------- |---------:|----------:|---------:|----------:|
                              From_Int | 15.56 ns | 0.4812 ns | 1.419 ns |       0 B |
                     From_Int_AsObject | 33.00 ns | 0.8075 ns | 2.343 ns |       0 B |
           From_Int_Nullable_WithValue | 15.22 ns | 0.4066 ns | 1.180 ns |       0 B |
  From_Int_Nullable_WithValue_AsObject | 34.41 ns | 0.7422 ns | 1.889 ns |       0 B |
             From_Int_Nullable_NoValue | 15.33 ns | 0.4587 ns | 1.353 ns |       0 B |
    From_Int_Nullable_NoValue_AsObject | 18.16 ns | 0.3928 ns | 1.075 ns |       0 B |
                             From_Long | 15.32 ns | 0.3729 ns | 1.094 ns |       0 B |
                    From_Long_AsObject | 30.85 ns | 0.6859 ns | 1.990 ns |       0 B |
          From_Long_Nullable_WithValue | 16.07 ns | 0.3975 ns | 1.160 ns |       0 B |
 From_Long_Nullable_WithValue_AsObject | 31.53 ns | 0.7052 ns | 2.057 ns |       0 B |
            From_Long_Nullable_NoValue | 17.94 ns | 0.3939 ns | 1.098 ns |       0 B |
   From_Long_Nullable_NoValue_AsObject | 18.63 ns | 0.4717 ns | 1.376 ns |       0 B |
