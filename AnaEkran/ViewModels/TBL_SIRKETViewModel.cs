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
using AnaEkran.Views.Raporlar.Sirket;
using Zinde.Xpf.Printing;
using Zinde.XtraReports.UI;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_SIRKETViewModel  : ViewModelDetailBase<TBL_SIRKETViewModel, TBL_SIRKET_MODEL> 
    {
	  
		
	 public void Baslangic()
	 {
	     TBL_SIRKET_GRUBListesi();
	     TBL_SIRKET_TIPIListesi();
	     TBL_SIRKET_SINIFListesi();
	 }
     #region TBL_SIRKET_GRUB
     private ObservableCollection<TBL_SIRKET_GRUB_MODEL> _TBL_SIRKET_GRUBlistesiCollection;
     public ObservableCollection<TBL_SIRKET_GRUB_MODEL> PropTBL_SIRKET_GRUBlistesiCollection
     {
         get { return _TBL_SIRKET_GRUBlistesiCollection; }
         set
         {
             _TBL_SIRKET_GRUBlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_SIRKET_GRUBlistesiCollection);
         }
     }
     private TBL_SIRKET_GRUB_MODEL _TBL_SIRKET_GRUB_MODELModel;
     public TBL_SIRKET_GRUB_MODEL SecilenTBL_SIRKET_GRUB_MODEL
     {
         get { return _TBL_SIRKET_GRUB_MODELModel; }
         set
         {
             _TBL_SIRKET_GRUB_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_SIRKET_GRUB_MODEL);
             this.Model.TBL_SIRKET_GRUB_ID = SecilenTBL_SIRKET_GRUB_MODEL.TBL_SIRKET_GRUB_ID;
         }
     }
     public async void TBL_SIRKET_GRUBListesi()
     {
         PropTBL_SIRKET_GRUBlistesiCollection = await serviceAgent.Listele__TBL_SIRKET_GRUB_MODEL();
     }
     #endregion
     #region TBL_SIRKET_TIPI
     private ObservableCollection<TBL_SIRKET_TIPI_MODEL> _TBL_SIRKET_TIPIlistesiCollection;
     public ObservableCollection<TBL_SIRKET_TIPI_MODEL> PropTBL_SIRKET_TIPIlistesiCollection
     {
         get { return _TBL_SIRKET_TIPIlistesiCollection; }
         set
         {
             _TBL_SIRKET_TIPIlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_SIRKET_TIPIlistesiCollection);
         }
     }
     private TBL_SIRKET_TIPI_MODEL _TBL_SIRKET_TIPI_MODELModel;
     public TBL_SIRKET_TIPI_MODEL SecilenTBL_SIRKET_TIPI_MODEL
     {
         get { return _TBL_SIRKET_TIPI_MODELModel; }
         set
         {
             _TBL_SIRKET_TIPI_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_SIRKET_TIPI_MODEL);
             this.Model.TBL_SIRKET_TIPI_ID = SecilenTBL_SIRKET_TIPI_MODEL.TBL_SIRKET_TIPI_ID;
         }
     }
     public async void TBL_SIRKET_TIPIListesi()
     {
         PropTBL_SIRKET_TIPIlistesiCollection = await serviceAgent.Listele__TBL_SIRKET_TIPI_MODEL();
     }
     #endregion
     #region TBL_SIRKET_SINIF
     private ObservableCollection<TBL_SIRKET_SINIF_MODEL> _TBL_SIRKET_SINIFlistesiCollection;
     public ObservableCollection<TBL_SIRKET_SINIF_MODEL> PropTBL_SIRKET_SINIFlistesiCollection
     {
         get { return _TBL_SIRKET_SINIFlistesiCollection; }
         set
         {
             _TBL_SIRKET_SINIFlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_SIRKET_SINIFlistesiCollection);
         }
     }
     private TBL_SIRKET_SINIF_MODEL _TBL_SIRKET_SINIF_MODELModel;
     public TBL_SIRKET_SINIF_MODEL SecilenTBL_SIRKET_SINIF_MODEL
     {
         get { return _TBL_SIRKET_SINIF_MODELModel; }
         set
         {
             _TBL_SIRKET_SINIF_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_SIRKET_SINIF_MODEL);
             this.Model.TBL_SIRKET_SINIF_ID = SecilenTBL_SIRKET_SINIF_MODEL.TBL_SIRKET_SINIF_ID;
         }
     }
     public async void TBL_SIRKET_SINIFListesi()
     {
         PropTBL_SIRKET_SINIFlistesiCollection = await serviceAgent.Listele__TBL_SIRKET_SINIF_MODEL();
     }
     #endregion

     //Sirketadi(k.TBL_SIRKET_ID),
     public String SirketGrupadi(int? id)
     {
         try
         {
             return PropTBL_SIRKET_GRUBlistesiCollection.Where(x => x.TBL_SIRKET_GRUB_ID == id).FirstOrDefault().SIRKET_GRUP_ADI;
         }
         catch (Exception)
         {


         }
         return null;
     }
     public String SirketSinifadi(int? id)
     {
         try
         {
             return PropTBL_SIRKET_SINIFlistesiCollection.Where(x => x.TBL_SIRKET_SINIF_ID == id).FirstOrDefault().SIRKET_SINIF_ADI;
         }
         catch (Exception)
         {


         }
         return null;
     }
     public String SirketTipfadi(int? id)
     {
         try
         {
             return PropTBL_SIRKET_TIPIlistesiCollection.Where(x => x.TBL_SIRKET_TIPI_ID == id).FirstOrDefault().SIRKET_TIPI_ADI;
         }
         catch (Exception)
         {


         }
         return null;
     }
	    public void RaporSirketListele()
	    {
            DataSet dataSet1 = new DataSet();
            dataSet1.DataSetName = "BankaListesiRapor";
            DataTable dataTable1 = new DataTable();

            dataSet1.Tables.Add(dataTable1);

            dataTable1.TableName = "Table";

            dataTable1.Columns.Add("ID", typeof(string));

            dataTable1.Columns.Add("GRUB ADI", typeof(string));

            dataTable1.Columns.Add("SINIF ADI", typeof(string));

            dataTable1.Columns.Add("TIP ADI", typeof(string));

            dataTable1.Columns.Add("ADI", typeof(string));

            dataTable1.Columns.Add("TELEFON_1", typeof(string));

            dataTable1.Columns.Add("TELEFON_2", typeof(string));

            dataTable1.Columns.Add("FAX_1", typeof(string));

            dataTable1.Columns.Add("FAX_2", typeof(string));

            dataTable1.Columns.Add("MAIL_1", typeof(string));

            dataTable1.Columns.Add("MAIL_2", typeof(string));

            dataTable1.Columns.Add("WEB_ADRES", typeof(string));

            dataTable1.Columns.Add("VERGI_DAIRESI", typeof(string));

            dataTable1.Columns.Add("VERGI_NO", typeof(string));

            dataTable1.Columns.Add("ADRES", typeof(string));

            dataTable1.Columns.Add("IL", typeof(string));

            dataTable1.Columns.Add("ILCE", typeof(string));

            dataTable1.Columns.Add("POSTA_KODU", typeof(string));

            dataTable1.Columns.Add("BANKA ADI", typeof(string));

            dataTable1.Columns.Add("BANKA_SUBE_ADI", typeof(string));

            dataTable1.Columns.Add("HESAP NO", typeof(string));

            dataTable1.Columns.Add("IBAN", typeof(string));

            dataTable1.Columns.Add("ACIKLAMA", typeof(string));

            dataTable1.Columns.Add("YEDEK", typeof(string));
	        foreach (var k in PropsýrketListe)
	        {
	            dataTable1.Rows.Add(new Object[]
	            {

	                k.TBL_SIRKET_ID,

	               SirketGrupadi(k.TBL_SIRKET_GRUB_ID) ,

	                SirketSinifadi(k.TBL_SIRKET_SINIF_ID),

	               SirketTipfadi(k.TBL_SIRKET_TIPI_ID) ,

	                k.SIRKET_ADI,

	                k.SIRKET_TELEFON_1,

	                k.SIRKET_TELEFON_2,

	                k.SIRKET_FAX_1,

	                k.SIRKET_FAX_2,

	                k.SIRKET_MAIL_1,

	                k.SIRKET_MAIL_2,

	                k.SIRKET_WEB_ADRES,

	                k.SIRKET_VERGI_DAIRESI,

	                k.SIRKET_VERGI_NO,

	                k.SIRKET_ADRES,

	                k.SIRKET_IL,

	                k.SIRKET_ILCE,

	                k.SIRKET_POSTA_KODU,

	                k.SIRKET_BANKA_ADI,

	                k.SIRKET_BANKA_SUBE_ADI,

	                k.SIRKET_HESAP_NO,

	                k.SIRKET_IBAN,

	                k.SIRKET_ACIKLAMA,

	                k.YEDEK,


	            });
	        }
             RaporSirketListesi report = new  RaporSirketListesi();
report.DataSource = dataSet1;
report.DataMember = dataTable1.TableName;
	 
//_tBL_SIRKET_ID
report.xrTableCell1.DataBindings.Add("Text", null, dataTable1.Columns[0].Caption);
report.xrLabel1.Text = dataTable1.Columns[0].ColumnName;

	 
//_tBL_SIRKET_GRUB_ID
report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[1].Caption);
report.xrLabel5.Text = dataTable1.Columns[1].ColumnName;

	 
//_tBL_SIRKET_SINIF_ID
report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[2].Caption);
report.xrLabel3.Text = dataTable1.Columns[2].ColumnName;

	 
//_tBL_SIRKET_TIPI_ID
report.xrTableCell4.DataBindings.Add("Text", null, dataTable1.Columns[3].Caption);
report.xrLabel4.Text = dataTable1.Columns[3].ColumnName;

	 
//_sIRKET_ADI
report.xrTableCell2.DataBindings.Add("Text", null, dataTable1.Columns[4].Caption);
report.xrLabel2.Text = dataTable1.Columns[4].ColumnName;

