
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 0.6892 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
     FromBoolNullable | 0.6680 ns | 0.0141 ns | 0.0125 ns |           - |           - |           - |                   - |
             FromChar | 0.6816 ns | 0.0186 ns | 0.0155 ns |           - |           - |           - |                   - |
     FromCharNullable | 0.8771 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
            FromSByte | 0.6825 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
    FromSByteNullable | 2.5750 ns | 0.0161 ns | 0.0143 ns |           - |           - |           - |                   - |
             FromByte | 0.6841 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
     FromByteNullable | 2.0013 ns | 0.0251 ns | 0.0235 ns |           - |           - |           - |                   - |
            FromShort | 0.8970 ns | 0.0187 ns | 0.0166 ns |           - |           - |           - |                   - |
    FromShortNullable | 2.2877 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
           FromUShort | 0.8869 ns | 0.0100 ns | 0.0088 ns |           - |           - |           - |                   - |
   FromUShortNullable | 1.9081 ns | 0.0151 ns | 0.0142 ns |           - |           - |           - |                   - |
              FromInt | 0.6777 ns | 0.0147 ns | 0.0138 ns |           - |           - |           - |                   - |
      FromIntNullable | 1.8935 ns | 0.0196 ns | 0.0183 ns |           - |           - |           - |                   - |
             FromUInt | 0.6369 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
     FromUIntNullable | 1.8899 ns | 0.0177 ns | 0.0166 ns |           - |           - |           - |                   - |
             FromLong | 0.6669 ns | 0.0346 ns | 0.0306 ns |           - |           - |           - |                   - |
     FromLongNullable | 1.9145 ns | 0.0207 ns | 0.0194 ns |           - |           - |           - |                   - |
            FromULong | 1.2338 ns | 0.0173 ns | 0.0144 ns |           - |           - |           - |                   - |
    FromULongNullable | 1.8407 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
            FromFloat | 0.7853 ns | 0.0133 ns | 0.0124 ns |           - |           - |           - |                   - |
    FromFloatNullable | 1.8650 ns | 0.0264 ns | 0.0247 ns |           - |           - |           - |                   - |
           FromDouble | 0.8765 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 1.9876 ns | 0.0197 ns | 0.0185 ns |           - |           - |           - |                   - |
          FromDecimal | 7.8262 ns | 0.0680 ns | 0.0636 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 8.7708 ns | 0.0812 ns | 0.0759 ns |           - |           - |           - |                   - |
         FromDateTime | 0.6518 ns | 0.0133 ns | 0.0124 ns |           - |           - |           - |                   - |
 FromDateTimeNullable | 1.3584 ns | 0.0201 ns | 0.0188 ns |           - |           - |           - |                   - |
           FromObject | 2.6887 ns | 0.0290 ns | 0.0271 ns |           - |           - |           - |                   - |
           FromString | 1.7145 ns | 0.0229 ns | 0.0214 ns |           - |           - |           - |                   - |
             FromEnum | 0.6428 ns | 0.0150 ns | 0.0140 ns |           - |           - |           - |                   - |
     FromEnumNullable | 2.0255 ns | 0.0204 ns | 0.0190 ns |           - |           - |           - |                   - |
