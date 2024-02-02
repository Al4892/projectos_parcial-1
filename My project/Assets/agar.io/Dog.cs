using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    [Header("clase derivada")]
    public string Raza;
    void Start()
    {
        Display();
    }
    void Update()
    {
        move();
    }
    public override void move()
    {
        posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionMouse.z = 0f;
    
    Vector3 direccion = (posicionMouse - transform.position).normalized;
    transform.Translate(direccion* speed * Time.deltaTime);
    }
}
