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

namespace FHR.Content.Items.Weapon
{
    public class SkullBow : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 56;

            Item.rare = ItemRarityID.Orange;
            Item.value = Item.buyPrice(0, 1, 22, 60);

            Item.damage = 35;
            Item.DamageType = DamageClass.Ranged;
            Item.crit = 0; //оказываеться что дефолт значение не 3% а 4% крита 0-0
            Item.knockBack = 5;

            Item.shoot = ProjectileID.BookOfSkullsSkull;
            Item.shootSpeed = 7;
            Item.mana = 5;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 20;
            Item.useAnimation = 20;

            Item.noMelee = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.DemonBow)
                .AddIngredient(ItemID.Bone, 50)
                .AddTile(TileID.BoneWelder)
                .Register();
            
            CreateRecipe()
                .AddIngredient(ItemID.TendonBow)
                .AddIngredient(ItemID.Bone, 50)
                .AddTile(TileID.BoneWelder)
                .Register();
        }
    }
}