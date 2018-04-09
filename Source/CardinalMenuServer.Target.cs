// Copyright 1998-2014 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class CardinalMenuServerTarget : TargetRules
{
    public CardinalMenuServerTarget(TargetInfo Target) : base (Target)
    {
        Type = TargetType.Server;
        ExtraModuleNames.Add("CardinalMenu");
    }

    //
    // TargetRules interface.
    //
    //Modified for UE4.16
    //public override void SetupBinaries(
    //   TargetInfo Target,
    //   ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
    //    ref List<string> OutExtraModuleNames
    //    )
    //{
    //    base.SetupBinaries(Target, ref OutBuildBinaryConfigurations, ref OutExtraModuleNames);
    //    OutExtraModuleNames.Add("CardinalMenu");
    //}
    
    
}