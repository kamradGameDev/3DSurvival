using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CharactersData : MonoBehaviour
{
    public static CharactersData instance { get; private set; }
    [SerializeField] private List<CharacterBase> allCharactersInScene;
    public List<CharacterBase> AllCharactersInScene => allCharactersInScene;
    private void Awake()
    {
        if (!instance)
            instance = this;
    }
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);

        allCharactersInScene = FindObjectsOfType<CharacterBase>().ToList();

        allCharactersInScene.Remove(GameManager.instance.Player);
    }
}
