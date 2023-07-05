# Absorber_1.0

## 1. 프로젝트 소개

   장    르 : 뱀서라이크, 핵앤슬래시, 로그라이크

   제작엔진 : 유니티 엔진 (C#)

   간단설명 : 끊임없이 몰려오는 적들로 부터 살아남아야 합니다. 적을 쓰러뜨리면 '마나'를 획득하여 레벨업 할 수 있습니다. 레벨업을 통해 스스로를 강화할 수 있고, 스테이지 마지막에 등장하는 보스몬스터를 쓰러뜨리면 스테이지를 통과할 수 있습니다. 스테이지 클리어 기록 및 점수를 랭킹보드에 등록하여 다른 사람들의 기록과 비교할 수도 있습니다. 
   
   최종수정 : 2023.06.16

   실행방법 : Absorber_1.0.zip 다운로드 및 압축 해제 후 Absrober.exe 실행

   Original Repository : [[Git_Repo]](https://github.com/kookmin-sw/capstone-2023-49).

---
## 2. 플레이 영상
[![Youtube동영상](http://img.youtube.com/vi/gokN30XPb7c/0.jpg)](https://youtu.be/gokN30XPb7c)

이미지 클릭시 유튜브 영상이 재생됩니다.

---
## 3. 게임 이미지

<img src="./referenceImgs/img_00_login.png"  width="320" height="180"/> <img src="./referenceImgs/img_01_lobby.png"  width="320" height="180"/> <img src="./referenceImgs/img_02_tutorial.png"  width="320" height="180"/>
<img src="./referenceImgs/img_03_selectWeapon.png"  width="320" height="180"/> <img src="./referenceImgs/img_04_testWeapon.png"  width="320" height="180"/> <img src="./referenceImgs/img_05_enterStage1.png"  width="320" height="180"/>
<img src="./referenceImgs/img_06_attackEnemy.png"  width="320" height="180"/> <img src="./referenceImgs/img_07_levelup.png"  width="320" height="180"/> <img src="./referenceImgs/img_08_enemies.png"  width="320" height="180"/>
<img src="./referenceImgs/img_09_eliteEnemy.png"  width="320" height="180"/> <img src="./referenceImgs/img_10_strongerEnemy.png"  width="320" height="180"/> <img src="./referenceImgs/img_11_SpawnBoss.png"  width="320" height="180"/>
<img src="./referenceImgs/img_12_SpawnBoss2.png"  width="320" height="180"/> <img src="./referenceImgs/img_13_BossStage.png"  width="320" height="180"/> <img src="./referenceImgs/img_14_Boss2Phase.png"  width="320" height="180"/>
<img src="./referenceImgs/img_15_BossDie.png"  width="320" height="180"/> <img src="./referenceImgs/img_16_ClearStage.png"  width="320" height="180"/> <img src="./referenceImgs/img_17_enterPortal.png"  width="320" height="180"/>
<img src="./referenceImgs/img_18_resultPage.png"  width="320" height="180"/> <img src="./referenceImgs/img_19_ranking.png"  width="320" height="180"/> 

---
## 4. 본인 역할

   1) 기획 총괄 및 Project Management 
      - 팀장으로서 역할 분담 및 업무 지시
      - 개발 규모 결정 및 스케줄 관리
      
   2) 무기 구현
      - 9종류의 무기 컨셉 및 디자인 결정.
      - 적 탐색 및 공격 시스템, 투사체 시스템 구현 (Weapon.cs, Projectile.cs...)
      - 무기 교체, 조준 방식 변경 시스템 구현 
      
   3) 아이템 구현
      - 5종류의 아이템 컨셉 및 디자인 결정.
      - 아이템 획득 방식 결정 및 구현 (DropItem.cs...)
        
   4) 듀토리얼 스테이지 구현
      - 게임 시작 직후 플레이어가 쉽게 조작키, 게임 방식을 익힐 수 있도록 듀토리얼 스테이지 디자인 및 구현 (Stage_000_tutorial.cs)
      
   5) 스테이지 전환 시스템 구현
      - 로비->듀토리얼 스테이지-> 1 스테이지 -> 승리/패배 결과창 -> 로비 간 연결 구현 (Stage.cs, StageManager.cs)
      
   6) 연출 및 효과 시스템 구현
      - 데미지 텍스트, 피격, 타격, 출혈, 아이템 획득, 대쉬 사용 등 다양한 효과 구현(무료 파티클 에셋 사용 및 직접제작, Effect.cs...)
      - 팀원이 제작한 연출 효과의 재생 및 정지를 효과적으로 관리할 수 있는 시스템 구현 (DirectingManager.cs)
       
   7) 풀링시스템 구축
      - 다운로드 받은 무료에셋(Pool)을 개조하여 본 프로젝트 다방면에 적용함. (PoolManger.cs, ProjPoolManager.cs, ItemPoolManager.cs, EffectPoolManager.cs...)
       
   8) 이미지 소스, 애니메이션 제작 및 적용
      - 외부인원과 함께 포토샵, 클립스튜디오 프로그램으로 이미지 제작. 본인은 모든 투사체의 이미지 제작
      - 모든 애니메이션 제작 및 적용 
      
   9) 테스트 환경 구축
      - 효율적인 개발을 위해, 능력치 임의 조작 시스템, 시간 배속 등 여러 기능을 갖춘 테스트 환경 구현
