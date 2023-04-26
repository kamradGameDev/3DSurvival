using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;
using AYellowpaper;

public class WeaponControl : MonoBehaviour
{
    [SerializeField] private MeshFilter meshFilter;
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private Transform parentCharacter;
    private IEquipWeaponType equipItem;

    private bool statusAttack = false;
    private void OnEnable ()
    {
        MainEventBus.PickUpItemEvent += CheckStatusNewEquipWeapon;
    }

    private void OnDisable()
    {
        MainEventBus.PickUpItemEvent -= CheckStatusNewEquipWeapon;
    }

    private void CheckStatusNewEquipWeapon(UnityEngine.Object item)
    {
        //здесь баги

        //UnityEngine.Object itemObject = Instantiate(item);

        //equipItem = itemObject as IEquipWeaponType;

        //Debug.Log(equipItem);

        //meshFilter.name = equipItem.item.name;

        //if (equipItem != null)
        //{
        //    meshFilter.transform.parent.localPosition = equipItem.localPos;
        //    meshFilter.transform.localEulerAngles = equipItem.angles;

        //    meshFilter.mesh = equipItem.mesh;

        //    meshRenderer.sharedMaterials = equipItem.materials;
        //}
    }

    private async void Update()
    {
        if (equipItem == null)
            return;

        if (meshFilter.mesh != null && Input.GetMouseButtonDown(0) && !statusAttack)
        {
            statusAttack = true;

            MainEventBus.UseRaycast(TypeRaycast.damageItem, equipItem.DistAttack);

            //equipItem.AttackAnimation(weapon: transform, TypeAttack.normal);
 
            await Task.Delay(equipItem.GetTimeAnimation());

            statusAttack = false;
            MainEventBus.UseAttack(TypeAttack.none);
        }
    }

    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.red;

    //    Gizmos.DrawSphere(transform.position + transform.forward / 2f, .2f);

    //    Physics.OverlapSphere(transform.position, 3f);
    //}
}
