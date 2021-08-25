using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TankScriptableObject", menuName = "ScriptableObject/tank")]
public class TankScriptableObject : ScriptableObject
{
    public float speed;
    public float Health;
    public float range;
    public float damage;
    public Color color;
    public float rotationSpeed;
}
