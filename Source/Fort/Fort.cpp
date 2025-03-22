#include "CoreMinimal.h"
#include "Modules/ModuleManager.h"

class FFortModule : public FDefaultGameModuleImpl {
    virtual void StartupModule() override {
        // if (GLog) GLog->AddOutputDevice(new FOutputDeviceConsole()); // ?
    }

    virtual void ShutdownModule() override {}
};

IMPLEMENT_PRIMARY_GAME_MODULE(FFortModule, Fort, "Fort");