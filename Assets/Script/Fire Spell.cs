using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
   
    public override void Cast()
    {
        Debug.Log("Cast Fire spell");
    }
    
    public void Cast(string target)
    {
        Debug.Log("Casting a Fire on slime");
    }
    public void Cast(string target, int power)
    {
        Debug.Log("Casting a Fire with power 5");

    }
    private void Start()
    {
        Cast();


    }
}
    
