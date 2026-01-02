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

namespace FHR.Content.Items.Tools
{
    public class BoneRod : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 1;
            Item.height= 1;

            Item.rare = ItemRarityID.White;
            Item.value = Item.buyPrice(1);

            Item.shoot = ProjectileID.FishingBobberGlowingStar;
            Item.shootSpeed = 12f;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 8;
            Item.useAnimation = 8;

            Item.fishingPole = 1;
        }

        public override void HoldItem(Player player)
        {
            player.accFishingLine = true;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            int bobberAmount = Main.rand.Next(1, 2);
            float spreadAmount = 75f;

            for (int index = 0; index < bobberAmount; ++index) {
				Vector2 bobberSpeed = velocity + new Vector2(Main.rand.NextFloat(-spreadAmount, spreadAmount) * 0.05f, Main.rand.NextFloat(-spreadAmount, spreadAmount) * 0.05f);

				Projectile.NewProjectile(source, position, bobberSpeed, type, 0, 0f, player.whoAmI);
			}
			return false;
		}
    }
}