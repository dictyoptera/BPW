using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;

public class cutcenemanage : MonoBehaviour
{
    public TMP_Text text;
    public Camera cutsceneCam;
    public PlayableDirector pd;
    public float radius;
    public Transform player;
    public Transform lamp;
    public bool CutsceneHasPlayed = false;
    public void Update()
    {
        if(Vector3.Distance(player.position, lamp.position) < radius && !cutsceneCam.isActiveAndEnabled && !CutsceneHasPlayed) {
            text.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayCutscene();
                CutsceneHasPlayed = true;
            }
        } else
        {
            text.enabled = false;
        }
    }

    public void PlayCutscene()
    {
        cutsceneCam.enabled = true;
        pd.Play();
        text.enabled = false;
    }

    
}
