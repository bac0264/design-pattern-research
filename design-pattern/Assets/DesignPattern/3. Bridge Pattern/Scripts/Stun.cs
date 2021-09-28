using UnityEngine;

public class Stun : Effect
{
    public Stun()
    {
        effectType = EffectType.Stun;
    }
    
    public override void Execute()
    {
        Debug.Log("Stun");
    }
}

