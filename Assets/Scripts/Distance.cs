using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject unCactus, doiCactus;
    public float distance;
    public Animator animatorUnu, animatorDoi;
    void Start(){ }

    void Update() {
        distance = Vector3.Distance(unCactus.transform.position, doiCactus.transform.position);

        if (distance < .2) {
            animatorUnu.SetTrigger("Fight");
            animatorDoi.SetTrigger("Fight");
        }
        else {
            animatorUnu.SetTrigger("Chill");
            animatorDoi.SetTrigger("Chill");
        }
    }
}
