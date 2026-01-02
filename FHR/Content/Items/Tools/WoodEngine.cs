// using Terraria;
// using Terraria.ID;
// using Terraria.ModLoader;
// using Terraria.DataStructures;
// using Microsoft.Xna.Framework;
// using Terraria.GameContent;
// using System.Reflection.Metadata;

// namespace FHR.Content.Items.Tools
// {
//     public class WoodEngineItem : ModItem
//     {
//         public override void SetDefaults()
//         {
//             Item.width = 1;
//             Item.height = 1;

//             Item.rare = ItemRarityID.White;
//             Item.value = Item.buyPrice(0, 0, 8, 60);

//             Item.damage = 10;
//             Item.DamageType = DamageClass.Melee;
//             Item.noMelee = true;
//             Item.crit = -1;
//             Item.knockBack = 5;
//             Item.axe = 10;
//             Item.useAmmo = AmmoID.Arrow;

//             Item.shoot = ProjectileID.NebulaChainsaw;
//             Item.shootSpeed = 10f;

//             Item.useStyle = ItemUseStyleID.Shoot;
//             Item.useTime = 10;
//             Item.useAnimation = 10;
//         }

//         public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
//         {
//             if (type == AmmoID.Gel)
//             {
//                 type = ProjectileID.VortexChainsaw;
//             }
//             else
//             {
//                 return;
//             }

//             if (type == AmmoID.Snowball)
//             {
//                 type = Item.damage = 10;
//             }
//             else
//             {
//                 return;
//             }
//         }
//     }
// }