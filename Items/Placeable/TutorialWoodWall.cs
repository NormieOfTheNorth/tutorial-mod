﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TutorialMod.Items.Placeable
{
    public class TutorialWoodWall : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tutorial Wood Wall");
        }
        
        public override void SetDefaults()
        {
            item.width = 12; // Hitbox Width
            item.height = 12; // Hitbox Height
            item.useTime = 15; // Speed before reuse
            item.useAnimation = 10; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 50; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createWall = mod.WallType("TutorialWoodWall");
            item.maxStack = 999; // The maximum number you can have of this item.
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "TutorialWood");
            r.SetResult(this, 4); // 4 = number of this item you get.
            r.AddRecipe();
        }
    }
}
