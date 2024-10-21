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

    
    }


    private void Burning()
    {
        
    }

    protected override void OnPlant(ObjectData data)
    {
        if (!isBurning)
        {
            isGrowing = true;
        }
    }

    protected override void OnIce(ObjectData data)
    {
        isGrowing = false;
    }


}
