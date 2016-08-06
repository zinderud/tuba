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
using AnaEkran.Provider;
using System.Collections.ObjectModel;
using AnaEkran.Views.Raporlar;
using AnaEkran.Views.Raporlar.Gider;
using Zinde.Xpf.Printing;
using Zinde.XtraReports.UI;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_GIDER_BAKIYEViewModel  : ViewModelDetailBase<TBL_GIDER_BAKIYEViewModel, TBL_GIDER_BAKIYE_MODEL> 
    {
	  
		
	 public void Baslangic()
	 {
	     TBL_GIDERListesi();
	     TBL_FISListesi();
	     TBL_PARA_TIPIListesi();
         TBL_KASAListesi();
	 }

     #region TBL_GIDER
     private ObservableCollection<TBL_GIDER_MODEL> _TBL_GIDERlistesiCollection;
     public ObservableCollection<TBL_GIDER_MODEL> PropTBL_GIDERlistesiCollection
     {
         get { return _TBL_GIDERlistesiCollection; }
         set
         {
             _TBL_GIDERlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_GIDERlistesiCollection);
         }
     }
     private TBL_GIDER_MODEL _TBL_GIDER_MODELModel;
     public TBL_GIDER_MODEL SecilenTBL_GIDER_MODEL
     {
         get { return _TBL_GIDER_MODELModel; }
         set
         {
             _TBL_GIDER_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_GIDER_MODEL);
             this.Model.TBL_GIDER_ID = SecilenTBL_GIDER_MODEL.TBL_GIDER_ID;
         }
     }
     public async void TBL_GIDERListesi()
     {
         PropTBL_GIDERlistesiCollection = await serviceAgent.Listele__TBL_GIDER_MODEL();
     }
     #endregion
     #region TBL_FIS
     private ObservableCollection<TBL_FIS_MODEL> _TBL_FISlistesiCollection;
     public ObservableCollection<TBL_FIS_MODEL> PropTBL_FISlistesiCollection
     {
         get { return _TBL_FISlistesiCollection; }
         set
         {
             _TBL_FISlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_FISlistesiCollection);
         }
     }
     private TBL_FIS_MODEL _TBL_FIS_MODELModel;
     public TBL_FIS_MODEL SecilenTBL_FIS_MODEL
     {
         get { return _TBL_FIS_MODELModel; }
         set
         {
             _TBL_FIS_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_FIS_MODEL);
             this.Model.TBL_FIS_ID = SecilenTBL_FIS_MODEL.TBL_FIS_ID;
         }
     }
     public async void TBL_FISListesi()
     {
         PropTBL_FISlistesiCollection = await serviceAgent.Listele__TBL_FIS_MODEL();
     }
     #endregion
     #region TBL_PARA_TIPI
     private ObservableCollection<TBL_PARA_TIPI_MODEL> _TBL_PARA_TIPIlistesiCollection;
     public ObservableCollection<TBL_PARA_TIPI_MODEL> PropTBL_PARA_TIPIlistesiCollection
     {
         get { return _TBL_PARA_TIPIlistesiCollection; }
         set
         {
             _TBL_PARA_TIPIlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_PARA_TIPIlistesiCollection);
         }
     }
     private TBL_PARA_TIPI_MODEL _TBL_PARA_TIPI_MODELModel;
     public TBL_PARA_TIPI_MODEL SecilenTBL_PARA_TIPI_MODEL
     {
         get { return _TBL_PARA_TIPI_MODELModel; }
         set
         {
             _TBL_PARA_TIPI_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_PARA_TIPI_MODEL);
             this.Model.TBL_PARA_TIPI_ID = SecilenTBL_PARA_TIPI_MODEL.TBL_PARA_TIPI_ID;
         }
     }
     public async void TBL_PARA_TIPIListesi()
     {
         PropTBL_PARA_TIPIlistesiCollection = await serviceAgent.Listele__TBL_PARA_TIPI_MODEL();
     }
     #endregion
     #region TBL_KASA
     private ObservableCollection<TBL_KASA_MODEL> _TBL_KASAlistesiCollection;
     public ObservableCollection<TBL_KASA_MODEL> PropTBL_KASAlistesiCollection
     {
         get { return _TBL_KASAlistesiCollection; }
         set
         {
             _TBL_KASAlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_KASAlistesiCollection);
         }
     }
     private TBL_KASA_MODEL _PropkasaSecilen;

     public TBL_KASA_MODEL PropkasaSecilen
     {
         get { return _PropkasaSecilen; }
         set
         {
             _PropkasaSecilen = value;
             NotifyPropertyChanged(m => m.PropkasaSecilen);
         }
     }


     private TBL_KASA_MODEL _TBL_KASA_MODELModel;
     public TBL_KASA_MODEL SecilenTBL_KASA_MODEL
     {
         get { return _TBL_KASA_MODELModel; }
         set
         {
             _TBL_KASA_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_KASA_MODEL);

             //todo giderde kasa id olmadýðý için kura baðladim sonradan düzelt
             this.Model.KUR = SecilenTBL_KASA_MODEL.TBL_KASA_ID.ToString();
         }
     }
     public async void TBL_KASAListesi()
     {
         PropTBL_KASAlistesiCollection = await serviceAgent.Listele__TBL_KASA_MODEL();
     }
     #endregion


     #region Gideri kasaya ekle
     public async void GiderKasaEkle(TBL_KASA_BAKIYE_MODEL model)
     {
         try
         {
             //TBL_DEPO_ISLEM_MODEL model1 = new TBL_DEPO_ISLEM_MODEL();

             if (await serviceAgent.Ekle__TBL_KASA_BAKIYE_MODEL(model))
             {
                 Listele();
                 Messenger.Default.Send<EkleTBL_KASA_BAKIYEMesaj>(new EkleTBL_KASA_BAKIYEMesaj() { MesajTBL_KASA_BAKIYE = model, mesaj = "Eklendi" });

             }
             else
             {
                 Messenger.Default.Send<EkleTBL_KASA_BAKIYEMesaj>(new EkleTBL_KASA_BAKIYEMesaj() { MesajTBL_KASA_BAKIYE = model, mesaj = "Eklendi bilinmeyen hata" });

             }
         }
         catch (Exception ex)
         {
             Messenger.Default.Send<HataTBL_KASA_BAKIYEMesaj>(new HataTBL_KASA_BAKIYEMesaj() { Hatamesaji = ex.ToString() });

         }

     }
     #endregion

     public String pARAadi(int? id)
     {
         try
         {
             return PropTBL_PARA_TIPIlistesiCollection.Where(x => x.TBL_PARA_TIPI_ID == id).FirstOrDefault().PARA_TIPI_ADI;
         }
         catch (Exception)
         {


         }
         return null;
     }
     public String Gideradi(int? id)
     {
         try
         {
             return PropTBL_GIDERlistesiCollection.Where(x => x.TBL_GIDER_ID == id).FirstOrDefault().GÝDER_ADI;
         }
         catch (Exception)
         {


         }
         return null;
     }
	    public void RaporGiderListele()
	    {
	        try
	        {
                DataSet dataSet1 = new DataSet();
                dataSet1.DataSetName = "GiderListesiRapor";
                DataTable dataTable1 = new DataTable();

                dataSet1.Tables.Add(dataTable1);

                dataTable1.TableName = "Table";

                dataTable1.Columns.Add("ID", typeof(string));

                dataTable1.Columns.Add("TBL_GIDER_ADI", typeof(string));

                dataTable1.Columns.Add("PARA_TIPI", typeof(string));

                dataTable1.Columns.Add("TBL_FIS_ID", typeof(string));

                dataTable1.Columns.Add("KUR", typeof(string));

                dataTable1.Columns.Add("TARIH", typeof(string));

                dataTable1.Columns.Add("TUTAR", typeof(string));

                dataTable1.Columns.Add("ACIKLAMA", typeof(string));

                dataTable1.Columns.Add("YEDEK", typeof(string));

	            foreach (var k in Propgýder_bakýyeListe)
	            {
	                dataTable1.Rows.Add(new Object[]
	                {

	                    k.TBL_GIDER_BAKIYE_ID,

	                   Gideradi(  k.TBL_GIDER_ID),

	                    pARAadi(k.TBL_PARA_TIPI_ID),

	                    k.TBL_FIS_ID,

	                    k.KUR,

	                    k.TARIH,

	                    k.TUTAR,

	                    k.ACIKLAMA,

	                    k.YEDEK,


	                });
	            }

                RaporgiderBakiye report = new RaporgiderBakiye();
report.DataSource = dataSet1;
report.DataMember = dataTable1.TableName;
	 
report.xrTableCell1.DataBindings.Add("Text", null, dataTable1.Columns[0].Caption);
report.xrLabel1.Text = dataTable1.Columns[0].ColumnName;

	 
report.xrTableCell2.DataBindings.Add("Text", null, dataTable1.Columns[1].Caption);
report.xrLabel2.Text = dataTable1.Columns[1].ColumnName;

	 
report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[2].Caption);
report.xrLabel3.Text = dataTable1.Columns[2].ColumnName;

	 
report.xrTableCell4.DataBindings.Add("Text", null, dataTable1.Columns[3].Caption);
report.xrLabel4.Text = dataTable1.Columns[3].ColumnName;

	 
report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
report.xrLabel5.Text = dataTable1.Columns[6].ColumnName;

	 
report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[5].Caption);
report.xrLabel6.Text = dataTable1.Columns[5].ColumnName;

	 
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

	            MessageBox.Show("hata");
	        }
	    }
	}
}
