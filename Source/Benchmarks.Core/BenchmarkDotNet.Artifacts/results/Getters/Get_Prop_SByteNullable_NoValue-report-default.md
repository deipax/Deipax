
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 1.807 ns | 0.0037 ns | 0.0033 ns |       0 B |
     ToBoolNullable | 4.473 ns | 0.0011 ns | 0.0009 ns |       0 B |
             ToChar | 1.808 ns | 0.0043 ns | 0.0038 ns |       0 B |
     ToCharNullable | 4.979 ns | 0.0004 ns | 0.0003 ns |       0 B |
            ToSByte | 2.316 ns | 0.0040 ns | 0.0036 ns |       0 B |
    ToSByteNullable | 1.278 ns | 0.0005 ns | 0.0004 ns |       0 B |
             ToByte | 2.062 ns | 0.0019 ns | 0.0017 ns |       0 B |
     ToByteNullable | 4.980 ns | 0.0004 ns | 0.0004 ns |       0 B |
            ToShort | 2.059 ns | 0.0025 ns | 0.0022 ns |       0 B |
    ToShortNullable | 4.732 ns | 0.0020 ns | 0.0019 ns |       0 B |
           ToUShort | 2.059 ns | 0.0007 ns | 0.0005 ns |       0 B |
   ToUShortNullable | 4.986 ns | 0.0122 ns | 0.0114 ns |       0 B |
              ToInt | 2.062 ns | 0.0018 ns | 0.0015 ns |       0 B |
      ToIntNullable | 4.472 ns | 0.0029 ns | 0.0027 ns |       0 B |
             ToUInt | 2.041 ns | 0.0007 ns | 0.0006 ns |       0 B |
     ToUIntNullable | 4.983 ns | 0.0042 ns | 0.0040 ns |       0 B |
             ToLong | 2.046 ns | 0.0082 ns | 0.0073 ns |       0 B |
     ToLongNullable | 3.576 ns | 0.0004 ns | 0.0003 ns |       0 B |
            ToULong | 2.045 ns | 0.0027 ns | 0.0025 ns |       0 B |
    ToULongNullable | 3.333 ns | 0.0034 ns | 0.0031 ns |       0 B |
            ToFloat | 2.402 ns | 0.0892 ns | 0.1250 ns |       0 B |
    ToFloatNullable | 4.489 ns | 0.0031 ns | 0.0029 ns |       0 B |
           ToDouble | 2.299 ns | 0.0011 ns | 0.0009 ns |       0 B |
   ToDoubleNullable | 3.582 ns | 0.0016 ns | 0.0011 ns |       0 B |
          ToDecimal | 3.578 ns | 0.0011 ns | 0.0009 ns |       0 B |
  ToDecimalNullable | 9.269 ns | 0.0054 ns | 0.0051 ns |       0 B |
         ToDateTime | 3.066 ns | 0.0030 ns | 0.0028 ns |       0 B |
 ToDateTimeNullable | 8.529 ns | 0.0045 ns | 0.0035 ns |       0 B |
           ToObject | 2.045 ns | 0.0026 ns | 0.0025 ns |       0 B |
          To_String | 2.052 ns | 0.0035 ns | 0.0031 ns |       0 B |
             ToEnum | 2.045 ns | 0.0024 ns | 0.0022 ns |       0 B |
     ToEnumNullable | 5.029 ns | 0.0026 ns | 0.0023 ns |       0 B |
