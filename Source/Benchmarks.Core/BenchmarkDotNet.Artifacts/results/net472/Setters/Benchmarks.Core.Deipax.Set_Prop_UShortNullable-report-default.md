
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6335 ns | 0.0179 ns | 0.0167 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.9991 ns | 0.0191 ns | 0.0169 ns |           - |           - |           - |                   - |
             FromChar |  0.5970 ns | 0.0068 ns | 0.0064 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.8722 ns | 0.0189 ns | 0.0177 ns |           - |           - |           - |                   - |
            FromSByte |  1.7195 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
    FromSByteNullable |  2.7621 ns | 0.0214 ns | 0.0200 ns |           - |           - |           - |                   - |
             FromByte |  0.5541 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.9924 ns | 0.0254 ns | 0.0238 ns |           - |           - |           - |                   - |
            FromShort |  1.7165 ns | 0.0112 ns | 0.0104 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.5988 ns | 0.0125 ns | 0.0104 ns |           - |           - |           - |                   - |
           FromUShort |  0.5992 ns | 0.0104 ns | 0.0097 ns |           - |           - |           - |                   - |
   FromUShortNullable |  0.5649 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
              FromInt |  1.6468 ns | 0.0184 ns | 0.0172 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.7341 ns | 0.0150 ns | 0.0141 ns |           - |           - |           - |                   - |
             FromUInt |  1.6639 ns | 0.0101 ns | 0.0095 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.6594 ns | 0.0269 ns | 0.0251 ns |           - |           - |           - |                   - |
             FromLong |  1.6681 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
     FromLongNullable |  3.3833 ns | 0.0344 ns | 0.0322 ns |           - |           - |           - |                   - |
            FromULong |  1.6889 ns | 0.0132 ns | 0.0124 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.9939 ns | 0.0191 ns | 0.0179 ns |           - |           - |           - |                   - |
            FromFloat |  3.5839 ns | 0.0232 ns | 0.0217 ns |           - |           - |           - |                   - |
    FromFloatNullable |  4.4390 ns | 0.0246 ns | 0.0230 ns |           - |           - |           - |                   - |
           FromDouble |  3.6798 ns | 0.0336 ns | 0.0315 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  6.1389 ns | 0.0315 ns | 0.0295 ns |           - |           - |           - |                   - |
          FromDecimal | 13.1850 ns | 0.0808 ns | 0.0717 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 23.4952 ns | 0.1535 ns | 0.1435 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7002 ns | 0.0083 ns | 0.0074 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5643 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
           FromObject | 12.7810 ns | 0.0669 ns | 0.0626 ns |           - |           - |           - |                   - |
           FromString | 44.3755 ns | 0.3461 ns | 0.3237 ns |           - |           - |           - |                   - |
             FromEnum |  1.6710 ns | 0.0161 ns | 0.0151 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.7213 ns | 0.0175 ns | 0.0163 ns |           - |           - |           - |                   - |
