﻿using Unity.Entities;
using Unity.Transforms;
using UnityEngine.SceneManagement;


public sealed class BallBootstrap
{
    public static void Initialize()
    {
        // Create ball archetype
        Ball.ballArchetype = Bootstrap.em.CreateArchetype(
            ComponentType.Create<Position>(),
            ComponentType.Create<Faction>()
            );
    }

    public static void InitializeWithScene()
    {
        Ball.ballRedMesh = Common.GetLookFromPrototype("RedBallPrototype");
        Ball.ballBlueMesh = Common.GetLookFromPrototype("BlueBallPrototype");
        Ball.ballGreenMesh = Common.GetLookFromPrototype("GreenBallPrototype");
        Ball.ballYellowMesh = Common.GetLookFromPrototype("YellowBallPrototype");
        Ball.ballPurpleMesh = Common.GetLookFromPrototype("PurpleBallPrototype");
    }



    public static void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
    {
        InitializeWithScene();
    }
}
