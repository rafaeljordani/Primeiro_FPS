using TMPro;
using UnityEngine;

public class ShowTexts : MonoBehaviour
{

    public TextMeshProUGUI points, amunnion, magSize;

    public ManegeMag weapon;

    public MainPoints mainPoints;
    void Start()
    {
        points.text =  mainPoints.points.ToString();
        amunnion.text = weapon.ammunition.ToString();
        magSize.text = weapon.ammunitionTotal.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        points.text = mainPoints.points.ToString();
        amunnion.text = weapon.ammunition.ToString();
        magSize.text = weapon.ammunitionTotal.ToString();
    }
}
