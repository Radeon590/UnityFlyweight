using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NpcFactory : MonoBehaviour
{
    [SerializeField] private GameObject npcPrefab;
    [SerializeField] private List<SkinSettings> skinSettings; //TODO: make dictionary and script for setup in editor

    public List<SkinSettings> SkinSettings => skinSettings;
    
    public void SpawnNpc(string skinName, Vector3 spawnPosition)
    {
        var skinSetting = skinSettings.FirstOrDefault(s => s.SkinName == skinName);
        var newNpc = Instantiate(npcPrefab, spawnPosition, Quaternion.identity);
        newNpc.GetComponent<Renderer>().materials = new[] { skinSetting.Material};
    }
}
