using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public GameActor gameActor = new GameActor();

        private JumpCommand jumpCommand = new JumpCommand();
        private FireCommand fireCommand = new FireCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            jumpCommand.Execute(gameActor);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            fireCommand.Execute(gameActor);
        }
    }
}
