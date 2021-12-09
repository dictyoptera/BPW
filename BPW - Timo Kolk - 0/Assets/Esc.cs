using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Esc : MonoBehaviour
{
    public GameObject GameMenu;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameMenu.SetActive(true);
        }
    }

}



