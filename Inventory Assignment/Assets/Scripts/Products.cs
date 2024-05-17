using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Scriptable object/Item")]
public class Products : ScriptableObject
{
    public bool stackable = true;
    public Sprite image;
    public int bookPrice;
    public int sellValue;
}

public enum BookType
{
    Fire,
    Electric,
    Ghost,
    Cheese,
    Sword
}
