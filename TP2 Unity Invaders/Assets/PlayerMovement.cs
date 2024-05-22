using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jugador : MonoBehaviour
{
    public GameObject prefabDisparo; // Referencia al prefab del proyectil
    public Transform puntoDeDisparo;   // Punto desde donde se disparará el proyectil
    public float velocidadProyectil = 10f; // Velocidad del proyectil

    private Vector2 movimiento;

    public void OnMove(InputValue input)
    {
        movimiento = input.Get<Vector2>();
    }

    public void OnFire()
    {
        Disparar();
    }

    void Update()
    {
        Mover();
    }

    void Mover()
    {
        transform.position = new Vector3(
            transform.position.x + movimiento.x * Time.deltaTime,
            transform.position.y + movimiento.y * Time.deltaTime,
            0
        );
    }

    void Disparar()
    {
        GameObject proyectil = Instantiate(prefabDisparo, puntoDeDisparo.position, Quaternion.identity);
        Rigidbody2D rb = proyectil.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.up * velocidadProyectil; // Disparar el proyectil hacia arriba
        }
    }
}

