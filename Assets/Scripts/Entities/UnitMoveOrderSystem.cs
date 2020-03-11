﻿using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;


public class UnitMoveOrderSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Entities.ForEach((Entity entity, ref Translation translation) =>
            {
                EntityManager.AddComponentData(entity, new PathfindingParams
                {
                    startPos = new int2(0, 0),
                    endPos = new int2(4, 0),
                });
            });       
        }
    }
}
