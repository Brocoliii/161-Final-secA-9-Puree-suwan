using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newspell : Spell
{
    public override void Cast()
    {
        Debug.Log("Cast Dark spell");
    }

    public void Cast(string target)
    {
        Debug.Log("Casting a Dark on slime");
    }
    public void Cast(string target, int power)
    {
        Debug.Log("Casting a Dark with power 5");

    }
    private void Start()
    {
        Cast();
        

    }
}
