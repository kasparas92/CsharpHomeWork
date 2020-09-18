using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonAndCommandAndObserverPatterns
{
    public class CarCommand : ICommand
    {
        private readonly Car _car;
        private readonly SpeedAction _speedAction;
        private readonly int _amount;
        public CarCommand(Car car, SpeedAction speedAction, int amount)
        {
            _car = car;
            _speedAction = speedAction;
            _amount = amount;
        }
        public void ExecuteAction()
        {
            if (_speedAction == SpeedAction.Increase)
            {
                _car.IncreaseSpeed(_amount);
            }
            else
            {
                _car.DecreaseSpeed(_amount);
            }
        }
    }
}
