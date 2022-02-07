// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class GDINFMG_Kyce_SedesaTarget : TargetRules
{
	public GDINFMG_Kyce_SedesaTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "GDINFMG_Kyce_Sedesa" } );
	}
}
