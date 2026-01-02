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
    public class MoltenCrowbar : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 32;

            Item.rare = ItemRarityID.Orange;
            Item.value = Item.buyPrice(1);

            Item.damage = 100000000;
            Item.DamageType = DamageClass.Melee;
            Item.crit = 1;
            Item.knockBack = 1;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 14;
            Item.useAnimation = 14;
        }

        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.OnFire, 120);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<MoltenBar>(), 20)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}