using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VeriTabanıProje
{
    class KullanicilarBaglanti
    {
        
        public Kullanicilar getKullanicilar(string kullanici_ad, string kullanici_sifre,string yetki_ad)
        {

            Kullanicilar kullanici = null;
            //Departman şartını bağla
            using (var conn = Database.GetConnection())
            {
                var command = new SqlCommand("Select yetki_id from kullanicilar where (kullanici_ad='" + kullanici_ad + "'and kullanici_sifre='" + kullanici_sifre + "') and  yetki_id =(select yetki_id from yetki where yetki_ad='" + yetki_ad + "') and kullanici_id in (select personel_id from personel where departman_id=(select departman_id from departman where departman_ad='Üretim ve Planlama'))");

                command.Connection = conn;
                conn.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kullanici = new Kullanicilar();
                        
                        kullanici.yetki_id = reader.GetInt32(0);
                    }
                    
                }
                conn.Close();
            }
            return kullanici;
        }

        public DataTable getUretimPersonelList()
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {
                var command = new SqlCommand("Select personel_id,personel_ad,personel_soyad,personel_tel,personel_mail from Personel where departman_id=3 and personel_id in(Select personel_id from Kullanicilar where yetki_id=1)");
                
                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public DataTable getUretimPersonelList(string personel_ad, string personel_soyad)
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {
                var command = new SqlCommand("Select personel_id,personel_ad,personel_soyad,personel_tel,personel_mail from Personel where personel_ad='"+personel_ad+"' and personel_soyad='"+personel_soyad+"'(Select personel_ad,personel_soyad from Personel where departman_id=3 and personel_id in(Select personel_id from Kullanicilar where yetki_id=1))");

                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public DataTable getUretimPersonelAdSoyadList(string personel_ad, string personel_soyad)
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {
                var command = new SqlCommand("Select personel_id ,personel_ad,personel_soyad from Personel where personel_ad='" + personel_ad + "'and personel_soyad='" + personel_soyad + "'(Select personel_ad,personel_soyad from Personel where departman_id=3 and personel_id in(Select personel_id from Kullanicilar where yetki_id=1))");

                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public DataTable getUretimSiparislList()
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {
                var command = new SqlCommand("Select * from Uretim");

                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public DataTable getUretimSiparisGuncelle(string uretim_adet,string urun_id,string uretim_id)
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {
                var command = new SqlCommand("update Uretim set uretim_adet='"+uretim_adet+"' where urun_id='"+urun_id+"' and uretim_id = '"+uretim_id+"'");



                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            return dt;

        }
        public DataTable getUretimSiparisGirisGuncelle(string uretim_adet, string urun_id)
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {
                var command = new SqlCommand("update Uretim set uretim_adet='" + uretim_adet + " where urun_id='" + urun_id + "'");



                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            return dt;

        }

        public DataTable getUretimSiparisEkle(string uretim_adet, string urun_id)
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {
                var command = new SqlCommand("insert into Uretim  (uretim_adet,urun_id) values ('" + uretim_adet + "' ,'" + urun_id + "')");


                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            return dt;

        }
        public DataTable getUretimUretilenUrunEkle(string uretim_adet, string uretim_tarihi, string urun_id)
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {
                var command = new SqlCommand("insert into Uretim (uretim_adet,uretim_tarihi,urun_id) values ('" + uretim_adet + "','" + uretim_tarihi + "','" + urun_id + "')");
                

                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            return dt;

        }
        public DataTable getUretimUretilecekBilgiList()
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {
                var command = new SqlCommand("select * from Uretim");

                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            return dt;

        }

        public DataTable getUretimUretilecekUrunBilgiList()
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {
                var command = new SqlCommand("select n.urun_id,urun_ad,urun_miktar,n.hammadde_id,hammadde_miktar,urun_aciklama , uretim_adet from Urun n  , Uretim m where n.urun_id= m.urun_id and uretim_tarihi is null ");

                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            return dt;

        }

        public DataTable getUretimHammaddeBilgiList()
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {
                var command = new SqlCommand("select * from Hammadde");

                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                
                conn.Close();
            }
            return dt;


        }

        public DataTable getUretimFazlaUrunStokKayıt(int fazlaUrun ,string urun_id)
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {
                var command = new SqlCommand("update Urun set urun_miktar="+fazlaUrun+" where urun_id='"+urun_id+"'");

                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);

                conn.Close();
            }
            return dt;


        }
        public DataTable getUretimHammaddeGuncelle(string hammadde_id, string hammadde_miktar)
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {
                var command = new SqlCommand("update Hammadde set hammadde_miktar=" + hammadde_miktar + "where hammadde_id=" + hammadde_id);

                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            return dt;

        }
        //eksik hammadde miktar talebi mesajla iletilecek
        /*public DataTable getEksikHammadeMiktarTalep(int eksikHammadde, string hammadde_id)
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {
                
                var command = new SqlCommand("insert into Alım (hammadde_id , alim_adet) values (" + hammadde_id+","+eksikHammadde+")");

                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            return dt;


        }*/
        public DataTable getEksikHammadeMiktarTalep(int eksikHammadde, string hammadde_id)
        {
            DataTable dt = null;
            using (var conn = Database.GetConnection())
            {

                var command = new SqlCommand("select hammadde_id , hammadde_ad from Hammadde where hammadde_id ="+hammadde_id);

                command.Connection = conn;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            return dt;


        }
        
        public  DataTable KayitSil(int uretim_id)
        {
            DataTable dt = null;
            
            using (var conn = Database.GetConnection())
            {

                var command = new SqlCommand("DELETE FROM Uretim WHERE uretim_id="+uretim_id);

                command.Connection = conn;      
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }
    }

}
