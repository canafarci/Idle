using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<CharacterController>().FromComponentInHierarchy().AsTransient();
        Container.Bind<IStacker>().FromComponentInHierarchy().AsTransient();
    }
}
