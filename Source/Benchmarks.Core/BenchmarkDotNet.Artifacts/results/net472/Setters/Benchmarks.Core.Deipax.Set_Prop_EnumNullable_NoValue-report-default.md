
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 18.5268 ns | 0.1090 ns | 0.1020 ns |           - |           - |           - |                   - |
     FromBoolNullable |  2.2184 ns | 0.0200 ns | 0.0187 ns |           - |           - |           - |                   - |
             FromChar | 18.4911 ns | 0.0806 ns | 0.0754 ns |           - |           - |           - |                   - |
     FromCharNullable |  2.1728 ns | 0.0123 ns | 0.0109 ns |           - |           - |           - |                   - |
            FromSByte | 18.5059 ns | 0.1194 ns | 0.1117 ns |           - |           - |           - |                   - |
    FromSByteNullable |  2.2541 ns | 0.0174 ns | 0.0155 ns |           - |           - |           - |                   - |
             FromByte | 18.2112 ns | 0.0832 ns | 0.0778 ns |           - |           - |           - |                   - |
     FromByteNullable |  2.2967 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
            FromShort | 18.5150 ns | 0.0759 ns | 0.0673 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.2098 ns | 0.0126 ns | 0.0118 ns |           - |           - |           - |                   - |
           FromUShort | 18.4487 ns | 0.0930 ns | 0.0870 ns |           - |           - |           - |                   - |
   FromUShortNullable |  2.2227 ns | 0.0229 ns | 0.0214 ns |           - |           - |           - |                   - |
              FromInt | 18.4097 ns | 0.0984 ns | 0.0921 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.2883 ns | 0.0088 ns | 0.0074 ns |           - |           - |           - |                   - |
             FromUInt | 18.7817 ns | 0.0807 ns | 0.0755 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.2156 ns | 0.0233 ns | 0.0218 ns |           - |           - |           - |                   - |
             FromLong | 18.6950 ns | 0.1601 ns | 0.1497 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.3607 ns | 0.0115 ns | 0.0107 ns |           - |           - |           - |                   - |
            FromULong | 18.6201 ns | 0.0686 ns | 0.0608 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.2525 ns | 0.0132 ns | 0.0117 ns |           - |           - |           - |                   - |
            FromFloat | 20.7728 ns | 0.0863 ns | 0.0807 ns |           - |           - |           - |                   - |
    FromFloatNullable |  2.0926 ns | 0.0194 ns | 0.0182 ns |           - |           - |           - |                   - |
           FromDouble | 20.6194 ns | 0.0909 ns | 0.0806 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  2.2477 ns | 0.0238 ns | 0.0222 ns |           - |           - |           - |                   - |
          FromDecimal | 28.4671 ns | 0.1521 ns | 0.1423 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.7044 ns | 0.0475 ns | 0.0444 ns |           - |           - |           - |                   - |
         FromDateTime | 13.2295 ns | 0.0599 ns | 0.0560 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  8.4055 ns | 0.0503 ns | 0.0420 ns |           - |           - |           - |                   - |
           FromObject |  2.9086 ns | 0.0281 ns | 0.0263 ns |           - |           - |           - |                   - |
           FromString |  1.7908 ns | 0.0096 ns | 0.0080 ns |           - |           - |           - |                   - |
             FromEnum |  0.8992 ns | 0.0130 ns | 0.0122 ns |           - |           - |           - |                   - |
     FromEnumNullable |  0.6901 ns | 0.0074 ns | 0.0066 ns |           - |           - |           - |                   - |
