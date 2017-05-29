using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Speech.Recognition;



namespace Proyecto
{
    public partial class Form3 : DevComponents.DotNetBar.OfficeForm
    {
        MySqlConnection cn = new MySqlConnection("server = localhost; Uid = root; Password = ;Database = taller_mechanico; Port = 3306");
        MySqlCommand cmd = new MySqlCommand();
        private SpeechRecognitionEngine escuchar = new SpeechRecognitionEngine();

        public Form3()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd.Connection = cn;

            try
            {
                cmd.CommandText = "select count(*) from usuario where Nombre  = '" + usertb.Text + "'and Contraseña = '" + passtb.Text + "'";
                int valor = int.Parse(cmd.ExecuteScalar().ToString());
                if (valor == 1)
                {
                        MessageBox.Show("Bienvenido");
                        cn.Close();
                        Form1 f = new Form1();
                        f.Show();
                        this.Hide();
                }
                else
                    MessageBox.Show("No encontrado");
                cn.Close();
            }
                catch (Exception ex) { MessageBox.Show("error siguiente" + ex); }
            
        }
        

        private void Form3_Load(object sender, EventArgs e)
        { 

        }

        private void Bt_escuchar_Click(object sender, EventArgs e)
        {
            try
            {
                escuchar.SetInputToDefaultAudioDevice();
                escuchar.LoadGrammar(new DictationGrammar());
                escuchar.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(lector);
                escuchar.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("no se puede abrir mas de una vez");
            }
        }
        public void lector(object sender, SpeechRecognizedEventArgs e)
        {
            foreach(RecognizedWordUnit palabra in e.Result.Words)
            {
                usertb.Text = palabra.Text;
     

            }
        }

        // private void bt_escuchar_contra_Click(object sender, EventArgs e)
        //{
        //  try
        //{
        //  escuchar.SetInputToDefaultAudioDevice();
        //escuchar.LoadGrammar(new DictationGrammar());
        //escuchar.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(lectorc);
        //                escuchar.RecognizeAsync(RecognizeMode.Multiple);
        //
        //}
        //      catch (InvalidOperationException)
        //    {
        // MessageBox.Show("no se puede abrir mas de una vez");
        //}
        //    }

        //public void lectorc(object sender, SpeechRecognizedEventArgs e)
        //{
        //  foreach (RecognizedWordUnit palabrac in e.Result.Words)
        //{
        //passtb.Text = palabrac.Text;


        //}
        //}
    }
}
