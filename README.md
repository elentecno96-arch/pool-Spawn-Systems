# Pool-Spawn=Systems
전체 Pool를 관리하는 Pool매니저와, 몬스터 Spawn을 관리하는 Spawn매니저

적용 디자인 패턴
1. Singleton
적용 클래스 : PoolManager, SpawnManager
설명 : Pool, Spwan을 전체적으로 관리하는 매니저를 싱글톤으로 제공하며 매니저를 통해 관리가 가능

2. Object Pooling
적용 클래스 : projectilePool, MonsterPool
설명 : 자주 생성되고 파괴되는 오브젝트를 재사용합니다

3. Strategy
적용 클래스 : AttackStrategy, DieStrategy, MoveStrategy
설명 : 몬스터의 공격, 죽음, 이동 방식을 독립적인 클래스로 분리하여 새로운 방식이 생성되면 클래스만 추가해 적용할 수 있습니다

4. Prototype
적용 클래스 : IClone<T>, SlimePieces
설명 : 객체 생성 로직을 객체 스스로 (Clone())에 담당하게 합니다

+5. 상태 패턴
MonsterStateMachine을 통해 각 몬스터의 상태의 흐름을 정의
각 상태에 전략패턴을 연결
