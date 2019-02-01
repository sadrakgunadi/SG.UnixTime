# SG.UnixTime
##### Unix Time Converter 

> Convert Date Time to Unix Time Stamp and Vice Versa

This is first release for Unix Time Converter. This package will convert Date Time to Unix Time Stamp and Vice Versa.

###### Import Reference
> using SG.UnixTime;

### Convert DateTime to Unix Time Stamp
ex :
```csharp
DateTime currentDateTime = DateTime.Now;
Int32 epoch = 0;

epoch = UnixTime.ToEpoch(currentDateTime);
Console.WriteLine(epoch);
```

### Convert Unix Time Stamp to DateTime
ex :
```csharp
DateTime defaultTime = DateTime.Now;

defaultTime = UnixTime.ToDateTime(epoch);
Console.WriteLine(defaultTime);
```

