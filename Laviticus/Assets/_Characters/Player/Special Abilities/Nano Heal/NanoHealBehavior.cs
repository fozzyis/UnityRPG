﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Character
{
    public class NanoHealBehavior : SpecialAbilityBehaviour
    {
        Player player;



        public override void Engage(AbilityUseParams useParams)
        {

            player.AddHealth((config as NanoHealConfig).GetHealAmount());
            PlayAbilitySound();
            PlayParticleEffect();


        }



        void Start()
        {
            player = GetComponent<Player>();

        }

    }
}