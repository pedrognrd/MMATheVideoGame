﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CombatSkills : MonoBehaviour
{
    protected int ammo; // -1 = infinite
    protected int ammoMax; // -1 = infinite
    protected int attackRoll;
    protected int chargers; // -1 = infinite
    protected int chargersMax; // -1 = infinite
    protected int criticalMod;
    protected int damage; // When the character increase its level, damage will be higer
    protected int damageMax;
    protected int damageMin;
    protected int distance; // When the character increase its level, distance will be higer
    protected int hitEffect; // 0 = none, 1 = bleeding, 2 = move, 3 = stun
    protected int impact;
    protected int kind; // 1 = melee, 2 = range, 3 = magic
    [SerializeField]
    protected GameObject character;

    public GameObject textEvent1;
    public GameObject enemyCharacter;
    public GameObject panelEnemy;

    protected virtual void Awake()
    {
        // Capturing Interactive GameObjects
        textEvent1 = GameObject.Find("TextEvent1");
        panelEnemy = GameObject.Find("PanelEnemy");
    }

    public abstract void Attack();
}
