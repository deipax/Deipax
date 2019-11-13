
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.4844 ns | 0.0152 ns | 0.0142 ns |  1.4872 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4847 ns | 0.0037 ns | 0.0035 ns |  1.4855 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.2736 ns | 0.0025 ns | 0.0024 ns |  1.2731 ns |  0.86 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  0.6986 ns | 0.0087 ns | 0.0073 ns |  0.7002 ns |  0.47 |    0.01 |     - |     - |     - |         - |
             ToBool |        net472 |  0.9500 ns | 0.0097 ns | 0.0076 ns |  0.9526 ns |  0.64 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.2813 ns | 0.0107 ns | 0.0095 ns |  4.2821 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.3948 ns | 0.0063 ns | 0.0056 ns |  4.3965 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.1759 ns | 0.0077 ns | 0.0068 ns |  4.1756 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.3762 ns | 0.0057 ns | 0.0048 ns |  4.3760 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.3805 ns | 0.0056 ns | 0.0052 ns |  4.3802 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.2003 ns | 0.0129 ns | 0.0120 ns |  1.2011 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.1426 ns | 0.0025 ns | 0.0022 ns |  1.1429 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.0765 ns | 0.0043 ns | 0.0040 ns |  1.0773 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  0.6444 ns | 0.0031 ns | 0.0029 ns |  0.6446 ns |  0.54 |    0.01 |     - |     - |     - |         - |
             ToChar |        net472 |  0.9438 ns | 0.0022 ns | 0.0021 ns |  0.9440 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0374 ns | 0.0242 ns | 0.0227 ns |  4.0316 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4449 ns | 0.0115 ns | 0.0096 ns |  4.4430 ns |  1.10 |    0.01 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.2278 ns | 0.0092 ns | 0.0086 ns |  4.2276 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.3782 ns | 0.0064 ns | 0.0060 ns |  4.3773 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.3795 ns | 0.0069 ns | 0.0064 ns |  4.3781 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4830 ns | 0.0214 ns | 0.0190 ns |  1.4824 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.4406 ns | 0.0042 ns | 0.0039 ns |  1.4396 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.2602 ns | 0.0095 ns | 0.0089 ns |  1.2619 ns |  0.85 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.8901 ns | 0.0019 ns | 0.0017 ns |  0.8897 ns |  0.60 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net472 |  1.1734 ns | 0.0028 ns | 0.0027 ns |  1.1742 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.4678 ns | 0.0073 ns | 0.0068 ns |  4.4689 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.3988 ns | 0.0102 ns | 0.0090 ns |  4.3983 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.2280 ns | 0.0059 ns | 0.0055 ns |  4.2259 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.6053 ns | 0.0103 ns | 0.0097 ns |  4.6046 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.6114 ns | 0.0055 ns | 0.0052 ns |  4.6115 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.9784 ns | 0.0654 ns | 0.0754 ns |  1.9802 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4828 ns | 0.0029 ns | 0.0024 ns |  1.4826 ns |  0.76 |    0.03 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.2689 ns | 0.0034 ns | 0.0032 ns |  1.2696 ns |  0.65 |    0.02 |     - |     - |     - |         - |
             ToByte |        net461 |  0.7033 ns | 0.0017 ns | 0.0016 ns |  0.7032 ns |  0.36 |    0.01 |     - |     - |     - |         - |
             ToByte |        net472 |  0.9534 ns | 0.0029 ns | 0.0027 ns |  0.9540 ns |  0.49 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.6160 ns | 0.0863 ns | 0.0721 ns |  4.5949 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.3991 ns | 0.0043 ns | 0.0038 ns |  4.3995 ns |  0.95 |    0.01 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.1676 ns | 0.0059 ns | 0.0052 ns |  4.1665 ns |  0.90 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.6062 ns | 0.0074 ns | 0.0069 ns |  4.6069 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.6130 ns | 0.0080 ns | 0.0075 ns |  4.6140 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.4723 ns | 0.0173 ns | 0.0144 ns |  1.4681 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.4380 ns | 0.0030 ns | 0.0028 ns |  1.4392 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.2428 ns | 0.0022 ns | 0.0021 ns |  1.2434 ns |  0.84 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 |  0.6736 ns | 0.0050 ns | 0.0044 ns |  0.6737 ns |  0.46 |    0.01 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9449 ns | 0.0031 ns | 0.0029 ns |  0.9440 ns |  0.64 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.5921 ns | 0.0529 ns | 0.0469 ns |  4.5834 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.3903 ns | 0.0049 ns | 0.0046 ns |  4.3912 ns |  0.96 |    0.01 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.2677 ns | 0.0034 ns | 0.0032 ns |  4.2676 ns |  0.93 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.6028 ns | 0.0060 ns | 0.0056 ns |  4.6035 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.6099 ns | 0.0065 ns | 0.0060 ns |  4.6117 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.6528 ns | 0.0227 ns | 0.0202 ns |  1.6468 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.6130 ns | 0.0088 ns | 0.0082 ns |  1.6145 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.3267 ns | 0.0030 ns | 0.0028 ns |  1.3265 ns |  0.80 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.6765 ns | 0.0030 ns | 0.0028 ns |  0.6769 ns |  0.41 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9263 ns | 0.0023 ns | 0.0019 ns |  0.9270 ns |  0.56 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.5997 ns | 0.0200 ns | 0.0187 ns |  4.5948 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4830 ns | 0.0259 ns | 0.0242 ns |  4.4818 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.2364 ns | 0.0048 ns | 0.0045 ns |  4.2368 ns |  0.92 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.6034 ns | 0.0043 ns | 0.0036 ns |  4.6045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.6374 ns | 0.0275 ns | 0.0257 ns |  4.6504 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.4908 ns | 0.0187 ns | 0.0174 ns |  1.4887 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.7205 ns | 0.0030 ns | 0.0028 ns |  1.7210 ns |  1.15 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.4943 ns | 0.0033 ns | 0.0028 ns |  1.4950 ns |  1.00 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  0.9127 ns | 0.0039 ns | 0.0037 ns |  0.9124 ns |  0.61 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  1.1733 ns | 0.0045 ns | 0.0038 ns |  1.1721 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.4991 ns | 0.0232 ns | 0.0206 ns |  4.4946 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.3955 ns | 0.0037 ns | 0.0034 ns |  4.3947 ns |  0.98 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.1635 ns | 0.0055 ns | 0.0052 ns |  4.1631 ns |  0.93 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.6028 ns | 0.0052 ns | 0.0049 ns |  4.6034 ns |  1.02 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.6083 ns | 0.0039 ns | 0.0037 ns |  4.6081 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.6450 ns | 0.0145 ns | 0.0136 ns |  1.6392 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.6088 ns | 0.0028 ns | 0.0026 ns |  1.6089 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.3418 ns | 0.0030 ns | 0.0028 ns |  1.3415 ns |  0.82 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.8900 ns | 0.0026 ns | 0.0023 ns |  0.8896 ns |  0.54 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  1.2049 ns | 0.0198 ns | 0.0186 ns |  1.1952 ns |  0.73 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.5667 ns | 0.0243 ns | 0.0227 ns |  4.5708 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4235 ns | 0.0087 ns | 0.0082 ns |  4.4194 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.2273 ns | 0.0083 ns | 0.0074 ns |  4.2244 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.6056 ns | 0.0074 ns | 0.0069 ns |  4.6076 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.6116 ns | 0.0065 ns | 0.0061 ns |  4.6098 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.4631 ns | 0.0143 ns | 0.0119 ns |  1.4588 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.5990 ns | 0.0027 ns | 0.0024 ns |  1.5987 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.4145 ns | 0.0029 ns | 0.0027 ns |  1.4147 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             ToLong |        net461 |  0.8821 ns | 0.0021 ns | 0.0019 ns |  0.8817 ns |  0.60 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  1.1788 ns | 0.0023 ns | 0.0018 ns |  1.1780 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.4063 ns | 0.0096 ns | 0.0085 ns |  2.4035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.0959 ns | 0.0047 ns | 0.0042 ns |  2.0971 ns |  0.87 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.8720 ns | 0.0051 ns | 0.0040 ns |  1.8715 ns |  0.78 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  1.9911 ns | 0.0028 ns | 0.0027 ns |  1.9905 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.0900 ns | 0.0043 ns | 0.0040 ns |  2.0910 ns |  0.87 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.6311 ns | 0.0082 ns | 0.0073 ns |  1.6281 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4398 ns | 0.0020 ns | 0.0019 ns |  1.4392 ns |  0.88 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4107 ns | 0.0027 ns | 0.0024 ns |  1.4107 ns |  0.86 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 |  0.6832 ns | 0.0017 ns | 0.0016 ns |  0.6827 ns |  0.42 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  0.9382 ns | 0.0026 ns | 0.0024 ns |  0.9388 ns |  0.58 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.0772 ns | 0.0665 ns | 0.0766 ns |  2.0564 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.2835 ns | 0.0054 ns | 0.0045 ns |  2.2837 ns |  1.11 |    0.03 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.9518 ns | 0.0025 ns | 0.0022 ns |  1.9518 ns |  0.94 |    0.03 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.0829 ns | 0.0032 ns | 0.0030 ns |  2.0824 ns |  1.00 |    0.04 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.0864 ns | 0.0025 ns | 0.0022 ns |  2.0871 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.6526 ns | 0.0295 ns | 0.0261 ns |  1.6452 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.6244 ns | 0.0041 ns | 0.0036 ns |  1.6243 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.2444 ns | 0.0024 ns | 0.0022 ns |  1.2448 ns |  0.75 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net461 |  0.9417 ns | 0.0033 ns | 0.0028 ns |  0.9412 ns |  0.57 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.1718 ns | 0.0026 ns | 0.0024 ns |  1.1717 ns |  0.71 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  1.1662 ns | 0.0189 ns | 0.0177 ns |  1.1638 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  1.1392 ns | 0.0045 ns | 0.0039 ns |  1.1389 ns |  0.98 |    0.02 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  1.1854 ns | 0.0038 ns | 0.0033 ns |  1.1848 ns |  1.02 |    0.02 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  0.9545 ns | 0.0028 ns | 0.0026 ns |  0.9545 ns |  0.82 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  1.1285 ns | 0.0071 ns | 0.0066 ns |  1.1298 ns |  0.97 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6405 ns | 0.0161 ns | 0.0143 ns |  1.6345 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.5970 ns | 0.0030 ns | 0.0027 ns |  1.5978 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.3826 ns | 0.0038 ns | 0.0032 ns |  1.3827 ns |  0.84 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.0619 ns | 0.0030 ns | 0.0028 ns |  1.0616 ns |  0.65 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.1951 ns | 0.0015 ns | 0.0014 ns |  1.1953 ns |  0.73 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.1712 ns | 0.0097 ns | 0.0091 ns |  2.1674 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.8145 ns | 0.0029 ns | 0.0027 ns |  1.8148 ns |  0.84 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.8718 ns | 0.0032 ns | 0.0029 ns |  1.8714 ns |  0.86 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.2184 ns | 0.0032 ns | 0.0030 ns |  2.2176 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.2409 ns | 0.0034 ns | 0.0031 ns |  2.2408 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.3927 ns | 0.0321 ns | 0.0300 ns |  2.3794 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.2830 ns | 0.0045 ns | 0.0038 ns |  2.2837 ns |  0.95 |    0.01 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.1839 ns | 0.0090 ns | 0.0085 ns |  2.1862 ns |  0.91 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.0025 ns | 0.0074 ns | 0.0069 ns |  6.0015 ns |  2.51 |    0.03 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.0083 ns | 0.0086 ns | 0.0080 ns |  6.0103 ns |  2.51 |    0.03 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.0421 ns | 0.0509 ns | 0.0476 ns | 10.0269 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.6377 ns | 0.0099 ns | 0.0093 ns | 10.6387 ns |  1.06 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.4057 ns | 0.0188 ns | 0.0175 ns |  2.3985 ns |  0.24 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.6207 ns | 0.0080 ns | 0.0067 ns | 10.6201 ns |  1.06 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.6399 ns | 0.0075 ns | 0.0070 ns | 10.6396 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3157 ns | 0.0202 ns | 0.0169 ns |  2.3074 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3211 ns | 0.0101 ns | 0.0094 ns |  2.3237 ns |  1.00 |    0.01 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.0776 ns | 0.0022 ns | 0.0019 ns |  2.0779 ns |  0.90 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.1276 ns | 0.0026 ns | 0.0023 ns |  1.1280 ns |  0.49 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.3454 ns | 0.0114 ns | 0.0107 ns |  1.3496 ns |  0.58 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.0135 ns | 0.0538 ns | 0.0503 ns |  7.9984 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.1052 ns | 0.0145 ns | 0.0136 ns |  8.1091 ns |  1.01 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.0997 ns | 0.0030 ns | 0.0028 ns |  2.1000 ns |  0.26 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.0595 ns | 0.0267 ns | 0.0236 ns |  8.0717 ns |  1.01 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.1785 ns | 0.0157 ns | 0.0147 ns |  8.1806 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4992 ns | 0.0273 ns | 0.0242 ns |  1.4962 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.4582 ns | 0.0032 ns | 0.0030 ns |  1.4589 ns |  0.97 |    0.02 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.6412 ns | 0.0051 ns | 0.0048 ns |  1.6416 ns |  1.09 |    0.02 |     - |     - |     - |         - |
           ToObject |        net461 |  1.7289 ns | 0.0102 ns | 0.0090 ns |  1.7286 ns |  1.15 |    0.02 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9809 ns | 0.0084 ns | 0.0079 ns |  0.9784 ns |  0.65 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.6573 ns | 0.0579 ns | 0.0513 ns |  1.6299 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.8284 ns | 0.0028 ns | 0.0025 ns |  1.8283 ns |  1.10 |    0.03 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.2292 ns | 0.0027 ns | 0.0025 ns |  1.2293 ns |  0.74 |    0.02 |     - |     - |     - |         - |
          To_String |        net461 |  1.1677 ns | 0.0037 ns | 0.0035 ns |  1.1696 ns |  0.71 |    0.02 |     - |     - |     - |         - |
          To_String |        net472 |  1.3864 ns | 0.0021 ns | 0.0020 ns |  1.3867 ns |  0.84 |    0.03 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.6460 ns | 0.0065 ns | 0.0057 ns |  1.6472 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.5980 ns | 0.0034 ns | 0.0032 ns |  1.5984 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.5617 ns | 0.0041 ns | 0.0038 ns |  1.5611 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.1656 ns | 0.0023 ns | 0.0021 ns |  1.1655 ns |  0.71 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.2116 ns | 0.0035 ns | 0.0033 ns |  1.2104 ns |  0.74 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.4788 ns | 0.0105 ns | 0.0098 ns |  4.4749 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.6268 ns | 0.0067 ns | 0.0059 ns |  4.6263 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.2261 ns | 0.0077 ns | 0.0060 ns |  4.2252 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.8360 ns | 0.0058 ns | 0.0054 ns |  4.8366 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.8352 ns | 0.0030 ns | 0.0027 ns |  4.8345 ns |  1.08 |    0.00 |     - |     - |     - |         - |
