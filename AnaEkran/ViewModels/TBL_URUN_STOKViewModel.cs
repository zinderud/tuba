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
using System.ServiceModel.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Input;
using AnaEkran.Provider;
using System.Collections.ObjectModel;
using AnaEkran.Views.Raporlar;
using AnaEkran.Views.Raporlar.Urun;
using Zinde.Xpf.Printing;
using Zinde.XtraReports.UI;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_URUN_STOKViewModel  : ViewModelDetailBase<TBL_URUN_STOKViewModel, TBL_URUN_STOK_MODEL> 
    {
	  
		
	 public void Baslangic()
	 {
         DurumlarCollection = _durumListesi.DurumcObservableCollection;
	     TBL_URUNListesi();
	     TBL_DEPOListesi();
	    
	 }
     #region TBL_URUN
     private ObservableCollection<TBL_URUN_MODEL> _TBL_URUNlistesiCollection;
     public ObservableCollection<TBL_URUN_MODEL> PropTBL_URUNlistesiCollection
     {
         get { return _TBL_URUNlistesiCollection; }
         set
         {
             _TBL_URUNlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_URUNlistesiCollection);
         }
     }
     private TBL_URUN_MODEL _TBL_URUN_MODELModel;
     public TBL_URUN_MODEL SecilenTBL_URUN_MODEL
     {
         get { return _TBL_URUN_MODELModel; }
         set
         {
             _TBL_URUN_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_URUN_MODEL);
             this.Model.TBL_URUN_ID = SecilenTBL_URUN_MODEL.TBL_URUN_ID;
         }
     }
     public async void TBL_URUNListesi()
     {
         PropTBL_URUNlistesiCollection = await serviceAgent.Listele__TBL_URUN_MODEL();
     }
     #endregion
     #region TBL_DEPO
     private ObservableCollection<TBL_DEPO_MODEL> _TBL_DEPOlistesiCollection;
     public ObservableCollection<TBL_DEPO_MODEL> PropTBL_DEPOlistesiCollection
     {
         get { return _TBL_DEPOlistesiCollection; }
         set
         {
             _TBL_DEPOlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_DEPOlistesiCollection);
         }
     }
     private TBL_DEPO_MODEL _TBL_DEPO_MODELModel;
     public TBL_DEPO_MODEL SecilenTBL_DEPO_MODEL
     {
         get { return _TBL_DEPO_MODELModel; }
         set
         {
             _TBL_DEPO_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_DEPO_MODEL);
             this.Model.TBL_DEPO_ID = SecilenTBL_DEPO_MODEL.TBL_DEPO_ID;
         }
     }
     public async void TBL_DEPOListesi()
     {
         PropTBL_DEPOlistesiCollection = await serviceAgent.Listele__TBL_DEPO_MODEL();
     }
     #endregion

        #region UrunStokDepo iliþkisi

     private ObservableCollection<GrupToplamModel> _GrupToplamModel;
     public ObservableCollection<GrupToplamModel> GrupToplamModel
     {
         get { return _GrupToplamModel; }
         set
         {
             _GrupToplamModel = value;
             NotifyPropertyChanged(m => m.GrupToplamModel);
         }
     }

        ObservableCollection<GrupToplamModel> _grupToplamModels;
	    public async void UrunStokDepoIliskisiListele()
	    {
	        try
	        {
                _grupToplamModels = new ObservableCollection<GrupToplamModel>();
                //var deneme = from k in Propurun_stokListe
                //    group k by k.TBL_URUN_ID
                //    into g
                //    select new {urunid=g,adet=


                //        g.Key};

                var model1 = Propurun_stokListe = await serviceAgent.Listele__TBL_URUN_STOK_MODEL();

                var listeler = from detay in model1
                               group detay by detay.TBL_URUN_ID
                                   into Grup
                                   select new
                                   {
                                       toplam = Grup.Sum(k => k.URUN_BIRIM_MIKTARI),

                                       TBL_URUN_ID = Grup.Key.ToString()
                                   };
                foreach (var k in listeler)
                {
                    _grupToplamModels.Add(new GrupToplamModel() { Toplam = k.toplam.ToString(), Gruplanan = k.TBL_URUN_ID });
                }
                GrupToplamModel = _grupToplamModels;
	        }
	        catch (Exception)
	        {

 MessageBox.Show("Hata");
	        }
            
	    }
        #endregion

        #region urun depo stok ekle
        public async void DepoStokEkle(TBL_DEPO_ISLEM_MODEL model)
        {
            try
            {
                //TBL_DEPO_ISLEM_MODEL model1 = new TBL_DEPO_ISLEM_MODEL();

                if (await serviceAgent.Ekle__TBL_DEPO_ISLEM_MODEL(model))
                {
                    Listele();
                    Messenger.Default.Send<EkleTBL_DEPO_ISLEMMesaj>(new EkleTBL_DEPO_ISLEMMesaj() { MesajTBL_DEPO_ISLEM = model, mesaj = "Eklendi" });

                }
                else
                {
                    Messenger.Default.Send<EkleTBL_DEPO_ISLEMMesaj>(new EkleTBL_DEPO_ISLEMMesaj() { MesajTBL_DEPO_ISLEM = model, mesaj = "Eklendi bilinmeyen hata" });

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_DEPO_ISLEMMesaj>(new HataTBL_DEPO_ISLEMMesaj() { Hatamesaji = ex.ToString() });

            }

        }
        #endregion
        #region durumlar
        //<zinderud:GridViewComboBoxColumn      ItemsSource="{Binding  DurumlarCollection}"  IsFilterable="True" IsReadOnly="False" 
        //    x:Name="DEPO_ONAYColumn" Width="Auto"  Header="DEPO ONAY" DataMemberBinding="{Binding DEPO_ONAY}" SelectedValueMemberPath="Durum" DisplayMemberPath="Durum"   
        //DurumlarCollection = _durumListesi.DurumcObservableCollection;
        DurumListesi _durumListesi = new DurumListesi();

        private ObservableCollection<Durumlar> _DurumlarCollection;

        public ObservableCollection<Durumlar> DurumlarCollection
        {
            get { return _DurumlarCollection; }
            set
            {
                _DurumlarCollection = value;
                NotifyPropertyChanged(m => m.DurumlarCollection);
            }
        }
        #endregion


        //urunadi(k.TBL_URUN_ID)  
        public String urunadi(int? id)
        {
            try
            {
                return PropTBL_URUNlistesiCollection.Where(x => x.TBL_URUN_ID == id).FirstOrDefault().URUN_ADI;
            }
            catch (Exception)
            {


            }
            return null;
        }
        // Depoadi(Convert.ToInt32( k.DEPO_TRANSFER_NEREDEN))
        public String Depoadi(int? id)
        {
            try
            {
                return PropTBL_DEPOlistesiCollection.Where(x => x.TBL_DEPO_ID == id).FirstOrDefault().DEPO_ADI;
            }
            catch (Exception)
            {


            }
            return null;
        }

	    public void RaporUrunDepoeAdetListele()
	    {
            try
            {
                DataSet dataSet1 = new DataSet();
                dataSet1.DataSetName = "RaporKasaParaListele";
                DataTable dataTable1 = new DataTable();

                dataSet1.Tables.Add(dataTable1);

                dataTable1.TableName = "Table";

                dataTable1.Columns.Add("Urun Adý", typeof(string));

                dataTable1.Columns.Add("Toplam", typeof(string));


                foreach (var k in GrupToplamModel)
                {
                    dataTable1.Rows.Add(new Object[]
	            {
	               urunadi(Convert.ToInt32(k.Gruplanan))   , k.Toplam
	            });
                }
                RaporUrunDepoeAdetListele report = new RaporUrunDepoeAdetListele();
                report.DataSource = dataSet1;
                report.DataMember = dataTable1.TableName;

                report.xrTableCell1.DataBindings.Add("Text", null, dataTable1.Columns[0].Caption);
                report.xrLabel1.Text = dataTable1.Columns[0].ColumnName;


                report.xrTableCell2.DataBindings.Add("Text", null, dataTable1.Columns[1].Caption);
                report.xrLabel2.Text = dataTable1.Columns[1].ColumnName;


                //report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[2].Caption);
                //report.xrLabel3.Text = dataTable1.Columns[2].ColumnName;


                //report.xrTableCell4.DataBindings.Add("Text", null, dataTable1.Columns[3].Caption);
                //report.xrLabel4.Text = dataTable1.Columns[3].ColumnName;


                //report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
                //report.xrLabel5.Text = dataTable1.Columns[6].ColumnName;


                //report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[5].Caption);
                //report.xrLabel6.Text = dataTable1.Columns[5].ColumnName;


                //report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
                //report.xrLabel7.Text = dataTable1.Columns[6].ColumnName;


                //report.xrTableCell8.DataBindings.Add("Text", null, dataTable1.Columns[7].Caption);
                //report.xrLabel8.Text = dataTable1.Columns[7].ColumnName;


                //report.xrTableCell9.DataBindings.Add("Text", null, dataTable1.Columns[8].Caption);
                //report.xrLabel9.Text = dataTable1.Columns[8].ColumnName;

                RaporSayfasi pencere = new RaporSayfasi();


                pencere.Preview.Model = new XtraReportPreviewModel(report);
                report.CreateDocument(true);



                pencere.ShowDialog();


                //report.ShowPreviewDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluþtu");
            }
	    }
	    public void RaporUrunStokListesi()
	    {
	        try
	        {
                DataSet dataSet1 = new DataSet();
                dataSet1.DataSetName = "BankaListesiRapor";
                DataTable dataTable1 = new DataTable();

                dataSet1.Tables.Add(dataTable1);

                dataTable1.TableName = "Table";

                dataTable1.Columns.Add("ID", typeof(string));

                dataTable1.Columns.Add("URUN_ADI", typeof(string));

                dataTable1.Columns.Add("DEPO ADI", typeof(string));

                dataTable1.Columns.Add("BIRIM", typeof(string));

                dataTable1.Columns.Add("DURUM", typeof(string));

                dataTable1.Columns.Add("ACIKLAMA", typeof(string));

                dataTable1.Columns.Add("YEDEK", typeof(string));
                foreach (var k in Propurun_stokListe)
                {
                    dataTable1.Rows.Add(new Object[]
	            {

	                k.TBL_URUN_STOK_ID,

	                urunadi(k.TBL_URUN_ID) ,

	               Depoadi(k.TBL_DEPO_ID) ,

	                k.URUN_BIRIM_MIKTARI,

	                k.STOK_DURUM,

	                k.ACIKLAMA,

	                k.YEDEK,


	            });
                }
                RaprUrunStokListesi report = new RaprUrunStokListesi();
                report.DataSource = dataSet1;
                report.DataMember = dataTable1.TableName;

                //_tBL_URUN_STOK_ID
                report.xrTableCell1.DataBindings.Add("Text", null, dataTable1.Columns[0].Caption);
                report.xrLabel1.Text = dataTable1.Columns[0].ColumnName;


                //_tBL_URUN_ID
                report.xrTableCell2.DataBindings.Add("Text", null, dataTable1.Columns[1].Caption);
                report.xrLabel2.Text = dataTable1.Columns[1].ColumnName;


                //_tBL_DEPO_ID
                report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[2].Caption);
                report.xrLabel3.Text = dataTable1.Columns[2].ColumnName;


                //_uRUN_BIRIM_MIKTARI
                report.xrTableCell4.DataBindings.Add("Text", null, dataTable1.Columns[3].Caption);
                report.xrLabel4.Text = dataTable1.Columns[3].ColumnName;


                //_sTOK_DURUM
                report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[4].Caption);
                report.xrLabel5.Text = dataTable1.Columns[4].ColumnName;


                //_aCIKLAMA
                report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[5].Caption);
                report.xrLabel6.Text = dataTable1.Columns[5].ColumnName;


                //_yEDEK
                report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
                report.xrLabel7.Text = dataTable1.Columns[6].ColumnName;

                RaporSayfasi pencere = new RaporSayfasi();


                pencere.Preview.Model = new XtraReportPreviewModel(report);
                report.CreateDocument(true);



                pencere.ShowDialog();


                //report.ShowPreviewDialog();
	        }
	        catch (Exception)
	        {

	            MessageBox.Show("HAta");
	        }
          


	    }

    }
}
