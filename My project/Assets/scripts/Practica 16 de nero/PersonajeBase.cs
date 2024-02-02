using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeBase : MonoBehaviour
{
    public bool isdead;
    protected float healt=100;
    public float gethealth()
    {
        return healt;
    }
    public bool getdead()
    {
        return isdead;
    }
}
public class Heroe: PersonajeBase
{
    private float fuerza=50;
    private float Velocidad = 70;
    private int attackPoints;
   
    public void setattack(int damage)
    {
        attackPoints = damage;
    }
    public int getattack()
    {
      if (isdead && healt != 0.0f )
        {
            return 0;
        }
        return attackPoints;

    }
}
class HeroeAgil: Heroe
{
    private float daño;
    public float nivel;
    public void GetAcces()
    {

        
        bool mueto = isdead;
        healt = 200;
        
    }
}
class EnemigoBase : PersonajeBase
{
    protected int Damage;
    protected float stamina;
    void hola()
    {
        isdead=false;
    }
    public void setDamage(int damage)
    {
        Damage = damage;
    }
    public int getdamage()
    {
        return Damage;
    }
}
class caballero : EnemigoBase
{
    void acceso()
    {
        
        healt = 100;
        stamina = 300;
        if (healt == 0)
        {
            isdead = true;
        }
    }
   
}
class tipos: MonoBehaviour
{
   public PersonajeBase personaje;
    public Heroe hr;
    public EnemigoBase enmy;
    private void Start()
    {
        personaje = new PersonajeBase();
        hr = new Heroe();
        enmy= new EnemigoBase();
        personaje.isdead = false;
        hr.getattack();
        enmy.setDamage(350);
        if (!personaje.getdead())
        {
            Debug.Log("Hero attack points: "+hr.getattack());
            if (!enmy.getdead())
            {
                int combatresult = (hr.getattack() - enmy.getdamage() * enmy.getdamage());
                Debug.Log("Combat result: "+ combatresult);
            } 
        }
    }
    

}