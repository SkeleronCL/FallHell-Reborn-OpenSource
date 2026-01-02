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

namespace FHR.Content.Items.Tools
{
    public class MoltenHammer : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 44;
            Item.height = 44;

            Item.rare = ItemRarityID.Orange;
            Item.value = Item.buyPrice(1);

            Item.damage = 15;
            Item.DamageType = DamageClass.Melee;
            Item.crit = -1;
            Item.knockBack = 5;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 27;
            Item.useAnimation = 27;

            Item.hammer = 70;
            Item.autoReuse = true;
            Item.attackSpeedOnlyAffectsWeaponAnimation = true;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(4)) {
				
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Torch);
			}
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Hellstone, 10)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}