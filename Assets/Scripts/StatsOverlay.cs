using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatsOverlay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI speedText;
    [SerializeField] private TextMeshProUGUI staminaText;
    [SerializeField] private TextMeshProUGUI biteDamageText;
    [SerializeField] private TextMeshProUGUI jumpPowerText;
    [SerializeField] private TextMeshProUGUI specialAbilitiesText;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
    }

    public void DisplayStats(Animal animal)
    {
        nameText.text = "Name: " + animal.AnimalName;
        healthText.text = "Health: " + animal.Health;
        speedText.text = "Speed: " + animal.Speed;
        staminaText.text = "Stamina: " + animal.Stamina;
        biteDamageText.text = "Bite Damage: " + animal.BiteDamage;
        jumpPowerText.text = "Jump Power: " + animal.JumpPower;
    }

    public void DisplaySpecialAbilities(List<string> abilities)
    {
        specialAbilitiesText.text = "";

        foreach (string ability in abilities)
        {
            specialAbilitiesText.text += ability + "\n";
        }
    }
}
