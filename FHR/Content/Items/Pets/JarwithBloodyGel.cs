using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Steamworks;
using FHR.Content.Items;
using FHR.Content.Items.Armor;
using FHR.Content.Items.Tools;
using FHR.Content.Items.Placemble;
using FHR.Content.Projectiles;
using FHR.Content.Projectiles.Pets;
using FHR.Content.Buffs;

namespace FHR.Content.Items.Pets
{
    public class JarwithBloodyGel : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 26;

            Item.rare = ItemRarityID.White;
            Item.value = Item.buyPrice(1);

            Item.shoot = ModContent.ProjectileType<BloodyGelP>();
            Item.buffType = ModContent.BuffType<BloodyGelBuff>();
        }

        public override bool? UseItem(Player player)
        {
            if (player.whoAmI == Main.myPlayer)
            {
                player.AddBuff(Item.buffType, 3600, true);
            }

            return true;
        }
    }
}