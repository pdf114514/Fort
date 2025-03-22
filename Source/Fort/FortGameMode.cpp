#include "FortGameMode.h"
#include "Engine.h"
#include "Engine/World.h"
#include "GameFramework/Actor.h"
#include "Kismet/GameplayStatics.h"

void AFortGameMode::StartPlay() {
    Super::StartPlay();

    UWorld* World = GetWorld();
    if (!World) {
        UE_LOG(LogTemp, Log, TEXT("World is null!"));
        return;
    }

    UE_LOG(LogTemp, Log, TEXT("Listening beginning!"));
    FURL Url(nullptr, TEXT(""), TRAVEL_Absolute);
    bool bSuccess = World->Listen(Url);
    if (!bSuccess) {
        UE_LOG(LogTemp, Log, TEXT("Failed to start listening!"));
        return;
    }
    UE_LOG(LogTemp, Log, TEXT("Listening started!"));
}