// ShootThemUp Game, All Rights Reserved.

using UnrealBuildTool;

public class ShootThemUp : ModuleRules
{
    public ShootThemUp(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[]
        {
            "Core",
            "CoreUObject",
            "Engine",
            "InputCore",
            "Niagara",
            "PhysicsCore",
            "GameplayTasks",
            "NavigationSystem"
        });

        PrivateDependencyModuleNames.AddRange(new string[] { });

        PublicIncludePaths.AddRange(new string[]
        {
            "ShootThemUp/Public/Player",
            "ShootThemUp/Public/Components",
            "ShootThemUp/Public/Dev",
            "ShootThemUp/Public/Weapon",
            "ShootThemUp/Public/UI",
            "ShootThemUp/Public/Animations",
            "ShootThemUP/Public/Pickups",
            "ShootThemUP/Public/Weapon/Components",
            "ShootThemUP/Public/AI",
            "ShootThemUP/Public/AI/Tasks",
            "ShootThemUP/Public/AI/Services",
            "ShootThemUP/Public/AI/EQS",
            "ShootThemUP/Public/AI/Decorators",
            "ShootThemUP/Public/Menu",
            "ShootThemUP/Public/Menu/UI",
            "ShootThemUP/Public/Sound"
        });

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
