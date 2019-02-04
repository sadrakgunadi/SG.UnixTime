# SG.UnixTime
##### Unix Time Converter 

> Convert Date Time to Unix Time Stamp and Vice Versa (seconds or milliseconds format)

![](https://img.shields.io/github/repo-size/sadrakgunadi/SG.UnixTime.svg?style=flat)
![](https://img.shields.io/github/languages/code-size/sadrakgunadi/SG.UnixTime.svg?style=flat)
![](https://img.shields.io/github/languages/count/sadrakgunadi/SG.UnixTime.svg?style=flat)
![](https://img.shields.io/github/downloads/sadrakgunadi/SG.UnixTime/total.svg?style=flat)

**This package will :**
- Convert Date Time to Unix Time Stamp and Vice Versa.
- Convert from or to seconds/milliseconds format with inferred type.

###### Import Reference
> using SG.UnixTime;

### Convert DateTime to Unix Time Stamp
example 1 :
```csharp
DateTime currentDateTime = DateTime.Now;
Int32 epoch = 0;

epoch = UnixTime.ToEpoch(currentDateTime);
Console.WriteLine(epoch);
```
example 2 (to seconds with inferred type) :
```csharp
DateTime currentDateTime = DateTime.Now;
Int32 epoch = 0;

epoch = UnixTime.ToEpoch <Int32>(currentDateTime, ConvertFormat.ToSeconds);
Console.WriteLine(epoch);
```
example 3 (to milliseconds with inferred type) :
```csharp
DateTime currentDateTime = DateTime.Now;
long epoch = 0;

epoch = UnixTime.ToEpoch <long>(currentDateTime, ConvertFormat.ToMilliseconds);
Console.WriteLine(epoch);
```

### Convert Unix Time Stamp to DateTime
example 1 :
```csharp
DateTime defaultTime = DateTime.Now;

defaultTime = UnixTime.ToDateTime(epoch);
Console.WriteLine(defaultTime);
```

example 2 :
```csharp
 DateTime defaultTime = DateTime.Now;

defaultTime = UnixTime.ToDateTime <Int32> (epoch, ConvertFormat.ToSeconds);
Console.WriteLine(defaultTime);
```
example 3 :
```csharp
DateTime defaultTime = DateTime.Now;

defaultTime = UnixTime.ToDateTime <long>(epoch, ConvertFormat.ToMilliseconds);
Console.WriteLine(defaultTime);
```

