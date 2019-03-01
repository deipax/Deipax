
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 14.9159 ns | 0.1156 ns | 0.1081 ns |           - |           - |           - |                   - |
     FromBoolNullable | 14.5013 ns | 0.0985 ns | 0.0873 ns |           - |           - |           - |                   - |
             FromChar | 13.6103 ns | 0.0477 ns | 0.0399 ns |           - |           - |           - |                   - |
     FromCharNullable | 14.6030 ns | 0.1025 ns | 0.0958 ns |           - |           - |           - |                   - |
            FromSByte | 13.7672 ns | 0.1025 ns | 0.0959 ns |           - |           - |           - |                   - |
    FromSByteNullable | 14.4320 ns | 0.0910 ns | 0.0851 ns |           - |           - |           - |                   - |
             FromByte | 13.7629 ns | 0.0914 ns | 0.0855 ns |           - |           - |           - |                   - |
     FromByteNullable | 14.5053 ns | 0.0971 ns | 0.0908 ns |           - |           - |           - |                   - |
            FromShort | 13.6343 ns | 0.0765 ns | 0.0716 ns |           - |           - |           - |                   - |
    FromShortNullable | 14.6931 ns | 0.1251 ns | 0.1170 ns |           - |           - |           - |                   - |
           FromUShort | 13.7399 ns | 0.1000 ns | 0.0935 ns |           - |           - |           - |                   - |
   FromUShortNullable | 14.5264 ns | 0.0899 ns | 0.0841 ns |           - |           - |           - |                   - |
              FromInt | 13.7880 ns | 0.1279 ns | 0.1196 ns |           - |           - |           - |                   - |
      FromIntNullable | 14.5472 ns | 0.0931 ns | 0.0871 ns |           - |           - |           - |                   - |
             FromUInt | 14.7732 ns | 0.0658 ns | 0.0615 ns |           - |           - |           - |                   - |
     FromUIntNullable | 14.9639 ns | 0.0904 ns | 0.0846 ns |           - |           - |           - |                   - |
             FromLong | 14.5749 ns | 0.3189 ns | 0.2983 ns |           - |           - |           - |                   - |
     FromLongNullable | 16.2117 ns | 0.3450 ns | 0.3835 ns |           - |           - |           - |                   - |
            FromULong | 14.8022 ns | 0.2042 ns | 0.1911 ns |           - |           - |           - |                   - |
    FromULongNullable | 16.7004 ns | 0.2136 ns | 0.1998 ns |           - |           - |           - |                   - |
            FromFloat | 17.1827 ns | 0.2453 ns | 0.2295 ns |           - |           - |           - |                   - |
    FromFloatNullable | 17.7944 ns | 0.0740 ns | 0.0656 ns |           - |           - |           - |                   - |
           FromDouble | 16.7779 ns | 0.2074 ns | 0.1940 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 18.2901 ns | 0.1054 ns | 0.0986 ns |           - |           - |           - |                   - |
          FromDecimal | 25.4184 ns | 0.2478 ns | 0.2318 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 29.9220 ns | 0.3403 ns | 0.3017 ns |           - |           - |           - |                   - |
         FromDateTime | 13.6220 ns | 0.1066 ns | 0.0945 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  2.1777 ns | 0.0368 ns | 0.0344 ns |           - |           - |           - |                   - |
           FromObject |  2.2179 ns | 0.0272 ns | 0.0254 ns |           - |           - |           - |                   - |
           FromString | 29.6332 ns | 0.4763 ns | 0.4455 ns |           - |           - |           - |                   - |
             FromEnum |  0.6629 ns | 0.0036 ns | 0.0030 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.3663 ns | 0.0022 ns | 0.0020 ns |           - |           - |           - |                   - |
