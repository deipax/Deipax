
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  2.882 ns | 0.0088 ns | 0.0083 ns |      - |       0 B |
     ToBoolNullable |  6.520 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
             ToChar |  1.264 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
     ToCharNullable |  4.488 ns | 0.0017 ns | 0.0016 ns |      - |       0 B |
            ToSByte |  3.710 ns | 0.0036 ns | 0.0032 ns |      - |       0 B |
    ToSByteNullable |  6.526 ns | 0.0014 ns | 0.0013 ns |      - |       0 B |
             ToByte |  3.852 ns | 0.0042 ns | 0.0035 ns |      - |       0 B |
     ToByteNullable |  6.541 ns | 0.0218 ns | 0.0193 ns |      - |       0 B |
            ToShort |  3.752 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |
    ToShortNullable |  6.543 ns | 0.0314 ns | 0.0278 ns |      - |       0 B |
           ToUShort |  3.886 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
   ToUShortNullable |  6.529 ns | 0.0036 ns | 0.0030 ns |      - |       0 B |
              ToInt |  3.056 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
      ToIntNullable |  6.535 ns | 0.0072 ns | 0.0067 ns |      - |       0 B |
             ToUInt |  3.293 ns | 0.0009 ns | 0.0006 ns |      - |       0 B |
     ToUIntNullable |  6.527 ns | 0.0078 ns | 0.0066 ns |      - |       0 B |
             ToLong |  3.073 ns | 0.0041 ns | 0.0039 ns |      - |       0 B |
     ToLongNullable |  6.174 ns | 0.0146 ns | 0.0136 ns |      - |       0 B |
            ToULong |  3.074 ns | 0.0032 ns | 0.0030 ns |      - |       0 B |
    ToULongNullable |  5.668 ns | 0.0224 ns | 0.0198 ns |      - |       0 B |
            ToFloat |  3.071 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
    ToFloatNullable |  6.535 ns | 0.0077 ns | 0.0072 ns |      - |       0 B |
           ToDouble |  3.242 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
   ToDoubleNullable |  5.974 ns | 0.0291 ns | 0.0258 ns |      - |       0 B |
          ToDecimal |  6.140 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
  ToDecimalNullable |  5.910 ns | 0.0079 ns | 0.0074 ns |      - |       0 B |
         ToDateTime |  4.345 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
 ToDateTimeNullable |  9.852 ns | 0.0080 ns | 0.0067 ns |      - |       0 B |
           ToObject |  3.937 ns | 0.0067 ns | 0.0063 ns | 0.0057 |      24 B |
          To_String |  6.856 ns | 0.0037 ns | 0.0033 ns | 0.0076 |      32 B |
             ToEnum | 20.973 ns | 0.0083 ns | 0.0069 ns | 0.0057 |      24 B |
