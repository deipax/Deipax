
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 10.718 ns | 0.0359 ns | 0.0318 ns |           - |           - |           - |                   - |
     FromBoolNullable | 15.832 ns | 0.0605 ns | 0.0505 ns |           - |           - |           - |                   - |
             FromChar | 10.490 ns | 0.0616 ns | 0.0576 ns |           - |           - |           - |                   - |
     FromCharNullable | 10.896 ns | 0.0647 ns | 0.0605 ns |           - |           - |           - |                   - |
            FromSByte | 10.477 ns | 0.0369 ns | 0.0345 ns |           - |           - |           - |                   - |
    FromSByteNullable | 23.326 ns | 0.1256 ns | 0.1175 ns |           - |           - |           - |                   - |
             FromByte | 10.721 ns | 0.0596 ns | 0.0558 ns |           - |           - |           - |                   - |
     FromByteNullable | 11.138 ns | 0.0707 ns | 0.0661 ns |           - |           - |           - |                   - |
            FromShort | 10.426 ns | 0.0486 ns | 0.0455 ns |           - |           - |           - |                   - |
    FromShortNullable | 10.901 ns | 0.0738 ns | 0.0690 ns |           - |           - |           - |                   - |
           FromUShort | 10.707 ns | 0.0609 ns | 0.0570 ns |           - |           - |           - |                   - |
   FromUShortNullable | 10.913 ns | 0.0575 ns | 0.0538 ns |           - |           - |           - |                   - |
              FromInt | 10.487 ns | 0.0588 ns | 0.0550 ns |           - |           - |           - |                   - |
      FromIntNullable | 11.149 ns | 0.0674 ns | 0.0631 ns |           - |           - |           - |                   - |
             FromUInt | 10.686 ns | 0.0597 ns | 0.0558 ns |           - |           - |           - |                   - |
     FromUIntNullable | 11.154 ns | 0.0502 ns | 0.0470 ns |           - |           - |           - |                   - |
             FromLong | 10.744 ns | 0.0617 ns | 0.0577 ns |           - |           - |           - |                   - |
     FromLongNullable | 11.991 ns | 0.0900 ns | 0.0842 ns |           - |           - |           - |                   - |
            FromULong | 10.543 ns | 0.0923 ns | 0.0863 ns |           - |           - |           - |                   - |
    FromULongNullable | 11.948 ns | 0.0339 ns | 0.0301 ns |           - |           - |           - |                   - |
            FromFloat | 21.929 ns | 0.1080 ns | 0.1010 ns |           - |           - |           - |                   - |
    FromFloatNullable | 27.845 ns | 0.1240 ns | 0.1160 ns |           - |           - |           - |                   - |
           FromDouble | 50.779 ns | 0.2111 ns | 0.1974 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 58.228 ns | 0.3892 ns | 0.3450 ns |           - |           - |           - |                   - |
          FromDecimal |  1.334 ns | 0.0099 ns | 0.0088 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  3.694 ns | 0.0176 ns | 0.0165 ns |           - |           - |           - |                   - |
         FromDateTime | 10.696 ns | 0.0513 ns | 0.0480 ns |           - |           - |           - |                   - |
 FromDateTimeNullable | 11.551 ns | 0.0435 ns | 0.0407 ns |           - |           - |           - |                   - |
           FromObject |  7.940 ns | 0.0381 ns | 0.0357 ns |           - |           - |           - |                   - |
           FromString | 74.481 ns | 0.4855 ns | 0.4541 ns |           - |           - |           - |                   - |
             FromEnum | 10.719 ns | 0.0646 ns | 0.0604 ns |           - |           - |           - |                   - |
     FromEnumNullable | 10.890 ns | 0.0499 ns | 0.0467 ns |           - |           - |           - |                   - |
