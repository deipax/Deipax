
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool | 17.7986 ns | 0.0216 ns | 0.0202 ns |       0 B |
     FromBoolNullable |  8.3317 ns | 0.0196 ns | 0.0184 ns |       0 B |
             FromChar |  1.0553 ns | 0.0041 ns | 0.0038 ns |       0 B |
     FromCharNullable |  0.9063 ns | 0.0048 ns | 0.0045 ns |       0 B |
            FromSByte | 19.3587 ns | 0.0352 ns | 0.0330 ns |       0 B |
    FromSByteNullable |  8.4564 ns | 0.0043 ns | 0.0040 ns |       0 B |
             FromByte | 19.3226 ns | 0.0175 ns | 0.0155 ns |       0 B |
     FromByteNullable |  8.2110 ns | 0.0105 ns | 0.0098 ns |       0 B |
            FromShort | 19.3126 ns | 0.0128 ns | 0.0113 ns |       0 B |
    FromShortNullable |  8.3227 ns | 0.0091 ns | 0.0076 ns |       0 B |
           FromUShort | 17.5595 ns | 0.0373 ns | 0.0330 ns |       0 B |
   FromUShortNullable |  8.4878 ns | 0.0195 ns | 0.0182 ns |       0 B |
              FromInt | 17.5405 ns | 0.0332 ns | 0.0295 ns |       0 B |
      FromIntNullable |  8.4509 ns | 0.0178 ns | 0.0166 ns |       0 B |
             FromUInt | 17.3148 ns | 0.0352 ns | 0.0312 ns |       0 B |
     FromUIntNullable |  8.0845 ns | 0.0125 ns | 0.0111 ns |       0 B |
             FromLong | 19.3194 ns | 0.0161 ns | 0.0135 ns |       0 B |
     FromLongNullable |  8.5781 ns | 0.0087 ns | 0.0077 ns |       0 B |
            FromULong | 17.6580 ns | 0.0660 ns | 0.0618 ns |       0 B |
    FromULongNullable |  8.7666 ns | 0.0061 ns | 0.0057 ns |       0 B |
            FromFloat | 22.4296 ns | 0.0346 ns | 0.0324 ns |       0 B |
    FromFloatNullable |  8.3736 ns | 0.0137 ns | 0.0128 ns |       0 B |
           FromDouble | 22.4340 ns | 0.0340 ns | 0.0318 ns |       0 B |
   FromDoubleNullable |  8.5837 ns | 0.0054 ns | 0.0050 ns |       0 B |
          FromDecimal |  6.2711 ns | 0.0106 ns | 0.0099 ns |       0 B |
  FromDecimalNullable |  1.8625 ns | 0.0037 ns | 0.0034 ns |       0 B |
         FromDateTime |  1.0141 ns | 0.0052 ns | 0.0046 ns |       0 B |
 FromDateTimeNullable |  2.0165 ns | 0.0061 ns | 0.0057 ns |       0 B |
           FromObject | 10.1197 ns | 0.0156 ns | 0.0146 ns |       0 B |
           FromString |  8.4753 ns | 0.0175 ns | 0.0164 ns |       0 B |
             FromEnum | 17.5399 ns | 0.0293 ns | 0.0274 ns |       0 B |
     FromEnumNullable |  8.1925 ns | 0.0186 ns | 0.0174 ns |       0 B |
