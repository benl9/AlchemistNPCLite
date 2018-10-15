using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using AlchemistNPCLite;

namespace AlchemistNPCLite.Items.Misc
{
	public class AlchemistCharmTier1 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Alchemist Charm Tier 1");
			Tooltip.SetDefault("While this is in your inventory, you have a low chance not to consume potion");
			DisplayName.AddTranslation(GameCulture.Russian, "Талисман Алхимика Тир 1");
            Tooltip.AddTranslation(GameCulture.Russian, "Если находится в инвентаре, вы имеет малый шанс не потратить зелье");
        }

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 1000000;
			item.rare = 6;
		}
		
		public override void UpdateInventory(Player player)
		{
		((AlchemistNPCLitePlayer)player.GetModPlayer(mod, "AlchemistNPCLitePlayer")).AlchemistCharmTier1 = true;
		}
	}
}
