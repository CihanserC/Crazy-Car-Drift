using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorPicker : MonoBehaviour
{
    public Material[] BodyColorMat;


    Material CurrMat;
    Renderer renderer;
    int colorvalue;

    void Start()
    {
        renderer = this.GetComponent<Renderer>();        
    }


    public void LoadChanges()
    {
        Debug.Log("Loaded - "+ "Value : " + colorvalue);

        colorvalue = PlayerPrefs.GetInt("ColorValue");
        renderer = this.GetComponent<Renderer>();

        if (renderer != null){

           if (colorvalue == 0)
           {
               //ChangeRed();
               renderer.material = BodyColorMat[0];
               CurrMat = renderer.material;
               //renderer.material = CurrMat;

           }
           if (colorvalue == 1)
           {
               //ChangeBlue();
               renderer.material = BodyColorMat[1];
               CurrMat = renderer.material;
            }
            if (colorvalue == 2)
           {
               //ChangeGreen();
               renderer.material = BodyColorMat[2];
               CurrMat = renderer.material;
           }
          


         }
      

    }

    public void ChangeRed()
    {
        renderer.material = BodyColorMat[0];
        CurrMat = renderer.material;
        PlayerPrefs.SetInt("ColorValue", 0);  
        PlayerPrefs.Save();
    }
    public void ChangeBlue()
    {
        renderer.material = BodyColorMat[1];
        CurrMat = renderer.material;
        PlayerPrefs.SetInt("ColorValue", 1);
        PlayerPrefs.Save();
    }
    public void ChangeGreen()
    {
        renderer.material = BodyColorMat[2];
        CurrMat = renderer.material;
        PlayerPrefs.SetInt("ColorValue", 2);
        PlayerPrefs.Save();
    }

    


}
