
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |   1.370 ns | 0.0028 ns | 0.0025 ns |           - |           - |           - |                   - |
     ToBoolNullable |   4.823 ns | 0.0036 ns | 0.0034 ns |           - |           - |           - |                   - |
             ToChar |   1.142 ns | 0.0012 ns | 0.0012 ns |           - |           - |           - |                   - |
     ToCharNullable |   4.364 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
            ToSByte |   4.427 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
    ToSByteNullable |   6.661 ns | 0.0057 ns | 0.0053 ns |           - |           - |           - |                   - |
             ToByte |   4.710 ns | 0.0035 ns | 0.0031 ns |           - |           - |           - |                   - |
     ToByteNullable |   6.650 ns | 0.0042 ns | 0.0037 ns |           - |           - |           - |                   - |
            ToShort |   4.715 ns | 0.0064 ns | 0.0054 ns |           - |           - |           - |                   - |
    ToShortNullable |   6.652 ns | 0.0041 ns | 0.0039 ns |           - |           - |           - |                   - |
           ToUShort |   4.564 ns | 0.0027 ns | 0.0026 ns |           - |           - |           - |                   - |
   ToUShortNullable |   6.663 ns | 0.0044 ns | 0.0035 ns |           - |           - |           - |                   - |
              ToInt |   3.088 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
      ToIntNullable |   5.852 ns | 0.0056 ns | 0.0052 ns |           - |           - |           - |                   - |
             ToUInt |   3.210 ns | 0.0052 ns | 0.0049 ns |           - |           - |           - |                   - |
     ToUIntNullable |   5.968 ns | 0.0059 ns | 0.0055 ns |           - |           - |           - |                   - |
             ToLong |   2.531 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
     ToLongNullable |   3.020 ns | 0.0085 ns | 0.0080 ns |           - |           - |           - |                   - |
            ToULong |   2.475 ns | 0.0034 ns | 0.0032 ns |           - |           - |           - |                   - |
    ToULongNullable |   3.002 ns | 0.0027 ns | 0.0024 ns |           - |           - |           - |                   - |
            ToFloat |   1.375 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
    ToFloatNullable |   4.366 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
           ToDouble |   1.135 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
   ToDoubleNullable |   1.802 ns | 0.0025 ns | 0.0023 ns |           - |           - |           - |                   - |
          ToDecimal |  53.593 ns | 0.0214 ns | 0.0200 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  64.233 ns | 0.0436 ns | 0.0408 ns |           - |           - |           - |                   - |
         ToDateTime |   2.042 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |   8.244 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
           ToObject |   3.712 ns | 0.0071 ns | 0.0066 ns |      0.0038 |           - |           - |                24 B |
          To_String | 107.828 ns | 0.0719 ns | 0.0673 ns |      0.0050 |           - |           - |                32 B |
             ToEnum |  11.929 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
     ToEnumNullable |  16.751 ns | 0.0150 ns | 0.0140 ns |           - |           - |           - |                   - |
