
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.8702 ns | 0.0037 ns | 0.0035 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.0993 ns | 0.0038 ns | 0.0036 ns |           - |           - |           - |                   - |
             ToChar |  0.8736 ns | 0.0018 ns | 0.0014 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.3284 ns | 0.0024 ns | 0.0021 ns |           - |           - |           - |                   - |
            ToSByte |  1.1611 ns | 0.0073 ns | 0.0069 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.1051 ns | 0.0055 ns | 0.0052 ns |           - |           - |           - |                   - |
             ToByte |  1.1563 ns | 0.0023 ns | 0.0022 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.1021 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
            ToShort |  1.1609 ns | 0.0032 ns | 0.0030 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.0990 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
           ToUShort |  0.8728 ns | 0.0029 ns | 0.0028 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.1014 ns | 0.0025 ns | 0.0022 ns |           - |           - |           - |                   - |
              ToInt |  0.8750 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1051 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
             ToUInt |  0.8787 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.1014 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
             ToLong |  0.8826 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.4689 ns | 0.0147 ns | 0.0123 ns |           - |           - |           - |                   - |
            ToULong |  0.9328 ns | 0.0512 ns | 0.0454 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.3860 ns | 0.0190 ns | 0.0178 ns |           - |           - |           - |                   - |
            ToFloat |  0.9273 ns | 0.0229 ns | 0.0203 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3470 ns | 0.0118 ns | 0.0105 ns |           - |           - |           - |                   - |
           ToDouble |  0.8979 ns | 0.0045 ns | 0.0042 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.4186 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
          ToDecimal |  3.0419 ns | 0.0052 ns | 0.0041 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  1.3713 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
         ToDateTime |  1.9469 ns | 0.0084 ns | 0.0075 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.1735 ns | 0.0113 ns | 0.0094 ns |           - |           - |           - |                   - |
           ToObject |  3.5220 ns | 0.0160 ns | 0.0142 ns |      0.0038 |           - |           - |                24 B |
          To_String |  4.1647 ns | 0.0042 ns | 0.0037 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 10.1898 ns | 0.0608 ns | 0.0568 ns |           - |           - |           - |                   - |
     ToEnumNullable | 14.8616 ns | 0.0466 ns | 0.0413 ns |           - |           - |           - |                   - |
