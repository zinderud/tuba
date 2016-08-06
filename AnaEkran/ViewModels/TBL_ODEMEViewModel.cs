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
using AnaEkran.Views.Raporlar.Odeme;
using Zinde.Xpf.Printing;
using Zinde.XtraReports.UI;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_ODEMEViewModel  : ViewModelDetailBase<TBL_ODEMEViewModel, TBL_ODEME_MODEL> 
    {
	  
		
	 public void Baslangic()
	 {
	     TBL_ODEME_TURUListesi();
	     TBL_ODEME_TIPIListesi();
	     TBL_SIRKETListesi();
	     TBL_PARA_TIPIListesi();
         //TBL_BANKAListesi();
         TBL_KASAListesi();
	 }
     #region TBL_ODEME_TURU
     private ObservableCollection<TBL_ODEME_TURU_MODEL> _TBL_ODEME_TURUlistesiCollection;
     public ObservableCollection<TBL_ODEME_TURU_MODEL> PropTBL_ODEME_TURUlistesiCollection
     {
         get { return _TBL_ODEME_TURUlistesiCollection; }
         set
         {
             _TBL_ODEME_TURUlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_ODEME_TURUlistesiCollection);
         }
     }
     private TBL_ODEME_TURU_MODEL _TBL_ODEME_TURU_MODELModel;
     public TBL_ODEME_TURU_MODEL SecilenTBL_ODEME_TURU_MODEL
     {
         get { return _TBL_ODEME_TURU_MODELModel; }
         set
         {
             _TBL_ODEME_TURU_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_ODEME_TURU_MODEL);
             this.Model.TBL_ODEME_TURU_ID = SecilenTBL_ODEME_TURU_MODEL.TBL_ODEME_TURU_ID;
         }
     }
     public async void TBL_ODEME_TURUListesi()
     {
         PropTBL_ODEME_TURUlistesiCollection = await serviceAgent.Listele__TBL_ODEME_TURU_MODEL();
     }
     #endregion

     #region TBL_ODEME_TIPI
     private ObservableCollection<TBL_ODEME_TIPI_MODEL> _TBL_ODEME_TIPIlistesiCollection;
     public ObservableCollection<TBL_ODEME_TIPI_MODEL> PropTBL_ODEME_TIPIlistesiCollection
     {
         get { return _TBL_ODEME_TIPIlistesiCollection; }
         set
         {
             _TBL_ODEME_TIPIlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_ODEME_TIPIlistesiCollection);
         }
     }
     private TBL_ODEME_TIPI_MODEL _TBL_ODEME_TIPI_MODELModel;
     public TBL_ODEME_TIPI_MODEL SecilenTBL_ODEME_TIPI_MODEL
     {
         get { return _TBL_ODEME_TIPI_MODELModel; }
         set
         {
             _TBL_ODEME_TIPI_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_ODEME_TIPI_MODEL);
             this.Model.TBL_ODEME_TIPI_ID = SecilenTBL_ODEME_TIPI_MODEL.TBL_ODEME_TIPI_ID;
         }
     }
     public async void TBL_ODEME_TIPIListesi()
     {
         PropTBL_ODEME_TIPIlistesiCollection = await serviceAgent.Listele__TBL_ODEME_TIPI_MODEL();
     }
     #endregion
     #region TBL_SIRKET
     private ObservableCollection<TBL_SIRKET_MODEL> _TBL_SIRKETlistesiCollection;
     public ObservableCollection<TBL_SIRKET_MODEL> PropTBL_SIRKETlistesiCollection
     {
         get { return _TBL_SIRKETlistesiCollection; }
         set
         {
             _TBL_SIRKETlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_SIRKETlistesiCollection);
         }
     }
     private TBL_SIRKET_MODEL _TBL_SIRKET_MODELModel;
     public TBL_SIRKET_MODEL SecilenTBL_SIRKET_MODEL
     {
         get { return _TBL_SIRKET_MODELModel; }
         set
         {
             _TBL_SIRKET_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_SIRKET_MODEL);
             this.Model.TBL_SIRKET_ID = SecilenTBL_SIRKET_MODEL.TBL_SIRKET_ID;
         }
     }
     public async void TBL_SIRKETListesi()
     {
         PropTBL_SIRKETlistesiCollection = await serviceAgent.Listele__TBL_SIRKET_MODEL();
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
     //#region TBL_BANKA
     //private ObservableCollection<TBL_BANKA_MODEL> _TBL_BANKAlistesiCollection;
     //public ObservableCollection<TBL_BANKA_MODEL> PropTBL_BANKAlistesiCollection
     //{
     //    get { return _TBL_BANKAlistesiCollection; }
     //    set
     //    {
     //        _TBL_BANKAlistesiCollection = value;
     //        NotifyPropertyChanged(m => m.PropTBL_BANKAlistesiCollection);
     //    }
     //}
     //private TBL_BANKA_MODEL _TBL_BANKA_MODELModel;
     //public TBL_BANKA_MODEL SecilenTBL_BANKA_MODEL
     //{
     //    get { return _TBL_BANKA_MODELModel; }
     //    set
     //    {
     //        _TBL_BANKA_MODELModel = value;
     //        NotifyPropertyChanged(m => m.SecilenTBL_BANKA_MODEL);
     //        //TODO DÜZENLE//  this.Model.TBL_BANKA_ID = SecilenTBL_BANKA_MODEL.TBL_BANKA_ID;
     //    }
     //}
     //public async void TBL_BANKAListesi()
     //{
     //    PropTBL_BANKAlistesiCollection = await serviceAgent.Listele__TBL_BANKA_MODEL();
     //}
     //#endregion
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
             this.Model.TBL_KASA_ID = SecilenTBL_KASA_MODEL.TBL_KASA_ID;
         }
     }
     public async void TBL_KASAListesi()
     {
         PropTBL_KASAlistesiCollection = await serviceAgent.Listele__TBL_KASA_MODEL();
     }
     #endregion

     public String Kasaadi(int? id)
     {
         try
         {
             return PropTBL_KASAlistesiCollection.Where(x => x.TBL_KASA_ID == id).FirstOrDefault().KASA_ADI;
         }
         catch (Exception)
         {


         }
         return null;
     }
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

     public String OdemeTuruadi(int? id)
     {
         try
         {
             return PropTBL_ODEME_TURUlistesiCollection.Where(x => x.TBL_ODEME_TURU_ID == id).FirstOrDefault().ODEME_TURU_ADI;
         }
         catch (Exception)
         {


         }
         return null;
     }
     public String OdemeTipiadi(int? id)
     {
         try
         {
             return PropTBL_ODEME_TIPIlistesiCollection.Where(x => x.TBL_ODEME_TIPI_ID == id).FirstOrDefault().ODEME_TIPI_ADI;
         }
         catch (Exception)
         {


         }
         return null;
     }
     public String Sirketadi(int? id)
     {
         try
         {
             return PropTBL_SIRKETlistesiCollection.Where(x => x.TBL_SIRKET_ID == id).FirstOrDefault().SIRKET_ADI;
         }
         catch (Exception)
         {


         }
         return null;
     }
	    public void RaporOdemeListele()
	    {
	        try
	        {
                DataSet dataSet1 = new DataSet();
                dataSet1.DataSetName = "OdemeListesiRapor";
                DataTable dataTable1 = new DataTable();

                dataSet1.Tables.Add(dataTable1);

                dataTable1.TableName = "Table";

                dataTable1.Columns.Add("ID", typeof(string));

                dataTable1.Columns.Add("KAYIT TARIHI", typeof(string));

                dataTable1.Columns.Add("VADE TARIHI", typeof(string));

                dataTable1.Columns.Add("ODEME TURU", typeof(string));

                dataTable1.Columns.Add("ODEME TIPI", typeof(string));

                dataTable1.Columns.Add("BELGE_NO", typeof(string));

                dataTable1.Columns.Add("SIRKET ADI", typeof(string));

                dataTable1.Columns.Add("TUTAR", typeof(string));

                dataTable1.Columns.Add("PARA TIPI", typeof(string));

                dataTable1.Columns.Add("KASA ADI", typeof(string));

                dataTable1.Columns.Add("YEDEK", typeof(string));
	            foreach (var k in PropodemeListe)
	            {
	                dataTable1.Rows.Add(new Object[]
	                {

	                    k.TBL_ODEME_ID,

	                    k.ODEME_KAYIT_TARIHI,

	                    k.ODEME_VADE_TARIHI,

	                    OdemeTuruadi(k.TBL_ODEME_TURU_ID),

	                    OdemeTipiadi(k.TBL_ODEME_TIPI_ID),

	                    k.BELGE_NO,

	                    Sirketadi(k.TBL_SIRKET_ID),

	                    k.TUTAR,

	                    pARAadi( k.TBL_PARA_TIPI_ID),

	                    Kasaadi(k.TBL_KASA_ID),

	                    k.YEDEK,


	                });
	            }
                 RaporOdemeListe report = new  RaporOdemeListe();
                 report.DataSource = dataSet1;
                 report.DataMember = dataTable1.TableName;

                 //_tBL_ODEME_ID
                 report.xrTableCell1.DataBindings.Add("Text", null, dataTable1.Columns[0].Caption);
                 report.xrLabel1.Text = dataTable1.Columns[0].ColumnName;


                 //_tBL_SIRKET_ID
                 report.xrTableCell2.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
                 report.xrLabel2.Text = dataTable1.Columns[6].ColumnName;


               


                 ////_oDEME_VADE_TARIHI
                 //report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[2].Caption);
                 //report.xrLabel3.Text = dataTable1.Columns[2].ColumnName;


                 //_tBL_ODEME_TURU_ID
                 report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[3].Caption);
                 report.xrLabel3.Text = dataTable1.Columns[3].ColumnName;


                 //_tBL_ODEME_TIPI_ID
                 report.xrTableCell4.DataBindings.Add("Text", null, dataTable1.Columns[4].Caption);
                 report.xrLabel4.Text = dataTable1.Columns[4].ColumnName;
                 //_tBL_KASA_ID
                 report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[9].Caption);
                 report.xrLabel5.Text = dataTable1.Columns[9].ColumnName;

                 //_tUTAR
                 report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[7].Caption);
                 report.xrLabel6.Text = dataTable1.Columns[7].ColumnName;
                 ////_bELGE_NO
                 //report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[5].Caption);
                 //report.xrLabel6.Text = dataTable1.Columns[5].ColumnName;


                 //_oDEME_KAYIT_TARIHI
                 report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[1].Caption);
                 report.xrLabel7.Text = dataTable1.Columns[1].ColumnName;
               


                 ////_tBL_PARA_TIPI_ID
                 //report.xrTableCell9.DataBindings.Add("Text", null, dataTable1.Columns[8].Caption);
                 //report.xrLabel9.Text = dataTable1.Columns[8].ColumnName;


                

                 ////_yEDEK
                 //report.xrTableCell11.DataBindings.Add("Text", null, dataTable1.Columns[10].Caption);
                 //report.xrLabel11.Text = dataTable1.Columns[10].ColumnName;


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
