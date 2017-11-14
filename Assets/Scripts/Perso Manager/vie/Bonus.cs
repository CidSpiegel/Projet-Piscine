using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : Trigger {
    public override void Effect(Player other)
    {
        other._life += 10;
    }
}
