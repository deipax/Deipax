
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.1679 ns | 0.0045 ns | 0.0040 ns |  1.1687 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1986 ns | 0.0090 ns | 0.0084 ns |  1.1959 ns |  1.03 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  0.9489 ns | 0.0026 ns | 0.0024 ns |  0.9484 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  0.7218 ns | 0.0027 ns | 0.0024 ns |  0.7218 ns |  0.62 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  0.4366 ns | 0.0056 ns | 0.0053 ns |  0.4388 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9460 ns | 0.0061 ns | 0.0057 ns |  3.9446 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1846 ns | 0.0053 ns | 0.0050 ns |  4.1843 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  3.9693 ns | 0.0039 ns | 0.0035 ns |  3.9683 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1543 ns | 0.0047 ns | 0.0039 ns |  4.1535 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1881 ns | 0.0098 ns | 0.0087 ns |  4.1869 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.7615 ns | 0.0017 ns | 0.0015 ns |  1.7617 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.6887 ns | 0.0146 ns | 0.0137 ns |  1.6817 ns |  0.96 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.1606 ns | 0.0053 ns | 0.0047 ns |  1.1616 ns |  0.66 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  1.8906 ns | 0.0156 ns | 0.0146 ns |  1.8827 ns |  1.07 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |  1.5828 ns | 0.0033 ns | 0.0031 ns |  1.5823 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  3.9754 ns | 0.0409 ns | 0.0382 ns |  3.9502 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1896 ns | 0.0066 ns | 0.0061 ns |  4.1920 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  3.9725 ns | 0.0034 ns | 0.0027 ns |  3.9722 ns |  1.00 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.6196 ns | 0.0087 ns | 0.0073 ns |  4.6165 ns |  1.16 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.6072 ns | 0.0071 ns | 0.0060 ns |  4.6057 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4627 ns | 0.0061 ns | 0.0057 ns |  1.4620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6476 ns | 0.0024 ns | 0.0023 ns |  1.6469 ns |  1.13 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  0.9765 ns | 0.0056 ns | 0.0052 ns |  0.9766 ns |  0.67 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.6283 ns | 0.0030 ns | 0.0025 ns |  1.6284 ns |  1.11 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.3561 ns | 0.0043 ns | 0.0035 ns |  1.3552 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  3.9510 ns | 0.0073 ns | 0.0068 ns |  3.9526 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.2032 ns | 0.0083 ns | 0.0070 ns |  4.2040 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  3.9729 ns | 0.0082 ns | 0.0073 ns |  3.9721 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.8844 ns | 0.0275 ns | 0.0257 ns |  4.8923 ns |  1.24 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.8421 ns | 0.0080 ns | 0.0066 ns |  4.8439 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.7603 ns | 0.0023 ns | 0.0022 ns |  1.7606 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.6607 ns | 0.0196 ns | 0.0183 ns |  1.6494 ns |  0.94 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  0.9584 ns | 0.0037 ns | 0.0029 ns |  0.9575 ns |  0.54 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  1.6790 ns | 0.0157 ns | 0.0147 ns |  1.6702 ns |  0.95 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  1.3564 ns | 0.0074 ns | 0.0069 ns |  1.3561 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  3.9416 ns | 0.0058 ns | 0.0054 ns |  3.9411 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.1920 ns | 0.0083 ns | 0.0074 ns |  4.1917 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  3.9801 ns | 0.0112 ns | 0.0094 ns |  3.9787 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.6194 ns | 0.0087 ns | 0.0081 ns |  4.6185 ns |  1.17 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.6611 ns | 0.0199 ns | 0.0186 ns |  4.6664 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.3427 ns | 0.0035 ns | 0.0033 ns |  2.3429 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.7120 ns | 0.0132 ns | 0.0123 ns |  2.7138 ns |  1.16 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  2.2500 ns | 0.0037 ns | 0.0035 ns |  2.2502 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  1.6328 ns | 0.0016 ns | 0.0015 ns |  1.6327 ns |  0.70 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.3557 ns | 0.0025 ns | 0.0023 ns |  1.3561 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.6411 ns | 0.0094 ns | 0.0083 ns |  4.6406 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.9160 ns | 0.0249 ns | 0.0232 ns |  4.9245 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.4343 ns | 0.0063 ns | 0.0059 ns |  4.4332 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.8829 ns | 0.0333 ns | 0.0311 ns |  4.8976 ns |  1.05 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.8592 ns | 0.0343 ns | 0.0321 ns |  4.8406 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.7619 ns | 0.0025 ns | 0.0023 ns |  1.7621 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.5000 ns | 0.0023 ns | 0.0021 ns |  1.5002 ns |  0.85 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  0.9627 ns | 0.0110 ns | 0.0103 ns |  0.9677 ns |  0.55 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.8796 ns | 0.0043 ns | 0.0038 ns |  1.8791 ns |  1.07 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.5843 ns | 0.0044 ns | 0.0039 ns |  1.5847 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.0025 ns | 0.0055 ns | 0.0049 ns |  4.0037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.2079 ns | 0.0312 ns | 0.0292 ns |  4.1930 ns |  1.05 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  3.9852 ns | 0.0073 ns | 0.0064 ns |  3.9829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.6509 ns | 0.0325 ns | 0.0304 ns |  4.6649 ns |  1.16 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.6189 ns | 0.0158 ns | 0.0148 ns |  4.6145 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.4586 ns | 0.0045 ns | 0.0043 ns |  1.4581 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.4789 ns | 0.0025 ns | 0.0024 ns |  1.4787 ns |  1.01 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  0.9595 ns | 0.0030 ns | 0.0028 ns |  0.9591 ns |  0.66 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  1.6299 ns | 0.0040 ns | 0.0036 ns |  1.6310 ns |  1.12 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  1.3559 ns | 0.0036 ns | 0.0032 ns |  1.3557 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  3.9512 ns | 0.0079 ns | 0.0074 ns |  3.9486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1870 ns | 0.0072 ns | 0.0064 ns |  4.1851 ns |  1.06 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  3.7526 ns | 0.0067 ns | 0.0062 ns |  3.7541 ns |  0.95 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.6145 ns | 0.0057 ns | 0.0048 ns |  4.6125 ns |  1.17 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.6575 ns | 0.0212 ns | 0.0198 ns |  4.6643 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.0852 ns | 0.0036 ns | 0.0032 ns |  1.0851 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.1905 ns | 0.0021 ns | 0.0018 ns |  1.1899 ns |  1.10 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  0.9270 ns | 0.0028 ns | 0.0026 ns |  0.9261 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  0.7526 ns | 0.0035 ns | 0.0033 ns |  0.7525 ns |  0.69 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  0.4323 ns | 0.0011 ns | 0.0009 ns |  0.4324 ns |  0.40 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  3.9489 ns | 0.0047 ns | 0.0042 ns |  3.9478 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4161 ns | 0.0092 ns | 0.0077 ns |  4.4164 ns |  1.12 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.2446 ns | 0.0164 ns | 0.0153 ns |  4.2495 ns |  1.08 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.1830 ns | 0.0318 ns | 0.0298 ns |  4.1956 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.1911 ns | 0.0061 ns | 0.0057 ns |  4.1903 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.0889 ns | 0.0097 ns | 0.0090 ns |  1.0846 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.2457 ns | 0.0035 ns | 0.0033 ns |  1.2454 ns |  1.14 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  0.9535 ns | 0.0032 ns | 0.0030 ns |  0.9534 ns |  0.88 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  0.7218 ns | 0.0034 ns | 0.0029 ns |  0.7222 ns |  0.66 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  0.4271 ns | 0.0014 ns | 0.0013 ns |  0.4271 ns |  0.39 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.5931 ns | 0.0111 ns | 0.0098 ns |  1.5958 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.7035 ns | 0.0029 ns | 0.0025 ns |  1.7035 ns |  1.07 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.4827 ns | 0.0033 ns | 0.0029 ns |  1.4830 ns |  0.93 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.5759 ns | 0.0038 ns | 0.0033 ns |  1.5758 ns |  0.99 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.5406 ns | 0.0034 ns | 0.0032 ns |  1.5397 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.1014 ns | 0.0033 ns | 0.0030 ns |  1.1016 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.2181 ns | 0.0070 ns | 0.0065 ns |  1.2179 ns |  1.11 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  0.9272 ns | 0.0025 ns | 0.0023 ns |  0.9268 ns |  0.84 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  0.7211 ns | 0.0021 ns | 0.0019 ns |  0.7208 ns |  0.65 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  0.4269 ns | 0.0026 ns | 0.0022 ns |  0.4270 ns |  0.39 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.5677 ns | 0.0257 ns | 0.0241 ns |  1.5564 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.7423 ns | 0.0133 ns | 0.0117 ns |  1.7465 ns |  1.11 |    0.02 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.5032 ns | 0.0028 ns | 0.0023 ns |  1.5040 ns |  0.96 |    0.02 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  1.8092 ns | 0.0027 ns | 0.0024 ns |  1.8101 ns |  1.15 |    0.02 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  1.5821 ns | 0.0084 ns | 0.0070 ns |  1.5808 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.3320 ns | 0.0032 ns | 0.0029 ns |  1.3319 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.3727 ns | 0.0040 ns | 0.0037 ns |  1.3708 ns |  1.03 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.2166 ns | 0.0080 ns | 0.0075 ns |  1.2195 ns |  0.91 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.9444 ns | 0.0030 ns | 0.0028 ns |  0.9444 ns |  0.71 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.6540 ns | 0.0032 ns | 0.0028 ns |  0.6542 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.6466 ns | 0.0172 ns | 0.0161 ns |  4.6412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.8795 ns | 0.0057 ns | 0.0053 ns |  4.8797 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2096 ns | 0.0078 ns | 0.0073 ns |  4.2089 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.8561 ns | 0.0039 ns | 0.0030 ns |  4.8558 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.8429 ns | 0.0082 ns | 0.0073 ns |  4.8442 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.3137 ns | 0.0037 ns | 0.0034 ns |  1.3145 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.2217 ns | 0.0036 ns | 0.0032 ns |  1.2211 ns |  0.93 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.1779 ns | 0.0040 ns | 0.0037 ns |  1.1786 ns |  0.90 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.7479 ns | 0.0023 ns | 0.0021 ns |  0.7475 ns |  0.57 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.4258 ns | 0.0022 ns | 0.0021 ns |  0.4256 ns |  0.32 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.7728 ns | 0.0026 ns | 0.0020 ns |  1.7724 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.7443 ns | 0.0037 ns | 0.0033 ns |  1.7446 ns |  0.98 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.7393 ns | 0.0130 ns | 0.0122 ns |  1.7324 ns |  0.98 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.5603 ns | 0.0030 ns | 0.0027 ns |  1.5593 ns |  0.88 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.4455 ns | 0.0038 ns | 0.0029 ns |  1.4449 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  5.7764 ns | 0.0091 ns | 0.0085 ns |  5.7750 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0579 ns | 0.0139 ns | 0.0130 ns |  6.0526 ns |  1.05 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.8227 ns | 0.0072 ns | 0.0067 ns |  5.8223 ns |  1.01 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.8469 ns | 0.0457 ns | 0.0427 ns |  5.8420 ns |  1.01 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.8330 ns | 0.0063 ns | 0.0053 ns |  5.8323 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.6623 ns | 0.0392 ns | 0.0367 ns | 18.6714 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.5023 ns | 0.0196 ns | 0.0163 ns | 18.4980 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.6142 ns | 0.1187 ns | 0.1111 ns | 12.5473 ns |  0.68 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.4583 ns | 0.0267 ns | 0.0250 ns | 18.4535 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.0033 ns | 0.0281 ns | 0.0263 ns | 18.0004 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2575 ns | 0.0039 ns | 0.0035 ns |  2.2569 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3600 ns | 0.0050 ns | 0.0047 ns |  2.3614 ns |  1.05 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3856 ns | 0.0052 ns | 0.0049 ns |  2.3881 ns |  1.06 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1329 ns | 0.0037 ns | 0.0035 ns |  1.1325 ns |  0.50 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  0.9733 ns | 0.0068 ns | 0.0060 ns |  0.9718 ns |  0.43 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9361 ns | 0.0484 ns | 0.0452 ns |  7.9667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  7.9699 ns | 0.0311 ns | 0.0260 ns |  7.9645 ns |  1.00 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9001 ns | 0.0035 ns | 0.0033 ns |  1.9004 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.1813 ns | 0.0110 ns | 0.0092 ns |  8.1808 ns |  1.03 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.0263 ns | 0.0072 ns | 0.0067 ns |  8.0269 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.3100 ns | 0.0069 ns | 0.0057 ns |  3.3098 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.9170 ns | 0.0299 ns | 0.0279 ns |  3.9317 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.7128 ns | 0.0379 ns | 0.0296 ns |  3.7249 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.7421 ns | 0.0120 ns | 0.0113 ns |  2.7404 ns |  0.83 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.6455 ns | 0.0262 ns | 0.0233 ns |  2.6363 ns |  0.80 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 26.7596 ns | 0.0597 ns | 0.0529 ns | 26.7586 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 16.9110 ns | 0.0438 ns | 0.0366 ns | 16.9123 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.0465 ns | 0.0187 ns | 0.0165 ns | 12.0470 ns |  0.45 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 28.6671 ns | 0.0673 ns | 0.0597 ns | 28.6546 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 29.4355 ns | 0.0529 ns | 0.0494 ns | 29.4414 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 10.0802 ns | 0.0191 ns | 0.0179 ns | 10.0726 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.2205 ns | 0.0124 ns | 0.0097 ns | 10.2203 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  7.9834 ns | 0.0116 ns | 0.0090 ns |  7.9852 ns |  0.79 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.7210 ns | 0.0220 ns | 0.0195 ns | 12.7201 ns |  1.26 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.6285 ns | 0.0346 ns | 0.0306 ns | 12.6181 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 14.1786 ns | 0.0211 ns | 0.0187 ns | 14.1776 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 15.1273 ns | 0.0152 ns | 0.0142 ns | 15.1259 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.3973 ns | 0.0131 ns | 0.0122 ns | 12.3955 ns |  0.87 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 17.3957 ns | 0.0233 ns | 0.0206 ns | 17.3899 ns |  1.23 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 17.5005 ns | 0.0633 ns | 0.0593 ns | 17.5168 ns |  1.23 |    0.01 |      - |     - |     - |         - |
