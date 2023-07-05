using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BossBeatenText : MonoBehaviour
{
    public Text bossBeatenText;

    private void Start()
    {
        bossBeatenText.enabled = false; // Hide the text initially
        BossEventSystem.instance.onBossesBeaten.AddListener(OnBossesBeaten);
    }

    private void OnDestroy()
    {
        BossEventSystem.instance.onBossesBeaten.RemoveListener(OnBossesBeaten);
    }

    private void OnBossesBeaten()
    {
        bossBeatenText.enabled = true; // Show the text
    }
}