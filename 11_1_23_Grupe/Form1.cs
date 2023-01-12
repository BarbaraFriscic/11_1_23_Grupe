using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_1_23_Grupe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gbxUnosUcenika.Enabled = false;
        }
        //GLOBALNE VARIJABLE
        List<Ucenik> Ucenici = new List<Ucenik>();
        Ucenik u;    
        int brUcenika;

        //ODREĐIVANJE VELIČINE GRUPE
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                brUcenika = Convert.ToInt32(txtbrUcenika.Text);
                gbxStvaranjeGrupe.Enabled = false;
                gbxUnosUcenika.Enabled = true;
                txtIme.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Molimo unesite broj!");
            }   
        }
        //UNOS NOVOG UČENIKA
        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {   //PROVJERA JE LI GRUPA POPUNJENA
                if (Ucenici.Count() < brUcenika)
                { 
                    u = new Ucenik(txtIme.Text, txtPrezime.Text, Convert.ToInt32(txtOIB.Text));    

                    for (int i = 0; i < Ucenici.Count(); i++)   //PROVJERA OIB-a
                    {
                        if(u.Oib == Ucenici[i].Oib)
                        {
                            throw new ArgumentException();
                        }  
                    }
                    Ucenici.Add(u);
                    lstUcenici.Items.Add(u);

                    txtIme.Clear();
                    txtPrezime.Clear();
                    txtOIB.Clear();
                    txtIme.Focus();

                }
                else
                {
                    MessageBox.Show("Grupa je popunjena!");
                    txtIme.Enabled = false;
                    txtPrezime.Enabled = false;
                    txtOIB.Enabled = false;
                    btnUnesi.Enabled = false;
                }
                    
            }
            catch (FormatException)
            {

                MessageBox.Show("Sva polja su obvezna!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Već postoji učenik s tim OIB-om!");
            }
        }
        private void lstUcenici_SelectedIndexChanged(object sender, EventArgs e) //PRIKAZ PODATAKA ZA IZABRANOG UČENIKA
        {
            Ucenik temp = (Ucenik)lstUcenici.SelectedItem;
            txtIme.Text = temp.Ime; 
            txtPrezime.Text = temp.Prezime;
            txtOIB.Text = Convert.ToString(temp.Oib);
        }
    }
}
