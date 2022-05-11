using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image HealthbarTotal;
    [SerializeField] private Image HealthbarCurrent;

    private void Start()
    {
        HealthbarTotal.fillAmount = playerHealth.currentHealth / 10;
    }
    private void Update()
    {
        HealthbarCurrent.fillAmount = playerHealth.currentHealth / 10;
    }
}