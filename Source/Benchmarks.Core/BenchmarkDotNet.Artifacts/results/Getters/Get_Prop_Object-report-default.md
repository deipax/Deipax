
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |    Median | Allocated |
------------------- |----------:|----------:|----------:|----------:|----------:|
             ToBool |  5.283 ns | 0.0665 ns | 0.0589 ns |  5.266 ns |       0 B |
     ToBoolNullable |  7.791 ns | 0.1403 ns | 0.1313 ns |  7.832 ns |       0 B |
             ToChar |  5.213 ns | 0.0499 ns | 0.0466 ns |  5.200 ns |       0 B |
     ToCharNullable |  7.729 ns | 0.1567 ns | 0.1389 ns |  7.721 ns |       0 B |
            ToSByte |  5.259 ns | 0.0977 ns | 0.0866 ns |  5.249 ns |       0 B |
    ToSByteNullable |  7.768 ns | 0.1826 ns | 0.1954 ns |  7.690 ns |       0 B |
             ToByte |  5.249 ns | 0.0663 ns | 0.0620 ns |  5.248 ns |       0 B |
     ToByteNullable |  7.825 ns | 0.1857 ns | 0.2210 ns |  7.866 ns |       0 B |
            ToShort |  5.208 ns | 0.0447 ns | 0.0418 ns |  5.196 ns |       0 B |
    ToShortNullable |  7.710 ns | 0.1271 ns | 0.1189 ns |  7.768 ns |       0 B |
           ToUShort |  5.249 ns | 0.0974 ns | 0.0863 ns |  5.205 ns |       0 B |
   ToUShortNullable |  7.663 ns | 0.1059 ns | 0.0990 ns |  7.611 ns |       0 B |
              ToInt |  5.158 ns | 0.0267 ns | 0.0237 ns |  5.154 ns |       0 B |
      ToIntNullable |  7.787 ns | 0.1836 ns | 0.1886 ns |  7.710 ns |       0 B |
             ToUInt |  5.327 ns | 0.1394 ns | 0.1235 ns |  5.343 ns |       0 B |
     ToUIntNullable |  7.643 ns | 0.1371 ns | 0.1145 ns |  7.594 ns |       0 B |
             ToLong |  5.250 ns | 0.0773 ns | 0.0685 ns |  5.241 ns |       0 B |
     ToLongNullable |  8.778 ns | 0.0564 ns | 0.0471 ns |  8.772 ns |       0 B |
            ToULong |  5.283 ns | 0.1300 ns | 0.1216 ns |  5.266 ns |       0 B |
    ToULongNullable |  8.583 ns | 0.1437 ns | 0.1274 ns |  8.544 ns |       0 B |
            ToFloat |  5.527 ns | 0.1444 ns | 0.1418 ns |  5.469 ns |       0 B |
    ToFloatNullable |  7.903 ns | 0.2179 ns | 0.2756 ns |  7.808 ns |       0 B |
           ToDouble |  5.451 ns | 0.0983 ns | 0.0821 ns |  5.424 ns |       0 B |
   ToDoubleNullable |  8.813 ns | 0.0724 ns | 0.0642 ns |  8.786 ns |       0 B |
          ToDecimal |  7.670 ns | 0.1868 ns | 0.2151 ns |  7.608 ns |       0 B |
  ToDecimalNullable | 14.490 ns | 0.3348 ns | 0.5951 ns | 14.187 ns |       0 B |
         ToDateTime |  6.757 ns | 0.0954 ns | 0.0797 ns |  6.729 ns |       0 B |
 ToDateTimeNullable | 14.323 ns | 0.1014 ns | 0.0847 ns | 14.292 ns |       0 B |
           ToObject |  1.282 ns | 0.0274 ns | 0.0243 ns |  1.273 ns |       0 B |
          To_String | 23.504 ns | 0.4859 ns | 0.4545 ns | 23.352 ns |       0 B |
             ToEnum | 24.586 ns | 0.2230 ns | 0.1977 ns | 24.561 ns |       0 B |
     ToEnumNullable | 27.545 ns | 0.4742 ns | 0.4436 ns | 27.656 ns |       0 B |
