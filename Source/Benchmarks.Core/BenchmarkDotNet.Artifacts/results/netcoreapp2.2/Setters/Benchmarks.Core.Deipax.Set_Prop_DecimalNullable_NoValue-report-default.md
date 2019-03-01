
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 17.2405 ns | 0.0197 ns | 0.0184 ns |           - |           - |           - |                   - |
     FromBoolNullable | 11.4790 ns | 0.0083 ns | 0.0074 ns |           - |           - |           - |                   - |
             FromChar |  0.7155 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.0081 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
            FromSByte | 16.9976 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
    FromSByteNullable |  9.8864 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
             FromByte | 17.4400 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
     FromByteNullable |  9.8878 ns | 0.0037 ns | 0.0033 ns |           - |           - |           - |                   - |
            FromShort | 17.4258 ns | 0.0108 ns | 0.0090 ns |           - |           - |           - |                   - |
    FromShortNullable |  9.9214 ns | 0.0085 ns | 0.0080 ns |           - |           - |           - |                   - |
           FromUShort | 17.0088 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
   FromUShortNullable |  9.9143 ns | 0.0059 ns | 0.0053 ns |           - |           - |           - |                   - |
              FromInt | 16.7705 ns | 0.0064 ns | 0.0054 ns |           - |           - |           - |                   - |
      FromIntNullable |  9.9101 ns | 0.0085 ns | 0.0080 ns |           - |           - |           - |                   - |
             FromUInt | 27.0270 ns | 0.0182 ns | 0.0170 ns |           - |           - |           - |                   - |
     FromUIntNullable |  9.8956 ns | 0.0055 ns | 0.0051 ns |           - |           - |           - |                   - |
             FromLong | 17.2608 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
     FromLongNullable |  9.9463 ns | 0.0083 ns | 0.0078 ns |           - |           - |           - |                   - |
            FromULong | 16.7273 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
    FromULongNullable |  9.9761 ns | 0.0073 ns | 0.0068 ns |           - |           - |           - |                   - |
            FromFloat | 19.8438 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
    FromFloatNullable |  9.9264 ns | 0.0057 ns | 0.0053 ns |           - |           - |           - |                   - |
           FromDouble | 20.1158 ns | 0.0317 ns | 0.0281 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 10.0193 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
          FromDecimal |  5.5590 ns | 0.0045 ns | 0.0042 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  1.3724 ns | 0.0013 ns | 0.0012 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6967 ns | 0.0028 ns | 0.0026 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6013 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
           FromObject |  9.0392 ns | 0.0116 ns | 0.0108 ns |           - |           - |           - |                   - |
           FromString |  7.9147 ns | 0.0223 ns | 0.0209 ns |           - |           - |           - |                   - |
             FromEnum | 17.0232 ns | 0.0338 ns | 0.0316 ns |           - |           - |           - |                   - |
     FromEnumNullable |  9.9032 ns | 0.0048 ns | 0.0042 ns |           - |           - |           - |                   - |
