using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pa19
{
    public partial class Form1 : Form
    {
        Club c = new Club();
        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewMem.DataSource = null;
                dataGridViewMem.DataSource = c.lstS;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        DataTable d = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Demarage de l'application ", "Demarer", MessageBoxButtons.OK);
           // dataGridViewMem.DataSource = null;
            d.Columns.Add("Numero Inscription ", typeof(string));
            d.Columns.Add("Nom Complet ", typeof(string));
            dataGridViewMem.DataSource = d;
            c.Ajouter(new Stagiaire("1996 11 05 0035", "Hassan SOUFIANI"));
            c.Ajouter(new Stagiaire("1995 09 15 0002", "imane BARKAOUI"));
            c.Ajouter(new Stagiaire("1996 01 05 0112", "aissam EL KHIATI"));
            c.Ajouter(new Stagiaire("1998 02 13 0190", "Badr MOUBTASSIM"));
            foreach(Stagiaire s in c.lstS)
            {
                d.Rows.Add(s.Numero, s.Nom); 
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
         
            Stagiaire st = new Stagiaire(textNum.Text,textNom.Text);
          
            for (int i = 0; i <c.lstS.Count; i++)
        {
            if(st.Numero==c.lstS[i].Numero)
            {
                c.lstS.RemoveAt(i);
                d.Rows.RemoveAt(i);
                clear();
                break;
            }
            else
            {
                MessageBox.Show("Le numéro d'inscription est introvable !!", "Suprimer", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }
          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Close ther Form ?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d==DialogResult.Cancel)
            {
                e.Cancel = !false;
            }
            if (d==DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                StreamWriter sw = new StreamWriter("D:\\testTDi\\Club de lecture.bin");
                bf.Serialize(sw.BaseStream, c.lstS);
                sw.Close();
            }

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Stagiaire st = new Stagiaire(textNum.Text,textNom.Text);
            for (int i = 0; i <1 ;i++ )
            {
                if (st.Numero != c.lstS[i].Numero)
                {
                    c.lstS.Add(st);
                    d.Rows.Add(st.Numero, st.Nom);
                    clear();
                  
                    
                }
                else {
                    MessageBox.Show("Le Membre existe dija", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
            }
        }
        public void clear ()
        {
            textNom.Text = textNum.Text = "";
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("L'application fermer","Fermer", MessageBoxButtons.OK);
        }

        
    }
}
