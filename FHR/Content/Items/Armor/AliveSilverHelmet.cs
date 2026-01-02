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

namespace FHR.Content.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class AliveSilverHelmet : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 20;

            Item.defense = 3;

            Item.rare = ItemRarityID.White;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.buyPrice(1);
        }

        // public override void AddRecipes()
        // {
        //     CreateRecipe()
        //         .AddIngredient(ModContent.ItemType<AliveSteelBar>(), 12)
        //         .AddIngredient(ItemID.TissueSample, 10)
        //         .AddIngredient(ItemID.SilverChainmail)
        //         .AddTile(TileID.Anvils)
        //         .Register();
        // }
    }
}