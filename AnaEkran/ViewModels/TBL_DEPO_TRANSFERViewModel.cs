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
using AnaEkran.Views.Raporlar.Depo;
using Zinde.Xpf.Printing;
using Zinde.XtraReports.UI;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_DEPO_TRANSFERViewModel  : ViewModelDetailBase<TBL_DEPO_TRANSFERViewModel, TBL_DEPO_TRANSFER_MODEL> 
    {
	  
		
	 public void Baslangic()
	 {
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
     public TBL_DEPO_MODEL SecilenTblDepoModeldepoTransferNereden
     {
         get { return _TBL_DEPO_MODELModel; }
         set
         {
             _TBL_DEPO_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTblDepoModeldepoTransferNereden);
             this.Model.DEPO_TRANSFER_NEREDEN = SecilenTblDepoModeldepoTransferNereden.TBL_DEPO_ID.ToString();
         }
     }
     private TBL_DEPO_MODEL _TBL_DEPO_MODELNereye;
     public TBL_DEPO_MODEL SecilenTblDepoModelNereye
     {
         get { return _TBL_DEPO_MODELNereye; }
         set
         {
             _TBL_DEPO_MODELNereye = value;
             NotifyPropertyChanged(m => m.SecilenTblDepoModelNereye);
             this.Model.DEPO_TRANSFER_NEREYE = SecilenTblDepoModelNereye.TBL_DEPO_ID.ToString();
         }
     }

     public async void TBL_DEPOListesi()
     {
         PropTBL_DEPOlistesiCollection = await serviceAgent.Listele__TBL_DEPO_MODEL();
     }

        
     #endregion

        #region Transfer Ýþlemi

	    public async void DepoTransferUrunEtkisi()
	    {
	        try
	        {
                //nereden
                TBL_DEPO_ISLEM_MODEL depoIslem = new TBL_DEPO_ISLEM_MODEL();
                depoIslem.DEPO_ISLEM_ADI = Model.DEPO_TRANSFER_ADI;
                depoIslem.TBL_DEPO_ID = Convert.ToInt32(model.DEPO_TRANSFER_NEREDEN);
                depoIslem.TBL_URUN_ID = Model.TBL_URUN_ID;
                depoIslem.URUN_MIKTAR = "-" + Model.DEPO_TRANSFER_ACIKLAMA;
                depoIslem.ACIKLAMA = model.DEPO_TRANSFER_NEREDEN + " den " + model.DEPO_TRANSFER_NEREYE +
                                     "'e  transfer iþlemi";
	           await serviceAgent.Ekle__TBL_DEPO_ISLEM_MODEL(depoIslem);

	        }
	        catch (Exception)
	        {

	            MessageBox.Show("Hata Oluþtu Ýþlemi Kontrol ediniz");
	       
	        }

	        try
	        {

                //nereye
                TBL_DEPO_ISLEM_MODEL depoIslemnereye = new TBL_DEPO_ISLEM_MODEL();
                depoIslemnereye.DEPO_ISLEM_ADI = Model.DEPO_TRANSFER_ADI;
                depoIslemnereye.TBL_DEPO_ID = Convert.ToInt32(model.DEPO_TRANSFER_NEREYE);
                depoIslemnereye.TBL_URUN_ID = Model.TBL_URUN_ID;
                depoIslemnereye.URUN_MIKTAR = Model.DEPO_TRANSFER_ACIKLAMA;
                depoIslemnereye.ACIKLAMA = model.DEPO_TRANSFER_NEREDEN + " den " + model.DEPO_TRANSFER_NEREYE +
                                     "'e  transfer iþlemi";
                await serviceAgent.Ekle__TBL_DEPO_ISLEM_MODEL(depoIslemnereye);
	        }
	        catch (Exception)
	        {
                MessageBox.Show("Hata Oluþtu Ýþlemi Kontrol ediniz");
	            
	        }

	    }
        #endregion

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
	    public void RaporTransferListele()
	    {
	        try
	        {
                DataSet dataSet1 = new DataSet();
                dataSet1.DataSetName = "BankaListesiRapor";
                DataTable dataTable1 = new DataTable();

                dataSet1.Tables.Add(dataTable1);

                dataTable1.TableName = "Table";

                dataTable1.Columns.Add("ID", typeof(string));

                dataTable1.Columns.Add("TRANSFER_ADI", typeof(string));

                dataTable1.Columns.Add("TARIH", typeof(string));

                dataTable1.Columns.Add("NEREDEN", typeof(string));

                dataTable1.Columns.Add("NEREYE", typeof(string));

                dataTable1.Columns.Add("URUN_ADI", typeof(string));

                dataTable1.Columns.Add("DEPO_TRANSFER_ACIKLAMA", typeof(string));

                dataTable1.Columns.Add("YEDEK", typeof(string));
                foreach (var k in Propdepo_transferListe)
                {
                    dataTable1.Rows.Add(new Object[]
	            {

	                k.TBL_DEPO_TRANSFER_ID,

	                k.DEPO_TRANSFER_ADI,

	                k.DEPO_TRANSFER_TARIHI,

	              Depoadi(Convert.ToInt32( k.DEPO_TRANSFER_NEREDEN)) ,

	                Depoadi(Convert.ToInt32( k.DEPO_TRANSFER_NEREYE)),

	              urunadi(k.TBL_URUN_ID)  ,

	                k.DEPO_TRANSFER_ACIKLAMA,

	                k.YEDEK,


	            });
                }
                Rapordepo_transfer report = new Rapordepo_transfer();
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


                report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[4].Caption);
                report.xrLabel5.Text = dataTable1.Columns[4].ColumnName;


                report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[5].Caption);
                report.xrLabel6.Text = dataTable1.Columns[5].ColumnName;


                //report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
                //report.xrLabel7.Text = dataTable1.Columns[6].ColumnName;


                //report.xrTableCell8.DataBindings.Add("Text", null, dataTable1.Columns[7].Caption);
                //report.xrLabel8.Text = dataTable1.Columns[7].ColumnName;


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
