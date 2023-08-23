using MelonLoader;
using BTD_Mod_Helper;
using OopsAllBads;
using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Enums;
using Il2CppAssets.Scripts.Models.Rounds;
using BTD_Mod_Helper.Extensions;
using BTD_Mod_Helper.Api.Scenarios;
using Il2CppAssets.Scripts.Models.Difficulty;
using Il2CppAssets.Scripts.Models;

[assembly: MelonInfo(typeof(OopsAllBads.OopsAllBads), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace OopsAllBads;

public class OopsAllBads : BloonsTD6Mod {
    public override void OnApplicationStart() {
        ModHelper.Msg<OopsAllBads>("OopsAllBads loaded!");
    }
}

public class OopsAllBadsRounds : ModRoundSet {
    public override string BaseRoundSet => RoundSetType.Default;
    public override int DefinedRounds => BaseRounds.Count;
    public override string DisplayName => "Oops All Bads";
    public override string Icon => VanillaSprites.BadBloonIcon;

    public override void ModifyRoundModels(RoundModel roundModel, int round) {
        roundModel.ClearBloonGroups();
        roundModel.AddBloonGroup("Bad", 1, 0, 0);
    }
}

public class EasyAllBads : ModGameMode {
    public override string Difficulty => DifficultyType.Easy;
    public override string BaseGameMode => GameModeType.Easy;
    public override string DisplayName => "1 Big Air Dabloon";
    public override string Icon => VanillaSprites.BadBloonIcon;
    public override void ModifyBaseGameModeModel(ModModel gameModeModel) { gameModeModel.UseRoundSet<OopsAllBadsRounds>(); }
}

public class MediumAllBads : ModGameMode {
    public override string Difficulty => DifficultyType.Medium;
    public override string BaseGameMode => GameModeType.Medium;
    public override string DisplayName => "1 Big Air Dabloon";
    public override string Icon => VanillaSprites.BadBloonIcon;
    public override void ModifyBaseGameModeModel(ModModel gameModeModel) { gameModeModel.UseRoundSet<OopsAllBadsRounds>(); }
}

public class HardAllBads : ModGameMode {
    public override string Difficulty => DifficultyType.Hard;
    public override string BaseGameMode => GameModeType.Hard;
    public override string DisplayName => "1 Big Air Dabloon";
    public override string Icon => VanillaSprites.BadBloonIcon;
    public override void ModifyBaseGameModeModel(ModModel gameModeModel) { gameModeModel.UseRoundSet<OopsAllBadsRounds>(); }
}

public class ImpoppableAllBads : ModGameMode {
    public override string Difficulty => DifficultyType.Hard;
    public override string BaseGameMode => GameModeType.Impoppable;
    public override string DisplayName => "1 Big Air Dabloon (Impoppable)";
    public override string Icon => VanillaSprites.BadBloonIcon;
    public override void ModifyBaseGameModeModel(ModModel gameModeModel) { gameModeModel.UseRoundSet<OopsAllBadsRounds>(); }
}
