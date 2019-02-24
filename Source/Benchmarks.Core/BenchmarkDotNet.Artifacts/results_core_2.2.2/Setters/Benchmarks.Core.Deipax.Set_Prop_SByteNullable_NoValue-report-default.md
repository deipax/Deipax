
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.9369 ns | 0.0052 ns | 0.0049 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.5798 ns | 0.0555 ns | 0.0760 ns |           - |           - |           - |                   - |
             FromChar |  1.3855 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.7380 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
            FromSByte |  0.9359 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
    FromSByteNullable |  0.7032 ns | 0.0018 ns | 0.0017 ns |           - |           - |           - |                   - |
             FromByte |  1.3662 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.7618 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
            FromShort |  1.8722 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.7444 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
           FromUShort |  1.3340 ns | 0.0024 ns | 0.0022 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.7386 ns | 0.0019 ns | 0.0018 ns |           - |           - |           - |                   - |
              FromInt |  1.7998 ns | 0.0042 ns | 0.0037 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.7428 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
             FromUInt |  1.3705 ns | 0.0023 ns | 0.0021 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.8971 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
             FromLong |  1.8031 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.7227 ns | 0.0012 ns | 0.0011 ns |           - |           - |           - |                   - |
            FromULong |  1.4076 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.9739 ns | 0.0016 ns | 0.0012 ns |           - |           - |           - |                   - |
            FromFloat |  3.8138 ns | 0.0031 ns | 0.0029 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.7729 ns | 0.0014 ns | 0.0013 ns |           - |           - |           - |                   - |
           FromDouble |  3.8740 ns | 0.0039 ns | 0.0037 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.8516 ns | 0.0022 ns | 0.0021 ns |           - |           - |           - |                   - |
          FromDecimal | 13.8108 ns | 0.0083 ns | 0.0070 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.6043 ns | 0.0113 ns | 0.0105 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7060 ns | 0.0008 ns | 0.0007 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  2.8747 ns | 0.0015 ns | 0.0014 ns |           - |           - |           - |                   - |
           FromObject |  2.8273 ns | 0.0030 ns | 0.0028 ns |           - |           - |           - |                   - |
           FromString |  1.8805 ns | 0.0020 ns | 0.0019 ns |           - |           - |           - |                   - |
             FromEnum |  1.8507 ns | 0.0018 ns | 0.0016 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.7605 ns | 0.0033 ns | 0.0031 ns |           - |           - |           - |                   - |
