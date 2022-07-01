using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float speed;
    public float multiplicador = 2f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1)*speed* Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bazooka();
        }
    }
    void Bazooka()
    {
        transform.localScale = new Vector3(1, 1, 1) * multiplicador;
    }
    
}
