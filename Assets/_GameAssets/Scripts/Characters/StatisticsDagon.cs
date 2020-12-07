﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatisticsDagon : StatisticsCharacter
{
    [Header("SANITY LOSS")]
    [Range(1, 10)]
    public int sanityLoss;
    protected void Awake()
    {
        characterName = "Dagon, Great Old One";
        characterConcept = "Server of Cthulhu";

        constitution = 50;
        dexterity = 20;
        intelligence = 20;
        power = 30;
        size = 60;
        strength = 52;

        fist = 80;
        shot = 40; // uses shot for summoning skills

        damageBonus = strength + size;
        dodge = dexterity * 2;
        hitPointsMax = constitution + size;
        hitPoints = hitPointsMax;
    }
}
