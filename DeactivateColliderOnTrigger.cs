using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateColliderOnTrigger : MonoBehaviour
{
    [SerializeField] private Collider targetCollider;

    private bool isTriggered;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTriggered)
        {
            targetCollider.enabled = false;
            isTriggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && isTriggered)
        {
            targetCollider.enabled = true;
            isTriggered = false;
        }
    }
}
