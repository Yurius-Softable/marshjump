using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMenuController : MonoBehaviour
{

    public GameObject buttonsMenu;
    public GameObject buttonsExit;

   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void ShowExitButtons() 
    {
        buttonsMenu.SetActive(false);
        
    }
}
