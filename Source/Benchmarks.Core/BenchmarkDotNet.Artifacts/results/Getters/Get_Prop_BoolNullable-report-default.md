
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
             ToBool |  2.028 ns | 0.0080 ns | 0.0071 ns |  2.026 ns |      - |       0 B |
     ToBoolNullable |  1.271 ns | 0.0030 ns | 0.0028 ns |  1.271 ns |      - |       0 B |
             ToChar |  1.277 ns | 0.0013 ns | 0.0011 ns |  1.277 ns |      - |       0 B |
     ToCharNullable |  4.460 ns | 0.0011 ns | 0.0008 ns |  4.460 ns |      - |       0 B |
            ToSByte |  2.807 ns | 0.0018 ns | 0.0017 ns |  2.806 ns |      - |       0 B |
    ToSByteNullable |  4.763 ns | 0.0023 ns | 0.0021 ns |  4.762 ns |      - |       0 B |
             ToByte |  2.808 ns | 0.0020 ns | 0.0018 ns |  2.807 ns |      - |       0 B |
     ToByteNullable |  4.757 ns | 0.0017 ns | 0.0015 ns |  4.757 ns |      - |       0 B |
            ToShort |  2.808 ns | 0.0044 ns | 0.0039 ns |  2.807 ns |      - |       0 B |
    ToShortNullable |  4.869 ns | 0.0170 ns | 0.0159 ns |  4.866 ns |      - |       0 B |
           ToUShort |  2.807 ns | 0.0025 ns | 0.0022 ns |  2.807 ns |      - |       0 B |
   ToUShortNullable |  4.880 ns | 0.0240 ns | 0.0224 ns |  4.882 ns |      - |       0 B |
              ToInt |  2.806 ns | 0.0002 ns | 0.0002 ns |  2.806 ns |      - |       0 B |
      ToIntNullable |  4.762 ns | 0.0035 ns | 0.0032 ns |  4.762 ns |      - |       0 B |
             ToUInt |  2.801 ns | 0.0022 ns | 0.0019 ns |  2.801 ns |      - |       0 B |
     ToUIntNullable |  4.758 ns | 0.0008 ns | 0.0007 ns |  4.758 ns |      - |       0 B |
             ToLong |  2.804 ns | 0.0001 ns | 0.0001 ns |  2.804 ns |      - |       0 B |
     ToLongNullable |  3.829 ns | 0.0030 ns | 0.0027 ns |  3.828 ns |      - |       0 B |
            ToULong |  3.104 ns | 0.0953 ns | 0.2750 ns |  3.020 ns |      - |       0 B |
    ToULongNullable |  3.865 ns | 0.0383 ns | 0.0358 ns |  3.868 ns |      - |       0 B |
            ToFloat |  2.829 ns | 0.0148 ns | 0.0138 ns |  2.831 ns |      - |       0 B |
    ToFloatNullable |  4.997 ns | 0.0071 ns | 0.0055 ns |  4.996 ns |      - |       0 B |
           ToDouble |  2.827 ns | 0.0233 ns | 0.0206 ns |  2.823 ns |      - |       0 B |
   ToDoubleNullable |  3.819 ns | 0.0153 ns | 0.0119 ns |  3.816 ns |      - |       0 B |
          ToDecimal |  7.020 ns | 0.0127 ns | 0.0113 ns |  7.018 ns |      - |       0 B |
  ToDecimalNullable | 20.865 ns | 0.1064 ns | 0.0996 ns | 20.816 ns |      - |       0 B |
         ToDateTime |  3.070 ns | 0.0180 ns | 0.0160 ns |  3.064 ns |      - |       0 B |
 ToDateTimeNullable |  8.836 ns | 0.0478 ns | 0.0400 ns |  8.822 ns |      - |       0 B |
           ToObject |  5.126 ns | 0.1354 ns | 0.2543 ns |  5.030 ns | 0.0057 |      24 B |
          To_String |  5.109 ns | 0.0091 ns | 0.0076 ns |  5.104 ns |      - |       0 B |
             ToEnum | 14.981 ns | 0.3346 ns | 0.5209 ns | 14.737 ns |      - |       0 B |
     ToEnumNullable | 20.160 ns | 0.0211 ns | 0.0187 ns | 20.159 ns |      - |       0 B |
