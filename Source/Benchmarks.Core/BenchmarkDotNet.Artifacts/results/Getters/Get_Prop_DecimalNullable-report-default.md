
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool | 18.232 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
     ToBoolNullable | 21.105 ns | 0.0406 ns | 0.0380 ns |      - |       0 B |
             ToChar |  1.293 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
     ToCharNullable |  4.469 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
            ToSByte | 25.511 ns | 0.0494 ns | 0.0462 ns |      - |       0 B |
    ToSByteNullable | 31.962 ns | 0.0182 ns | 0.0161 ns |      - |       0 B |
             ToByte | 27.001 ns | 0.0409 ns | 0.0383 ns |      - |       0 B |
     ToByteNullable | 29.612 ns | 0.0209 ns | 0.0195 ns |      - |       0 B |
            ToShort | 25.461 ns | 0.0386 ns | 0.0342 ns |      - |       0 B |
    ToShortNullable | 31.905 ns | 0.0057 ns | 0.0048 ns |      - |       0 B |
           ToUShort | 25.283 ns | 0.0464 ns | 0.0411 ns |      - |       0 B |
   ToUShortNullable | 31.747 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
              ToInt | 24.697 ns | 0.0167 ns | 0.0148 ns |      - |       0 B |
      ToIntNullable | 29.004 ns | 0.0323 ns | 0.0286 ns |      - |       0 B |
             ToUInt | 24.451 ns | 0.0584 ns | 0.0488 ns |      - |       0 B |
     ToUIntNullable | 28.741 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
             ToLong | 26.773 ns | 0.1285 ns | 0.1073 ns |      - |       0 B |
     ToLongNullable | 26.184 ns | 0.1504 ns | 0.1256 ns |      - |       0 B |
            ToULong | 26.857 ns | 0.1697 ns | 0.1504 ns |      - |       0 B |
    ToULongNullable | 29.805 ns | 0.0406 ns | 0.0360 ns |      - |       0 B |
            ToFloat | 26.307 ns | 0.4151 ns | 0.3883 ns |      - |       0 B |
    ToFloatNullable | 30.255 ns | 0.0217 ns | 0.0203 ns |      - |       0 B |
           ToDouble | 22.804 ns | 0.4006 ns | 0.3748 ns |      - |       0 B |
   ToDoubleNullable | 27.154 ns | 0.0324 ns | 0.0234 ns |      - |       0 B |
          ToDecimal |  3.082 ns | 0.0296 ns | 0.0262 ns |      - |       0 B |
  ToDecimalNullable |  2.564 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
         ToDateTime |  3.074 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
 ToDateTimeNullable |  8.527 ns | 0.0820 ns | 0.0727 ns |      - |       0 B |
           ToObject |  5.631 ns | 0.0481 ns | 0.0402 ns | 0.0076 |      32 B |
          To_String | 79.709 ns | 0.2906 ns | 0.2576 ns | 0.0075 |      32 B |
             ToEnum | 37.166 ns | 0.1779 ns | 0.1577 ns |      - |       0 B |
     ToEnumNullable | 42.694 ns | 0.1363 ns | 0.1275 ns |      - |       0 B |
