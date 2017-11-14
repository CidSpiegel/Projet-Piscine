using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Malus : Trigger {
    public override void Effect(Player other)
    {
        other._life -= 10;
    }
}
