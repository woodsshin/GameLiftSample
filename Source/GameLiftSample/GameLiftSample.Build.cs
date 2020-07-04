// Copyright 1998-2017 WoodsShin, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GameLiftSample : ModuleRules
{
	public GameLiftSample(ReadOnlyTargetRules Target) : base(Target)
	{
	    bFasterWithoutUnity = true;

        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicDependencyModuleNames.AddRange(
            new string[] {
                "Core",
                "CoreUObject",
                "Engine",
                "InputCore",
                "GameLiftFramework"
            });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
        PublicIncludePaths.AddRange(
            new string[] {
            });
    }
}
