
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |     Mean |     Error |    StdDev | Allocated |
--------------------- |---------:|----------:|----------:|----------:|
             FromBool | 6.741 ns | 0.0046 ns | 0.0043 ns |       0 B |
     FromBoolNullable | 6.528 ns | 0.0211 ns | 0.0187 ns |       0 B |
             FromChar | 1.162 ns | 0.0018 ns | 0.0014 ns |       0 B |
     FromCharNullable | 1.006 ns | 0.0005 ns | 0.0004 ns |       0 B |
            FromSByte | 6.766 ns | 0.0117 ns | 0.0104 ns |       0 B |
    FromSByteNullable | 6.767 ns | 0.0016 ns | 0.0012 ns |       0 B |
             FromByte | 6.773 ns | 0.0189 ns | 0.0167 ns |       0 B |
     FromByteNullable | 6.516 ns | 0.0086 ns | 0.0077 ns |       0 B |
            FromShort | 6.768 ns | 0.0158 ns | 0.0148 ns |       0 B |
    FromShortNullable | 6.770 ns | 0.0040 ns | 0.0036 ns |       0 B |
           FromUShort | 6.766 ns | 0.0154 ns | 0.0144 ns |       0 B |
   FromUShortNullable | 6.479 ns | 0.0408 ns | 0.0382 ns |       0 B |
              FromInt | 7.522 ns | 0.0166 ns | 0.0155 ns |       0 B |
      FromIntNullable | 6.512 ns | 0.0012 ns | 0.0011 ns |       0 B |
             FromUInt | 6.767 ns | 0.0118 ns | 0.0111 ns |       0 B |
     FromUIntNullable | 6.772 ns | 0.0050 ns | 0.0047 ns |       0 B |
             FromLong | 7.523 ns | 0.0135 ns | 0.0120 ns |       0 B |
     FromLongNullable | 7.008 ns | 0.0011 ns | 0.0009 ns |       0 B |
            FromULong | 7.264 ns | 0.0184 ns | 0.0163 ns |       0 B |
    FromULongNullable | 7.011 ns | 0.0044 ns | 0.0039 ns |       0 B |
            FromFloat | 6.546 ns | 0.0136 ns | 0.0127 ns |       0 B |
    FromFloatNullable | 6.540 ns | 0.0059 ns | 0.0052 ns |       0 B |
           FromDouble | 6.542 ns | 0.0149 ns | 0.0139 ns |       0 B |
   FromDoubleNullable | 7.265 ns | 0.0037 ns | 0.0035 ns |       0 B |
          FromDecimal | 7.277 ns | 0.0164 ns | 0.0137 ns |       0 B |
  FromDecimalNullable | 7.281 ns | 0.0056 ns | 0.0049 ns |       0 B |
         FromDateTime | 7.064 ns | 0.0288 ns | 0.0255 ns |       0 B |
 FromDateTimeNullable | 7.264 ns | 0.0038 ns | 0.0034 ns |       0 B |
           FromObject | 7.547 ns | 0.0162 ns | 0.0152 ns |       0 B |
           FromString | 6.754 ns | 0.0044 ns | 0.0041 ns |       0 B |
             FromEnum | 7.510 ns | 0.0137 ns | 0.0128 ns |       0 B |
     FromEnumNullable | 6.517 ns | 0.0050 ns | 0.0047 ns |       0 B |
