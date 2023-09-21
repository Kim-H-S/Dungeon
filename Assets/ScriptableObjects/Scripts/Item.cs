using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type
{
    Equipment,
    Consumables,
    Etc
}

[CreateAssetMenu(menuName = "Item")]
public class Item : ScriptableObject
{
    public Type type;
    public string name;
    public string description;
    public Sprite sprite;
    public bool bEquip = false;
    //public int count;
    //public bool bStackable;

    public bool Equip()
    {
        return bEquip = !bEquip;
    }

}
