using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebAplikacijaMovies
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ispolniLista();
        }

        protected void ispolniLista()
        {
            lstFilmovi.Items.Clear();
            SqlConnection kon = new SqlConnection();
            kon.ConnectionString =
                ConfigurationManager.ConnectionStrings["konekcija"].ConnectionString;
            string sqlString = "SELECT film_id, film_ime FROM tblFilmovi";
            SqlCommand komanda = new SqlCommand(sqlString, kon);

            try
            {
                kon.Open();
                SqlDataReader citac = komanda.ExecuteReader();

                while (citac.Read())
                {
                    ListItem element = new ListItem();
                    element.Text = citac["film_ime"].ToString();
                    element.Value = citac["film_id"].ToString();
                    lstFilmovi.Items.Add(element);
                }
                citac.Close();
            }

            catch (Exception err)
            {
                lblPoraka.Text = err.Message;
            }

            finally
            {
                kon.Close();
            }
        }

        protected void lstFilmovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            selektirajFilm(lstFilmovi.SelectedValue);
        }

        protected void selektirajFilm(string id)
        {
            SqlConnection kon = new SqlConnection();
            kon.ConnectionString =
                ConfigurationManager.ConnectionStrings["konekcija"].ConnectionString;
            string sqlString = "SELECT film_id, film_ime, reziser, maska_uloga, zenska_uloga, zanr, godina, vremetraenje FROM tblFilmovi WHERE film_id='" + id + "'";
            SqlCommand komanda = new SqlCommand(sqlString, kon);

            try
            {
                kon.Open();
                SqlDataReader citac = komanda.ExecuteReader();
                if (citac.Read())
                {
                    txtIme.Text = citac["film_ime"].ToString();
                    txtReziser.Text = citac["reziser"].ToString();
                    txtMaskaUloga.Text = citac["maska_uloga"].ToString();
                    txtZenskaUloga.Text = citac["zenska_uloga"].ToString();
                    txtZanr.Text = citac["zanr"].ToString();
                    txtGodina.Text = citac["godina"].ToString();
                    txtVremetraenje.Text = citac["vremetraenje"].ToString();
                    citac.Close();
                }
            }

            catch (Exception err)
            {
                lblPoraka.Text = err.Message;
            }

            finally
            {
                kon.Close();
            }
        }

        protected void btnNovFilm_Click(object sender, EventArgs e)
        {
            txtIme.Text = "";
            txtReziser.Text = "";
            txtMaskaUloga.Text = "";
            txtZenskaUloga.Text = "";
            txtZanr.Text = "";
            txtGodina.Text = "";
            txtVremetraenje.Text = "";
        }

        protected void btnVnesi_Click(object sender, EventArgs e)
        {
            SqlConnection kon = new SqlConnection();
            kon.ConnectionString =
                ConfigurationManager.ConnectionStrings["konekcija"].ConnectionString;
            SqlCommand komanda = new SqlCommand();
            komanda.Connection = kon;
            komanda.CommandText = "INSERT INTO tblFilmovi (film_ime, reziser, maska_uloga, zenska_uloga, zanr, godina, vremetraenje)" +
                        "VALUES (@film_ime, @reziser, @maska_uloga, @zenska_uloga, @zanr, @godina, @vremetraenje)";
            komanda.Parameters.AddWithValue("@film_ime", txtIme.Text);
            komanda.Parameters.AddWithValue("@reziser", txtReziser.Text);
            komanda.Parameters.AddWithValue("@maska_uloga", txtMaskaUloga.Text);
            komanda.Parameters.AddWithValue("@zenska_uloga", txtZenskaUloga.Text);
            komanda.Parameters.AddWithValue("@zanr", txtZanr.Text);
            komanda.Parameters.AddWithValue("@godina", txtGodina.Text);
            komanda.Parameters.AddWithValue("@vremetraenje", txtVremetraenje.Text);

            try
            {
                kon.Open();
                komanda.ExecuteNonQuery();
            }

            catch (Exception err)
            {
                lblPoraka.Text = err.Message;
            }

            finally
            {
                kon.Close();
            }
            ispolniLista();
        }

        protected void btnZacuvaj_Click(object sender, EventArgs e)
        {
            SqlConnection kon = new SqlConnection();
            kon.ConnectionString =
                ConfigurationManager.ConnectionStrings["konekcija"].ConnectionString;
            SqlCommand komanda = new SqlCommand();
            komanda.Connection = kon;
            komanda.CommandText = "UPDATE tblFilmovi SET " + "film_ime='" + txtIme.Text + 
                "', reziser='" + txtReziser.Text + "', maska_uloga='" + txtMaskaUloga.Text + 
                "', zenska_uloga='" + txtZenskaUloga.Text + "', zanr='" + txtZanr.Text + 
                "', godina='" + txtGodina.Text + "', vremetraenje='" + txtVremetraenje.Text + "'" + 
                    "WHERE film_id='" + lstFilmovi.SelectedValue + "'";

            try
            {
                kon.Open();
                komanda.ExecuteNonQuery();
            }

            catch (Exception err)
            {
                lblPoraka.Text = err.Message;
            }

            finally
            {
                kon.Close();
            }

            ispolniLista();
        }

        protected void btnIzbrisi_Click(object sender, EventArgs e)
        {

            if (lstFilmovi.SelectedIndex != -1)
            {
                SqlConnection kon = new SqlConnection();
                kon.ConnectionString =
                    ConfigurationManager.ConnectionStrings["konekcija"].ConnectionString;
                SqlCommand komanda = new SqlCommand();
                komanda.Connection = kon;
                komanda.CommandText = "DELETE FROM tblFilmovi WHERE film_id='" + lstFilmovi.SelectedValue + "'";

                try
                {
                    kon.Open();
                    komanda.ExecuteNonQuery();
                }

                catch (Exception err)
                {
                    lblPoraka.Text = err.Message;
                }

                finally
                {
                    kon.Close();
                }

                ispolniLista();
            }
        }



    }
}