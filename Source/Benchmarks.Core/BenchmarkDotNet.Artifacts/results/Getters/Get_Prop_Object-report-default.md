
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev | Allocated |
------------------- |----------:|----------:|----------:|----------:|
             ToBool |  7.649 ns | 0.0184 ns | 0.0172 ns |       0 B |
     ToBoolNullable | 10.684 ns | 0.0238 ns | 0.0211 ns |       0 B |
             ToChar |  7.791 ns | 0.0153 ns | 0.0143 ns |       0 B |
     ToCharNullable | 11.161 ns | 0.0209 ns | 0.0196 ns |       0 B |
            ToSByte |  7.622 ns | 0.0185 ns | 0.0173 ns |       0 B |
    ToSByteNullable | 10.462 ns | 0.0297 ns | 0.0277 ns |       0 B |
             ToByte |  7.647 ns | 0.0274 ns | 0.0257 ns |       0 B |
     ToByteNullable | 12.591 ns | 0.0245 ns | 0.0229 ns |       0 B |
            ToShort |  7.695 ns | 0.0282 ns | 0.0264 ns |       0 B |
    ToShortNullable | 11.078 ns | 0.0437 ns | 0.0409 ns |       0 B |
           ToUShort |  7.774 ns | 0.0318 ns | 0.0298 ns |       0 B |
   ToUShortNullable | 11.078 ns | 0.0225 ns | 0.0210 ns |       0 B |
              ToInt |  8.193 ns | 0.0335 ns | 0.0313 ns |       0 B |
      ToIntNullable | 10.966 ns | 0.0301 ns | 0.0282 ns |       0 B |
             ToUInt |  7.630 ns | 0.0257 ns | 0.0228 ns |       0 B |
     ToUIntNullable | 10.762 ns | 0.0404 ns | 0.0378 ns |       0 B |
             ToLong |  8.077 ns | 0.0315 ns | 0.0294 ns |       0 B |
     ToLongNullable | 11.647 ns | 0.0325 ns | 0.0304 ns |       0 B |
            ToULong |  7.911 ns | 0.0227 ns | 0.0212 ns |       0 B |
    ToULongNullable | 12.074 ns | 0.0285 ns | 0.0267 ns |       0 B |
            ToFloat |  7.657 ns | 0.0497 ns | 0.0388 ns |       0 B |
    ToFloatNullable | 10.915 ns | 0.0225 ns | 0.0200 ns |       0 B |
           ToDouble |  7.821 ns | 0.0275 ns | 0.0257 ns |       0 B |
   ToDoubleNullable | 11.572 ns | 0.0427 ns | 0.0400 ns |       0 B |
          ToDecimal | 11.133 ns | 0.0333 ns | 0.0312 ns |       0 B |
  ToDecimalNullable | 11.580 ns | 0.0343 ns | 0.0304 ns |       0 B |
         ToDateTime |  8.918 ns | 0.0303 ns | 0.0284 ns |       0 B |
 ToDateTimeNullable | 12.064 ns | 0.0264 ns | 0.0247 ns |       0 B |
           ToObject |  1.799 ns | 0.0053 ns | 0.0050 ns |       0 B |
          To_String | 25.198 ns | 0.0325 ns | 0.0272 ns |       0 B |
             ToEnum | 29.867 ns | 0.1009 ns | 0.0894 ns |       0 B |
