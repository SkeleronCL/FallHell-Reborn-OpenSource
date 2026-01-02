// using Terraria;
// using Terraria.ID;
// using Terraria.ModLoader;
// using Terraria.DataStructures;
// using Microsoft.Xna.Framework;
// using Steamworks;
// using FHR.Content.Items;
// using FHR.Content.Projectiles;
// using FHR.Content.Items.Armor;
// using FHR.Content.Items.Tools;
// using FHR.Content.Items.Placemble;
// using Microsoft.CodeAnalysis.CSharp.Syntax;

// namespace FHR.Content.Items.Weapon
// {
//     public class BoneWarrior : ModItem
//     {
//         public override void SetDefaults()
//         {
//             Item.width = 70;
//             Item.height = 68;
//             Item.scale = 1.5f;

//             Item.rare = ItemRarityID.Orange;
//             Item.value = Item.buyPrice(0, 1, 62, 90);

//             Item.damage = 37;
//             Item.DamageType = DamageClass.Melee;
//             Item.crit = 3;
//             Item.knockBack = 7;

//             Item.shoot = ModContent.ProjectileType<BoneWarriorP>();
//             Item.shootSpeed = 10f;

//             Item.useStyle = ItemUseStyleID.Swing;
//             Item.useTime = 34;
//             Item.useAnimation = 34;

//             Item.noMelee = false;
//             Item.autoReuse = true;
//         }

//         public override void ModifyWeaponDamage(Player player, ref StatModifier damage)
//         {
//             if (Main.hardMode)
//             {
//                 Item.damage = 100;
//             }
//             else
//             {
//                 return;
//             }
//         }

//         // public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
//         // {
//         //     float adjustedItemScale = player.GetAdjustedItemScale(Item);
//         //     Projectile.NewProjectile(source, player.MountedCenter, new Vector2(player.direction, 0f), type, damage, knockback, player.whoAmI, player.direction * player.gravDir, player.itemAnimationMax, adjustedItemScale);
// 		// 	NetMessage.SendData(MessageID.PlayerControls, number: player.whoAmI);
            
//         //     return base.Shoot(player, source, position, velocity, type, damage, knockback);
//         // }

//         public override void AddRecipes()
//         {
//             CreateRecipe()
//                 .AddIngredient(ItemID.Bone, 10)
//                 .AddIngredient(ModContent.ItemType<BloodiestGem>())
//                 .AddIngredient(ModContent.ItemType<BloodyBar>(), 20)
//                 .AddTile(TileID.Anvils)
//                 .Register();
//         }
//     }
// }