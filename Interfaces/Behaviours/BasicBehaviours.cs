using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable
{
    void Move();
}

public interface ISpeakable
{
    void Speak(CharacterBase character);
}

public interface ITradable
{
    void Trade(CharacterBase character);
}

