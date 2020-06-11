using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OneFourQoLChanges
{
    public class QoLGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            switch (item.type)
            {
                case ItemID.RedPaint:
                case ItemID.OrangePaint:
                case ItemID.YellowPaint:
                case ItemID.LimePaint:
                case ItemID.GreenPaint:
                case ItemID.TealPaint:
                case ItemID.CyanPaint:
                case ItemID.SkyBluePaint:
                case ItemID.BluePaint:
                case ItemID.PurplePaint:
                case ItemID.VioletPaint:
                case ItemID.PinkPaint:
                case ItemID.BlackPaint:
                case ItemID.GrayPaint:
                case ItemID.WhitePaint:
                case ItemID.BrownPaint:
                case ItemID.ShadowPaint:
                case ItemID.NegativePaint:
                case ItemID.DeepRedPaint:
                case ItemID.DeepOrangePaint:
                case ItemID.DeepYellowPaint:
                case ItemID.DeepLimePaint:
                case ItemID.DeepGreenPaint:
                case ItemID.DeepTealPaint:
                case ItemID.DeepCyanPaint:
                case ItemID.DeepSkyBluePaint:
                case ItemID.DeepBluePaint:
                case ItemID.DeepPurplePaint:
                case ItemID.DeepVioletPaint:
                case ItemID.DeepPinkPaint:
                    if (QoLModConfig.Instance.paintAmmoSlot)
                        item.ammo = ItemID.RedPaint;
                    else
                        item.ammo = AmmoID.None;
                    break;
                case ItemID.Actuator:
                    if (QoLModConfig.Instance.actuatorsAmmoSlot)
                        item.ammo = ItemID.Actuator;
                    else
                        item.ammo = AmmoID.None;
                    break;
                case ItemID.Ale:
                    if (QoLModConfig.Instance.aleAmmoSlot)
                    {
                        item.ammo = ItemID.Ale;
                        item.notAmmo = false;
                    }
                    else
                    {
                        item.ammo = AmmoID.None;
                        item.notAmmo = true;
                    }
                    break;
            }
        }
    }
}
