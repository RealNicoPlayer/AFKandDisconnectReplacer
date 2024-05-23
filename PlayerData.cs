﻿using UnityEngine;

namespace AFKReplacer
{
    internal class PlayerData
    {
        // The last recorded position of the player
        public Vector3 LastPlayerPosition { get; set; } = Vector3.zero;

        // The last recorded rotation of the player
        public Quaternion LastPlayerRotation { get; set; } = Quaternion.identity;

        // How many seconds since the player's rotation has changed
        public int SecondsSinceRotationChange { get; set; } = 0;

        // How many times the player has been despawned
        public int DespawnCount { get; set; } = 0;

    }
}
