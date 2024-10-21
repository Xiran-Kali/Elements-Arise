using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMaterial : Material
{
    [SerializeField]
    private int explosionTemp;

    [SerializeField]
    private float explosionRadius;

    [SerializeField]
    private float explosionForce;
    
    protected override void OnVolcano(ObjectData data)
    {
        Explode();

    }

    protected override void OnFire(ObjectData data)
    {
        if (data.Temperature >= explosionTemp) { Explode(); }

    }

    protected override void OnSteam(ObjectData data)
    {
        if (data.Temperature >= explosionTemp) { Explode(); }
    }


    private void Explode()
    {
        Collider[] colliders = new Collider[20];
        int numColliders = Physics.OverlapSphereNonAlloc(transform.position, explosionRadius,colliders);

        for (int i = 0; i < numColliders; i++)
        {
            colliders[i].attachedRigidbody.AddExplosionForce(explosionForce, transform.position, explosionRadius);
        }

        Destroy(this.gameObject);

    }

}
