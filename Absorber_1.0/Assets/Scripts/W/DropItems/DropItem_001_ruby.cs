using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//===========================================
// 루비 = 회복템 
//==============================================
public class DropItem_001_ruby : DropItem
{
    //================== 오버라이드 =========================
    // 필수정보 초기화
    //==============================================
    public override void InitEssentialItemInfo()
    {
        id_dropItem = "001";
    }
    
    
    //================== 오버라이드 =========================
    // 회복 아이템  획득 효과 - 플레이어와 충돌시 발동
    //==============================================
    public override void PickupEffect()
    {
        Player.Instance.ChangeHp((int)Player.Instance.Hp_item_up);
    }
}
