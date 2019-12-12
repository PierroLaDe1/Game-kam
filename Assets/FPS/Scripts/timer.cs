


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timer : MonoBehaviour
{
public float temps;
public Text textComponent;

public float Timerinterval = 5f;
// Start is called before the first frame update
void Start()
{
//On met le texte à jour pour afficher le nombre de vies
textComponent.text = temps.ToString();
}

void Update()
{
        
//On enlève une vie
temps -= Time.deltaTime;
//On met le texte à jour
textComponent.text = temps.ToString();
    if (temps <0  )
Debug.Log("PERDU ");
    
}
}