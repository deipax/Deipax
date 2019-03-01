
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8791 ns | 0.0166 ns | 0.0155 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.9262 ns | 0.0141 ns | 0.0125 ns |           - |           - |           - |                   - |
             FromChar |  0.6822 ns | 0.0127 ns | 0.0119 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.8112 ns | 0.0130 ns | 0.0122 ns |           - |           - |           - |                   - |
            FromSByte |  0.7027 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.9335 ns | 0.0112 ns | 0.0100 ns |           - |           - |           - |                   - |
             FromByte |  0.6858 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.9389 ns | 0.0111 ns | 0.0098 ns |           - |           - |           - |                   - |
            FromShort |  0.6830 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.8124 ns | 0.0199 ns | 0.0186 ns |           - |           - |           - |                   - |
           FromUShort |  0.6795 ns | 0.0138 ns | 0.0122 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.9034 ns | 0.0220 ns | 0.0195 ns |           - |           - |           - |                   - |
              FromInt |  0.6805 ns | 0.0106 ns | 0.0099 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.7006 ns | 0.0175 ns | 0.0164 ns |           - |           - |           - |                   - |
             FromUInt |  0.6953 ns | 0.0100 ns | 0.0089 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.8795 ns | 0.0177 ns | 0.0166 ns |           - |           - |           - |                   - |
             FromLong |  1.2824 ns | 0.0143 ns | 0.0133 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.1157 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
            FromULong |  1.6586 ns | 0.0187 ns | 0.0175 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.7834 ns | 0.0103 ns | 0.0092 ns |           - |           - |           - |                   - |
            FromFloat |  3.4167 ns | 0.0340 ns | 0.0318 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.8815 ns | 0.0173 ns | 0.0162 ns |           - |           - |           - |                   - |
           FromDouble |  3.3120 ns | 0.0254 ns | 0.0238 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.9503 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
          FromDecimal | 12.9242 ns | 0.0665 ns | 0.0622 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.2525 ns | 0.0460 ns | 0.0408 ns |           - |           - |           - |                   - |
         FromDateTime |  0.8894 ns | 0.0163 ns | 0.0153 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5442 ns | 0.0110 ns | 0.0103 ns |           - |           - |           - |                   - |
           FromObject |  2.7314 ns | 0.0130 ns | 0.0116 ns |           - |           - |           - |                   - |
           FromString |  1.7449 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
             FromEnum |  0.6881 ns | 0.0179 ns | 0.0167 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.8780 ns | 0.0113 ns | 0.0105 ns |           - |           - |           - |                   - |
