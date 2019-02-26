
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 11.7669 ns | 0.0127 ns | 0.0118 ns |           - |           - |           - |                   - |
     FromBoolNullable | 12.2050 ns | 0.0056 ns | 0.0052 ns |           - |           - |           - |                   - |
             FromChar | 11.9909 ns | 0.0073 ns | 0.0064 ns |           - |           - |           - |                   - |
     FromCharNullable | 12.2168 ns | 0.0085 ns | 0.0076 ns |           - |           - |           - |                   - |
            FromSByte | 11.9967 ns | 0.0071 ns | 0.0067 ns |           - |           - |           - |                   - |
    FromSByteNullable | 12.2284 ns | 0.0075 ns | 0.0070 ns |           - |           - |           - |                   - |
             FromByte | 11.9560 ns | 0.0134 ns | 0.0119 ns |           - |           - |           - |                   - |
     FromByteNullable | 12.2497 ns | 0.0057 ns | 0.0054 ns |           - |           - |           - |                   - |
            FromShort | 11.9985 ns | 0.0085 ns | 0.0079 ns |           - |           - |           - |                   - |
    FromShortNullable | 12.2365 ns | 0.0110 ns | 0.0097 ns |           - |           - |           - |                   - |
           FromUShort | 12.0207 ns | 0.0084 ns | 0.0079 ns |           - |           - |           - |                   - |
   FromUShortNullable | 12.2259 ns | 0.0060 ns | 0.0053 ns |           - |           - |           - |                   - |
              FromInt | 11.9674 ns | 0.0087 ns | 0.0081 ns |           - |           - |           - |                   - |
      FromIntNullable | 12.2384 ns | 0.0061 ns | 0.0057 ns |           - |           - |           - |                   - |
             FromUInt | 12.0357 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
     FromUIntNullable | 12.2821 ns | 0.0081 ns | 0.0075 ns |           - |           - |           - |                   - |
             FromLong | 12.2871 ns | 0.0052 ns | 0.0046 ns |           - |           - |           - |                   - |
     FromLongNullable | 13.2387 ns | 0.0118 ns | 0.0111 ns |           - |           - |           - |                   - |
            FromULong | 12.2826 ns | 0.0068 ns | 0.0060 ns |           - |           - |           - |                   - |
    FromULongNullable | 13.1936 ns | 0.0230 ns | 0.0215 ns |           - |           - |           - |                   - |
            FromFloat | 13.6708 ns | 0.0093 ns | 0.0083 ns |           - |           - |           - |                   - |
    FromFloatNullable | 13.9069 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
           FromDouble | 13.7136 ns | 0.0082 ns | 0.0077 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 14.5791 ns | 0.0103 ns | 0.0091 ns |           - |           - |           - |                   - |
          FromDecimal | 28.3781 ns | 0.0474 ns | 0.0395 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 33.1876 ns | 0.0467 ns | 0.0437 ns |           - |           - |           - |                   - |
         FromDateTime | 11.0467 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  2.1162 ns | 0.0026 ns | 0.0025 ns |           - |           - |           - |                   - |
           FromObject |  2.2338 ns | 0.0021 ns | 0.0020 ns |           - |           - |           - |                   - |
           FromString | 23.2090 ns | 0.0285 ns | 0.0253 ns |           - |           - |           - |                   - |
             FromEnum |  0.7146 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
     FromEnumNullable |  0.9319 ns | 0.0029 ns | 0.0027 ns |           - |           - |           - |                   - |
