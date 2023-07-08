# Absorber_1.0
---
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

   ##### 1) 기획 총괄 및 Project Management 
      팀장으로서 역할 분담 및 업무 지시
      개발 규모 결정 및 스케줄 관리
      
   ##### 2) 무기 구현
      9종류의 무기 컨셉 및 디자인 결정.
      적 탐색 및 공격 시스템, 투사체 시스템 구현 (Weapon.cs, Projectile.cs...)
      무기 교체, 조준 방식 변경 시스템 구현 
      
   ##### 3) 아이템 구현
      5종류의 아이템 컨셉 및 디자인 결정.
      아이템 획득 방식 결정 및 구현 (DropItem.cs...)
        
   ##### 4) 듀토리얼 스테이지 구현
      게임 시작 직후 플레이어가 쉽게 조작키, 게임 방식을 익힐 수 있도록 듀토리얼 스테이지 디자인 및 구현 (Stage_000_tutorial.cs)
      
   ##### 5) 스테이지 전환 시스템 구현
      로비->듀토리얼 스테이지-> 1 스테이지 -> 승리/패배 결과창 -> 로비 간 연결 구현 (Stage.cs, StageManager.cs)
      
   ##### 6) 연출 및 효과 시스템 구현
      데미지 텍스트, 피격, 타격, 출혈, 아이템 획득, 대쉬 사용 등 다양한 효과 구현(무료 파티클 에셋 사용 및 직접제작, Effect.cs...)
      팀원이 제작한 연출 효과의 재생 및 정지를 효과적으로 관리할 수 있는 시스템 구현 (DirectingManager.cs)
       
   ##### 7) 풀링시스템 구축
      다운로드 받은 무료에셋(Pool)을 개조하여 본 프로젝트 다방면에 적용함. (PoolManger.cs, ProjPoolManager.cs, ItemPoolManager.cs, EffectPoolManager.cs...)
       
   ##### 8) 이미지 소스, 애니메이션 제작 및 적용
      외부인원과 함께 포토샵, 클립스튜디오 프로그램으로 이미지 제작. 본인은 모든 투사체의 이미지 제작
      모든 애니메이션 제작 및 적용 
      
   ##### 9) 테스트 환경 구축
      효율적인 개발을 위해, 능력치 임의 조작 시스템, 시간 배속 등 여러 기능을 갖춘 테스트 환경 구현

---
## 5. 개선점

   시간 부족으로 인해 구현하지 못하고 빠뜨린 기능들을 Absorber_2.0 에서 구현하기 위해 개선점을 기록함.
   
   개선점들은 [[Absorber_2.0]](https://github.com/gotkagovkfl/Absorber_2.0) 에 반영되고, 추가 개선점들은 이슈에 기록됨
   
   ##### 1) 스프라이트 해상도 문제 해결
      현재 대부분의 이미지의 해상도가 1024*1024 이상이어서 자원 관리에 취약한 상태이기 때문에,
      최적화를 위해 해상도를 줄이면서 품질을 유지하는 작업이 필요하다. 
   ##### 2) 아틀라스 이미지 사용
      현재 모든 애니메이션에 사용되는 스프라이트가 프레임 별로 단일 파일로 되어있기 때문에,
      드로우콜을 줄이기 위해 이들을 아틀라스 이미지로 묶는 작업이 필요하다.

   ##### 3) 이펙트 직접 제작
      현재는 무료 에셋을 사용하였으나, 추후 상업적 이용 관련해서 문제 발생을 막기 위해 vfx를 직접 제작해보자.
   ##### 4) 연출 최적화
      시간 부족으로 인해 연출 관련 코드가 최적화가 안되어 있기 때문에, 최적화 작업이 필요하다. 
   ##### 5) 쉐이더 사용
      시간 부족으로 쉐이더에 대한 연구를 진행하지 못하였다.
   ##### 6) 명령 패턴 사용
      사용자 설정으로 키변경 추가 등을 위해 이동, 공격 등 행동에 대한 명령 패턴을 추가해보자. 
   ##### 7) 캡슐화
      현재 빠른 개발을 위해 대부분의 변수들이 public 인데, oop에 적합하도록 코드를 다시 작성해야 한다.
   #### 8) ScriptableObject 사용
      적 능력치와 같은 데이터들을 scriptableobject를 사용해보자
   #### 9) addressable 에셋 시스템 사용
      기존 Resource 를 이용하는 방법은 로딩 시간 문제 등 단점이 많다고 하니, 개선된 방법을 사용해보자.

      
