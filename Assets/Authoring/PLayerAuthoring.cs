using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leopotam.Ecs;

public class PlayerAuthoring : Authoring<PlayerComponent>
{
    [SerializeField] float cooldownValue = 0.18f;
    [SerializeField] public int damage = 1;

    protected override void Start()
    {
        base.Start();

        entity.Get<PlayerComponent>().view = GetComponent<Player>();
        entity.Get<PlayerComponent>().cooldownValue = cooldownValue;
        entity.Get<PlayerComponent>().damage = damage;
    }
}
