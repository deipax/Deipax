
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool | 14.0208 ns | 0.0311 ns | 0.0290 ns |       0 B |
     FromBoolNullable | 14.6217 ns | 0.0335 ns | 0.0297 ns |       0 B |
             FromChar | 14.2791 ns | 0.0271 ns | 0.0254 ns |       0 B |
     FromCharNullable | 14.8468 ns | 0.0431 ns | 0.0382 ns |       0 B |
            FromSByte | 14.0183 ns | 0.0378 ns | 0.0353 ns |       0 B |
    FromSByteNullable | 14.5906 ns | 0.0424 ns | 0.0397 ns |       0 B |
             FromByte | 14.0156 ns | 0.0404 ns | 0.0378 ns |       0 B |
     FromByteNullable | 14.6198 ns | 0.0382 ns | 0.0357 ns |       0 B |
            FromShort | 14.0317 ns | 0.0527 ns | 0.0493 ns |       0 B |
    FromShortNullable | 15.1045 ns | 0.0568 ns | 0.0532 ns |       0 B |
           FromUShort | 14.2657 ns | 0.0210 ns | 0.0196 ns |       0 B |
   FromUShortNullable | 14.8355 ns | 0.0292 ns | 0.0273 ns |       0 B |
              FromInt | 14.0090 ns | 0.0269 ns | 0.0252 ns |       0 B |
      FromIntNullable | 14.8604 ns | 0.0457 ns | 0.0427 ns |       0 B |
             FromUInt | 13.9973 ns | 0.0162 ns | 0.0144 ns |       0 B |
     FromUIntNullable | 14.7982 ns | 0.0448 ns | 0.0419 ns |       0 B |
             FromLong | 14.5672 ns | 0.0480 ns | 0.0425 ns |       0 B |
     FromLongNullable | 15.5193 ns | 0.0395 ns | 0.0370 ns |       0 B |
            FromULong | 14.9682 ns | 0.0175 ns | 0.0146 ns |       0 B |
    FromULongNullable | 15.5171 ns | 0.0410 ns | 0.0363 ns |       0 B |
            FromFloat | 15.9599 ns | 0.0291 ns | 0.0258 ns |       0 B |
    FromFloatNullable | 16.3598 ns | 0.0242 ns | 0.0227 ns |       0 B |
           FromDouble | 15.7075 ns | 0.0113 ns | 0.0100 ns |       0 B |
   FromDoubleNullable | 16.5094 ns | 0.0240 ns | 0.0200 ns |       0 B |
          FromDecimal | 48.0684 ns | 0.0177 ns | 0.0166 ns |       0 B |
  FromDecimalNullable | 36.9962 ns | 0.0717 ns | 0.0671 ns |       0 B |
         FromDateTime | 13.4380 ns | 0.0037 ns | 0.0029 ns |       0 B |
 FromDateTimeNullable |  4.7986 ns | 0.0285 ns | 0.0253 ns |       0 B |
           FromObject |  3.0232 ns | 0.0267 ns | 0.0250 ns |       0 B |
           FromString | 29.3507 ns | 0.1174 ns | 0.1041 ns |       0 B |
             FromEnum |  0.8881 ns | 0.0049 ns | 0.0041 ns |       0 B |
     FromEnumNullable |  1.6703 ns | 0.0054 ns | 0.0051 ns |       0 B |
