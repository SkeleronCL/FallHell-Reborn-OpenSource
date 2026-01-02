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
    public class MoltenDrill : ModItem
    {
        public override void SetStaticDefaults() {
			// As mentioned in the documentation, IsDrill and IsChainsaw automatically reduce useTime and useAnimation to 60% of what is set in SetDefaults and decrease tileBoost by 1, but only for vanilla items.
			// We set it here despite it doing nothing because it is likely to be used by other mods to provide special effects to drill or chainsaw items globally.
			ItemID.Sets.IsDrill[Type] = true;
		}
        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 26;

            Item.rare = ItemRarityID.Orange;
            Item.value = Item.buyPrice(1);

            Item.damage = 14;
            Item.DamageType = DamageClass.MeleeNoSpeed;
            Item.crit = 2;
            Item.knockBack = 5;

            Item.shoot = ModContent.ProjectileType<MoltenDrillP>();
            Item.shootSpeed = 35f;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 4;
            Item.useAnimation = 15;

            Item.noMelee = true;
            Item.noUseGraphic = true;
            Item.channel = true;

            Item.tileBoost = -1;
            Item.pick = 101;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Obsidian, 10)
                .AddIngredient(ModContent.ItemType<MoltenBar>(), 20)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}