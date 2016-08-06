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
	public partial class TBL_URUNViewModel  : ViewModelDetailBase<TBL_URUNViewModel, TBL_URUN_MODEL> 
    {
	  
		
	 public void Baslangic()
	 {
	     TBL_URUN_TIPIListesi();
	     TBL_URUN_CINSIListesi();
	     TBL_URUN_MARKAListesi();
	     TBL_URUN_BIRIMListesi();
	     TBL_KDVListesi();
	     TBL_PARA_TIPIListesi();
	 }


     #region TBL_URUN_TIPI
     private ObservableCollection<TBL_URUN_TIPI_MODEL> _TBL_URUN_TIPIlistesiCollection;
     public ObservableCollection<TBL_URUN_TIPI_MODEL> PropTBL_URUN_TIPIlistesiCollection
     {
         get { return _TBL_URUN_TIPIlistesiCollection; }
         set
         {
             _TBL_URUN_TIPIlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_URUN_TIPIlistesiCollection);
         }
     }
     private TBL_URUN_TIPI_MODEL _TBL_URUN_TIPI_MODELModel;
     public TBL_URUN_TIPI_MODEL SecilenTBL_URUN_TIPI_MODEL
     {
         get { return _TBL_URUN_TIPI_MODELModel; }
         set
         {
             _TBL_URUN_TIPI_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_URUN_TIPI_MODEL);
             this.Model.TBL_URUN_TIPI_ID = SecilenTBL_URUN_TIPI_MODEL.TBL_URUN_TIPI_ID;
         }
     }
     public async void TBL_URUN_TIPIListesi()
     {
         PropTBL_URUN_TIPIlistesiCollection = await serviceAgent.Listele__TBL_URUN_TIPI_MODEL();
     }
     #endregion
     #region TBL_URUN_CINSI
     private ObservableCollection<TBL_URUN_CINSI_MODEL> _TBL_URUN_CINSIlistesiCollection;
     public ObservableCollection<TBL_URUN_CINSI_MODEL> PropTBL_URUN_CINSIlistesiCollection
     {
         get { return _TBL_URUN_CINSIlistesiCollection; }
         set
         {
             _TBL_URUN_CINSIlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_URUN_CINSIlistesiCollection);
         }
     }
     private TBL_URUN_CINSI_MODEL _TBL_URUN_CINSI_MODELModel;
     public TBL_URUN_CINSI_MODEL SecilenTBL_URUN_CINSI_MODEL
     {
         get { return _TBL_URUN_CINSI_MODELModel; }
         set
         {
             _TBL_URUN_CINSI_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_URUN_CINSI_MODEL);
             this.Model.TBL_URUN_CINSI_ID = SecilenTBL_URUN_CINSI_MODEL.TBL_URUN_CINSI_ID;
         }
     }
     public async void TBL_URUN_CINSIListesi()
     {
         PropTBL_URUN_CINSIlistesiCollection = await serviceAgent.Listele__TBL_URUN_CINSI_MODEL();
     }
     #endregion

     #region TBL_URUN_MARKA
     private ObservableCollection<TBL_URUN_MARKA_MODEL> _TBL_URUN_MARKAlistesiCollection;
     public ObservableCollection<TBL_URUN_MARKA_MODEL> PropTBL_URUN_MARKAlistesiCollection
     {
         get { return _TBL_URUN_MARKAlistesiCollection; }
         set
         {
             _TBL_URUN_MARKAlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_URUN_MARKAlistesiCollection);
         }
     }
     private TBL_URUN_MARKA_MODEL _TBL_URUN_MARKA_MODELModel;
     public TBL_URUN_MARKA_MODEL SecilenTBL_URUN_MARKA_MODEL
     {
         get { return _TBL_URUN_MARKA_MODELModel; }
         set
         {
             _TBL_URUN_MARKA_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_URUN_MARKA_MODEL);
             this.Model.TBL_URUN_MARKA_ID = SecilenTBL_URUN_MARKA_MODEL.TBL_URUN_MARKA_ID;
         }
     }
     public async void TBL_URUN_MARKAListesi()
     {
         PropTBL_URUN_MARKAlistesiCollection = await serviceAgent.Listele__TBL_URUN_MARKA_MODEL();
     }
     #endregion
     #region TBL_URUN_BIRIM
     private ObservableCollection<TBL_URUN_BIRIM_MODEL> _TBL_URUN_BIRIMlistesiCollection;
     public ObservableCollection<TBL_URUN_BIRIM_MODEL> PropTBL_URUN_BIRIMlistesiCollection
     {
         get { return _TBL_URUN_BIRIMlistesiCollection; }
         set
         {
             _TBL_URUN_BIRIMlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_URUN_BIRIMlistesiCollection);
         }
     }
     private TBL_URUN_BIRIM_MODEL _TBL_URUN_BIRIM_MODELModel;
     public TBL_URUN_BIRIM_MODEL SecilenTBL_URUN_BIRIM_MODEL
     {
         get { return _TBL_URUN_BIRIM_MODELModel; }
         set
         {
             _TBL_URUN_BIRIM_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_URUN_BIRIM_MODEL);
             this.Model.TBL_URUN_BIRIM_ID = SecilenTBL_URUN_BIRIM_MODEL.TBL_URUN_BIRIM_ID;
         }
     }
     public async void TBL_URUN_BIRIMListesi()
     {
         PropTBL_URUN_BIRIMlistesiCollection = await serviceAgent.Listele__TBL_URUN_BIRIM_MODEL();
     }
     #endregion

     #region TBL_KDV
     private ObservableCollection<TBL_KDV_MODEL> _TBL_KDVlistesiCollection;
     public ObservableCollection<TBL_KDV_MODEL> PropTBL_KDVlistesiCollection
     {
         get { return _TBL_KDVlistesiCollection; }
         set
         {
             _TBL_KDVlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_KDVlistesiCollection);
         }
     }
     private TBL_KDV_MODEL _TBL_KDV_MODELModel;
     public TBL_KDV_MODEL SecilenTBL_KDV_MODEL
     {
         get { return _TBL_KDV_MODELModel; }
         set
         {
             _TBL_KDV_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_KDV_MODEL);
             this.Model.TBL_KDV_ID = SecilenTBL_KDV_MODEL.TBL_KDV_ID;
         }
     }
     public async void TBL_KDVListesi()
     {
         PropTBL_KDVlistesiCollection = await serviceAgent.Listele__TBL_KDV_MODEL();
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

     // pARAadi( k.TBL_PARA_TIPI_ID),
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
        //
	              // UrunTipadi(k.TBL_URUN_TIPI_ID) ,
     public String UrunTipadi(int? id)
     {
         try
         {
             return PropTBL_URUN_TIPIlistesiCollection.Where(x => x.TBL_URUN_TIPI_ID == id).FirstOrDefault().URUN_TIPI_ADI;

         }
         catch (Exception)
         {


         }
         return null;
     }
	 
	    public void RaporUrunListesi()
	    {
            DataSet dataSet1 = new DataSet();
            dataSet1.DataSetName = "BankaListesiRapor";
            DataTable dataTable1 = new DataTable();

            dataSet1.Tables.Add(dataTable1);

            dataTable1.TableName = "Table";

            dataTable1.Columns.Add("ID", typeof(string));

            dataTable1.Columns.Add("URUN ADI", typeof(string));

            dataTable1.Columns.Add("KODU", typeof(string));

            dataTable1.Columns.Add("TIP ADI", typeof(string));

            dataTable1.Columns.Add("CINSI ADI", typeof(string));

            dataTable1.Columns.Add("MARKA ADI", typeof(string));

            dataTable1.Columns.Add("BIRIM ADI", typeof(string));

            dataTable1.Columns.Add("KDV", typeof(string));

            dataTable1.Columns.Add("DURUM", typeof(string));

            dataTable1.Columns.Add("ALIS_FIYATI", typeof(string));

            dataTable1.Columns.Add("SATIS_FIYATI", typeof(string));

            dataTable1.Columns.Add("PARA TIPI", typeof(string));

            dataTable1.Columns.Add("YEDEK", typeof(string));
	        foreach (var k in PropurunListe)
	        {
	            dataTable1.Rows.Add(new Object[]
	            {

	                k.TBL_URUN_ID,

	                k.URUN_ADI,

	                k.URUN_KODU,

	               UrunTipadi(k.TBL_URUN_TIPI_ID) ,

	                k.TBL_URUN_CINSI_ID,

	                k.TBL_URUN_MARKA_ID,

	                k.TBL_URUN_BIRIM_ID,

	                k.TBL_KDV_ID,

	                k.URUN_DURUM,

	                k.URUN_ALIS_FIYATI,

	                k.URUN_SATIS_FIYATI,

	             pARAadi( k.TBL_PARA_TIPI_ID),

	                k.YEDEK,


	            });
	        }
             RaporUrunListesi report = new  RaporUrunListesi();
report.DataSource = dataSet1;
report.DataMember = dataTable1.TableName;
	 
//_tBL_URUN_ID
report.xrTableCell1.DataBindings.Add("Text", null, dataTable1.Columns[0].Caption);
report.xrLabel1.Text = dataTable1.Columns[0].ColumnName;

	 
//_uRUN_ADI
report.xrTableCell2.DataBindings.Add("Text", null, dataTable1.Columns[1].Caption);
report.xrLabel2.Text = dataTable1.Columns[1].ColumnName;

	 
////_uRUN_KODU
//report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[2].Caption);
//report.xrLabel3.Text = dataTable1.Columns[2].ColumnName;

	 
////_tBL_URUN_TIPI_ID
report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[3].Caption);
report.xrLabel7.Text = dataTable1.Columns[3].ColumnName;

	 
////_tBL_URUN_CINSI_ID
//report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[4].Caption);
//report.xrLabel5.Text = dataTable1.Columns[4].ColumnName;

	 
////_tBL_URUN_MARKA_ID
//report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[5].Caption);
//report.xrLabel6.Text = dataTable1.Columns[5].ColumnName;

	 
////_tBL_URUN_BIRIM_ID
//report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
//report.xrLabel7.Text = dataTable1.Columns[6].ColumnName;

	 
//_tBL_KDV_ID
report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[7].Caption);
report.xrLabel3.Text = dataTable1.Columns[7].ColumnName;

	 
////_uRUN_DURUM
//report.xrTableCell9.DataBindings.Add("Text", null, dataTable1.Columns[8].Caption);
//report.xrLabel9.Text = dataTable1.Columns[8].ColumnName;

	 
//_uRUN_ALIS_FIYATI
report.xrTableCell4.DataBindings.Add("Text", null, dataTable1.Columns[9].Caption);
report.xrLabel4.Text = dataTable1.Columns[9].ColumnName;

	 
//_uRUN_SATIS_FIYATI
report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[10].Caption);
report.xrLabel5.Text = dataTable1.Columns[10].ColumnName;

	 
//_tBL_PARA_TIPI_ID
report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[11].Caption);
report.xrLabel6.Text = dataTable1.Columns[11].ColumnName;

	 
////_yEDEK
//report.xrTableCell13.DataBindings.Add("Text", null, dataTable1.Columns[12].Caption);
//report.xrLabel13.Text = dataTable1.Columns[12].ColumnName;


RaporSayfasi pencere = new RaporSayfasi();


pencere.Preview.Model = new XtraReportPreviewModel(report);
report.CreateDocument(true);



pencere.ShowDialog();
 
 //report.ShowPreviewDialog();

	    }
    }
}
