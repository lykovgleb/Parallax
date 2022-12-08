using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    private float basePosition;
    private GameObject cam;
    [Range(-1, 1)]
    [SerializeField] private float distance;
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        basePosition = transform.position.x;
    }
    void LateUpdate()
    {
        var positionWithParallaxEffect = basePosition + cam.transform.position.x * distance;
        transform.position = new Vector3(positionWithParallaxEffect, transform.position.y, transform.position.z);
    }
}
