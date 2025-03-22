#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "FortGameMode.generated.h"

UCLASS()
class FORT_API AFortGameMode : public AGameModeBase {
    GENERATED_BODY()

    public:
        virtual void StartPlay() override;
};