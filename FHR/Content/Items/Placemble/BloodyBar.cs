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
using FHR.Content.Tiles;

namespace FHR.Content.Items.Placemble
{
    public class BloodyBar : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 24;

            Item.rare = ItemRarityID.Blue;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.buyPrice(0, 0, 14, 5);

            Item.DefaultToPlaceableTile(ModContent.TileType<BloodyBarT>());
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<BloodyNugget>(), 18)
                .AddIngredient(ItemID.IronBar)
                .AddTile(TileID.Anvils)
                .Register();

            CreateRecipe()
               .AddIngredient(ModContent.ItemType<BloodyNugget>(), 18)
               .AddIngredient(ItemID.LeadBar)
               .AddTile(TileID.Anvils)
               .Register();
        }
    }
}