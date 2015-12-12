using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class JumpCommand : ICommand
    {
        public void Execute(GameActor actor)
        {
            actor.Jump();
            //MessageBox.Show("Jump");
        }
    }
}
