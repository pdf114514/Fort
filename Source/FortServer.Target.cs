// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class FortServerTarget : TargetRules
{
    public FortServerTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Server;
        LinkType = TargetLinkType.Monolithic;
        // BuildEnvironment = TargetBuildEnvironment.Shared;

        ExtraModuleNames.AddRange( new string[] { "Fort" } );

        // bIsBuildingConsoleApplication = true;

        // bShouldCompileAsDLL = true;

        // bCompileChaos = false;
        // bCompileImmediatePhysics = false;
        // bCompileCustomSQLitePlatform = false;
        // bCompilePhysX = false;
        // bCompileNvCloth = false;
        // bCompileAPEX = false;

        // bCompileAgainstEngine = true;
        // bCompileAgainstCoreUObject = true;

        bUseLoggingInShipping = true;
        bEventDrivenLoader = false;
        // bUseStaticCRT = false;

        bBuildWithEditorOnlyData = false;
    }
}
