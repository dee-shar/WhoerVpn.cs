# WhoerVpn.cs
Web-API for [whoer.net](https://whoer.net/vpn) which is an application/extension that will hide your real IP, protect your data when working through public wi-fi points

## Example
```cs
using WhoerVpnApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new WhoerVpn();
            api.LoginByCode("accountCode");
            string proxies = await api.GetProxies();
            Console.WriteLine(proxies);
        }
    }
}
```
