using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SharedCodeSnippet : MonoBehaviour
{
    private Player _me;
    private Player _enemy;

    public Text _meHp;
    public Button _meHurtBtn;

    public Text _enemyHp;
    public Button _enemyHurtBtn;

    private void Awake()
    {
        _me = new Player("我方", 100);
        _enemy = new Player("敌方", 100, 1);

        _meHurtBtn.onClick.AddListener(() => HurtBtnCallBack(_me));
        _enemyHurtBtn.onClick.AddListener(() => HurtBtnCallBack(_enemy));
    }
    
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HurtBtnCallBack(Player player)
    {
        player.Hurt(5);
    }

    private void Update()
    {
        _meHp.text = $"meHp:{_me.hp}";
        _enemyHp.text = $"enemyHp:{_enemy.hp}";
    }
}