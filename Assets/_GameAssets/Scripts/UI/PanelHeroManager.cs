﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class PanelHeroManager : MonoBehaviour
{
    private Text textName;
    private Text textConcept;
    private Text textHitPoints;
    private Text textSanityPoints;
    private int hitPoints; 
    private int hitPointsMax;
    private int sanity; 
    private int sanityMax;


    private void Start()
    {
        // Capture Hero statistics
        LoadingStatistics();
    }

    public void LoadingStatistics() 
    {
        textName = GameObject.Find("HeroName").GetComponent<Text>();
        textName.text = GameObject.Find("BlueGhost").GetComponent<StatisticsBlueGhost>().characterName;
        textConcept = GameObject.Find("HeroConcept").GetComponent<Text>();
        textConcept.text = GameObject.Find("BlueGhost").GetComponent<StatisticsBlueGhost>().characterConcept;

        hitPoints = GameObject.Find("BlueGhost").GetComponent<StatisticsBlueGhost>().hitPoints;
        hitPointsMax = GameObject.Find("BlueGhost").GetComponent<StatisticsBlueGhost>().hitPointsMax;
        sanity = GameObject.Find("BlueGhost").GetComponent<StatisticsBlueGhost>().sanity;
        sanityMax = GameObject.Find("BlueGhost").GetComponent<StatisticsBlueGhost>().sanityMax;
        textHitPoints = GameObject.Find("HeroHitPoints").GetComponent<Text>();
        textSanityPoints = GameObject.Find("HeroSanityPoints").GetComponent<Text>();
        textHitPoints.text = hitPoints + "/" + hitPointsMax;
        textSanityPoints.text = sanity + "/" + sanityMax;
    }
}