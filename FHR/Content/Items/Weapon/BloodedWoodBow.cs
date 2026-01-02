using Terraria;
using Terraria.ID;
using Terraria.ObjectData;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Steamworks;
using FHR.Content.Items;
using FHR.Content.Items.Armor;
using FHR.Content.Items.Tools;
using FHR.Content.Items.Placemble;

namespace FHR.Content.Items.Weapon
{
    public class BloodedWoodBow : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 1;
            Item.height = 1;

            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(1);

            Item.damage = 1;
            Item.DamageType = DamageClass.Ranged;
            Item.crit = 1;
            Item.knockBack = 1;

            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.shootSpeed = 6f;
            
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 25;
            Item.useAnimation = 25;

            Item.noMelee = true;
        }
    }
}