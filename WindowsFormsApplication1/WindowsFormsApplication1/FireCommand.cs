using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class FireCommand : ICommand
    {
        public void Execute(GameActor actor)
        {
            actor.Fire();
            //MessageBox.Show("Fire");
        }
    }
}
