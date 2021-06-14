﻿using Controllers;

namespace Commands
{
    public sealed class AutoAttackCommand : ICommand
    {
        private readonly BattleController _controller;

        public AutoAttackCommand(BattleController controller)
        {
            _controller = controller;
        }

        public void Execute()
        {
            _controller.AutoMove();
        }

    }
}
