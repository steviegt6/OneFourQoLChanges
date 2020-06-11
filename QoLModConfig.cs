using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace OneFourQoLChanges
{
    [Label("1.4 QoL Mod Config")]
    public class QoLModConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        public static QoLModConfig Instance;

        [Header("Ammo Slot Changes")]
        [Label("Allow Paint to be Stored in Ammo Slots")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool paintAmmoSlot;

        [Label("Allow Actuators to be Stored in Ammo Slots")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool actuatorsAmmoSlot;

        [Label("Allow Ale to be Stored in Ammo Slots")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool aleAmmoSlot;
    }
}
