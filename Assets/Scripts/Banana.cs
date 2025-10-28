using UnityEngine;

public class Banana : Weapon
{
    public float speed = 0f;
    
    public override void Move()
    {
        throw new System.Exception();
    }

    public override void OnHitWith(Character character)
    {
        throw new System.Exception();
    }
}
