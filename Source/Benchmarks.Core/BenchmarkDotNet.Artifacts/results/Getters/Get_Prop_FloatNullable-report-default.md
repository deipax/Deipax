
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   4.753 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
     ToBoolNullable |   7.303 ns | 0.0218 ns | 0.0182 ns |      - |       0 B |
             ToChar |   3.571 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
     ToCharNullable |   6.802 ns | 0.0151 ns | 0.0141 ns |      - |       0 B |
            ToSByte |   8.614 ns | 0.0218 ns | 0.0204 ns |      - |       0 B |
    ToSByteNullable |  11.227 ns | 0.0201 ns | 0.0178 ns |      - |       0 B |
             ToByte |   8.498 ns | 0.0367 ns | 0.0343 ns |      - |       0 B |
     ToByteNullable |  11.509 ns | 0.0187 ns | 0.0166 ns |      - |       0 B |
            ToShort |   8.562 ns | 0.0277 ns | 0.0259 ns |      - |       0 B |
    ToShortNullable |  11.304 ns | 0.0179 ns | 0.0167 ns |      - |       0 B |
           ToUShort |   8.656 ns | 0.0288 ns | 0.0270 ns |      - |       0 B |
   ToUShortNullable |  11.661 ns | 0.0202 ns | 0.0189 ns |      - |       0 B |
              ToInt |   7.111 ns | 0.0496 ns | 0.0464 ns |      - |       0 B |
      ToIntNullable |   9.070 ns | 0.0277 ns | 0.0246 ns |      - |       0 B |
             ToUInt |   7.162 ns | 0.0207 ns | 0.0173 ns |      - |       0 B |
     ToUIntNullable |   9.049 ns | 0.0517 ns | 0.0483 ns |      - |       0 B |
             ToLong |   7.973 ns | 0.0319 ns | 0.0298 ns |      - |       0 B |
     ToLongNullable |  11.533 ns | 0.0314 ns | 0.0278 ns |      - |       0 B |
            ToULong |   7.564 ns | 0.0236 ns | 0.0221 ns |      - |       0 B |
    ToULongNullable |  11.725 ns | 0.0329 ns | 0.0275 ns |      - |       0 B |
            ToFloat |   2.827 ns | 0.0154 ns | 0.0144 ns |      - |       0 B |
    ToFloatNullable |   1.791 ns | 0.0084 ns | 0.0070 ns |      - |       0 B |
           ToDouble |   4.623 ns | 0.0183 ns | 0.0171 ns |      - |       0 B |
   ToDoubleNullable |   6.680 ns | 0.0253 ns | 0.0236 ns |      - |       0 B |
          ToDecimal |  27.811 ns | 0.1370 ns | 0.1282 ns |      - |       0 B |
  ToDecimalNullable |  36.410 ns | 0.0684 ns | 0.0607 ns |      - |       0 B |
         ToDateTime |   5.123 ns | 0.0080 ns | 0.0075 ns |      - |       0 B |
 ToDateTimeNullable |   6.454 ns | 0.0280 ns | 0.0262 ns |      - |       0 B |
           ToObject |   5.344 ns | 0.0142 ns | 0.0126 ns | 0.0057 |      24 B |
          To_String | 226.688 ns | 0.6776 ns | 0.6338 ns | 0.0074 |      32 B |
             ToEnum |  29.860 ns | 0.0928 ns | 0.0868 ns | 0.0057 |      24 B |
