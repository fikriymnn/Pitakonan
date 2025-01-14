using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem.Controls;

[RequireComponent(typeof(CinemachineFreeLook))]

public class CameraLook : MonoBehaviour
{
    [SerializeField]
    private float lookSpeed = 1;

    private CinemachineFreeLook cinemachine;
    private Player playerInput;

    private void Awake()
    {
        playerInput = new Player();
        cinemachine = GetComponent<CinemachineFreeLook>();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 delta = playerInput.PlayerMain.Look.ReadValue<Vector2>();
        cinemachine.m_XAxis.Value += delta.x * 200 * lookSpeed * Time.deltaTime;
        cinemachine.m_YAxis.Value += delta.y * lookSpeed * Time.deltaTime;
    }
}
