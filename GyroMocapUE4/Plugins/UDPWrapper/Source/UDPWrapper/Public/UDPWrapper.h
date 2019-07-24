#pragma once

#include "CoreMinimal.h"
#include "ModuleManager.h"

class FUDPWrapperModule : public IModuleInterface
{
public:

	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};