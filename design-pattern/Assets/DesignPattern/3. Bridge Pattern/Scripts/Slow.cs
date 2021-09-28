using UnityEngine;

public class Slow : Effect
{
    public Slow()
    {
        effectType = EffectType.Slow;
    }
    
    public override void Execute()
    {
        Debug.Log("Slow");
    }
}
