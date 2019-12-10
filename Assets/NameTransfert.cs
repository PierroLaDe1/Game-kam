using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameTransfert : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;
    public GameObject Button;
    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Bienvenue " + theName + ", te voila dans notre parc ! prends l'arme , détruit toutes les cibles et découvres la suite ! ";
        Button.SetActive(true);
    }
    
    
}
