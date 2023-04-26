using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using AYellowpaper;
using DG.Tweening;
using Cysharp.Threading.Tasks;

public class PickUpObj : MonoBehaviour, IInteractObj
{
    private bool pickUpPlayer = false;

    [RequireInterface((typeof(IPickUpObj)))]
    [SerializeField] private UnityEngine.Object dropObj;
    private void Start()
    {
        dropObj = RandomDrop(dropObj);
    }

    private UnityEngine.Object RandomDrop(UnityEngine.Object item)
    {
        return Instantiate(item);
    }

    public async void Interact()
    {
        if (pickUpPlayer)
            return;

        pickUpPlayer = true;

        EquipItemBase item = dropObj as EquipItemBase;

        Debug.Log(item);

        item.PickUpItem();

        MainEventBus.EquipItemPlayerItem(item);

        await transform.DOScale(new Vector3(1.2f, 1.2f, 1.2f), 0.5f).AsyncWaitForCompletion();

        await transform.DOScale(Vector3.zero, 0.5f).AsyncWaitForCompletion();

        gameObject.SetActive(false);
    }

    public string GetNameAndStatus()
    {
        return dropObj.ToString();
    }

    public IHealth GetHealth()
    {
        return null;
    }
}
