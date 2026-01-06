using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Games.Monster.State
{
    public class MonsterStateMachine
    {
        public Monster mon;
        public MonsterState monsterState;

        Dictionary<string, MonsterState> statesDic;

        public MonsterStateMachine(Monster monster)
        {
            statesDic = new Dictionary<string, MonsterState>();
            mon = monster;
        }
        public void AddState(string name, MonsterState state)
        {
            state.stateMachine = this;
            state.mon = mon;
            statesDic[name] = state;
        }
        public void ChangeState(string name)
        {
            if (statesDic.ContainsKey(name) == false)
            {
                return;
            }
            if (monsterState != null)
            {
                monsterState.ExitState();
            }
            monsterState = statesDic[name];
            monsterState.StartState();
        }
        public void UpdateState()
        {
            monsterState?.UpdateState();
        }
    }
}
