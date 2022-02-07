// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class GDINFMG_Kyce_SedesaEditorTarget : TargetRules
{
	public GDINFMG_Kyce_SedesaEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "GDINFMG_Kyce_Sedesa" } );
	}
}
