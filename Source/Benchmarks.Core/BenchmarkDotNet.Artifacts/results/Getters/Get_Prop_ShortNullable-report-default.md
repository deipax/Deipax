
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  4.550 ns | 0.0071 ns | 0.0066 ns |      - |       0 B |
     ToBoolNullable |  6.807 ns | 0.0411 ns | 0.0385 ns |      - |       0 B |
             ToChar |  5.191 ns | 0.0067 ns | 0.0060 ns |      - |       0 B |
     ToCharNullable |  7.290 ns | 0.0030 ns | 0.0028 ns |      - |       0 B |
            ToSByte |  6.217 ns | 0.0482 ns | 0.0427 ns |      - |       0 B |
    ToSByteNullable |  7.537 ns | 0.0027 ns | 0.0021 ns |      - |       0 B |
             ToByte |  6.202 ns | 0.0373 ns | 0.0330 ns |      - |       0 B |
     ToByteNullable |  7.998 ns | 0.0014 ns | 0.0013 ns |      - |       0 B |
            ToShort |  2.852 ns | 0.0211 ns | 0.0187 ns |      - |       0 B |
    ToShortNullable |  1.795 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
           ToUShort |  5.382 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
   ToUShortNullable |  7.264 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
              ToInt |  4.658 ns | 0.0385 ns | 0.0341 ns |      - |       0 B |
      ToIntNullable |  6.771 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
             ToUInt |  5.434 ns | 0.0073 ns | 0.0048 ns |      - |       0 B |
     ToUIntNullable |  7.263 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
             ToLong |  4.971 ns | 0.0743 ns | 0.0620 ns |      - |       0 B |
     ToLongNullable |  6.898 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
            ToULong |  5.390 ns | 0.0314 ns | 0.0262 ns |      - |       0 B |
    ToULongNullable |  7.408 ns | 0.0022 ns | 0.0019 ns |      - |       0 B |
            ToFloat |  4.600 ns | 0.0069 ns | 0.0058 ns |      - |       0 B |
    ToFloatNullable |  7.042 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
           ToDouble |  4.869 ns | 0.0120 ns | 0.0106 ns |      - |       0 B |
   ToDoubleNullable |  7.169 ns | 0.0034 ns | 0.0030 ns |      - |       0 B |
          ToDecimal |  8.173 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
  ToDecimalNullable | 16.534 ns | 0.0131 ns | 0.0122 ns |      - |       0 B |
         ToDateTime |  5.774 ns | 0.1475 ns | 0.2339 ns |      - |       0 B |
 ToDateTimeNullable |  6.393 ns | 0.0148 ns | 0.0124 ns |      - |       0 B |
           ToObject |  5.577 ns | 0.0044 ns | 0.0041 ns | 0.0057 |      24 B |
          To_String | 47.022 ns | 0.0149 ns | 0.0125 ns | 0.0076 |      32 B |
             ToEnum | 27.561 ns | 0.0216 ns | 0.0202 ns | 0.0057 |      24 B |
