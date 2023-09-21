using Game.UI;
using System;
using System.Diagnostics;
using System.Numerics;

namespace Game.player
{
    public class PlayerController
    {
        private PlayerModel _Model;
        private PlayerView _View;

        private int speed;
        public PlayerController(PlayerView playerView, PlayerModel playerModel,PlayerSO playerSO)
        {
            _Model = playerModel;
            _View = playerView;
            _Model.SetValues(playerSO);
            _Model.SetPlayerController(this);
            _View.SetPlayerController(this);
            speed = _Model.speed;
        }

        public int TakeDamage()
        {
            int damage=_Model.DamageValue;
            int health = _Model.health;
            if (health - damage > 0)
            {
                health -= damage;
                _Model.SetHealth(health);
                return health;
                
            }
            else
            {
                _View.Death();
                return 0;
            }
        }
        public void Death()
        {
            
        }
        public int GetHealth()
        {
            return _Model.health;
        }
        public int GetSpeed()
        {
            return _Model.speed;
        }

        internal void Heal()
        {
            int health=GetHealth();
            if( health< _Model.Maxhealth)
            {
                health+=_Model.HealValue;
            }
        }
    }
}
