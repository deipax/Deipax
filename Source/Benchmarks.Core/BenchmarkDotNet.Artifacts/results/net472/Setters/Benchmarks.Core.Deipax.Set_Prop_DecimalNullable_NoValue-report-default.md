
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 16.5473 ns | 0.1147 ns | 0.1073 ns |           - |           - |           - |                   - |
     FromBoolNullable | 10.9172 ns | 0.0606 ns | 0.0567 ns |           - |           - |           - |                   - |
             FromChar |  0.5930 ns | 0.0090 ns | 0.0080 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.9316 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
            FromSByte | 15.9517 ns | 0.0833 ns | 0.0779 ns |           - |           - |           - |                   - |
    FromSByteNullable | 10.8346 ns | 0.0415 ns | 0.0388 ns |           - |           - |           - |                   - |
             FromByte | 15.8934 ns | 0.0935 ns | 0.0875 ns |           - |           - |           - |                   - |
     FromByteNullable | 10.9071 ns | 0.0808 ns | 0.0756 ns |           - |           - |           - |                   - |
            FromShort | 15.7940 ns | 0.0838 ns | 0.0783 ns |           - |           - |           - |                   - |
    FromShortNullable | 10.4814 ns | 0.0477 ns | 0.0446 ns |           - |           - |           - |                   - |
           FromUShort | 16.2920 ns | 0.1585 ns | 0.1483 ns |           - |           - |           - |                   - |
   FromUShortNullable | 11.7022 ns | 0.0280 ns | 0.0249 ns |           - |           - |           - |                   - |
              FromInt | 15.8844 ns | 0.1269 ns | 0.1187 ns |           - |           - |           - |                   - |
      FromIntNullable | 13.1849 ns | 0.0814 ns | 0.0761 ns |           - |           - |           - |                   - |
             FromUInt | 15.8118 ns | 0.0590 ns | 0.0493 ns |           - |           - |           - |                   - |
     FromUIntNullable | 11.8126 ns | 0.0825 ns | 0.0772 ns |           - |           - |           - |                   - |
             FromLong | 16.4563 ns | 0.0771 ns | 0.0721 ns |           - |           - |           - |                   - |
     FromLongNullable | 11.5640 ns | 0.0448 ns | 0.0419 ns |           - |           - |           - |                   - |
            FromULong | 16.1657 ns | 0.0837 ns | 0.0783 ns |           - |           - |           - |                   - |
    FromULongNullable | 12.8568 ns | 0.0602 ns | 0.0534 ns |           - |           - |           - |                   - |
            FromFloat | 18.8466 ns | 0.1043 ns | 0.0975 ns |           - |           - |           - |                   - |
    FromFloatNullable | 11.7112 ns | 0.0544 ns | 0.0509 ns |           - |           - |           - |                   - |
           FromDouble | 18.9378 ns | 0.1533 ns | 0.1434 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 11.6597 ns | 0.0472 ns | 0.0418 ns |           - |           - |           - |                   - |
          FromDecimal |  5.2684 ns | 0.0234 ns | 0.0219 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  1.3270 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6790 ns | 0.0117 ns | 0.0109 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5734 ns | 0.0163 ns | 0.0153 ns |           - |           - |           - |                   - |
           FromObject |  8.2296 ns | 0.0598 ns | 0.0559 ns |           - |           - |           - |                   - |
           FromString | 11.9306 ns | 0.0557 ns | 0.0521 ns |           - |           - |           - |                   - |
             FromEnum | 16.1762 ns | 0.1212 ns | 0.1134 ns |           - |           - |           - |                   - |
     FromEnumNullable | 11.7962 ns | 0.0784 ns | 0.0733 ns |           - |           - |           - |                   - |
