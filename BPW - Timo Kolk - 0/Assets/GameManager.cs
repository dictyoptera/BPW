using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject endOrb;

   public void CompleteLevel()
    {
        endOrb.SetActive(true);  
    }
}
