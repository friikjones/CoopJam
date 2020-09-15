using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap : MonoBehaviour {

    //State change vars
    public TrapState trapState;
    private int tick;
    public float idleTime;
    public float warningTime;
    public float activeTime;
    public float cooldownTimer;

    //Movement Vars
    private Rigidbody rb;
    private BoxCollider boxCollider;
    private Vector3 initialPosition;
    public float trapHeight;

    //Visual Queue Vars
    public MeshRenderer meshRenderer;
    public GameObject warningObject;
    public Material activeMaterial;
    public Material cooldownMaterial;


    void Start() {
        rb = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
        initialPosition = transform.position;
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void FixedUpdate() {
        tick++;
        StateHandler();
    }

    void StateHandler() {
        switch (trapState) {
            case TrapState.Idle:
                if (tick > idleTime * 50) {
                    trapState = TrapState.Warning;
                    tick = 0;
                    WarningTransition();
                }
                break;
            case TrapState.Warning:
                if (tick > warningTime * 50) {
                    trapState = TrapState.Active;
                    tick = 0;
                    ActiveTransition();
                }
                break;
            case TrapState.Active:
                if (tick > activeTime * 50) {
                    trapState = TrapState.Cooldown;
                    tick = 0;
                    CooldownTransition();
                }
                break;
            case TrapState.Cooldown:
                if (tick > cooldownTimer * 50) {
                    trapState = TrapState.Idle;
                    tick = 0;
                    IdleTransition();
                }
                break;

        }
    }

    void IdleTransition() {
        boxCollider.isTrigger = true;
        boxCollider.enabled = false;
        transform.position = initialPosition - new Vector3(0, trapHeight, 0);
    }
    void WarningTransition() {
        warningObject.SetActive(true);
    }
    void ActiveTransition() {
        warningObject.SetActive(false);
        transform.position = initialPosition + new Vector3(0, trapHeight, 0);
        boxCollider.enabled = true;
        meshRenderer.material = activeMaterial;
    }
    void CooldownTransition() {
        boxCollider.isTrigger = false;
        meshRenderer.material = cooldownMaterial;
    }


}
