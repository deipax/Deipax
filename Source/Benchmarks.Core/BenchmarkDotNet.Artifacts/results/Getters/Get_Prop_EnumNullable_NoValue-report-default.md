
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 4.027 ns | 0.0125 ns | 0.0117 ns |       0 B |
     ToBoolNullable | 6.800 ns | 0.0190 ns | 0.0178 ns |       0 B |
             ToChar | 3.931 ns | 0.0146 ns | 0.0136 ns |       0 B |
     ToCharNullable | 6.787 ns | 0.0087 ns | 0.0077 ns |       0 B |
            ToSByte | 4.495 ns | 0.0038 ns | 0.0034 ns |       0 B |
    ToSByteNullable | 6.792 ns | 0.0206 ns | 0.0192 ns |       0 B |
             ToByte | 4.638 ns | 0.0037 ns | 0.0031 ns |       0 B |
     ToByteNullable | 6.781 ns | 0.0149 ns | 0.0139 ns |       0 B |
            ToShort | 4.077 ns | 0.0175 ns | 0.0155 ns |       0 B |
    ToShortNullable | 6.803 ns | 0.0135 ns | 0.0127 ns |       0 B |
           ToUShort | 3.820 ns | 0.0182 ns | 0.0171 ns |       0 B |
   ToUShortNullable | 6.796 ns | 0.0115 ns | 0.0107 ns |       0 B |
              ToInt | 3.871 ns | 0.0430 ns | 0.0402 ns |       0 B |
      ToIntNullable | 6.807 ns | 0.0092 ns | 0.0077 ns |       0 B |
             ToUInt | 4.385 ns | 0.0131 ns | 0.0123 ns |       0 B |
     ToUIntNullable | 7.285 ns | 0.0163 ns | 0.0153 ns |       0 B |
             ToLong | 3.882 ns | 0.0123 ns | 0.0103 ns |       0 B |
     ToLongNullable | 7.194 ns | 0.0139 ns | 0.0130 ns |       0 B |
            ToULong | 4.424 ns | 0.0143 ns | 0.0134 ns |       0 B |
    ToULongNullable | 6.911 ns | 0.0102 ns | 0.0096 ns |       0 B |
            ToFloat | 3.836 ns | 0.0069 ns | 0.0061 ns |       0 B |
    ToFloatNullable | 6.797 ns | 0.0188 ns | 0.0175 ns |       0 B |
           ToDouble | 4.635 ns | 0.0122 ns | 0.0114 ns |       0 B |
   ToDoubleNullable | 6.953 ns | 0.0324 ns | 0.0288 ns |       0 B |
          ToDecimal | 6.443 ns | 0.0187 ns | 0.0175 ns |       0 B |
  ToDecimalNullable | 7.179 ns | 0.0219 ns | 0.0205 ns |       0 B |
         ToDateTime | 5.141 ns | 0.0153 ns | 0.0143 ns |       0 B |
 ToDateTimeNullable | 6.917 ns | 0.0230 ns | 0.0215 ns |       0 B |
           ToObject | 2.564 ns | 0.0103 ns | 0.0096 ns |       0 B |
          To_String | 4.914 ns | 0.0126 ns | 0.0118 ns |       0 B |
             ToEnum | 3.070 ns | 0.0061 ns | 0.0054 ns |       0 B |
