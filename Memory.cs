using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Modules.Memory.DynamicFunctions;

namespace CountryFlagIcons;

public static class Memory
{
    public static readonly MemoryFunctionVoid<CCSPlayerController, IntPtr, IntPtr, IntPtr> CCSPlayerController_InventoryUpdateThink = 
        new("55 48 89 E5 41 57 41 56 41 55 49 89 FD 41 54 53 48 81 EC ? ? ? ? E8 ? ? ? ? 4C 89 EF E8");
}
