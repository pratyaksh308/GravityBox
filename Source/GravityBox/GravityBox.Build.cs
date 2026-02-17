// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GravityBox : ModuleRules
{
	public GravityBox(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"GravityBox",
			"GravityBox/Variant_Platforming",
			"GravityBox/Variant_Platforming/Animation",
			"GravityBox/Variant_Combat",
			"GravityBox/Variant_Combat/AI",
			"GravityBox/Variant_Combat/Animation",
			"GravityBox/Variant_Combat/Gameplay",
			"GravityBox/Variant_Combat/Interfaces",
			"GravityBox/Variant_Combat/UI",
			"GravityBox/Variant_SideScrolling",
			"GravityBox/Variant_SideScrolling/AI",
			"GravityBox/Variant_SideScrolling/Gameplay",
			"GravityBox/Variant_SideScrolling/Interfaces",
			"GravityBox/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
