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
using FHR.Content.Items.Ammunition;
using FHR.Content.Projectiles;

namespace FHr.Content.Items.Weapon
{
    public class BloodCrossbow : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 55;
            Item.height = 22;

            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(0, 0, 56, 88);

            Item.damage = 14;
            Item.DamageType = DamageClass.Ranged;
            Item.crit = 1;
            Item.knockBack = 5;

            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.shootSpeed = 14f;
            Item.useAmmo = AmmoID.Arrow;
            Item.reuseDelay = 24;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 12;
            Item.useAnimation = 24;

            Item.noMelee = true;
            Item.autoReuse = true;
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if (type == ProjectileID.UnholyArrow)
            {
                type = ProjectileID.BloodArrow;
            }

            if (type == ModContent.ProjectileType<UnfaithfulArrowP>())
            {
                type = ProjectileID.BloodArrow;
            }
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<BloodyBar>(), 15)
                .AddIngredient(ItemID.Vertebrae, 6)
                .AddTile(TileID.DemonAltar)
                .Register();

            CreateRecipe()
                .AddIngredient(ModContent.ItemType<BloodyBar>(), 15)
                .AddIngredient(ItemID.WormTooth, 6)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
}