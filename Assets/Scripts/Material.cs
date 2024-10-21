using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material : MonoBehaviour
{
    protected bool conductivite;
    protected float mass_multiplier;

    protected virtual void OnFire(ObjectData data)
    {

    }

    protected virtual void OnWater(ObjectData data)
    {

    }
    protected virtual void OnEarth(ObjectData data)
    {

    }
    protected virtual void OnWind(ObjectData data)
    {

    }
    protected virtual void OnSteam(ObjectData data)
    {

    }
    protected virtual void OnVolcano(ObjectData data)
    {

    }
    protected virtual void OnThunder(ObjectData data)
    {

    }
    protected virtual void OnPlant(ObjectData data)
    {

    }
    protected virtual void OnIce(ObjectData data)
    {

    }

    protected virtual void OnSand(ObjectData data)
    {

    }

    protected virtual void Burning()
    {

    }

    protected virtual bool Frozen()
    {
        return false;
    }


}
