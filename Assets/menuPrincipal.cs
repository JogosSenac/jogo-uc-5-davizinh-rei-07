using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPrincipal : MonoBehaviour
{
   public void comecar() 
   {
    SceneManager.LoadScene("inicio");
   }
   public void sair()
   {
    Application.Quit();
   }
}
