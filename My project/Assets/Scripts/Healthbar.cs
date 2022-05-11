using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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