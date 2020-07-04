// Copyright 1998-2017 WoodsShin, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class GameLiftSampleTarget : TargetRules
{
	public GameLiftSampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

        bForceEnableExceptions = true;

        ExtraModuleNames.AddRange( new string[] { "GameLiftSample" } );
	}
}
