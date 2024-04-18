// ShootThemUp Game, All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "Engine/GameInstance.h"
#include "STUGameInstance.generated.h"

UCLASS()
class SHOOTTHEMUP_API USTUGameInstance : public UGameInstance
{
    GENERATED_BODY()

public:
    FName GetStartupLevelName() const { return StartupLevelName; }

protected:
    UPROPERTY(EditDefaultsOnly, Category = "UI")
    FName StartupLevelName = NAME_None;
};