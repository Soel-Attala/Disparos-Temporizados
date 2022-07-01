using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float hor;
    public float ver;
    public float speed;
    public GameObject proyectilPrefab;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoJugador();
        Shoot();
    }

    void MovimientoJugador()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hor, 0, ver) * speed * Time.deltaTime);
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(proyectilPrefab, transform.position, transform.rotation);
        }
    }


}
