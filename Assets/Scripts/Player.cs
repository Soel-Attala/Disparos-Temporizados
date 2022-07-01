using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float hor;
    public float ver;
    public float speed;
    public float tiempo = 3f;
    public float tiempoRestante;

    public GameObject proyectilPrefab;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoJugador();
        Temporizador();
    }

    void MovimientoJugador()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hor, 0, ver) * speed * Time.deltaTime);
    }

    void Shoot()
    { 
       
        
        Instantiate(proyectilPrefab, transform.position, transform.rotation);
        
          
    }

    void Reload()
    {
        tiempoRestante = tiempo;
    }

    void Temporizador()
    {
        tiempoRestante -= Time.deltaTime;
        if(tiempoRestante <= 0)
        {
            Shoot();
            Reload();
        }
    }






}
