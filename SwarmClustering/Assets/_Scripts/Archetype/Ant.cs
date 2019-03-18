﻿using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;
using Unity.Transforms;

public static class Ant
{
    public static EntityArchetype antArchetype;

    public static MeshInstanceRenderer antMesh;

    public static void CreateAnt(ref Entity ant, ref EntityManager em, int position)
    {
        ant = em.CreateEntity(antArchetype);
        em.SetComponentData(ant, new Position { Value = Common.GetGridLocation(position) });
        em.SetComponentData(ant, new Rotation { Value = new quaternion(0f, 0f, 0f, 1f) });
        em.SetComponentData(ant, new Carrying { Value = Common.False });
        em.SetComponentData(ant, new StartPosition { Value = Common.GetGridLocation(position) });
        em.SetComponentData(ant, new NextPosition { Value = Common.GetGridLocation(position) });

        em.AddSharedComponentData(ant, antMesh);
    }
}