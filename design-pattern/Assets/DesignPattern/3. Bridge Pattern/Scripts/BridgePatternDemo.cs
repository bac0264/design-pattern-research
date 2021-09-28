using UnityEngine;

public class BridgePatternDemo : MonoBehaviour
{
    private void Start()
    {
        var active = new Active(new Stun(), new Bullet());
        active.Execute();
    }
}
