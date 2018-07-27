# CryptoCompare-Api [![Build status](https://ci.appveyor.com/api/projects/status/iaccxxc7mb6us3yl/branch/master?svg=true)](https://ci.appveyor.com/project/tosunthex/cryptocompare-api/branch/master) [![Codacy Badge](https://api.codacy.com/project/badge/Grade/e3355681d430459aa12e37221929d9e7)](https://www.codacy.com/app/tosunthex/CryptoCompare-Api?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=tosunthex/CryptoCompare-Api&amp;utm_campaign=Badge_Grade) [![NuGet](https://img.shields.io/nuget/v/CryptoCompareAsyncApi.svg)](https://www.nuget.org/packages/CryptoCompareAsyncApi/)
.Net and .Net Core async Crypto Compare client for newest Min-API



## Installation
This Crypto Compare api wrapper library is available on [NuGet](https://www.nuget.org/packages/CryptoCompareAsyncApi/)

## Basic Usage
````csharp
// Using ctor
 var client = new CryptoCompareClient();
 var response = await client..OtherClient.GetCoinList();
 

// Using Singleton 
var btcId = 1182;
var btc = await CryptoCompareClient.Instance.OtherClient.GetSocialStat(btcId);
````

Package manager
````
Install-Package CryptoCompareAsyncApi
````
.NET CLI
````
dotnet add package CryptoCompareAsyncApi
````
Paket CLI
````
paket add CryptoCompareAsyncApi
````

Target Frameworks and Dependencies
> .NETFramework 4.5
```
Microsoft.AspNet.WebApi.SelfHost (>= 5.2.2)
Newtonsoft.Json (>= 11.0.2)
```

>.NETFramework 4.6.1
```
Microsoft.AspNet.WebApi.SelfHost (>= 5.2.2)
Newtonsoft.Json (>= 11.0.2)
```

>.NETStandard 1.3
```
NETStandard.Library (>= 1.6.1)
Newtonsoft.Json (>= 11.0.2)
```

>.NETStandard 1.5
```
NETStandard.Library (>= 1.6.1)
Newtonsoft.Json (>= 11.0.2)
```

>.NETStandard 2.0
```
Newtonsoft.Json (>= 11.0.2)
```
