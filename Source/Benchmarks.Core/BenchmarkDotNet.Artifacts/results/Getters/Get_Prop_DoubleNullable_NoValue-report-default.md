
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 3.947 ns | 0.0019 ns | 0.0017 ns |       0 B |
     ToBoolNullable | 6.537 ns | 0.0190 ns | 0.0168 ns |       0 B |
             ToChar | 3.527 ns | 0.0017 ns | 0.0013 ns |       0 B |
     ToCharNullable | 6.786 ns | 0.0060 ns | 0.0050 ns |       0 B |
            ToSByte | 3.993 ns | 0.0090 ns | 0.0084 ns |       0 B |
    ToSByteNullable | 6.537 ns | 0.0090 ns | 0.0084 ns |       0 B |
             ToByte | 4.154 ns | 0.0017 ns | 0.0014 ns |       0 B |
     ToByteNullable | 6.537 ns | 0.0038 ns | 0.0036 ns |       0 B |
            ToShort | 4.103 ns | 0.0137 ns | 0.0128 ns |       0 B |
    ToShortNullable | 6.543 ns | 0.0048 ns | 0.0045 ns |       0 B |
           ToUShort | 3.958 ns | 0.0061 ns | 0.0057 ns |       0 B |
   ToUShortNullable | 6.538 ns | 0.0042 ns | 0.0040 ns |       0 B |
              ToInt | 3.971 ns | 0.0181 ns | 0.0170 ns |       0 B |
      ToIntNullable | 6.536 ns | 0.0025 ns | 0.0023 ns |       0 B |
             ToUInt | 4.120 ns | 0.0027 ns | 0.0018 ns |       0 B |
     ToUIntNullable | 6.547 ns | 0.0091 ns | 0.0085 ns |       0 B |
             ToLong | 3.971 ns | 0.0081 ns | 0.0076 ns |       0 B |
     ToLongNullable | 6.154 ns | 0.0106 ns | 0.0099 ns |       0 B |
            ToULong | 4.694 ns | 0.0163 ns | 0.0153 ns |       0 B |
    ToULongNullable | 6.148 ns | 0.0013 ns | 0.0011 ns |       0 B |
            ToFloat | 3.966 ns | 0.0028 ns | 0.0022 ns |       0 B |
    ToFloatNullable | 6.535 ns | 0.0011 ns | 0.0008 ns |       0 B |
           ToDouble | 1.789 ns | 0.0008 ns | 0.0006 ns |       0 B |
   ToDoubleNullable | 2.301 ns | 0.0024 ns | 0.0021 ns |       0 B |
          ToDecimal | 6.398 ns | 0.0170 ns | 0.0150 ns |       0 B |
  ToDecimalNullable | 5.900 ns | 0.0072 ns | 0.0064 ns |       0 B |
         ToDateTime | 4.858 ns | 0.0012 ns | 0.0011 ns |       0 B |
 ToDateTimeNullable | 5.902 ns | 0.0054 ns | 0.0051 ns |       0 B |
           ToObject | 2.046 ns | 0.0018 ns | 0.0015 ns |       0 B |
          To_String | 4.162 ns | 0.0024 ns | 0.0022 ns |       0 B |
             ToEnum | 4.301 ns | 0.0049 ns | 0.0046 ns |       0 B |
