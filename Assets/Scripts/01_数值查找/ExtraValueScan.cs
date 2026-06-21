using System;
using UnityEngine;
using UnityEngine.UI;

public class ExtraValueScan : MonoBehaviour
{
    private Player _me;

    public Text _hpText;
    public Button _hurtBtn;
    
    public Text _speedText;
    public Slider _speedSlider;
    public Button _addSpeedBtn;
    public Button _subSpeedBtn;
    public float _speedDelta = 0.5f;
    
    private void Awake()
    {
        _me = new Player(nameof(ExtraValueScan), 100);
        
        _hurtBtn.onClick.AddListener(Hurt);
        
        _addSpeedBtn.onClick.AddListener(AddSpeed);
        _subSpeedBtn.onClick.AddListener(SubSpeed);
    }

    private void AddSpeed()
    {
        _me.ChangeSpeed(_speedDelta);
    }
    
    private void SubSpeed()
    {
        _me.ChangeSpeed(-_speedDelta);
    }
    
    private void Update()
    {
        _hpText.text = $"hp: {_me.hp}";
        _speedText.text = $"speed:{_me.speed}";
        
        _speedSlider.value =  _me.speed;
    }

    private void Hurt()
    {
        _me.Hurt(5);
    }
}
