using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBoi : MonoBehaviour
{
    public Transform player;
    public static Transform playerboi;

    private void Awake()
    {
        playerboi = player;   
    }
}
