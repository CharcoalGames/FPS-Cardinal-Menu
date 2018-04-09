// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class CardinalMenuTarget : TargetRules
{
	public CardinalMenuTarget(TargetInfo Target) : base (Target)
	{
		Type = TargetType.Game;
        ExtraModuleNames.Add("CardinalMenu");
        bUsesSteam = true;
    }

	//
	// TargetRules interface.
	//
//  UE4.16 Changes
//	public override void SetupBinaries(
//		TargetInfo Target,
//		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
//		ref List<string> OutExtraModuleNames
//		)
//	{
//		OutExtraModuleNames.AddRange( new string[] { "CardinalMenu" } );
//	}
}
