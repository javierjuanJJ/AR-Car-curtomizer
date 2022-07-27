using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    private Renderer[] mats;
    
    private void ChangeColorMethod(Color colorToChange)
    {
        for (int count = 0; count < mats.Length; count++)
        {
            mats[count].material.color = colorToChange;
        }
    }
    public void ChangeColorRed()
    {
        ChangeColorMethod(Color.red);
    }
    public void ChangeColorBlue()
    {
        ChangeColorMethod(Color.blue);
    }
    public void ChangeColorBlack()
    {
        ChangeColorMethod(Color.black);
    }
    public void ChangeColorYellow()
    {
        ChangeColorMethod(Color.yellow);
    }
}
