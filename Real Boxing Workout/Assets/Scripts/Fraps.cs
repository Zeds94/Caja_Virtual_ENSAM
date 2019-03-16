using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fraps {

    public float speed;
    public float magnitude;
    Vector3 vit;

    public Fraps()
    {
        speed = 0f;
        magnitude = 0f;
        vit = new Vector3(0f, 0f, 0f);
    }

    public Fraps(Vector3 v)
    {
        vit = v;
        magnitude = v.magnitude;
    }

    public float getMagnitude()
    {
        return magnitude;

    }
}
