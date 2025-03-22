// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class Fort : ModuleRules
{
    public Fort(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        // PrivatePCHHeaderFile = "AFort.h";
        // CppStandard = CppStandardVersion.Latest;

        PublicDependencyModuleNames.AddRange(new string[] {
            "Core",
            "CoreUObject",
            "Engine"
            // "Launch", "Projects", "Sockets", "Networking", "OnlineSubsystem", "OnlineSubsystemUtils"
        });

        bEnableExceptions = true;
    }
}
