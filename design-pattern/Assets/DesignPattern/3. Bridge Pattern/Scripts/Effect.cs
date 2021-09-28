
public enum EffectType
{
    Stun,
    Slow,
    Freeze,
}
public abstract class Effect
{
    public EffectType effectType;

    public abstract void Execute();
}

