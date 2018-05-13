
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  2.060 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
     ToBoolNullable |  4.734 ns | 0.0110 ns | 0.0097 ns |      - |       0 B |
             ToChar |  3.847 ns | 0.0009 ns | 0.0008 ns |      - |       0 B |
     ToCharNullable |  6.003 ns | 0.0039 ns | 0.0030 ns |      - |       0 B |
            ToSByte |  3.848 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
    ToSByteNullable |  6.018 ns | 0.0168 ns | 0.0149 ns |      - |       0 B |
             ToByte |  3.850 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
     ToByteNullable |  6.017 ns | 0.0172 ns | 0.0153 ns |      - |       0 B |
            ToShort |  3.849 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
    ToShortNullable |  6.008 ns | 0.0083 ns | 0.0077 ns |      - |       0 B |
           ToUShort |  3.848 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
   ToUShortNullable |  6.008 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
              ToInt |  3.847 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
      ToIntNullable |  6.141 ns | 0.0895 ns | 0.0837 ns |      - |       0 B |
             ToUInt |  3.835 ns | 0.0040 ns | 0.0037 ns |      - |       0 B |
     ToUIntNullable |  6.064 ns | 0.0188 ns | 0.0176 ns |      - |       0 B |
             ToLong |  1.956 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
     ToLongNullable |  2.562 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
            ToULong |  2.809 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
    ToULongNullable |  3.833 ns | 0.0016 ns | 0.0013 ns |      - |       0 B |
            ToFloat |  2.048 ns | 0.0041 ns | 0.0037 ns |      - |       0 B |
    ToFloatNullable |  5.809 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
           ToDouble |  2.049 ns | 0.0076 ns | 0.0071 ns |      - |       0 B |
   ToDoubleNullable |  3.321 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
          ToDecimal |  6.760 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
  ToDecimalNullable | 19.026 ns | 0.0170 ns | 0.0159 ns |      - |       0 B |
         ToDateTime |  3.069 ns | 0.0071 ns | 0.0067 ns |      - |       0 B |
 ToDateTimeNullable |  8.313 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
           ToObject |  4.914 ns | 0.0045 ns | 0.0042 ns | 0.0057 |      24 B |
          To_String | 46.893 ns | 0.0963 ns | 0.0901 ns | 0.0076 |      32 B |
             ToEnum | 15.355 ns | 0.0311 ns | 0.0291 ns |      - |       0 B |
     ToEnumNullable | 20.705 ns | 0.0089 ns | 0.0074 ns |      - |       0 B |