//_sIRKET_BANKA_ADI
report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[18].Caption);
report.xrLabel6.Text = dataTable1.Columns[18].ColumnName;

////_sIRKET_TELEFON_1
//report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[5].Caption);
//report.xrLabel6.Text = dataTable1.Columns[5].ColumnName;


////_sIRKET_TELEFON_2
//report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
//report.xrLabel7.Text = dataTable1.Columns[6].ColumnName;

//_sIRKET_HESAP_NO
report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[20].Caption);
report.xrLabel7.Text = dataTable1.Columns[20].ColumnName;


////_sIRKET_BANKA_SUBE_ADI
//report.xrTableCell20.DataBindings.Add("Text", null, dataTable1.Columns[19].Caption);
//report.xrLabel20.Text = dataTable1.Columns[19].ColumnName;


	 
////_sIRKET_FAX_1
//report.xrTableCell8.DataBindings.Add("Text", null, dataTable1.Columns[7].Caption);
//report.xrLabel8.Text = dataTable1.Columns[7].ColumnName;

	 
////_sIRKET_FAX_2
//report.xrTableCell9.DataBindings.Add("Text", null, dataTable1.Columns[8].Caption);
//report.xrLabel9.Text = dataTable1.Columns[8].ColumnName;

	 
////_sIRKET_MAIL_1
//report.xrTableCell10.DataBindings.Add("Text", null, dataTable1.Columns[9].Caption);
//report.xrLabel10.Text = dataTable1.Columns[9].ColumnName;

	 
////_sIRKET_MAIL_2
//report.xrTableCell11.DataBindings.Add("Text", null, dataTable1.Columns[10].Caption);
//report.xrLabel11.Text = dataTable1.Columns[10].ColumnName;

	 
////_sIRKET_WEB_ADRES
//report.xrTableCell12.DataBindings.Add("Text", null, dataTable1.Columns[11].Caption);
//report.xrLabel12.Text = dataTable1.Columns[11].ColumnName;

	 
////_sIRKET_VERGI_DAIRESI
//report.xrTableCell13.DataBindings.Add("Text", null, dataTable1.Columns[12].Caption);
//report.xrLabel13.Text = dataTable1.Columns[12].ColumnName;

	 
////_sIRKET_VERGI_NO
//report.xrTableCell14.DataBindings.Add("Text", null, dataTable1.Columns[13].Caption);
//report.xrLabel14.Text = dataTable1.Columns[13].ColumnName;

	 
////_sIRKET_ADRES
//report.xrTableCell15.DataBindings.Add("Text", null, dataTable1.Columns[14].Caption);
//report.xrLabel15.Text = dataTable1.Columns[14].ColumnName;

	 
////_sIRKET_IL
//report.xrTableCell16.DataBindings.Add("Text", null, dataTable1.Columns[15].Caption);
//report.xrLabel16.Text = dataTable1.Columns[15].ColumnName;

	 
////_sIRKET_ILCE
//report.xrTableCell17.DataBindings.Add("Text", null, dataTable1.Columns[16].Caption);
//report.xrLabel17.Text = dataTable1.Columns[16].ColumnName;

	 
////_sIRKET_POSTA_KODU
//report.xrTableCell18.DataBindings.Add("Text", null, dataTable1.Columns[17].Caption);
//report.xrLabel18.Text = dataTable1.Columns[17].ColumnName;

	 
////_sIRKET_BANKA_ADI
//report.xrTableCell19.DataBindings.Add("Text", null, dataTable1.Columns[18].Caption);
//report.xrLabel19.Text = dataTable1.Columns[18].ColumnName;

	 
////_sIRKET_BANKA_SUBE_ADI
//report.xrTableCell20.DataBindings.Add("Text", null, dataTable1.Columns[19].Caption);
//report.xrLabel20.Text = dataTable1.Columns[19].ColumnName;

	 
////_sIRKET_HESAP_NO
//report.xrTableCell21.DataBindings.Add("Text", null, dataTable1.Columns[20].Caption);
//report.xrLabel21.Text = dataTable1.Columns[20].ColumnName;

	 
////_sIRKET_IBAN
//report.xrTableCell22.DataBindings.Add("Text", null, dataTable1.Columns[21].Caption);
//report.xrLabel22.Text = dataTable1.Columns[21].ColumnName;

	 
////_sIRKET_ACIKLAMA
//report.xrTableCell23.DataBindings.Add("Text", null, dataTable1.Columns[22].Caption);
//report.xrLabel23.Text = dataTable1.Columns[22].ColumnName;

	 
////_yEDEK
//report.xrTableCell24.DataBindings.Add("Text", null, dataTable1.Columns[23].Caption);
//report.xrLabel24.Text = dataTable1.Columns[23].ColumnName;

RaporSayfasi pencere = new RaporSayfasi();


pencere.Preview.Model = new XtraReportPreviewModel(report);
report.CreateDocument(true);



pencere.ShowDialog();

 
 //report.ShowPreviewDialog();

	    }
	}
}
