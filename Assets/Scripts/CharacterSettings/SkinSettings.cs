using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinSettings", menuName = "CharacterSettings/SkinSettings", order = 1)]
public class SkinSettings : ScriptableObject
{
    [SerializeField] private Material material;

    public Material Material => material;
    
    [SerializeField] private string skinName;
    
    public string SkinName
    {
        get => skinName;
    }
}
