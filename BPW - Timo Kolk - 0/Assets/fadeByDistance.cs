using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class fadeByDistance : MonoBehaviour
{
    
    public float maximumDistance = 1;
    public float minmumDistance = 1;

    private MeshRenderer rend;
    private Material mat;
    private Transform player;
    private float a = 1;

    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        mat = rend.material;
        player = ObjectBoi.playerboi;
    }

    // Update is called once per frame
    void Update()
    {
        Vector4 color = mat.color;
        float distance = Vector3.Distance(player.position, transform.position);
        if(distance < maximumDistance)
        {
            a = ((distance - minmumDistance) / (maximumDistance - minmumDistance));
        } else
        {
            a = 1;
        }
        if(distance < minmumDistance)
        {
            a = 0;
        }
        color.w = a;
        color.w = Mathf.Max(color.w, 0);
        mat.color = color;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, maximumDistance);
        Gizmos.DrawWireSphere(transform.position, minmumDistance);
    }
}
