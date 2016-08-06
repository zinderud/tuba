//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;
using AnaEkran.Helpers;
using AnaEkran.Properties;
using AnaEkran.Provider;
using System.Collections.ObjectModel;
using AnaEkran.Views.Raporlar;
using AnaEkran.Views.Raporlar.Personel;
using Zinde.Xpf.Printing;
using Zinde.XtraReports.UI;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_PERSONELViewModel  : ViewModelDetailBase<TBL_PERSONELViewModel, TBL_PERSONEL_MODEL> 
    {
	  
		
	 public void Baslangic()
     {
         PersonelYetkirCollection = _PersonelYetkisiListesi.PersonelYetkiObservableCollection;
     }

     private string sifre;

     public string Sifre
     {
         get { return sifre; }
         set { sifre = value; NotifyPropertyChanged(m=>m.Sifre);}
     }

	    public void giris()
	    {
	        try
	        {
                if (Sifre == null || ProppersonelSecilen.SIFRE==null)
	            {
	                MessageBox.Show("Personel secilmedi");
	            }

                if (Sifre == ProppersonelSecilen.SIFRE)
                {

                    Messenger.Default.Send<KullaniciGirisMesaj>(
              new KullaniciGirisMesaj() { Mesaj = "Baþarýlý", MesajTblPersonel = ProppersonelSecilen });
                }
                else
                {
                    MessageBox.Show(Resources.TBL_PERSONELViewModel_giris_Hatalý_þifre_girdiniz_Tekrar_deneyiniz);
                }
	        }
	        catch (Exception ex)
	        {

	            MessageBox.Show("hata");
	        }
	       
	    }

        #region Personel Yetki
        //<zinderud:GridViewComboBoxColumn      ItemsSource="{Binding  DurumlarCollection}"  IsFilterable="True" IsReadOnly="False" 
        //    x:Name="DEPO_ONAYColumn" Width="Auto"  Header="DEPO ONAY" DataMemberBinding="{Binding DEPO_ONAY}" SelectedValueMemberPath="Durum" DisplayMemberPath="Durum"   
        //DurumlarCollection = _durumListesi.DurumcObservableCollection;
        PersonelYetkisiListesi _PersonelYetkisiListesi = new PersonelYetkisiListesi();

        private ObservableCollection<PersonelYetki> _PersonelYetkirCollection;

        public ObservableCollection<PersonelYetki> PersonelYetkirCollection
        {
            get { return _PersonelYetkirCollection; }
            set
            {
                _PersonelYetkirCollection = value;
                NotifyPropertyChanged(m => m.PersonelYetkirCollection);
            }
        }
        #endregion

	    public void RaporPersonelListe()
	    {
	        try
	        {
                DataSet dataSet1 = new DataSet();
                dataSet1.DataSetName = "PersonelListesiRapor";
                DataTable dataTable1 = new DataTable();

                dataSet1.Tables.Add(dataTable1);

                dataTable1.TableName = "Table";

                dataTable1.Columns.Add("ID", typeof(string));

                dataTable1.Columns.Add("AD_SOYAD", typeof(string));

                dataTable1.Columns.Add("YETKI SEVIYESI", typeof(string));

                dataTable1.Columns.Add("SIFRE", typeof(string));

                dataTable1.Columns.Add("BARKOD", typeof(string));

                dataTable1.Columns.Add("GOREVI", typeof(string));

                dataTable1.Columns.Add("TELEFON1", typeof(string));

                dataTable1.Columns.Add("TELEFON2", typeof(string));

                dataTable1.Columns.Add("MAIL", typeof(string));

                dataTable1.Columns.Add("CALISMA_DURUMU", typeof(string));

                dataTable1.Columns.Add("ISE_BASLAMA_TARIHI", typeof(string));

                dataTable1.Columns.Add("ISTEN_AYRILMA_TARIHI", typeof(string));

                dataTable1.Columns.Add("ISE_GELIS_SAATI", typeof(string));

                dataTable1.Columns.Add("ISTEN_CIKIS_SAATI", typeof(string));

                dataTable1.Columns.Add("SSK_NO", typeof(string));

                dataTable1.Columns.Add("CINSIYET", typeof(string));

                dataTable1.Columns.Add("KIMLIK_NO", typeof(string));

                dataTable1.Columns.Add("DOGUM_TARIHI", typeof(string));

                dataTable1.Columns.Add("DOGUM_YERI", typeof(string));

                dataTable1.Columns.Add("EGITIM_DURUMU", typeof(string));

                dataTable1.Columns.Add("ACIKLAMA", typeof(string));

                dataTable1.Columns.Add("AYAKKABI_NO", typeof(string));

                dataTable1.Columns.Add("GOMLEK_NO", typeof(string));

                dataTable1.Columns.Add("MONT_NO", typeof(string));

                dataTable1.Columns.Add("PANTOLON_NO", typeof(string));

                dataTable1.Columns.Add("YEDEK", typeof(string));

	            foreach (var k in ProppersonelListe)
	            {
	                dataTable1.Rows.Add(new Object[]
	                {

	                    k.TBL_PERSONEL_ID,

	                    k.PERSONEL_AD_SOYAD,

	                    k.YETKI_SEVIYESI,

	                    k.SIFRE,

	                    k.BARKOD_ID,

	                    k.PERSONEL_GOREVI,

	                    k.PERSONEL_TELEFON1,

	                    k.PERSONEL_TELEFON2,

	                    k.PERSONEL_MAIL,

	                    k.PERSONEL_CALISMA_DURUMU,

	                    k.PERSONEL_ISE_BASLAMA_TARIHI,

	                    k.PERSONEL_ISTEN_AYRILMA_TARIHI,

	                    k.PERSONEL_ISE_GELIS_SAATI,

	                    k.PERSONEL_ISTEN_CIKIS_SAATI,

	                    k.PERSONEL_SSK_NO,

	                    k.PERSONEL_CINSIYET,

	                    k.PERSONEL_KIMLIK_NO,

	                    k.PERSONEL_DOGUM_TARIHI,

	                    k.PERSONEL_DOGUM_YERI,

	                    k.PERSONEL_EGITIM_DURUMU,

	                    k.PERSONEL_ACIKLAMA,

	                    k.PERSONEL_AYAKKABI_NO,

	                    k.PERSONEL_GOMLEK_NO,

	                    k.PERSONEL_MONT_NO,

	                    k.PERSONEL_PANTOLON_NO,

	                    k.YEDEK,


	                });
	            }
	            RaporPersonelListesi report = new  RaporPersonelListesi();
report.DataSource = dataSet1;
report.DataMember = dataTable1.TableName;
	 
//_tBL_PERSONEL_ID
report.xrTableCell1.DataBindings.Add("Text", null, dataTable1.Columns[0].Caption);
report.xrLabel1.Text = dataTable1.Columns[0].ColumnName;

	 
//_pERSONEL_AD_SOYAD
report.xrTableCell2.DataBindings.Add("Text", null, dataTable1.Columns[1].Caption);
report.xrLabel2.Text = dataTable1.Columns[1].ColumnName;

////_pERSONEL_SSK_NO
report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[14].Caption);
report.xrLabel3.Text = dataTable1.Columns[14].ColumnName;
//_yETKI_SEVIYESI
//report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[2].Caption);
//report.xrLabel3.Text = dataTable1.Columns[2].ColumnName;

////_pERSONEL_KIMLIK_NO
report.xrTableCell4.DataBindings.Add("Text", null, dataTable1.Columns[16].Caption);
report.xrLabel4.Text = dataTable1.Columns[16].ColumnName;
//_sIFRE
//report.xrTableCell4.DataBindings.Add("Text", null, dataTable1.Columns[3].Caption);
//report.xrLabel4.Text = dataTable1.Columns[3].ColumnName;


////_pERSONEL_ISE_BASLAMA_TARIHI
report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[10].Caption);
report.xrLabel6.Text = dataTable1.Columns[10].ColumnName;
//_bARKOD_ID
//report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[4].Caption);
//report.xrLabel5.Text = dataTable1.Columns[4].ColumnName;

	 
//_pERSONEL_GOREVI
report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[5].Caption);
report.xrLabel5.Text = dataTable1.Columns[5].ColumnName;

	 
//_pERSONEL_TELEFON1
report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
report.xrLabel7.Text = dataTable1.Columns[6].ColumnName;
////_pERSONEL_SSK_NO
//report.xrTableCell15.DataBindings.Add("Text", null, dataTable1.Columns[14].Caption);
//report.xrLabel15.Text = dataTable1.Columns[14].ColumnName;
////_pERSONEL_KIMLIK_NO
//report.xrTableCell17.DataBindings.Add("Text", null, dataTable1.Columns[16].Caption);
//report.xrLabel17.Text = dataTable1.Columns[16].ColumnName;

	 
////_pERSONEL_TELEFON2
//report.xrTableCell8.DataBindings.Add("Text", null, dataTable1.Columns[7].Caption);
//report.xrLabel8.Text = dataTable1.Columns[7].ColumnName;

	 
////_pERSONEL_MAIL
//report.xrTableCell9.DataBindings.Add("Text", null, dataTable1.Columns[8].Caption);
//report.xrLabel9.Text = dataTable1.Columns[8].ColumnName;

	 
////_pERSONEL_CALISMA_DURUMU
//report.xrTableCell10.DataBindings.Add("Text", null, dataTable1.Columns[9].Caption);
//report.xrLabel10.Text = dataTable1.Columns[9].ColumnName;

	 
////_pERSONEL_ISE_BASLAMA_TARIHI
//report.xrTableCell11.DataBindings.Add("Text", null, dataTable1.Columns[10].Caption);
//report.xrLabel11.Text = dataTable1.Columns[10].ColumnName;

	 
////_pERSONEL_ISTEN_AYRILMA_TARIHI
//report.xrTableCell12.DataBindings.Add("Text", null, dataTable1.Columns[11].Caption);
//report.xrLabel12.Text = dataTable1.Columns[11].ColumnName;

	 
////_pERSONEL_ISE_GELIS_SAATI
//report.xrTableCell13.DataBindings.Add("Text", null, dataTable1.Columns[12].Caption);
//report.xrLabel13.Text = dataTable1.Columns[12].ColumnName;

	 
////_pERSONEL_ISTEN_CIKIS_SAATI
//report.xrTableCell14.DataBindings.Add("Text", null, dataTable1.Columns[13].Caption);
//report.xrLabel14.Text = dataTable1.Columns[13].ColumnName;

	 

	 
////_pERSONEL_CINSIYET
//report.xrTableCell16.DataBindings.Add("Text", null, dataTable1.Columns[15].Caption);
//report.xrLabel16.Text = dataTable1.Columns[15].ColumnName;

	 


	 
////_pERSONEL_DOGUM_TARIHI
//report.xrTableCell18.DataBindings.Add("Text", null, dataTable1.Columns[17].Caption);
//report.xrLabel18.Text = dataTable1.Columns[17].ColumnName;

	 
////_pERSONEL_DOGUM_YERI
//report.xrTableCell19.DataBindings.Add("Text", null, dataTable1.Columns[18].Caption);
//report.xrLabel19.Text = dataTable1.Columns[18].ColumnName;

	 
////_pERSONEL_EGITIM_DURUMU
//report.xrTableCell20.DataBindings.Add("Text", null, dataTable1.Columns[19].Caption);
//report.xrLabel20.Text = dataTable1.Columns[19].ColumnName;

	 
////_pERSONEL_ACIKLAMA
//report.xrTableCell21.DataBindings.Add("Text", null, dataTable1.Columns[20].Caption);
//report.xrLabel21.Text = dataTable1.Columns[20].ColumnName;

	 
////_pERSONEL_AYAKKABI_NO
//report.xrTableCell22.DataBindings.Add("Text", null, dataTable1.Columns[21].Caption);
//report.xrLabel22.Text = dataTable1.Columns[21].ColumnName;

	 
////_pERSONEL_GOMLEK_NO
//report.xrTableCell23.DataBindings.Add("Text", null, dataTable1.Columns[22].Caption);
//report.xrLabel23.Text = dataTable1.Columns[22].ColumnName;

	 
////_pERSONEL_MONT_NO
//report.xrTableCell24.DataBindings.Add("Text", null, dataTable1.Columns[23].Caption);
//report.xrLabel24.Text = dataTable1.Columns[23].ColumnName;

	 
////_pERSONEL_PANTOLON_NO
//report.xrTableCell25.DataBindings.Add("Text", null, dataTable1.Columns[24].Caption);
//report.xrLabel25.Text = dataTable1.Columns[24].ColumnName;

	 
////_yEDEK
//report.xrTableCell26.DataBindings.Add("Text", null, dataTable1.Columns[25].Caption);
//report.xrLabel26.Text = dataTable1.Columns[25].ColumnName;

RaporSayfasi pencere = new RaporSayfasi();


pencere.Preview.Model = new XtraReportPreviewModel(report);
report.CreateDocument(true);



pencere.ShowDialog();

 
 //report.ShowPreviewDialog();
	           
	        }
	        catch (Exception)
	        {

	            MessageBox.Show("Hata");
	        }
	    }
         
	}
}
