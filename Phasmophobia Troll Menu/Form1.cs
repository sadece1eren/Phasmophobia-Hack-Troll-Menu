using Swed64;
using System.Diagnostics;
using Memory;
using System.Numerics;
using System;
using System.Reflection;
using System.Security.Cryptography;

namespace Phasmophobia_Troll_Menu
{
    public partial class Form1 : Form
    {
        Swed jhrox;
        IntPtr moduleBase;
        Mem eren = new Mem();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        public void float_cheat()
        {
            jhrox = new Swed("Phasmophobia");
            moduleBase = jhrox.GetModuleBase("UnityPlayer.dll");
            if (checkBox1.Checked)
            {
                jhrox.Nop(moduleBase, 0x115314B, 8);
            }
            else
            {
                jhrox.WriteBytes(moduleBase, 0x115314B, "41 0F 11 86 F0 01 00 00");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int PID = eren.GetProcIdFromName("Phasmophobia");
            if (PID > 0)
            {
                float_cheat();
            }
            else
            {
                if (checkBox1.Checked == false)
                {

                }
                else
                {
                    checkBox1.Checked = false;
                    MessageBox.Show("You Need Open The Game Before Attaching The Cheat !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int PID = eren.GetProcIdFromName("Phasmophobia");
            if (PID > 0)
            {
                label2.Text = "Yep";
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = "Nope";
                label2.ForeColor = Color.Red;
            }
        }

        public void freez()
        {
            jhrox = new Swed("Phasmophobia");
            if (checkBox2.Checked == false)
            {
                jhrox.WriteBytes(moduleBase, 0x102856, "0F 11 12");
            }
            else
            {
                moduleBase = jhrox.GetModuleBase("UnityPlayer.dll");
                if (checkBox2.Checked)
                {
                    jhrox.Nop(moduleBase, 0x102856, 3);
                }
                else
                {
                    jhrox.WriteBytes(moduleBase, 0x102856, "0F 11 12");
                }
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int PID = eren.GetProcIdFromName("Phasmophobia");
            if (PID > 0)
            {
                freez();
            }
            else
            {
                if (checkBox2.Checked == false)
                {

                }
                else
                {
                    checkBox2.Checked = false;
                    MessageBox.Show("You Need Open The Game Before Attaching The Cheat !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void basketball()
        {
            if (string.IsNullOrEmpty(textBox1.Text)) {
                MessageBox.Show("you need to enter input !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int PID = eren.GetProcIdFromName("Phasmophobia");
                string basketball = "GameAssembly.dll+05315E30,D20,1E0,168";
                string basketball2 = "GameAssembly.dll+050D1930,B8,0,28,70,1E0,68";
                eren.OpenProcess(PID);
                eren.WriteMemory(basketball, "int", textBox1.Text);
                eren.WriteMemory(basketball2, "int", textBox1.Text);
                MessageBox.Show("Cheat Injecting. To see the score it is enough to shoot 1 basket.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PID = eren.GetProcIdFromName("Phasmophobia");
            if (PID > 0)
            {
                basketball();
            }
            else
            {
                checkBox2.Checked = false;
                MessageBox.Show("You Need Open The Game Before Attaching The Cheat !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}