using EnkaDotNet.Caching;
using EnkaDotNet.Enums;
using Xunit;
using Xunit.Abstractions;

namespace EnkaDotNet.Tests.Genshin;

public class ProfilePicTest(ITestOutputHelper testOutputHelper)
{
    [Fact]
    public async Task TestProfilePcitureThing()
    {
        var options = new EnkaClientOptions
        {
            EnableCaching = true,
            CacheDurationMinutes = 10,
            PreloadedLanguages = [Language.English],
            CacheProvider = CacheProvider.SQLite,
        };

        var enkaClient = await EnkaClient.CreateAsync(options);
        await enkaClient.PreloadAssetsAsync([Language.English]);

        var info = await enkaClient.GetGenshinPlayerInfoAsync(784677402, Language.English);
        testOutputHelper.WriteLine($"aaa: {info.IconUrl}");
        Console.WriteLine($"aaa: {info.IconUrl}");
    }
}