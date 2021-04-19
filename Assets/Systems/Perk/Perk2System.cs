using Leopotam.Ecs;


sealed class Perk2System : IEcsRunSystem
{
    readonly EcsFilter<PlayerComponent, HealthPointComponent, Perk2> players;

    void IEcsRunSystem.Run()
    {
        foreach (var p in players)
        {
            players.Get1(p).maxHealthPoint += 20;
            players.Get2(p).Value += 20;
            UnityEngine.Debug.Log("����");
        }
    }
}
