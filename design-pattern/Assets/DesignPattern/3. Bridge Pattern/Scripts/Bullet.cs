using UnityEngine;

public class Bullet : Mechanism
{
    public Bullet()
    {
        mechanismType = MechanismType.Bullet;
    }
    public override void Execute()
    {
        Debug.Log("Bullet");
    }
}
