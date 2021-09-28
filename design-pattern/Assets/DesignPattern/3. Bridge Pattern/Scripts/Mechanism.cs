public enum MechanismType
{
    Bullet,
    AtkAoe,
}
public abstract class Mechanism
{
    public MechanismType mechanismType;

    public abstract void Execute();
}

