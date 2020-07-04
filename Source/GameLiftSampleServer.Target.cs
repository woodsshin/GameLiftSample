// Copyright 1998-2017 WoodsShin, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class GameLiftSampleServerTarget : TargetRules
{
	public GameLiftSampleServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;

        bForceEnableExceptions = true;

        ExtraModuleNames.AddRange( new string[] { "GameLiftSample" } );
	}
}
