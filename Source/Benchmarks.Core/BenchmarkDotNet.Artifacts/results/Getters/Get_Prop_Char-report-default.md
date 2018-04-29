 
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.594 ns | 0.0008 ns | 0.0007 ns |  3.594 ns |      - |       0 B |
     ToBoolNullable |  6.806 ns | 0.0345 ns | 0.0306 ns |  6.824 ns |      - |       0 B |
             ToChar |  1.807 ns | 0.0029 ns | 0.0024 ns |  1.805 ns |      - |       0 B |
     ToCharNullable |  4.716 ns | 0.0018 ns | 0.0016 ns |  4.716 ns |      - |       0 B |
            ToSByte |  4.843 ns | 0.0264 ns | 0.0247 ns |  4.832 ns |      - |       0 B |
    ToSByteNullable |  7.062 ns | 0.0037 ns | 0.0029 ns |  7.062 ns |      - |       0 B |
             ToByte |  4.380 ns | 0.0293 ns | 0.0260 ns |  4.394 ns |      - |       0 B |
     ToByteNullable |  7.027 ns | 0.0018 ns | 0.0015 ns |  7.027 ns |      - |       0 B |
            ToShort |  4.404 ns | 0.0289 ns | 0.0256 ns |  4.421 ns |      - |       0 B |
    ToShortNullable |  7.029 ns | 0.0031 ns | 0.0029 ns |  7.029 ns |      - |       0 B |
           ToUShort |  3.866 ns | 0.0222 ns | 0.0208 ns |  3.856 ns |      - |       0 B |
   ToUShortNullable |  6.823 ns | 0.0038 ns | 0.0035 ns |  6.822 ns |      - |       0 B |
              ToInt |  3.876 ns | 0.0272 ns | 0.0254 ns |  3.891 ns |      - |       0 B |
      ToIntNullable |  6.794 ns | 0.0176 ns | 0.0147 ns |  6.789 ns |      - |       0 B |
             ToUInt |  3.881 ns | 0.0028 ns | 0.0018 ns |  3.882 ns |      - |       0 B |
     ToUIntNullable |  6.777 ns | 0.0090 ns | 0.0084 ns |  6.771 ns |      - |       0 B |
             ToLong |  3.842 ns | 0.0122 ns | 0.0114 ns |  3.834 ns |      - |       0 B |
     ToLongNullable |  6.387 ns | 0.0017 ns | 0.0014 ns |  6.387 ns |      - |       0 B |
            ToULong |  3.857 ns | 0.0189 ns | 0.0168 ns |  3.866 ns |      - |       0 B |
    ToULongNullable |  6.131 ns | 0.0010 ns | 0.0008 ns |  6.131 ns |      - |       0 B |
            ToFloat |  3.838 ns | 0.0099 ns | 0.0092 ns |  3.832 ns |      - |       0 B |
    ToFloatNullable |  6.768 ns | 0.0011 ns | 0.0010 ns |  6.768 ns |      - |       0 B |
           ToDouble |  3.841 ns | 0.0271 ns | 0.0254 ns |  3.821 ns |      - |       0 B |
   ToDoubleNullable |  6.132 ns | 0.0006 ns | 0.0005 ns |  6.132 ns |      - |       0 B |
          ToDecimal |  6.913 ns | 0.0120 ns | 0.0112 ns |  6.918 ns |      - |       0 B |
  ToDecimalNullable |  6.131 ns | 0.0024 ns | 0.0020 ns |  6.131 ns |      - |       0 B |
         ToDateTime |  5.409 ns | 0.0038 ns | 0.0036 ns |  5.409 ns |      - |       0 B |
 ToDateTimeNullable |  6.642 ns | 0.0009 ns | 0.0008 ns |  6.642 ns |      - |       0 B |
           ToObject |  4.589 ns | 0.0020 ns | 0.0019 ns |  4.588 ns | 0.0057 |      24 B |
          To_String |  7.739 ns | 0.0029 ns | 0.0026 ns |  7.739 ns | 0.0076 |      32 B |
             ToEnum | 21.919 ns | 0.0171 ns | 0.0152 ns | 21.918 ns | 0.0057 |      24 B |
