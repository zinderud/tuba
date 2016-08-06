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
using System.Windows;
using System.Windows.Input;
using AnaEkran.Provider;
using System.Collections.ObjectModel;
using AnaEkran.Views.Raporlar;
using AnaEkran.Views.Raporlar.Kasa;
using Zinde.Xpf.Printing;
using Zinde.XtraReports.UI;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_KASA_BAKIYEViewModel  : ViewModelDetailBase<TBL_KASA_BAKIYEViewModel, TBL_KASA_BAKIYE_MODEL> 
    {
	  
		
	 public void Baslangic()
	 {
	     TBL_KASAListesi();
	     TBL_PARA_TIPIListesi();
	     TBL_FISListesi();
	 }

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
     private TBL_KASA_MODEL _TBL_KASA_MODELModel;
     public TBL_KASA_MODEL SecilenTBL_KASA_MODEL
     {
         get { return _TBL_KASA_MODELModel; }
         set
         {
             _TBL_KASA_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_KASA_MODEL);
             this.Model.TBL_KASA_ID = SecilenTBL_KASA_MODEL.TBL_KASA_ID;
         }
     }
     public async void TBL_KASAListesi()
     {
         PropTBL_KASAlistesiCollection = await serviceAgent.Listele__TBL_KASA_MODEL();
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


     #region KasaPara iliþkisi

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
     public async void KasaParaIliskisiListele()
     {
         _grupToplamModels = new ObservableCollection<GrupToplamModel>();
         //var deneme = from k in Propurun_stokListe
         //    group k by k.TBL_URUN_ID
         //    into g
         //    select new {urunid=g,adet=


         //        g.Key};

         var model1=Propkasa_bakýyeListe  = await serviceAgent.Listele__TBL_KASA_BAKIYE_MODEL();

         var listeler = from detay in model1
                        group detay by detay.TBL_KASA_ID
                            into Grup
                            select new
                            {
                                toplam = Grup.Sum(k => Convert.ToDouble(k.TUTAR)),

                                TBL_KASA_ID = Grup.Key.ToString()
                            };
         foreach (var k in listeler)
         {
             _grupToplamModels.Add(new GrupToplamModel() { Toplam = k.toplam.ToString(), Gruplanan = k.TBL_KASA_ID });
         }
         GrupToplamModel = _grupToplamModels;
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




     public void RaporKasaParaListele()
        {
            try
            {
                DataSet dataSet1 = new DataSet();
                dataSet1.DataSetName = "RaporKasaParaListele";
                DataTable dataTable1 = new DataTable();

                dataSet1.Tables.Add(dataTable1);

                dataTable1.TableName = "Table";

                dataTable1.Columns.Add("Kasa Adý", typeof(string));

                dataTable1.Columns.Add("Toplam", typeof(string));


                foreach (var k in GrupToplamModel)
                {
                    dataTable1.Rows.Add(new Object[]
	            {
	               Kasaadi(Convert.ToInt32(k.Gruplanan))   , k.Toplam
	            });
                }
                RaporKasaParaListele report = new RaporKasaParaListele();
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
	    public void RaporKasaBakiyeListele()
	    {
	        try
	        {
                DataSet dataSet1 = new DataSet();
                dataSet1.DataSetName = "KasaListesiRapor";
                DataTable dataTable1 = new DataTable();

                dataSet1.Tables.Add(dataTable1);

                dataTable1.TableName = "Table";

                dataTable1.Columns.Add("ID", typeof(string));

                dataTable1.Columns.Add("KASA_ADI", typeof(string));

                dataTable1.Columns.Add("PARA_TIPI", typeof(string));

                dataTable1.Columns.Add("FIS_ID", typeof(string));

                dataTable1.Columns.Add("KUR", typeof(string));

                dataTable1.Columns.Add("TARIH", typeof(string));

                dataTable1.Columns.Add("TUTAR", typeof(string));

                dataTable1.Columns.Add("ACIKLAMA", typeof(string));

                dataTable1.Columns.Add("YEDEK", typeof(string));
	            foreach (var k in Propkasa_bakýyeListe)
	            {
	                dataTable1.Rows.Add(new Object[]
	                {

	                    k.TBL_KASA_BAKIYE_ID,

	                    Kasaadi(k.TBL_KASA_ID),

	                   pARAadi( k.TBL_PARA_TIPI_ID),

	                    k.TBL_FIS_ID,

	                    k.KUR,

	                    k.TARIH,

	                    k.TUTAR,

	                    k.ACIKLAMA,

	                    k.YEDEK,


	                });
	            }
                 RaporKasaBakiye report = new  RaporKasaBakiye();
                 report.DataSource = dataSet1;
                 report.DataMember = dataTable1.TableName;

                 report.xrTableCell1.DataBindings.Add("Text", null, dataTable1.Columns[0].Caption);
                 report.xrLabel1.Text = dataTable1.Columns[0].ColumnName;


                 report.xrTableCell2.DataBindings.Add("Text", null, dataTable1.Columns[1].Caption);
                 report.xrLabel2.Text = dataTable1.Columns[1].ColumnName;


                 report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[2].Caption);
                 report.xrLabel3.Text = dataTable1.Columns[2].ColumnName;


                 report.xrTableCell4.DataBindings.Add("Text", null, dataTable1.Columns[5].Caption);
                 report.xrLabel4.Text = dataTable1.Columns[5].ColumnName;


                 report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
                 report.xrLabel5.Text = dataTable1.Columns[6].ColumnName;


                 report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[7].Caption);
                 report.xrLabel6.Text = dataTable1.Columns[7].ColumnName;


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
	            
	            
	        }
	    }
	}
}
