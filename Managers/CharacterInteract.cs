using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System;

public enum TypeRaycast
{
    standart, interactItem, damageItem
}

public class CharacterInteract : MonoBehaviour
{
    [SerializeField] private Transform startPos;
    [SerializeField] private LayerMask targetLayer;
    private TypeAttack typeAttack;
    private void OnEnable()
    {
        MainEventBus.EventUseAttack += CheckStatusAttack;
    }
    private void OnDisable()
    {
        MainEventBus.EventUseAttack -= CheckStatusAttack;
    }

    private void CheckStatusAttack(TypeAttack typeAttack)
    {
        this.typeAttack = typeAttack;
    }

    private async void Update()
    {
        await Task.Delay(500);
        if(typeAttack == TypeAttack.none)
            CheckRayCastCommand(5f);
    }
    private void CheckRayCastCommand(float dist)
    {
        RaycastHit hit;

        if (Physics.Raycast(startPos.position, startPos.forward, out hit, dist, targetLayer))
        {
            IInteractObj interactObj = hit.transform.GetComponent<IInteractObj>();

            if (interactObj == null)
                return;

            UIEvents.NewInteractMessage(interactObj.GetNameAndStatus());

            if(Input.GetKeyDown(KeyCode.E))
            {
                interactObj.Interact();
            }
        }

        else
            UIEvents.NewInteractMessage("");
    }
}
