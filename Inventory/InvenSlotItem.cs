using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InvenSlotItem : MonoBehaviour
{
    [SerializeField] private Image slotImg;

    [SerializeField] private TextMeshProUGUI countItems;

    public bool AddItem(EquipItemBase equipItem)
    {
        if (slotImg.sprite == null)
        {
            slotImg.sprite = equipItem.Icon;
            countItems.text = "1";
            //добавить сохранение
            return true;
        }
        else if(slotImg.sprite != null && slotImg.sprite == equipItem.Icon)
        {
            int count = int.Parse("countItems");
            count++;
            countItems.text = count.ToString();
            //добавить сохранение
            return true;
        }

        return false;
    }

    public void RemoveItem()
    {
        slotImg.sprite = null;
        countItems.text = "";
    }
}
