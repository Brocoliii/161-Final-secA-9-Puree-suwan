using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Spell : MonoBehaviour
{
    public virtual void Cast()
    {
        Debug.Log("Casting Simulation");
    }
    public void Cast(string target)
    {
        Debug.Log("Casting a generic spell");
    }
    public void Cast(string target , int power)
    {
        Debug.Log("Casting a spell on slime");
    
    }
}
