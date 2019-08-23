#pragma once

#include "Components/ActorComponent.h"
#include "Networking.h"
#include "Runtime/Sockets/Public/IPAddress.h"
#include "UDPComponent.generated.h"

DECLARE_DYNAMIC_MULTICAST_DELEGATE(FUDPEventSignature);
DECLARE_DYNAMIC_MULTICAST_DELEGATE_OneParam(FUDPMessageSignature, const TArray<uint8>&, Bytes);

UCLASS(ClassGroup = "Networking", meta = (BlueprintSpawnableComponent))
class UDPWRAPPER_API UUDPComponent : public UActorComponent
{
	GENERATED_UCLASS_BODY()
public:
	UPROPERTY(BlueprintAssignable, Category = "UDP Events")
	FUDPMessageSignature OnReceivedBytes;

	UPROPERTY(BlueprintAssignable, Category = "UDP Events")
	FUDPEventSignature OnReceiveSocketStartedListening;

	UPROPERTY(BlueprintAssignable, Category = "UDP Events")
	FUDPEventSignature OnReceiveSocketStoppedListening;

	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "UDP Connection Properties")
	FString SendIP;

	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "UDP Connection Properties")
	int32 SendPort;

	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "UDP Connection Properties")
	int32 ReceivePort;

	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "UDP Connection Properties")
	FString SendSocketName;

	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "UDP Connection Properties")
	FString ReceiveSocketName;

	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "UDP Connection Properties")
	int32 BufferSize;

	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "UDP Connection Properties")
	bool bShouldAutoConnect;

	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "UDP Connection Properties")
	bool bShouldAutoListen;

	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category = "UDP Connection Properties")
	bool bReceiveDataOnGameThread;

	UPROPERTY(BlueprintReadOnly, Category = "UDP Connection Properties")
	bool bIsConnected;

	UFUNCTION(BlueprintCallable, Category = "UDP Functions")
	FString StringFromBinaryArray(const TArray<uint8>& BinaryArray);

	UFUNCTION(BlueprintCallable, Category = "UDP Functions")
	void ConnectToSendSocket(const FString& InIP = TEXT("127.0.0.1"), const int32 InPort = 3000);

	UFUNCTION(BlueprintCallable, Category = "UDP Functions")
	void CloseSendSocket();

	UFUNCTION(BlueprintCallable, Category = "UDP Functions")
	void StartReceiveSocketListening(const int32 InListenPort = 3002);

	UFUNCTION(BlueprintCallable, Category = "UDP Functions")
	void CloseReceiveSocket();

	UFUNCTION(BlueprintCallable, Category = "UDP Functions")
	void Emit(const TArray<uint8>& Bytes);

	virtual void InitializeComponent() override;
	virtual void UninitializeComponent() override;
	virtual void BeginPlay() override;
	virtual void EndPlay(const EEndPlayReason::Type EndPlayReason) override;
	
protected:
	FSocket* SenderSocket;
	FSocket* ReceiverSocket;

	void OnDataReceivedDelegate(const FArrayReaderPtr& DataPtr, const FIPv4Endpoint& Endpoint);

	FUdpSocketReceiver* UDPReceiver;
	FString SocketDescription;
	TSharedPtr<FInternetAddr> RemoteAdress;
	ISocketSubsystem* SocketSubsystem;
};