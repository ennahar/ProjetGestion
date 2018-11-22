using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaires_prestations
{
    public partial class FormSaisieJoursPrestees : Form
    {
        public FormSaisieJoursPrestees()
        {
            InitializeComponent();
            /////////////////////////////////////////////////////////////////////////////
            ///////connexion à la base sql "ProjetGestion"/////////////
            ///////////////////////////////////////////////////////////////////////////
            string ChaineConnet = "data source=.\\SQLEXPRESS; integrated security=true;Initial catalog=ProjetGestion";
            SqlConnection sqlconn = new SqlConnection(ChaineConnet);
            sqlconn.Open(); //ouverture connexion////
            ////requete a utiliser pour remplissage de la combo liste des utilisateurs///
            ////////////////////////////////////////////////////////////////////////
            string s2sql = @"select u_nom from Utilisateur";
            SqlCommand cmd1;
            cmd1 = new SqlCommand(s2sql, sqlconn);
            SqlDataReader DataRead;
            DataRead = cmd1.ExecuteReader();

            while (DataRead.Read())
            {

                comboBoxListUtilisateur.Items.Add(DataRead["u_nom"].ToString()) ;

            }
            sqlconn.Close();//fermeture connexion////
            sqlconn.Open();
            string ssql = @"select p_code , p_desc from Projet";
            SqlCommand cmd2;
            cmd2 = new SqlCommand(ssql, sqlconn);
            SqlDataReader DataRead1;
            DataRead1 = cmd2.ExecuteReader();

            while (DataRead1.Read())
            {

                comboBoxNomProjet.Items.Add(DataRead1["p_code"].ToString()+" "+DataRead1["p_desc"].ToString());

            }
            sqlconn.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string sSQL;
            string ChaineConnet = "data source=.\\SQLEXPRESS;integrated security=true;Initial catalog=ProjetGestion";
            SqlConnection sqlconn = new SqlConnection(ChaineConnet);
            SqlCommand cmd;           
            // Représente une connexion à une base de données SQL Server
            // Ouverture de la connexion
            sqlconn.Open();
            // Requete à utiliser pour verifier l existence de l enregistrement dans la table HP///
            sSQL = @"select * from  HP where ( 
                                        hp_codeU=@code AND
                                        hp_date=@date AND
                                        hp_codeP=@codeP)";
            cmd = new SqlCommand(sSQL, sqlconn);
            // Passage de parametres
            cmd.Parameters.Add("@code",SqlDbType.VarChar,5);
            cmd.Parameters.Add("@date", SqlDbType.Date);
            cmd.Parameters.Add("@codeP", SqlDbType.VarChar, 5);
            // affectation des valeurs ///
            cmd.Parameters["@code"].Value = comboBoxListUtilisateur.Text;
            cmd.Parameters["@date"].Value = DateSaisieJP.Text;
            cmd.Parameters["@codeP"].Value = comboBoxNomProjet.Text.Substring(0,5);
            int nbrEnregHP = cmd.ExecuteNonQuery();
            MessageBox.Show(nbrEnregHP.ToString());
            //sqlconn.Close();
            //if (nbrEnregHP==1) //
            //{
            //    MessageBox.Show("attention heures Prestées déjà entrées !");
            //}
            //else
            //{

            //}



        }
    }
}
