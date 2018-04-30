
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
             ToBool |  1.293 ns | 0.0022 ns | 0.0018 ns |  1.293 ns |      - |       0 B |
     ToBoolNullable |  4.465 ns | 0.0003 ns | 0.0003 ns |  4.465 ns |      - |       0 B |
             ToChar |  3.108 ns | 0.0045 ns | 0.0035 ns |  3.110 ns |      - |       0 B |
     ToCharNullable |  6.504 ns | 0.0045 ns | 0.0038 ns |  6.502 ns |      - |       0 B |
            ToSByte |  3.589 ns | 0.0145 ns | 0.0136 ns |  3.583 ns |      - |       0 B |
    ToSByteNullable |  6.601 ns | 0.0859 ns | 0.0670 ns |  6.589 ns |      - |       0 B |
             ToByte |  3.600 ns | 0.1061 ns | 0.1994 ns |  3.510 ns |      - |       0 B |
     ToByteNullable |  6.518 ns | 0.0103 ns | 0.0081 ns |  6.514 ns |      - |       0 B |
            ToShort |  3.613 ns | 0.0222 ns | 0.0207 ns |  3.608 ns |      - |       0 B |
    ToShortNullable |  6.546 ns | 0.0382 ns | 0.0339 ns |  6.540 ns |      - |       0 B |
           ToUShort |  3.601 ns | 0.0035 ns | 0.0033 ns |  3.601 ns |      - |       0 B |
   ToUShortNullable |  6.530 ns | 0.0162 ns | 0.0152 ns |  6.527 ns |      - |       0 B |
              ToInt |  3.610 ns | 0.0103 ns | 0.0086 ns |  3.607 ns |      - |       0 B |
      ToIntNullable |  6.574 ns | 0.0730 ns | 0.0647 ns |  6.549 ns |      - |       0 B |
             ToUInt |  3.600 ns | 0.0343 ns | 0.0286 ns |  3.589 ns |      - |       0 B |
     ToUIntNullable |  7.366 ns | 0.1108 ns | 0.1037 ns |  7.332 ns |      - |       0 B |
             ToLong |  3.838 ns | 0.0043 ns | 0.0036 ns |  3.838 ns |      - |       0 B |
     ToLongNullable |  6.512 ns | 0.0083 ns | 0.0074 ns |  6.512 ns |      - |       0 B |
            ToULong |  3.575 ns | 0.0103 ns | 0.0097 ns |  3.577 ns |      - |       0 B |
    ToULongNullable |  6.405 ns | 0.0090 ns | 0.0085 ns |  6.404 ns |      - |       0 B |
            ToFloat |  3.842 ns | 0.0079 ns | 0.0070 ns |  3.842 ns |      - |       0 B |
    ToFloatNullable |  6.554 ns | 0.0413 ns | 0.0366 ns |  6.544 ns |      - |       0 B |
           ToDouble |  3.865 ns | 0.0758 ns | 0.0672 ns |  3.833 ns |      - |       0 B |
   ToDoubleNullable |  6.773 ns | 0.0421 ns | 0.0374 ns |  6.770 ns |      - |       0 B |
          ToDecimal |  7.423 ns | 0.0115 ns | 0.0102 ns |  7.422 ns |      - |       0 B |
  ToDecimalNullable | 16.245 ns | 0.0195 ns | 0.0182 ns | 16.239 ns |      - |       0 B |
         ToDateTime |  4.610 ns | 0.0040 ns | 0.0038 ns |  4.610 ns |      - |       0 B |
 ToDateTimeNullable |  6.176 ns | 0.0056 ns | 0.0052 ns |  6.175 ns |      - |       0 B |
           ToObject |  3.793 ns | 0.0046 ns | 0.0041 ns |  3.792 ns | 0.0057 |      24 B |
          To_String |  5.623 ns | 0.0053 ns | 0.0049 ns |  5.622 ns |      - |       0 B |
             ToEnum | 22.734 ns | 0.0559 ns | 0.0496 ns | 22.729 ns | 0.0057 |      24 B |
