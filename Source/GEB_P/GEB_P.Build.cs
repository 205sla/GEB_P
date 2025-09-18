// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GEB_P : ModuleRules
{
	public GEB_P(ReadOnlyTargetRules Target) : base(Target)
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
			"GEB_P",
			"GEB_P/Variant_Platforming",
			"GEB_P/Variant_Platforming/Animation",
			"GEB_P/Variant_Combat",
			"GEB_P/Variant_Combat/AI",
			"GEB_P/Variant_Combat/Animation",
			"GEB_P/Variant_Combat/Gameplay",
			"GEB_P/Variant_Combat/Interfaces",
			"GEB_P/Variant_Combat/UI",
			"GEB_P/Variant_SideScrolling",
			"GEB_P/Variant_SideScrolling/AI",
			"GEB_P/Variant_SideScrolling/Gameplay",
			"GEB_P/Variant_SideScrolling/Interfaces",
			"GEB_P/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
