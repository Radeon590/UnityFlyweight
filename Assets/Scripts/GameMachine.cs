using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMachine : MonoBehaviour
{
    [SerializeField] private Transform npcSpawnPoint;
    [SerializeField] private NpcFactory npcFactory;
    
    void Start()
    {
        foreach (var s in npcFactory.SkinSettings)
        {
            npcFactory.SpawnNpc(s.SkinName, npcSpawnPoint.position);
        }
    }
}
