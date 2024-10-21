using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    [SerializeField] private int temperature;
    [SerializeField] private int humidity;
    [SerializeField] private float speed;


    public virtual void Catch(ObjectData data)
    {
        data.Temperature += temperature;
        data.Humidity += humidity;
    }
}
