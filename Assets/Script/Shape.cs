using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
   
    
    protected string shapeName { get; set; }

    public void init(string shapeName)
    { }

    public abstract float CalculateArea();
    
    public virtual void Resize()
    { Debug.Log("$Resizing Shape....."); }
    public void Draw()
    { Debug.Log("$Drawing{ShapeName}"); }
    


    
}
