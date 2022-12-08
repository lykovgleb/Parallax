using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [Range(1f, 10f)]
    [SerializeField] private float camSpeed;
    private Vector3 nextPosition;

    private void LateUpdate()
    {
        nextPosition = new Vector3(player.transform.position.x, player.transform.position.y + 2, -10);
        transform.position = Vector3.Lerp(transform.position, nextPosition, camSpeed * Time.deltaTime);
    }
}
