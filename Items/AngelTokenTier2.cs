using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AngelMod.Items
{
    public class AngelTokenTier2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tier 2 Offering Token");
            Tooltip.SetDefault("...");
        }

        public override void SetDefaults()
        {
            item.value = 0;
            item.rare = 0;
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimstoneBlock, 50);
            recipe.AddIngredient(ItemID.Vertebrae, 10);
            recipe.AddIngredient(ItemID.CrimtaneBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class OfferAngelTokenTier2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Offer Tier 2 Token");
            Tooltip.SetDefault("A Small Sacrifice");
        }

        public override void SetDefaults()
        {
            item.value = 0;
            item.rare = 0;
        }

        public override void OnCraft(Recipe recipe)
        {
            Main.LocalPlayer.GetModPlayer<AngelPlayer>().SpawnTier2();
            item.TurnToAir();
        }

        public override void AddRecipes()
        {
            AngelRecipe recipe = new AngelRecipe(mod);
            recipe.AddIngredient(mod.GetItem("AngelTokenTier2"));
            recipe.SetResult(this);
            recipe.AddRecipe();

            PocketAngelRecipe PArecipe = new PocketAngelRecipe(mod);
            PArecipe.AddIngredient(mod.GetItem("AngelTokenTier2"));
            PArecipe.SetResult(this);
            PArecipe.AddRecipe();
        }
    }
}