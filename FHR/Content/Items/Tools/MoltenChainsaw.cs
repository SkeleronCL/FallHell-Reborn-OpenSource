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
    public class MoltenChainsaw : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 60;
            Item.height = 26;

            Item.rare = ItemRarityID.Orange;
            Item.value = Item.buyPrice(1);

            Item.damage = 14;
            Item.DamageType = DamageClass.Melee;
            Item.crit = 2;
            Item.knockBack = 5;

            Item.shoot = ModContent.ProjectileType<MoltenChainsawP>();
            Item.shootSpeed = 35f;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 4;
            Item.useAnimation = 15;

            Item.noMelee = true;
            Item.noUseGraphic = true;
            Item.channel = true;

            Item.tileBoost = -1;
            Item.axe = 30;
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