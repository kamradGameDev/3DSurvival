using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractMessage : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private void Start()
    {
        UIEvents.EventInteractMessage += CheckNewText;
    }
    private void CheckNewText(string message)
    {
        text.text = message;
    }
}
