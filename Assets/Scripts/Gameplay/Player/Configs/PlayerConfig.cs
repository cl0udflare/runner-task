﻿using UnityEngine;

namespace Gameplay.Player.Configs
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Runner/Player")]
    public class PlayerConfig : ScriptableObject
    {
        public PlayerController Prefab;
        public PlayerStats Stats;
        [Space]
        public float LaneOffset = 3f;
    }
}