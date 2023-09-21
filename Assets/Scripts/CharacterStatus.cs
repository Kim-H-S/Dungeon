using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CharacterStatus
{
    [Range(0, 100)] public float attck;
    [Range(0, 100)] public float defence;
    [Range(0, 1000)] public float health;
    [Range(0, 100)] public float critical;
}
