
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |----------:|----------:|----------:|-------:|----------:|
             FromBool | 15.327 ns | 0.0227 ns | 0.0213 ns |      - |       0 B |
     FromBoolNullable | 15.345 ns | 0.0315 ns | 0.0280 ns |      - |       0 B |
             FromChar | 16.094 ns | 0.0193 ns | 0.0181 ns |      - |       0 B |
     FromCharNullable | 16.084 ns | 0.0064 ns | 0.0050 ns |      - |       0 B |
            FromSByte | 15.825 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
    FromSByteNullable | 15.826 ns | 0.0150 ns | 0.0140 ns |      - |       0 B |
             FromByte | 15.331 ns | 0.0104 ns | 0.0087 ns |      - |       0 B |
     FromByteNullable | 15.335 ns | 0.0184 ns | 0.0172 ns |      - |       0 B |
            FromShort | 15.834 ns | 0.0093 ns | 0.0078 ns |      - |       0 B |
    FromShortNullable | 15.842 ns | 0.0212 ns | 0.0199 ns |      - |       0 B |
           FromUShort | 15.341 ns | 0.0145 ns | 0.0129 ns |      - |       0 B |
   FromUShortNullable | 15.327 ns | 0.0156 ns | 0.0146 ns |      - |       0 B |
              FromInt | 15.831 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
      FromIntNullable | 15.840 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
             FromUInt | 13.917 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
     FromUIntNullable | 13.903 ns | 0.0196 ns | 0.0183 ns |      - |       0 B |
             FromLong | 16.595 ns | 0.0075 ns | 0.0066 ns |      - |       0 B |
     FromLongNullable | 16.614 ns | 0.0201 ns | 0.0188 ns |      - |       0 B |
            FromULong | 15.843 ns | 0.0091 ns | 0.0076 ns |      - |       0 B |
    FromULongNullable | 16.013 ns | 0.0181 ns | 0.0160 ns |      - |       0 B |
            FromFloat | 17.113 ns | 0.0083 ns | 0.0074 ns |      - |       0 B |
    FromFloatNullable | 17.114 ns | 0.0144 ns | 0.0135 ns |      - |       0 B |
           FromDouble | 16.874 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
   FromDoubleNullable | 16.862 ns | 0.0210 ns | 0.0197 ns |      - |       0 B |
          FromDecimal | 38.422 ns | 0.0295 ns | 0.0276 ns |      - |       0 B |
  FromDecimalNullable | 38.710 ns | 0.6004 ns | 0.5322 ns |      - |       0 B |
         FromDateTime |        NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |  7.696 ns | 0.0034 ns | 0.0029 ns |      - |       0 B |
           FromObject | 14.890 ns | 0.0095 ns | 0.0084 ns |      - |       0 B |
           FromString | 83.400 ns | 0.0651 ns | 0.0577 ns |      - |       0 B |
             FromEnum | 45.784 ns | 0.0206 ns | 0.0172 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_UIntNullable.FromDateTime: DefaultJob
