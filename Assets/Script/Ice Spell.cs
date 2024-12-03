using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    public override void Cast()
    {
        Debug.Log("Cast Ice spell");
    }
   
    public void Cast(string target)
    {
        Debug.Log("Casting a Ice on slime");
    }
    public void Cast(string target, int power)
    {
        Debug.Log("Casting a Ice with power 5");

    }
    private void Start()
    {
        Cast();

    }
}
