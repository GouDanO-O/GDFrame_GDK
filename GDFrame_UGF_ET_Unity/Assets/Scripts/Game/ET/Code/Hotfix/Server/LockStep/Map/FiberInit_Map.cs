﻿using Cysharp.Threading.Tasks;

namespace ET.Server
{
    [Invoke((long)SceneType.Map)]
    public class FiberInit_Map: AInvokeHandler<FiberInit, UniTask>
    {
        public override async UniTask Handle(FiberInit fiberInit)
        {
            Scene root = fiberInit.Fiber.Root;
            root.AddComponent<MailBoxComponent, MailBoxType>(MailBoxType.UnOrderedMessage);
            root.AddComponent<TimerComponent>();
            root.AddComponent<CoroutineLockComponent>();
            root.AddComponent<ProcessInnerSender>();
            root.AddComponent<MessageSender>();
            await NavmeshComponent.Instance.LoadAsync(root.Name);
            root.AddComponent<UnitComponent>();
            root.AddComponent<AOIManagerComponent>();
            root.AddComponent<RoomManagerComponent>();
            root.AddComponent<LocationProxyComponent>();
            root.AddComponent<MessageLocationSenderComponent>();

            await UniTask.CompletedTask;
        }
    }
}