namespace XIVLauncher.Common.Util;

public static class ServerAddress
{
    //The server address provided here is intended for distribution by OtterCorp only.
    //Any individuals not affiliated with this organization should modify the server address before distributing it.
    //Unauthorized server usage is prohibited.
    public const string S3Address = "https://s3.ffxiv.wang";
    public const string MainAddress = "https://aonyx.ffxiv.wang";

    // Soil 社区版静态分发 (Cloudflare R2)
    public const string SoilDalamudAddress = "https://dalamud-dis.atmoomen.top";
    public const string SoilDalamudVersionUrl = SoilDalamudAddress + "/RELEASE";
    public const string SoilDalamudAssetAddress = SoilDalamudAddress + "/assets";
    public const string SoilDalamudAssetVersionUrl = SoilDalamudAssetAddress + "/RELEASE";

    // Dalamud 运行时版本信息 (GitHub 反代加速)
    public const string SoilDalamudRuntimeInfoUrl = "https://gh.atmoomen.top/https://raw.githubusercontent.com/Dalamud-DailyRoutines/XLCNSoilAssets/master/runtimeInfo";
}
