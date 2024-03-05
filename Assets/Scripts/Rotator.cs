using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float velocidadRotacion = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(velocidadRotacion * Time.deltaTime, 0, 0);
    }
}
