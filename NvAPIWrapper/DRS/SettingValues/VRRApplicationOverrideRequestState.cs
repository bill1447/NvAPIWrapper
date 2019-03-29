namespace NvAPIWrapper.DRS.SettingValues
{
    public enum VRRApplicationOverrideRequestState : uint
    {
        Allow = 0x0,

        ForceOff = 0x1,

        DisAllow = 0x2,

        ULMB = 0x3,

        FixedRefresh = 0x4,

        Default = 0x0
    }
}