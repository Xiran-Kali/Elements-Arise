using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public override void Catch(ObjectData data)
    {
        data.Material.OnFire(data);
    }
}
