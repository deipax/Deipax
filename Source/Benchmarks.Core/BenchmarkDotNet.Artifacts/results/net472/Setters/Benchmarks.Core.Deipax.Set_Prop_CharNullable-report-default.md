
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6682 ns | 0.0183 ns | 0.0171 ns |           - |           - |           - |                   - |
     FromBoolNullable |  0.9260 ns | 0.0110 ns | 0.0097 ns |           - |           - |           - |                   - |
             FromChar |  0.8793 ns | 0.0093 ns | 0.0077 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.7040 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
            FromSByte |  1.8243 ns | 0.0187 ns | 0.0175 ns |           - |           - |           - |                   - |
    FromSByteNullable |  2.8181 ns | 0.0300 ns | 0.0280 ns |           - |           - |           - |                   - |
             FromByte |  0.6967 ns | 0.0171 ns | 0.0160 ns |           - |           - |           - |                   - |
     FromByteNullable |  2.0597 ns | 0.0118 ns | 0.0105 ns |           - |           - |           - |                   - |
            FromShort |  1.7989 ns | 0.0192 ns | 0.0179 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.6269 ns | 0.0280 ns | 0.0262 ns |           - |           - |           - |                   - |
           FromUShort |  0.6762 ns | 0.0132 ns | 0.0123 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.9319 ns | 0.0299 ns | 0.0279 ns |           - |           - |           - |                   - |
              FromInt |  1.6871 ns | 0.0248 ns | 0.0232 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.7426 ns | 0.0312 ns | 0.0292 ns |           - |           - |           - |                   - |
             FromUInt |  1.7417 ns | 0.0192 ns | 0.0180 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.6491 ns | 0.0233 ns | 0.0218 ns |           - |           - |           - |                   - |
             FromLong |  1.6730 ns | 0.0166 ns | 0.0155 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.9516 ns | 0.0287 ns | 0.0268 ns |           - |           - |           - |                   - |
            FromULong |  1.6900 ns | 0.0161 ns | 0.0143 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.9988 ns | 0.0290 ns | 0.0271 ns |           - |           - |           - |                   - |
            FromFloat |  0.6589 ns | 0.0175 ns | 0.0164 ns |           - |           - |           - |                   - |
    FromFloatNullable |  0.9665 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
           FromDouble |  0.6358 ns | 0.0191 ns | 0.0179 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.0835 ns | 0.0179 ns | 0.0167 ns |           - |           - |           - |                   - |
          FromDecimal |  1.0855 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  1.5381 ns | 0.0210 ns | 0.0197 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6577 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5728 ns | 0.0167 ns | 0.0148 ns |           - |           - |           - |                   - |
           FromObject | 12.9985 ns | 0.0695 ns | 0.0650 ns |           - |           - |           - |                   - |
           FromString |  3.1556 ns | 0.0523 ns | 0.0489 ns |           - |           - |           - |                   - |
             FromEnum |  1.6648 ns | 0.0247 ns | 0.0231 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.7431 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
