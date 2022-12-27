## Console/Src_Culture/
Set C# 5.0 culture with DefaultThreadCurrentCulture/DefaultThreadCurrentUICulture.

Assuming that the [web application sets the application level culture](https://learn.microsoft.com/ja-jp/troubleshoot/developer/webapps/aspnet/development/set-current-culture) in web.config.
I investigated why it is good to set the culture except for web applications.

The bottom line is, just set DefaultThreadCurrentCulture and DefaultThreadCurrentUICulture.

[Source code explanation page](https://blog.unikktle.com/c-5-0-%e3%82%ab%e3%83%ab%e3%83%81%e3%83%a3%e3%83%bc%e8%a8%ad%e5%ae%9a%e3%81%af-defaultthreadcurrent-%e3%81%a7%e8%a1%8c%e3%81%86/)

---

## Console/Src_DeepCopy/
Recommendation v2 when copying List by value (DeepCopy) in C#.

If you search the net for a method of duplicating (value copy/DeepCopy) the List of your own class in C#, you will find methods such as ToList () and new, but it is safe to create a DeepCopy () method. .

[An example of DeepCopy using MemberwiseClone()](https://learn.microsoft.com/ja-jp/dotnet/api/system.object.memberwiseclone?view=net-5.0) says,
There is a problem that the source code becomes complicated by having a processing method in the data class, but with the DeepCopy() method as an extension method, there is no need to add processing to the data class, which simplifies the source code.

[Source code explanation page](https://blog.unikktle.com/c%e3%81%a7list%e3%82%92%e5%80%a4%e3%82%b3%e3%83%94%e3%83%bcdeepcopy%e3%81%99%e3%82%8b%e9%9a%9b%e3%81%ae%e3%81%8a%e5%8b%a7%e3%82%81-v2/)

---

## Console/Src_OS_Expression/

Use IsOSPlatform to determine the OS of the execution environment in C#.

When running a .Net Core application, if you want to divide the processing for each OS, use RuntimeInformation.IsOSPlatform() to determine the OS and divide the processing.

[Source code explanation page](https://blog.unikktle.com/c%e3%81%a7%e5%ae%9f%e8%a1%8c%e7%92%b0%e5%a2%83%e3%81%aeos%e3%82%92%e5%88%a4%e5%ae%9a%e3%81%99%e3%82%8b%e5%a0%b4%e5%90%88%e3%81%af-isosplatform-%e3%82%92%e4%bd%bf%e3%81%86/)

---

