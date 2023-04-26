using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    [SerializeField] private Player player;
    public Player Player => player;
    private void Awake()
    {
        if (!instance)
            instance = this;

        //Cursor.lockState = CursorLockMode.Locked;
    }
}
