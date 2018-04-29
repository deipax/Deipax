
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |     Mean |     Error |    StdDev | Allocated |
------------------- |---------:|----------:|----------:|----------:|
             ToBool | 5.700 ns | 0.0024 ns | 0.0018 ns |       0 B |
     ToBoolNullable | 7.573 ns | 0.0414 ns | 0.0367 ns |       0 B |
             ToChar | 5.837 ns | 0.0033 ns | 0.0026 ns |       0 B |
     ToCharNullable | 8.025 ns | 0.0119 ns | 0.0106 ns |       0 B |
            ToSByte | 5.708 ns | 0.0189 ns | 0.0177 ns |       0 B |
    ToSByteNullable | 7.556 ns | 0.0205 ns | 0.0191 ns |       0 B |
             ToByte | 5.742 ns | 0.0127 ns | 0.0119 ns |       0 B |
     ToByteNullable | 7.537 ns | 0.0037 ns | 0.0035 ns |       0 B |
            ToShort | 5.710 ns | 0.0268 ns | 0.0238 ns |       0 B |
    ToShortNullable | 7.559 ns | 0.0133 ns | 0.0104 ns |       0 B |
           ToUShort | 5.684 ns | 0.0190 ns | 0.0177 ns |       0 B |
   ToUShortNullable | 7.567 ns | 0.0312 ns | 0.0292 ns |       0 B |
              ToInt | 6.339 ns | 0.0195 ns | 0.0183 ns |       0 B |
      ToIntNullable | 7.557 ns | 0.0170 ns | 0.0159 ns |       0 B |
             ToUInt | 5.754 ns | 0.0210 ns | 0.0197 ns |       0 B |
     ToUIntNullable | 7.801 ns | 0.0911 ns | 0.0852 ns |       0 B |
             ToLong | 6.306 ns | 0.0224 ns | 0.0209 ns |       0 B |
     ToLongNullable | 8.048 ns | 0.0310 ns | 0.0242 ns |       0 B |
            ToULong | 5.647 ns | 0.0153 ns | 0.0144 ns |       0 B |
    ToULongNullable | 7.937 ns | 0.0203 ns | 0.0190 ns |       0 B |
            ToFloat | 5.842 ns | 0.0167 ns | 0.0148 ns |       0 B |
    ToFloatNullable | 7.587 ns | 0.0262 ns | 0.0245 ns |       0 B |
           ToDouble | 5.828 ns | 0.0125 ns | 0.0111 ns |       0 B |
   ToDoubleNullable | 9.592 ns | 0.0226 ns | 0.0211 ns |       0 B |
          ToDecimal | 8.219 ns | 0.0409 ns | 0.0383 ns |       0 B |
  ToDecimalNullable | 8.321 ns | 0.0355 ns | 0.0332 ns |       0 B |
         ToDateTime | 6.779 ns | 0.0241 ns | 0.0225 ns |       0 B |
 ToDateTimeNullable | 7.747 ns | 0.0435 ns | 0.0385 ns |       0 B |
           ToObject | 1.795 ns | 0.0058 ns | 0.0055 ns |       0 B |
          To_String | 5.662 ns | 0.0161 ns | 0.0150 ns |       0 B |
             ToEnum | 7.510 ns | 0.0141 ns | 0.0125 ns |       0 B |
