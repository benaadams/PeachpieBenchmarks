Peachpie Plaintext Benchmark
=================

# PHP running on ASP.NET Core on .NET Core 

Following on from the announcement by [Peachpie](https://github.com/iolevel/peachpie) of the milestone of 
[WordPress on .NET](http://www.peachpie.io/2017/02/wordpress-announcement.html); I was interesting in trying the 
[TechEmpower plaintext benchmark](https://www.techempower.com/benchmarks/#section=data-r13&hw=ph&test=plaintext) against it.

Results as follows (Azure D15 v2 Win <-> Azure D15 v2 Linux)

```
Pipeline depth: 16
Running 10s test @ http://...:5004/plaintext.php
  40 threads and 1024 connections
  Thread Stats   Avg      Stdev     Max   +/- Stdev
    Latency    49.94ms   76.02ms   1.29s    92.38%
    Req/Sec     7.69k     2.00k   17.05k    78.68%
  3086700 requests in 10.10s, 441.56MB read
  Socket errors: connect 19, read 0, write 0, timeout 45
Requests/sec: 305612.35
Transfer/sec:     43.72MB
```

Instructions
---

Install [.NET Core Sdk](https://www.microsoft.com/net/download/core#/lts)

Install dependencies
```
dotnet restore
```

Move into the server folder
```
cd server
```

Run in release mode
```
dotnet run -c Release
```

Connect to plaintext site at `http://localhost:5004/plaintext.php`
