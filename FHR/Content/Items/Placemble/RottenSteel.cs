using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Steamworks;

namespace FHR.Content.Items.Placemble
{
    public class RottenSteelBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(10, 7));
        }
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 24;

            Item.rare = ItemRarityID.Blue;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.buyPrice(0, 0, 14, 5);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SilverBar)
                .AddIngredient(ItemID.RottenChunk, 6)
                .AddIngredient(ModContent.ItemType<BloodSoul>(), 4)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}