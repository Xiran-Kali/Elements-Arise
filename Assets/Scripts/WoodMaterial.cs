using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodMaterial : Material
{
    private float scaling = 1;
    [SerializeField] private float maxScaling;
    private bool isBurning = false;
    private bool isGrowing = false;

    private void Update()
    {
        if (isGrowing && scaling < maxScaling)
        {
            scaling += Time.deltaTime;
        }
        if (isBurning)
        {

            scaling -= Time.deltaTime;
            if (scaling <= 0)
            {
                Destroy(gameObject);
            }
        
        }
        gameObject.transform.localScale = scaling * gameObject.transform.lossyScale;
    
    }


    public override void Burning(ObjectData data)
    {
        base.Burning(data);
        isBurning = true;
    }

    public override void OnPlant(ObjectData data)
    {
        if (!isBurning)
        {
            isGrowing = true;
        }
    }

    public override void OnIce(ObjectData data)
    {
        isGrowing = false;
    }


}
