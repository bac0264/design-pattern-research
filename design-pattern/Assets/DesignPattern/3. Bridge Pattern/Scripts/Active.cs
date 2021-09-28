using System;
using System.Collections.Generic;
using UnityEngine;

public class Active
{
    public Effect effect;
    public Mechanism mechanism;
    
    // Việc khởi tạo Effect hay Mechanism được config type trong Csv
    // Một vài Skill đặc biệt sẽ k cần khởi tạo mechanism hay effect
    
    public Active(Effect effect, Mechanism mechanism)
    {
        this.effect = effect;
        this.mechanism = mechanism;
    }
    
    public virtual void Execute()
    {
        mechanism.Execute();
        effect.Execute();
    }
}
