
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   2.096 ns | 0.0039 ns | 0.0034 ns |      - |       0 B |
     ToBoolNullable |   4.898 ns | 0.0265 ns | 0.0247 ns |      - |       0 B |
             ToChar |   1.297 ns | 0.0058 ns | 0.0054 ns |      - |       0 B |
     ToCharNullable |   4.594 ns | 0.0176 ns | 0.0156 ns |      - |       0 B |
            ToSByte |   5.135 ns | 0.0101 ns | 0.0094 ns |      - |       0 B |
    ToSByteNullable |   7.285 ns | 0.0119 ns | 0.0111 ns |      - |       0 B |
             ToByte |   5.384 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
     ToByteNullable |   7.270 ns | 0.0060 ns | 0.0056 ns |      - |       0 B |
            ToShort |   5.386 ns | 0.0060 ns | 0.0053 ns |      - |       0 B |
    ToShortNullable |   7.368 ns | 0.0171 ns | 0.0134 ns |      - |       0 B |
           ToUShort |   5.400 ns | 0.0176 ns | 0.0164 ns |      - |       0 B |
   ToUShortNullable |   7.156 ns | 0.0209 ns | 0.0195 ns |      - |       0 B |
              ToInt |   3.828 ns | 0.0074 ns | 0.0053 ns |      - |       0 B |
      ToIntNullable |   6.263 ns | 0.0089 ns | 0.0083 ns |      - |       0 B |
             ToUInt |   3.776 ns | 0.0137 ns | 0.0128 ns |      - |       0 B |
     ToUIntNullable |   6.257 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
             ToLong |   4.859 ns | 0.0073 ns | 0.0068 ns |      - |       0 B |
     ToLongNullable |   6.950 ns | 0.0199 ns | 0.0186 ns |      - |       0 B |
            ToULong |   4.348 ns | 0.0111 ns | 0.0103 ns |      - |       0 B |
    ToULongNullable |   6.267 ns | 0.0135 ns | 0.0126 ns |      - |       0 B |
            ToFloat |   1.278 ns | 0.0043 ns | 0.0033 ns |      - |       0 B |
    ToFloatNullable |   4.472 ns | 0.0023 ns | 0.0021 ns |      - |       0 B |
           ToDouble |   1.270 ns | 0.0048 ns | 0.0045 ns |      - |       0 B |
   ToDoubleNullable |   2.554 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
          ToDecimal |  63.041 ns | 0.0303 ns | 0.0253 ns |      - |       0 B |
  ToDecimalNullable |  74.361 ns | 0.1105 ns | 0.0923 ns |      - |       0 B |
         ToDateTime |   3.064 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
 ToDateTimeNullable |   8.819 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
           ToObject |   3.801 ns | 0.0056 ns | 0.0053 ns | 0.0057 |      24 B |
          To_String | 254.651 ns | 0.0923 ns | 0.0721 ns | 0.0072 |      32 B |
             ToEnum |  13.191 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
     ToEnumNullable |  18.959 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
