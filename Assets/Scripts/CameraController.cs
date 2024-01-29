using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Vector3 m_Offset;

    [SerializeField]
    private Transform m_Player;

    // Update is called once per frame
    void Update()
    {
        transform.position = m_Player.position + m_Offset;
    }
}
