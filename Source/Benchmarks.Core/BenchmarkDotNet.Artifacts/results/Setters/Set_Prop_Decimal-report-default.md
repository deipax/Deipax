
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  10.907 ns | 0.0136 ns | 0.0127 ns |       0 B |
     FromBoolNullable |  11.176 ns | 0.0211 ns | 0.0176 ns |       0 B |
             FromChar |   1.734 ns | 0.0074 ns | 0.0065 ns |       0 B |
     FromCharNullable |   3.203 ns | 0.0100 ns | 0.0094 ns |       0 B |
            FromSByte |  10.663 ns | 0.0163 ns | 0.0153 ns |       0 B |
    FromSByteNullable |  11.372 ns | 0.0300 ns | 0.0280 ns |       0 B |
             FromByte |  10.652 ns | 0.0120 ns | 0.0100 ns |       0 B |
     FromByteNullable |  11.245 ns | 0.0194 ns | 0.0172 ns |       0 B |
            FromShort |  10.649 ns | 0.0247 ns | 0.0206 ns |       0 B |
    FromShortNullable |  11.178 ns | 0.0187 ns | 0.0175 ns |       0 B |
           FromUShort |  10.668 ns | 0.0152 ns | 0.0127 ns |       0 B |
   FromUShortNullable |  11.163 ns | 0.0163 ns | 0.0152 ns |       0 B |
              FromInt |  10.645 ns | 0.0162 ns | 0.0144 ns |       0 B |
      FromIntNullable |  11.249 ns | 0.0174 ns | 0.0163 ns |       0 B |
             FromUInt |  10.658 ns | 0.0195 ns | 0.0152 ns |       0 B |
     FromUIntNullable |  10.906 ns | 0.0175 ns | 0.0163 ns |       0 B |
             FromLong |  10.899 ns | 0.0229 ns | 0.0203 ns |       0 B |
     FromLongNullable |  11.596 ns | 0.0149 ns | 0.0139 ns |       0 B |
            FromULong |  10.669 ns | 0.0214 ns | 0.0190 ns |       0 B |
    FromULongNullable |  11.435 ns | 0.0084 ns | 0.0075 ns |       0 B |
            FromFloat |  25.207 ns | 0.0300 ns | 0.0250 ns |       0 B |
    FromFloatNullable |  25.671 ns | 0.0876 ns | 0.0819 ns |       0 B |
           FromDouble |  62.266 ns | 0.0875 ns | 0.0819 ns |       0 B |
   FromDoubleNullable |  63.247 ns | 0.0671 ns | 0.0628 ns |       0 B |
          FromDecimal |   1.812 ns | 0.0044 ns | 0.0039 ns |       0 B |
  FromDecimalNullable |   4.475 ns | 0.0032 ns | 0.0028 ns |       0 B |
         FromDateTime |   2.221 ns | 0.0072 ns | 0.0067 ns |       0 B |
 FromDateTimeNullable |   8.085 ns | 0.0238 ns | 0.0223 ns |       0 B |
           FromObject |   8.880 ns | 0.0350 ns | 0.0328 ns |       0 B |
           FromString | 111.706 ns | 0.2256 ns | 0.2110 ns |       0 B |
             FromEnum |  10.646 ns | 0.0209 ns | 0.0196 ns |       0 B |
     FromEnumNullable |  11.267 ns | 0.0146 ns | 0.0114 ns |       0 B |
