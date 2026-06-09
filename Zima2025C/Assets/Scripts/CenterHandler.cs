using UnityEngine;
using UnityEngine.UI;

public class TopBarHandler : MonoBehaviour
{

    private PlayerController _playerController;
    public Slider HPSlider;
    public Gradient HPColorGradient;
    public Image HPFillImage;

    public Slider SpeedBoostSlider;
    public Gradient SpeedBoostColorGradient;
    public Image SpeedBoostFillImage;

    void Start()
    {
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        _playerController.OnHPChanged += UpdateHPSlider;
        _playerController.OnSpeedChanged += UpdateSpeedBoostSlider;
        UpdateHPSlider();
        UpdateSpeedBoostSlider();
    }

    void UpdateHPSlider()
    {
        HPSlider.value = _playerController.hp / 100;
        HPFillImage.color = HPColorGradient.Evaluate(_playerController.hp / 100);
    }

    void UpdateSpeedBoostSlider()
    {
        SpeedBoostSlider.value = _playerController.speedBoostTimer / 5;
        SpeedBoostFillImage.color = SpeedBoostColorGradient.Evaluate(_playerController.speedBoostTimer / 5);
    }
}