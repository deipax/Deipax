
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  2.028 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
     ToBoolNullable |  5.009 ns | 0.0095 ns | 0.0080 ns |      - |       0 B |
             ToChar |  2.030 ns | 0.0023 ns | 0.0021 ns |      - |       0 B |
     ToCharNullable |  4.890 ns | 0.0022 ns | 0.0021 ns |      - |       0 B |
            ToSByte |  2.541 ns | 0.0041 ns | 0.0038 ns |      - |       0 B |
    ToSByteNullable |  5.262 ns | 0.0065 ns | 0.0061 ns |      - |       0 B |
             ToByte |  2.538 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
     ToByteNullable |  5.272 ns | 0.0139 ns | 0.0116 ns |      - |       0 B |
            ToShort |  2.542 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
    ToShortNullable |  5.520 ns | 0.0141 ns | 0.0132 ns |      - |       0 B |
           ToUShort |  2.022 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
   ToUShortNullable |  1.279 ns | 0.0023 ns | 0.0022 ns |      - |       0 B |
              ToInt |  2.028 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
      ToIntNullable |  5.424 ns | 0.1202 ns | 0.1125 ns |      - |       0 B |
             ToUInt |  2.046 ns | 0.0042 ns | 0.0037 ns |      - |       0 B |
     ToUIntNullable |  5.575 ns | 0.0250 ns | 0.0234 ns |      - |       0 B |
             ToLong |  2.044 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
     ToLongNullable |  2.814 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
            ToULong |  2.047 ns | 0.0021 ns | 0.0015 ns |      - |       0 B |
    ToULongNullable |  2.814 ns | 0.0076 ns | 0.0067 ns |      - |       0 B |
            ToFloat |  2.302 ns | 0.0048 ns | 0.0045 ns |      - |       0 B |
    ToFloatNullable |  5.320 ns | 0.1395 ns | 0.2912 ns |      - |       0 B |
           ToDouble |  2.307 ns | 0.0029 ns | 0.0028 ns |      - |       0 B |
   ToDoubleNullable |  3.065 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
          ToDecimal |  6.775 ns | 0.0079 ns | 0.0073 ns |      - |       0 B |
  ToDecimalNullable | 19.038 ns | 0.0165 ns | 0.0154 ns |      - |       0 B |
         ToDateTime |  2.818 ns | 0.0037 ns | 0.0034 ns |      - |       0 B |
 ToDateTimeNullable |  8.323 ns | 0.0089 ns | 0.0075 ns |      - |       0 B |
           ToObject |  5.226 ns | 0.0058 ns | 0.0055 ns | 0.0057 |      24 B |
          To_String | 38.460 ns | 0.0609 ns | 0.0540 ns | 0.0076 |      32 B |
             ToEnum | 14.877 ns | 0.0146 ns | 0.0137 ns |      - |       0 B |
     ToEnumNullable | 20.205 ns | 0.0420 ns | 0.0393 ns |      - |       0 B |
