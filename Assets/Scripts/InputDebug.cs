using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDebug : MonoBehaviour
{

    Vector3 pos;

    public float offset = 3f;





    void Update()

    {

        pos = Input.mousePosition;

        pos.z = 10;

        transform.position = Camera.main.ScreenToWorldPoint(pos);

    }

}
