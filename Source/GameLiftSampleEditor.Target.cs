// Copyright 1998-2017 WoodsShin, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class GameLiftSampleEditorTarget : TargetRules
{
	public GameLiftSampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

        ExtraModuleNames.AddRange( new string[] { "GameLiftSample" } );
	}
}
