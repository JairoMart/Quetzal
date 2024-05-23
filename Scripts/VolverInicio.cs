using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class VolverInicio : MonoBehaviour
{

void volverClicked() {
SceneManager.LoadScene("interfaz");
 }
 


void Update() {
//Regla del escape
if (Input.GetKey("escape"))
volverClicked();

}
   
 



}
